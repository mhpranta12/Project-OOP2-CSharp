﻿namespace ProjectOOP2new.View
{
    partial class Teacher
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
            this.topLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.noticeBtn = new System.Windows.Forms.Button();
            this.updateteacherBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(84, 92);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(225, 50);
            this.topLabel.TabIndex = 9;
            this.topLabel.Text = "✒Teacher";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.Location = new System.Drawing.Point(269, 495);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 56);
            this.button2.TabIndex = 10;
            this.button2.Text = "📌 Add a Teacher";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.addteacherBtnClk);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(585, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 56);
            this.button1.TabIndex = 11;
            this.button1.Text = "✂ Remove a Teacher";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // noticeBtn
            // 
            this.noticeBtn.BackColor = System.Drawing.Color.Teal;
            this.noticeBtn.Location = new System.Drawing.Point(894, 495);
            this.noticeBtn.Name = "noticeBtn";
            this.noticeBtn.Size = new System.Drawing.Size(212, 56);
            this.noticeBtn.TabIndex = 12;
            this.noticeBtn.Text = "🖥 View All Teacher";
            this.noticeBtn.UseVisualStyleBackColor = false;
            this.noticeBtn.Click += new System.EventHandler(this.viewallteachersBtnClk);
            // 
            // updateteacherBtn
            // 
            this.updateteacherBtn.BackColor = System.Drawing.Color.Turquoise;
            this.updateteacherBtn.Location = new System.Drawing.Point(1175, 495);
            this.updateteacherBtn.Name = "updateteacherBtn";
            this.updateteacherBtn.Size = new System.Drawing.Size(212, 56);
            this.updateteacherBtn.TabIndex = 13;
            this.updateteacherBtn.Text = "📝 Update a Teacher";
            this.updateteacherBtn.UseVisualStyleBackColor = false;
            this.updateteacherBtn.Click += new System.EventHandler(this.updateteacherBtnClk);
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1444, 734);
            this.Controls.Add(this.updateteacherBtn);
            this.Controls.Add(this.noticeBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.topLabel);
            this.Name = "Teacher";
            this.Text = "Teacher";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button noticeBtn;
        private System.Windows.Forms.Button updateteacherBtn;
    }
}