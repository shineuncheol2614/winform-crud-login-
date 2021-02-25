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
    public partial class delete : Form
    {
        public delete()
        {
            InitializeComponent();
        }

        static string connstr = "Server = 127.0.0.1;Port = 3306;Database=db_ack;Uid=root;pwd=1101";
        MySqlConnection conn = new MySqlConnection(connstr);


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string id = idTxt.Text;
                string pw = pwTxt.Text;

                String uid = string.Empty;
                String upw = string.Empty;
                string selectSql = "select uid,pw from userinfo where uid = '#id' and pw = '#pw'";
                selectSql = selectSql.Replace("#id", id);
                selectSql = selectSql.Replace("#pw", pw);

                MySqlCommand cmd = new MySqlCommand(selectSql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    uid = reader["UID"].ToString();
                    upw = reader["PW"].ToString();
                }
                reader.Close();

                if (uid == id && upw == pw)
                {
                    String deleteSql = @"delete from userinfo where uid = '#id'";
                    deleteSql = deleteSql.Replace("#id", id.ToString());
                    MySqlCommand updatecmd = new MySqlCommand(deleteSql, conn);
                    updatecmd.ExecuteNonQuery();
                    MessageBox.Show("삭제완료");
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
