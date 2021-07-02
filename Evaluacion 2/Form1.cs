using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion_2
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
            Promedio estudiantes = new Promedio();
            estudiantes.Nombre = NombretextBox.Text;
            estudiantes.NumeroCuenta = Convert.ToDouble(CuentatextBox.Text);
            estudiantes.Nota1 = Convert.ToDouble(Nota1textBox.Text);
            estudiantes.Nota2 = Convert.ToDouble(Nota2textBox.Text);
            estudiantes.Nota3 = Convert.ToDouble(Nota3textBox.Text);
            estudiantes.Nota4 = Convert.ToDouble(Nota4textBox.Text);


            MessageBox.Show("El promedio del estudiante es: " + "" + estudiantes.DevolverPromedio() + " y " + " " + estudiantes.aproboOreprobo());
        }



        private void button3_Click(object sender, EventArgs e)
        {
            NombretextBox.Clear();
            CuentatextBox.Clear();
            Nota1textBox.Clear();
            Nota2textBox.Clear();
            Nota3textBox.Clear();
            Nota4textBox.Clear();
            
        }
    }
}
