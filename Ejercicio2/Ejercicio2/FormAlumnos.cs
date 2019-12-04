using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class FormAlumnos : Form
    {
        private AlumnoManager _Manager;
        public FormAlumnos()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            _Manager = new AlumnoManager();
        }

        public void LimpiarTexto()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox text = ctrl as TextBox;
                    text.Clear();
                }
            }
        }

        private void btnReadAlmno_Click(object sender, EventArgs e)
        {
            listAlumno.Items.Clear();
            List<Alumno> alumnos = _Manager.GetAlumnos();
            foreach (Alumno alumno in alumnos)
            {
                ListViewItem item = listAlumno.Items.Add(alumno.Num_Matricula.ToString());
                item.SubItems.Add(alumno.Dni.ToString());
                item.SubItems.Add(alumno.Nombre);
            }
        }
    }
}

