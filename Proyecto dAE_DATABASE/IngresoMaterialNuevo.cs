using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_dAE_DATABASE.Modelo;
//using para utilizar iText
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.IO.Image;
using iText.StyledXmlParser.Jsoup.Nodes;
using Microsoft.EntityFrameworkCore;

namespace Proyecto_dAE_DATABASE
{
    public partial class IngresoMaterialNuevo : Form
    {
        BodegaContext contexto = new BodegaContext();
        public IngresoMaterialNuevo()
        {
            InitializeComponent();
            CargarGrid();
            CargarImplementos();
            // Ajustar dinámicamente los límites de los NumericUpDown
            nudFactura.Maximum = 10000;
            nudImplemento.Maximum = 10000;
            nudCantidad.Maximum = 10000;
        }

        private void CargarGrid()
        {
            using (var context = new BodegaContext())
            {
                var ingresos = context.IngresoMaterials
                    .Select(im => new
                    {
                        im.NumFactura,
                        im.IdImplemento,
                        im.Cantidad,
                        im.Descripcion,
                        im.Fecha
                    })
                    .ToList();

                dataGridView1.DataSource = ingresos;
            }
        }

        private void CargarImplementos()
        {
            using (var context = new BodegaContext())
            {
                // Obtener los IDs de implementos existentes
                var idsImplementos = context.Implementos.Select(i => i.IdImplemento).ToList();

                if (idsImplementos.Any())
                {
                    // Establecer el rango de valores del NumericUpDown
                    nudImplemento.Minimum = idsImplementos.Min();
                    nudImplemento.Maximum = idsImplementos.Max();
                }
                else
                {
                    // Si no hay implementos, deshabilitar el NumericUpDown
                    nudImplemento.Minimum = 0;
                    nudImplemento.Maximum = 0;
                    nudImplemento.Enabled = false;

                    MessageBox.Show("No hay implementos disponibles en la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var filaSeleccionada = dataGridView1.SelectedRows[0];

                decimal numFactura = Convert.ToDecimal(filaSeleccionada.Cells["NumFactura"].Value);
                decimal idImplemento = Convert.ToDecimal(filaSeleccionada.Cells["IdImplemento"].Value);
                decimal cantidad = Convert.ToDecimal(filaSeleccionada.Cells["Cantidad"].Value);

                nudFactura.Value = numFactura;
                nudImplemento.Value = idImplemento;
                nudCantidad.Value = cantidad;

                using (var context = new BodegaContext())
                {
                    var ingreso = context.IngresoMaterials
                        .Include(im => im.IdImplementoNavigation)
                        .ThenInclude(i => i.IdDeporteNavigation)
                        .FirstOrDefault(im => im.NumFactura == (int)numFactura);

                    if (ingreso != null)
                    {
                        txtbImplemento.Text = ingreso.IdImplementoNavigation?.Tipo ?? "N/A";
                        txtbDeporte.Text = ingreso.IdImplementoNavigation?.IdDeporteNavigation?.NombreDeporte ?? "N/A";
                        rtbDescripcion.Text = ingreso.Descripcion ?? ""; // Cargar la descripción en el RichTextBox
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string parametro = cmbParametro.SelectedItem.ToString();
            string busqueda = txtbBusqueda.Text;

            using (var context = new BodegaContext())
            {
                var query = context.IngresoMaterials.AsQueryable();

                switch (parametro)
                {
                    case "Número de Factura":
                        if (int.TryParse(busqueda, out int numFactura))
                            query = query.Where(im => im.NumFactura == numFactura);
                        break;
                    case "ID del Implemento":
                        if (int.TryParse(busqueda, out int idImplemento))
                            query = query.Where(im => im.IdImplemento == idImplemento);
                        break;
                }

                dataGridView1.DataSource = query
                    .Select(im => new
                    {
                        im.NumFactura,
                        im.IdImplemento,
                        im.Cantidad,
                        im.Descripcion,
                        im.Fecha
                    })
                    .ToList();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int idImplemento = (int)nudImplemento.Value;
            int numFactura = (int)nudFactura.Value;
            int cantidad = (int)nudCantidad.Value;
            string descripcion = rtbDescripcion.Text; // Obtener la descripción del RichTextBox

            using (var context = new BodegaContext())
            {
                var implemento = context.Implementos.Find(idImplemento);

                // Verificar si el número de factura ya existe
                bool existe = context.IngresoMaterials.Any(im => im.NumFactura == numFactura);
                if (existe)
                {
                    MessageBox.Show($"El número de factura {numFactura} ya existe. Introduce uno diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (implemento == null)
                {
                    MessageBox.Show("El implemento no existe.");
                    return;
                }

                // Agregar el registro en IngresoMaterial
                var nuevoIngreso = new IngresoMaterial
                {
                    NumFactura = numFactura,
                    IdImplemento = idImplemento,
                    Cantidad = cantidad,
                    Descripcion = descripcion, // Guardar la descripción ingresada
                    Fecha = DateOnly.FromDateTime(DateTime.Now)
                };
                context.IngresoMaterials.Add(nuevoIngreso);

                // Actualizar cantidad en Implemento
                implemento.Cantidad += cantidad;

                context.SaveChanges();
                MessageBox.Show("Material agregado exitosamente.");

                // Recargar el DataGridView
                CargarGrid();

                // Limpiar el RichTextBox después de agregar
                rtbDescripcion.Clear();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int numFactura = (int)nudFactura.Value;

            using (var context = new BodegaContext())
            {
                var ingreso = context.IngresoMaterials.Find(numFactura);
                if (ingreso == null)
                {
                    MessageBox.Show("El registro no existe.");
                    return;
                }

                int? idImplementoNullable = ingreso.IdImplemento;
                int? cantidadNullable = ingreso.Cantidad;

                if (idImplementoNullable.HasValue && cantidadNullable.HasValue)
                {
                    int idImplemento = idImplementoNullable.Value;
                    int cantidad = cantidadNullable.Value;

                    ingreso.IdImplemento = (int)nudImplemento.Value;
                    ingreso.Cantidad = (int)nudCantidad.Value;
                    ingreso.Descripcion = rtbDescripcion.Text; // Actualizar la descripción
                    ingreso.Fecha = DateOnly.FromDateTime(DateTime.Now);

                    var implemento = context.Implementos.FirstOrDefault(i => i.IdImplemento == idImplemento);
                    if (implemento != null)
                    {
                        implemento.Cantidad -= (cantidad - (int)nudCantidad.Value);
                    }

                    context.SaveChanges();

                    MessageBox.Show("Registro modificado exitosamente.");
                    CargarGrid();
                }
                else
                {
                    MessageBox.Show("No se pudo obtener la cantidad o el implemento.");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int numFactura = (int)nudFactura.Value;

            using (var context = new BodegaContext())
            {
                var ingreso = context.IngresoMaterials.Find(numFactura);
                if (ingreso == null)
                {
                    MessageBox.Show("El registro no existe.");
                    return;
                }

                // Obtener el IdImplemento y la cantidad del registro
                int? idImplementoNullable = ingreso.IdImplemento; // Usamos int? para permitir valores null
                int? cantidadNullable = ingreso.Cantidad; // Usamos int? para permitir valores null

                if (idImplementoNullable.HasValue && cantidadNullable.HasValue)
                {
                    int idImplemento = idImplementoNullable.Value;
                    int cantidad = cantidadNullable.Value;

                    // Actualizar la cantidad en la tabla Implementos
                    var implemento = context.Implementos.FirstOrDefault(i => i.IdImplemento == idImplemento);
                    if (implemento != null)
                    {
                        implemento.Cantidad -= cantidad;  // Restamos la cantidad eliminada
                        context.SaveChanges();
                    }

                    // Eliminar el registro de IngresoMaterial
                    context.IngresoMaterials.Remove(ingreso);
                    context.SaveChanges();

                    MessageBox.Show("Registro eliminado exitosamente.");

                    // Recargar el DataGridView
                    CargarGrid();
                }
                else
                {
                    MessageBox.Show("No se pudo obtener la cantidad o el implemento.");
                }
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var filaSeleccionada = dataGridView1.SelectedRows[0];
                    int numFactura = Convert.ToInt32(filaSeleccionada.Cells["NumFactura"].Value);

                    using (var context = new BodegaContext())
                    {
                        var ingreso = context.IngresoMaterials
                            .Include(im => im.IdImplementoNavigation)
                            .ThenInclude(i => i.IdDeporteNavigation)
                            .FirstOrDefault(im => im.NumFactura == numFactura);

                        if (ingreso == null)
                        {
                            MessageBox.Show("No se pudo encontrar el registro en la base de datos.");
                            return;
                        }

                        string implemento = ingreso.IdImplementoNavigation?.Tipo ?? "N/A";
                        string deporte = ingreso.IdImplementoNavigation?.IdDeporteNavigation?.NombreDeporte ?? "N/A";
                        int cantidad = ingreso.Cantidad ?? 0;
                        string descripcion = ingreso.Descripcion ?? "Sin descripción";
                        string fecha = ingreso.Fecha.HasValue ? ingreso.Fecha.Value.ToString("dd/MM/yyyy") : "Sin fecha";

                        string pdfPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"Factura_NumFactura_{numFactura}.pdf");

                        using (PdfWriter writer = new PdfWriter(pdfPath))
                        {
                            using (PdfDocument pdf = new PdfDocument(writer))
                            {
                                iText.Layout.Document documento = new iText.Layout.Document(pdf);

                                string logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img", "logo.jpeg");
                                if (File.Exists(logoPath))
                                {
                                    var logo = new iText.Layout.Element.Image(ImageDataFactory.Create(logoPath))
                                        .SetWidth(100)
                                        .SetHeight(50)
                                        .SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.LEFT);
                                    documento.Add(logo);
                                }

                                documento.Add(new Paragraph("\nFACTURA").SetFontSize(20).SetTextAlignment(TextAlignment.CENTER));
                                documento.Add(new Paragraph($"Número de Factura: {numFactura}\n").SetFontSize(12));

                                Table tabla = new Table(2).UseAllAvailableWidth();
                                tabla.AddCell("Implemento:");
                                tabla.AddCell(implemento);
                                tabla.AddCell("Deporte:");
                                tabla.AddCell(deporte);
                                tabla.AddCell("Cantidad:");
                                tabla.AddCell(cantidad.ToString());
                                tabla.AddCell("Descripción:");
                                tabla.AddCell(descripcion);
                                tabla.AddCell("Fecha:");
                                tabla.AddCell(fecha);
                                documento.Add(tabla);

                                documento.Add(new Paragraph("\n\n").SetFontSize(12));
                                documento.Add(new Paragraph($"Fecha de emisión: {DateTime.Now:dd/MM/yyyy}")
                                    .SetFontSize(10)
                                    .SetTextAlignment(TextAlignment.RIGHT));

                                documento.Close();
                            }
                        }

                        if (File.Exists(pdfPath))
                        {
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                            {
                                FileName = pdfPath,
                                UseShellExecute = true
                            });
                        }
                        else
                        {
                            MessageBox.Show("El archivo PDF no se pudo generar.");
                        }

                        MessageBox.Show("Factura generada exitosamente.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un registro en el DataGridView.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void nudImplemento_ValueChanged(object sender, EventArgs e)
        {
            int idImplementoSeleccionado = (int)nudImplemento.Value;

            using (var context = new BodegaContext())
            {
                // Buscar el implemento en la base de datos
                var implemento = context.Implementos
                    .Include(i => i.IdDeporteNavigation) // Incluir relación con deporte
                    .FirstOrDefault(i => i.IdImplemento == idImplementoSeleccionado);

                if (implemento != null)
                {
                    // Mostrar nombre y deporte del implemento
                    txtbImplemento.Text = implemento.Tipo;
                    txtbDeporte.Text = implemento.IdDeporteNavigation?.NombreDeporte ?? "Sin deporte asignado";
                }
                else
                {
                    // Si no se encuentra, limpiar los campos
                    txtbImplemento.Clear();
                    txtbDeporte.Clear();
                }
            }
        }
    }
}
