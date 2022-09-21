<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formLogin.aspx.cs" Inherits="newWebForm.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Form Login</title>
    <link rel="stylesheet" href="Assets/CSS/style.css"/>
    <link rel="stylesheet" href="Assets/CSS/grid.css"/>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.2/css/all.min.css" integrity="sha512-1sCRPdkRXhBV2PBLUdRb4tMg1w2YPf37qatUFeS7zlBy7jJI8Lf4VHwWfZZfpXtYSLy85pkm9GaYVYMfw5BC1A==" crossorigin="anonymous" referrerpolicy="no-referrer" />
</head>
<body>
    <form id="form__login" runat="server">
        <div class="main main__background">          
                <div class="grid">
                    <div class="row">
                        <div class="col l-o-4 l-4 c-12">
                            <div class="content">
                                <div class="form__login">
                                    <div class="title">
                                        <h1 class=""> Đăng Nhập</h1>
                                        <h2 class="link__form--register"> Đăng ký ngay <a href="#">tại đây</a></h2>
                                    </div>     

                                    <div class="form-group">
                                        <asp:TextBox ID="txt_userName" runat="server" class="input__username form-control" name="user" placeholder="Vui lòng nhập tên đăng nhập..."></asp:TextBox>                            
                                        <span class="errorMessage__1"></span>
                                    </div>

                                    <div class="form-group">
                                        <asp:TextBox ID="txt_userPassWord" runat="server" class="input__username form-control" name="user" placeholder="Vui lòng nhập mật khẩu ..."></asp:TextBox>
                                        <span class="errorMessage__2"></span>
                                    </div>

                                    <asp:Button ID="btn__Login" class="btn__Login" runat="server" Text="ĐĂNG NHẬP" OnClick="btn__Login_Click" />
                                    <div class="forgot__PassWord">
                                        <a href="#">Quên mật khẩu?</a>
                                    </div>

                                    <div class="or">
                                        <div class="line"></div>
                                        <p class="">HOẶC</p>
                                        <div class="line"></div>
                                    </div>
                                    
                                    <div class="select__login">
                                        <button class="btn__login--facebook">
                                            <i class="fa-brands fa-facebook"></i>
                                            FACEBOOK
                                        </button>

                                        <button class="btn__login--google">
                                            <i class="fa-brands fa-google"></i>
                                            GOOGLE
                                        </button>
                                    </div>
                                </div>
                            </div>                          
                        </div>
                    </div>
                </div>                     
        </div>
    </form>
    <script src="Assets/JS/Validation.js"></script>
</body>
</html>
