#pragma checksum "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Confirm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0169a5049f4118673381643e03acbdb5ce7d6940"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservations_Confirm), @"mvc.1.0.view", @"/Views/Reservations/Confirm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reservations/Confirm.cshtml", typeof(AspNetCore.Views_Reservations_Confirm))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\_ViewImports.cshtml"
using BookingForm;

#line default
#line hidden
#line 2 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\_ViewImports.cshtml"
using BookingForm.Models;

#line default
#line hidden
#line 3 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Confirm.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#line 4 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Confirm.cshtml"
using reCAPTCHA.AspNetCore;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0169a5049f4118673381643e03acbdb5ce7d6940", @"/Views/Reservations/Confirm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a961fb0ce4f853b3e2c4fa2992c1d9302b2824bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservations_Confirm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookingForm.Models.Reservation>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 5 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Confirm.cshtml"
  
  Layout = null;

#line default
#line hidden
            BeginContext(185, 1876, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5585fc29dc1b45d3872f17ab3888e6ea", async() => {
                BeginContext(191, 1580, true);
                WriteLiteral(@"
  <title>Xác nhận đặt mua</title>
  <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
  <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"" integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"" crossorigin=""anonymous""></script>
<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"">
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"" integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"" crossorigin=""anonymous""></script>
  <style>
    h1 {
      margin-top: 65px;
      font-family: sans-serif;
      font-size: 40;
      color: #595f65;
    }

    p {
      font-family: sans-serif;
      font-size: 18;
      color: #828486;
    }

    h3 {
      font-size: 28;
      font-family: sans-serif;
  ");
                WriteLiteral(@"    color: #6f767d;
      margin-top: 35px;
    }

    h4 {
      font-family: sans-serif;
      font-size: 21;
      color: #46494c;
    }

    h1,
    h3,
    h4,
    p {
      margin-left: 11px;
    }

    a {
      color: #595f65;
    }

    #product,
    #order {
      background-color: #f7f7f7;
      margin-left: 11px;
      margin-right: 11px;
      padding: 0 14 0 14;
    }

    #product>p,
    #order>p {
      margin: 18 0 18 0;
    }

    #product>h4,
    #order>h4 {
      margin: 0 0 18 0;
    }

    ");
                EndContext();
                BeginContext(1772, 282, true);
                WriteLiteral(@"@media only screen and (min-width: 1280px) {
      body {
        margin: 0 400 20 400;
      }

      h5 {
        font-family: sans-serif;
        font-size: 15px;
        color: red;
        font-style: italic;
        margin-left: 14px;

      }
    }
  </style>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2061, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2063, 2195, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f20333cf0ab64f93885ef67477dee04f", async() => {
                BeginContext(2069, 215, true);
                WriteLiteral("\r\n<hr />\r\n<hr />\r\n<!-- <h1 style=\"font-family:sans-serif; \">Chúc mừng bạn đã đặt mua thành công!</h1>\r\n<p>Đơn hàng của bạn đã được hệ thông tiếp nhận</p> -->\r\n<h3>Thông tin sản phẩm</h3>\r\n<div id=\"product\">\r\n    <p>");
                EndContext();
                BeginContext(2285, 25, false);
#line 93 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Confirm.cshtml"
  Write(Model.Apartment.LocalCode);

