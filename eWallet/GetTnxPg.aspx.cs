using System;
using System.Collections.Generic;

namespace eWallet
{
    public partial class TnxPg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = Session["jsonStr"].ToString();

            //  TnxAPI api = new TnxAPI();

            // Data to be used for UI
            TnxData tnxDetail = null; //(TnxData)api.apiResult;

            if (tnxDetail != null)
            {
                List<TnxData.Datum> tnxList = tnxDetail.data;
                if (tnxList == null)
                {
                 //   lblId.Text = "Tnx list null" + "<br/>";
                }
                else
                {
                    foreach (TnxData.Datum tnx in tnxList)
                    {
                        if (tnx != null)
                        {
                            string name = tnx.id;
                          //  lblId.Text = name + "<br/>";
                        }
                        else
                            break;
                    }
                }

            }
            else
            {
                Response.Write("Tnx is null");

            }
        }
    }
}