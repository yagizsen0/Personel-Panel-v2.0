namespace PersonelPanel
{
    partial class form_istatistik
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
            this.Lbl_PersonelToplam = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_PersonelToplam
            // 
            this.Lbl_PersonelToplam.AutoSize = true;
            this.Lbl_PersonelToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_PersonelToplam.Location = new System.Drawing.Point(193, 43);
            this.Lbl_PersonelToplam.Name = "Lbl_PersonelToplam";
            this.Lbl_PersonelToplam.Size = new System.Drawing.Size(17, 18);
            this.Lbl_PersonelToplam.TabIndex = 12;
            this.Lbl_PersonelToplam.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(42, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "Kayıtlı Personel :";
            // 
            // form_istatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 113);
            this.Controls.Add(this.Lbl_PersonelToplam);
            this.Controls.Add(this.label9);
            this.MaximizeBox = false;
            this.Name = "form_istatistik";
            this.Text = "İstatistik";
            this.Load += new System.EventHandler(this.form_istatistik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_PersonelToplam;
        private System.Windows.Forms.Label label9;
    }
}