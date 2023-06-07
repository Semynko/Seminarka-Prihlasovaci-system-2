namespace Autoskola
{
    partial class FormVlastniHeslo
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
            this.textBoxNoveHeslo = new System.Windows.Forms.TextBox();
            this.textBoxPotvrdit = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.labelNoveHeslo = new System.Windows.Forms.Label();
            this.labelPotvrdit = new System.Windows.Forms.Label();
            this.labelKopirovat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNoveHeslo
            // 
            this.textBoxNoveHeslo.Location = new System.Drawing.Point(108, 26);
            this.textBoxNoveHeslo.Name = "textBoxNoveHeslo";
            this.textBoxNoveHeslo.PasswordChar = '●';
            this.textBoxNoveHeslo.Size = new System.Drawing.Size(219, 20);
            this.textBoxNoveHeslo.TabIndex = 0;
            // 
            // textBoxPotvrdit
            // 
            this.textBoxPotvrdit.Location = new System.Drawing.Point(108, 65);
            this.textBoxPotvrdit.Name = "textBoxPotvrdit";
            this.textBoxPotvrdit.PasswordChar = '●';
            this.textBoxPotvrdit.Size = new System.Drawing.Size(219, 20);
            this.textBoxPotvrdit.TabIndex = 1;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(108, 119);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(91, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "Potvrdit";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(220, 119);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(91, 23);
            this.buttonCopy.TabIndex = 3;
            this.buttonCopy.Text = "Kopirovat";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // labelNoveHeslo
            // 
            this.labelNoveHeslo.AutoSize = true;
            this.labelNoveHeslo.Location = new System.Drawing.Point(41, 29);
            this.labelNoveHeslo.Name = "labelNoveHeslo";
            this.labelNoveHeslo.Size = new System.Drawing.Size(64, 13);
            this.labelNoveHeslo.TabIndex = 4;
            this.labelNoveHeslo.Text = "Nové heslo:";
            // 
            // labelPotvrdit
            // 
            this.labelPotvrdit.AutoSize = true;
            this.labelPotvrdit.Location = new System.Drawing.Point(28, 68);
            this.labelPotvrdit.Name = "labelPotvrdit";
            this.labelPotvrdit.Size = new System.Drawing.Size(74, 13);
            this.labelPotvrdit.TabIndex = 5;
            this.labelPotvrdit.Text = "Potvrdit heslo:";
            // 
            // labelKopirovat
            // 
            this.labelKopirovat.AutoSize = true;
            this.labelKopirovat.Location = new System.Drawing.Point(105, 103);
            this.labelKopirovat.Name = "labelKopirovat";
            this.labelKopirovat.Size = new System.Drawing.Size(0, 13);
            this.labelKopirovat.TabIndex = 6;
            // 
            // FormVlastniHeslo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 189);
            this.Controls.Add(this.labelKopirovat);
            this.Controls.Add(this.labelPotvrdit);
            this.Controls.Add(this.labelNoveHeslo);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxPotvrdit);
            this.Controls.Add(this.textBoxNoveHeslo);
            this.Name = "FormVlastniHeslo";
            this.Text = "FormVlastniHeslo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNoveHeslo;
        private System.Windows.Forms.TextBox textBoxPotvrdit;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Label labelNoveHeslo;
        private System.Windows.Forms.Label labelPotvrdit;
        private System.Windows.Forms.Label labelKopirovat;
    }
}