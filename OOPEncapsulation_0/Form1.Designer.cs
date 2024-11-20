namespace OOPEncapsulation_0
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
            this.BtnYarat = new System.Windows.Forms.Button();
            this.TxtKategori = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnYarat
            // 
            this.BtnYarat.Location = new System.Drawing.Point(45, 69);
            this.BtnYarat.Name = "BtnYarat";
            this.BtnYarat.Size = new System.Drawing.Size(139, 32);
            this.BtnYarat.TabIndex = 0;
            this.BtnYarat.Text = "Yarat";
            this.BtnYarat.UseVisualStyleBackColor = true;
            this.BtnYarat.Click += new System.EventHandler(this.BtnYarat_Click);
            // 
            // TxtKategori
            // 
            this.TxtKategori.Location = new System.Drawing.Point(45, 136);
            this.TxtKategori.Name = "TxtKategori";
            this.TxtKategori.Size = new System.Drawing.Size(100, 22);
            this.TxtKategori.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtKategori);
            this.Controls.Add(this.BtnYarat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnYarat;
        private System.Windows.Forms.TextBox TxtKategori;
    }
}

