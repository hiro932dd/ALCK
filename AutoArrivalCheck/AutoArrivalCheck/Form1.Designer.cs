namespace AutoArrivalCheck
{
    partial class Form1
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
            IDname = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            login_button = new Button();
            cancel_button = new Button();
            SuspendLayout();
            // 
            // IDname
            // 
            IDname.AutoSize = true;
            IDname.Font = new Font("Yu Gothic UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            IDname.Location = new Point(144, 107);
            IDname.Name = "IDname";
            IDname.Size = new Size(70, 37);
            IDname.TabIndex = 0;
            IDname.Text = "ID：";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(229, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(401, 30);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(144, 190);
            label1.Name = "label1";
            label1.Size = new Size(96, 37);
            label1.TabIndex = 2;
            label1.Text = "pass：";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(229, 197);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(401, 30);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // login_button
            // 
            login_button.Font = new Font("Yu Gothic UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            login_button.Location = new Point(437, 298);
            login_button.Name = "login_button";
            login_button.Size = new Size(193, 59);
            login_button.TabIndex = 4;
            login_button.Text = "ログイン";
            login_button.UseVisualStyleBackColor = true;
            login_button.Click += login_button_Click;
            // 
            // cancel_button
            // 
            cancel_button.Font = new Font("Yu Gothic UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cancel_button.Location = new Point(229, 298);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(178, 59);
            cancel_button.TabIndex = 5;
            cancel_button.Text = "キャンセル";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cancel_button);
            Controls.Add(login_button);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(IDname);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IDname;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Button login_button;
        private Button cancel_button;
        private DataGridView TestGrid;
    }
}