namespace RPTimeSchedule
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.checkBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.helpBtn = new System.Windows.Forms.Button();
            this.addlistBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboList = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.moduleLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.clearResBtn = new System.Windows.Forms.Button();
            this.lp3Label = new System.Windows.Forms.Label();
            this.break2Label = new System.Windows.Forms.Label();
            this.lp2Label = new System.Windows.Forms.Label();
            this.breakLabel = new System.Windows.Forms.Label();
            this.lp1Label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wipeBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class Code";
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(9, 32);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(287, 20);
            this.txtbox1.TabIndex = 1;
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(9, 68);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(75, 23);
            this.checkBtn.TabIndex = 2;
            this.checkBtn.Text = "Check";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wipeBtn);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.helpBtn);
            this.groupBox1.Controls.Add(this.addlistBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBtn);
            this.groupBox1.Controls.Add(this.txtbox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 109);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manual";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Created By Firman Jamal";
            // 
            // helpBtn
            // 
            this.helpBtn.Location = new System.Drawing.Point(300, 30);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(25, 23);
            this.helpBtn.TabIndex = 4;
            this.helpBtn.Text = "?";
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // addlistBtn
            // 
            this.addlistBtn.Location = new System.Drawing.Point(90, 68);
            this.addlistBtn.Name = "addlistBtn";
            this.addlistBtn.Size = new System.Drawing.Size(75, 23);
            this.addlistBtn.TabIndex = 3;
            this.addlistBtn.Text = "Add to List";
            this.addlistBtn.UseVisualStyleBackColor = true;
            this.addlistBtn.Click += new System.EventHandler(this.addListBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboList);
            this.groupBox2.Location = new System.Drawing.Point(12, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 70);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Class List";
            // 
            // comboList
            // 
            this.comboList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboList.FormattingEnabled = true;
            this.comboList.Location = new System.Drawing.Point(9, 28);
            this.comboList.Name = "comboList";
            this.comboList.Size = new System.Drawing.Size(316, 21);
            this.comboList.TabIndex = 0;
            this.comboList.Text = "Select list...";
            this.comboList.SelectedIndexChanged += new System.EventHandler(this.ComboList_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.moduleLabel);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.timeLabel);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.dayLabel);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.clearResBtn);
            this.groupBox3.Controls.Add(this.lp3Label);
            this.groupBox3.Controls.Add(this.break2Label);
            this.groupBox3.Controls.Add(this.lp2Label);
            this.groupBox3.Controls.Add(this.breakLabel);
            this.groupBox3.Controls.Add(this.lp1Label);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 160);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // moduleLabel
            // 
            this.moduleLabel.AutoSize = true;
            this.moduleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduleLabel.Location = new System.Drawing.Point(264, 80);
            this.moduleLabel.Name = "moduleLabel";
            this.moduleLabel.Size = new System.Drawing.Size(50, 13);
            this.moduleLabel.TabIndex = 16;
            this.moduleLabel.Text = "Not Set";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(215, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Module:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(264, 53);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(50, 13);
            this.timeLabel.TabIndex = 14;
            this.timeLabel.Text = "Not Set";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(227, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Time:";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLabel.Location = new System.Drawing.Point(264, 27);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(50, 13);
            this.dayLabel.TabIndex = 12;
            this.dayLabel.Text = "Not Set";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Day:";
            // 
            // clearResBtn
            // 
            this.clearResBtn.Enabled = false;
            this.clearResBtn.Location = new System.Drawing.Point(218, 120);
            this.clearResBtn.Name = "clearResBtn";
            this.clearResBtn.Size = new System.Drawing.Size(96, 23);
            this.clearResBtn.TabIndex = 10;
            this.clearResBtn.Text = "Clear Result";
            this.clearResBtn.UseVisualStyleBackColor = true;
            this.clearResBtn.Click += new System.EventHandler(this.clearResBtn_Click);
            // 
            // lp3Label
            // 
            this.lp3Label.AutoSize = true;
            this.lp3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lp3Label.Location = new System.Drawing.Point(112, 130);
            this.lp3Label.Name = "lp3Label";
            this.lp3Label.Size = new System.Drawing.Size(81, 13);
            this.lp3Label.TabIndex = 9;
            this.lp3Label.Text = "Not Selected";
            // 
            // break2Label
            // 
            this.break2Label.AutoSize = true;
            this.break2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.break2Label.Location = new System.Drawing.Point(112, 106);
            this.break2Label.Name = "break2Label";
            this.break2Label.Size = new System.Drawing.Size(81, 13);
            this.break2Label.TabIndex = 8;
            this.break2Label.Text = "Not Selected";
            // 
            // lp2Label
            // 
            this.lp2Label.AutoSize = true;
            this.lp2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lp2Label.Location = new System.Drawing.Point(112, 80);
            this.lp2Label.Name = "lp2Label";
            this.lp2Label.Size = new System.Drawing.Size(81, 13);
            this.lp2Label.TabIndex = 7;
            this.lp2Label.Text = "Not Selected";
            // 
            // breakLabel
            // 
            this.breakLabel.AutoSize = true;
            this.breakLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakLabel.Location = new System.Drawing.Point(112, 53);
            this.breakLabel.Name = "breakLabel";
            this.breakLabel.Size = new System.Drawing.Size(81, 13);
            this.breakLabel.TabIndex = 6;
            this.breakLabel.Text = "Not Selected";
            // 
            // lp1Label
            // 
            this.lp1Label.AutoSize = true;
            this.lp1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lp1Label.Location = new System.Drawing.Point(112, 27);
            this.lp1Label.Name = "lp1Label";
            this.lp1Label.Size = new System.Drawing.Size(81, 13);
            this.lp1Label.TabIndex = 5;
            this.lp1Label.Text = "Not Selected";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Learning Phase 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Study Period:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Learning Phase 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Break:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Learning Phase 1:";
            // 
            // wipeBtn
            // 
            this.wipeBtn.Enabled = false;
            this.wipeBtn.ForeColor = System.Drawing.Color.Red;
            this.wipeBtn.Location = new System.Drawing.Point(250, 68);
            this.wipeBtn.Name = "wipeBtn";
            this.wipeBtn.Size = new System.Drawing.Size(75, 23);
            this.wipeBtn.TabIndex = 7;
            this.wipeBtn.Text = "Wipe Cache";
            this.wipeBtn.UseVisualStyleBackColor = true;
            this.wipeBtn.Click += new System.EventHandler(this.WipeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(354, 376);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RP Lesson Schedule";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Button addlistBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearResBtn;
        private System.Windows.Forms.Label lp3Label;
        private System.Windows.Forms.Label break2Label;
        private System.Windows.Forms.Label lp2Label;
        private System.Windows.Forms.Label breakLabel;
        private System.Windows.Forms.Label lp1Label;
        private System.Windows.Forms.Label moduleLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button wipeBtn;
    }
}

