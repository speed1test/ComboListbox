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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            cmbInfo.Items.Add("Esta es una prueba");
            cmbInfo.Items.Add("Esta es una prueba 2");
            lstInfo1.Items.Add("Esta es otra prueba de funcionamiento");
            lstInfo1.Items.Add("Esta es otra prueba de funcionamiento 2");
        }

        public void Form2_Load(object sender, EventArgs e) 
        {
            
        }

        private void btnLlenarInfo_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            //Imprimir lo que se a seleccionado
            MessageBox.Show(cmbInfo.Text);
            MessageBox.Show(lstInfo1.Text);
        }
    }
}
