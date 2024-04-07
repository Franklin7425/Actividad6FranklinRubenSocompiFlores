using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reportes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime a = dateTimePicker1.Value;
            DateTime b = dateTimePicker2.Value;

            this.dataTable1TableAdapter.Fill(this.conjuntodeDatos.DataTable1, a, b);

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime c = dateTimePicker3.Value;

            this.pRODUCTOTableAdapter.Fill(this.conjuntodeDatos.PRODUCTO, c);

            this.reportViewer2.RefreshReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int d = Convert.ToInt32(textBox1.Text);

            this.dataTable2TableAdapter.Fill(this.conjuntodeDatos.DataTable2, d);

            this.reportViewer3.RefreshReport();
        }
    }
}
