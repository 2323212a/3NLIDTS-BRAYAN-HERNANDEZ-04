using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3NLIDTS_BRAYAN_HERNANDEZ_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
        }
        private void btnBorar_Click(object sender, EventArgs e)
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txtedad.Clear();
            txttelefono.Clear();
            txtestatura.Clear();
            rbfemenino.Checked = false;
            rbmasculino.Checked = false;
        }

            string ruta = "datos.txt";

            if (File.Exists(ruta))
            {
                // Abrir el archivo en el bloc de notas
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
    }
}
