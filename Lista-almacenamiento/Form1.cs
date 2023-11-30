using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_almacenamiento
{
        public partial class Form1 : Form
        {
            private List<string> listaEstudiantes = new List<string>();
            public Form1()
            {

                InitializeComponent();
            }
            private void label1_Click(object sender, EventArgs e)
            {

            }
            private void btnAdd_Click(object sender, EventArgs e)
            {
            // Obtener el nombre ingresado
            string nombre = txtNombre.Text.Trim();

            // Verificar si el nombre no está vacío
            if (!string.IsNullOrEmpty(nombre))
            {
                // Verificar si el nombre ya está en la lista
                if (!NombreEnLista(nombre))
                {
                    // Agregar el nombre a la lista
                    listaEstudiantes.Add(nombre);

                    // Limpiar y volver a llenar el ListBox
                    ListNombres.Items.Clear();
                    foreach (string estudiante in listaEstudiantes)
                    {
                        ListNombres.Items.Add(estudiante);
                    }

                    // Limpiar la caja de texto
                    txtNombre.Clear();
                }
                else
                {
                    MessageBox.Show("El nombre ya está en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
            private void btnLimpiar_Click(object sender, EventArgs e)
            {
                // Limpiar la lista y el ListBox
                listaEstudiantes.Clear();
                ListNombres.Items.Clear();
        }
        private bool NombreEnLista(string nombre)
        {
            // Verificar si el nombre ya está en la lista
            return listaEstudiantes.Contains(nombre);
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
            {
                
            }
        }
    }