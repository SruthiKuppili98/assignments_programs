<%@Page trace="true"  Language="C#" AutoEventWireup="true" CodeBehind="count.aspx.cs" Inherits="statemanagemetdemoonweb.count" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" BorderColor="#003300" ForeColor="#99CCFF" OnClick="Button1_Click" Text="Hit up" />
       <asp:Button ID="Button2" runat="server" BorderColor="#003300" ForeColor="#99CCFF"  Text="Open Another Page" PostBackUrl="~/gethiddenfieldvalues.aspx" />
      
            <asp:HiddenField ID="hfCount1" runat="server" Value="0" />
             
        </div>
    </form>
</body>
</html>
