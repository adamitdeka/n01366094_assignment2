<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calender.aspx.cs" Inherits="n01366094_assignment2.calender" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="calenderForm" runat="server">
        <h2>Select the days you go to work.</h2>
        <asp:CheckBoxList runat="server" ID="weekDays">
            <asp:ListItem Value="sunday">SUNDAY</asp:ListItem>
            <asp:ListItem Value="monday">MONDAY</asp:ListItem>
            <asp:ListItem Value="tuesday">TUESDAY</asp:ListItem>
            <asp:ListItem Value="wednesday">WEDNESDAY</asp:ListItem>
            <asp:ListItem Value="thursday">THURSDAY</asp:ListItem>
            <asp:ListItem Value="friday">FRIDAY</asp:ListItem>
            <asp:ListItem Value="saturday">SATURDAY</asp:ListItem>
        </asp:CheckBoxList>
        <button type="submit" runat="server">Submit</button>
    </form>
    <div id="displayResult" runat="server"> </div>
</body>
</html>
