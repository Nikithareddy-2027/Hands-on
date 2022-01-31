using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialApplicationEntity;

namespace TutorialDataLayer
{
    public class UserInfoDataConnection
    {
        string sqlConnectionstr = "Data Source = LAPTOP-HNLA2RU1; Initial Catalog = Nikitha ; Integrated Security = True";
        public string InsertInfo(UserInfoModel userInfomodel)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlCon = new SqlConnection(sqlConnectionstr);
            SqlDataAdapter adp = new SqlDataAdapter("insert into UserInfo values('" + userInfomodel.Firstname + "','" + userInfomodel.Lastname + "','" + userInfomodel.Email + "','" + userInfomodel.Mobile + "','" + userInfomodel.Password + "')", sqlCon);
            adp.Fill(dt);

            return "regestered Successfully";
        }
        public DataTable SelectInfo()
        {
            DataTable dt = new DataTable();
            SqlConnection sqlCon = new SqlConnection(sqlConnectionstr);
            SqlDataAdapter adp = new SqlDataAdapter("select * from UserInfo", sqlCon);
            adp.Fill(dt);
            return dt;
        }
    }
}
