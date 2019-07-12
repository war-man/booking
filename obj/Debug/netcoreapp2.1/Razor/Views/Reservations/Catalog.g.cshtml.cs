#pragma checksum "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Catalog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9402d63acd47315c133d64b13a9d2630028b8240"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservations_Catalog), @"mvc.1.0.view", @"/Views/Reservations/Catalog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reservations/Catalog.cshtml", typeof(AspNetCore.Views_Reservations_Catalog))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9402d63acd47315c133d64b13a9d2630028b8240", @"/Views/Reservations/Catalog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a961fb0ce4f853b3e2c4fa2992c1d9302b2824bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservations_Catalog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookingForm.Models.Block>>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Catalog.cshtml"
  
    Layout = "/Views/Reservations/DumbLayout.cshtml";

#line default
#line hidden
            BeginContext(108, 73, true);
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        \r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 10 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Catalog.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(230, 16, true);
            WriteLiteral("            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 246, "\"", 270, 2);
            WriteAttributeValue("", 254, "block", 254, 5, true);
#line 12 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Catalog.cshtml"
WriteAttributeValue(" ", 259, item.Name, 260, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(271, 42, true);
            WriteLiteral(">\r\n                <h3 class=\"block-name\">");
            EndContext();
            BeginContext(314, 9, false);
#line 13 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Catalog.cshtml"
                                  Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(323, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
#line 14 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Catalog.cshtml"
                 foreach (var floor in item.Floors)
                {

#line default
#line hidden
            BeginContext(402, 72, true);
            WriteLiteral("                    <div class=\"floor-container\"><h4 class=\"floor-name\">");
            EndContext();
            BeginContext(475, 10, false);
#line 16 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Catalog.cshtml"
                                                                   Write(floor.Name);

#line default
#line hidden
            EndContext();
            BeginContext(485, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 17 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Catalog.cshtml"
                         foreach (var room in floor.Apartments)
                        {
                            var type = room.ApartmentDetails.ApartmentType.Replace("+", "P");
                            type = type.Replace("1", "O");
                            type = type.Replace("2", "W");
                            type = type.Replace("3", "H");

#line default
#line hidden
            BeginContext(859, 94, true);
            WriteLiteral("                            <div class=\"room-container\">\r\n                                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 953, "\"", 971, 2);
            WriteAttributeValue("", 961, "room", 961, 4, true);
#line 24 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Catalog.cshtml"
WriteAttributeValue(" ", 965, type, 966, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(972, 39, true);
            WriteLiteral(">\r\n                                    ");
            EndContext();
            BeginContext(1011, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd12dd372d3e4a1382afeda1aca002ef", async() => {
                BeginContext(1077, 14, false);
#line 25 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Catalog.cshtml"
                                                                                                Write(room.LocalCode);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-apartmentCode", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 25 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Catalog.cshtml"
                                                                        WriteLiteral(room.LocalCode);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["apartmentCode"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-apartmentCode", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["apartmentCode"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1095, 78, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 28 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Catalog.cshtml"
                        }

#line default
#line hidden
            BeginContext(1200, 28, true);
            WriteLiteral("                    </div>\r\n");
            EndContext();
#line 30 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Catalog.cshtml"
                }

#line default
#line hidden
            BeginContext(1247, 20, true);
            WriteLiteral("            </div>\r\n");
            EndContext();
#line 32 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Catalog.cshtml"
        }

#line default
#line hidden
            BeginContext(1278, 1010, true);
            WriteLiteral(@"    </tbody>
</table>
<style>
    .room-container {
        display: inline-block;
        float: left;
        border: 1px solid black;
        background-color: yellow;
    }
    .floor-container {
        overflow: auto; 
        border: 1px solid black;
        background-color: yellow;
    }
    ul, li {
        list-style: none;
        margin: 0 0 0 0 !important;
        padding: 0 0 0 0 !important;
    }
    .room {
        margin: 3px 3px 3px 3px;
    }
    .room>a {
        color: black !important;
    }
    .room>a:hover {
        <!-- text-decoration: none; -->
    }
    .OBRP {
        background-color: rgb(243, 135, 184);
    }
    .STU {
        background-color: rgb(224, 201, 227);
    }
    .WBR {
        background-color: rgb(175, 140, 136);
    }
    .WBRP {
        background-color: rgb(109, 207, 246)
    }
    .HBR {
        background-color: rgb(254, 242, 0);
    }
    .block {
        padding: 0 15px 15px 15px;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookingForm.Models.Block>> Html { get; private set; }
    }
}
#pragma warning restore 1591
