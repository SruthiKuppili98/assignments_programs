<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Surprise_pro.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 177px;
        }
        .auto-style2 {
            width: 262px;
        }
        .auto-style3 {
            width: 177px;
            height: 26px;
        }
        .auto-style4 {
            width: 262px;
            height: 26px;
        }
        .auto-style5 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">UserName</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox1" runat="server" Width="260px" AutoPostBack="True"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter Valid Name" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Password</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="256px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">ConfirmPassword</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" Width="256px"></asp:TextBox>
                    </td>
                    <td class="auto-style5">
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="Enter valid Password" ForeColor="Red"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Age</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox4" runat="server" Width="251px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="Enter valid Age" ForeColor="Red" MaximumValue="79" MinimumValue="10"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Gender</td>
                    <td class="auto-style2">
                        <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" GroupName="Gender" Text="Male" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" GroupName="Gender" Text="Female" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>