<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="updateUser.aspx.cs" Inherits="newWebForm.Display.updateUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h3>Cập nhật thong tin người dùng</h3>
        <div class="main">
            <div class="form-group">
                <asp:Label runat="server">userID: </asp:Label>
                <asp:TextBox ID="txtUserID" runat="server"></asp:TextBox>
            </div>

             <div class="form-group">
                <asp:Label runat="server">userName: </asp:Label>
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            </div>

             <div class="form-group">
                  <asp:Label runat="server">Password: </asp:Label>
                    <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
            </div>
            
            <asp:Button ID="btn_Save" runat="server" Text="Lưu" OnClick="btn_Save_Click"/>

        </div>
    </form>
</body>
</html>
