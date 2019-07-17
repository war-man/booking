#pragma checksum "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d20a3b7821c312fb83c157980d2b24e6c7fbe0fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservations_Success), @"mvc.1.0.view", @"/Views/Reservations/Success.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reservations/Success.cshtml", typeof(AspNetCore.Views_Reservations_Success))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d20a3b7821c312fb83c157980d2b24e6c7fbe0fa", @"/Views/Reservations/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a961fb0ce4f853b3e2c4fa2992c1d9302b2824bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservations_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookingForm.Models.Reservation>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Continue", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Success.cshtml"
  
  Layout = null;

#line default
#line hidden
            BeginContext(64, 1258, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de4a4edd0d314fd88fbd123bb346dd6c", async() => {
                BeginContext(70, 963, true);
                WriteLiteral(@"
  <title>Đặt hàng thành công</title>
  <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
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
                BeginContext(1034, 281, true);
                WriteLiteral(@"@media only screen and (min-width: 1280px) {
      body {
        margin: 0 400 0 400;
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
            BeginContext(1322, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1324, 768, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e0bed2533fb4300a1f958380c2a5acb", async() => {
                BeginContext(1330, 206, true);
                WriteLiteral("\r\n<hr />\r\n<hr />\r\n<h1 style=\"font-family:sans-serif; \">Chúc mừng bạn đã đặt chỗ thành công!</h1>\r\n<p>Đơn hàng của bạn đã được hệ thông tiếp nhận</p>\r\n\r\n<h3>Thông tin sản phẩm</h3>\r\n<div id=\"order\">\r\n    <p>");
                EndContext();
                BeginContext(1537, 25, false);
#line 88 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Success.cshtml"
  Write(Model.Apartment.LocalCode);

#line default
#line hidden
                EndContext();
                BeginContext(1562, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(1566, 20, false);
#line 88 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Success.cshtml"
                               Write(Model.Apartment.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1586, 27, true);
                WriteLiteral("</p>\r\n    <p>Số phòng ngủ: ");
                EndContext();
                BeginContext(1614, 25, false);
#line 89 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Success.cshtml"
                Write(Model.Apartment.NOBedroom);

#line default
#line hidden
                EndContext();
                BeginContext(1639, 21, true);
                WriteLiteral(" / Số phòng vệ sinh: ");
                EndContext();
                BeginContext(1661, 20, false);
#line 89 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Success.cshtml"
                                                               Write(Model.Apartment.NOWC);

#line default
#line hidden
                EndContext();
                BeginContext(1681, 20, true);
                WriteLiteral("</p>\r\n    <p>Hướng: ");
                EndContext();
                BeginContext(1702, 25, false);
#line 90 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Success.cshtml"
         Write(Model.Apartment.Direction);

#line default
#line hidden
                EndContext();
                BeginContext(1727, 9, true);
                WriteLiteral(" / View: ");
                EndContext();
                BeginContext(1737, 20, false);
#line 90 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Success.cshtml"
                                            Write(Model.Apartment.View);

#line default
#line hidden
                EndContext();
                BeginContext(1757, 9, true);
                WriteLiteral(" / Tầng: ");
                EndContext();
                BeginContext(1767, 21, false);
#line 90 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Success.cshtml"
                                                                          Write(Model.Apartment.Floor);

#line default
#line hidden
                EndContext();
                BeginContext(1788, 14, true);
                WriteLiteral(" / Diện tích: ");
                EndContext();
                BeginContext(1803, 20, false);
#line 90 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Success.cshtml"
                                                                                                              Write(Model.Apartment.Area);

#line default
#line hidden
                EndContext();
                BeginContext(1823, 40, true);
                WriteLiteral("</p>\r\n</div>\r\n\r\n<p>Mã xác nhận</p>\r\n<h3>");
                EndContext();
                BeginContext(1864, 18, false);
#line 94 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Success.cshtml"
Write(Model.Reserved.RCC);

#line default
#line hidden
                EndContext();
                BeginContext(1882, 143, true);
                WriteLiteral("</h3>\r\n<h5>Lưu ý: Khách hàng cần lưu lại mã xác nhận để bốc thăm trong trường hợp có nhiều đơn hàng cùng đặt vào một sản phẩm</h5>\r\n<p>Bấm vào ");
                EndContext();
                BeginContext(2025, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f269c85de484c418fb6b945f3675761", async() => {
                    BeginContext(2050, 3, true);
                    WriteLiteral("đây");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2057, 28, true);
                WriteLiteral(" để tiếp tục chọn mua.</p>\r\n");
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
            BeginContext(2092, 849, true);
            WriteLiteral(@"
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

    #product,
    #order {
      background-color: #f7f7f7;
      margin-left: 11px;
      margin-right: 11px;
      padding: 7 14 7 14;
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
            BeginContext(2942, 304, true);
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
    body {
        margin-bottom: 20;
    }
  </style>
");
            EndContext();
        }
        #pragma warning restore 1998
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
