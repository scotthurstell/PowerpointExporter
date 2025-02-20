namespace PowerpointExporter
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
            openFileDialog1 = new OpenFileDialog();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(303, 385);
            button1.Name = "button1";
            button1.Size = new Size(176, 47);
            button1.TabIndex = 1;
            button1.Text = "Export To Image";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 126);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 2;
            label1.Text = "Selected File:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 126);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 151);
            label3.Name = "label3";
            label3.Size = new Size(139, 25);
            label3.TabIndex = 4;
            label3.Text = "Export Location:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(296, 151);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 5;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(200, 176);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 6;
            label5.Text = "File Prefix:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(296, 179);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 31);
            textBox1.TabIndex = 7;
            textBox1.Text = "E.g. JanuarySalesInfo";
            textBox1.TextChanged += TextBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(485, 179);
            label6.Name = "label6";
            label6.Size = new Size(132, 25);
            label6.TabIndex = 8;
            label6.Text = "-{slide number}";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private Label label6;
    }
}
