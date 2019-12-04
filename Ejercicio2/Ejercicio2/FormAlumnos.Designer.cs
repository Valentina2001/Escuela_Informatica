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
            this.listAlumno = new System.Windows.Forms.ListView();
            this.colNumMatricula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDNI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnReadAlmno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listAlumno
            // 
            this.listAlumno.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNumMatricula,
            this.colDNI,
            this.colNombre});
            this.listAlumno.HideSelection = false;
            this.listAlumno.Location = new System.Drawing.Point(123, 98);
            this.listAlumno.Name = "listAlumno";
            this.listAlumno.Size = new System.Drawing.Size(527, 107);
            this.listAlumno.TabIndex = 0;
            this.listAlumno.UseCompatibleStateImageBehavior = false;
            this.listAlumno.View = System.Windows.Forms.View.Details;
            // 
            // colNumMatricula
            // 
            this.colNumMatricula.Text = "Numero matricula";
            this.colNumMatricula.Width = 141;
            // 
            // colDNI
            // 
            this.colDNI.Text = "DNI";
            this.colDNI.Width = 141;
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre alumno";
            this.colNombre.Width = 241;
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
            this.btnReadAlmno.Location = new System.Drawing.Point(123, 66);
            this.btnReadAlmno.Name = "btnReadAlmno";
            this.btnReadAlmno.Size = new System.Drawing.Size(75, 23);
            this.btnReadAlmno.TabIndex = 2;
            this.btnReadAlmno.Text = "Leer";
            this.btnReadAlmno.UseVisualStyleBackColor = true;
            this.btnReadAlmno.Click += new System.EventHandler(this.btnReadAlmno_Click);
            // 
            // menu_alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReadAlmno);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.listAlumno);
            this.Name = "menu_alumnos";
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
    }
}