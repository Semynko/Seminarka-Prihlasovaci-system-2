namespace Autoskola
{
    partial class FormZapomenute
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
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.radioButtonNahodne = new System.Windows.Forms.RadioButton();
            this.radioButtonZadane = new System.Windows.Forms.RadioButton();
            this.buttonPotvrdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(117, 28);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(277, 20);
            this.textBoxEmail.TabIndex = 0;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(117, 99);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(277, 20);
            this.textBoxUsername.TabIndex = 1;
            // 
            // radioButtonNahodne
            // 
            this.radioButtonNahodne.AutoSize = true;
            this.radioButtonNahodne.Location = new System.Drawing.Point(117, 156);
            this.radioButtonNahodne.Name = "radioButtonNahodne";
            this.radioButtonNahodne.Size = new System.Drawing.Size(113, 17);
            this.radioButtonNahodne.TabIndex = 2;
            this.radioButtonNahodne.TabStop = true;
            this.radioButtonNahodne.Text = "Vygenerovat heslo";
            this.radioButtonNahodne.UseVisualStyleBackColor = true;
            // 
            // radioButtonZadane
            // 
            this.radioButtonZadane.AutoSize = true;
            this.radioButtonZadane.Location = new System.Drawing.Point(117, 197);
            this.radioButtonZadane.Name = "radioButtonZadane";
            this.radioButtonZadane.Size = new System.Drawing.Size(116, 17);
            this.radioButtonZadane.TabIndex = 3;
            this.radioButtonZadane.TabStop = true;
            this.radioButtonZadane.Text = "Zadat vlastní heslo";
            this.radioButtonZadane.UseVisualStyleBackColor = true;
            this.radioButtonZadane.CheckedChanged += new System.EventHandler(this.radioButtonZadane_CheckedChanged);
            // 
            // buttonPotvrdit
            // 
            this.buttonPotvrdit.Location = new System.Drawing.Point(236, 165);
            this.buttonPotvrdit.Name = "buttonPotvrdit";
            this.buttonPotvrdit.Size = new System.Drawing.Size(112, 49);
            this.buttonPotvrdit.TabIndex = 4;
            this.buttonPotvrdit.Text = "Potvrdit";
            this.buttonPotvrdit.UseVisualStyleBackColor = true;
            this.buttonPotvrdit.Click += new System.EventHandler(this.buttonPotvrdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "uživatelské jméno:";
            // 
            // FormZapomenute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 300);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPotvrdit);
            this.Controls.Add(this.radioButtonZadane);
            this.Controls.Add(this.radioButtonNahodne);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxEmail);
            this.Name = "FormZapomenute";
            this.Text = "FormZapomenute";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.RadioButton radioButtonNahodne;
        private System.Windows.Forms.RadioButton radioButtonZadane;
        private System.Windows.Forms.Button buttonPotvrdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}