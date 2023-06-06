namespace Autoskola
{
    partial class FormJizdy
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
            this.BtnVytvoritJizdu = new System.Windows.Forms.Button();
            this.BtnOdstranitJizdu = new System.Windows.Forms.Button();
            this.BtnUpravitJizdu = new System.Windows.Forms.Button();
            this.lbxSeznamJizd = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnVytvoritJizdu
            // 
            this.BtnVytvoritJizdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnVytvoritJizdu.Location = new System.Drawing.Point(41, 46);
            this.BtnVytvoritJizdu.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVytvoritJizdu.Name = "BtnVytvoritJizdu";
            this.BtnVytvoritJizdu.Size = new System.Drawing.Size(264, 140);
            this.BtnVytvoritJizdu.TabIndex = 1;
            this.BtnVytvoritJizdu.Text = "Vytvořit jízdy";
            this.BtnVytvoritJizdu.UseVisualStyleBackColor = true;
            this.BtnVytvoritJizdu.Click += new System.EventHandler(this.BtnVytvoritJizdu_Click);
            // 
            // BtnOdstranitJizdu
            // 
            this.BtnOdstranitJizdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnOdstranitJizdu.Location = new System.Drawing.Point(41, 368);
            this.BtnOdstranitJizdu.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOdstranitJizdu.Name = "BtnOdstranitJizdu";
            this.BtnOdstranitJizdu.Size = new System.Drawing.Size(264, 140);
            this.BtnOdstranitJizdu.TabIndex = 3;
            this.BtnOdstranitJizdu.Text = "Odstranit jízdu";
            this.BtnOdstranitJizdu.UseVisualStyleBackColor = true;
            this.BtnOdstranitJizdu.Click += new System.EventHandler(this.BtnOdstranitJizdu_Click);
            // 
            // BtnUpravitJizdu
            // 
            this.BtnUpravitJizdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnUpravitJizdu.Location = new System.Drawing.Point(41, 206);
            this.BtnUpravitJizdu.Margin = new System.Windows.Forms.Padding(4);
            this.BtnUpravitJizdu.Name = "BtnUpravitJizdu";
            this.BtnUpravitJizdu.Size = new System.Drawing.Size(264, 140);
            this.BtnUpravitJizdu.TabIndex = 2;
            this.BtnUpravitJizdu.Text = "Upravit jízdu";
            this.BtnUpravitJizdu.UseVisualStyleBackColor = true;
            this.BtnUpravitJizdu.Click += new System.EventHandler(this.BtnUpravitJizdu_Click);
            // 
            // lbxSeznamJizd
            // 
            this.lbxSeznamJizd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbxSeznamJizd.FormattingEnabled = true;
            this.lbxSeznamJizd.ItemHeight = 25;
            this.lbxSeznamJizd.Location = new System.Drawing.Point(401, 46);
            this.lbxSeznamJizd.Margin = new System.Windows.Forms.Padding(4);
            this.lbxSeznamJizd.Name = "lbxSeznamJizd";
            this.lbxSeznamJizd.Size = new System.Drawing.Size(597, 454);
            this.lbxSeznamJizd.TabIndex = 4;
            // 
            // FormJizdy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 658);
            this.Controls.Add(this.lbxSeznamJizd);
            this.Controls.Add(this.BtnOdstranitJizdu);
            this.Controls.Add(this.BtnUpravitJizdu);
            this.Controls.Add(this.BtnVytvoritJizdu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormJizdy";
            this.Text = "FormJizdy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVytvoritJizdu;
        private System.Windows.Forms.Button BtnOdstranitJizdu;
        private System.Windows.Forms.Button BtnUpravitJizdu;
        private System.Windows.Forms.ListBox lbxSeznamJizd;
    }

}