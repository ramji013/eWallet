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

namespace eWallet
{
    public partial class GetAccountDetailsPg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AccountDetailData rtAcct = (AccountDetailData)Session["AccountDetailData"];

            if (rtAcct != null)
            {
                List<AccountDetailData.Datum> acctList = rtAcct.data;
                if (acctList == null)
                {
                   // lblId.Text = "account list null" + "<br/>";
                }
                else
                {
                    foreach (AccountDetailData.Datum acct in acctList)
                    {
                        if (acct != null)
                        {
                            string name = acct.id;
                           //lblId.Text = name + "<br/>";
                        }
                        else
                            break;
                    }
                }
            }
        }
    }
}