#pragma checksum "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\RequestDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a49555b9c6b333f91f6913c28feab140e70e9c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RequestDetails), @"mvc.1.0.view", @"/Views/Home/RequestDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/RequestDetails.cshtml", typeof(AspNetCore.Views_Home_RequestDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a49555b9c6b333f91f6913c28feab140e70e9c5", @"/Views/Home/RequestDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a961fb0ce4f853b3e2c4fa2992c1d9302b2824bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RequestDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookingForm.Models.Request>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConfirmRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RequestsControl", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(35, 155, true);
            WriteLiteral("\r\n<div>\r\n    <h4>Yêu cầu</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            Tên yêu cầu\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(191, 43, false);
#line 11 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\RequestDetails.cshtml"
       Write(Html.DisplayFor(model => model.RequestName));

#line default
#line hidden
            EndContext();
            BeginContext(234, 98, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Loại yêu cầu\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(333, 39, false);
#line 17 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\RequestDetails.cshtml"
       Write(Html.DisplayFor(model => model.Subject));

#line default
#line hidden
            EndContext();
            BeginContext(372, 17, true);
            WriteLiteral("\r\n        </dd>\r\n");
            EndContext();
            BeginContext(703, 86, true);
            WriteLiteral("        <dt>\r\n            Người gửi yêu cầu\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(790, 13, false);
#line 35 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\RequestDetails.cshtml"
       Write(ViewBag.Owner);

#line default
#line hidden
            EndContext();
            BeginContext(803, 100, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Tên khách hàng\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(904, 40, false);
#line 41 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\RequestDetails.cshtml"
       Write(Html.DisplayFor(model => model.Customer));

#line default
#line hidden
            EndContext();
            BeginContext(944, 88, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n           SĐT\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1033, 43, false);
#line 47 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\RequestDetails.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1076, 95, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Quốc tịch\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1172, 43, false);
#line 53 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\RequestDetails.cshtml"
       Write(Html.DisplayFor(model => model.Nationality));

#line default
#line hidden
            EndContext();
            BeginContext(1215, 97, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Số hợp đồng\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1313, 46, false);
#line 59 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\RequestDetails.cshtml"
       Write(Html.DisplayFor(model => model.ContractNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1359, 95, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Ngày sinh\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1455, 35, false);
#line 65 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\RequestDetails.cshtml"
       Write(Html.DisplayFor(model => model.DOB));

#line default
#line hidden
            EndContext();
            BeginContext(1490, 91, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Email\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1582, 37, false);
#line 71 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\RequestDetails.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1619, 104, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n           Tình trạng hôn nhân\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1724, 45, false);
#line 77 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\RequestDetails.cshtml"
       Write(Html.DisplayFor(model => model.MaritalStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1769, 94, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Mục đích\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1864, 39, false);
#line 83 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\RequestDetails.cshtml"
       Write(Html.DisplayFor(model => model.Purpose));

#line default
#line hidden
            EndContext();
            BeginContext(1903, 94, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Sản phẩm\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1998, 39, false);
#line 89 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\RequestDetails.cshtml"
       Write(Html.DisplayFor(model => model.Product));

#line default
#line hidden
            EndContext();
            BeginContext(2037, 90, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n           Lưu ý\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2128, 36, false);
#line 95 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\RequestDetails.cshtml"
       Write(Html.DisplayFor(model => model.Note));

#line default
#line hidden
            EndContext();
            BeginContext(2164, 95, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n           Tình trạng\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2260, 42, false);
#line 101 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\RequestDetails.cshtml"
       Write(Html.DisplayFor(model => model.LoanStatus));

#line default
#line hidden
            EndContext();
            BeginContext(2302, 105, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n           Thời gian hoàn thành\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2408, 44, false);
#line 107 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\RequestDetails.cshtml"
       Write(Html.DisplayFor(model => model.CompleteTime));

#line default
#line hidden
            EndContext();
            BeginContext(2452, 108, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Thời gian nhận yêu cầu\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2561, 42, false);
#line 113 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\RequestDetails.cshtml"
       Write(Html.DisplayFor(model => model.SubmitTime));

#line default
#line hidden
            EndContext();
            BeginContext(2603, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2650, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49fd9a543b2b49a2af9cbe37ef38fcf2", async() => {
                BeginContext(2706, 8, true);
                WriteLiteral("Xác nhận");
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
#line 118 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\RequestDetails.cshtml"
                                     WriteLiteral(Model.Id);

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
            BeginContext(2718, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2726, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f478d3f9f0b04d0e9faba860e34da51a", async() => {
                BeginContext(2758, 7, true);
                WriteLiteral("Trở lại");
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
            BeginContext(2769, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookingForm.Models.Request> Html { get; private set; }
    }
}
#pragma warning restore 1591