#line default
#line hidden
                EndContext();
                BeginContext(2310, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(2314, 20, false);
#line 93 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Confirm.cshtml"
                               Write(Model.Apartment.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2334, 27, true);
                WriteLiteral("</p>\r\n    <p>Số phòng ngủ: ");
                EndContext();
                BeginContext(2362, 25, false);
#line 94 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Confirm.cshtml"
                Write(Model.Apartment.NOBedroom);

#line default
#line hidden
                EndContext();
                BeginContext(2387, 21, true);
                WriteLiteral(" / Số phòng vệ sinh: ");
                EndContext();
                BeginContext(2409, 20, false);
#line 94 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Confirm.cshtml"
                                                               Write(Model.Apartment.NOWC);

#line default
#line hidden
                EndContext();
                BeginContext(2429, 20, true);
                WriteLiteral("</p>\r\n    <p>Hướng: ");
                EndContext();
                BeginContext(2450, 25, false);
#line 95 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Confirm.cshtml"
         Write(Model.Apartment.Direction);

#line default
#line hidden
                EndContext();
                BeginContext(2475, 9, true);
                WriteLiteral(" / View: ");
                EndContext();
                BeginContext(2485, 20, false);
#line 95 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Confirm.cshtml"
                                            Write(Model.Apartment.View);

#line default
#line hidden
                EndContext();
                BeginContext(2505, 9, true);
                WriteLiteral(" / Tầng: ");
                EndContext();
                BeginContext(2515, 21, false);
#line 95 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Confirm.cshtml"
                                                                          Write(Model.Apartment.Floor);

#line default
#line hidden
                EndContext();
                BeginContext(2536, 14, true);
                WriteLiteral(" / Diện tích: ");
                EndContext();
                BeginContext(2551, 20, false);
#line 95 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Confirm.cshtml"
                                                                                                              Write(Model.Apartment.Area);

#line default
#line hidden
                EndContext();
                BeginContext(2571, 16, true);
                WriteLiteral("</p>\r\n</div>\r\n\r\n");
                EndContext();
                BeginContext(2587, 1628, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27c58adcce4d4cb18ddaf7d44ef170dd", async() => {
                    BeginContext(2637, 67, true);
                    WriteLiteral("\r\n      <div class=\"form-group\" hidden>\r\n        <input type=\"text\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 2704, "\"", 2736, 1);
#line 100 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Confirm.cshtml"
WriteAttributeValue("", 2712, Model.Reserved.Customer, 2712, 24, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(2737, 92, true);
                    WriteLiteral(" name=\"Customer\" id=\"Customer\" class=\"form-control\" placeholder=\"\" aria-describedby=\"helpId\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 2829, "\"", 2850, 1);
#line 100 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Confirm.cshtml"
WriteAttributeValue("", 2837, ViewBag.code, 2837, 13, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(2851, 99, true);
                    WriteLiteral(" required>\r\n      <label for=\"\">\r\n          Mã căn hộ\r\n      </label>\r\n          <input type=\"text\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 2950, "\"", 2984, 1);
#line 104 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Confirm.cshtml"
WriteAttributeValue("", 2958, Model.Apartment.LocalCode, 2958, 26, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(2985, 102, true);
                    WriteLiteral(" name=\"ApartmentCode\" id=\"ApartmentCode\" class=\"form-control\" placeholder=\"\" aria-describedby=\"helpId\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 3087, "\"", 3108, 1);
#line 104 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Confirm.cshtml"
WriteAttributeValue("", 3095, ViewBag.code, 3095, 13, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(3109, 132, true);
                    WriteLiteral(" required>\r\n      </div>\r\n      <div class=\"form-group\" hidden>\r\n          <label>Nhập số cmnd</label>\r\n          <input type=\"text\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 3241, "\"", 3269, 1);
#line 108 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Confirm.cshtml"
WriteAttributeValue("", 3249, Model.Reserved.Cmnd, 3249, 20, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(3270, 216, true);
                    WriteLiteral(" id=\"Cmnd\" name=\"Cmnd\" class=\"form-control\" placeholder=\"cmnd\" aria-describedby=\"helpId\" required>\r\n      </div>\r\n      <div class=\"form-group\" hidden>\r\n          <label>Nhập SĐT</label>\r\n          <input type=\"text\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 3486, "\"", 3521, 1);
#line 112 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Confirm.cshtml"
WriteAttributeValue("", 3494, Model.Reserved.PhoneNumber, 3494, 27, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(3522, 228, true);
                    WriteLiteral(" id=\"PhoneNumber\" name=\"PhoneNumber\" class=\"form-control\" placeholder=\"sđt\" aria-describedby=\"helpId\" required>\r\n      </div>\r\n      <div class=\"form-group\" hidden>\r\n          <label>Nhập mã</label>\r\n          <input type=\"text\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 3750, "\"", 3779, 1);
#line 116 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Confirm.cshtml"
WriteAttributeValue("", 3758, Model.Reserved.RCode, 3758, 21, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(3780, 158, true);
                    WriteLiteral(" id=\"RCode\" name=\"RCode\" class=\"form-control\" placeholder=\"code\" aria-describedby=\"helpId\" required>\r\n      </div>\r\n      <div class=\"form-group\">\r\n          ");
                    EndContext();
                    BeginContext(3939, 40, false);
#line 119 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Confirm.cshtml"
     Write(Html.Recaptcha(RecaptchaSettings?.Value));

#line default
#line hidden
                    EndContext();
                    BeginContext(3979, 229, true);
                    WriteLiteral("\r\n      </div>\r\n      <p style=\"color: red; font-style: italic\">Lưu ý: Mỗi mã chỉ được sử dụng một lần. Quý khách sẽ không được thay đổi căn sau khi đã chọn</p>\r\n      <button class=\"btn btn-success\" id=\"btn\">Đặt mua</button>\r\n  ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4215, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
                BeginContext(4219, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3f7fe20767f43cf8c5b0a2e5f0667d2", async() => {
                    BeginContext(4242, 3, true);
                    WriteLiteral("Hủy");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4249, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4258, 790, true);
            WriteLiteral(@"
<style>
    
    p {
      font-family: sans-serif;
      font-size: 18;
      color: #828486;
    }

    h3 {
      font-size: 28;
      font-family: sans-serif;
      color: #6f767d;
      margin-top: 35px;
    }

    h4 {
      font-family: sans-serif;
      font-size: 21;
      color: #46494c;
    }

    h1,
    h3,
    h4,
    p {
      margin-left: 11px;
    }

    a {
      color: #595f65;
    }

    <!-- #product,
    #order {
      background-color: #f7f7f7;
      margin-left: 11px;
      margin-right: 11px;
      padding: 6 14 6 14;
    }

    #product>p,
    #order>p {
      margin: 18 0 18 0;
    }

    #product>h4,
    #order>h4 {
      margin: 0 0 18 0;
    } -->

    body {
      margin-bottom: 20;
    }

    ");
            EndContext();
            BeginContext(5049, 267, true);
            WriteLiteral(@"@media only screen and (min-width: 1280px) {
      body {
        margin: 0 400 0 400;
      }

    }
    h5 {
      font-family: sans-serif;
      font-size: 15px;
      color: red;
      font-style: italic;
      margin-left: 14px;

    }
  </style>
");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<RecaptchaSettings> RecaptchaSettings { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookingForm.Models.Reservation> Html { get; private set; }
    }
}
#pragma warning restore 1591
