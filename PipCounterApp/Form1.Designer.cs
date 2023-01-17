namespace PipCounterApp
{
    partial class PipCounterBox
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BullAndBearMainPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BullAndBearMainPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BullAndBearMainPicture
            // 
            this.BullAndBearMainPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BullAndBearMainPicture.ImageLocation = "E:\\Users\\Luke Wardle\\Desktop\\dev.stuff\\C#\\PipCounterApp\\PipCounterApp\\Images\\trad" +
    "ingbullbear.jfif";
            this.BullAndBearMainPicture.Location = new System.Drawing.Point(-2, -2);
            this.BullAndBearMainPicture.Name = "BullAndBearMainPicture";
            this.BullAndBearMainPicture.Size = new System.Drawing.Size(804, 451);
            this.BullAndBearMainPicture.TabIndex = 0;
            this.BullAndBearMainPicture.TabStop = false;
            // 
            // PipCounterBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BullAndBearMainPicture);
            this.Name = "PipCounterBox";
            this.RightToLeftLayout = true;
            this.Text = "PipCounterApp";
            ((System.ComponentModel.ISupportInitialize)(this.BullAndBearMainPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox BullAndBearMainPicture;
    }
}