
namespace ackTestApp2
{
    partial class delete
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
            this.pwTxt = new System.Windows.Forms.TextBox();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "삭제할 아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "비밀번호";
            // 
            // pwTxt
            // 
            this.pwTxt.Location = new System.Drawing.Point(105, 73);
            this.pwTxt.Name = "pwTxt";
            this.pwTxt.Size = new System.Drawing.Size(100, 21);
            this.pwTxt.TabIndex = 2;
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(105, 28);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(100, 21);
            this.idTxt.TabIndex = 3;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(105, 116);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "삭제";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 151);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.pwTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "delete";
            this.Text = "delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pwTxt;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Button deleteBtn;
    }
}