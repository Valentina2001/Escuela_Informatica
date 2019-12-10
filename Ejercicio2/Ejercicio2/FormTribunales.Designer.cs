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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTribunales));
            this.listTribunales = new System.Windows.Forms.ListView();
            this.colNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLugarExamen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNumComponentes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTribunales = new System.Windows.Forms.Label();
            this.btnLeerTribunal = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.lblNumTribunal = new System.Windows.Forms.Label();
            this.txtNumTribunal = new System.Windows.Forms.TextBox();
            this.txtLugarExamen = new System.Windows.Forms.TextBox();
            this.lblLugarExamenTribunal = new System.Windows.Forms.Label();
            this.txtNumComponentes = new System.Windows.Forms.TextBox();
            this.lblNumComponentesTribunal = new System.Windows.Forms.Label();
            this.btnAgregarTribunal = new System.Windows.Forms.Button();
            this.btnActualizarTribunal = new System.Windows.Forms.Button();
            this.btnEliminarTribunal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listTribunales
            // 
            this.listTribunales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNum,
            this.colLugarExamen,
            this.colNumComponentes});
            this.listTribunales.HideSelection = false;
            this.listTribunales.Location = new System.Drawing.Point(62, 114);
            this.listTribunales.Name = "listTribunales";
            this.listTribunales.Size = new System.Drawing.Size(648, 199);
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
            this.colLugarExamen.Width = 287;
            // 
            // colNumComponentes
            // 
            this.colNumComponentes.Text = "Número de Componentes";
            this.colNumComponentes.Width = 291;
            // 
            // lblTribunales
            // 
            this.lblTribunales.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTribunales.Location = new System.Drawing.Point(295, 52);
            this.lblTribunales.Name = "lblTribunales";
            this.lblTribunales.Size = new System.Drawing.Size(204, 32);
            this.lblTribunales.TabIndex = 1;
            this.lblTribunales.Text = "Tribunales";
            this.lblTribunales.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLeerTribunal
            // 
            this.btnLeerTribunal.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeerTribunal.Image = ((System.Drawing.Image)(resources.GetObject("btnLeerTribunal.Image")));
            this.btnLeerTribunal.Location = new System.Drawing.Point(62, 52);
            this.btnLeerTribunal.Name = "btnLeerTribunal";
            this.btnLeerTribunal.Size = new System.Drawing.Size(64, 56);
            this.btnLeerTribunal.TabIndex = 2;
            this.btnLeerTribunal.UseVisualStyleBackColor = true;
            this.btnLeerTribunal.Click += new System.EventHandler(this.btnLeerTribunal_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(604, 77);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(106, 31);
            this.btnInicio.TabIndex = 3;
            this.btnInicio.Text = "Volver Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // lblNumTribunal
            // 
            this.lblNumTribunal.AutoSize = true;
            this.lblNumTribunal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumTribunal.Location = new System.Drawing.Point(60, 335);
            this.lblNumTribunal.Name = "lblNumTribunal";
            this.lblNumTribunal.Size = new System.Drawing.Size(37, 15);
            this.lblNumTribunal.TabIndex = 4;
            this.lblNumTribunal.Text = "Num";
            // 
            // txtNumTribunal
            // 
            this.txtNumTribunal.Location = new System.Drawing.Point(187, 335);
            this.txtNumTribunal.Name = "txtNumTribunal";
            this.txtNumTribunal.Size = new System.Drawing.Size(212, 20);
            this.txtNumTribunal.TabIndex = 5;
            // 
            // txtLugarExamen
            // 
            this.txtLugarExamen.Location = new System.Drawing.Point(187, 360);
            this.txtLugarExamen.Name = "txtLugarExamen";
            this.txtLugarExamen.Size = new System.Drawing.Size(212, 20);
            this.txtLugarExamen.TabIndex = 7;
            // 
            // lblLugarExamenTribunal
            // 
            this.lblLugarExamenTribunal.AutoSize = true;
            this.lblLugarExamenTribunal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugarExamenTribunal.Location = new System.Drawing.Point(60, 361);
            this.lblLugarExamenTribunal.Name = "lblLugarExamenTribunal";
            this.lblLugarExamenTribunal.Size = new System.Drawing.Size(120, 15);
            this.lblLugarExamenTribunal.TabIndex = 6;
            this.lblLugarExamenTribunal.Text = "Lugar de Examen";
            // 
            // txtNumComponentes
            // 
            this.txtNumComponentes.Location = new System.Drawing.Point(187, 386);
            this.txtNumComponentes.Name = "txtNumComponentes";
            this.txtNumComponentes.Size = new System.Drawing.Size(212, 20);
            this.txtNumComponentes.TabIndex = 9;
            // 
            // lblNumComponentesTribunal
            // 
            this.lblNumComponentesTribunal.AutoSize = true;
            this.lblNumComponentesTribunal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumComponentesTribunal.Location = new System.Drawing.Point(60, 387);
            this.lblNumComponentesTribunal.Name = "lblNumComponentesTribunal";
            this.lblNumComponentesTribunal.Size = new System.Drawing.Size(121, 15);
            this.lblNumComponentesTribunal.TabIndex = 8;
            this.lblNumComponentesTribunal.Text = "No. Componentes";
            // 
            // btnAgregarTribunal
            // 
            this.btnAgregarTribunal.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTribunal.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarTribunal.Image")));
            this.btnAgregarTribunal.Location = new System.Drawing.Point(442, 349);
            this.btnAgregarTribunal.Name = "btnAgregarTribunal";
            this.btnAgregarTribunal.Size = new System.Drawing.Size(89, 88);
            this.btnAgregarTribunal.TabIndex = 10;
            this.btnAgregarTribunal.UseVisualStyleBackColor = true;
            this.btnAgregarTribunal.Click += new System.EventHandler(this.btnAgregarTribunal_Click);
            // 
            // btnActualizarTribunal
            // 
            this.btnActualizarTribunal.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarTribunal.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarTribunal.Image")));
            this.btnActualizarTribunal.Location = new System.Drawing.Point(552, 349);
            this.btnActualizarTribunal.Name = "btnActualizarTribunal";
            this.btnActualizarTribunal.Size = new System.Drawing.Size(91, 88);
            this.btnActualizarTribunal.TabIndex = 11;
            this.btnActualizarTribunal.UseVisualStyleBackColor = true;
            this.btnActualizarTribunal.Click += new System.EventHandler(this.btnActualizarTribunal_Click);
            // 
            // btnEliminarTribunal
            // 
            this.btnEliminarTribunal.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTribunal.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarTribunal.Image")));
            this.btnEliminarTribunal.Location = new System.Drawing.Point(661, 349);
            this.btnEliminarTribunal.Name = "btnEliminarTribunal";
            this.btnEliminarTribunal.Size = new System.Drawing.Size(89, 87);
            this.btnEliminarTribunal.TabIndex = 12;
            this.btnEliminarTribunal.UseVisualStyleBackColor = true;
            this.btnEliminarTribunal.Click += new System.EventHandler(this.btnEliminarTribunal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Añadir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Actualizar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(680, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Eliminar";
            // 
            // FormTribunales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarTribunal);
            this.Controls.Add(this.btnActualizarTribunal);
            this.Controls.Add(this.btnAgregarTribunal);
            this.Controls.Add(this.txtNumComponentes);
            this.Controls.Add(this.lblNumComponentesTribunal);
            this.Controls.Add(this.txtLugarExamen);
            this.Controls.Add(this.lblLugarExamenTribunal);
            this.Controls.Add(this.txtNumTribunal);
            this.Controls.Add(this.lblNumTribunal);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.btnLeerTribunal);
            this.Controls.Add(this.lblTribunales);
            this.Controls.Add(this.listTribunales);
            this.Name = "FormTribunales";
            this.Text = "FormTribunales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listTribunales;
        private System.Windows.Forms.ColumnHeader colNum;
        private System.Windows.Forms.ColumnHeader colLugarExamen;
        private System.Windows.Forms.ColumnHeader colNumComponentes;
        private System.Windows.Forms.Label lblTribunales;
        private System.Windows.Forms.Button btnLeerTribunal;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label lblNumTribunal;
        private System.Windows.Forms.TextBox txtNumTribunal;
        private System.Windows.Forms.TextBox txtLugarExamen;
        private System.Windows.Forms.Label lblLugarExamenTribunal;
        private System.Windows.Forms.TextBox txtNumComponentes;
        private System.Windows.Forms.Label lblNumComponentesTribunal;
        private System.Windows.Forms.Button btnAgregarTribunal;
        private System.Windows.Forms.Button btnActualizarTribunal;
        private System.Windows.Forms.Button btnEliminarTribunal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}