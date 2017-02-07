namespace RegistroTarea.UI.Consultas
{
    partial class ConsultaPeliculas
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
            this.VerListaPeliculasbutton = new System.Windows.Forms.Button();
            this.ListaPeliculasdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ListaPeliculasdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // VerListaPeliculasbutton
            // 
            this.VerListaPeliculasbutton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.VerListaPeliculasbutton.Image = global::RegistroTarea.Properties.Resources.Buscar;
            this.VerListaPeliculasbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VerListaPeliculasbutton.Location = new System.Drawing.Point(12, 24);
            this.VerListaPeliculasbutton.Name = "VerListaPeliculasbutton";
            this.VerListaPeliculasbutton.Size = new System.Drawing.Size(75, 29);
            this.VerListaPeliculasbutton.TabIndex = 0;
            this.VerListaPeliculasbutton.Text = "Ver lista";
            this.VerListaPeliculasbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VerListaPeliculasbutton.UseVisualStyleBackColor = false;
            this.VerListaPeliculasbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListaPeliculasdataGridView
            // 
            this.ListaPeliculasdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaPeliculasdataGridView.Location = new System.Drawing.Point(13, 87);
            this.ListaPeliculasdataGridView.Name = "ListaPeliculasdataGridView";
            this.ListaPeliculasdataGridView.Size = new System.Drawing.Size(357, 227);
            this.ListaPeliculasdataGridView.TabIndex = 1;
            // 
            // ConsultaPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(382, 326);
            this.Controls.Add(this.ListaPeliculasdataGridView);
            this.Controls.Add(this.VerListaPeliculasbutton);
            this.Name = "ConsultaPeliculas";
            this.Text = "ConsultaPeliculas";
            ((System.ComponentModel.ISupportInitialize)(this.ListaPeliculasdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VerListaPeliculasbutton;
        private System.Windows.Forms.DataGridView ListaPeliculasdataGridView;
    }
}