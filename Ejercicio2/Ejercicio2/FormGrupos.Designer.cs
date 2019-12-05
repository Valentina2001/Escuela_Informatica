namespace Ejercicio2
{
    partial class FormGrupos
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
            this.listGrupos = new System.Windows.Forms.ListView();
            this.colNumGrupo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombreGrupo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNumComponente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLeerGrupo = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNumgrupo = new System.Windows.Forms.Label();
            this.txtNumGrupo = new System.Windows.Forms.TextBox();
            this.txtNombreGrupo = new System.Windows.Forms.TextBox();
            this.lblNombreGrupo = new System.Windows.Forms.Label();
            this.txtNumComponente = new System.Windows.Forms.TextBox();
            this.lblNumcomponentes = new System.Windows.Forms.Label();
            this.btnAgregarGrupo = new System.Windows.Forms.Button();
            this.btnActualizarGrupo = new System.Windows.Forms.Button();
            this.btnEliminarGrupo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listGrupos
            // 
            this.listGrupos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNumGrupo,
            this.colNombreGrupo,
            this.colNumComponente});
            this.listGrupos.HideSelection = false;
            this.listGrupos.Location = new System.Drawing.Point(34, 104);
            this.listGrupos.Name = "listGrupos";
            this.listGrupos.Size = new System.Drawing.Size(738, 116);
            this.listGrupos.TabIndex = 0;
            this.listGrupos.UseCompatibleStateImageBehavior = false;
            this.listGrupos.View = System.Windows.Forms.View.Details;
            // 
            // colNumGrupo
            // 
            this.colNumGrupo.Text = "Numero Grupo";
            this.colNumGrupo.Width = 210;
            // 
            // colNombreGrupo
            // 
            this.colNombreGrupo.Text = "Nombre del grupo";
            this.colNombreGrupo.Width = 271;
            // 
            // colNumComponente
            // 
            this.colNumComponente.Text = "Numero de componente";
            this.colNumComponente.Width = 246;
            // 
            // btnLeerGrupo
            // 
            this.btnLeerGrupo.Location = new System.Drawing.Point(34, 69);
            this.btnLeerGrupo.Name = "btnLeerGrupo";
            this.btnLeerGrupo.Size = new System.Drawing.Size(75, 23);
            this.btnLeerGrupo.TabIndex = 1;
            this.btnLeerGrupo.Text = "Listar";
            this.btnLeerGrupo.UseVisualStyleBackColor = true;
            this.btnLeerGrupo.Click += new System.EventHandler(this.btnLeerGrupo_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(687, 68);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver inicio";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(246, 52);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(138, 25);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Lista Grupos";
            // 
            // lblNumgrupo
            // 
            this.lblNumgrupo.AutoSize = true;
            this.lblNumgrupo.Location = new System.Drawing.Point(34, 261);
            this.lblNumgrupo.Name = "lblNumgrupo";
            this.lblNumgrupo.Size = new System.Drawing.Size(73, 13);
            this.lblNumgrupo.TabIndex = 4;
            this.lblNumgrupo.Text = "NumeroGrupo";
            // 
            // txtNumGrupo
            // 
            this.txtNumGrupo.Location = new System.Drawing.Point(154, 258);
            this.txtNumGrupo.Name = "txtNumGrupo";
            this.txtNumGrupo.Size = new System.Drawing.Size(194, 20);
            this.txtNumGrupo.TabIndex = 5;
            // 
            // txtNombreGrupo
            // 
            this.txtNombreGrupo.Location = new System.Drawing.Point(154, 295);
            this.txtNombreGrupo.Name = "txtNombreGrupo";
            this.txtNombreGrupo.Size = new System.Drawing.Size(194, 20);
            this.txtNombreGrupo.TabIndex = 7;
            // 
            // lblNombreGrupo
            // 
            this.lblNombreGrupo.AutoSize = true;
            this.lblNombreGrupo.Location = new System.Drawing.Point(34, 298);
            this.lblNombreGrupo.Name = "lblNombreGrupo";
            this.lblNombreGrupo.Size = new System.Drawing.Size(91, 13);
            this.lblNombreGrupo.TabIndex = 6;
            this.lblNombreGrupo.Text = "Nombre del grupo";
            // 
            // txtNumComponente
            // 
            this.txtNumComponente.Location = new System.Drawing.Point(154, 332);
            this.txtNumComponente.Name = "txtNumComponente";
            this.txtNumComponente.Size = new System.Drawing.Size(194, 20);
            this.txtNumComponente.TabIndex = 9;
            // 
            // lblNumcomponentes
            // 
            this.lblNumcomponentes.AutoSize = true;
            this.lblNumcomponentes.Location = new System.Drawing.Point(34, 335);
            this.lblNumcomponentes.Name = "lblNumcomponentes";
            this.lblNumcomponentes.Size = new System.Drawing.Size(106, 13);
            this.lblNumcomponentes.TabIndex = 8;
            this.lblNumcomponentes.Text = "Numero componente";
            // 
            // btnAgregarGrupo
            // 
            this.btnAgregarGrupo.Location = new System.Drawing.Point(434, 261);
            this.btnAgregarGrupo.Name = "btnAgregarGrupo";
            this.btnAgregarGrupo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarGrupo.TabIndex = 10;
            this.btnAgregarGrupo.Text = "Agregar";
            this.btnAgregarGrupo.UseVisualStyleBackColor = true;
            this.btnAgregarGrupo.Click += new System.EventHandler(this.btnAgregarGrupo_Click);
            // 
            // btnActualizarGrupo
            // 
            this.btnActualizarGrupo.Location = new System.Drawing.Point(434, 294);
            this.btnActualizarGrupo.Name = "btnActualizarGrupo";
            this.btnActualizarGrupo.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarGrupo.TabIndex = 11;
            this.btnActualizarGrupo.Text = "Actualizar";
            this.btnActualizarGrupo.UseVisualStyleBackColor = true;
            this.btnActualizarGrupo.Click += new System.EventHandler(this.btnActualizarGrupo_Click);
            // 
            // btnEliminarGrupo
            // 
            this.btnEliminarGrupo.Location = new System.Drawing.Point(434, 325);
            this.btnEliminarGrupo.Name = "btnEliminarGrupo";
            this.btnEliminarGrupo.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarGrupo.TabIndex = 12;
            this.btnEliminarGrupo.Text = "Eliminar";
            this.btnEliminarGrupo.UseVisualStyleBackColor = true;
            this.btnEliminarGrupo.Click += new System.EventHandler(this.btnEliminarGrupo_Click);
            // 
            // FormGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarGrupo);
            this.Controls.Add(this.btnActualizarGrupo);
            this.Controls.Add(this.btnAgregarGrupo);
            this.Controls.Add(this.txtNumComponente);
            this.Controls.Add(this.lblNumcomponentes);
            this.Controls.Add(this.txtNombreGrupo);
            this.Controls.Add(this.lblNombreGrupo);
            this.Controls.Add(this.txtNumGrupo);
            this.Controls.Add(this.lblNumgrupo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLeerGrupo);
            this.Controls.Add(this.listGrupos);
            this.Name = "FormGrupos";
            this.Text = "FormGrupos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listGrupos;
        private System.Windows.Forms.ColumnHeader colNumGrupo;
        private System.Windows.Forms.ColumnHeader colNombreGrupo;
        private System.Windows.Forms.ColumnHeader colNumComponente;
        private System.Windows.Forms.Button btnLeerGrupo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNumgrupo;
        private System.Windows.Forms.TextBox txtNumGrupo;
        private System.Windows.Forms.TextBox txtNombreGrupo;
        private System.Windows.Forms.Label lblNombreGrupo;
        private System.Windows.Forms.TextBox txtNumComponente;
        private System.Windows.Forms.Label lblNumcomponentes;
        private System.Windows.Forms.Button btnAgregarGrupo;
        private System.Windows.Forms.Button btnActualizarGrupo;
        private System.Windows.Forms.Button btnEliminarGrupo;
    }
}