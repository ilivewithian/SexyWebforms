<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SexyWebforms.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sexy Webforms</title>
    <link href="Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:LinkButton CssClass="button" Text="Look at my sexy curves" runat="server" />
        <div class="clear">&nbsp;</div>
        <asp:HyperLink CssClass="button" NavigateUrl="#" runat="server" Text="Hyperlinks can be sexy too" />
    </div>
    </form>
</body>
</html>
