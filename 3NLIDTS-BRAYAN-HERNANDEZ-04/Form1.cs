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
using System.IO;

namespace _3NLIDTS_BRAYAN_HERNANDEZ_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool EsTextoValido(string valor)
        {
            return Regex.IsMatch(valor, @"^[a-zA-Z\s]+$");
        }

        private bool ValidarCampos()
        {
            if (!EsTextoValido(txtnombre.Text))
            {
                MessageBox.Show("Por favor ingrese un nombre válido (solo letras y espacios).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!EsTextoValido(txtapellido.Text))
            {
                MessageBox.Show("Por favor ingrese un apellido válido (solo letras y espacios).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Regex.IsMatch(txtedad.Text, @"^[0-9]{1,2}$"))
            {
                MessageBox.Show("Ingrese una edad válida (solo números, máximo 2 dígitos).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Regex.IsMatch(txttelefono.Text, @"^[0-9]{10}$"))
            {
                MessageBox.Show("Ingrese un teléfono válido de 10 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!double.TryParse(txtestatura.Text, out _))
            {
                MessageBox.Show("Ingrese solo números en la estatura (ejemplo: 1.75).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!rbfemenino.Checked && !rbmasculino.Checked)
            {
                MessageBox.Show("Seleccione un género.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            string edad = txtedad.Text;
            string nombre = txtnombre.Text;
            string apellido = txtapellido.Text;
            string telefono = txttelefono.Text;
            string estatura = txtestatura.Text;
            string genero = rbfemenino.Checked ? "Femenino" : "Masculino";
            string datos = $"Nombre: {nombre}\r\nApellido: {apellido}\r\nEdad: {edad}\r\nTeléfono: {telefono}\r\nEstatura: {estatura}\r\nGénero: {genero}";
            MessageBox.Show(datos, "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string ruta = "datos.txt";
            try
            {
                File.AppendAllText(ruta, datos + Environment.NewLine + "---------------------" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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