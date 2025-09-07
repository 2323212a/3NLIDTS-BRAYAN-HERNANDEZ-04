using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.IO;         
using System.Diagnostics;


namespace _3NLIDTS_BRAYAN_HERNANDEZ_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtedad.TextChanged += ValidarEdad;
            txtnombre.TextChanged += ValidarNombre;
            txtapellido.TextChanged += ValidarApellido;
            txttelefono.Leave += ValidarTelefono;
            txtestatura.TextChanged += ValidarEstatura;

        }

        private void ValidarNombre(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsTextoValido(textBox.Text))
            {
                MessageBox.Show("Por favor ingrese un nombre válido (solo letras y espacios).",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void ValidarApellido(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsTextoValido(textBox.Text))
            {
                MessageBox.Show("Por favor ingrese un apellido válido (solo letras y espacios).",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void ValidarEdad(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!Regex.IsMatch(textBox.Text, @"^[0-9]{1,2}$")) // Edad entre 0 y 99
            {
                MessageBox.Show("Ingrese una edad válida (solo números, máximo 2 dígitos).",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void ValidarEstatura(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!double.TryParse(textBox.Text, out _))
            {
                MessageBox.Show("Ingrese solo números en la estatura (ejemplo: 1.75).",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void ValidarTelefono(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!Regex.IsMatch(textBox.Text, @"^[0-9]{10}$")) // 10 dígitos
            {
                MessageBox.Show("Ingrese un teléfono válido de 10 dígitos.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private bool EsTextoValido(string valor)
        {
            return Regex.IsMatch(valor, @"^[a-zA-Z\s]+$");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string edad = txtedad.Text;
            string nombre = txtnombre.Text;
            string apellido = txtapellido.Text;
            string telefono = txttelefono.Text;
            string estatura = txtestatura.Text;
            string genero = "";
            if (rbfemenino.Checked)
            {
                genero = "Femenino";
            }
            else if (rbmasculino.Checked)
            {
                genero = "Masculino";
            }
            string datos = $"Nombre: {nombre}\r\nApellido: {apellido}\r\nEdad: {edad}\r\nTeléfono: {telefono}\r\nEstatura: {estatura}\r\nGénero: {genero}";
            MessageBox.Show(datos, "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string ruta = "datos.txt"; // El archivo se creará en la carpeta del programa
            File.AppendAllText(ruta, datos + Environment.NewLine + "---------------------" + Environment.NewLine);
        }
        private void btnregistros_Click_1(object sender, EventArgs e)
        {

            string ruta = "datos.txt";

            if (File.Exists(ruta))
            {
                Process.Start("notepad.exe", ruta);
            }
            else
            {
                MessageBox.Show("Aún no hay registros guardados.",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txtedad.Clear();
            txttelefono.Clear();
            txtestatura.Clear();
            rbfemenino.Checked = false;
            rbmasculino.Checked = false;
        }
    }
}