namespace RegistroTarea.UI.Consultas
{
    partial class ConsultaUsuarios
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
            this.VerListaUsuariosbutton = new System.Windows.Forms.Button();
            this.ListaUsuariosdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ListaUsuariosdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // VerListaUsuariosbutton
            // 
            this.VerListaUsuariosbutton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.VerListaUsuariosbutton.Image = global::RegistroTarea.Properties.Resources.Buscar;
            this.VerListaUsuariosbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VerListaUsuariosbutton.Location = new System.Drawing.Point(12, 20);
            this.VerListaUsuariosbutton.Name = "VerListaUsuariosbutton";
            this.VerListaUsuariosbutton.Size = new System.Drawing.Size(75, 30);
            this.VerListaUsuariosbutton.TabIndex = 0;
            this.VerListaUsuariosbutton.Text = "Ver lista";
            this.VerListaUsuariosbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VerListaUsuariosbutton.UseVisualStyleBackColor = false;
            this.VerListaUsuariosbutton.Click += new System.EventHandler(this.VerListaUsuariosbutton_Click);
            // 
            // ListaUsuariosdataGridView
            // 
            this.ListaUsuariosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaUsuariosdataGridView.Location = new System.Drawing.Point(12, 73);
            this.ListaUsuariosdataGridView.Name = "ListaUsuariosdataGridView";
            this.ListaUsuariosdataGridView.Size = new System.Drawing.Size(375, 251);
            this.ListaUsuariosdataGridView.TabIndex = 1;
            // 
            // ConsultaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(399, 336);
            this.Controls.Add(this.ListaUsuariosdataGridView);
            this.Controls.Add(this.VerListaUsuariosbutton);
            this.Name = "ConsultaUsuarios";
            this.Text = "ConsultaUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.ListaUsuariosdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VerListaUsuariosbutton;
        private System.Windows.Forms.DataGridView ListaUsuariosdataGridView;
    }
}