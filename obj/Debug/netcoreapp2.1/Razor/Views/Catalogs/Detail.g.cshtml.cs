#pragma checksum "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cd48180b1c006a6446ed45f7f2a6b85b9d5ef89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogs_Detail), @"mvc.1.0.view", @"/Views/Catalogs/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Catalogs/Detail.cshtml", typeof(AspNetCore.Views_Catalogs_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cd48180b1c006a6446ed45f7f2a6b85b9d5ef89", @"/Views/Catalogs/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a961fb0ce4f853b3e2c4fa2992c1d9302b2824bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalogs_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookingForm.Models.Apartment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "StatusMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Reserve", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ceac1afe9fff4a27829a780c287e36ad", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 2 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = ViewBag.msg;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(90, 59, true);
            WriteLiteral("\r\n</hr>\r\n<div class=\"form-group\">\r\n  <label for=\"\">\r\n      ");
            EndContext();
            BeginContext(150, 45, false);
#line 6 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
 Write(Html.DisplayNameFor(model => model.LocalCode));

#line default
#line hidden
            EndContext();
            BeginContext(195, 110, true);
            WriteLiteral("\r\n  </label>\r\n  <input type=\"text\" name=\"\" id=\"\" class=\"form-control\" placeholder=\"\" aria-describedby=\"helpId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 305, "\"", 329, 1);
