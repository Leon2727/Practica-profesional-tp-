
namespace ProyectoPracticaProfesional.View
{
    partial class DifficultyForm
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
            this.buttonHard = new System.Windows.Forms.Button();
            this.buttonMedium = new System.Windows.Forms.Button();
            this.buttonEasy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonHard
            // 
            this.buttonHard.BackColor = System.Drawing.Color.Transparent;
            this.buttonHard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonHard.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonHard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonHard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHard.Location = new System.Drawing.Point(179, 595);
            this.buttonHard.Name = "buttonHard";
            this.buttonHard.Size = new System.Drawing.Size(298, 62);
            this.buttonHard.TabIndex = 0;
            this.buttonHard.UseVisualStyleBackColor = false;
            this.buttonHard.Click += new System.EventHandler(this.buttonHard_Click);
            // 
            // buttonMedium
            // 
            this.buttonMedium.BackColor = System.Drawing.Color.Transparent;
            this.buttonMedium.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonMedium.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonMedium.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonMedium.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMedium.Location = new System.Drawing.Point(179, 463);
            this.buttonMedium.Name = "buttonMedium";
            this.buttonMedium.Size = new System.Drawing.Size(298, 62);
            this.buttonMedium.TabIndex = 1;
            this.buttonMedium.UseVisualStyleBackColor = false;
            this.buttonMedium.Click += new System.EventHandler(this.buttonMedium_Click);
            // 
            // buttonEasy
            // 
            this.buttonEasy.BackColor = System.Drawing.Color.Transparent;
            this.buttonEasy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonEasy.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonEasy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonEasy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEasy.Location = new System.Drawing.Point(179, 345);
            this.buttonEasy.Name = "buttonEasy";
            this.buttonEasy.Size = new System.Drawing.Size(298, 62);
            this.buttonEasy.TabIndex = 2;
            this.buttonEasy.UseVisualStyleBackColor = false;
            this.buttonEasy.Click += new System.EventHandler(this.buttonEasy_Click);
            // 
            // DifficultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoPracticaProfesional.Properties.Resources.MenuElegirDificultad;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(654, 936);
            this.Controls.Add(this.buttonEasy);
            this.Controls.Add(this.buttonMedium);
            this.Controls.Add(this.buttonHard);
            this.Name = "DifficultyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi Primer Puzzle";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHard;
        private System.Windows.Forms.Button buttonMedium;
        private System.Windows.Forms.Button buttonEasy;
    }
}