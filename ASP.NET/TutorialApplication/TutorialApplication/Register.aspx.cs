using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TutorialBussiness;
using TutorialApplicationEntity;
using System.Data;

namespace TutorialApplication
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtRegister_Click(object sender, EventArgs e)
        {
            UserInfoModel userInfoModel = new UserInfoModel();
            UserInfoBusiness userInfoBusiness = new UserInfoBusiness();

            userInfoModel.Id = Convert.ToInt32(txtId.Text);
            userInfoModel.Firstname = txtfname.Text;
            userInfoModel.Lastname = txtlname.Text;
            userInfoModel.Email = txtemail.Text;
            userInfoModel.Mobile = Convert.ToInt32(txtmobile.Text);
            userInfoModel.Password = txtpsw.Text;

            string msg = userInfoBusiness.InsertDetails(userInfoModel);
            DataTable dtObj = userInfoBusiness.GetDetails();
            gvUserInfo.DataSource = dtObj;
            gvUserInfo.DataBind();

        }
    }
}