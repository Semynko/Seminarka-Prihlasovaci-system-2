
namespace Autoskola
{
    partial class FormSystem
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
            this.BtnJizdy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnJizdy
            // 
            this.BtnJizdy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnJizdy.Location = new System.Drawing.Point(23, 25);
            this.BtnJizdy.Name = "BtnJizdy";
            this.BtnJizdy.Size = new System.Drawing.Size(198, 114);
            this.BtnJizdy.TabIndex = 0;
            this.BtnJizdy.Text = "Jízdy";
            this.BtnJizdy.UseVisualStyleBackColor = true;
            this.BtnJizdy.Click += new System.EventHandler(this.BtnJizdy_Click);
            // 
            // FormSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 603);
            this.Controls.Add(this.BtnJizdy);
            this.Name = "FormSystem";
            this.Text = "FormSystem";
            this.Enter += new System.EventHandler(this.FormSystem_Enter);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnJizdy;
    }
}