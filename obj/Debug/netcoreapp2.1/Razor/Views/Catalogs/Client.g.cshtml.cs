#pragma checksum "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Client.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec9180c3c2c91b0373c2a1a6c0d7334b71ebe8d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogs_Client), @"mvc.1.0.view", @"/Views/Catalogs/Client.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Catalogs/Client.cshtml", typeof(AspNetCore.Views_Catalogs_Client))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec9180c3c2c91b0373c2a1a6c0d7334b71ebe8d0", @"/Views/Catalogs/Client.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a961fb0ce4f853b3e2c4fa2992c1d9302b2824bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalogs_Client : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookingForm.Models.Client>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Code", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(47, 295, true);
            WriteLiteral(@"
<table class=""table"">
    <thead>
        <tr>

            <th>Số thứ tự</th>
            <th>Họ và tên</th>
            <th>Số điện thoại</th>
            <th>Số cmnd</th>
            <th>Số sản phẩm đặt mua</th>
            <th>Code</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 16 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Client.cshtml"
          
            int count = 1;
        

#line default
#line hidden
            BeginContext(393, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 19 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Client.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(442, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(481, 5, false);
#line 22 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Client.cshtml"
               Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(486, 39, true);
            WriteLiteral("</td>\r\n                <td scope=\"row\">");
            EndContext();
            BeginContext(526, 13, false);
#line 23 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Client.cshtml"
                           Write(item.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(539, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(567, 16, false);
#line 24 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Client.cshtml"
               Write(item.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(583, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(611, 9, false);
#line 25 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Client.cshtml"
               Write(item.Cmnd);

#line default
#line hidden
            EndContext();
            BeginContext(620, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(648, 14, false);
#line 26 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Client.cshtml"
               Write(item.NOProduct);

#line default
#line hidden
            EndContext();
            BeginContext(662, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 27 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Client.cshtml"
                 if (item.Codes != null)
                {

#line default
#line hidden
            BeginContext(730, 24, true);
            WriteLiteral("                    <td>");
            EndContext();
            BeginContext(754, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba1ce6e3b2234ba5a95abafcb8552ec0", async() => {
                BeginContext(799, 3, true);
                WriteLiteral("Xem");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 29 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Client.cshtml"
                                               WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(806, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 30 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Client.cshtml"

                }

#line default
#line hidden
            BeginContext(834, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 33 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Client.cshtml"
            count++;
        }

#line default
#line hidden
            BeginContext(886, 32, true);
            WriteLiteral("        \r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookingForm.Models.Client>> Html { get; private set; }
    }
}
#pragma warning restore 1591
