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
    public partial class FormProfesores : Form
    {
        private ProfesorManager _Manager;
        public FormProfesores()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            _Manager = new ProfesorManager();
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

        private void FormProfesores_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listProfesores.Items.Clear();
            List<Profesor> profesores = _Manager.GetProfesor();
            foreach (Profesor profesor in profesores)
            {
                ListViewItem item = listProfesores.Items.Add(profesor.DNI.ToString());
                item.SubItems.Add(profesor.Nombre);
                item.SubItems.Add(profesor.Domicilio);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Profesor profesor = new Profesor()
            {
                DNI = int.Parse(txtDNI.Text),
                Nombre = txtNombre.Text,
                Domicilio = txtDomicilio.Text
            };
            _Manager.Write(profesor);
            button1_Click(this, new EventArgs());
            LimpiarTexto();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Profesor profesor = new Profesor()
            {
                DNI = int.Parse(txtDNI.Text),
                Nombre = txtNombre.Text,
                Domicilio = txtDomicilio.Text
            };
            _Manager.Update(profesor);
            button1_Click(this, new EventArgs());
            LimpiarTexto();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _Manager.Delete(int.Parse(txtDNI.Text));
            button1_Click(this, new EventArgs());
            LimpiarTexto();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            menu_principal principal = new menu_principal();
            principal.Show();
            this.Hide();
        }
    }
}


