<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Pract9.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Multiple Image Upload</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" AllowMultiple="true"/>
        </div>
        <div>&nbsp;</div>
        <div>
            <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click"></asp:Button>&nbsp;
        </div>
       

    </form>
</body>
</html>
