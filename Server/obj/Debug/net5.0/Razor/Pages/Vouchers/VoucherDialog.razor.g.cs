#pragma checksum "D:\DATN-SaC\Server\Pages\Vouchers\VoucherDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9788e4c37aa3ac2c075935242b28bfaf54b833f1"
// <auto-generated/>
#pragma warning disable 1591
namespace Server.Pages.Vouchers
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
#line 2 "D:\DATN-SaC\Server\Pages\Vouchers\VoucherDialog.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DATN-SaC\Server\Pages\Vouchers\VoucherDialog.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DATN-SaC\Server\Pages\Vouchers\VoucherDialog.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/voucherdialog/{id}")]
    public partial class VoucherDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-xl-6 mx-auto");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card card-signin flex-row shadow-lg card-signup");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-body");
            __builder.OpenElement(10, "h2");
            __builder.AddAttribute(11, "class", "card-title text-center font-weight-bold text-uppercase");
            __builder.AddContent(12, 
#nullable restore
#line 14 "D:\DATN-SaC\Server\Pages\Vouchers\VoucherDialog.razor"
                                                                                        Tilte

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-md-12");
            __builder.OpenElement(16, "form");
            __builder.AddAttribute(17, "asp-action", "Create");
            __builder.AddAttribute(18, "class", "form-signin");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(19);
            __builder.AddAttribute(20, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 17 "D:\DATN-SaC\Server\Pages\Vouchers\VoucherDialog.razor"
                                              voucher

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 17 "D:\DATN-SaC\Server\Pages\Vouchers\VoucherDialog.razor"
                                                                       SubmitForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(23);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n                                ");
                __builder2.OpenElement(25, "input");
                __builder2.AddAttribute(26, "type", "hidden");
                __builder2.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "D:\DATN-SaC\Server\Pages\Vouchers\VoucherDialog.razor"
                                                            voucher.VoucherId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => voucher.VoucherId = __value, voucher.VoucherId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                                ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-label-group");
                __builder2.AddMarkupContent(32, "<label class=\"control-label\">Mã giảm</label>\r\n                                    ");
                __builder2.OpenElement(33, "input");
                __builder2.AddAttribute(34, "class", "form-control");
                __builder2.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "D:\DATN-SaC\Server\Pages\Vouchers\VoucherDialog.razor"
                                                  voucher.VoucherCode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => voucher.VoucherCode = __value, voucher.VoucherCode));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                                    ");
                __Blazor.Server.Pages.Vouchers.VoucherDialog.TypeInference.CreateValidationMessage_0(__builder2, 38, 39, 
#nullable restore
#line 23 "D:\DATN-SaC\Server\Pages\Vouchers\VoucherDialog.razor"
                                                              () => voucher.VoucherCode

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n\r\n                                ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-label-group mt-3");
                __builder2.AddMarkupContent(43, "<label class=\"control-label\">Ngày hiệu lực</label>\r\n                                    ");
                __builder2.OpenElement(44, "input");
                __builder2.AddAttribute(45, "type", "date");
                __builder2.AddAttribute(46, "class", "form-control");
                __builder2.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "D:\DATN-SaC\Server\Pages\Vouchers\VoucherDialog.razor"
                                                              voucher.StartDate

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => voucher.StartDate = __value, voucher.StartDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n                                    ");
                __Blazor.Server.Pages.Vouchers.VoucherDialog.TypeInference.CreateValidationMessage_1(__builder2, 50, 51, 
#nullable restore
#line 29 "D:\DATN-SaC\Server\Pages\Vouchers\VoucherDialog.razor"
                                                              () => voucher.StartDate

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n                                ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-label-group mt-3");
                __builder2.AddMarkupContent(55, "<label class=\"control-label\">Ngày kết thúc</label>\r\n                                    ");
                __builder2.OpenElement(56, "input");
                __builder2.AddAttribute(57, "type", "date");
                __builder2.AddAttribute(58, "class", "form-control");
                __builder2.AddAttribute(59, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "D:\DATN-SaC\Server\Pages\Vouchers\VoucherDialog.razor"
                                                              voucher.EndDate

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => voucher.EndDate = __value, voucher.EndDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n                                    ");
                __Blazor.Server.Pages.Vouchers.VoucherDialog.TypeInference.CreateValidationMessage_2(__builder2, 62, 63, 
#nullable restore
#line 34 "D:\DATN-SaC\Server\Pages\Vouchers\VoucherDialog.razor"
                                                              () => voucher.EndDate

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 37 "D:\DATN-SaC\Server\Pages\Vouchers\VoucherDialog.razor"
                                 if (id != "0")
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "form-label-group mt-3 form-check");
                __builder2.OpenElement(66, "label");
                __builder2.AddAttribute(67, "class", "form-check-label");
                __builder2.OpenElement(68, "input");
                __builder2.AddAttribute(69, "type", "checkbox");
                __builder2.AddAttribute(70, "class", "form-check-input");
                __builder2.AddAttribute(71, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "D:\DATN-SaC\Server\Pages\Vouchers\VoucherDialog.razor"
                                                                                                   voucher.Status

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(72, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => voucher.Status = __value, voucher.Status));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, " Còn hiệu lực\r\n                                        ");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 44 "D:\DATN-SaC\Server\Pages\Vouchers\VoucherDialog.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "form-label-group mt-3");
                __builder2.AddMarkupContent(76, "<label class=\"control-label\">Loại giảm giá</label>\r\n                                    ");
                __Blazor.Server.Pages.Vouchers.VoucherDialog.TypeInference.CreateInputSelect_3(__builder2, 77, 78, "form-control", 79, 
#nullable restore
#line 49 "D:\DATN-SaC\Server\Pages\Vouchers\VoucherDialog.razor"
                                                               voucher.CategoryDiscount

#line default
#line hidden
#nullable disable
                , 80, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => voucher.CategoryDiscount = __value, voucher.CategoryDiscount)), 81, () => voucher.CategoryDiscount, 82, (__builder3) => {
                    __builder3.OpenElement(83, "option");
                    __builder3.AddAttribute(84, "value", 
#nullable restore
#line 50 "D:\DATN-SaC\Server\Pages\Vouchers\VoucherDialog.razor"
                                                        CategoryDiscount.Cash

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(85, "Tiền mặt");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(86, "\r\n                                        ");
                    __builder3.OpenElement(87, "option");
                    __builder3.AddAttribute(88, "value", 
#nullable restore
#line 51 "D:\DATN-SaC\Server\Pages\Vouchers\VoucherDialog.razor"
                                                        CategoryDiscount.Percent

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(89, "Phần trăm");
                    __builder3.CloseElement();
                }
                );
                __builder2.AddMarkupContent(90, "\r\n                                    ");
                __Blazor.Server.Pages.Vouchers.VoucherDialog.TypeInference.CreateValidationMessage_4(__builder2, 91, 92, 
#nullable restore
#line 53 "D:\DATN-SaC\Server\Pages\Vouchers\VoucherDialog.razor"
                                                              () => voucher.CategoryDiscount

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 56 "D:\DATN-SaC\Server\Pages\Vouchers\VoucherDialog.razor"
                                 if (voucher.CategoryDiscount == CategoryDiscount.Percent)
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "form-label-group mt-3");
                __builder2.AddMarkupContent(95, "<label class=\"control-label\">Giá trị</label>\r\n                                        ");
                __builder2.OpenElement(96, "input");
                __builder2.AddAttribute(97, "type", "number");
                __builder2.AddAttribute(98, "min", "0");
                __builder2.AddAttribute(99, "max", "100");
                __builder2.AddAttribute(100, "class", "form-control");
                __builder2.AddAttribute(101, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 60 "D:\DATN-SaC\Server\Pages\Vouchers\VoucherDialog.razor"
                                                                                      voucher.Value

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(102, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => voucher.Value = __value, voucher.Value, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n                                        ");
                __Blazor.Server.Pages.Vouchers.VoucherDialog.TypeInference.CreateValidationMessage_5(__builder2, 104, 105, 
#nullable restore
#line 61 "D:\DATN-SaC\Server\Pages\Vouchers\VoucherDialog.razor"
                                                                  () => voucher.Value

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 63 "D:\DATN-SaC\Server\Pages\Vouchers\VoucherDialog.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(106, "div");
                __builder2.AddAttribute(107, "class", "form-label-group mt-3");
                __builder2.AddMarkupContent(108, "<label class=\"control-label\">Giá trị</label>\r\n                                        ");
                __builder2.OpenElement(109, "input");
                __builder2.AddAttribute(110, "type", "number");
                __builder2.AddAttribute(111, "min", "1000");
                __builder2.AddAttribute(112, "class", "form-control");
                __builder2.AddAttribute(113, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 68 "D:\DATN-SaC\Server\Pages\Vouchers\VoucherDialog.razor"
                                                                               voucher.Value

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(114, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => voucher.Value = __value, voucher.Value, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n                                        ");
                __Blazor.Server.Pages.Vouchers.VoucherDialog.TypeInference.CreateValidationMessage_6(__builder2, 116, 117, 
#nullable restore
#line 69 "D:\DATN-SaC\Server\Pages\Vouchers\VoucherDialog.razor"
                                                                  () => voucher.Value

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 71 "D:\DATN-SaC\Server\Pages\Vouchers\VoucherDialog.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(118, "div");
                __builder2.AddAttribute(119, "class", "form-label-group mt-3");
                __builder2.AddMarkupContent(120, "<label class=\"control-label\">Số lượng mã</label>\r\n                                    ");
                __builder2.OpenElement(121, "input");
                __builder2.AddAttribute(122, "type", "number");
                __builder2.AddAttribute(123, "min", "0");
                __builder2.AddAttribute(124, "max", "10000");
                __builder2.AddAttribute(125, "class", "form-control");
                __builder2.AddAttribute(126, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 75 "D:\DATN-SaC\Server\Pages\Vouchers\VoucherDialog.razor"
                                                                                    voucher.VoucherQuantity

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(127, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => voucher.VoucherQuantity = __value, voucher.VoucherQuantity, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(128, "\r\n                                    ");
                __Blazor.Server.Pages.Vouchers.VoucherDialog.TypeInference.CreateValidationMessage_7(__builder2, 129, 130, 
#nullable restore
#line 76 "D:\DATN-SaC\Server\Pages\Vouchers\VoucherDialog.razor"
                                                              () => voucher.VoucherQuantity

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(131, "\r\n                                ");
                __builder2.OpenElement(132, "div");
                __builder2.AddAttribute(133, "class", "form-label-group mt-3");
                __builder2.AddMarkupContent(134, "<button type=\"submit\" class=\"btn btn-info\">Lưu</button>\r\n                                    ");
                __builder2.OpenElement(135, "input");
                __builder2.AddAttribute(136, "type", "button");
                __builder2.AddAttribute(137, "class", "btn btn-primary");
                __builder2.AddAttribute(138, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "D:\DATN-SaC\Server\Pages\Vouchers\VoucherDialog.razor"
                                                                                            Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(139, "value", "Thoát");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 91 "D:\DATN-SaC\Server\Pages\Vouchers\VoucherDialog.razor"
       
    [Parameter]
    public string id { get; set; }
    private Share.Models.Voucher voucher { get; set; }
    private ToastParameters _toastParameters;
    private string Tilte = "";
    protected override void OnInitialized()
    {
        if (string.IsNullOrWhiteSpace(id) || id == "0")
        {
            Tilte = "Thêm mã giảm giá";
            voucher = new Share.Models.Voucher();
            voucher.StartDate = DateTime.Today;
            voucher.EndDate = DateTime.Today.AddDays(1);
        }
        else
        {
            Tilte = "Sửa mã giảm giá";
            voucher = _voucherService.GetVoucher(int.Parse(id));
        }
    }
    private void SubmitForm()
    {
        _toastParameters = new ToastParameters();
        if (voucher.VoucherId == 0)
        {
            int ret = _voucherService.AddVoucher(voucher);
            if (ret != 0)
            {
                _toastParameters.Add(nameof(Notification.Title), "Thêm mã giảm giá thành công!");
                _toastParameters.Add(nameof(Notification.IsSuccess), true);
                toastService.ShowToast<Notification>(_toastParameters);
            }
            else
            {
                _toastParameters.Add(nameof(Notification.Title), "Thêm mã giảm giá thất bại!");
                _toastParameters.Add(nameof(Notification.IsSuccess), false);
                toastService.ShowToast<Notification>(_toastParameters);
            }
        }
        else
        {
            int ret = _voucherService.EditVoucher(voucher.VoucherId, voucher);
            if (ret == voucher.VoucherId)
            {
                _toastParameters.Add(nameof(Notification.Title), "Chỉnh sửa mã giảm giá thành công!");
                _toastParameters.Add(nameof(Notification.IsSuccess), true);
                toastService.ShowToast<Notification>(_toastParameters);
            }
            else
            {
                _toastParameters.Add(nameof(Notification.Title), "Chỉnh sửa mã giảm giá thất bại!");
                _toastParameters.Add(nameof(Notification.IsSuccess), false);
                toastService.ShowToast<Notification>(_toastParameters);
            }
        }
        navigation.NavigateTo("VoucherList");
    }
    private void Cancel()
    {
        navigation.NavigateTo("VoucherList", true);

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Share.Interfaces.IVoucherSvc _voucherService { get; set; }
    }
}
namespace __Blazor.Server.Pages.Vouchers.VoucherDialog
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
