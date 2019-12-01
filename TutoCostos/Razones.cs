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
    }
}
