namespace AmericanTruckSimulatorTrainer
{
    partial class Trainer
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
            this.gif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gif)).BeginInit();
            this.SuspendLayout();
            // 
            // gif
            // 
            this.gif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gif.Location = new System.Drawing.Point(0, 0);
            this.gif.Name = "gif";
            this.gif.Size = new System.Drawing.Size(730, 650);
            this.gif.TabIndex = 0;
            this.gif.TabStop = false;
            this.gif.Click += new System.EventHandler(this.gif_Click);
            // 
            // Trainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 650);
            this.Controls.Add(this.gif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Trainer";
            this.Text = "Trainer";
            this.Load += new System.EventHandler(this.Trainer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox gif;
    }
}