<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="date.aspx.cs" Inherits="_29_12.date" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblDateTime" runat="server" Font-Size="50px"></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="ddlColors" runat="server" OnSelectedIndexChanged="ddlColors_SelectedIndexChanged">
                <asp:ListItem>black</asp:ListItem>
                <asp:ListItem>yellow</asp:ListItem>
                <asp:ListItem>blue</asp:ListItem>
                <asp:ListItem>green</asp:ListItem>
                <asp:ListItem>red</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>