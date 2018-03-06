using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clase2
{
    public partial class Form1 : Form
    {
        string _nombre, _apellido, _genero, _direccion, _ci;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _nombre = txtNombre.Text;
            _apellido = txtApellido.Text;
            _ci = txtCi.Text + "-" + cmbExp.Text;
            _genero = (rbMujer.Checked == true) ? rbMujer.Text : rbVaron.Text;
            _direccion = txtDireccion.Text;
            MessageBox.Show("Nombre: "+_nombre
                            +"\nApellido: "+_apellido
                            +"\nCi: "+_ci
                            +"\nGenero: "+_genero
                            +"\nDirección: "+_direccion
                );
        }
    }
}
