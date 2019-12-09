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
    public partial class Razones : Form
    {
        public Razones()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtBox.Text = openFileDialog1.FileName;
            leeCsv(txtBox.Text);
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

        private void Razones_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Botón 2017 que muestra los valores en los TextBox

            //Valores a ser utilizados
            double activoCorriente = 103750, pasivoCorriente = 40625, inventario = 51250, activoTotal = 125000, pasivoTotal = 56875,
                   utilidadOperacional = 12338, gastosFinancieros = 33345, ventas = 253756, cuentasPorCobrar = 40000, costoDeVenta = 211198, 
                   cuentasPorPagar = 24456, activosBrutos = 137500, utilidadNeta = 6169;
            int dias = 365;
            //Indicadores de Liquidez
            //Razón Corriente
            double razonCorriente = activoCorriente / pasivoCorriente;
            txtRazonCte.Text = Convert.ToString(Math.Round(razonCorriente, 2));

            //Razón Ácida
            double razonAcida = (activoCorriente - inventario) / pasivoCorriente;
            txtRazonAcd.Text = Convert.ToString(Math.Round(razonAcida, 2));

            //Capital de Trabajo
            double capitalDeTrabajo = activoCorriente - pasivoCorriente;
            txtCapital.Text = Convert.ToString(Math.Round(capitalDeTrabajo, 2));

            //Indicadores de Endeudamiento
            //Razón de Endeudamiento
            double razonDeEndeudamiento = (pasivoTotal/activoTotal) * 100;
            txtRazonDeuda.Text = Convert.ToString(Math.Round(razonDeEndeudamiento));

            //Razón Porción Corriente de la Deuda
            double razonPorcionCorrienteDeLaDeuda = (pasivoCorriente / pasivoTotal) * 100;
            txtPorcionDeuda.Text = Convert.ToString(Math.Round(razonPorcionCorrienteDeLaDeuda));

            //Razón Cobertura de Interéses
            double razonCoberturaDeIntereses = (utilidadOperacional / gastosFinancieros);
            txtCoberturaInteres.Text = Convert.ToString(Math.Round(razonCoberturaDeIntereses, 2));

            //Indicadores de Actividad
            //Rotación de Cartera
            double rotacionDeCartera = ventas / cuentasPorCobrar;
            double periodoDeCobranza = dias / rotacionDeCartera;

            txtRotacionCartera.Text = Convert.ToString(Math.Round(rotacionDeCartera, 2));
            txtCobranzaCartera.Text = Convert.ToString(Math.Round(periodoDeCobranza, 0));

            //Rotación de Cuentas Por Pagar
            double rotacionCuentasPorPagar = costoDeVenta / cuentasPorPagar;
            double periodoDeCobranza_ = dias / rotacionCuentasPorPagar;

            txtRotacionCtaPagar.Text = Convert.ToString(Math.Round(rotacionCuentasPorPagar, 2));
            txtCobranzaPagar.Text = Convert.ToString(Math.Round(periodoDeCobranza_, 0));

            //Rotación de Inventario
            double rotacionInventario = costoDeVenta / inventario;
            double periodoDeRotacion = dias / rotacionInventario;

            txtRotacionInv.Text = Convert.ToString(Math.Round(rotacionInventario, 2));
            txtPeriodoInv.Text = Convert.ToString(Math.Round(periodoDeRotacion, 0));

            //Rotación de Activos
            double rotacionActivos = ventas / activosBrutos;

            txtRotacionActivo.Text = Convert.ToString(Math.Round(rotacionActivos, 2));

            //Indicadores de Rentabilidad
            //Rentabilidad Neta
            double rentabilidadNeta = (utilidadNeta / ventas) * 100;
            txtRentabilidadNeta.Text = Convert.ToString(Math.Round(rentabilidadNeta, 0));

            //Rentabilidad Operacional
            double rentabilidadOperacional = (utilidadOperacional / ventas) * 100;
            txtRentabilidadOperacional.Text = Convert.ToString(Math.Round(rentabilidadOperacional, 0));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Botón 2018 que muestra los valores en los TextBox
            //Valores a ser utilizados
            double activoCorriente = 145250, pasivoCorriente = 56875, inventario = 71750, activoTotal = 175000, pasivoTotal = 79625,
                   utilidadOperacional = 30796, gastosFinancieros = 36721, ventas = 279128, cuentasPorCobrar = 56000, costoDeVenta = 215986,
                   cuentasPorPagar = 38500, activosBrutos = 196000, utilidadNeta = 15398;
            int dias = 365;
            //Indicadores de Liquidez
            //Razón Corriente
            double razonCorriente = activoCorriente / pasivoCorriente;
            txtRazonCte2.Text = Convert.ToString(Math.Round(razonCorriente, 2));

            //Razón Ácida
            double razonAcida = (activoCorriente - inventario) / pasivoCorriente;
            txtRazonAcd2.Text = Convert.ToString(Math.Round(razonAcida, 2));

            //Capital de Trabajo
            double capitalDeTrabajo = activoCorriente - pasivoCorriente;
            txtCapital2.Text = Convert.ToString(Math.Round(capitalDeTrabajo, 2));

            //Indicadores de Endeudamiento
            //Razón de Endeudamiento
            double razonDeEndeudamiento = (pasivoTotal / activoTotal) * 100;
            txtRazonDeuda2.Text = Convert.ToString(Math.Round(razonDeEndeudamiento));

            //Razón Porción Corriente de la Deuda
            double razonPorcionCorrienteDeLaDeuda = (pasivoCorriente / pasivoTotal) * 100;
            txtPorcionDeuda2.Text = Convert.ToString(Math.Round(razonPorcionCorrienteDeLaDeuda));

            //Razón Cobertura de Interéses
            double razonCoberturaDeIntereses = (utilidadOperacional / gastosFinancieros);
            txtCoberturaInteres2.Text = Convert.ToString(Math.Round(razonCoberturaDeIntereses, 2));

            //Indicadores de Actividad
            //Rotación de Cartera
            double rotacionDeCartera = ventas / cuentasPorCobrar;
            double periodoDeCobranza = dias / rotacionDeCartera;

            txtRotacionCartera2.Text = Convert.ToString(Math.Round(rotacionDeCartera, 2));
            txtCobranzaCartera2.Text = Convert.ToString(Math.Round(periodoDeCobranza, 0));

            //Rotación de Cuentas Por Pagar
            double rotacionCuentasPorPagar = costoDeVenta / cuentasPorPagar;
            double periodoDeCobranza_ = dias / rotacionCuentasPorPagar;

            txtRotacionCtaPagar2.Text = Convert.ToString(Math.Round(rotacionCuentasPorPagar, 2));
            txtCobranzaPagar2.Text = Convert.ToString(Math.Round(periodoDeCobranza_, 0));

            //Rotación de Inventario
            double rotacionInventario = costoDeVenta / inventario;
            double periodoDeRotacion = dias / rotacionInventario;

            txtRotacionInv2.Text = Convert.ToString(Math.Round(rotacionInventario, 2));
            txtPeriodoInv2.Text = Convert.ToString(Math.Round(periodoDeRotacion, 0));

            //Rotación de Activos
            double rotacionActivos = ventas / activosBrutos;

            txtRotacionActivo2.Text = Convert.ToString(Math.Round(rotacionActivos, 2));

            //Indicadores de Rentabilidad
            //Rentabilidad Neta
            double rentabilidadNeta = (utilidadNeta / ventas) * 100;
            txtRentabilidadNeta2.Text = Convert.ToString(Math.Round(rentabilidadNeta, 0));

            //Rentabilidad Operacional
            double rentabilidadOperacional = (utilidadOperacional / ventas) * 100;
            txtRentabilidadOperacional2.Text = Convert.ToString(Math.Round(rentabilidadOperacional, 0));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void txtRentabilidadOperacional_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
