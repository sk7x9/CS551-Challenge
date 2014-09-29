<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="challenge.Register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <h1>
            Register</h1>
        <p>
            <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" 
                ContinueDestinationPageUrl="~/Default.aspx">
                <WizardSteps>
                    <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server" />
                    <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server" />
                </WizardSteps>
            </asp:CreateUserWizard>
        </p>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Home</asp:HyperLink>
        </p>
    
    </div>
    </form>
</body>
</html>
