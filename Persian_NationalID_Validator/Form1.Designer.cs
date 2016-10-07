namespace Persian_NationalID_Validator
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
            this.checkIdButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nationalIdTextbox = new System.Windows.Forms.TextBox();
            this.messageLable = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkIdButton
            // 
            this.checkIdButton.Location = new System.Drawing.Point(15, 127);
            this.checkIdButton.Name = "checkIdButton";
            this.checkIdButton.Size = new System.Drawing.Size(75, 23);
            this.checkIdButton.TabIndex = 3;
            this.checkIdButton.Text = "&Check ID";
            this.checkIdButton.UseVisualStyleBackColor = true;
            this.checkIdButton.Click += new System.EventHandler(this.checkIdButton_Click);
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
            // messageLable
            // 
            this.messageLable.AutoSize = true;
            this.messageLable.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLable.Location = new System.Drawing.Point(128, 76);
            this.messageLable.Name = "messageLable";
            this.messageLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.messageLable.Size = new System.Drawing.Size(0, 18);
            this.messageLable.TabIndex = 2;
            this.messageLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.messageLable.Click += new System.EventHandler(this.label2_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(178, 127);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "&Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 162);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.messageLable);
            this.Controls.Add(this.nationalIdTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkIdButton);
            this.Name = "Form";
            this.Text = "Persian NationalID Validator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkIdButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nationalIdTextbox;
        private System.Windows.Forms.Label messageLable;
        private System.Windows.Forms.Button resetButton;
    }
}

