<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Datagriddatatable.aspx.cs" Inherits="WebApplication4.Datagriddatatable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataGrid ID="DataGrid1" runat="server" OnSelectedIndexChanged="DataGrid1_SelectedIndexChanged" />
            </div><br/><br/>
        <div>
            <asp:DataGrid ID="DataGrid2" runat="server" OnSelectedIndexChanged="DataGrid1_SelectedIndexChanged" />
        </div><br/><br/>
            <div>
            <asp:DataGrid ID="DataGrid3" runat="server" OnSelectedIndexChanged="DataGrid1_SelectedIndexChanged" />
        </div><br/><br/>
        <div>
            <asp:DataGrid ID="DataGrid4" runat="server" OnSelectedIndexChanged="DataGrid1_SelectedIndexChanged" />
        </div><br/><br/>
        <div>
            <asp:DataGrid ID="DataGrid5" runat="server" OnSelectedIndexChanged="DataGrid1_SelectedIndexChanged" />
        </div>
        
    </form>
</body>
</html>