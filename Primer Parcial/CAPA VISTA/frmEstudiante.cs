using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPA_VISTA
{
    public partial class frmEstudiante : Form
    {
        string UsuarioAplicacion; //usuario heredado
        static Form FormularioPadre;
        public frmEstudiante(string usuario, Form formularioPadre)
        {
            InitializeComponent();
        UsuarioAplicacion = usuario;
        navegador1.Usuario = UsuarioAplicacion;
        FormularioPadre = formularioPadre;
    }

        private void navegador1_Load(object sender, EventArgs e)
        {
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            navegador1.aplicacion = 1306;
            navegador1.tbl = "alumnos";
            navegador1.campoEstado = "estatus_alumno";
            navegador1.MDIformulario = FormularioPadre;
            foreach (Control C in this.Controls)
            {
                if ((C.Tag != null) && (!C.Tag.ToString().Equals("")))
                {
                    if (C is TextBox)
                    {
                        lista.Add(C);

                    }
                    else if (C is ComboBox)
                    {
                        lista.Add(C);

                    }
                    else if (C is DateTimePicker)
                    {
                        lista.Add(C);
                    }
                }
            }
            navegador1.control = lista;
            navegador1.formulario = this;
            navegador1.DatosActualizar = dataGridView1;
            navegador1.procActualizarData();
            navegador1.procCargar();
            navegador1.ayudaRuta = "";
            navegador1.ruta = "";
        }

        private void frmEstudiante_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox6.Text = "1";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                textBox6.Text = "0";
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //si el campo estado esta vacio coloca los 2 radioButons en falso, para que se puedan volver a seleccionar
            if (textBox6.Text == "")
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
            if (textBox6.Text == "1")
            {
                radioButton1.Checked = true;
            }
        }
    }
}
