#pragma checksum "D:\DATN-SaC\Server\Pages\ChangePassword.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfade41c43dc4fd606a0f741a89d723a92935f2e"
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
#line 13 "D:\DATN-SaC\Server\_Imports.razor"
using Syncfusion.Blazor.Popups;

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
#line 7 "D:\DATN-SaC\Server\Pages\ChangePassword.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\DATN-SaC\Server\Pages\ChangePassword.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\DATN-SaC\Server\Pages\ChangePassword.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\DATN-SaC\Server\Pages\ChangePassword.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/changepass")]
    public partial class ChangePassword : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    #button {
        background-color: #009688;
        border: none;
        border-radius: 5px;
        color: #FFFFFF;
        font-weight: 700;
        width: 60px;
    }

    .e-popup.e-popup-open.e-dialog {
        border-radius: 20px;
    }

    .e-dialog .e-dlg-header-content {
        background-color: #689F38;
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
        color: #33691E;
        font-size: 20px;
        margin: 44px 19px;
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
            __builder.AddAttribute(2, "class", "container mt-5");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-6 mx-auto");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card card-signin flex-row shadow-lg card-signup");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-body");
            __builder.AddMarkupContent(11, "<h2 class=\"card-title text-center font-weight-bold text-uppercase\">ĐỔI MẬT KHẨU</h2>\r\n                    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-md-12");
            __builder.OpenElement(14, "form");
            __builder.AddAttribute(15, "onsubmit", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 79 "D:\DATN-SaC\Server\Pages\ChangePassword.razor"
                                         ChangePass

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "form-label-group mt-3");
            __builder.AddMarkupContent(18, "<label class=\"control-label\">Mật khẩu cũ</label>\r\n                                ");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "type", "password");
            __builder.AddAttribute(21, "class", "form-control");
            __builder.AddAttribute(22, "required");
            __builder.AddAttribute(23, "autofocus");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 82 "D:\DATN-SaC\Server\Pages\ChangePassword.razor"
                                                                                   oldPass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => oldPass = __value, oldPass));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n                            ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "form-label-group mt-3");
            __builder.AddMarkupContent(29, "<label class=\"control-label\">Mật khẩu mới</label>\r\n                                ");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "type", "password");
            __builder.AddAttribute(32, "class", "form-control");
            __builder.AddAttribute(33, "required");
            __builder.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 87 "D:\DATN-SaC\Server\Pages\ChangePassword.razor"
                                                                                   newPass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newPass = __value, newPass));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n                            ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "form-label-group mt-3");
            __builder.AddMarkupContent(39, "<label class=\"control-label\">Nhập lại mật khẩu</label>\r\n                                ");
            __builder.OpenElement(40, "input");
            __builder.AddAttribute(41, "type", "password");
            __builder.AddAttribute(42, "class", "form-control");
            __builder.AddAttribute(43, "required");
            __builder.AddAttribute(44, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 92 "D:\DATN-SaC\Server\Pages\ChangePassword.razor"
                                                                                   confirmPass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => confirmPass = __value, confirmPass));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                            ");
            __builder.AddMarkupContent(47, "<div class=\"form-label-group mt-3\"><button class=\"btn btn-info\" type=\"submit\">Đổi mật khẩu</button></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n\r\n");
            __builder.OpenComponent<Syncfusion.Blazor.Popups.SfDialog>(49);
            __builder.AddAttribute(50, "Width", "509px");
            __builder.AddAttribute(51, "Height", "220px");
            __builder.AddAttribute(52, "IsModal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 105 "D:\DATN-SaC\Server\Pages\ChangePassword.razor"
                                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "ShowCloseIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 105 "D:\DATN-SaC\Server\Pages\ChangePassword.razor"
                                                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 105 "D:\DATN-SaC\Server\Pages\ChangePassword.razor"
                                                                                          IsVisible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "VisibleChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => IsVisible = __value, IsVisible))));
            __builder.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogTemplates>(57);
                __builder2.AddAttribute(58, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(59, "<i class=\"fa fa-check\"></i> Thông báo");
                }
                ));
                __builder2.AddAttribute(60, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(61, "<h1 class=\"dialogText\">Đổi mật khẩu thành công, vui lòng đăng nhập lại!</h1>");
                }
                ));
                __builder2.AddAttribute(62, "FooterTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(63, "button");
                    __builder3.AddAttribute(64, "id", "button");
                    __builder3.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 112 "D:\DATN-SaC\Server\Pages\ChangePassword.razor"
                                           Confirm

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(66, "class", "e-control e-btn");
                    __builder3.AddAttribute(67, "data-ripple", "true");
                    __builder3.AddContent(68, "OK");
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(69, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogAnimationSettings>(70);
                __builder2.AddAttribute(71, "Effect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Popups.DialogEffect>(
#nullable restore
#line 115 "D:\DATN-SaC\Server\Pages\ChangePassword.razor"
                                     DialogEffect.FlipXDown

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(72, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 115 "D:\DATN-SaC\Server\Pages\ChangePassword.razor"
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
#line 118 "D:\DATN-SaC\Server\Pages\ChangePassword.razor"
       
    public string oldPass, newPass, confirmPass;
    private ToastParameters _toastParameters;

    [CascadingParameter] protected Task<AuthenticationState> AuthStat { get; set; }
    string id;
    User user = new User();
    protected override void OnInitialized()
    {
        id = AuthStat.Result.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        user = _userService.GetUser(int.Parse(id));
    }

    public void ChangePass()
    {
        _toastParameters = new ToastParameters();
        if (!string.IsNullOrEmpty(oldPass) || !string.IsNullOrEmpty(newPass) || !string.IsNullOrEmpty(confirmPass))
        {
            if (string.Equals(user.Password, _encodeHelper.Encode(oldPass)))
            {
                if (string.Equals(newPass, confirmPass))
                {
                    user.Password = _encodeHelper.Encode(newPass);
                    user.ConfirmPass = user.Password;
                    int ret = _userService.EditUser(int.Parse(id), user);
                    if (ret == int.Parse(id))
                    {
                        //_toastParameters.Add(nameof(Notification.Title), "Đổi mật khẩu thành công, vui lòng đăng nhập lại!");
                        //_toastParameters.Add(nameof(Notification.IsSuccess), true);
                        //toastService.ShowToast<Notification>(_toastParameters);
                        //navigationManager.NavigateTo("/logout?returnUrl=/", true);
                        OpenDialog();
                    }
                    else
                    {
                        _toastParameters.Add(nameof(Notification.Title), "Đổi mật khẩu thất bại!");
                        _toastParameters.Add(nameof(Notification.IsSuccess), false);
                        toastService.ShowToast<Notification>(_toastParameters);
                    }

                }
                else
                {
                    _toastParameters.Add(nameof(Notification.Title), "Mật khẩu mới và xác nhận mật khẩu mới không khớp!");
                    _toastParameters.Add(nameof(Notification.IsSuccess), false);
                    toastService.ShowToast<Notification>(_toastParameters);
                }
            }
            else
            {
                _toastParameters.Add(nameof(Notification.Title), "Mật khẩu cũ không đúng!");
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

    private void Confirm()
    {
        navigationManager.NavigateTo("/logout?returnUrl=/", true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Share.Interfaces.IEncodeHelper _encodeHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Share.Interfaces.IUserSvc _userService { get; set; }
    }
}
#pragma warning restore 1591
