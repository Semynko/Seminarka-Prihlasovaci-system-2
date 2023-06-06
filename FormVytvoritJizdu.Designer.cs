namespace Autoskola
{
    partial class FormVytvoritJizdu
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
            this.dtpJizda = new System.Windows.Forms.DateTimePicker();
            this.txtbxStudent = new System.Windows.Forms.TextBox();
            this.cmbxRidic = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnVytvoritJizdu
            // 
            this.BtnVytvoritJizdu.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnVytvoritJizdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnVytvoritJizdu.Location = new System.Drawing.Point(13, 266);
            this.BtnVytvoritJizdu.Name = "BtnVytvoritJizdu";
            this.BtnVytvoritJizdu.Size = new System.Drawing.Size(274, 114);
            this.BtnVytvoritJizdu.TabIndex = 2;
            this.BtnVytvoritJizdu.Text = "Vytvořit jízdu";
            this.BtnVytvoritJizdu.UseVisualStyleBackColor = true;
            this.BtnVytvoritJizdu.Click += new System.EventHandler(this.BtnVytvoritJizdu_Click);
            // 
            // dtpJizda
            // 
            this.dtpJizda.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpJizda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpJizda.Location = new System.Drawing.Point(12, 50);
            this.dtpJizda.Name = "dtpJizda";
            this.dtpJizda.Size = new System.Drawing.Size(276, 31);
            this.dtpJizda.TabIndex = 3;
            // 
            // txtbxStudent
            // 
            this.txtbxStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtbxStudent.Location = new System.Drawing.Point(12, 119);
            this.txtbxStudent.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxStudent.Name = "txtbxStudent";
            this.txtbxStudent.Size = new System.Drawing.Size(276, 28);
            this.txtbxStudent.TabIndex = 4;
            // 
            // cmbxRidic
            // 
            this.cmbxRidic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbxRidic.FormattingEnabled = true;
            this.cmbxRidic.Location = new System.Drawing.Point(12, 194);
            this.cmbxRidic.Margin = new System.Windows.Forms.Padding(2);
            this.cmbxRidic.Name = "cmbxRidic";
            this.cmbxRidic.Size = new System.Drawing.Size(276, 32);
            this.cmbxRidic.TabIndex = 5;
            this.cmbxRidic.SelectedIndexChanged += new System.EventHandler(this.cmbxRidic_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Datum a čas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(9, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Jméno studenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(9, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Instruktor";
            // 
            // FormVytvoritJizdu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 391);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbxRidic);
            this.Controls.Add(this.txtbxStudent);
            this.Controls.Add(this.dtpJizda);
            this.Controls.Add(this.BtnVytvoritJizdu);
            this.Name = "FormVytvoritJizdu";
            this.Text = "FormVytvoritJizdu";
            this.Load += new System.EventHandler(this.FormVytvoritJizdu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVytvoritJizdu;
        private System.Windows.Forms.DateTimePicker dtpJizda;
        private System.Windows.Forms.TextBox txtbxStudent;
        private System.Windows.Forms.ComboBox cmbxRidic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}