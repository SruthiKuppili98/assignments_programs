<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="EMPLOYEE.aspx.vb" Inherits="data_bound.EMPLOYEE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            EMPLOYEE DETAILS</div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="EMP ID"></asp:Label>
                </td>
                <td>&nbsp;
                    <asp:Label ID="Label17" runat="server" Text='<%# Eval("EMP ID")%>'></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="EMP NAME"></asp:Label>
                </td>
                <td>&nbsp;
                    <asp:Label ID="Label5" runat="server" Text='<%# Eval("EMP NAME")%>'></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="EMP EMAILID"></asp:Label>
                </td>
                <td>&nbsp;
                    <asp:Label ID="Label8" runat="server" Text='<%# Eval("EMP EMAILID")%>'></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="EMP MOBILE NO"></asp:Label>
                </td>
               <td>&nbsp;
                    <asp:Label ID="Label9" runat="server" Text='<%# Eval("EMP MOBILE NO")%>'></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="EMP IMAGE"></asp:Label>
                </td>
               <td rowspan="5">&nbsp;
                   <asp:Image ID="img1" runat="server" Width="217px" ImageUrl='<%# "C:\Users\skuppili3\Downloads"%>' Height="162px" /> 
                    <asp:Label ID="Label10" runat="server" Text='<%# Eval("EMP IMAGE")%>'></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="EMP GENDER"></asp:Label>
                </td>
                <td>&nbsp;
                    <asp:Label ID="Label11" runat="server" Text='<%# Eval("EMP GENDER")%>'></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
