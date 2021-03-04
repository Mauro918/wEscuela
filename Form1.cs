using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wEscuela
{
    public partial class frmPersonasEscuela : Form
    {
        Persona persona = new Persona();

        public frmPersonasEscuela()
        {
            InitializeComponent();
            InicializarFormulario();
        }

        public void InicializarFormulario()
        {
           
        }

        private void btnCaptrarDatos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Datos Capturados ");
            rdoEstudiante.Checked = false;
            rdoProfesor.Checked = false;
            txtCalificacion.Clear();
            txtNombre.Clear();
            txtSueldo.Clear();
            txtCalificacion.Enabled = true;
            txtSueldo.Enabled = true;
        }

        private void rdoProfesor_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdoProfesor.Checked)
                {
                    txtCalificacion.Enabled = false;
                    txtSueldo.Enabled = true;
                }
            }
            catch
            { 
                throw;
            }
        }

        private void rdoEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdoEstudiante.Checked)
                {
                    txtSueldo.Enabled = false;
                    txtCalificacion.Enabled = true;
                }
            }
            catch 
            {
                 throw;
            }
            
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            persona.Nombre = txtNombre.Text;
            string asiste = persona.Asistir();

            if (rdoEstudiante.Checked)
            {
                persona.Calificacion = int.Parse(txtCalificacion.Text);
                try
                {
                    string estudia = persona.Estudiar();
                    DialogResult Resultado = MessageBox.Show(" Nombre:    \t " + persona.Nombre + " \nCalificacion:  \t" +
                        persona.Calificacion + "\n" + asiste + "\n" + estudia);
                }
                catch
                {
                    throw;
                }

            }
            else if (rdoProfesor.Checked)
            {
                persona.Sueldo = int.Parse(txtSueldo.Text);
                string enseña = persona.Enseñar();

                DialogResult Resultado = MessageBox.Show(" Nombre:  \t" + persona.Nombre + "\nSueldo: \t$" + persona.Sueldo +
                    "\n" + asiste + "\n" + enseña);
            }
            else
            {
                MessageBox.Show(" Error; verifique que halla seleccionado alguna de las siguientes opcciones ( Estudiante o Persona)");
            }
        }

        private void frmEscuela_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show(" Realmente desea salir?", " Comfirmacion ",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (resultado == DialogResult.No);
        }
    }


}
