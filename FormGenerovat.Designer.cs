namespace Autoskola
{
    partial class FormGenerovat
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelHeslo = new System.Windows.Forms.Label();
            this.labelKopirovat = new System.Windows.Forms.Label();
            this.buttonGenerovat = new System.Windows.Forms.Button();
            this.buttonPotvrdit = new System.Windows.Forms.Button();
            this.buttonKopirovat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generované heslo:";
            // 
            // labelHeslo
            // 
            this.labelHeslo.AutoSize = true;
            this.labelHeslo.Location = new System.Drawing.Point(170, 30);
            this.labelHeslo.Name = "labelHeslo";
            this.labelHeslo.Size = new System.Drawing.Size(0, 13);
            this.labelHeslo.TabIndex = 1;
            // 
            // labelKopirovat
            // 
            this.labelKopirovat.AutoSize = true;
            this.labelKopirovat.Location = new System.Drawing.Point(170, 70);
            this.labelKopirovat.Name = "labelKopirovat";
            this.labelKopirovat.Size = new System.Drawing.Size(0, 13);
            this.labelKopirovat.TabIndex = 2;
            // 
            // buttonGenerovat
            // 
            this.buttonGenerovat.Location = new System.Drawing.Point(70, 147);
            this.buttonGenerovat.Name = "buttonGenerovat";
            this.buttonGenerovat.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerovat.TabIndex = 3;
            this.buttonGenerovat.Text = "Generovat";
            this.buttonGenerovat.UseVisualStyleBackColor = true;
            this.buttonGenerovat.Click += new System.EventHandler(this.buttonGenerovat_Click);
            // 
            // buttonPotvrdit
            // 
            this.buttonPotvrdit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonPotvrdit.Location = new System.Drawing.Point(186, 147);
            this.buttonPotvrdit.Name = "buttonPotvrdit";
            this.buttonPotvrdit.Size = new System.Drawing.Size(75, 23);
            this.buttonPotvrdit.TabIndex = 4;
            this.buttonPotvrdit.Text = "Potvrdit";
            this.buttonPotvrdit.UseVisualStyleBackColor = true;
            this.buttonPotvrdit.Click += new System.EventHandler(this.buttonPotvrdit_Click);
            // 
            // buttonKopirovat
            // 
            this.buttonKopirovat.Location = new System.Drawing.Point(301, 147);
            this.buttonKopirovat.Name = "buttonKopirovat";
            this.buttonKopirovat.Size = new System.Drawing.Size(75, 23);
            this.buttonKopirovat.TabIndex = 5;
            this.buttonKopirovat.Text = "Kopírovat";
            this.buttonKopirovat.UseVisualStyleBackColor = true;
            this.buttonKopirovat.Click += new System.EventHandler(this.buttonKopirovat_Click);
            // 
            // FormGenerovat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 197);
            this.Controls.Add(this.buttonKopirovat);
            this.Controls.Add(this.buttonPotvrdit);
            this.Controls.Add(this.buttonGenerovat);
            this.Controls.Add(this.labelKopirovat);
            this.Controls.Add(this.labelHeslo);
            this.Controls.Add(this.label1);
            this.Name = "FormGenerovat";
            this.Text = "FormGenerovat";
            this.Load += new System.EventHandler(this.FormGenerovat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHeslo;
        private System.Windows.Forms.Label labelKopirovat;
        private System.Windows.Forms.Button buttonGenerovat;
        private System.Windows.Forms.Button buttonPotvrdit;
        private System.Windows.Forms.Button buttonKopirovat;
    }
}