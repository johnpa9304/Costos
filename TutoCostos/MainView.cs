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
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form analisisHorizontal = new Horizontal();
            analisisHorizontal.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form analisisPorRazones = new Razones();
            analisisPorRazones.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form analisisDupont = new Dupont();
            analisisDupont.Show();
        }
    }
}
