namespace AutoArrivalCheck
{
    partial class Check
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
            exitBt = new Button();
            shutterBt = new Button();
            cameraPic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)cameraPic).BeginInit();
            SuspendLayout();
            // 
            // exitBt
            // 
            exitBt.Font = new Font("Yu Gothic UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            exitBt.Location = new Point(42, 441);
            exitBt.Margin = new Padding(3, 4, 3, 4);
            exitBt.Name = "exitBt";
            exitBt.Size = new Size(155, 60);
            exitBt.TabIndex = 0;
            exitBt.Text = "終了";
            exitBt.UseVisualStyleBackColor = true;
            exitBt.Click += exitBt_Click;
            // 
            // shutterBt
            // 
            shutterBt.BackgroundImageLayout = ImageLayout.Center;
            shutterBt.Font = new Font("Yu Gothic UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            shutterBt.Location = new Point(802, 440);
            shutterBt.Name = "shutterBt";
            shutterBt.Size = new Size(152, 61);
            shutterBt.TabIndex = 1;
            shutterBt.Text = "撮影";
            shutterBt.UseVisualStyleBackColor = true;
            shutterBt.Click += shutterBt_Click;
            // 
            // cameraPic
            // 
            cameraPic.Location = new Point(12, 12);
            cameraPic.Name = "cameraPic";
            cameraPic.Size = new Size(1029, 404);
            cameraPic.TabIndex = 2;
            cameraPic.TabStop = false;
            // 
            // Check
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 514);
            Controls.Add(cameraPic);
            Controls.Add(shutterBt);
            Controls.Add(exitBt);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Check";
            Text = "Check";
            FormClosing += Check_FormClosing;
            Load += Check_Load;
            ((System.ComponentModel.ISupportInitialize)cameraPic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button exitBt;
        private Button shutterBt;
        private PictureBox cameraPic;
    }
}