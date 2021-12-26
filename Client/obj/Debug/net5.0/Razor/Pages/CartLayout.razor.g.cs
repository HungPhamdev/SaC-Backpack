#pragma checksum "D:\DATN-SaC\Client\Pages\CartLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "890fa2c39f94d2ed27dbff42f31602d1cd1c4dc4"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Pages
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
#line 17 "D:\DATN-SaC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

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
#line 2 "D:\DATN-SaC\Client\Pages\CartLayout.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DATN-SaC\Client\Pages\CartLayout.razor"
using Share.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DATN-SaC\Client\Pages\CartLayout.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DATN-SaC\Client\Pages\CartLayout.razor"
using Share.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DATN-SaC\Client\Pages\CartLayout.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cart")]
    public partial class CartLayout : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .my-custom-scrollbar {\r\n        position: relative;\r\n        height: 400px;\r\n        overflow: auto;\r\n    }\r\n\r\n    .table-wrapper-scroll-y {\r\n        display: block;\r\n    }\r\n\r\n    .payment-info {\r\n        background: blue;\r\n        padding: 10px;\r\n        border-radius: 6px;\r\n        color: #fff;\r\n        font-weight: bold\r\n    }\r\n\r\n    .product-details {\r\n        padding: 10px\r\n    }\r\n\r\n    body {\r\n        background: #eee\r\n    }\r\n\r\n    .cart {\r\n        background: #fff\r\n    }\r\n\r\n    .p-about {\r\n        font-size: 12px\r\n    }\r\n\r\n    .table-shadow {\r\n        -webkit-box-shadow: 5px 5px 15px -2px rgba(0, 0, 0, 0.42);\r\n        box-shadow: 5px 5px 15px -2px rgba(0, 0, 0, 0.42)\r\n    }\r\n\r\n    .type {\r\n        font-weight: 400;\r\n        font-size: 10px\r\n    }\r\n\r\n    label.radio {\r\n        cursor: pointer\r\n    }\r\n\r\n        label.radio input {\r\n            position: absolute;\r\n            top: 0;\r\n            left: 0;\r\n            visibility: hidden;\r\n            pointer-events: none\r\n        }\r\n\r\n        label.radio span {\r\n            padding: 1px 12px;\r\n            border: 2px solid #ada9a9;\r\n            display: inline-block;\r\n            color: #8f37aa;\r\n            border-radius: 3px;\r\n            text-transform: uppercase;\r\n            font-size: 11px;\r\n            font-weight: 300\r\n        }\r\n\r\n        label.radio input:checked + span {\r\n            border-color: #fff;\r\n            background-color: blue;\r\n            color: #fff\r\n        }\r\n\r\n    .credit-inputs {\r\n        background: rgb(102, 102, 221);\r\n        color: #fff !important;\r\n        border-color: rgb(102, 102, 221)\r\n    }\r\n\r\n        .credit-inputs::placeholder {\r\n            color: #fff;\r\n            font-size: 13px\r\n        }\r\n\r\n    .credit-card-label {\r\n        font-size: 9px;\r\n        font-weight: 300\r\n    }\r\n\r\n    .form-control.credit-inputs:focus {\r\n        background: rgb(102, 102, 221);\r\n        border: rgb(102, 102, 221)\r\n    }\r\n\r\n    .line {\r\n        border-bottom: 1px solid rgb(102, 102, 221)\r\n    }\r\n\r\n    .information span {\r\n        font-size: 12px;\r\n        font-weight: 500\r\n    }\r\n\r\n    .information {\r\n        margin-bottom: 5px\r\n    }\r\n\r\n    .items {\r\n        -webkit-box-shadow: 5px 5px 4px -1px rgba(0, 0, 0, 0.25);\r\n        box-shadow: 5px 5px 4px -1px rgba(0, 0, 0, 0.08)\r\n    }\r\n\r\n    .spec {\r\n        font-size: 11px\r\n    }\r\n\r\n    .button:focus {\r\n        outline: none;\r\n    }\r\n</style>\r\n");
            __builder.OpenComponent<BlazorAnimate.Animate>(1);
            __builder.AddAttribute(2, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 134 "D:\DATN-SaC\Client\Pages\CartLayout.razor"
                    Animations.FadeUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 134 "D:\DATN-SaC\Client\Pages\CartLayout.razor"
                                                 TimeSpan.FromSeconds(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "container p-3 rounded cart");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row no-gutters");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-md-12");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "product-details mr-2");
                __builder2.AddMarkupContent(13, "<div class=\"d-flex justify-content-between\"><a href=\"/\" class=\"d-flex flex-row align-items-center\"><i class=\"fa fa-long-arrow-left\"></i><span class=\"ml-2\">Tiếp tục mua sắm</span></a></div>\r\n                    <hr>\r\n                    ");
                __builder2.AddMarkupContent(14, "<h6 class=\"mb-0\">Giỏ hàng</h6>\r\n                    ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "table-wrapper-scroll-y my-custom-scrollbar");
                __builder2.OpenElement(17, "table");
                __builder2.AddAttribute(18, "class", "table table-responsive mb-0");
                __builder2.OpenElement(19, "tbody");
#nullable restore
#line 148 "D:\DATN-SaC\Client\Pages\CartLayout.razor"
                                 foreach (var item in orderCart.ListViewCart)
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(20, "tr");
                __builder2.AddAttribute(21, "class");
                __builder2.OpenElement(22, "th");
                __builder2.AddAttribute(23, "scope", "row");
                __builder2.AddAttribute(24, "width", "300px");
                __builder2.OpenElement(25, "img");
                __builder2.AddAttribute(26, "class", "rounded");
                __builder2.AddAttribute(27, "src", 
#nullable restore
#line 152 "D:\DATN-SaC\Client\Pages\CartLayout.razor"
                                                                        imgUrl + item.product.Image

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(28, "width", "40");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                                            ");
                __builder2.OpenElement(30, "span");
                __builder2.AddAttribute(31, "class", "ml-2");
                __builder2.OpenElement(32, "span");
                __builder2.AddAttribute(33, "class", "font-weight-bold");
                __builder2.AddContent(34, 
#nullable restore
#line 153 "D:\DATN-SaC\Client\Pages\CartLayout.razor"
                                                                                               item.product.ProductName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n                                            ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "ml-2");
                __builder2.OpenElement(38, "span");
                __builder2.AddAttribute(39, "class", "spec badge bg-dark");
                __builder2.AddContent(40, 
#nullable restore
#line 154 "D:\DATN-SaC\Client\Pages\CartLayout.razor"
                                                                                                item.product.Category.DisplayName()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                                        ");
                __builder2.OpenElement(42, "th");
                __builder2.AddAttribute(43, "class", "text-center");
                __builder2.OpenElement(44, "span");
                __builder2.OpenElement(45, "i");
                __builder2.AddAttribute(46, "class", "fa fa-minus");
                __builder2.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 158 "D:\DATN-SaC\Client\Pages\CartLayout.razor"
                                                                                   () => MinusQuantityAndUpdateCart(item)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(48, "   ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n                                            ");
                __builder2.OpenElement(50, "span");
                __builder2.AddAttribute(51, "class");
                __builder2.AddContent(52, 
#nullable restore
#line 159 "D:\DATN-SaC\Client\Pages\CartLayout.razor"
                                                            item.Quantity

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(53, "   ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                                            ");
                __builder2.OpenElement(55, "span");
                __builder2.OpenElement(56, "i");
                __builder2.AddAttribute(57, "class", "fa fa-plus");
                __builder2.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 160 "D:\DATN-SaC\Client\Pages\CartLayout.razor"
                                                                                  () => PlusQuantityAndUpdateCart(item)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                                        ");
                __builder2.OpenElement(60, "th");
                __builder2.AddAttribute(61, "class", "text-center");
                __builder2.AddAttribute(62, "width", "100px");
                __builder2.OpenElement(63, "span");
                __builder2.AddAttribute(64, "class", "font-weight-bold");
                __builder2.AddContent(65, 
#nullable restore
#line 162 "D:\DATN-SaC\Client\Pages\CartLayout.razor"
                                                                                                              string.Format("{0:#,0}", item.Price)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(66, "đ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n                                        ");
                __builder2.OpenElement(68, "th");
                __builder2.AddAttribute(69, "class", "text-center");
                __builder2.AddAttribute(70, "width", "30px");
                __builder2.OpenElement(71, "i");
                __builder2.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 163 "D:\DATN-SaC\Client\Pages\CartLayout.razor"
                                                                                          () => DeleteCart(item)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(73, "class", "fa fa-trash-o ml-3 text-black-50 ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 165 "D:\DATN-SaC\Client\Pages\CartLayout.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n                            ");
                __builder2.OpenElement(75, "tfoot");
                __builder2.OpenElement(76, "tr");
                __builder2.AddAttribute(77, "class");
                __builder2.AddMarkupContent(78, "<th scope=\"row\" width=\"300px\">Tổng cộng:</th>\r\n                                    <th class=\"text-center\"></th>\r\n                                    ");
                __builder2.OpenElement(79, "th");
                __builder2.AddAttribute(80, "class", "text-center");
                __builder2.AddAttribute(81, "width", "200px");
                __builder2.AddContent(82, 
#nullable restore
#line 172 "D:\DATN-SaC\Client\Pages\CartLayout.razor"
                                                                            string.Format("{0:#,0}", @orderCart.Total)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(83, "đ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n                                    <th class=\"text-center\" width=\"30px\"></th>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n        ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "row");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "col-6");
                __builder2.OpenElement(90, "span");
                __builder2.AddMarkupContent(91, "&nbsp; Bạn đã thêm ");
                __builder2.AddContent(92, 
#nullable restore
#line 184 "D:\DATN-SaC\Client\Pages\CartLayout.razor"
                                          orderCart.ListViewCart.Count

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(93, " sản phẩm vào giỏ hàng");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 186 "D:\DATN-SaC\Client\Pages\CartLayout.razor"
             if (orderCart.ListViewCart.Count != 0)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(94);
                __builder2.AddAttribute(95, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
#nullable restore
#line 190 "D:\DATN-SaC\Client\Pages\CartLayout.razor"
                         if (context.User.Claims.Where(_ => _.Type == "email").Select(_ => _.Value).FirstOrDefault() != null
                        && context.User.Claims.Where(_ => _.Type == "email").Select(_ => _.Value).FirstOrDefault() != "")
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(96, "div");
                    __builder3.AddAttribute(97, "class", "col-6 text-end");
                    __builder3.OpenElement(98, "button");
                    __builder3.AddAttribute(99, "class", "btn btn-primary btn-block");
                    __builder3.AddAttribute(100, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 194 "D:\DATN-SaC\Client\Pages\CartLayout.razor"
                                                                                      () => modal.Show<Checkout>("Thanh Toán")

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(101, "type", "button");
                    __builder3.AddMarkupContent(102, "<span>Tiếp theo<i class=\"fa fa-long-arrow-right ml-1\"></i></span>");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 196 "D:\DATN-SaC\Client\Pages\CartLayout.razor"
                        }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.AddAttribute(103, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
#nullable restore
#line 199 "D:\DATN-SaC\Client\Pages\CartLayout.razor"
                         if (emailAddress != null && emailAddress != "")
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(104, "div");
                    __builder3.AddAttribute(105, "class", "col-6 text-end");
                    __builder3.OpenElement(106, "button");
                    __builder3.AddAttribute(107, "class", "btn btn-primary btn-block");
                    __builder3.AddAttribute(108, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 202 "D:\DATN-SaC\Client\Pages\CartLayout.razor"
                                                                                      () => modal.Show<Checkout>("Thanh Toán")

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(109, "type", "button");
                    __builder3.AddMarkupContent(110, "<span>Tiếp theo<i class=\"fa fa-long-arrow-right ml-1\"></i></span>");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 204 "D:\DATN-SaC\Client\Pages\CartLayout.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(111, "<div class=\"col-6 text-end\"><a href=\"/login\"><button class=\"btn btn-primary btn-block\" type=\"button\"><span>Đăng nhập</span></button></a></div>");
#nullable restore
#line 210 "D:\DATN-SaC\Client\Pages\CartLayout.razor"
                        }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 213 "D:\DATN-SaC\Client\Pages\CartLayout.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 221 "D:\DATN-SaC\Client\Pages\CartLayout.razor"
       
    private string emailAddress;
    public Cart orderCart;
    protected string imgUrl = "";

    protected override void OnInitialized()
    {
        emailAddress = sessionStorage.GetItem<string>("Email");
        var cart = sessionStorage.GetItem<string>("cart");
        if (cart == null)
        {
            orderCart = new Share.Models.ViewModels.Cart();
        }
        else
        {
            orderCart = JsonConvert.DeserializeObject<Cart>(cart);
        }
        imgUrl = config.GetSection("API")["ImgUrl"].ToString();
    }

    private void PlusQuantity(CartItem item)
    {
        item.Quantity++;
    }
    private void MinusQuantity(CartItem item)
    {
        if (item.Quantity > 0)
        {
            item.Quantity--;
        }
    }

    private void PlusQuantityAndUpdateCart(CartItem item)
    {
        PlusQuantity(item);
        UpdateCart(item);
    }

    private void MinusQuantityAndUpdateCart(CartItem item)
    {
        MinusQuantity(item);
        UpdateCart(item);
    }

    private void UpdateCart(CartItem item)
    {
        item.Price = item.Quantity * item.product.Price;
        orderCart.Total = Calculate(orderCart.ListViewCart);
        sessionStorage.SetItem("cart", JsonConvert.SerializeObject(orderCart));
    }

    private void DeleteCart(CartItem item)
    {
        orderCart.ListViewCart.Remove(item);
        orderCart.Total = Calculate(orderCart.ListViewCart);
        sessionStorage.SetItem("cart", JsonConvert.SerializeObject(orderCart));
    }

    //private async Task OrderCart()
    //{
    //    var apiUrl = config.GetSection("API")["APIUrl"].ToString();
    //    imgUrl = config.GetSection("API")["ImgUrl"].ToString();
    //    var accessToken = sessionStorage.GetItem<string>("AccessToken");
    //    var khachhangid = sessionStorage.GetItem<int>("khachhangId");

    //    orderCart.CustomerId = khachhangid;

    //    using (var client = new HttpClient())
    //    {
    //        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
    //        StringContent content = new StringContent(JsonConvert.SerializeObject(orderCart), System.Text.Encoding.UTF8, "application/json");
    //        client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
    //        HttpResponseMessage response = await client.PostAsync(apiUrl + "Cart", content);

    //        if (response.StatusCode == HttpStatusCode.OK)
    //        {

    //        }
    //        else
    //        {
    //            sessionStorage.RemoveItem("cart");
    //            await JSRuntime.InvokeAsync<object>("clearCart", "");
    //            NavigationManager.NavigateTo("/history");
    //        }
    //    }
    //}

    private float Calculate(List<CartItem> listCart)
    {
        float total = 0;
        if (listCart != null)
        {
            for (int i = 0; i < listCart.Count; i++)
            {
                total += listCart[i].Price;
            }
        }
        return total;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService modal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591