﻿namespace ProjectOOP2new.View
{
    partial class AssignCourseTeacher
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
            this.sidtextBox = new System.Windows.Forms.TextBox();
            this.topLabel = new System.Windows.Forms.Label();
            this.dlttrsBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sidtextBox
            // 
            this.sidtextBox.Location = new System.Drawing.Point(401, 275);
            this.sidtextBox.Name = "sidtextBox";
            this.sidtextBox.Size = new System.Drawing.Size(292, 22);
            this.sidtextBox.TabIndex = 28;
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(40, 38);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(457, 50);
            this.topLabel.TabIndex = 29;
            this.topLabel.Text = "Assign Course Teacher";
            // 
            // dlttrsBtn
            // 
            this.dlttrsBtn.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlttrsBtn.Location = new System.Drawing.Point(401, 441);
            this.dlttrsBtn.Name = "dlttrsBtn";
            this.dlttrsBtn.Size = new System.Drawing.Size(292, 39);
            this.dlttrsBtn.TabIndex = 31;
            this.dlttrsBtn.Text = "Assign Teacher";
            this.dlttrsBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NSimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "Course\'s Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(401, 349);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 22);
            this.textBox1.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NSimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "Teacher\'s Name";
            // 
            // AssignCourseTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 572);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dlttrsBtn);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.sidtextBox);
            this.Name = "AssignCourseTeacher";
            this.Text = "AssignCourseTeacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sidtextBox;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Button dlttrsBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}