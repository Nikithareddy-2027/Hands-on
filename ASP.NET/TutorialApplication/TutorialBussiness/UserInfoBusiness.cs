using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialApplicationEntity;
using TutorialDataLayer;

namespace TutorialBussiness
{
    public class UserInfoBusiness
    {
        public string InsertDetails(UserInfoModel userInfoModel)
        {
            UserInfoDataConnection userInfoData = new UserInfoDataConnection();
            string msg = userInfoData.InsertInfo(userInfoModel);
            return msg;
        }
        public DataTable GetDetails()
        {
            UserInfoDataConnection userInfoData = new UserInfoDataConnection();
            DataTable dtObj = userInfoData.SelectInfo();
            return dtObj;
        }
    }
}
