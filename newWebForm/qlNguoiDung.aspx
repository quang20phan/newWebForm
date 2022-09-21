<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="qlNguoiDung.aspx.cs" Inherits="newWebForm.qlNguoiDung" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Quản Lý User</title>
    <link rel="stylesheet" href="Assets/styleFormUser.css">

</head>
<body>
    <div class="backgr">
        <form id="form1" runat="server">
         <div class ="title__Form">CẬP NHẬT NGƯỜI DÙNG</div>
        <div class="container">
           
            <div class ="form__group">
                <asp:Label ID="Label1" runat="server" Text="Label">ID: </asp:Label>             
                <asp:TextBox ID="txtUserID" runat="server" class="tbox1"></asp:TextBox>              
            </div>

             <div class ="form__group">
                <asp:Label ID="Label2" runat="server" Text="Label">Tên Tài Khoản: </asp:Label>              
                <asp:TextBox ID="txtUserName" runat="server" class="tbox2"></asp:TextBox>              
            </div>

            <div class ="form__group">
                <asp:Label ID="Label3" runat="server" Text="Label">Mật Khẩu: </asp:Label>              
                <asp:TextBox ID="txtPassWord" runat="server" class="tbox3"></asp:TextBox>                            
            </div>

            <div class ="btn">

                <asp:Button ID="btnThem" runat="server" Text="THÊM" class="btn__size" OnClick="btnThem_Click" />
                <asp:Button ID="btnSua" runat="server" Text="Sửa" class="btn__center btn__size" OnClick="btnSua_Click"/>
                <asp:Button ID="btnXoa" runat="server" Text="Xóa" class="btn__size" OnClick="btnXoa_Click" />
                <asp:Button ID="btnReset" runat="server" Text="Làm mới" class="btn__size btn__reset" OnClick="btnReset_Click" />

            </div>
             
                <asp:GridView ID="dgv__User" runat="server" class="dgv__user" OnSelectedIndexChanged="dgv__User_SelectedIndexChanged" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                    <Columns>
                        <asp:BoundField DataField="userID" HeaderText="User ID" />
                        <asp:BoundField DataField="userName" HeaderText="User Name" />
                        <asp:BoundField DataField="userPassWord" HeaderText="PassWord" />
                        <asp:CommandField SelectText="Chọn" ShowSelectButton="True" />
                    </Columns>
                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#330099" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                    <SortedAscendingCellStyle BackColor="#FEFCEB" />
                    <SortedAscendingHeaderStyle BackColor="#AF0101" />
                    <SortedDescendingCellStyle BackColor="#F6F0C0" />
                    <SortedDescendingHeaderStyle BackColor="#7E0000" />
                </asp:GridView>
                
            </div>
    </form>
    </div> 
</body>
</html>
