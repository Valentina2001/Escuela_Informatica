﻿using System;
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
    public partial class menu_principal : Form
    {
        public menu_principal()
        {
            InitializeComponent();
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            FormAlumnos form = new FormAlumnos();
            this.Dispose(false);
            form.Show();
        }

        private void btnProfesor_Click(object sender, EventArgs e)
        {
            FormProfesores form = new FormProfesores();
            this.Dispose(false);
            form.Show();
        }

        
    }
}