
namespace Autoskola
{
    partial class Form1
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
            this.buttonPrihlasit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonInformace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPrihlasit
            // 
            this.buttonPrihlasit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrihlasit.Location = new System.Drawing.Point(75, 181);
            this.buttonPrihlasit.Name = "buttonPrihlasit";
            this.buttonPrihlasit.Size = new System.Drawing.Size(872, 293);
            this.buttonPrihlasit.TabIndex = 0;
            this.buttonPrihlasit.Text = "Přihlásit se";
            this.buttonPrihlasit.UseVisualStyleBackColor = true;
            this.buttonPrihlasit.Click += new System.EventHandler(this.buttonPrihlasit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "AUTOŠKOLA";
            // 
            // buttonInformace
            // 
            this.buttonInformace.Location = new System.Drawing.Point(872, 533);
            this.buttonInformace.Name = "buttonInformace";
            this.buttonInformace.Size = new System.Drawing.Size(75, 23);
            this.buttonInformace.TabIndex = 2;
            this.buttonInformace.Text = "O aplikaci";
            this.buttonInformace.UseVisualStyleBackColor = true;
            this.buttonInformace.Click += new System.EventHandler(this.buttonInformace_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 595);
            this.Controls.Add(this.buttonInformace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPrihlasit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrihlasit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInformace;
    }
}

