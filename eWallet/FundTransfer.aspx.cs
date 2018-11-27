using System;


namespace eWallet
{
    public partial class FundTransfer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void transferFund_Click(object sender, EventArgs e){
            lblAmountData.Text = txtAmount.Text;
            subjectData.Text = txtSubject.Text;
            lblToData.Text = txtTrasferTo.Text;
        }
    }
}