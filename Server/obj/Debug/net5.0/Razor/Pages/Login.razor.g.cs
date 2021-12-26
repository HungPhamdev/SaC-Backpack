#pragma checksum "D:\DATN-SaC\Server\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e2e8f65b09328b3ef0bd0a66fb205cd171cae0d"
// <auto-generated/>
#pragma warning disable 1591
namespace Server.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\DATN-SaC\Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DATN-SaC\Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DATN-SaC\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DATN-SaC\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DATN-SaC\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DATN-SaC\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DATN-SaC\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\DATN-SaC\Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\DATN-SaC\Server\_Imports.razor"
using Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\DATN-SaC\Server\_Imports.razor"
using Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\DATN-SaC\Server\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\DATN-SaC\Server\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\DATN-SaC\Server\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\DATN-SaC\Server\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\DATN-SaC\Server\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DATN-SaC\Server\Pages\Login.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DATN-SaC\Server\Pages\Login.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DATN-SaC\Server\Pages\Login.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DATN-SaC\Server\Pages\Login.razor"
using Share.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DATN-SaC\Server\Pages\Login.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DATN-SaC\Server\Pages\Login.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\DATN-SaC\Server\Pages\Login.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\DATN-SaC\Server\Pages\Login.razor"
           [AllowAnonymous]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    #button {
        background-color: #E53935;
        border: none;
        border-radius: 5px;
        font-weight: 700;
        width: 60px;
    }

    .e-popup.e-popup-open.e-dialog {
        border-radius: 20px;
    }

    .e-dialog .e-dlg-header-content {
        background-color: #FF5252;
        border-radius: 20px 20px 0px 0px;
    }

        .e-dialog .e-dlg-header-content + .e-dlg-content {
            padding: 0;
        }

    .e-dialog .e-dlg-header {
        position: relative;
        font-size: 25px;
        font-weight: bold;
        color: linen;
        margin-left: 10px;
    }

    .e-dialog .e-footer-content {
        padding: 15px;
        border-radius: 0px 0px 20px 20px;
    }

    .e-dialog .e-dlg-header-content {
        padding: 6px;
    }

    .dialogText {
        color: #D50000;
        font-size: 20px;
        margin: 44px 11px;
        font-weight: 700;
    }

    .e-dialog .e-dlg-header-content .e-btn.e-dlg-closeicon-btn {
        margin-right: 10px;
    }

    .e-dialog .e-dlg-header-content .e-icon-dlg-close {
        color: #FFFFFF;
        margin-top: 10px;
    }

    .e-dlg-header, .e-dlg-header * {
        color: #FFFFFF;
    }
