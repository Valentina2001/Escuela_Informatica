﻿namespace Ejercicio2
{
    partial class menu_principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_principal));
            this.fondoLibros = new System.Windows.Forms.Label();
            this.fondoBienvenido = new System.Windows.Forms.Label();
            this.btnAlumno = new System.Windows.Forms.Button();
            this.btnProfesor = new System.Windows.Forms.Button();
            this.btnTribunal = new System.Windows.Forms.Button();
            this.btnGrupo = new System.Windows.Forms.Button();
            this.btnTfc = new System.Windows.Forms.Button();
            this.labelOpcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fondoLibros
            // 
            this.fondoLibros.Image = ((System.Drawing.Image)(resources.GetObject("fondoLibros.Image")));
            this.fondoLibros.Location = new System.Drawing.Point(0, 66);
            this.fondoLibros.Name = "fondoLibros";
            this.fondoLibros.Size = new System.Drawing.Size(798, 120);
            this.fondoLibros.TabIndex = 0;
            // 
            // fondoBienvenido
            // 
            this.fondoBienvenido.BackColor = System.Drawing.Color.Silver;
            this.fondoBienvenido.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fondoBienvenido.Location = new System.Drawing.Point(3, 0);
            this.fondoBienvenido.Name = "fondoBienvenido";
            this.fondoBienvenido.Size = new System.Drawing.Size(795, 66);
            this.fondoBienvenido.TabIndex = 1;
            this.fondoBienvenido.Text = "BIENVENIDOS";
            this.fondoBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAlumno
            // 
            this.btnAlumno.Location = new System.Drawing.Point(143, 264);
            this.btnAlumno.Name = "btnAlumno";
            this.btnAlumno.Size = new System.Drawing.Size(150, 32);
            this.btnAlumno.TabIndex = 2;
            this.btnAlumno.Text = "Ver Alumno";
            this.btnAlumno.UseVisualStyleBackColor = true;
            this.btnAlumno.Click += new System.EventHandler(this.btnAlumno_Click);
            // 
            // btnProfesor
            // 
            this.btnProfesor.Location = new System.Drawing.Point(143, 342);
            this.btnProfesor.Name = "btnProfesor";
            this.btnProfesor.Size = new System.Drawing.Size(150, 32);
            this.btnProfesor.TabIndex = 3;
            this.btnProfesor.Text = "Ver Profesor";
            this.btnProfesor.UseVisualStyleBackColor = true;
            this.btnProfesor.Click += new System.EventHandler(this.btnProfesor_Click);
            // 
            // btnTribunal
            // 
            this.btnTribunal.Location = new System.Drawing.Point(326, 264);
            this.btnTribunal.Name = "btnTribunal";
            this.btnTribunal.Size = new System.Drawing.Size(150, 32);
            this.btnTribunal.TabIndex = 4;
            this.btnTribunal.Text = "Ver Tribunal";
            this.btnTribunal.UseVisualStyleBackColor = true;
            this.btnTribunal.Click += new System.EventHandler(this.btnTribunal_Click);
            // 
            // btnGrupo
            // 
            this.btnGrupo.Location = new System.Drawing.Point(326, 342);
            this.btnGrupo.Name = "btnGrupo";
            this.btnGrupo.Size = new System.Drawing.Size(150, 32);
            this.btnGrupo.TabIndex = 5;
            this.btnGrupo.Text = "Ver Grupo";
            this.btnGrupo.UseVisualStyleBackColor = true;
            this.btnGrupo.Click += new System.EventHandler(this.btnGrupo_Click);
            // 
            // btnTfc
            // 
            this.btnTfc.Location = new System.Drawing.Point(504, 305);
            this.btnTfc.Name = "btnTfc";
            this.btnTfc.Size = new System.Drawing.Size(150, 32);
            this.btnTfc.TabIndex = 6;
            this.btnTfc.Text = "Ver TFC";
            this.btnTfc.UseVisualStyleBackColor = true;
            this.btnTfc.Click += new System.EventHandler(this.btnTfc_Click);
            // 
            // labelOpcion
            // 
            this.labelOpcion.BackColor = System.Drawing.SystemColors.Window;
            this.labelOpcion.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpcion.Location = new System.Drawing.Point(170, 213);
            this.labelOpcion.Name = "labelOpcion";
            this.labelOpcion.Size = new System.Drawing.Size(462, 23);
            this.labelOpcion.TabIndex = 7;
            this.labelOpcion.Text = "Elija la opción que desea realizar";
            this.labelOpcion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menu_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOpcion);
            this.Controls.Add(this.btnTfc);
            this.Controls.Add(this.btnGrupo);
            this.Controls.Add(this.btnTribunal);
            this.Controls.Add(this.btnProfesor);
            this.Controls.Add(this.btnAlumno);
            this.Controls.Add(this.fondoBienvenido);
            this.Controls.Add(this.fondoLibros);
            this.Name = "menu_principal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label fondoLibros;
        private System.Windows.Forms.Label fondoBienvenido;
        private System.Windows.Forms.Button btnAlumno;
        private System.Windows.Forms.Button btnProfesor;
        private System.Windows.Forms.Button btnTribunal;
        private System.Windows.Forms.Button btnGrupo;
        private System.Windows.Forms.Button btnTfc;
        private System.Windows.Forms.Label labelOpcion;
    }
}

