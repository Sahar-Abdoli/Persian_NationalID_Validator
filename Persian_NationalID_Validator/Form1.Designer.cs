﻿namespace Persian_NationalID_Validator
{
    partial class Form
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nationalIdTextbox = new System.Windows.Forms.TextBox();
            this.Message = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Check ID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&National ID";
            // 
            // nationalIdTextbox
            // 
            this.nationalIdTextbox.Location = new System.Drawing.Point(78, 30);
            this.nationalIdTextbox.Name = "nationalIdTextbox";
            this.nationalIdTextbox.Size = new System.Drawing.Size(175, 20);
            this.nationalIdTextbox.TabIndex = 1;
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message.Location = new System.Drawing.Point(247, 72);
            this.Message.Name = "Message";
            this.Message.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Message.Size = new System.Drawing.Size(0, 18);
            this.Message.TabIndex = 2;
            this.Message.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Message.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "&Reset";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 162);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.nationalIdTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form";
            this.Text = "Persian NationalID Validator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nationalIdTextbox;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.Button button2;
    }
}

