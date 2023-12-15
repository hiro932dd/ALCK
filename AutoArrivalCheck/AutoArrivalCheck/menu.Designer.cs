namespace AutoArrivalCheck
{
    partial class menu
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
            Check_Button = new Button();
            label1 = new Label();
            button1 = new Button();
            ExitButton = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // Check_Button
            // 
            Check_Button.Font = new Font("Yu Gothic UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Check_Button.Location = new Point(525, 149);
            Check_Button.Name = "Check_Button";
            Check_Button.Size = new Size(283, 89);
            Check_Button.TabIndex = 0;
            Check_Button.Text = "入荷数確認";
            Check_Button.UseVisualStyleBackColor = true;
            Check_Button.Click += Check_Button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(294, 32);
            label1.Name = "label1";
            label1.Size = new Size(298, 72);
            label1.TabIndex = 1;
            label1.Text = "AutoArrival";
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(73, 149);
            button1.Name = "button1";
            button1.Size = new Size(283, 89);
            button1.TabIndex = 2;
            button1.Text = "伝票読み取り";
            button1.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExitButton.Location = new Point(11, 481);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(152, 57);
            ExitButton.TabIndex = 4;
            ExitButton.Text = "終了する";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(682, 475);
            button2.Name = "button2";
            button2.Size = new Size(183, 63);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 549);
            Controls.Add(button2);
            Controls.Add(ExitButton);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(Check_Button);
            Name = "menu";
            Text = "main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Check_Button;
        private Label label1;
        private Button button1;
        private Button ExitButton;
        private Button button2;
    }
}