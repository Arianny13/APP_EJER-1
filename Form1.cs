using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_EJER_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            // Capturar los datos del estudiante desde los TextBox
            string matricula = txt_Matricula.Text;
            string nombre = txt_Nombre.Text;
            string apellidos = txt_Apellido.Text;
            int edad = Convert.ToInt32(txt_Edad.Text); // Convertir a entero          
            string carrera = txt_Carrera.Text;

            // Construir el mensaje a mostrar en el Label
            string mensaje = $"Matrícula: {matricula}\n" +
                             $"Nombre: {nombre}\n" +
                             $"Apellido: {apellidos}\n" +
                             $"Edad: {edad}\n" +
                             $"Carrera: {carrera}";

            // Mostrar el mensaje en el Label
            txt_Datos.Text = mensaje;
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Matricula.Clear();
            txt_Nombre.Clear();
            txt_Apellido.Clear();
            txt_Edad.Clear();
            txt_Carrera.Clear();
            txt_Datos.Clear();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