#line 8 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
WriteAttributeValue("", 313, Model.LocalCode, 313, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(330, 70, true);
            WriteLiteral(" readonly>\r\n</div>\r\n<div class=\"form-group\">\r\n  <label for=\"\">\r\n      ");
            EndContext();
            BeginContext(401, 46, false);
#line 12 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
 Write(Html.DisplayNameFor(model => model.GlobalCode));

#line default
#line hidden
            EndContext();
            BeginContext(447, 110, true);
            WriteLiteral("\r\n  </label>\r\n  <input type=\"text\" name=\"\" id=\"\" class=\"form-control\" placeholder=\"\" aria-describedby=\"helpId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 557, "\"", 582, 1);
#line 14 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
WriteAttributeValue("", 565, Model.GlobalCode, 565, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(583, 70, true);
            WriteLiteral(" readonly>\r\n</div>\r\n<div class=\"form-group\">\r\n  <label for=\"\">\r\n      ");
            EndContext();
            BeginContext(654, 41, false);
#line 18 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
 Write(Html.DisplayNameFor(model => model.Floor));

#line default
#line hidden
            EndContext();
            BeginContext(695, 110, true);
            WriteLiteral("\r\n  </label>\r\n  <input type=\"text\" name=\"\" id=\"\" class=\"form-control\" placeholder=\"\" aria-describedby=\"helpId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 805, "\"", 825, 1);
#line 20 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
WriteAttributeValue("", 813, Model.Floor, 813, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(826, 70, true);
            WriteLiteral(" readonly>\r\n</div>\r\n<div class=\"form-group\">\r\n  <label for=\"\">\r\n      ");
            EndContext();
            BeginContext(897, 45, false);
#line 24 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
 Write(Html.DisplayNameFor(model => model.Direction));

#line default
#line hidden
            EndContext();
            BeginContext(942, 110, true);
            WriteLiteral("\r\n  </label>\r\n  <input type=\"text\" name=\"\" id=\"\" class=\"form-control\" placeholder=\"\" aria-describedby=\"helpId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1052, "\"", 1076, 1);
#line 26 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
WriteAttributeValue("", 1060, Model.Direction, 1060, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1077, 70, true);
            WriteLiteral(" readonly>\r\n</div>\r\n<div class=\"form-group\">\r\n  <label for=\"\">\r\n      ");
            EndContext();
            BeginContext(1148, 40, false);
#line 30 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
 Write(Html.DisplayNameFor(model => model.Area));

#line default
#line hidden
            EndContext();
            BeginContext(1188, 110, true);
            WriteLiteral("\r\n  </label>\r\n  <input type=\"text\" name=\"\" id=\"\" class=\"form-control\" placeholder=\"\" aria-describedby=\"helpId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1298, "\"", 1317, 1);
#line 32 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
WriteAttributeValue("", 1306, Model.Area, 1306, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1318, 70, true);
            WriteLiteral(" readonly>\r\n</div>\r\n<div class=\"form-group\">\r\n  <label for=\"\">\r\n      ");
            EndContext();
            BeginContext(1389, 45, false);
#line 36 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
 Write(Html.DisplayNameFor(model => model.NOBedroom));

#line default
#line hidden
            EndContext();
            BeginContext(1434, 110, true);
            WriteLiteral("\r\n  </label>\r\n  <input type=\"text\" name=\"\" id=\"\" class=\"form-control\" placeholder=\"\" aria-describedby=\"helpId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1544, "\"", 1568, 1);
#line 38 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
WriteAttributeValue("", 1552, Model.NOBedroom, 1552, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1569, 70, true);
            WriteLiteral(" readonly>\r\n</div>\r\n<div class=\"form-group\">\r\n  <label for=\"\">\r\n      ");
            EndContext();
            BeginContext(1640, 40, false);
#line 42 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
 Write(Html.DisplayNameFor(model => model.NOWC));

#line default
#line hidden
            EndContext();
            BeginContext(1680, 110, true);
            WriteLiteral("\r\n  </label>\r\n  <input type=\"text\" name=\"\" id=\"\" class=\"form-control\" placeholder=\"\" aria-describedby=\"helpId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1790, "\"", 1809, 1);
#line 44 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
WriteAttributeValue("", 1798, Model.NOWC, 1798, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1810, 70, true);
            WriteLiteral(" readonly>\r\n</div>\r\n<div class=\"form-group\">\r\n  <label for=\"\">\r\n      ");
            EndContext();
            BeginContext(1881, 40, false);
#line 48 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
 Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1921, 110, true);
            WriteLiteral("\r\n  </label>\r\n  <input type=\"text\" name=\"\" id=\"\" class=\"form-control\" placeholder=\"\" aria-describedby=\"helpId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2031, "\"", 2050, 1);
#line 50 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
WriteAttributeValue("", 2039, Model.Name, 2039, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2051, 70, true);
            WriteLiteral(" readonly>\r\n</div>\r\n<div class=\"form-group\">\r\n  <label for=\"\">\r\n      ");
            EndContext();
            BeginContext(2122, 41, false);
#line 54 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
 Write(Html.DisplayNameFor(model => model.Block));

#line default
#line hidden
            EndContext();
            BeginContext(2163, 110, true);
            WriteLiteral("\r\n  </label>\r\n  <input type=\"text\" name=\"\" id=\"\" class=\"form-control\" placeholder=\"\" aria-describedby=\"helpId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2273, "\"", 2293, 1);
#line 56 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
WriteAttributeValue("", 2281, Model.Block, 2281, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2294, 70, true);
            WriteLiteral(" readonly>\r\n</div>\r\n<div class=\"form-group\">\r\n  <label for=\"\">\r\n      ");
            EndContext();
            BeginContext(2365, 41, false);
#line 60 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
 Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2406, 110, true);
            WriteLiteral("\r\n  </label>\r\n  <input type=\"text\" name=\"\" id=\"\" class=\"form-control\" placeholder=\"\" aria-describedby=\"helpId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2516, "\"", 2536, 1);
#line 62 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
WriteAttributeValue("", 2524, Model.Price, 2524, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2537, 46, true);
            WriteLiteral(" readonly>\r\n</div>\r\n<div class=\"hideable\">\r\n  ");
            EndContext();
            BeginContext(2583, 1156, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17bfdb09ea5a4f648aa6fb93f13d6945", async() => {
                BeginContext(2620, 77, true);
                WriteLiteral("\r\n      <div class=\"form-group\" hidden>\r\n        <label for=\"\">\r\n            ");
                EndContext();
                BeginContext(2698, 45, false);
#line 68 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.LocalCode));

#line default
#line hidden
                EndContext();
                BeginContext(2743, 148, true);
                WriteLiteral("\r\n        </label>\r\n        <input type=\"text\" name=\"ApartmentCode\" id=\"ApartmentCode\" class=\"form-control\" placeholder=\"\" aria-describedby=\"helpId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2891, "\"", 2915, 1);
#line 70 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
WriteAttributeValue("", 2899, Model.LocalCode, 2899, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2916, 816, true);
                WriteLiteral(@" required>
      </div>
      <div class=""form-group"">
        <label>Nhập số cmnd</label>
        <input type=""text"" id=""Cmnd"" name=""Cmnd"" class=""form-control"" placeholder=""cmnd"" aria-describedby=""helpId"" required>
      </div>
      <div class=""form-group"">
        <label>Nhập SĐT</label>
        <input type=""text"" id=""PhoneNumber"" name=""PhoneNumber"" class=""form-control"" placeholder=""sđt"" aria-describedby=""helpId"" required>
      </div>
      <div class=""form-group"">
        <label>Nhập mã</label>
        <input type=""text"" id=""RCode"" name=""RCode"" class=""form-control"" placeholder=""code"" aria-describedby=""helpId"" required>
      </div>
      <!-- <p style=""color: red; font-style: italic"">Lưu ý: Mỗi mã chỉ được sử dụng một lần. Quý khách sẽ không được thay đổi căn sau khi đã chọn</p> -->
  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3739, 800, true);
            WriteLiteral(@"
    <button class=""btn btn-success"" id=""btn"">Xác nhận</button>
</div>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
<script src=""https://unpkg.com/sweetalert/dist/sweetalert.min.js""></script>
<script>
    $('#btn').on('click', function() {
      swal({
      title: ""Bạn có chắc chắn chọn mua căn này?"",
      text: ""Mỗi mã chỉ được sử dụng một lần. Quý khách sẽ không được thay đổi căn sau khi đã chọn!"",
      icon: ""warning"",
      buttons: true,
      dangerMode: true,
    })
    .then((willBuy) => {
      if (willBuy) {
        swal(""Hệ thống đã nhận được yêu cầu của bạn, đang tiến hành xử lý!"", {
          icon: ""success"",
        });
        $('#form').submit();
      } else {
        
      }
    });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookingForm.Models.Apartment> Html { get; private set; }
    }
}
#pragma warning restore 1591
