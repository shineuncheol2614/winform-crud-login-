using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ackTestApp2
{
    public partial class regist : Form
    {

        static string connstr = "Server = 127.0.0.1;Port = 3306;Database=db_ack;Uid=root;pwd=1101";
        MySqlConnection conn = new MySqlConnection(connstr);

        public regist()
        {
            InitializeComponent();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                DataSet ds = new DataSet();
                string sql = string.Empty;
                string id = string.Empty;
                string pw = string.Empty;
                string name = string.Empty;

                id = idTxt.Text;
                pw = pwTxt.Text;
                name = nameTxt.Text;

                sql = @"insert into userinfo values ('#id','#pw','#name')";
                sql = sql.Replace("#id", id);
                sql = sql.Replace("#pw", pw);
                sql = sql.Replace("#name", name);

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("회원가입 완료");
                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("입력사항을 확인후 다시 시도 해주세요.");
            }
        }
    }
}
