using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutoCostos
{
    public partial class Dupont : Form
    {
        public Dupont()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtBox.Text = openFileDialog1.FileName;
            leeCsv(txtBox.Text);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void leeCsv(string path)
        {
            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(path);
            if (lines.Length > 0)
            {
                string firstLine = lines[0];
                string[] header = firstLine.Split(';');
                foreach (string headerWord in header)
                {
                    dt.Columns.Add(new DataColumn(headerWord));

                }
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] data = lines[i].Split(';');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    try
                    {
                        foreach (string headerWord in header)
                        {
                            dr[headerWord] = data[columnIndex++];
                        }
                        dt.Rows.Add(dr);
                    }
                    catch (IndexOutOfRangeException)
                    {
                        System.Console.WriteLine("Error: la matriz se excede...");
                    }
                }
            }

            if (dt.Rows.Count > 0)
            {
                dgvRazones.DataSource = dt;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Calculos anio 2017

            double utilidadNeta = 6169, ventas = 253756, activos = 125000, patrimonio = 68125;

            textActivos.Text = Convert.ToString(Math.Round(activos, 2));
            textPatrimonio.Text = Convert.ToString(Math.Round(patrimonio, 2));
            textUtilidadNeta.Text = Convert.ToString(Math.Round(utilidadNeta, 2));
            textActivos3.Text = Convert.ToString(Math.Round(activos, 2));
            textVentas.Text = Convert.ToString(Math.Round(ventas, 2));

            //Calculo del margen neto

            double margenNeto = utilidadNeta / ventas;
            textMargenNeto.Text = Convert.ToString(Math.Round(margenNeto, 2));

            //Calculo de rotacion de activos

            double rotacionActivos = ventas / activos;
            textRotacionActivos.Text = Convert.ToString(Math.Round(rotacionActivos, 2));

            //Calculo de Multiplicador de capital

            double multiplicadorCapital = activos / patrimonio;
            textMultiplicadorCapital.Text = Convert.ToString(Math.Round(multiplicadorCapital, 2));

            //Calculo del Roa

            double roa = utilidadNeta / activos;
            textRoa.Text = Convert.ToString(Math.Round(roa, 2));

            //Calculo del Roe

            double roe = margenNeto * rotacionActivos * multiplicadorCapital;
            textRoe.Text = Convert.ToString(Math.Round(roe, 2));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Calculos anio 2018

            double utilidadNeta = 15398, ventas = 279128, activos = 175000, patrimonio = 95375;
            textActivos2.Text = Convert.ToString(Math.Round(activos, 2));
            textPatrimonio2.Text = Convert.ToString(Math.Round(patrimonio, 2));
            textUtilidadNeta2.Text = Convert.ToString(Math.Round(utilidadNeta, 2));
            textActivos4.Text = Convert.ToString(Math.Round(activos, 2));
            textVentas2.Text = Convert.ToString(Math.Round(ventas, 2));

            //Calculo del margen neto

            double margenNeto = utilidadNeta / ventas;
            textMargenNeto2.Text = Convert.ToString(Math.Round(margenNeto, 2));

            //Calculo de rotacion de activos

            double rotacionActivos = ventas / activos;
            textRotacionActivos2.Text = Convert.ToString(Math.Round(rotacionActivos, 2));

            //Calculo de Multiplicador de capital

            double multiplicadorCapital = activos / patrimonio;
            textMultiplicadorCapital2.Text = Convert.ToString(Math.Round(multiplicadorCapital, 2));

            //Calculo del Roa

            double roa = utilidadNeta / activos;
            textRoa2.Text = Convert.ToString(Math.Round(roa, 2));

            //Calculo del Roe

            double roe = margenNeto * rotacionActivos * multiplicadorCapital;
            textRoe2.Text = Convert.ToString(Math.Round(roe, 2));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
