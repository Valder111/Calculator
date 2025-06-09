namespace Calculator
{
    partial class MainForm
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
            button_1 = new Button();
            button_2 = new Button();
            button_3 = new Button();
            button_4 = new Button();
            button_5 = new Button();
            button_6 = new Button();
            button_7 = new Button();
            button_8 = new Button();
            button_9 = new Button();
            button_0 = new Button();
            button_ClearAll = new Button();
            button_point = new Button();
            richTextBox1 = new RichTextBox();
            button_plus = new Button();
            button_minus = new Button();
            button_mult = new Button();
            button_mod = new Button();
            buttonAnswer = new Button();
            labelText = new Label();
            button_deleteLast = new Button();
            label_operation = new Label();
            firstNumber_Text = new Label();
            SuspendLayout();
            // 
            // button_1
            // 
            button_1.Font = new Font("Segoe UI", 12F);
            button_1.Location = new Point(26, 415);
            button_1.Margin = new Padding(4);
            button_1.Name = "button_1";
            button_1.Size = new Size(76, 78);
            button_1.TabIndex = 0;
            button_1.Text = "1";
            button_1.UseVisualStyleBackColor = true;
            button_1.Click += numberButtons;
            // 
            // button_2
            // 
            button_2.Font = new Font("Segoe UI", 12F);
            button_2.Location = new Point(135, 415);
            button_2.Margin = new Padding(4);
            button_2.Name = "button_2";
            button_2.Size = new Size(76, 78);
            button_2.TabIndex = 1;
            button_2.Text = "2";
            button_2.UseVisualStyleBackColor = true;
            button_2.Click += numberButtons;
            // 
            // button_3
            // 
            button_3.Font = new Font("Segoe UI", 12F);
            button_3.Location = new Point(240, 415);
            button_3.Margin = new Padding(4);
            button_3.Name = "button_3";
            button_3.Size = new Size(76, 78);
            button_3.TabIndex = 2;
            button_3.Text = "3";
            button_3.UseVisualStyleBackColor = true;
            button_3.Click += numberButtons;
            // 
            // button_4
            // 
            button_4.Font = new Font("Segoe UI", 12F);
            button_4.Location = new Point(26, 312);
            button_4.Margin = new Padding(4);
            button_4.Name = "button_4";
            button_4.Size = new Size(76, 78);
            button_4.TabIndex = 3;
            button_4.Text = "4";
            button_4.UseVisualStyleBackColor = true;
            button_4.Click += numberButtons;
            // 
            // button_5
            // 
            button_5.Font = new Font("Segoe UI", 12F);
            button_5.Location = new Point(135, 312);
            button_5.Margin = new Padding(4);
            button_5.Name = "button_5";
            button_5.Size = new Size(76, 78);
            button_5.TabIndex = 4;
            button_5.Text = "5";
            button_5.UseVisualStyleBackColor = true;
            button_5.Click += numberButtons;
            // 
            // button_6
            // 
            button_6.Font = new Font("Segoe UI", 12F);
            button_6.Location = new Point(240, 312);
            button_6.Margin = new Padding(4);
            button_6.Name = "button_6";
            button_6.Size = new Size(76, 78);
            button_6.TabIndex = 5;
            button_6.Text = "6";
            button_6.UseVisualStyleBackColor = true;
            button_6.Click += numberButtons;
            // 
            // button_7
            // 
            button_7.Font = new Font("Segoe UI", 12F);
            button_7.Location = new Point(26, 199);
            button_7.Margin = new Padding(4);
            button_7.Name = "button_7";
            button_7.Size = new Size(76, 78);
            button_7.TabIndex = 6;
            button_7.Text = "7";
            button_7.UseVisualStyleBackColor = true;
            button_7.Click += numberButtons;
            // 
            // button_8
            // 
            button_8.Font = new Font("Segoe UI", 12F);
            button_8.Location = new Point(135, 199);
            button_8.Margin = new Padding(4);
            button_8.Name = "button_8";
            button_8.Size = new Size(76, 78);
            button_8.TabIndex = 7;
            button_8.Text = "8";
            button_8.UseVisualStyleBackColor = true;
            button_8.Click += numberButtons;
            // 
            // button_9
            // 
            button_9.Font = new Font("Segoe UI", 12F);
            button_9.Location = new Point(240, 199);
            button_9.Margin = new Padding(4);
            button_9.Name = "button_9";
            button_9.Size = new Size(76, 78);
            button_9.TabIndex = 8;
            button_9.Text = "9";
            button_9.UseVisualStyleBackColor = true;
            button_9.Click += numberButtons;
            // 
            // button_0
            // 
            button_0.Font = new Font("Segoe UI", 12F);
            button_0.Location = new Point(136, 523);
            button_0.Margin = new Padding(4);
            button_0.Name = "button_0";
            button_0.Size = new Size(76, 78);
            button_0.TabIndex = 9;
            button_0.Text = "0";
            button_0.UseVisualStyleBackColor = true;
            button_0.Click += numberButtons;
            // 
            // button_ClearAll
            // 
            button_ClearAll.Font = new Font("Segoe UI", 12F);
            button_ClearAll.Location = new Point(240, 523);
            button_ClearAll.Margin = new Padding(4);
            button_ClearAll.Name = "button_ClearAll";
            button_ClearAll.Size = new Size(76, 78);
            button_ClearAll.TabIndex = 10;
            button_ClearAll.Text = "C";
            button_ClearAll.UseVisualStyleBackColor = true;
            button_ClearAll.Click += button_ClearAll_Click;
            // 
            // button_point
            // 
            button_point.Font = new Font("Segoe UI", 12F);
            button_point.Location = new Point(26, 523);
            button_point.Margin = new Padding(4);
            button_point.Name = "button_point";
            button_point.Size = new Size(76, 78);
            button_point.TabIndex = 11;
            button_point.Text = ",";
            button_point.UseVisualStyleBackColor = true;
            button_point.Click += button_point_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBox1.Location = new Point(26, 73);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.RightToLeft = RightToLeft.No;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox1.Size = new Size(399, 61);
            richTextBox1.TabIndex = 13;
            richTextBox1.Text = "";
            // 
            // button_plus
            // 
            button_plus.Font = new Font("Segoe UI", 12F);
            button_plus.Location = new Point(349, 199);
            button_plus.Margin = new Padding(4);
            button_plus.Name = "button_plus";
            button_plus.Size = new Size(76, 78);
            button_plus.TabIndex = 14;
            button_plus.Text = "+";
            button_plus.UseVisualStyleBackColor = true;
            button_plus.Click += buttons_Operation_Click;
            // 
            // button_minus
            // 
            button_minus.Font = new Font("Segoe UI", 12F);
            button_minus.Location = new Point(349, 312);
            button_minus.Margin = new Padding(4);
            button_minus.Name = "button_minus";
            button_minus.Size = new Size(76, 78);
            button_minus.TabIndex = 15;
            button_minus.Text = "-";
            button_minus.UseVisualStyleBackColor = true;
            button_minus.Click += buttons_Operation_Click;
            // 
            // button_mult
            // 
            button_mult.Font = new Font("Segoe UI", 12F);
            button_mult.Location = new Point(349, 415);
            button_mult.Margin = new Padding(4);
            button_mult.Name = "button_mult";
            button_mult.Size = new Size(76, 78);
            button_mult.TabIndex = 16;
            button_mult.Text = "*";
            button_mult.UseVisualStyleBackColor = true;
            button_mult.Click += buttons_Operation_Click;
            // 
            // button_mod
            // 
            button_mod.Font = new Font("Segoe UI", 12F);
            button_mod.Location = new Point(349, 523);
            button_mod.Margin = new Padding(4);
            button_mod.Name = "button_mod";
            button_mod.Size = new Size(76, 78);
            button_mod.TabIndex = 17;
            button_mod.Text = "/";
            button_mod.UseVisualStyleBackColor = true;
            button_mod.Click += buttons_Operation_Click;
            // 
            // buttonAnswer
            // 
            buttonAnswer.Font = new Font("Segoe UI", 12F);
            buttonAnswer.Location = new Point(455, 523);
            buttonAnswer.Margin = new Padding(4);
            buttonAnswer.Name = "buttonAnswer";
            buttonAnswer.Size = new Size(76, 78);
            buttonAnswer.TabIndex = 19;
            buttonAnswer.Text = "=";
            buttonAnswer.UseVisualStyleBackColor = true;
            buttonAnswer.Click += button_Answer_Click;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelText.Location = new Point(26, 30);
            labelText.Name = "labelText";
            labelText.Size = new Size(94, 27);
            labelText.TabIndex = 20;
            labelText.Text = "Test text";
            // 
            // button_deleteLast
            // 
            button_deleteLast.Font = new Font("Segoe UI", 12F);
            button_deleteLast.Location = new Point(455, 199);
            button_deleteLast.Margin = new Padding(4);
            button_deleteLast.Name = "button_deleteLast";
            button_deleteLast.Size = new Size(76, 78);
            button_deleteLast.TabIndex = 21;
            button_deleteLast.Text = "<--";
            button_deleteLast.UseVisualStyleBackColor = true;
            button_deleteLast.Click += button_deleteLast_Click;
            // 
            // label_operation
            // 
            label_operation.AutoSize = true;
            label_operation.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_operation.Location = new Point(476, 97);
            label_operation.Name = "label_operation";
            label_operation.Size = new Size(0, 37);
            label_operation.TabIndex = 22;
            // 
            // firstNumber_Text
            // 
            firstNumber_Text.AutoSize = true;
            firstNumber_Text.ForeColor = SystemColors.ButtonShadow;
            firstNumber_Text.Location = new Point(36, 110);
            firstNumber_Text.Name = "firstNumber_Text";
            firstNumber_Text.Size = new Size(37, 21);
            firstNumber_Text.TabIndex = 23;
            firstNumber_Text.Text = "100";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 630);
            Controls.Add(firstNumber_Text);
            Controls.Add(label_operation);
            Controls.Add(button_deleteLast);
            Controls.Add(labelText);
            Controls.Add(buttonAnswer);
            Controls.Add(button_mod);
            Controls.Add(button_mult);
            Controls.Add(button_minus);
            Controls.Add(button_plus);
            Controls.Add(richTextBox1);
            Controls.Add(button_point);
            Controls.Add(button_ClearAll);
            Controls.Add(button_0);
            Controls.Add(button_9);
            Controls.Add(button_8);
            Controls.Add(button_7);
            Controls.Add(button_6);
            Controls.Add(button_5);
            Controls.Add(button_4);
            Controls.Add(button_3);
            Controls.Add(button_2);
            Controls.Add(button_1);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_1;
        private Button button_2;
        private Button button_3;
        private Button button_4;
        private Button button_5;
        private Button button_6;
        private Button button_7;
        private Button button_8;
        private Button button_9;
        private Button button_0;
        private Button button_ClearAll;
        private Button button_point;
        private RichTextBox richTextBox1;
        private Button button_plus;
        private Button button_minus;
        private Button button_mult;
        private Button button_mod;
        private Button buttonAnswer;
        private Label labelText;
        private Button button_deleteLast;
        private Label label_operation;
        private Label firstNumber_Text;
    }
}
