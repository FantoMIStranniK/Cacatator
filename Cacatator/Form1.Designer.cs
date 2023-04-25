namespace Cacatator
{
    partial class Cacator
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            SummButton = new Button();
            MultButton = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(0, 0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            // 
            // SummButton
            // 
            SummButton.Location = new Point(169, 142);
            SummButton.Name = "SummButton";
            SummButton.Size = new Size(151, 69);
            SummButton.TabIndex = 0;
            SummButton.Text = "Summ";
            SummButton.UseVisualStyleBackColor = true;
            SummButton.Click += SummButton_Click;
            // 
            // MultButton
            // 
            MultButton.Location = new Point(12, 142);
            MultButton.Name = "MultButton";
            MultButton.Size = new Size(151, 69);
            MultButton.TabIndex = 1;
            MultButton.Text = "Multiply";
            MultButton.UseVisualStyleBackColor = true;
            MultButton.Click += MultButton_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(169, 78);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(151, 23);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 78);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(151, 23);
            textBox4.TabIndex = 3;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 60);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 4;
            label4.Text = "X Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(169, 60);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 5;
            label5.Text = "Y Number";
            // 
            // Cacator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(MultButton);
            Controls.Add(SummButton);
            Name = "Cacator";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Button SummButton;
        private Button MultButton;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
    }
}