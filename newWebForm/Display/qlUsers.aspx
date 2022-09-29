<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="qlUsers.aspx.cs" Inherits="newWebForm.Display.qlUsers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h1>Cập nhật người dùng</h1>
            <asp:Button ID="btn__Create"  runat="server" OnClick="btn__Create_Click" Text="Thêm mới"/> 
            <asp:GridView  ID="dgv__User" AutoGenerateColumns="False" runat="server" Width="100%" CellPadding="4"
                   EnableViewState="False" DataKeyNames="userID" ForeColor="#333333" OnRowDeleting="dgv__User_RowDeleting" OnRowEditing="dgv__User_RowEditing"> 
             <Columns>
                 <asp:TemplateField HeaderText="UserID" HeaderStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                     <%#Eval("userID") %>
                    </ItemTemplate>                
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 
                <asp:TemplateField HeaderText="UserName" HeaderStyle-HorizontalAlign="Left"  >
                    <ItemTemplate>
                    <asp:Label ID="lblUserName" runat="server" Text='<%#Eval("userName") %>' Visible="false"></asp:Label>
                    <asp:Label ID="lblUserId" runat="server" Text='<%#Eval("userID") %>' Visible="false"></asp:Label>
                     <a href="/Display/updateUser.aspx?user_id=<%#Eval("userID") %>"> <%#Eval("userName") %></a>
                    </ItemTemplate>

                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 
                <asp:TemplateField HeaderText="Password" HeaderStyle-HorizontalAlign="Left" >
                    <ItemStyle HorizontalAlign="left" Wrap="True" />
                    <HeaderStyle HorizontalAlign="left" />
                    <ItemTemplate>
                        <%#Eval("userPassWord")  %><%--<%# Convert.ToDateTime(Eval("UserDOB")).ToString("dd/MM/yyyy") %>--%> 
                    </ItemTemplate>
                </asp:TemplateField>
                 
                 <asp:CommandField ShowDeleteButton="true" DeleteText="Xóa"  ButtonType="Button" />
                 <asp:CommandField ShowEditButton="true" UpdateText="Sửa"  ButtonType="Button" EditText="Sửa" />
               
            </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
