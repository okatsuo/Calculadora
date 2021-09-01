
namespace Calculadora
{
    partial class Calculator
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
            this.tbFirstNumber = new System.Windows.Forms.TextBox();
            this.tbSecondNumber = new System.Windows.Forms.TextBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbResultMessage = new System.Windows.Forms.Label();
            this.cbbSocialMedia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbFirstNumber
            // 
            this.tbFirstNumber.Location = new System.Drawing.Point(32, 49);
            this.tbFirstNumber.Name = "tbFirstNumber";
            this.tbFirstNumber.Size = new System.Drawing.Size(127, 20);
            this.tbFirstNumber.TabIndex = 0;
            // 
            // tbSecondNumber
            // 
            this.tbSecondNumber.Location = new System.Drawing.Point(32, 75);
            this.tbSecondNumber.Name = "tbSecondNumber";
            this.tbSecondNumber.Size = new System.Drawing.Size(127, 20);
            this.tbSecondNumber.TabIndex = 1;
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(32, 101);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(26, 23);
            this.btnSum.TabIndex = 2;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.Sum_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(159, 49);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 13);
            this.lbResult.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Sub_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "*";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Multiplication_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(132, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "/";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Div_Click);
            // 
            // lbResultMessage
            // 
            this.lbResultMessage.AutoSize = true;
            this.lbResultMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultMessage.Location = new System.Drawing.Point(165, 49);
            this.lbResultMessage.Name = "lbResultMessage";
            this.lbResultMessage.Size = new System.Drawing.Size(168, 26);
            this.lbResultMessage.TabIndex = 7;
            this.lbResultMessage.Text = "                          ";
            // 
            // cbbSocialMedia
            // 
            this.cbbSocialMedia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbSocialMedia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSocialMedia.FormattingEnabled = true;
            this.cbbSocialMedia.Location = new System.Drawing.Point(407, 131);
            this.cbbSocialMedia.Name = "cbbSocialMedia";
            this.cbbSocialMedia.Size = new System.Drawing.Size(121, 21);
            this.cbbSocialMedia.TabIndex = 8;
            this.cbbSocialMedia.SelectedIndexChanged += new System.EventHandler(this.cbbSocialMedia_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "find me 😄";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(530, 164);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbSocialMedia);
            this.Controls.Add(this.lbResultMessage);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.tbSecondNumber);
            this.Controls.Add(this.tbFirstNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFirstNumber;
        private System.Windows.Forms.TextBox tbSecondNumber;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbResultMessage;
        private System.Windows.Forms.ComboBox cbbSocialMedia;
        private System.Windows.Forms.Label label1;
    }
}

