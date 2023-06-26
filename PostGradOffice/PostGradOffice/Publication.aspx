<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Publication.aspx.cs" Inherits="PostGradOffice.Publication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {   
            position: absolute;
            top: 73px;
            left: 69px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 74px;
            left: 333px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 155px;
            left: 68px;
            z-index: 1;
            right: 1436px;
        }
        .auto-style4 {
            position: absolute;
            top: 155px;
            left: 327px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 75px;
            left: 567px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 110px;
            left: 10px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 109px;
            left: 270px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 204px;
            left: 13px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 203px;
            left: 274px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 112px;
            left: 530px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 293px;
            left: 189px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style1" Text="title:"></asp:Label>
        <asp:Label ID="Label2" runat="server" CssClass="auto-style2" Text="date:"></asp:Label>
        <asp:Label ID="Label3" runat="server" CssClass="auto-style3" Text="host:"></asp:Label>
        <asp:Label ID="Label4" runat="server" CssClass="auto-style4" Text="place:"></asp:Label>
        <asp:Label ID="Label5" runat="server" CssClass="auto-style5" Text="accepted:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style6"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style7"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style8"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="TextBox4" runat="server" CssClass="auto-style9"></asp:TextBox>
        <asp:TextBox ID="TextBox5" runat="server" CssClass="auto-style10"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" CssClass="auto-style11" OnClick="Button1_Click" Text="add publication" />
    </form>
</body>
</html>
