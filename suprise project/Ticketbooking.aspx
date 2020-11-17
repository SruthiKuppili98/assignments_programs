<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TicketBooking.aspx.cs" Inherits="Surprise_pro.TicketBooking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<style type="text/css">
        .auto-style1 {
            width: 207px;
        }
    .auto-style2 {
        width: 275px;
    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False">
        </asp:GridView>
        
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">Passenger Name</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox1" runat="server" Width="209px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter Valid User Name" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Age</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox2" runat="server" Width="209px"></asp:TextBox>
                </td>
                <td>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter Valid Age" ForeColor="Red" MaximumValue="79" MinimumValue="10"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Gender</td>
                <td class="auto-style2">
                    <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" />
&nbsp;
                    <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Flight ID</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox3" runat="server" Width="209px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">FlightNumber</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox4" runat="server" Width="209px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">FlightName</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox5" runat="server" Width="209px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Source</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox6" runat="server" Width="209px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox6" ErrorMessage="Enter Valid Boarding Point" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Destination</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox7" runat="server" Width="209px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox7" ErrorMessage="Enter Valid Destination Point" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
        <br />
        <asp:Label ID="Label1" runat="server" ForeColor="Blue" Text="Take up your Flight!!!!!!!!!!!!!!!!!!!"></asp:Label>
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        <br />
        <br />
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Show" Width="63px" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
