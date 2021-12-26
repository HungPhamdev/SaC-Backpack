#pragma checksum "D:\DATN-SaC\Client\Shared\WebLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d91f3d5237f21d7270a8109548a1f39434284cb2"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\DATN-SaC\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DATN-SaC\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DATN-SaC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DATN-SaC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DATN-SaC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DATN-SaC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DATN-SaC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\DATN-SaC\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\DATN-SaC\Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\DATN-SaC\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\DATN-SaC\Client\_Imports.razor"
using Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\DATN-SaC\Client\_Imports.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\DATN-SaC\Client\_Imports.razor"
using BlazorAnimate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\DATN-SaC\Client\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\DATN-SaC\Client\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\DATN-SaC\Client\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\DATN-SaC\Client\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\DATN-SaC\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\DATN-SaC\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DATN-SaC\Client\Shared\WebLayout.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DATN-SaC\Client\Shared\WebLayout.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\DATN-SaC\Client\Shared\WebLayout.razor"
using Pages;

#line default
#line hidden
#nullable disable
    public partial class WebLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 13 "D:\DATN-SaC\Client\Shared\WebLayout.razor"
         if (bool.Parse(context.User.Claims.Where(_ => _.Type == "firstLogin").Select(_ => _.Value).FirstOrDefault()))
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(2, "<style>\r\n                .blazored-modal {\r\n                    width: 960px;\r\n                }\r\n\r\n                main {\r\n                    min-height: 500px;\r\n                }\r\n\r\n                .blazored-toast-container {\r\n                    z-index: 200;\r\n                }\r\n\r\n                #button {\r\n                    background-color: #E53935;\r\n                    border: none;\r\n                    border-radius: 5px;\r\n                    color: #FFFFFF;\r\n                    font-weight: 700;\r\n                    width: 60px;\r\n                }\r\n\r\n                .e-popup.e-popup-open.e-dialog {\r\n                    border-radius: 20px;\r\n                }\r\n\r\n                .e-dialog .e-dlg-header-content {\r\n                    background-color: #FF5252;\r\n                    border-radius: 20px 20px 0px 0px;\r\n                }\r\n\r\n                    .e-dialog .e-dlg-header-content + .e-dlg-content {\r\n                        padding: 0;\r\n                    }\r\n\r\n                .e-dialog .e-dlg-header {\r\n                    position: relative;\r\n                    font-size: 25px;\r\n                    font-weight: bold;\r\n                    color: linen;\r\n                    margin-left: 10px;\r\n                }\r\n\r\n                .e-dialog .e-footer-content {\r\n                    padding: 15px;\r\n                    border-radius: 0px 0px 20px 20px;\r\n                }\r\n\r\n                .e-dialog .e-dlg-header-content {\r\n                    padding: 6px;\r\n                }\r\n\r\n                .dialogText {\r\n                    color: #D50000;\r\n                    font-size: 22px;\r\n                    margin: 51px 26px 20px;\r\n                    font-weight: 700;\r\n                }\r\n\r\n                .e-dialog .e-dlg-header-content .e-btn.e-dlg-closeicon-btn {\r\n                    margin-right: 10px;\r\n                }\r\n\r\n                .e-dialog .e-dlg-header-content .e-icon-dlg-close {\r\n                    color: #FFFFFF;\r\n                }\r\n\r\n                .e-dlg-header, .e-dlg-header * {\r\n                    color: #FFFFFF;\r\n                }\r\n            </style>");
#nullable restore
#line 86 "D:\DATN-SaC\Client\Shared\WebLayout.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.AddMarkupContent(4, "<style>\r\n    .blazored-modal {\r\n        width: 960px;\r\n    }\r\n\r\n    main {\r\n        min-height: 500px;\r\n    }\r\n\r\n    .blazored-toast-container {\r\n        z-index: 200;\r\n    }\r\n</style>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(5);
            __builder.AddAttribute(6, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 105 "D:\DATN-SaC\Client\Shared\WebLayout.razor"
         if (bool.Parse(context.User.Claims.Where(_ => _.Type == "firstLogin").Select(_ => _.Value).FirstOrDefault()))
        {


#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.SfDialog>(7);
                __builder2.AddAttribute(8, "Width", "509px");
                __builder2.AddAttribute(9, "Height", "220px");
                __builder2.AddAttribute(10, "IsModal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 108 "D:\DATN-SaC\Client\Shared\WebLayout.razor"
                                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 108 "D:\DATN-SaC\Client\Shared\WebLayout.razor"
                                                                                 IsVisible

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "VisibleChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => IsVisible = __value, IsVisible))));
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Popups.DialogTemplates>(14);
                    __builder3.AddAttribute(15, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(16, "<i class=\"fa fa-exclamation-triangle\"></i> Thông báo");
                    }
                    ));
                    __builder3.AddAttribute(17, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(18, "<h1 class=\"dialogText\">Vui lòng cập nhật đầy đủ thông tin cá nhân!</h1>");
                    }
                    ));
                    __builder3.AddAttribute(19, "FooterTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(20, "button");
                        __builder4.AddAttribute(21, "id", "button");
                        __builder4.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 115 "D:\DATN-SaC\Client\Shared\WebLayout.razor"
                                                        () => Confirm(context.User.Claims.Where(_ => _.Type == "email").Select(_ => _.Value).FirstOrDefault())

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(23, "class", "e-control e-btn");
                        __builder4.AddAttribute(24, "data-ripple", "true");
                        __builder4.AddContent(25, "OK");
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\r\n                ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Popups.DialogAnimationSettings>(27);
                    __builder3.AddAttribute(28, "Effect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Popups.DialogEffect>(
#nullable restore
#line 118 "D:\DATN-SaC\Client\Shared\WebLayout.razor"
                                                 DialogEffect.FlipXDown

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 118 "D:\DATN-SaC\Client\Shared\WebLayout.razor"
                                                                                  600

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 120 "D:\DATN-SaC\Client\Shared\WebLayout.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\r\n\r\n");
            __builder.OpenElement(31, "header");
            __builder.AddAttribute(32, "id", "header");
            __builder.AddAttribute(33, "class", "fixed-top d-flex align-items-center");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "container d-flex align-items-center");
            __builder.AddMarkupContent(36, "<div class=\"logo me-auto\"><h1><a href=\"/\">SaC Backpack</a></h1></div>\r\n\r\n        ");
            __builder.OpenElement(37, "nav");
            __builder.AddAttribute(38, "id", "navbar");
            __builder.AddAttribute(39, "class", "navbar order-last order-lg-0");
            __builder.OpenElement(40, "ul");
            __builder.AddMarkupContent(41, "<li><a href=\"/\" class=\"nav-link scrollto\" style=\"cursor:pointer\" onclick=\"document.getElementById(\'hero\').scrollIntoView({behavior:\'smooth\'})\">Trang chủ</a></li>\r\n\r\n                ");
            __builder.AddMarkupContent(42, "<li><a href=\"/products\" class=\"nav-link scrollto\" style=\"cursor:pointer\">Sản phẩm</a></li>\r\n                ");
            __builder.OpenElement(43, "li");
            __builder.OpenElement(44, "a");
            __builder.AddAttribute(45, "class", "nav-link scrollto");
            __builder.AddAttribute(46, "style", "cursor:pointer");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 139 "D:\DATN-SaC\Client\Shared\WebLayout.razor"
                                                                                    () => modal.Show<CartLayout>("Thông tin giỏ hàng")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(48, "Giỏ hàng");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(50);
            __builder.AddAttribute(51, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(52, "li");
                __builder2.AddAttribute(53, "class", "dropdown");
                __builder2.OpenElement(54, "a");
                __builder2.AddAttribute(55, "style", "cursor:pointer");
                __builder2.OpenElement(56, "span");
                __builder2.AddContent(57, 
#nullable restore
#line 144 "D:\DATN-SaC\Client\Shared\WebLayout.razor"
                                                             context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, " <i class=\"bi bi-chevron-down\"></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                            ");
                __builder2.OpenElement(60, "ul");
                __builder2.OpenElement(61, "li");
                __builder2.OpenElement(62, "a");
                __builder2.AddAttribute(63, "class", "nav-link scrollto");
                __builder2.AddAttribute(64, "href", "/info/" + (
#nullable restore
#line 146 "D:\DATN-SaC\Client\Shared\WebLayout.razor"
                                                                              context.User.Claims.Where(_ => _.Type == "email").Select(_ => _.Value).FirstOrDefault()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(65, "Thông tin cá nhân");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n                                ");
                __builder2.AddMarkupContent(67, "<li><a class=\"nav-link scrollto\" href=\"/history\">Lịch sử đặt hàng</a></li>\r\n                                ");
                __builder2.OpenElement(68, "li");
                __builder2.OpenElement(69, "a");
                __builder2.AddAttribute(70, "class", "nav-link scrollto");
                __builder2.AddAttribute(71, "style", "cursor:pointer");
                __builder2.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 148 "D:\DATN-SaC\Client\Shared\WebLayout.razor"
                                                                                                  BeginSignOut

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(73, "Đăng xuất");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(74, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 153 "D:\DATN-SaC\Client\Shared\WebLayout.razor"
                         if (emailAddress != null && emailAddress != "")
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(75, "li");
                __builder2.AddAttribute(76, "class", "dropdown");
                __builder2.OpenElement(77, "a");
                __builder2.AddAttribute(78, "style", "cursor:pointer");
                __builder2.OpenElement(79, "span");
                __builder2.AddContent(80, 
#nullable restore
#line 156 "D:\DATN-SaC\Client\Shared\WebLayout.razor"
                                                                 cusName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, " <i class=\"bi bi-chevron-down\"></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n                                ");
                __builder2.OpenElement(83, "ul");
                __builder2.OpenElement(84, "li");
                __builder2.OpenElement(85, "a");
                __builder2.AddAttribute(86, "class", "nav-link scrollto");
                __builder2.AddAttribute(87, "href", "/info/" + (
#nullable restore
#line 158 "D:\DATN-SaC\Client\Shared\WebLayout.razor"
                                                                                  customerId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(88, "Thông tin cá nhân");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n                                    ");
                __builder2.AddMarkupContent(90, "<li><a class=\"nav-link scrollto\" href=\"/history\">Lịch sử đặt hàng</a></li>\r\n                                    ");
                __builder2.AddMarkupContent(91, "<li><a class=\"nav-link scrollto\" href=\"/changepass\">Đổi mật khẩu</a></li>\r\n                                    ");
                __builder2.AddMarkupContent(92, "<li><a class=\"nav-link scrollto\" href=\"/logout\">Đăng xuất</a></li>");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 164 "D:\DATN-SaC\Client\Shared\WebLayout.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(93, @"<li class=""dropdown""><a style=""cursor:pointer""><span>Tài khoản</span> <i class=""bi bi-chevron-down""></i></a>
                                <ul><li><a class=""nav-link"" href=""/login"">Đăng nhập</a></li>
                                    <li><a class=""nav-link"" href=""/register"">Đăng ký</a></li></ul></li>");
#nullable restore
#line 174 "D:\DATN-SaC\Client\Shared\WebLayout.razor"
                        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n            ");
            __builder.OpenElement(95, "i");
            __builder.AddAttribute(96, "class", "bi bi-list mobile-nav-toggle");
            __builder.AddAttribute(97, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 179 "D:\DATN-SaC\Client\Shared\WebLayout.razor"
                                                                async () => await ChangeMenu()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n\r\n");
            __builder.OpenElement(99, "main");
            __builder.AddAttribute(100, "id", "main");
            __builder.AddContent(101, 
#nullable restore
#line 186 "D:\DATN-SaC\Client\Shared\WebLayout.razor"
     Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n");
            __builder.OpenComponent<Blazored.Modal.CascadingBlazoredModal>(103);
            __builder.AddAttribute(104, "HideHeader", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 188 "D:\DATN-SaC\Client\Shared\WebLayout.razor"
                                    true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(105, "\r\n");
            __builder.OpenComponent<Blazored.Toast.BlazoredToasts>(106);
            __builder.AddAttribute(107, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazored.Toast.Configuration.ToastPosition>(
#nullable restore
#line 189 "D:\DATN-SaC\Client\Shared\WebLayout.razor"
                          Blazored.Toast.Configuration.ToastPosition.TopRight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(108, "Timeout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 189 "D:\DATN-SaC\Client\Shared\WebLayout.razor"
                                                                                        2

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(109, "\r\n\r\n");
            __builder.AddMarkupContent(110, @"<footer id=""footer""><div class=""footer-top""><div class=""container""><div class=""row""><div class=""col-lg-3 col-md-6""><div class=""footer-info""><h3>SaC Backpack</h3>
                        <p>
                            CVPM Quang Trung <br>
                            Quận 12, TP. HCM<br><br></p></div></div>

                <div class=""col-lg-3 col-md-6 footer-links""><h4>LỐI TẮT</h4>
                    <ul><li><i class=""bx bx-chevron-right""></i> <a href=""/"">Trang chủ</a></li>
                        <li><i class=""bx bx-chevron-right""></i> <a href=""/login"">Đăng nhập</a></li></ul></div>
                <div class=""col-lg-3 col-md-6 footer-links""><h4>DỊCH VỤ CỦA CHÚNG TÔI</h4>
                    <ul><li><i class=""bx bx-chevron-right""></i> <a href=""/products"">Sản phẩm</a></li></ul></div>
                <div class=""col-lg-3 col-md-6 footer-newsletter""><h4>LIÊN HỆ</h4>
                    <strong>SĐT:</strong> 033 278 0105<br>
                    <strong>Email:</strong> web.sacbackpack@gmail.com<br></div></div></div></div>

    <div class=""container""><div class=""credits"">

            Designed by <b>4Dev</b></div></div></footer>");
        }
        #pragma warning restore 1998
#nullable restore
#line 238 "D:\DATN-SaC\Client\Shared\WebLayout.razor"
      
    string emailAddress;
    string cusName;
    int customerId;
    public Customer cus;
    private bool IsVisible { get; set; }

    protected async Task ChangeMenu()
    {
        await JSRuntime.InvokeVoidAsync("changeMenu");
    }
    protected override async Task OnInitializedAsync()
    {
        IsVisible = true;
        await JSRuntime.InvokeVoidAsync("mainJS");
        emailAddress = sessionStorage.GetItem<string>("Email");
        customerId = sessionStorage.GetItem<int>("customerId");
        if (customerId != 0)
        {
            var apiUrl = config.GetSection("API")["APIUrl"].ToString();
            var accessToken = sessionStorage.GetItem<string>("AccessToken");
            cus = new Customer();
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
                client.BaseAddress = new Uri(apiUrl);
                using (var response = await client.GetAsync("Customer/?id=" + customerId))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    cus = JsonConvert.DeserializeObject<Customer>(apiResponse);
                }
                cusName = cus.FullName;
            }
        }

    }

    private void Confirm(string link)
    {
        navigationManager.NavigateTo("/info/" + link);
        IsVisible = false;
    }

    private async Task BeginSignOut(MouseEventArgs args)
    {
        await SignOutManager.SetSignOutState();
        navigationManager.NavigateTo($"authentication/logout");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService modal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignOutSessionStateManager SignOutManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591