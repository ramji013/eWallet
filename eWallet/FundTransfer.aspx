<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FundTransfer.aspx.cs" Inherits="eWallet.FundTransfer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTransferTo" runat="server" Text="Transfer To :     "></asp:Label>
            <asp:TextBox ID="txtTrasferTo" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblAmount" runat="server" Text="Amount :        "></asp:Label>
            <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblSubject" runat="server" Text="Subject :       "></asp:Label>
            <asp:TextBox id="txtSubject" TextMode="multiline" Columns="50" Rows="5" runat="server" />
            <br />
            <br />
            <asp:Button ID="btnOk" runat="server" Text="Ok"  OnClick="transferFund_Click" />


            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="lblSubjectlabel" runat="server" Text="Subject     :   "></asp:Label>
            <asp:Label ID="subjectData" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblFrom" runat="server" Text="From     :   "></asp:Label>
            <asp:Label ID="lblFromData" runat="server"></asp:Label>
            <br />
            <br />

            <asp:Label ID="lblTo" runat="server" Text="To     :   "></asp:Label>
            <asp:Label ID="lblToData" runat="server"></asp:Label>
            <br />
            <br />

            <asp:Label ID="lblAmountLabel" runat="server" Text="Amount     :   "></asp:Label>
            <asp:Label ID="lblAmountData" runat="server"></asp:Label>
            <br />
            <br />

            <asp:Label ID="lblStateLabel" runat="server" Text="State     :   "></asp:Label>
            <asp:Label ID="lblStatus" runat="server"></asp:Label>
            <br />
            <br />

            <asp:Button ID="btnBactToIndex" runat="server" Text="Back to Home Page" OnClick="goToHomePage_Click" />

        </div>
    </form>
</body>
</html>



