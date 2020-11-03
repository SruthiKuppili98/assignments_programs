<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="student.aspx.cs" Inherits="studentdatabound.student" %>

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
        <div style="background-color:antiquewhite">
            <asp:Repeater ID="repeater2" runat="server">
                <HeaderTemplate>
                    <table>
                        <tr>
            <td>STUDENT DETAILS</td>
                            </tr>
                        </table>
                    </HeaderTemplate>
                <ItemTemplate>
        <table style="width:100%;border:solid 2px; background-color:burlywood">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="StudentID"></asp:Label>
                </td>
                <td><asp:Label ID="Label11" runat="server" Text='<% #Eval("StudentId")%>'></asp:Label></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label2" runat="server" Text="Student Name"></asp:Label>
                </td>
                <td><asp:Label ID="Label9" runat="server" Text='<% #Eval("Student Name")%>'></asp:Label></td>
                <td>&nbsp;</td>
                
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Text="Student EmailId"></asp:Label>
                </td>
                <td><asp:Label ID="Label10" runat="server" Text='<% #Eval("Student EmailId")%>'></asp:Label></td>
                <td>&nbsp;</td>>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label4" runat="server" Text="Student Mobile No"></asp:Label>
                </td>
               <td><asp:Label ID="Label12" runat="server" Text='<% #Eval("Student Mobile No")%>'></asp:Label></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label5" runat="server" Text="Student Adress"></asp:Label>
                </td>
                <td><asp:Label ID="Label13" runat="server" Text='<% #Eval("Student Adress")%>'></asp:Label></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label6" runat="server" Text="Student City"></asp:Label>
                </td>
                <td><asp:Label ID="Label14" runat="server" Text='<% #Eval("Student City")%>'></asp:Label></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label7" runat="server" Text="Student Gender"></asp:Label>
                </td>
               <td><asp:Label ID="Label15" runat="server" Text='<% #Eval("Student Gender")%>'></asp:Label></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label8" runat="server" Text="Student Image"></asp:Label>
                </td>
               <td rowspan="5"><asp:Image ID="image1" runat="server" Width="100px" ImageUrl='Jimin.jpg<% #Eval("StudentImage")%>'></asp:Image></td>
                <td>&nbsp;</td>
            </tr>
        </table>
                     </ItemTemplate>
                <FooterTemplate>
                    <table style="background-color:black;border:solid 2px;color:cadetblue">
                        <tr>
                            <td>
                                 @developed by Sruthi<br />
                                @All Copyrights reserved to this Page

                            </td>

                        </tr>
                    </table>
                </FooterTemplate>
                 </asp:Repeater>
        </div>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudentTableConnectionString %>" SelectCommand="SELECT * FROM [Student]"></asp:SqlDataSource>

    </form>
</body>
</html>