
namespace Autoskola
{
    partial class FormPrihlaseni
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
            this.buttonRegistr = new System.Windows.Forms.Button();
            this.buttonZapomel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxJmeno = new System.Windows.Forms.TextBox();
            this.textBoxHeslo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonPrihlasit
            // 
            this.buttonPrihlasit.Location = new System.Drawing.Point(83, 214);
            this.buttonPrihlasit.Name = "buttonPrihlasit";
            this.buttonPrihlasit.Size = new System.Drawing.Size(191, 43);
            this.buttonPrihlasit.TabIndex = 0;
            this.buttonPrihlasit.Text = "Přihlásit se";
            this.buttonPrihlasit.UseVisualStyleBackColor = true;
            this.buttonPrihlasit.Click += new System.EventHandler(this.buttonPrihlasit_Click);
            // 
            // buttonRegistr
            // 
            this.buttonRegistr.Location = new System.Drawing.Point(30, 289);
            this.buttonRegistr.Name = "buttonRegistr";
            this.buttonRegistr.Size = new System.Drawing.Size(130, 34);
            this.buttonRegistr.TabIndex = 1;
            this.buttonRegistr.Text = "Registrovat";
            this.buttonRegistr.UseVisualStyleBackColor = true;
            this.buttonRegistr.Click += new System.EventHandler(this.buttonRegistr_Click);
            // 
            // buttonZapomel
            // 
            this.buttonZapomel.Location = new System.Drawing.Point(200, 289);
            this.buttonZapomel.Name = "buttonZapomel";
            this.buttonZapomel.Size = new System.Drawing.Size(132, 34);
            this.buttonZapomel.TabIndex = 2;
            this.buttonZapomel.Text = "Zapomenuté heslo";
            this.buttonZapomel.UseVisualStyleBackColor = true;
            this.buttonZapomel.Click += new System.EventHandler(this.buttonZapomel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Uživatelské jméno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Heslo:";
            // 
            // textBoxJmeno
            // 
            this.textBoxJmeno.Location = new System.Drawing.Point(130, 67);
            this.textBoxJmeno.Name = "textBoxJmeno";
            this.textBoxJmeno.Size = new System.Drawing.Size(232, 20);
            this.textBoxJmeno.TabIndex = 5;
            // 
            // textBoxHeslo
            // 
            this.textBoxHeslo.Location = new System.Drawing.Point(130, 103);
            this.textBoxHeslo.Name = "textBoxHeslo";
            this.textBoxHeslo.PasswordChar = '●';
            this.textBoxHeslo.Size = new System.Drawing.Size(232, 20);
            this.textBoxHeslo.TabIndex = 6;
            // 
            // FormPrihlaseni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 454);
            this.Controls.Add(this.textBoxHeslo);
            this.Controls.Add(this.textBoxJmeno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonZapomel);
            this.Controls.Add(this.buttonRegistr);
            this.Controls.Add(this.buttonPrihlasit);
            this.Name = "FormPrihlaseni";
            this.Text = "FormPrihlaseni";
            this.Enter += new System.EventHandler(this.FormPrihlaseni_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrihlasit;
        private System.Windows.Forms.Button buttonRegistr;
        private System.Windows.Forms.Button buttonZapomel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxJmeno;
        private System.Windows.Forms.TextBox textBoxHeslo;
    }
}