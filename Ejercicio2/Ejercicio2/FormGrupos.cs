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
    public partial class FormGrupos : Form
    {
        private GrupoManager _Manager;
        public FormGrupos()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            _Manager = new GrupoManager();
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

        private void btnLeerGrupo_Click(object sender, EventArgs e)
        {
            listGrupos.Items.Clear();
            List<Grupo> grupos = _Manager.GetGrupos();
            foreach (Grupo grupo in grupos)
            {
                ListViewItem item = listGrupos.Items.Add(grupo.Num_grupo.ToString());
                item.SubItems.Add(grupo.Nombre);
                item.SubItems.Add(grupo.Num_componente.ToString());
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            menu_principal principal = new menu_principal();
            principal.Show();
            this.Hide();
        }

        private void btnAgregarGrupo_Click(object sender, EventArgs e)
        {
            Grupo grupo = new Grupo()
            {
                Num_grupo = int.Parse(txtNumGrupo.Text),
                Nombre = txtNombreGrupo.Text,
                Num_componente = int.Parse(txtNumComponente.Text)
            };
            _Manager.Write(grupo);
            LimpiarTexto();
            btnLeerGrupo_Click(this, new EventArgs());
        }

        private void btnActualizarGrupo_Click(object sender, EventArgs e)
        {
            Grupo grupo = new Grupo()
            {
                Num_grupo = int.Parse(txtNumGrupo.Text),
                Nombre = txtNombreGrupo.Text,
                Num_componente = int.Parse(txtNumComponente.Text)
            };
            _Manager.Update(grupo);
            LimpiarTexto();
            btnLeerGrupo_Click(this, new EventArgs());
        }

        private void btnEliminarGrupo_Click(object sender, EventArgs e)
        {
            _Manager.Delete(int.Parse(txtNumGrupo.Text));
            btnLeerGrupo_Click(this, new EventArgs());
            LimpiarTexto();
        }
    }
}
