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
    public partial class Horizontal : Form
    {
        public Horizontal()
        {
            InitializeComponent();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void abrirArchivoBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            txtPath.Text = openFileDialog1.FileName;
            leeCSV(txtPath.Text);
        }

        private void leeCSV(string filePath) {
            DataTable dt = new DataTable();

            dt.Columns.Add("Cuenta", typeof(String));
            dt.Columns.Add("V2017", typeof(Decimal));
            dt.Columns.Add("V2018", typeof(Decimal));
            dt.Columns.Add("VariacionAbsoluta", typeof(Decimal), "(V2018 - V2017)");
            DataColumn VariacionRelativa = dt.Columns.Add("VariacionRelativa", typeof(Decimal));
            VariacionRelativa.Expression = "IIF([V2018]<[V2017], ([V2018]-[V2017])/[V2018],([V2018]-[V2017])/[V2017])";
            
            string[] lines = System.IO.File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] data = lines[i].Split(';');
                    DataRow dr = dt.NewRow();

                    try
                    {
                        dr["Cuenta"] = data[0];
                        dr["V2017"] = Decimal.Parse(data[1]);
                        dr["V2018"] = Decimal.Parse(data[2]);

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
                dgvHorizontal.DataSource = dt;
            }




            /*DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(filePath);
            if(lines.Length > 0)
            {
                string firstLine = lines[0];
                string[] header = firstLine.Split(';');//{ "Cuenta", "2017", "2018", "Variación Absoluta", "Variación Relativa" }; 
                foreach (string headerWord in header)
                {
                    dt.Columns.Add(new DataColumn(headerWord));

                }
                DataColumn dataColumn1 = new DataColumn("Variación Absoluta");
                DataColumn dataColumn2 = new DataColumn("Variación Relativa");
                dt.Columns.Add(dataColumn1);
                dt.Columns.Add(dataColumn2);

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] data = lines[i].Split(';');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    try {
                        foreach (string headerWord in header)
                        {
                            dr[headerWord] = data[columnIndex++];
                        }
                        dt.Rows.Add(dr);
                    }
                    catch(IndexOutOfRangeException)
                    {
                        System.Console.WriteLine("Error: la matriz se excede...");
                    }

                    foreach (DataGridViewRow row in dgvHorizontal.Rows)
                    {
                        int n = row.Index;
                        //Variación Absoluta = 2018 - 2017
                        dgvHorizontal.Rows[n].Cells[3].Value = (Double.Parse(dgvHorizontal.Rows
                            [n].Cells[2].Value.ToString()) - Double.Parse(dgvHorizontal.Rows
                            [n].Cells[1].Value.ToString())).ToString();
                        //Variación Relativa = Variación Absoluta / Min(2018, 2017)
                        dgvHorizontal.Rows[n].Cells[4].Value = (Double.Parse(dgvHorizontal.Rows
                            [n].Cells[3].Value.ToString()) / Math.Min(Double.Parse(dgvHorizontal.Rows[n].Cells[1].Value.ToString()),
                            Double.Parse(dgvHorizontal.Rows[n].Cells[2].Value.ToString()))).ToString();
                    }
                   
                }
            }

            if (dt.Rows.Count > 0)
            {
                dgvHorizontal.DataSource = dt;
            }*/
        }
    }
}
