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
    public partial class FormTfc : Form
    {
        private TfcManager _Manager;
        public FormTfc()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            _Manager = new TfcManager();
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

        private void btnLeer_Click(object sender, EventArgs e)
        {
            listTFC.Items.Clear();
            List<TFC> tfcs = _Manager.GetTfc();
            foreach (TFC tfc in tfcs)
            {
                ListViewItem items = listTFC.Items.Add(tfc.Num_orden.ToString());
                items.SubItems.Add(tfc.Tema);
                items.SubItems.Add(tfc.Fecha);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            TFC tfc = new TFC()
            {
                Tema = txtTema.Text,
                Fecha = txtFecha.Text,
            };
            _Manager.Write(tfc);
            btnLeer_Click(this, new EventArgs());
            LimpiarTexto();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            TFC tfc = new TFC()
            {
                Num_orden = int.Parse(txtNum_orden.Text),
                Tema = txtTema.Text,
                Fecha = txtFecha.Text,
            };
            _Manager.Update(tfc);
            btnLeer_Click(this, new EventArgs());
            LimpiarTexto();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _Manager.Delete(int.Parse(txtNum_orden.Text));
            btnLeer_Click(this, new EventArgs());
            LimpiarTexto();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            menu_principal form = new menu_principal();
            this.Dispose(false);
            form.Show();
        }
    }
}