#pragma checksum "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Passport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee56039c6ec1118d6eeb9215129a31308cea62f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Passport), @"mvc.1.0.view", @"/Views/Admin/Passport.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Passport.cshtml", typeof(AspNetCore.Views_Admin_Passport))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee56039c6ec1118d6eeb9215129a31308cea62f1", @"/Views/Admin/Passport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a961fb0ce4f853b3e2c4fa2992c1d9302b2824bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Passport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 400px; height:250px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Passport.cshtml"
  
    ViewData["Title"] = "TT CMND -";
    string[] paths = null;
    if (ViewBag.paths != null)
    {
        paths = ViewBag.paths.Split(" ");
    }
    

#line default
#line hidden
            BeginContext(168, 152, true);
            WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <label class=\"control-label\">\r\n            Tên khách hàng\r\n        </label>\r\n        <input class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 320, "\"", 345, 1);
#line 15 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Passport.cshtml"
WriteAttributeValue("", 328, TempData["Name"], 328, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(346, 130, true);
            WriteLiteral(" readonly />\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label class=\"control-label\">\r\n            Ảnh\r\n        </label>\r\n");
            EndContext();
#line 21 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Passport.cshtml"
          
            if (paths == null)
            {

#line default
#line hidden
            BeginContext(535, 103, true);
            WriteLiteral("                <label class=\"control-label\">\r\n                    Không có\r\n                </label>\r\n");
            EndContext();
#line 27 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Passport.cshtml"
            }
            else if (paths.Length == 2)
            {
                foreach (var path in paths)
                {

#line default
#line hidden
            BeginContext(773, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(793, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a6b01597e7284176b2a8e99501a525ff", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 803, "~/storage/", 803, 10, true);
#line 32 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Passport.cshtml"
AddHtmlAttributeValue("", 813, path, 813, 5, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(856, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 33 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Passport.cshtml"
                }
            }
        

#line default
#line hidden
            BeginContext(903, 22, true);
            WriteLiteral("        \r\n\r\n    </div>");
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
