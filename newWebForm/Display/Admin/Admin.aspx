<%@ Page Title="" Language="C#" MasterPageFile="~/Display/myMasterPages/Admin.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="newWebForm.Display.Admin.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContentAdmin" runat="server">
    
    <form runat="server">

        <div  class="container-fluid px-4">
        <h1 class="mt-4">Danh sách người dùng</h1>
        <ol class="breadcrumb mb-4">
            <li class="breadcrumb-item"><a href="/views/admin/">Quay lại</a></li>
            <li class="breadcrumb-item active">Quản lý người dùng</li>
        </ol>
        <asp:Button ID="btnCreate"  runat="server" CssClass="mr-2 mb-3 btn btn-success" Text="Thêm mới người dùng" OnClick="btnCreate_Click"/> 
        <asp:GridView ID="dgv__User" CssClass="table" GridLines="None" runat ="server" EnableViewState="false" AutoGenerateColumns="false" DataKeyNames="userID"
            OnRowDeleting="dgv__User_RowDeleting" OnRowEditing="dgv__gvUser_RowEditing" >
            <Columns >
                
                <asp:TemplateField  HeaderText="userID">
                    
                    <ItemTemplate >  
                    <asp:Label runat="server" ID="lbID" Text='<%#:Eval("userID")%>' Visible="false"></asp:Label>
                    <asp:Label runat="server" ID="lbPassword" Text='<%#:Eval("userPassWord")%>' Visible="false"></asp:Label>
                      <%#Eval("userID")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField  HeaderText="userName">
                    <ItemTemplate>  
                           <a href="/Display/updateUser.aspx?user_id=<%#Eval("userID") %>"> <%#Eval("userName") %></a>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField  HeaderText="Password">
                    <ItemTemplate>  
                          <%#Eval("userPassWord")%>
                    </ItemTemplate>
                </asp:TemplateField>
              
                <asp:CommandField ShowDeleteButton="true" DeleteText="Xóa"  ButtonType="Button" ControlStyle-CssClass="btn btn-danger"  />
                <asp:CommandField ShowEditButton="true" UpdateText="Sửa"  ButtonType="Button" ControlStyle-CssClass="btn btn-warning" EditText="Sửa"/>
            </Columns>
            
            <HeaderStyle CssClass="thead-dark"/>
      </asp:GridView>
        </div>
    </form>

</asp:Content>
