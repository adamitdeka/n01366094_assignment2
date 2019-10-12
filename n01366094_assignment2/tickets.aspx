<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tickets.aspx.cs" Inherits="n01366094_assignment2.tickets" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="ticketForm" runat="server">
        <div>
            <label for="ticketNum">How many tickets you want?</label>
            <asp:TextBox runat="server" ID="ticketNum" ></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="ticketNum" ErrorMessage="Required a number" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:CompareValidator runat="server" ControlToValidate="ticketNum" ValueToCompare="0" Operator="GreaterThan" Type="Integer"  ErrorMessage="Value cannot be 0 or negative " ForeColor="Red" ></asp:CompareValidator>
        </div>
        <button type="submit" runat="server">Submit</button>
    </form>
    <div id="displayResult" runat="server"></div>
</body>
</html>

