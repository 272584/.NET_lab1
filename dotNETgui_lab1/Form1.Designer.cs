namespace KnapsackGUI
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
            txtNumberOfItems = new TextBox();
            txtSeed = new TextBox();
            txtCapacity = new TextBox();
            btnRun = new Button();
            txtResults = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtNumberOfItems
            // 
            txtNumberOfItems.Location = new Point(185, 20);
            txtNumberOfItems.Name = "txtNumberOfItems";
            txtNumberOfItems.Size = new Size(100, 27);
            txtNumberOfItems.TabIndex = 0;
            // 
            // txtSeed
            // 
            txtSeed.Location = new Point(185, 60);
            txtSeed.Name = "txtSeed";
            txtSeed.Size = new Size(100, 27);
            txtSeed.TabIndex = 1;
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(185, 100);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(100, 27);
            txtCapacity.TabIndex = 2;
            // 
            // btnRun
            // 
            btnRun.Location = new Point(185, 142);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(100, 32);
            btnRun.TabIndex = 3;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // txtResults
            // 
            txtResults.Location = new Point(160, 180);
            txtResults.Multiline = true;
            txtResults.Name = "txtResults";
            txtResults.ReadOnly = true;
            txtResults.Size = new Size(200, 100);
            txtResults.TabIndex = 4;
            txtResults.TextChanged += txtResults_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 5;
            label1.Text = "Number of Items (n):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 60);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 6;
            label2.Text = "Seed:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 100);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 7;
            label3.Text = "Capacity:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 180);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 8;
            label4.Text = "Results:";
            // 
            // Form1
            // 
            ClientSize = new Size(400, 300);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtResults);
            Controls.Add(btnRun);
            Controls.Add(txtCapacity);
            Controls.Add(txtSeed);
            Controls.Add(txtNumberOfItems);
            Name = "Form1";
            Text = "Knapsack Problem Solver";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNumberOfItems;
        private System.Windows.Forms.TextBox txtSeed;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}