<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stores.aspx.cs" Inherits="challenge.stores" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
          Search Store :
        <asp:TextBox ID="SearchBox" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="SearchBtn" runat="server" OnClick="SearchBtn_Click" Text="Submit" />
        <br />
        <br />
        <asp:Label ID="resultbox" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
