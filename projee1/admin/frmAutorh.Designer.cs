namespace projee1.admin
{
    partial class frmAutorh
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
            this.textYazaradi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textSoyadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBio = new System.Windows.Forms.RichTextBox();
            this.frmsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textYazaradi
            // 
            this.textYazaradi.Location = new System.Drawing.Point(112, 34);
            this.textYazaradi.Name = "textYazaradi";
            this.textYazaradi.Size = new System.Drawing.Size(229, 22);
            this.textYazaradi.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 37);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Yazar Adı:";
            // 
            // textSoyadi
            // 
            this.textSoyadi.Location = new System.Drawing.Point(112, 73);
            this.textSoyadi.Name = "textSoyadi";
            this.textSoyadi.Size = new System.Drawing.Size(229, 22);
            this.textSoyadi.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 76);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 113);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bio";
            // 
            // richTextBio
            // 
            this.richTextBio.Location = new System.Drawing.Point(112, 110);
            this.richTextBio.Name = "richTextBio";
            this.richTextBio.Size = new System.Drawing.Size(229, 182);
            this.richTextBio.TabIndex = 9;
            this.richTextBio.Text = "";
            // 
            // frmsave
            // 
            this.frmsave.Location = new System.Drawing.Point(112, 331);
            this.frmsave.Name = "frmsave";
            this.frmsave.Size = new System.Drawing.Size(229, 23);
            this.frmsave.TabIndex = 10;
            this.frmsave.Text = "Kaydet";
            this.frmsave.UseVisualStyleBackColor = true;
            // 
            // frmAutorh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 554);
            this.Controls.Add(this.frmsave);
            this.Controls.Add(this.richTextBio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textSoyadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textYazaradi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAutorh";
            this.Text = "frmAutorh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textYazaradi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSoyadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBio;
        private System.Windows.Forms.Button frmsave;
    }
}