</style>
");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row justify-content-center");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-xl-10 col-lg-12 col-md-9");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card o-hidden border-0 shadow-lg my-5");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-body p-0");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row");
            __builder.AddMarkupContent(13, "<div class=\"col-lg-6 d-none d-lg-block bg-login-image\"></div>\r\n                        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-lg-6");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "p-5");
            __builder.AddMarkupContent(18, "<div class=\"text-center\"><h1 class=\"h4 text-gray-900 mb-4\">Đăng Nhập SaC Website</h1></div>\r\n                                ");
            __builder.OpenElement(19, "form");
            __builder.AddAttribute(20, "class", "user");
            __builder.AddAttribute(21, "onsubmit", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 86 "D:\DATN-SaC\Server\Pages\Login.razor"
                                                              CheckLogin

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "form-group");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "type", "text");
            __builder.AddAttribute(26, "class", "form-control form-control-user");
            __builder.AddAttribute(27, "id", "username");
            __builder.AddAttribute(28, "aria-describedby", "emailHelp");
            __builder.AddAttribute(29, "placeholder", "Tên đăng nhập");
            __builder.AddAttribute(30, "required");
            __builder.AddAttribute(31, "autofocus");
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 89 "D:\DATN-SaC\Server\Pages\Login.razor"
                                                                     username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                                    ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "form-group");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "type", "password");
            __builder.AddAttribute(39, "class", "form-control form-control-user");
            __builder.AddAttribute(40, "id", "password");
            __builder.AddAttribute(41, "placeholder", "Mật khẩu");
            __builder.AddAttribute(42, "required");
            __builder.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 93 "D:\DATN-SaC\Server\Pages\Login.razor"
                                                                       password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n\r\n                                    ");
            __builder.AddMarkupContent(46, "<button class=\"btn btn-primary btn-user btn-block\" type=\"submit\">Đăng nhập</button>");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                                <hr>\r\n                                ");
            __builder.AddMarkupContent(48, "<div class=\"text-center\"><a class=\"small\" href=\"/forgotPassword\">Quên mật khẩu?</a></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
            __builder.OpenComponent<Syncfusion.Blazor.Popups.SfDialog>(50);
            __builder.AddAttribute(51, "Width", "509px");
            __builder.AddAttribute(52, "Height", "220px");
            __builder.AddAttribute(53, "IsModal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 111 "D:\DATN-SaC\Server\Pages\Login.razor"
                                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "ShowCloseIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 111 "D:\DATN-SaC\Server\Pages\Login.razor"
                                                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 111 "D:\DATN-SaC\Server\Pages\Login.razor"
                                                                                          IsVisible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "VisibleChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => IsVisible = __value, IsVisible))));
            __builder.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogTemplates>(58);
                __builder2.AddAttribute(59, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(60, "<i class=\"fa fa-exclamation-triangle\"></i> Thông báo!");
                }
                ));
                __builder2.AddAttribute(61, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(62, "<h1 class=\"dialogText\">Đăng nhập thất bại! Tài khoản đã dừng hoạt động!</h1>");
                }
                ));
                __builder2.AddAttribute(63, "FooterTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(64, "button");
                    __builder3.AddAttribute(65, "id", "button");
                    __builder3.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 118 "D:\DATN-SaC\Server\Pages\Login.razor"
                                           CloseDialog

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(67, "class", "e-control e-btn");
                    __builder3.AddAttribute(68, "data-ripple", "true");
                    __builder3.AddContent(69, "OK");
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(70, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogAnimationSettings>(71);
                __builder2.AddAttribute(72, "Effect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Popups.DialogEffect>(
#nullable restore
#line 121 "D:\DATN-SaC\Server\Pages\Login.razor"
                                     DialogEffect.FlipXDown

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(73, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 121 "D:\DATN-SaC\Server\Pages\Login.razor"
                                                                      600

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 124 "D:\DATN-SaC\Server\Pages\Login.razor"
      
    private ToastParameters _toastParameters;

    string username = "";
    string password = "";

    private string Encode(string param)
    {
        return HttpUtility.UrlEncode(param);
    }
    //public void Enter(KeyboardEventArgs e)
    //{
    //    if (e.Code == "Enter" || e.Code == "NumpadEnter")
    //    {
    //        CheckLogin();
    //    }
    //}
    private void CheckLogin()
    {
        _toastParameters = new ToastParameters();
        if (username == "")
        {
            _toastParameters.Add(nameof(Notification.Title), "Vui lòng nhập tài khoản!");
            _toastParameters.Add(nameof(Notification.IsSuccess), false);
            toastService.ShowToast<Notification>(_toastParameters);
        }
        if (password == "")
        {
            _toastParameters.Add(nameof(Notification.Title), "Vui lòng nhập mật khẩu!");
            _toastParameters.Add(nameof(Notification.IsSuccess), false);
            toastService.ShowToast<Notification>(_toastParameters);
        }
        if (username != "" && password != "")
        {
            var viewLogin = new ViewLogin() { UserName = username, Password = password };
            User user = _userService.Login(viewLogin);
            if (user != null)
            {
                if (user.Status == false)
                {
                    OpenDialog();
                }
                else
                {
                    NavigationManager.NavigateTo("CheckLogin?paramUsername=" + @Encode(@username)
                    + "&paramPassword=" + @Encode(@password), true);
                }
            }
            else
            {

                _toastParameters.Add(nameof(Notification.Title), "Đăng nhập thất bại! Vui lòng kiểm tra lại thông tin");
                _toastParameters.Add(nameof(Notification.IsSuccess), false);
                toastService.ShowToast<Notification>(_toastParameters);
            }
        }
    }

    private bool IsVisible { get; set; }

    private void OpenDialog()
    {
        IsVisible = true;
    }

    private void CloseDialog()
    {
        IsVisible = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Share.Interfaces.IUserSvc _userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
