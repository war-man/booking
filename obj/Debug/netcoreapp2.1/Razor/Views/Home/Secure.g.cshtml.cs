#pragma checksum "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Secure.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11297dba6c1b57c33b406e3603c6746db51cccfd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Secure), @"mvc.1.0.view", @"/Views/Home/Secure.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Secure.cshtml", typeof(AspNetCore.Views_Home_Secure))]
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
#line 1 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Secure.cshtml"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11297dba6c1b57c33b406e3603c6746db51cccfd", @"/Views/Home/Secure.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a961fb0ce4f853b3e2c4fa2992c1d9302b2824bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Secure : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CallApiUsingUserAccessToken", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CallApiUsingClientCredentials", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Secure.cshtml"
  
    ViewData["Title"] = "Secure";

#line default
#line hidden
            BeginContext(87, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(92, 17, false);
#line 5 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Secure.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(109, 40, true);
            WriteLiteral("</h2>\r\n<h3>User claims</h3>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(149, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eaadb6d1eaa7423aab842631ab4adb6c", async() => {
                BeginContext(193, 25, true);
                WriteLiteral("Call API using user token");
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
            BeginContext(222, 21, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(243, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3cb4a3000ab46e483b64405bfb7598f", async() => {
                BeginContext(289, 35, true);
                WriteLiteral("Call API using application identity");
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
            BeginContext(328, 16, true);
            WriteLiteral("\r\n</div>\r\n<dl>\r\n");
            EndContext();
#line 14 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Secure.cshtml"
     foreach (var claim in User.Claims)
    {

#line default
#line hidden
            BeginContext(392, 12, true);
            WriteLiteral("        <dt>");
            EndContext();
            BeginContext(405, 10, false);
#line 16 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Secure.cshtml"
       Write(claim.Type);

#line default
#line hidden
            EndContext();
            BeginContext(415, 19, true);
            WriteLiteral("</dt>\r\n        <dd>");
            EndContext();
            BeginContext(435, 11, false);
#line 17 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Secure.cshtml"
       Write(claim.Value);

#line default
#line hidden
            EndContext();
            BeginContext(446, 7, true);
            WriteLiteral("</dd>\r\n");
            EndContext();
#line 18 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Secure.cshtml"

    }

#line default
#line hidden
            BeginContext(462, 35, true);
            WriteLiteral("    <dt>access token</dt>\r\n    <dd>");
            EndContext();
            BeginContext(498, 59, false);
#line 21 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Secure.cshtml"
   Write(await ViewContext.HttpContext.GetTokenAsync("access_token"));

#line default
#line hidden
            EndContext();
            BeginContext(557, 43, true);
            WriteLiteral("</dd>\r\n    <dt>refresh token</dt>\r\n    <dd>");
            EndContext();
            BeginContext(601, 60, false);
#line 23 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Secure.cshtml"
   Write(await ViewContext.HttpContext.GetTokenAsync("refresh_token"));

#line default
#line hidden
            EndContext();
            BeginContext(661, 14, true);
            WriteLiteral("</dd>\r\n</dl>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
