
namespace GsharpHomework
{
    partial class Frm_Show
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
            this.PIC1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PIC1)).BeginInit();
            this.SuspendLayout();
            // 
            // PIC1
            // 
            this.PIC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PIC1.Location = new System.Drawing.Point(0, 0);
            this.PIC1.Name = "PIC1";
            this.PIC1.Size = new System.Drawing.Size(277, 277);
            this.PIC1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIC1.TabIndex = 0;
            this.PIC1.TabStop = false;
            // 
            // Frm_Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 277);
            this.Controls.Add(this.PIC1);
            this.Name = "Frm_Show";
            this.Text = "Frm_Show";
            ((System.ComponentModel.ISupportInitialize)(this.PIC1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox PIC1;
    }
}