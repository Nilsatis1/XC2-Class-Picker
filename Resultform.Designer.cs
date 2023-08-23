namespace XC2_Class_Picker
{
    partial class Resultform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resultform));
            this.txtClass = new System.Windows.Forms.RichTextBox();
            this.alienPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.alienPic)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(53, 384);
            this.txtClass.Margin = new System.Windows.Forms.Padding(4);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(224, 42);
            this.txtClass.TabIndex = 1;
            this.txtClass.Text = "";
            // 
            // alienPic
            // 
            this.alienPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.alienPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alienPic.Cursor = System.Windows.Forms.Cursors.No;
            this.alienPic.Enabled = false;
            this.alienPic.Location = new System.Drawing.Point(124, 433);
            this.alienPic.Name = "alienPic";
            this.alienPic.Size = new System.Drawing.Size(79, 82);
            this.alienPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.alienPic.TabIndex = 2;
            this.alienPic.TabStop = false;
            // 
            // Resultform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(321, 537);
            this.Controls.Add(this.alienPic);
            this.Controls.Add(this.txtClass);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Resultform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Resultform_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.alienPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtClass;
        private System.Windows.Forms.PictureBox alienPic;
    }
}