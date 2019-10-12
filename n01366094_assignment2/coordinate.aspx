<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="coordinate.aspx.cs" Inherits="n01366094_assignment2.coordinate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="coordinateForm" runat="server" method="post">
        <div>
            <label for="xInput">X Coordinate:</label>
            <asp:TextBox ID="xInput" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="xInput" ErrorMessage="X coordinate field empty" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:CompareValidator runat="server" ControlToValidate="xInput" ValueToCompare="0" Operator="NotEqual"  ErrorMessage="Value cannot be 0 " ForeColor="Red" ></asp:CompareValidator>
        </div>
        <div>
            <label for="yInput">Y Coordinate:</label>
            <asp:TextBox ID="yInput" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="yInput" ErrorMessage="Y coordinate field empty" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:CompareValidator runat="server" ControlToValidate="yInput" ValueToCompare="0" Operator="NotEqual"  ErrorMessage="Value cannot be 0 " ForeColor="Red" ></asp:CompareValidator>
        </div>
        <button type="submit" id="coordinateSubmitForm">Submit</button>
    </form>
    <div id="displayResult" runat="server"></div>
</body>
</html>

