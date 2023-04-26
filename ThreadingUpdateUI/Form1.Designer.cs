namespace ThreadingUpdateUI
{
    partial class Form1
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
            btnGo = new Button();
            textBox1 = new TextBox();
            panel1 = new Panel();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnGoNoThread = new Button();
            lblCounter = new Label();
            SuspendLayout();
            // 
            // btnGo
            // 
            btnGo.Location = new Point(18, 177);
            btnGo.Margin = new Padding(4, 3, 4, 3);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(364, 27);
            btnGo.TabIndex = 0;
            btnGo.Text = "Go";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 14);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 23);
            textBox1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Location = new Point(18, 210);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 464);
            panel1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(147, 44);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(237, 23);
            textBox2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 5;
            label1.Text = "Count to:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 47);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 6;
            label2.Text = "Sleep betwen count:";
            // 
            // btnGoNoThread
            // 
            btnGoNoThread.Location = new Point(14, 98);
            btnGoNoThread.Margin = new Padding(4, 3, 4, 3);
            btnGoNoThread.Name = "btnGoNoThread";
            btnGoNoThread.Size = new Size(364, 27);
            btnGoNoThread.TabIndex = 7;
            btnGoNoThread.Text = "Go No Thread";
            btnGoNoThread.UseVisualStyleBackColor = true;
            btnGoNoThread.Click += btnGoNoThread_Click;
            // 
            // lblCounter
            // 
            lblCounter.AutoSize = true;
            lblCounter.Location = new Point(147, 128);
            lblCounter.Margin = new Padding(4, 0, 4, 0);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(89, 15);
            lblCounter.TabIndex = 8;
            lblCounter.Text = "[MY COUNTER]";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 688);
            Controls.Add(lblCounter);
            Controls.Add(btnGoNoThread);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(btnGo);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGoNoThread;
        private System.Windows.Forms.Label lblCounter;
    }
}

