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
    public class TutorialDataConnection
    {
        string sqlConnectionstr = "Data Source = LAPTOP-HNLA2RU1; Initial Catalog = Nikitha ; Integrated Security = True";

        public string InsertOp(TutorialModel tutorialModel)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlObj = new SqlConnection(sqlConnectionstr);
            #region Connection Mode
            SqlCommand sqlCmd = new SqlCommand("insert into Tutorial values(" + tutorialModel.TutorialId + ",'" + tutorialModel.TutorialName + "','" + tutorialModel.TutorialDesc + "','" + tutorialModel.Published + "'," + tutorialModel.TutorialFee + ")", sqlObj);
            sqlObj.Open();
            sqlCmd.ExecuteNonQuery();
            sqlObj.Close();
            #endregion

            // #region Disconnected Mode
            // SqlDataAdapter adp = new SqlDataAdapter("insert into Tutorial values(" + tutorialModel.TutorialId + ",'" + tutorialModel.TutorialName + "','" + tutorialModel.TutorialDesc + "','" + tutorialModel.TutorialDesc + "'," + tutorialModel.TutorialFee + ")", sqlObj);
            // adp.Fill(dt);
            //#endregion
            return "Tutorial Details Saved Successfully";
        }
        public string UpdateOp(TutorialModel tutorialModel)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlObj = new SqlConnection(sqlConnectionstr);
            #region Connected Mode
            SqlCommand sqlCmd = new SqlCommand("update Tutorial set TutorialName = '" + tutorialModel.TutorialName + "', TutorialDesc = '" + tutorialModel.TutorialDesc + "', TutorialFee = " + tutorialModel.TutorialFee + " ", sqlObj);
            sqlObj.Open();
            sqlCmd.ExecuteNonQuery();
            sqlObj.Close();
            #endregion

            // #region DisConnected Mode
            // SqlDataAdapter adp = new SqlDataAdapter("update EmployeeDetails set TutorialName = '" + tutorialModel.TutorialName + "', TutorialDesc = '" + tutorialModel.TutorialDesc + "', TutorialFee = " + tutorialModel.TutorialFee + " ", sqlObj);
            //adp.Fill(dt);
            // #endregion
            return "TutorialId" + tutorialModel.TutorialId + "Tutorial Details Updated Successfully";
        }
        public string DeletebyId(int TutorialId)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlObj = new SqlConnection(sqlConnectionstr);
            #region Connected Mode
            SqlCommand sqlCmd = new SqlCommand("delete from Tutorial where TutorialId = " + TutorialId + " ", sqlObj);
            sqlObj.Open();
            sqlCmd.ExecuteNonQuery();
            sqlObj.Close();
            #endregion

            // #region DisConnected Mode
            //SqlDataAdapter adp = new SqlDataAdapter("delete from Tutorial where TutorialId = " + TutotrialId + " ", sqlObj);
            //adp.Fill(dt);
            //#endregion
            return "TutorialId" + TutorialId + "Tutorial Details Deleted Successfully";
        }
        public DataTable SelectOp()
        {
            DataTable dt = new DataTable();
            SqlConnection sqlObj = new SqlConnection(sqlConnectionstr);
            #region Connected Mode
            SqlCommand sqlCmdObj = new SqlCommand("select * from Tutorial", sqlObj);
            sqlObj.Open();
            SqlDataReader sqlReaderObj = sqlCmdObj.ExecuteReader();
            dt.Load(sqlReaderObj);
            sqlObj.Close();
            #endregion

            // #region Disconnected Mode
            //SqlDataAdapter adp = new SqlDataAdapter("select * from Tutorials", sqlObj);
            // adp.Fill(dt);
            //#endregion
            return dt;
        }
        public DataTable EditbyId(int TutorialId)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlObj = new SqlConnection(sqlConnectionstr);
            #region Connected Mode
            SqlCommand sqlCmdObj = new SqlCommand("select * from Tutorial where TutorialId = " + TutorialId + " ", sqlObj);
            sqlObj.Open();
            SqlDataReader sqlReaderObj = sqlCmdObj.ExecuteReader();
            dt.Load(sqlReaderObj);
            sqlObj.Close();
            #endregion

            // #region Disconnected Mode
            //SqlDataAdapter adp = new SqlDataAdapter("select * from Tutorial where TutorialId = " + TutorialId + " ", sqlObj);
            // adp.Fill(dt);
            //#endregion
            return dt;
        }

    }
}
