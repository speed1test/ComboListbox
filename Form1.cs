using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPrueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            var dt = new DataTable();
            dt.Columns.Add("Nombre:");
            dt.Columns.Add("Edad: ");
            dt.Rows.Add("Rosa", 22);
            dt.Rows.Add("Felipe", 99);
            dtaTabla.DataSource = dt;
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
