
namespace ackTestApp2
{
    partial class regist
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.pwTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.regBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "pw";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "name";
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(94, 19);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(100, 21);
            this.idTxt.TabIndex = 3;
            // 
            // pwTxt
            // 
            this.pwTxt.Location = new System.Drawing.Point(94, 66);
            this.pwTxt.Name = "pwTxt";
            this.pwTxt.Size = new System.Drawing.Size(100, 21);
            this.pwTxt.TabIndex = 4;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(94, 111);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(100, 21);
            this.nameTxt.TabIndex = 5;
            // 
            // regBtn
            // 
            this.regBtn.Location = new System.Drawing.Point(83, 153);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(75, 23);
            this.regBtn.TabIndex = 6;
            this.regBtn.Text = "회원가입";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // regist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 188);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.pwTxt);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "regist";
            this.Text = "regist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.TextBox pwTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Button regBtn;
    }
}