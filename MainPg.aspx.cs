using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Headers;

using FidorData ;

namespace Project5
{
    public partial class Main : System.Web.UI.Page
    {
        protected  void Page_Load(object sender, EventArgs e)
        {
            if (Session["AccessToken"] != null)
            {
                ImgMain.ImageUrl = "./Financial_2_Img.jpg";

                //     lblLoginStatus.Text += "Fidor login Successful !!!" + "<br/>";
  
                AccountDetail api = new AccountDetail();
            }
        }

        protected async void btnGetAccount_Click(object sender, EventArgs e)
        {
            await APIConnector.client.sendAPI(FidorAPI.getUersCurrent);
            Response.Redirect("GetAccountPg.aspx");
        }

        protected async void btnGetAccounts_Click(object sender, EventArgs e)
        {
            await APIConnector.client.sendAPI(FidorAPI.getAccountsURL);
            Response.Redirect("GetAccountDetailPg.aspx");
        }

        protected void btnTnx_Click(object sender, EventArgs e)
        {
        }

        protected void btnFundTxf_Click(object sender, EventArgs e)
        {
            Response.Redirect("FundTransfer.aspx");
        }
    }
}