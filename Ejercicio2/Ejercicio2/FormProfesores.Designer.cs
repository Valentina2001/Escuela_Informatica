namespace Ejercicio2
{
    partial class FormProfesores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listProfesores = new System.Windows.Forms.ListView();
            this.colDNI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDomicilio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnLeer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listProfesores
            // 
            this.listProfesores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDNI,
            this.colNombre,
            this.colDomicilio});
            this.listProfesores.HideSelection = false;
            this.listProfesores.Location = new System.Drawing.Point(131, 69);
            this.listProfesores.Name = "listProfesores";
            this.listProfesores.Size = new System.Drawing.Size(520, 225);
            this.listProfesores.TabIndex = 0;
            this.listProfesores.UseCompatibleStateImageBehavior = false;
            this.listProfesores.View = System.Windows.Forms.View.Details;
            // 
            // colDNI
            // 
            this.colDNI.Text = "DNI";
            this.colDNI.Width = 122;
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre";
            this.colNombre.Width = 224;
            // 
            // colDomicilio
            // 
            this.colDomicilio.Text = "Domicilio";
            this.colDomicilio.Width = 163;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Profesores";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeer.Location = new System.Drawing.Point(131, 40);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 2;
            this.btnLeer.Text = "LEER";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listProfesores);
            this.Name = "FormProfesores";
            this.Text = "FormProfesores";
            this.Load += new System.EventHandler(this.FormProfesores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listProfesores;
        private System.Windows.Forms.ColumnHeader colDNI;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colDomicilio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLeer;
    }
}