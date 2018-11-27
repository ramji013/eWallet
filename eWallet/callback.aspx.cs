using System;
using FintechAPI;


namespace eWallet
{
    public partial class callback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OAuth2 oAuth2 = new OAuth2();

            oAuth2.client_id = "f01805e4766ebdc5";
            oAuth2.client_secret = "be744c6869ffac80f421742f9aff0732";
            oAuth2.redirect_uri = "http://localhost:3000/callback.aspx";

            string code = Request.QueryString["code"];
            
            APIAccess.Result status = new APIAccess.Result();

            status.result = -1;
            status.value = "";
            
            APIAccess fidorapi = new APIAccess();

            status = fidorapi.GetAccessToken(oAuth2, code);

            if (status.result == 0)
            {
                Session["AccessToken"] = status.value;
                Response.Redirect("Index.aspx");
            }  

        }
    }
} 