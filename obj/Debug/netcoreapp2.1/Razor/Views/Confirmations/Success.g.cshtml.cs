#pragma checksum "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Confirmations\Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "139f53815c47814d2f7e11c27e13fa70b1c36271"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Confirmations_Success), @"mvc.1.0.view", @"/Views/Confirmations/Success.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Confirmations/Success.cshtml", typeof(AspNetCore.Views_Confirmations_Success))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"139f53815c47814d2f7e11c27e13fa70b1c36271", @"/Views/Confirmations/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a961fb0ce4f853b3e2c4fa2992c1d9302b2824bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Confirmations_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookingForm.Models.Invoice>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Confirmations\Success.cshtml"
  
  Layout = null;

#line default
#line hidden
            BeginContext(62, 1257, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4c607838e9c421fb8312eee99e431de", async() => {
                BeginContext(68, 962, true);
                WriteLiteral(@"
  <title>Đặt mua thành công</title>
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
                BeginContext(1031, 281, true);
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
            BeginContext(1319, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1321, 604, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f52db6d5dab44198b9404a4fb60c0f63", async() => {
                BeginContext(1327, 76, true);
                WriteLiteral("\r\n<hr />\r\n<hr />\r\n<h1 style=\"font-family:sans-serif; \">Chúc mừng khách hàng ");
                EndContext();
                BeginContext(1404, 21, false);
#line 84 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Confirmations\Success.cshtml"
                                                     Write(Model.Client.FullName);

#line default
#line hidden
                EndContext();
                BeginContext(1425, 33, true);
                WriteLiteral(" đã đặt mua thành công căn hộ số ");
                EndContext();
                BeginContext(1459, 25, false);
#line 84 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Confirmations\Success.cshtml"
                                                                                                            Write(Model.Apartment.LocalCode);

#line default
#line hidden
                EndContext();
                BeginContext(1484, 62, true);
                WriteLiteral("!</h1>\r\n\r\n<h3>Thông tin căn hộ</h3>\r\n<div id=\"order\">\r\n    <p>");
                EndContext();
                BeginContext(1547, 25, false);
#line 88 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Confirmations\Success.cshtml"
  Write(Model.Apartment.LocalCode);

#line default
#line hidden
                EndContext();
                BeginContext(1572, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(1576, 20, false);
#line 88 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Confirmations\Success.cshtml"
                               Write(Model.Apartment.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1596, 27, true);
                WriteLiteral("</p>\r\n    <p>Số phòng ngủ: ");
                EndContext();
                BeginContext(1624, 25, false);
#line 89 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Confirmations\Success.cshtml"
                Write(Model.Apartment.NOBedroom);

#line default
#line hidden
                EndContext();
                BeginContext(1649, 21, true);
                WriteLiteral(" / Số phòng vệ sinh: ");
                EndContext();
                BeginContext(1671, 20, false);
#line 89 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Confirmations\Success.cshtml"
                                                               Write(Model.Apartment.NOWC);

#line default
#line hidden
                EndContext();
                BeginContext(1691, 20, true);
                WriteLiteral("</p>\r\n    <p>Hướng: ");
                EndContext();
                BeginContext(1712, 25, false);
#line 90 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Confirmations\Success.cshtml"
         Write(Model.Apartment.Direction);

#line default
#line hidden
                EndContext();
                BeginContext(1737, 9, true);
                WriteLiteral(" / View: ");
                EndContext();
                BeginContext(1747, 20, false);
#line 90 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Confirmations\Success.cshtml"
                                            Write(Model.Apartment.View);

#line default
#line hidden
                EndContext();
                BeginContext(1767, 9, true);
                WriteLiteral(" / Tầng: ");
                EndContext();
                BeginContext(1777, 21, false);
#line 90 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Confirmations\Success.cshtml"
                                                                          Write(Model.Apartment.Floor);

#line default
#line hidden
                EndContext();
                BeginContext(1798, 14, true);
                WriteLiteral(" / Diện tích: ");
                EndContext();
                BeginContext(1813, 20, false);
#line 90 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Confirmations\Success.cshtml"
                                                                                                              Write(Model.Apartment.Area);

#line default
#line hidden
                EndContext();
                BeginContext(1833, 27, true);
                WriteLiteral("</p>\r\n</div>\r\n\r\n<p>Bấm vào ");
                EndContext();
                BeginContext(1860, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b254a34032b43d69411f1596f9aea5c", async() => {
                    BeginContext(1883, 3, true);
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
                BeginContext(1890, 28, true);
                WriteLiteral(" để tiếp tục xác nhận.</p>\r\n");
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
            BeginContext(1925, 849, true);
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
            BeginContext(2775, 304, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookingForm.Models.Invoice> Html { get; private set; }
    }
}
#pragma warning restore 1591
