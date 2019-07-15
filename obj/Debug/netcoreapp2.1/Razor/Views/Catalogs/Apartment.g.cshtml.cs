#pragma checksum "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Apartment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da880900c1b9e647fcb6c916335cd7c5a7577829"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogs_Apartment), @"mvc.1.0.view", @"/Views/Catalogs/Apartment.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Catalogs/Apartment.cshtml", typeof(AspNetCore.Views_Catalogs_Apartment))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da880900c1b9e647fcb6c916335cd7c5a7577829", @"/Views/Catalogs/Apartment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a961fb0ce4f853b3e2c4fa2992c1d9302b2824bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalogs_Apartment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookingForm.Models.Apartment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Apartment.cshtml"
  
    ViewData["title"] = "Sản phẩm";
    Layout = "~/Views/Catalogs/DumbLayout.cshtml";

#line default
#line hidden
            BeginContext(146, 84, true);
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(231, 45, false);
#line 10 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Apartment.cshtml"
           Write(Html.DisplayNameFor(model => model.LocalCode));

#line default
#line hidden
            EndContext();
            BeginContext(276, 294, true);
            WriteLiteral(@"
            </th>
            <th>
                Tầng
            </th>    
            <th>
                Loại căn
            </th>    
            <th>
                Vị trí/Thông tin căn hộ
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 25 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Apartment.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(602, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(651, 44, false);
#line 28 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Apartment.cshtml"
           Write(Html.DisplayFor(modelItem => item.LocalCode));

#line default
#line hidden
            EndContext();
            BeginContext(695, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(751, 40, false);
#line 31 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Apartment.cshtml"
           Write(Html.DisplayFor(modelItem => item.Floor));

#line default
#line hidden
            EndContext();
            BeginContext(791, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(847, 65, false);
#line 34 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Apartment.cshtml"
           Write(Html.DisplayFor(modelItem => item.ApartmentDetails.ApartmentType));

#line default
#line hidden
            EndContext();
            BeginContext(912, 65, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <p>-Khối: ");
            EndContext();
            BeginContext(978, 40, false);
#line 37 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Apartment.cshtml"
                     Write(Html.DisplayFor(modelItem => item.Block));

#line default
#line hidden
            EndContext();
            BeginContext(1018, 11, true);
            WriteLiteral(" / Căn số: ");
            EndContext();
            BeginContext(1030, 45, false);
#line 37 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Apartment.cshtml"
                                                                         Write(Html.DisplayFor(modelItem => item.GlobalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1075, 30, true);
            WriteLiteral("</p>\r\n                <p>-PN: ");
            EndContext();
            BeginContext(1106, 44, false);
#line 38 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Apartment.cshtml"
                   Write(Html.DisplayFor(modelItem => item.NOBedroom));

#line default
#line hidden
            EndContext();
            BeginContext(1150, 7, true);
            WriteLiteral(" / WC: ");
            EndContext();
            BeginContext(1158, 39, false);
#line 38 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Apartment.cshtml"
                                                                       Write(Html.DisplayFor(modelItem => item.NOWC));

#line default
#line hidden
            EndContext();
            BeginContext(1197, 9, true);
            WriteLiteral(" / View: ");
            EndContext();
            BeginContext(1207, 39, false);
#line 38 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Apartment.cshtml"
                                                                                                                        Write(Html.DisplayFor(modelItem => item.View));

#line default
#line hidden
            EndContext();
            BeginContext(1246, 10, true);
            WriteLiteral(" / Hướng: ");
            EndContext();
            BeginContext(1257, 44, false);
#line 38 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Apartment.cshtml"
                                                                                                                                                                          Write(Html.DisplayFor(modelItem => item.Direction));

#line default
#line hidden
            EndContext();
            BeginContext(1301, 14, true);
            WriteLiteral(" / Diện tích: ");
            EndContext();
            BeginContext(1316, 39, false);
#line 38 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Apartment.cshtml"
                                                                                                                                                                                                                                     Write(Html.DisplayFor(modelItem => item.Area));

#line default
#line hidden
            EndContext();
            BeginContext(1355, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 39 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Apartment.cshtml"
                 if(item.IsCorner)
                {

#line default
#line hidden
            BeginContext(1416, 38, true);
            WriteLiteral("                    <p>(Căn góc)</p>\r\n");
            EndContext();
#line 42 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Apartment.cshtml"
                    
                }

#line default
#line hidden
            BeginContext(1495, 53, true);
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1548, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb4473587d1349f89cb446c781157652", async() => {
                BeginContext(1604, 7, true);
                WriteLiteral("Đặt chỗ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-code", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Apartment.cshtml"
                                           WriteLiteral(item.LocalCode);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["code"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-code", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["code"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1615, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 49 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Apartment.cshtml"
}

#line default
#line hidden
            BeginContext(1654, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookingForm.Models.Apartment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
