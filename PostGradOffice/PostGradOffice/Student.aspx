<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="PostGradOffice.Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 23px;
            left: 13px;
            z-index: 1;
            width: 151px;
        }
        .auto-style2 {
            position: absolute;
            top: 66px;
            left: 37px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 138px;
            left: 10px;
            z-index: 1;
            width: 147px;
        }
        .auto-style4 {
            position: absolute;
            top: 179px;
            left: 30px;
            z-index: 1;
            width: 63px;
        }
        .auto-style5 {
            position: absolute;
            top: 180px;
            left: 261px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 136px;
            left: 239px;
            z-index: 1;
            width: 156px;
        }
        .auto-style7 {
            position: absolute;
            top: 242px;
            left: 14px;
            z-index: 1;
            width: 153px;
        }
        .auto-style8 {
            position: absolute;
            top: 248px;
            left: 199px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 336px;
            left: 17px;
            z-index: 1;
            width: 114px;
        }
        .auto-style10 {
            position: absolute;
            top: 341px;
            left: 194px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style1" Text="view my profile:"></asp:Label>
        <p>
            <asp:Label ID="Label4" runat="server" CssClass="auto-style7" Text="my progress reports:"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" CssClass="auto-style2" OnClick="Button1_Click" Text="view" />
            <asp:Label ID="Label3" runat="server" CssClass="auto-style6" Text="view courses:"></asp:Label>
        </p>
        <asp:Label ID="Label2" runat="server" CssClass="auto-style3" Text="view thesis:"></asp:Label>
        <asp:Button ID="Button2" runat="server" CssClass="auto-style4" OnClick="Button2_Click" Text="view" />
        <asp:Button ID="Button3" runat="server" CssClass="auto-style5" OnClick="Button3_Click" Text="view" />
        <asp:Button ID="Button4" runat="server" CssClass="auto-style8" OnClick="Button4_Click" Text="view" />
        <asp:Label ID="Label5" runat="server" CssClass="auto-style9" Text="add publication:"></asp:Label>
        <asp:Button ID="Button5" runat="server" CssClass="auto-style10" OnClick="Button5_Click" Text="Add" />
    </form>
</body>
</html>
