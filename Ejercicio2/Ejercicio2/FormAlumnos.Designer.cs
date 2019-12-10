namespace Ejercicio2
{
    partial class FormAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlumnos));
            this.listAlumno = new System.Windows.Forms.ListView();
            this.colNumMatricula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDNI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnReadAlmno = new System.Windows.Forms.Button();
            this.txtNumMatricula = new System.Windows.Forms.TextBox();
            this.lblNumMatricula = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.btnActualizarAlumno = new System.Windows.Forms.Button();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listAlumno
            // 
            this.listAlumno.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNumMatricula,
            this.colDNI,
            this.colNombre});
            this.listAlumno.HideSelection = false;
            this.listAlumno.Location = new System.Drawing.Point(122, 95);
            this.listAlumno.Name = "listAlumno";
            this.listAlumno.Size = new System.Drawing.Size(527, 107);
            this.listAlumno.TabIndex = 0;
            this.listAlumno.UseCompatibleStateImageBehavior = false;
            this.listAlumno.View = System.Windows.Forms.View.Details;
            this.listAlumno.SelectedIndexChanged += new System.EventHandler(this.listAlumno_SelectedIndexChanged);
            // 
            // colNumMatricula
            // 
            this.colNumMatricula.Text = "Numero matricula";
            this.colNumMatricula.Width = 140;
            // 
            // colDNI
            // 
            this.colDNI.Text = "DNI";
            this.colDNI.Width = 161;
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre alumno";
            this.colNombre.Width = 216;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(286, 43);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(177, 28);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Lista Alumnos";
            // 
            // btnReadAlmno
            // 
            this.btnReadAlmno.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnReadAlmno.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnReadAlmno.Image = ((System.Drawing.Image)(resources.GetObject("btnReadAlmno.Image")));
            this.btnReadAlmno.Location = new System.Drawing.Point(122, 29);
            this.btnReadAlmno.Name = "btnReadAlmno";
            this.btnReadAlmno.Size = new System.Drawing.Size(66, 62);
            this.btnReadAlmno.TabIndex = 2;
            this.btnReadAlmno.UseVisualStyleBackColor = false;
            this.btnReadAlmno.Click += new System.EventHandler(this.btnReadAlmno_Click);
            // 
            // txtNumMatricula
            // 
            this.txtNumMatricula.Location = new System.Drawing.Point(169, 240);
            this.txtNumMatricula.Name = "txtNumMatricula";
            this.txtNumMatricula.Size = new System.Drawing.Size(249, 20);
            this.txtNumMatricula.TabIndex = 3;
            // 
            // lblNumMatricula
            // 
            this.lblNumMatricula.AutoSize = true;
            this.lblNumMatricula.Location = new System.Drawing.Point(74, 243);
            this.lblNumMatricula.Name = "lblNumMatricula";
            this.lblNumMatricula.Size = new System.Drawing.Size(89, 13);
            this.lblNumMatricula.TabIndex = 4;
            this.lblNumMatricula.Text = "Numero matricula";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(74, 274);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 6;
            this.lblDNI.Text = "DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(169, 271);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(249, 20);
            this.txtDNI.TabIndex = 5;
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Location = new System.Drawing.Point(74, 307);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(81, 13);
            this.lblNombreAlumno.TabIndex = 8;
            this.lblNombreAlumno.Text = "Nombre alumno";
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(169, 304);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(249, 20);
            this.txtNombreAlumno.TabIndex = 7;
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarAlumno.Image")));
            this.btnAgregarAlumno.Location = new System.Drawing.Point(434, 240);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(94, 94);
            this.btnAgregarAlumno.TabIndex = 9;
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // btnActualizarAlumno
            // 
            this.btnActualizarAlumno.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarAlumno.Image")));
            this.btnActualizarAlumno.Location = new System.Drawing.Point(534, 240);
            this.btnActualizarAlumno.Name = "btnActualizarAlumno";
            this.btnActualizarAlumno.Size = new System.Drawing.Size(92, 94);
            this.btnActualizarAlumno.TabIndex = 10;
            this.btnActualizarAlumno.UseVisualStyleBackColor = true;
            this.btnActualizarAlumno.Click += new System.EventHandler(this.btnActualizarAlumno_Click);
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarAlumno.Image")));
            this.btnEliminarAlumno.Location = new System.Drawing.Point(632, 240);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(96, 94);
            this.btnEliminarAlumno.TabIndex = 11;
            this.btnEliminarAlumno.UseVisualStyleBackColor = true;
            this.btnEliminarAlumno.Click += new System.EventHandler(this.btnEliminarAlumno_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(574, 66);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver inicio";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Agregar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Actualizar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(658, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Eliminar";
            // 
            // FormAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEliminarAlumno);
            this.Controls.Add(this.btnActualizarAlumno);
            this.Controls.Add(this.btnAgregarAlumno);
            this.Controls.Add(this.lblNombreAlumno);
            this.Controls.Add(this.txtNombreAlumno);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblNumMatricula);
            this.Controls.Add(this.txtNumMatricula);
            this.Controls.Add(this.btnReadAlmno);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.listAlumno);
            this.Name = "FormAlumnos";
            this.Text = "Menu Alumnos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listAlumno;
        private System.Windows.Forms.ColumnHeader colNumMatricula;
        private System.Windows.Forms.ColumnHeader colDNI;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnReadAlmno;
        private System.Windows.Forms.TextBox txtNumMatricula;
        private System.Windows.Forms.Label lblNumMatricula;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblNombreAlumno;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.Button btnActualizarAlumno;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}