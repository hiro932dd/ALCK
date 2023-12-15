namespace AutoArrivalCheck
{
    partial class exitmenu
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
            exitLabel = new Label();
            exitGo = new Button();
            ExitNo = new Button();
            SuspendLayout();
            // 
            // exitLabel
            // 
            exitLabel.AutoSize = true;
            exitLabel.Font = new Font("Yu Gothic UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            exitLabel.Location = new Point(172, 47);
            exitLabel.Name = "exitLabel";
            exitLabel.Size = new Size(232, 47);
            exitLabel.TabIndex = 0;
            exitLabel.Text = "終了しますか？";
            // 
            // exitGo
            // 
            exitGo.Font = new Font("Yu Gothic UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            exitGo.Location = new Point(327, 183);
            exitGo.Name = "exitGo";
            exitGo.Size = new Size(187, 68);
            exitGo.TabIndex = 1;
            exitGo.Text = "はい";
            exitGo.UseVisualStyleBackColor = true;
            exitGo.Click += exitGo_Click;
            // 
            // ExitNo
            // 
            ExitNo.Font = new Font("Yu Gothic UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ExitNo.Location = new Point(52, 183);
            ExitNo.Name = "ExitNo";
            ExitNo.Size = new Size(187, 68);
            ExitNo.TabIndex = 2;
            ExitNo.Text = "いいえ";
            ExitNo.UseVisualStyleBackColor = true;
            ExitNo.Click += ExitNo_Click;
            // 
            // exitmenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 288);
            Controls.Add(ExitNo);
            Controls.Add(exitGo);
            Controls.Add(exitLabel);
            Name = "exitmenu";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label exitLabel;
        private Button exitGo;
        private Button ExitNo;
    }
}