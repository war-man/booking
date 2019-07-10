#pragma checksum "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Partial\TableContents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1be8f644710dfc5e8761f84178e783f04ca0c324"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partial_TableContents), @"mvc.1.0.view", @"/Views/Partial/TableContents.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Partial/TableContents.cshtml", typeof(AspNetCore.Views_Partial_TableContents))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1be8f644710dfc5e8761f84178e783f04ca0c324", @"/Views/Partial/TableContents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a961fb0ce4f853b3e2c4fa2992c1d9302b2824bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Partial_TableContents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookingForm.Models.Appoinment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AppDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Confirm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Draft", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(171, 11, true);
            WriteLiteral("\r\n<tbody>\r\n");
            EndContext();
#line 6 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Partial\TableContents.cshtml"
     foreach (var item in Model)
    {
        var statusClass = "Yellow";

        if (item.Deposit == "Đúng thời hạn")
        {
            statusClass = "Green";
        }
        else if (item.Deposit == "Không đúng thời hạn")
        {
            statusClass = "Red";
        }

#line default
#line hidden
            BeginContext(479, 11, true);
            WriteLiteral("        <tr");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 490, "\"", 510, 1);
#line 18 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Partial\TableContents.cshtml"
WriteAttributeValue("", 498, statusClass, 498, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(511, 66, true);
            WriteLiteral(">\r\n            <td style=\"white-space: nowrap;\">\r\n                ");
            EndContext();
            BeginContext(578, 43, false);
#line 20 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Partial\TableContents.cshtml"
           Write(Html.DisplayFor(modelItem => item.Customer));

#line default
#line hidden
            EndContext();
            BeginContext(621, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(677, 45, false);
#line 23 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Partial\TableContents.cshtml"
           Write(Html.DisplayFor(modelItem => item.Sale.Email));

#line default
#line hidden
            EndContext();
            BeginContext(722, 21, true);
            WriteLiteral(" - \r\n                ");
            EndContext();
            BeginContext(744, 46, false);
#line 24 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Partial\TableContents.cshtml"
           Write(Html.DisplayFor(modelItem => item.SaleDetails));

#line default
#line hidden
            EndContext();
            BeginContext(790, 57, true);
            WriteLiteral("\r\n\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(848, 43, false);
#line 28 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Partial\TableContents.cshtml"
           Write(Html.DisplayFor(modelItem => item.Contract));

#line default
#line hidden
            EndContext();
            BeginContext(891, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
            BeginContext(1019, 18, true);
            WriteLiteral("            <td>\r\n");
            EndContext();
#line 34 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Partial\TableContents.cshtml"
                  
                    string str = "";
                    if (item.ph > 0)
                    {
                        str = "<input type=\"checkbox\" name=\"ph\" value=\"Boat\" checked disabled>( Số: " + item.ph + " )";
                    }
                    else
                    {
                        str = "<input type=\"checkbox\" name=\"ph\" value=\"Boat\" disabled>";
                    }
                

#line default
#line hidden
            BeginContext(1493, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1510, 13, false);
#line 45 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Partial\TableContents.cshtml"
           Write(Html.Raw(str));

#line default
#line hidden
            EndContext();
            BeginContext(1523, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
#line 48 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Partial\TableContents.cshtml"
                  
                    string str1 = "";
                    if (item.pms > 0)
                    {
                        str1 = "<input type=\"checkbox\" name=\"ph\" value=\"Boat\" checked disabled>( Số: " + item.pms + " )";
                    }
                    else
                    {
                        str1 = "<input type=\"checkbox\" name=\"ph\" value=\"Boat\" disabled>";
                    }
                

#line default
#line hidden
            BeginContext(2023, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(2040, 14, false);
#line 59 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Partial\TableContents.cshtml"
           Write(Html.Raw(str1));

#line default
#line hidden
            EndContext();
            BeginContext(2054, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2117, 37, true);
            WriteLiteral("            </td>\r\n            <td>\r\n");
            EndContext();
#line 63 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Partial\TableContents.cshtml"
                  
                    string str2 = "";
                    if (item.psh > 0)
                    {
                        str2 = "<input type=\"checkbox\" name=\"ph\" value=\"Boat\" checked disabled>( Số: " + item.psh + " )";
                    }
                    else
                    {
                        str2 = "<input type=\"checkbox\" name=\"ph\" value=\"Boat\" disabled>";
                    }
                

#line default
#line hidden
            BeginContext(2615, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(2632, 14, false);
#line 74 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Partial\TableContents.cshtml"
           Write(Html.Raw(str2));

#line default
#line hidden
            EndContext();
            BeginContext(2646, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2709, 37, true);
            WriteLiteral("            </td>\r\n            <td>\r\n");
            EndContext();
#line 78 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Partial\TableContents.cshtml"
                  
                    string str3 = "";
                    if (item.pshh > 0)
                    {
                        str3 = "<input type=\"checkbox\" name=\"ph\" value=\"Boat\" checked disabled>( Số: " + item.pshh + " )";
                    }
                else
                    {
                        str3 = "<input type=\"checkbox\" name=\"ph\" value=\"Boat\" disabled>";
                    }
                

#line default
#line hidden
            BeginContext(3205, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(3222, 14, false);
#line 89 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Partial\TableContents.cshtml"
           Write(Html.Raw(str3));

#line default
#line hidden
            EndContext();
            BeginContext(3236, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3300, 37, true);
            WriteLiteral("            </td>\r\n            <td>\r\n");
            EndContext();
            BeginContext(3400, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(3417, 35, false);
#line 94 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Partial\TableContents.cshtml"
           Write(String.Format("{0:N0}", item.Money));

#line default
#line hidden
            EndContext();
            BeginContext(3452, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3508, 40, false);
#line 97 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Partial\TableContents.cshtml"
           Write(Html.DisplayFor(modelItem => item.cTime));

#line default
#line hidden
            EndContext();
            BeginContext(3548, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3604, 40, false);
#line 100 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Partial\TableContents.cshtml"
           Write(Html.DisplayFor(modelItem => item.DType));

#line default
#line hidden
            EndContext();
            BeginContext(3644, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
            BeginContext(3745, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(3762, 34, false);
#line 104 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Partial\TableContents.cshtml"
           Write(String.Format("{0:N0}", item.Cash));

#line default
#line hidden
            EndContext();
            BeginContext(3796, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3852, 40, false);
#line 107 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Partial\TableContents.cshtml"
           Write(Html.DisplayFor(modelItem => item.dTime));

#line default
#line hidden
            EndContext();
            BeginContext(3892, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
#line 110 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Partial\TableContents.cshtml"
                  
                    string tmp = "";
                    if (item.Price > 0)
                    {
                        tmp = "<input type =\"checkbox\" name=\"ph\" value=\"Boat\" checked disabled> " + @String.Format("{0:N0}", item.Price);
                    }
                    else
                    {
                        tmp = "<input type =\"checkbox\" name=\"ph\" value=\"Boat\" disabled>";
                    }
                

#line default
#line hidden
            BeginContext(4409, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(4426, 13, false);
#line 121 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Partial\TableContents.cshtml"
           Write(Html.Raw(tmp));

#line default
#line hidden
            EndContext();
            BeginContext(4439, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4495, 43, false);
#line 124 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Partial\TableContents.cshtml"
           Write(Html.DisplayFor(modelItem => item.Requires));

#line default
#line hidden
            EndContext();
            BeginContext(4538, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4594, 42, false);
#line 127 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Partial\TableContents.cshtml"
           Write(Html.DisplayFor(modelItem => item.Confirm));

#line default
#line hidden
            EndContext();
            BeginContext(4636, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4691, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2952bd8f62ce4cadb954b48ebb69880c", async() => {
                BeginContext(4748, 3, true);
                WriteLiteral("XHĐ");
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
#line 130 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Partial\TableContents.cshtml"
                                             WriteLiteral(item.Contract);

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
            BeginContext(4755, 19, true);
            WriteLiteral("|\r\n                ");
            EndContext();
            BeginContext(4774, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ee5e56d85214bf08cbc2ddcb11d2954", async() => {
                BeginContext(4828, 2, true);
                WriteLiteral("XN");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 131 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Partial\TableContents.cshtml"
                                          WriteLiteral(item.Contract);

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
            BeginContext(4834, 19, true);
            WriteLiteral("|\r\n                ");
            EndContext();
            BeginContext(4853, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f3a23d304654537ac5a504bc0ddac6f", async() => {
                BeginContext(4905, 5, true);
                WriteLiteral("Draft");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 132 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Partial\TableContents.cshtml"
                                        WriteLiteral(item.Contract);

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
            BeginContext(4914, 19, true);
            WriteLiteral("|\r\n                ");
            EndContext();
            BeginContext(4933, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb87335efa014564b62048eb7fd1b81a", async() => {
                BeginContext(4986, 3, true);
                WriteLiteral("Hủy");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 133 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Partial\TableContents.cshtml"
                                         WriteLiteral(item.Contract);

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
            BeginContext(4993, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(5169, 34, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n");
            EndContext();
#line 138 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Partial\TableContents.cshtml"
    }

#line default
#line hidden
            BeginContext(5210, 373, true);
            WriteLiteral(@"
</tbody>

<style>
    /*tr:hover {
        background-color: #ddd;
    }*/
    .Red {
        color: #ffffff;
        background-color: #f74743
    }

    .Green {
        color: #ffffff;
        background-color: #2ed75d
    }

    .Yellow {
        background-color: #f6f11d
    }

    th, td {
        border-left: 1px solid #ddd;
    }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookingForm.Models.Appoinment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
