
namespace ProyectoPracticaProfesional
{
    partial class home
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonPla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // buttonPla
            // 
            this.buttonPla.BackColor = System.Drawing.Color.Transparent;
            this.buttonPla.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonPla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPla.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPla.Location = new System.Drawing.Point(197, 760);
            this.buttonPla.Name = "buttonPla";
            this.buttonPla.Size = new System.Drawing.Size(255, 68);
            this.buttonPla.TabIndex = 0;
            this.buttonPla.UseVisualStyleBackColor = false;
            this.buttonPla.Click += new System.EventHandler(this.buttonPla_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::ProyectoPracticaProfesional.Properties.Resources.MenuPrincipal_TPFinal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(654, 928);
            this.Controls.Add(this.buttonPla);
            this.DoubleBuffered = true;
            this.Name = "home";
            this.Text = "Mi Primer Puzzle";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonPla;
    }
}

