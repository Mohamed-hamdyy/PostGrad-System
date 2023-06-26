<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProgressReport.aspx.cs" Inherits="PostGradOffice.ProgressReport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 125px;
            left: 12px;
            z-index: 1;
            width: 295px;
        }
        .auto-style2 {
            position: absolute;
            top: 202px;
            left: 10px;
            z-index: 1;
            width: 295px;
        }
        .auto-style3 {
            position: absolute;
            top: 279px;
            left: 98px;
            z-index: 1;
            width: 169px;
        }
        .auto-style4 {
            position: absolute;
            top: 354px;
            left: 135px;
            z-index: 1;
            height: 110px;
            width: 553px;
            margin-right: 0px;
            margin-bottom: 12px;
        }
        .auto-style5 {
            position: absolute;
            top: 402px;
            left: 15px;
            z-index: 1;
            width: 156px;
        }
        .auto-style6 {
            position: absolute;
            top: 283px;
            left: 16px;
            z-index: 1;
            width: 167px;
            right: 1359px;
        }
        .auto-style7 {
            position: absolute;
            top: 27px;
            left: 16px;
            z-index: 1;
            width: 158px;
        }
        .auto-style8 {
            position: absolute;
            top: 32px;
            left: 189px;
            z-index: 1;
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button2" runat="server" CssClass="auto-style2" OnClick="Button2_Click" Text="Fill Progress Report" />
        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style3"></asp:TextBox>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style4" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" CssClass="auto-style5" Text="description:"></asp:Label>
        </p>
        <asp:Label ID="Label2" runat="server" CssClass="auto-style6" Text="state:"></asp:Label>
        <asp:Label ID="Label3" runat="server" CssClass="auto-style7" Text="enter the report number: " Visible="False"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style8" Visible="False"></asp:TextBox>
        <p>
        <asp:Button ID="Button1" runat="server" CssClass="auto-style1" OnClick="Button1_Click" Text="Add Progress Report" />
        </p>
    </form>
</body>
</html>
