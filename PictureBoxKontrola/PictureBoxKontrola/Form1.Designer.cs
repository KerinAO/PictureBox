namespace PictureBoxKontrola
{
    partial class Form1
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
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnSakrij = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(88, 463);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(160, 36);
            this.btnPrikazi.TabIndex = 0;
            this.btnPrikazi.Text = "Prikaži sliku";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // picBox
            // 
            this.picBox.Image = global::PictureBoxKontrola.Properties.Resources.valhalla;
            this.picBox.Location = new System.Drawing.Point(88, 12);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(414, 429);
            this.picBox.TabIndex = 1;
            this.picBox.TabStop = false;
            this.picBox.Visible = false;
            // 
            // btnSakrij
            // 
            this.btnSakrij.Location = new System.Drawing.Point(342, 463);
            this.btnSakrij.Name = "btnSakrij";
            this.btnSakrij.Size = new System.Drawing.Size(160, 36);
            this.btnSakrij.TabIndex = 2;
            this.btnSakrij.Text = "Sakrij sliku";
            this.btnSakrij.UseVisualStyleBackColor = true;
            this.btnSakrij.Click += new System.EventHandler(this.btnSakrij_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 520);
            this.Controls.Add(this.btnSakrij);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.btnPrikazi);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnSakrij;
    }
}

