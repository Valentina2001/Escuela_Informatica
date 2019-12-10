namespace Ejercicio2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.btnAlumno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAlumno.Image = ((System.Drawing.Image)(resources.GetObject("btnAlumno.Image")));
            this.btnAlumno.Location = new System.Drawing.Point(38, 261);
            this.btnAlumno.Name = "btnAlumno";
            this.btnAlumno.Size = new System.Drawing.Size(118, 110);
            this.btnAlumno.TabIndex = 2;
            this.btnAlumno.UseVisualStyleBackColor = false;
            this.btnAlumno.Click += new System.EventHandler(this.btnAlumno_Click);
            // 
            // btnProfesor
            // 
            this.btnProfesor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnProfesor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProfesor.Image = ((System.Drawing.Image)(resources.GetObject("btnProfesor.Image")));
            this.btnProfesor.Location = new System.Drawing.Point(192, 261);
            this.btnProfesor.Name = "btnProfesor";
            this.btnProfesor.Size = new System.Drawing.Size(117, 110);
            this.btnProfesor.TabIndex = 3;
            this.btnProfesor.UseVisualStyleBackColor = false;
            this.btnProfesor.Click += new System.EventHandler(this.btnProfesor_Click);
            // 
            // btnTribunal
            // 
            this.btnTribunal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTribunal.Image = ((System.Drawing.Image)(resources.GetObject("btnTribunal.Image")));
            this.btnTribunal.Location = new System.Drawing.Point(334, 261);
            this.btnTribunal.Name = "btnTribunal";
            this.btnTribunal.Size = new System.Drawing.Size(129, 110);
            this.btnTribunal.TabIndex = 4;
            this.btnTribunal.UseVisualStyleBackColor = false;
            this.btnTribunal.Click += new System.EventHandler(this.btnTribunal_Click);
            // 
            // btnGrupo
            // 
            this.btnGrupo.Image = ((System.Drawing.Image)(resources.GetObject("btnGrupo.Image")));
            this.btnGrupo.Location = new System.Drawing.Point(482, 261);
            this.btnGrupo.Name = "btnGrupo";
            this.btnGrupo.Size = new System.Drawing.Size(125, 110);
            this.btnGrupo.TabIndex = 5;
            this.btnGrupo.UseVisualStyleBackColor = true;
            this.btnGrupo.Click += new System.EventHandler(this.btnGrupo_Click);
            // 
            // btnTfc
            // 
            this.btnTfc.Image = ((System.Drawing.Image)(resources.GetObject("btnTfc.Image")));
            this.btnTfc.Location = new System.Drawing.Point(633, 261);
            this.btnTfc.Name = "btnTfc";
            this.btnTfc.Size = new System.Drawing.Size(124, 110);
            this.btnTfc.TabIndex = 6;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ver Alumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ver profesor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ver tribunal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ver Grupo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(669, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ver TFC";
            // 
            // menu_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Load += new System.EventHandler(this.menu_principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

