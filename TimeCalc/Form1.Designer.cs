namespace TimeCalc
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
            tbHours = new TextBox();
            tbMins = new TextBox();
            tbSecs = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lstbTimeLists = new ListBox();
            totalTime = new Label();
            label6 = new Label();
            btnReset = new Button();
            SuspendLayout();
            // 
            // tbHours
            // 
            tbHours.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbHours.Location = new Point(20, 46);
            tbHours.Name = "tbHours";
            tbHours.Size = new Size(43, 29);
            tbHours.TabIndex = 0;
            tbHours.KeyDown += tbHours_KeyDown;
            tbHours.KeyPress += textBox1_KeyPress;
            // 
            // tbMins
            // 
            tbMins.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbMins.Location = new Point(85, 46);
            tbMins.Name = "tbMins";
            tbMins.Size = new Size(43, 29);
            tbMins.TabIndex = 1;
            tbMins.KeyDown += tbMins_KeyDown;
            tbMins.KeyPress += textBox2_KeyPress;
            // 
            // tbSecs
            // 
            tbSecs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbSecs.Location = new Point(152, 46);
            tbSecs.Name = "tbSecs";
            tbSecs.Size = new Size(43, 29);
            tbSecs.TabIndex = 2;
            tbSecs.KeyDown += textBox3_KeyDown;
            tbSecs.KeyPress += textBox3_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(67, 47);
            label1.Name = "label1";
            label1.Size = new Size(14, 21);
            label1.TabIndex = 3;
            label1.Text = ":";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(133, 47);
            label2.Name = "label2";
            label2.Size = new Size(14, 21);
            label2.TabIndex = 4;
            label2.Text = ":";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 24);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 5;
            label3.Text = "Hour(s)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 24);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 6;
            label4.Text = "Minutes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(150, 24);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 7;
            label5.Text = "Seconds";
            // 
            // lstbTimeLists
            // 
            lstbTimeLists.FormattingEnabled = true;
            lstbTimeLists.ItemHeight = 15;
            lstbTimeLists.Location = new Point(20, 104);
            lstbTimeLists.Name = "lstbTimeLists";
            lstbTimeLists.Size = new Size(175, 154);
            lstbTimeLists.TabIndex = 8;
            // 
            // totalTime
            // 
            totalTime.AutoSize = true;
            totalTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            totalTime.Location = new Point(307, 50);
            totalTime.Name = "totalTime";
            totalTime.Size = new Size(0, 21);
            totalTime.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(221, 50);
            label6.Name = "label6";
            label6.Size = new Size(80, 21);
            label6.TabIndex = 10;
            label6.Text = "Total Time";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(221, 223);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(135, 35);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 276);
            Controls.Add(btnReset);
            Controls.Add(label6);
            Controls.Add(totalTime);
            Controls.Add(lstbTimeLists);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbSecs);
            Controls.Add(tbMins);
            Controls.Add(tbHours);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Time Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbHours;
        private TextBox tbMins;
        private TextBox tbSecs;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox lstbTimeLists;
        private Label totalTime;
        private Label label6;
        private Button btnReset;
    }
}