using iText.Commons.Actions.Contexts;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
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
using iText.Layout;
using iText.IO.Image;
using iText.StyledXmlParser.Jsoup.Nodes;
using Microsoft.EntityFrameworkCore;

namespace Proyecto_dAE_DATABASE
{
    public partial class Reportes : Form
    {
        BodegaContext contexto = new BodegaContext();
        public Reportes()
        {
            InitializeComponent();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            string pdfPath = "ReporteArticulosPrestados.pdf";
            var ordenSeleccionado = cmbR1.SelectedItem.ToString();
            var prestamos = contexto.DetallePrestamos
                .Join(contexto.Prestamos, dp => dp.IdPrestamo, p => p.IdPrestamo, (dp, p) => new { DetallePrestamo = dp, Prestamo = p })
                .Join(contexto.Implementos, dpp => dpp.DetallePrestamo.IdImplemento, i => i.IdImplemento, (dpp, i) => new { DetallePrestamoPrestamo = dpp, Implemento = i })
                .Join(contexto.Deportes, dppi => dppi.Implemento.IdDeporte, d => d.IdDeporte, (dppi, d) => new { DetallePrestamoPrestamoImplemento = dppi, Deporte = d })
                .Join(contexto.Usuarios, dppid => dppid.DetallePrestamoPrestamoImplemento.DetallePrestamoPrestamo.Prestamo.IdReceptor, u => u.IdUsuario, (dppid, u) => new
                {
                    Implemento = dppid.DetallePrestamoPrestamoImplemento.Implemento.Tipo,
                    CantidadPrestada = dppid.DetallePrestamoPrestamoImplemento.DetallePrestamoPrestamo.DetallePrestamo.CantidadPrestada,
                    FechaPrestamo = dppid.DetallePrestamoPrestamoImplemento.DetallePrestamoPrestamo.Prestamo.FechaPrestamo, // Fecha de Préstamo
                    FechaDevolucion = dppid.DetallePrestamoPrestamoImplemento.DetallePrestamoPrestamo.Prestamo.FechaDevolucion,
                    Deporte = dppid.Deporte.NombreDeporte,
                    Usuario = u.NombreUsuario
                });


            switch (cmbR1.SelectedIndex)
            {
                case 0:
                    prestamos = prestamos.OrderBy(p => p.Usuario);
                    break;
                case 1:
                    prestamos = prestamos.OrderBy(p => p.FechaDevolucion);
                    break;
                case 2:
                    prestamos = prestamos.OrderBy(p => p.Deporte);
                    break;
                default:
                    MessageBox.Show("Por favor selecciona una opción de orden.");
                    return;
            }


            var listaPrestamos = prestamos.ToList();


            using (PdfWriter writer = new PdfWriter(pdfPath))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    iText.Layout.Document documento = new iText.Layout.Document(pdf);


                    documento.Add(new Paragraph("REPORTE DE ARTÍCULOS PRESTADOS").SetFontSize(20).SetTextAlignment(TextAlignment.CENTER));
                    documento.Add(new Paragraph("Listado de artículos ordenados por " + ordenSeleccionado).SetFontSize(12).SetTextAlignment(TextAlignment.CENTER));
                    documento.Add(new Paragraph("\n"));

                    Table tabla = new Table(6);
                    tabla.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                    tabla.SetFontSize(10);

                    tabla.AddHeaderCell("Implemento");
                    tabla.AddHeaderCell("Cantidad Prestada");
                    tabla.AddHeaderCell("Fecha de Préstamo");
                    tabla.AddHeaderCell("Fecha de Devolución");
                    tabla.AddHeaderCell("Deporte");
                    tabla.AddHeaderCell("Usuario");


                    foreach (var item in listaPrestamos)
                    {
                        tabla.AddCell(new Paragraph(item.Implemento));
                        tabla.AddCell(new Paragraph(item.CantidadPrestada.ToString()));
                        tabla.AddCell(new Paragraph(item.FechaPrestamo.ToString("yyyy-MM-dd")));
                        tabla.AddCell(new Paragraph(item.FechaDevolucion.ToString("yyyy-MM-dd")));
                        tabla.AddCell(new Paragraph(item.Deporte));
                        tabla.AddCell(new Paragraph(item.Usuario));
                    }


                    documento.Add(tabla);


                    documento.Add(new Paragraph("\n\nFecha del reporte: " + DateTime.Now).SetTextAlignment(TextAlignment.RIGHT).SetFontSize(10));


                    documento.Close();
                }
            }


            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = pdfPath,
                UseShellExecute = true
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {

                string pdfPath = "ReportePrestamos.pdf";


                using (PdfWriter writer = new PdfWriter(pdfPath))
                {
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        iText.Layout.Document documento = new iText.Layout.Document(pdf);

                        documento.Add(new Paragraph("REPORTE DE PRÉSTAMOS DE IMPLEMENTOS").SetFontSize(20).SetTextAlignment(TextAlignment.CENTER));
                        documento.Add(new Paragraph("Listado de usuarios con implementos en préstamo").SetFontSize(12).SetTextAlignment(TextAlignment.CENTER));
                        documento.Add(new Paragraph("\n"));


                        Table tabla = new Table(6);
                        tabla.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                        tabla.SetFontSize(10);


                        tabla.AddHeaderCell("Usuario");
                        tabla.AddHeaderCell("Carné Biblioteca");
                        tabla.AddHeaderCell("Implemento");
                        tabla.AddHeaderCell("Cantidad Prestada");
                        tabla.AddHeaderCell("Fecha Préstamo");
                        tabla.AddHeaderCell("Fecha Devolución");


                        var prestamos = contexto.Prestamos
                            .Join(contexto.Usuarios, p => p.IdReceptor, u => u.IdUsuario, (p, u) => new { p, u })
                            .Join(contexto.DetallePrestamos, pu => pu.p.IdEncargadoPrestamo, dp => dp.IdPrestamo, (pu, dp) => new { pu, dp })
                            .Join(contexto.Implementos, pudp => pudp.dp.IdImplemento, i => i.IdImplemento, (pudp, i) => new
                            {
                                Usuario = pudp.pu.u.NombreUsuario,
                                CarneBiblioteca = pudp.pu.u.CarneBiblioteca,
                                Implemento = i.Tipo,
                                CantidadPrestada = pudp.dp.CantidadPrestada,
                                FechaPrestamo = pudp.pu.p.FechaPrestamo,
                                FechaDevolucion = pudp.pu.p.FechaDevolucion
                            })
                            .ToList();


                        foreach (var item in prestamos)
                        {
                            tabla.AddCell(new Paragraph(item.Usuario));
                            tabla.AddCell(new Paragraph(item.CarneBiblioteca.ToString()));
                            tabla.AddCell(new Paragraph(item.Implemento));
                            tabla.AddCell(new Paragraph(item.CantidadPrestada.ToString()));
                            tabla.AddCell(new Paragraph(item.FechaPrestamo.ToString("yyyy-MM-dd")));
                            tabla.AddCell(new Paragraph(item.FechaDevolucion.ToString("yyyy-MM-dd")));
                        }

                        documento.Add(tabla);

                        documento.Add(new Paragraph("\n\nFecha del reporte: " + DateTime.Now).SetTextAlignment(TextAlignment.RIGHT).SetFontSize(10));

                        documento.Close();
                    }
                }

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = pdfPath,
                    UseShellExecute = true
                });
            }
        }

        private void btnReportesIII_Click(object sender, EventArgs e)
        {
            string pdfPath = "ReporteDeBajas.pdf";


            using (PdfWriter writer = new PdfWriter(pdfPath))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    iText.Layout.Document documento = new iText.Layout.Document(pdf);


                    documento.Add(new Paragraph("REPORTE DE IMPLEMENTOS DADOS DE BAJA").SetFontSize(20).SetTextAlignment(TextAlignment.CENTER));
                    documento.Add(new Paragraph("Listado de implementos en orden alfabético con los datos de la persona responsable").SetFontSize(12).SetTextAlignment(TextAlignment.CENTER));
                    documento.Add(new Paragraph("\n"));


                    Table tabla = new Table(6);
                    tabla.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                    tabla.SetFontSize(10);


                    tabla.AddHeaderCell("Implemento");
                    tabla.AddHeaderCell("Cantidad");
                    tabla.AddHeaderCell("Razón de Baja");
                    tabla.AddHeaderCell("Usuario Responsable");
                    tabla.AddHeaderCell("Carné");
                    tabla.AddHeaderCell("Fecha de Baja");


                    var bajas = contexto.DeBajas
                        .Join(contexto.Implementos, db => db.IdImplemento, i => i.IdImplemento, (db, i) => new { db, i })
                        .Join(contexto.Razones, dbi => dbi.db.IdRazon, r => r.IdRazon, (dbi, r) => new { dbi, r })
                        .Join(contexto.Usuarios, dbir => dbir.dbi.db.IdUsuarioResponsable, u => u.IdUsuario, (dbir, u) => new
                        {
                            Implemento = dbir.dbi.i.Tipo,
                            Cantidad = dbir.dbi.db.Cantidad,
                            Razon = dbir.r.NombreRazon,
                            UsuarioResponsable = u.NombreUsuario,
                            CarneBiblioteca = u.CarneBiblioteca,
                            FechaDeBaja = dbir.dbi.db.FechaDeBaja
                        })
                        .OrderBy(b => b.Implemento)
                        .ToList();


                    foreach (var item in bajas)
                    {
                        tabla.AddCell(new Paragraph(item.Implemento));
                        tabla.AddCell(new Paragraph(item.Cantidad.ToString()));
                        tabla.AddCell(new Paragraph(item.Razon));
                        tabla.AddCell(new Paragraph(item.UsuarioResponsable));
                        tabla.AddCell(new Paragraph(item.CarneBiblioteca.ToString()));
                        tabla.AddCell(new Paragraph(item.FechaDeBaja.ToString("yyyy-MM-dd")));
                    }


                    documento.Add(tabla);

                    documento.Add(new Paragraph("\n\nFecha del reporte: " + DateTime.Now).SetTextAlignment(TextAlignment.RIGHT).SetFontSize(10));

                    documento.Close();
                }
            }

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = pdfPath,
                UseShellExecute = true
            });
        }
    }
}
