#pragma checksum "D:\DATN-SaC\Client\Pages\Detail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60f4a048d929851aa2263cde2c704fb700cbe888"
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
#line 2 "D:\DATN-SaC\Client\Pages\Detail.razor"
using Share.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DATN-SaC\Client\Pages\Detail.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DATN-SaC\Client\Pages\Detail.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DATN-SaC\Client\Pages\Detail.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DATN-SaC\Client\Pages\Detail.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(WebLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/detail/{id}")]
    public partial class Detail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "id", "breadcrumbs");
            __builder.AddAttribute(2, "class", "breadcrumbs");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.AddMarkupContent(5, "<ol><li><a href=\"/\">Home</a></li>\r\n            <li>Chi tiết sản phẩm</li></ol>\r\n        ");
            __builder.OpenElement(6, "h2");
            __builder.AddContent(7, 
#nullable restore
#line 21 "D:\DATN-SaC\Client\Pages\Detail.razor"
             product.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenElement(9, "section");
            __builder.AddAttribute(10, "id", "portfolio-details");
            __builder.AddAttribute(11, "class", "portfolio-details");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "container");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "row gy-4");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col-lg-6 text-center");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "portfolio-details-slider swiper");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "swiper-wrapper align-items-center");
#nullable restore
#line 34 "D:\DATN-SaC\Client\Pages\Detail.razor"
                          
                            temp = imgUrl + product.Image;
                        

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "swiper-slide");
            __builder.OpenElement(24, "img");
            __builder.AddAttribute(25, "src", 
#nullable restore
#line 38 "D:\DATN-SaC\Client\Pages\Detail.razor"
                                       temp

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(26, "class", "img-thumbnail w-75");
            __builder.AddAttribute(27, "alt");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    <div class=\"swiper-pagination\"></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "col-lg-6");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "portfolio-info");
            __builder.AddMarkupContent(34, "<h3>Thông tin sản phẩm</h3>\r\n                    ");
            __builder.OpenElement(35, "ul");
            __builder.OpenElement(36, "li");
            __builder.AddMarkupContent(37, "<strong>Loại sản phẩm</strong>:\r\n");
#nullable restore
#line 53 "D:\DATN-SaC\Client\Pages\Detail.razor"
                             if (product.Category == Category.Backpack)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(38, "<span>Ba lô</span>");
#nullable restore
#line 56 "D:\DATN-SaC\Client\Pages\Detail.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(39, "<span>Phụ kiện</span>");
#nullable restore
#line 60 "D:\DATN-SaC\Client\Pages\Detail.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                        ");
            __builder.OpenElement(41, "li");
            __builder.AddMarkupContent(42, "<strong>Giá sản phẩm</strong>: ");
            __builder.AddContent(43, 
#nullable restore
#line 62 "D:\DATN-SaC\Client\Pages\Detail.razor"
                                                            string.Format("{0:#,0}", product.Price)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(44, " VNĐ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.OpenElement(46, "li");
            __builder.AddMarkupContent(47, "<strong>Tình trạng</strong>:\r\n");
#nullable restore
#line 65 "D:\DATN-SaC\Client\Pages\Detail.razor"
                             if (product.Status)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(48, "<span>Còn hàng</span> <br>\r\n                                ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "class", "btn btn-dark text-right mt-3");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "D:\DATN-SaC\Client\Pages\Detail.razor"
                                                                                       () => AddCart(product.ProductId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(52, "THÊM VÀO GIỎ HÀNG ");
            __builder.CloseElement();
#nullable restore
#line 69 "D:\DATN-SaC\Client\Pages\Detail.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(53, "<span>Hết hàng</span>");
#nullable restore
#line 73 "D:\DATN-SaC\Client\Pages\Detail.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "portfolio-description");
            __builder.AddMarkupContent(57, "<h2>Mô tả sản phẩm</h2>\r\n                    ");
            __builder.AddContent(58, 
#nullable restore
#line 79 "D:\DATN-SaC\Client\Pages\Detail.razor"
                      (MarkupString)product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 89 "D:\DATN-SaC\Client\Pages\Detail.razor"
       
    [Parameter]
    public string id { get; set; }

    protected string imgUrl = "";
    protected string temp = "";
    public Product product;
    private ToastParameters _toastParameters;

    protected override async Task OnInitializedAsync()
    {
        if (string.IsNullOrWhiteSpace(id) || id == "0")
        {
            NavigationManager.NavigateTo("/", true);
        }
        else
        {
            var apiUrl = config.GetSection("API")["APIUrl"].ToString();
            imgUrl = config.GetSection("API")["ImgUrl"].ToString();

            product = new Product();
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
                client.BaseAddress = new Uri(apiUrl);
                using (var response = await client.GetAsync($"Product/{id}"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    product = JsonConvert.DeserializeObject<Product>(apiResponse);
                }
            }
        }
    }

    private void AddCart(int id)
    {
        _toastParameters = new ToastParameters();
        //var cart = HttpContext.Session.GetString("cart");//get key cart
        var cart = sessionStorage.GetItem<string>("cart");//get key cart
        if (cart == null)
        {
            List<CartItem> listCart = new List<CartItem>()
{
                    new CartItem
                    {
                        product = product,
                        Quantity = 1,
                        Price = product.Price
                    }
            };

            Cart orderCart = new Cart()
            {
                ListViewCart = listCart,
                Total = Calculate(listCart)
            };

            sessionStorage.SetItem("cart", JsonConvert.SerializeObject(orderCart));
            _toastParameters.Add(nameof(Notification.Title), "Thêm sản phẩm thành công!");
            _toastParameters.Add(nameof(Notification.IsSuccess), true);
            toastService.ShowToast<Notification>(_toastParameters);
            //HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(listCart));
        }
        else
        {

            Cart orderCart = JsonConvert.DeserializeObject<Cart>(cart);
            bool check = true;
            for (int i = 0; i < orderCart.ListViewCart.Count; i++)
            {
                if (orderCart.ListViewCart[i].product.ProductId == id)
                {
                    orderCart.ListViewCart[i].Quantity++;
                    orderCart.ListViewCart[i].Price = product.Price * orderCart.ListViewCart[i].Quantity;
                    check = false;
                }
            }

            if (check)
            {
                orderCart.ListViewCart.Add(new CartItem
                {
                    product = product,
                    Quantity = 1,
                    Price = product.Price * 1
                });
            }
            orderCart.Total = Calculate(orderCart.ListViewCart);
            sessionStorage.SetItem("cart", JsonConvert.SerializeObject(orderCart));
            _toastParameters.Add(nameof(Notification.Title), "Thêm sản phẩm thành công!");
            _toastParameters.Add(nameof(Notification.IsSuccess), true);
            toastService.ShowToast<Notification>(_toastParameters);

            //HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
        }
    }

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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
