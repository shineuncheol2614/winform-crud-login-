
namespace ackTestApp2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pwTxt = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.regist = new System.Windows.Forms.Button();
            this.findpw = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(107, 12);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(174, 21);
            this.idTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "PW";
            // 
            // pwTxt
            // 
            this.pwTxt.Location = new System.Drawing.Point(107, 52);
            this.pwTxt.Name = "pwTxt";
            this.pwTxt.Size = new System.Drawing.Size(174, 21);
            this.pwTxt.TabIndex = 3;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(12, 100);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 4;
            this.login.Text = "로그인";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // regist
            // 
            this.regist.Location = new System.Drawing.Point(93, 100);
            this.regist.Name = "regist";
            this.regist.Size = new System.Drawing.Size(75, 23);
            this.regist.TabIndex = 5;
            this.regist.Text = "회원가입";
            this.regist.UseVisualStyleBackColor = true;
            this.regist.Click += new System.EventHandler(this.regist_Click);
            // 
            // findpw
            // 
            this.findpw.Location = new System.Drawing.Point(174, 100);
            this.findpw.Name = "findpw";
            this.findpw.Size = new System.Drawing.Size(75, 23);
            this.findpw.TabIndex = 6;
            this.findpw.Text = "pw 변경";
            this.findpw.UseVisualStyleBackColor = true;
            this.findpw.Click += new System.EventHandler(this.findpw_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(255, 100);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "회원탈퇴";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 135);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.findpw);
            this.Controls.Add(this.regist);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pwTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pwTxt;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button regist;
        private System.Windows.Forms.Button findpw;
        private System.Windows.Forms.Button deleteBtn;
    }
}

