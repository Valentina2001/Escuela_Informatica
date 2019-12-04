namespace Ejercicio2
{
    partial class FormTribunales
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
            this.listTribunales = new System.Windows.Forms.ListView();
            this.colNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLugarExamen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNumComponentes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTribunales = new System.Windows.Forms.Label();
            this.btnLeerTribunal = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listTribunales
            // 
            this.listTribunales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNum,
            this.colLugarExamen,
            this.colNumComponentes});
            this.listTribunales.HideSelection = false;
            this.listTribunales.Location = new System.Drawing.Point(148, 114);
            this.listTribunales.Name = "listTribunales";
            this.listTribunales.Size = new System.Drawing.Size(526, 199);
            this.listTribunales.TabIndex = 0;
            this.listTribunales.UseCompatibleStateImageBehavior = false;
            this.listTribunales.View = System.Windows.Forms.View.Details;
            // 
            // colNum
            // 
            this.colNum.Text = "Num";
            // 
            // colLugarExamen
            // 
            this.colLugarExamen.Text = "Lugar de Examen";
            this.colLugarExamen.Width = 236;
            // 
            // colNumComponentes
            // 
            this.colNumComponentes.Text = "Número de Componentes";
            this.colNumComponentes.Width = 223;
            // 
            // lblTribunales
            // 
            this.lblTribunales.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTribunales.Location = new System.Drawing.Point(307, 51);
            this.lblTribunales.Name = "lblTribunales";
            this.lblTribunales.Size = new System.Drawing.Size(204, 32);
            this.lblTribunales.TabIndex = 1;
            this.lblTribunales.Text = "Tribunales";
            this.lblTribunales.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLeerTribunal
            // 
            this.btnLeerTribunal.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeerTribunal.Location = new System.Drawing.Point(148, 77);
            this.btnLeerTribunal.Name = "btnLeerTribunal";
            this.btnLeerTribunal.Size = new System.Drawing.Size(75, 31);
            this.btnLeerTribunal.TabIndex = 2;
            this.btnLeerTribunal.Text = "Leer";
            this.btnLeerTribunal.UseVisualStyleBackColor = true;
            this.btnLeerTribunal.Click += new System.EventHandler(this.btnLeerTribunal_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(568, 77);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(106, 31);
            this.btnInicio.TabIndex = 3;
            this.btnInicio.Text = "Volver Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // FormTribunales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.btnLeerTribunal);
            this.Controls.Add(this.lblTribunales);
            this.Controls.Add(this.listTribunales);
            this.Name = "FormTribunales";
            this.Text = "FormTribunales";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listTribunales;
        private System.Windows.Forms.ColumnHeader colNum;
        private System.Windows.Forms.ColumnHeader colLugarExamen;
        private System.Windows.Forms.ColumnHeader colNumComponentes;
        private System.Windows.Forms.Label lblTribunales;
        private System.Windows.Forms.Button btnLeerTribunal;
        private System.Windows.Forms.Button btnInicio;
    }
}