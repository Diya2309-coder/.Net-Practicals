<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="prac11.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" BorderStyle="Solid"></asp:TextBox>

            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" BackColor="#CCFFFF" ForeColor="#660033" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
