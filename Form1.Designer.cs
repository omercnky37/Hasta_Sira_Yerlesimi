﻿namespace WinFormsApp8
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
            button1 = new Button();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Emoji", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(179, 218);
            button1.Name = "button1";
            button1.Size = new Size(205, 90);
            button1.TabIndex = 1;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(202, 341);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(328, 304);
            listBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(287, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 31);
            textBox1.TabIndex = 4;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Emoji", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(457, 218);
            button3.Name = "button3";
            button3.Size = new Size(205, 90);
            button3.TabIndex = 5;
            button3.Text = "Çıkar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(947, 689);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private ListBox listBox1;
        private TextBox textBox1;
        private Button button3;
    }
}