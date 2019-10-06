<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Raffle_Bundle.aspx.cs" Inherits="Raffle_Bundle.Raffle_Bundle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ruffle Tool</title>
    <link rel="stylesheet" type="text/css" href="styles.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Raffle Tickets <br/> Purchasing and Bundling App</h1>
            <label>Enter a number of tickets you would like to buy: <br/> </label>
            <asp:TextBox runat="server" ID="user_input"></asp:TextBox>
            <%--<asp:RequiredFieldValidator runat="server"
                ControlToValidate="user_input"
                ErrorMessage="Enter a minimum of 1 ticket"></asp:RequiredFieldValidator>--%>
            <%--Validator from bdukesbdukes. “Asp.net Validation to Make Sure Textbox Has Integer Values.” Stack Overflow, stackoverflow.com/questions/1427629/asp-net-validation-to-make-sure-textbox-has-integer-values.--%>
            <%--Cannot find how to have no MaxValue --%>
            <asp:RangeValidator runat="server"
                ControlToValidate="user_input"
                ErrorMessage="Minimum number of tickets is 1."
                MaximumValue="1000000" 
                MinimumValue="1"
                Type="Integer"></asp:RangeValidator>

        </div>
        <div>
            <asp:Button runat="server" Text="Submit" ID="submit_button" />
        </div>
        <div runat="server" id="bundles_summary"></div>
    </form>
</body>
</html>
