﻿namespace ProjectOOP2new.View
{
    partial class DeleteCourse
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
            this.dltcrsBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cidtextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(64, 62);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(362, 50);
            this.topLabel.TabIndex = 23;
            this.topLabel.Text = "✄ Remove Course";
            // 
            // dltcrsBtn
            // 
            this.dltcrsBtn.BackColor = System.Drawing.Color.Ivory;
            this.dltcrsBtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dltcrsBtn.Location = new System.Drawing.Point(559, 369);
            this.dltcrsBtn.Name = "dltcrsBtn";
            this.dltcrsBtn.Size = new System.Drawing.Size(366, 39);
            this.dltcrsBtn.TabIndex = 31;
            this.dltcrsBtn.Text = "Delete  Course";
            this.dltcrsBtn.UseVisualStyleBackColor = false;
            this.dltcrsBtn.Click += new System.EventHandler(this.dltcrsBtnClk);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NSimSun", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(287, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 28);
            this.label3.TabIndex = 32;
            this.label3.Text = "Course\'s Code";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cidtextBox
            // 
            this.cidtextBox.Location = new System.Drawing.Point(559, 275);
            this.cidtextBox.Name = "cidtextBox";
            this.cidtextBox.Size = new System.Drawing.Size(366, 37);
            this.cidtextBox.TabIndex = 33;
            this.cidtextBox.Text = "";
            // 
            // DeleteCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1410, 599);
            this.Controls.Add(this.cidtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dltcrsBtn);
            this.Controls.Add(this.topLabel);
            this.Name = "DeleteCourse";
            this.Text = "DeleteCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Button dltcrsBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox cidtextBox;
    }
}