
namespace ackTestApp2
{
    partial class changePw
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
            this.idTxt = new System.Windows.Forms.TextBox();
            this.nowPwTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.afterPwTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(129, 27);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(100, 21);
            this.idTxt.TabIndex = 0;
            // 
            // nowPwTxt
            // 
            this.nowPwTxt.Location = new System.Drawing.Point(129, 61);
            this.nowPwTxt.Name = "nowPwTxt";
            this.nowPwTxt.Size = new System.Drawing.Size(100, 21);
            this.nowPwTxt.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "변경";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "변경할 ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "현재 비밀번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "변경할 비밀번호";
            // 
            // afterPwTxt
            // 
            this.afterPwTxt.Location = new System.Drawing.Point(129, 92);
            this.afterPwTxt.Name = "afterPwTxt";
            this.afterPwTxt.Size = new System.Drawing.Size(100, 21);
            this.afterPwTxt.TabIndex = 6;
            // 
            // changePw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 163);
            this.Controls.Add(this.afterPwTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nowPwTxt);
            this.Controls.Add(this.idTxt);
            this.Name = "changePw";
            this.Text = "changePw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.TextBox nowPwTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox afterPwTxt;
    }
}