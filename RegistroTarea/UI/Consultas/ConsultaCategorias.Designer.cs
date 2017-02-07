namespace RegistroTarea.UI.Consultas
{
    partial class ConsultaCategorias
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
            this.VerListabutton = new System.Windows.Forms.Button();
            this.ListaCategoriasdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ListaCategoriasdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // VerListabutton
            // 
            this.VerListabutton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.VerListabutton.Image = global::RegistroTarea.Properties.Resources.Buscar;
            this.VerListabutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VerListabutton.Location = new System.Drawing.Point(12, 37);
            this.VerListabutton.Name = "VerListabutton";
            this.VerListabutton.Size = new System.Drawing.Size(75, 29);
            this.VerListabutton.TabIndex = 0;
            this.VerListabutton.Text = "Ver lista";
            this.VerListabutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VerListabutton.UseVisualStyleBackColor = false;
            this.VerListabutton.Click += new System.EventHandler(this.VerListabutton_Click);
            // 
            // ListaCategoriasdataGridView
            // 
            this.ListaCategoriasdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaCategoriasdataGridView.Location = new System.Drawing.Point(13, 82);
            this.ListaCategoriasdataGridView.Name = "ListaCategoriasdataGridView";
            this.ListaCategoriasdataGridView.Size = new System.Drawing.Size(396, 251);
            this.ListaCategoriasdataGridView.TabIndex = 1;
            // 
            // ConsultaCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(418, 340);
            this.Controls.Add(this.ListaCategoriasdataGridView);
            this.Controls.Add(this.VerListabutton);
            this.Name = "ConsultaCategorias";
            this.Text = "ConsultaCategorias";
            ((System.ComponentModel.ISupportInitialize)(this.ListaCategoriasdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VerListabutton;
        private System.Windows.Forms.DataGridView ListaCategoriasdataGridView;
    }
}