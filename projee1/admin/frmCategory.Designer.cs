namespace projee1.admin
{
    partial class frmCategory
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
            this.textKategoriadı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextAcıklama = new System.Windows.Forms.RichTextBox();
            this.frmsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textKategoriadı
            // 
            this.textKategoriadı.Location = new System.Drawing.Point(90, 29);
            this.textKategoriadı.Name = "textKategoriadı";
            this.textKategoriadı.Size = new System.Drawing.Size(229, 22);
            this.textKategoriadı.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 32);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategori Adi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 90);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Acıklama";
            // 
            // richTextAcıklama
            // 
            this.richTextAcıklama.Location = new System.Drawing.Point(90, 90);
            this.richTextAcıklama.Name = "richTextAcıklama";
            this.richTextAcıklama.Size = new System.Drawing.Size(227, 202);
            this.richTextAcıklama.TabIndex = 5;
            this.richTextAcıklama.Text = "";
            // 
            // frmsave
            // 
            this.frmsave.Location = new System.Drawing.Point(90, 353);
            this.frmsave.Name = "frmsave";
            this.frmsave.Size = new System.Drawing.Size(227, 38);
            this.frmsave.TabIndex = 6;
            this.frmsave.Text = "Kaydet";
            this.frmsave.UseVisualStyleBackColor = true;
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 554);
            this.Controls.Add(this.frmsave);
            this.Controls.Add(this.richTextAcıklama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textKategoriadı);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCategory";
            this.Text = "frmCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textKategoriadı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextAcıklama;
        private System.Windows.Forms.Button frmsave;
    }
}