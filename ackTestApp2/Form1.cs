using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ackTestApp2
{
    public partial class Form1 : Form
    {
        static string connstr = "Server = 127.0.0.1;Port = 3306;Database=db_ack;Uid=root;pwd=1101";
        MySqlConnection conn = new MySqlConnection(connstr);

        public Form1()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// login(select)
        /// </summary>

        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string id = idTxt.Text;
                string pw = pwTxt.Text;
                String uid = string.Empty;
                String upw = string.Empty;
                string sql = "select uid,pw from userinfo where uid = '#id' and pw = '#pw'";
                sql = sql.Replace("#id", id);
                sql = sql.Replace("#pw", pw);

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        uid = reader["UID"].ToString();
                        upw = reader["PW"].ToString();
                    }
                    reader.Close();

                    if (uid == id && upw == pw)
                    {
                        MessageBox.Show("로그인 성공");
                    }
                    else
                    {
                        MessageBox.Show("아이디 및 비밀번호를 확인해주세요.");
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                
                conn.Close();

            }

        }

        /// <summary>
        /// regist(select,insert)
        /// </summary>
        private void regist_Click(object sender, EventArgs e)
        {
            using (regist regForm = new regist())
            {
                regForm.ShowDialog();
            }
        }

        /// <summary>
        /// change password (select, update)
        /// </summary>
        private void findpw_Click(object sender, EventArgs e)
        {
            using (changePw chPW = new changePw())
            {
                chPW.ShowDialog();
            }
        }

        /// <summary>
        /// detete ID (select, delete)
        /// </summary>
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            using (delete delId = new delete())
            {
                delId.ShowDialog();
            }
        }
    }
}
