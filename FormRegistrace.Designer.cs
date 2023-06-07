
namespace Autoskola
{
    partial class FormRegistrace
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
            this.labe = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRegistrovat = new System.Windows.Forms.Button();
            this.textBoxJmeno = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxHeslo = new System.Windows.Forms.TextBox();
            this.textBoxPotvrdit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Location = new System.Drawing.Point(25, 56);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(23, 13);
            this.labe.TabIndex = 0;
            this.labe.Text = "UJ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Heslo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Potvrdit:";
            // 
            // buttonRegistrovat
            // 
            this.buttonRegistrovat.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonRegistrovat.Location = new System.Drawing.Point(92, 234);
            this.buttonRegistrovat.Name = "buttonRegistrovat";
            this.buttonRegistrovat.Size = new System.Drawing.Size(217, 64);
            this.buttonRegistrovat.TabIndex = 4;
            this.buttonRegistrovat.Text = "Registrovat";
            this.buttonRegistrovat.UseVisualStyleBackColor = true;
            this.buttonRegistrovat.Click += new System.EventHandler(this.buttonRegistrovat_Click);
            // 
            // textBoxJmeno
            // 
            this.textBoxJmeno.Location = new System.Drawing.Point(65, 53);
            this.textBoxJmeno.Name = "textBoxJmeno";
            this.textBoxJmeno.Size = new System.Drawing.Size(285, 20);
            this.textBoxJmeno.TabIndex = 5;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(65, 93);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(285, 20);
            this.textBoxEmail.TabIndex = 6;
            // 
            // textBoxHeslo
            // 
            this.textBoxHeslo.Location = new System.Drawing.Point(65, 134);
            this.textBoxHeslo.Name = "textBoxHeslo";
            this.textBoxHeslo.PasswordChar = '●';
            this.textBoxHeslo.Size = new System.Drawing.Size(285, 20);
            this.textBoxHeslo.TabIndex = 7;
            // 
            // textBoxPotvrdit
            // 
            this.textBoxPotvrdit.Location = new System.Drawing.Point(65, 171);
            this.textBoxPotvrdit.Name = "textBoxPotvrdit";
            this.textBoxPotvrdit.PasswordChar = '●';
            this.textBoxPotvrdit.Size = new System.Drawing.Size(285, 20);
            this.textBoxPotvrdit.TabIndex = 8;
            // 
            // FormRegistrace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 345);
            this.Controls.Add(this.textBoxPotvrdit);
            this.Controls.Add(this.textBoxHeslo);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxJmeno);
            this.Controls.Add(this.buttonRegistrovat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labe);
            this.Name = "FormRegistrace";
            this.Text = "FormRegistrace";
            this.Load += new System.EventHandler(this.FormRegistrace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRegistrovat;
        private System.Windows.Forms.TextBox textBoxJmeno;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxHeslo;
        private System.Windows.Forms.TextBox textBoxPotvrdit;
    }
}