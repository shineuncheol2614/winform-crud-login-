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
    public partial class changePw : Form
    {

        static string connstr = "Server = 127.0.0.1;Port = 3306;Database=db_ack;Uid=root;pwd=1101";
        MySqlConnection conn = new MySqlConnection(connstr);
        public changePw()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string id = idTxt.Text;
                string nowpw = nowPwTxt.Text;
                string afterpw = afterPwTxt.Text;

                String uid = string.Empty;
                String upw = string.Empty;
                string selectSql = "select uid,pw from userinfo where uid = '#id' and pw = '#pw'";
                selectSql = selectSql.Replace("#id", id);
                selectSql = selectSql.Replace("#pw", nowpw);

                MySqlCommand cmd = new MySqlCommand(selectSql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    uid = reader["UID"].ToString();
                    upw = reader["PW"].ToString();
                }
                reader.Close();

                if (uid == id && upw == nowpw)
                {
                    String updateSql = @"update userinfo set pw = '#pw' where uid = '#id'";
                    updateSql = updateSql.Replace("#pw", afterpw.ToString());
                    updateSql = updateSql.Replace("#id", id.ToString());
                    MySqlCommand updatecmd = new MySqlCommand(updateSql, conn);
                    updatecmd.ExecuteNonQuery();
                    MessageBox.Show("변경완료");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("아이디 및 비밀번호를 확인해주세요.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

                conn.Close();

            }
        }
    }
}
