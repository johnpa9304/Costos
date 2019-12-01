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

                        dr[n] = data[columnIndex+3];
                        dgvHorizontal.Rows[n].Cells[3].Value = (Double.Parse(dgvHorizontal.Rows
                            [n].Cells[2].Value.ToString()) - Double.Parse(dgvHorizontal.Rows
                            [n].Cells[1].Value.ToString())).ToString();

                        dgvHorizontal.Rows[n].Cells[4].Value = (Double.Parse(dgvHorizontal.Rows
                            [n].Cells[3].Value.ToString()) / Math.Min(Double.Parse(dgvHorizontal.Rows[n].Cells[1].Value.ToString()),
                            Double.Parse(dgvHorizontal.Rows[n].Cells[2].Value.ToString()))).ToString();
                    }
                   
                }
            }

            if (dt.Rows.Count > 0)
            {
                dgvHorizontal.DataSource = dt;
            }
        }
    }
}
