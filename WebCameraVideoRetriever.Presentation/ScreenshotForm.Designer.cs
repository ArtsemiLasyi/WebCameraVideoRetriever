
namespace WebCameraVideoRetriever.Presentation
{
    partial class ScreenshotForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenshotForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SaveScreenshotToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ExitWithoutSavetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ScreenshotPictureBox = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenshotPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveScreenshotToolStripButton,
            this.ExitWithoutSavetoolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SaveScreenshotToolStripButton
            // 
            this.SaveScreenshotToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SaveScreenshotToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveScreenshotToolStripButton.Image")));
            this.SaveScreenshotToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveScreenshotToolStripButton.Name = "SaveScreenshotToolStripButton";
            this.SaveScreenshotToolStripButton.Size = new System.Drawing.Size(70, 22);
            this.SaveScreenshotToolStripButton.Text = "Сохранить";
            this.SaveScreenshotToolStripButton.Click += new System.EventHandler(this.SaveScreenshotToolStripButton_Click);
            // 
            // ExitWithoutSavetoolStripButton
            // 
            this.ExitWithoutSavetoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ExitWithoutSavetoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitWithoutSavetoolStripButton.Image")));
            this.ExitWithoutSavetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitWithoutSavetoolStripButton.Name = "ExitWithoutSavetoolStripButton";
            this.ExitWithoutSavetoolStripButton.Size = new System.Drawing.Size(135, 22);
            this.ExitWithoutSavetoolStripButton.Text = "Выйти без сохранения";
            this.ExitWithoutSavetoolStripButton.Click += new System.EventHandler(this.ExitWithoutSavetoolStripButton_Click);
            // 
            // ScreenshotPictureBox
            // 
            this.ScreenshotPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScreenshotPictureBox.Location = new System.Drawing.Point(0, 25);
            this.ScreenshotPictureBox.Name = "ScreenshotPictureBox";
            this.ScreenshotPictureBox.Size = new System.Drawing.Size(800, 425);
            this.ScreenshotPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ScreenshotPictureBox.TabIndex = 1;
            this.ScreenshotPictureBox.TabStop = false;
            // 
            // ScreenshotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ScreenshotPictureBox);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ScreenshotForm";
            this.Text = "ScreenshotForm";
            this.Load += new System.EventHandler(this.ScreenshotForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenshotPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton SaveScreenshotToolStripButton;
        private System.Windows.Forms.ToolStripButton ExitWithoutSavetoolStripButton;
        private System.Windows.Forms.PictureBox ScreenshotPictureBox;
    }
}