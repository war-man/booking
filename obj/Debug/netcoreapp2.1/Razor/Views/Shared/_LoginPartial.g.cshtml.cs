#pragma checksum "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Shared\_LoginPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7a90cbb43c19c2e17db23c32671e482d1db05c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LoginPartial), @"mvc.1.0.view", @"/Views/Shared/_LoginPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_LoginPartial.cshtml", typeof(AspNetCore.Views_Shared__LoginPartial))]
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
#line 1 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Shared\_LoginPartial.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7a90cbb43c19c2e17db23c32671e482d1db05c3", @"/Views/Shared/_LoginPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a961fb0ce4f853b3e2c4fa2992c1d9302b2824bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LoginPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Manage/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Manage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("logoutForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(159, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Shared\_LoginPartial.cshtml"
  
    var src = "/images/Profile/profile.png";
    var signed = false;
    if (SignInManager.IsSignedIn(User))
    {
        signed = true;
        var curUser = await UserManager.GetUserAsync(User);
        if (curUser.Portrait != null)
        {
            var base64 = Convert.ToBase64String(curUser.Portrait);
            src = String.Format("data:image/gif;base64,{0}", base64);
        }
    }



#line default
#line hidden
            BeginContext(583, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 23 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Shared\_LoginPartial.cshtml"
 if (SignInManager.IsSignedIn(User))
{


#line default
#line hidden
            BeginContext(628, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(632, 4311, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0004da0ae1d470a8b7ec3cb4cdcbee5", async() => {
                BeginContext(797, 81, true);
                WriteLiteral("\r\n         \r\n        <ul class=\"nav navbar-nav navbar-right\">\r\n            <li>\r\n");
                EndContext();
                BeginContext(1012, 258, true);
                WriteLiteral(@"                <div class=""dropdown"">
                    <button class=""btn btn-outline-light dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        <img id=""imgh""");
                EndContext();
                BeginWriteAttribute("src", " src=", 1270, "", 1279, 1);
#line 33 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Shared\_LoginPartial.cshtml"
WriteAttributeValue("", 1275, src, 1275, 4, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1279, 272, true);
                WriteLiteral(@" style=""margin-top:1px; width:42px;height:42px;border-radius:50%;transition: .5s ease;backface-visibility: hidden; border:0"" />
                    </button>

                    <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
                        ");
                EndContext();
                BeginContext(1551, 160, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74a039cfd65542f6bcb4af305db0752d", async() => {
                    BeginContext(1644, 63, true);
                    WriteLiteral("\r\n                            Profile\r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1711, 64, true);
                WriteLiteral("\r\n                        <div class=\"dropdown-divider\"></div>\r\n");
                EndContext();
#line 41 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Shared\_LoginPartial.cshtml"
                          
                            if (User.IsInRole("Manager"))
                            {

#line default
#line hidden
                BeginContext(1893, 265, true);
                WriteLiteral(@"                                <a class=""dropdown-item"" href=""#"">Manager</a>
                                <a class=""dropdown-item"" href=""/Admin/Dashboard"">Administrator</a>
                                <a class=""dropdown-item"" href=""/Home/Dashboard""></a>
");
                EndContext();
                BeginContext(2243, 323, true);
                WriteLiteral(@"                                <div class=""dropdown-divider""></div>
                                <h5 class=""dropdown-header"">Help</h5>
                                <a class=""dropdown-item"" href=""/Admin/Tutor"">Administrator</a>
                                <a class=""dropdown-item"" href=""/Home/Tutor"">Sale</a>
");
                EndContext();
#line 53 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Shared\_LoginPartial.cshtml"

                            }
                            else if (User.IsInRole("Administrator"))
                            {

#line default
#line hidden
                BeginContext(2700, 514, true);
                WriteLiteral(@"                                <a class=""dropdown-item"" href=""/Admin/Dashboard"">Manager</a>
                                <a class=""dropdown-item"" href=""/Home/Dashboard"">Appointment</a>
                                <div class=""dropdown-divider""></div>
                                <h5 class=""dropdown-header"">Help</h5>
                                <a class=""dropdown-item"" href=""/Admin/Tutor"">Administrator</a>
                                <a class=""dropdown-item"" href=""/Home/Tutor"">Sale</a>
");
                EndContext();
#line 63 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Shared\_LoginPartial.cshtml"

                            }
                            else if (User.IsInRole("Leader") || User.IsInRole("TeamLeader"))
                            {

#line default
#line hidden
                BeginContext(3372, 343, true);
                WriteLiteral(@"                                <a class=""dropdown-item"" href=""/Home/Dashboard"">Appointment</a>
                                <a class=""dropdown-item"" href=""/Home/Manager"">Manager</a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""Home/Tutor"">Help</a>
");
                EndContext();
#line 71 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Shared\_LoginPartial.cshtml"
                            }
                            else if (User.IsInRole("Sale"))
                            {

#line default
#line hidden
                BeginContext(3838, 253, true);
                WriteLiteral("                                <a class=\"dropdown-item\" href=\"/Home/Dashboard\">Appointment</a>\r\n                                <div class=\"dropdown-divider\"></div>\r\n                                <a class=\"dropdown-item\" href=\"/Home/Tutor\">Help</a>\r\n");
                EndContext();
#line 77 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Shared\_LoginPartial.cshtml"
                            }
                            else if (User.IsInRole("TelSale"))
                            {

#line default
#line hidden
                BeginContext(4217, 225, true);
                WriteLiteral("                                <a class=\"dropdown-item\" href=\"#\">Contact</a>\r\n                                <div class=\"dropdown-divider\"></div>\r\n                                <a class=\"dropdown-item\" href=\"#\">Help</a>\r\n");
                EndContext();
#line 83 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Shared\_LoginPartial.cshtml"
                            }
                        

#line default
#line hidden
                BeginContext(4500, 436, true);
                WriteLiteral(@"                        <div class=""dropdown-divider""></div>
                        <a class=""dropdown-item"" href=""/Home/Feedback"">Feedback</a>
                        <div class=""dropdown-divider""></div>
                        <button type=""submit"" class=""btn btn-link dropdown-item"">Logout</button>
                    </div>
                </div>


            </li>
            <li>

            </li>
        </ul>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 26 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Shared\_LoginPartial.cshtml"
                                                                  WriteLiteral(Url.Page("/Index", new { area = "" }));

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4943, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 99 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Shared\_LoginPartial.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(4957, 85, true);
            WriteLiteral("    <ul class=\"nav navbar-nav navbar-right\">\r\n        <li style=\"margin-right: 30px\">");
            EndContext();
            BeginContext(5042, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5f7d3d77c494f44b9441e59179da4da", async() => {
                BeginContext(5094, 7, true);
                WriteLiteral("Đăng ký");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5105, 46, true);
            WriteLiteral("</li>\r\n        <li style=\"margin-right: 30px\">");
            EndContext();
            BeginContext(5151, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97b11f2908244b32a93097a96729f4e9", async() => {
                BeginContext(5200, 9, true);
                WriteLiteral("Đăng nhập");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5213, 18, true);
            WriteLiteral("</li>\r\n    </ul>\r\n");
            EndContext();
#line 106 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Shared\_LoginPartial.cshtml"
}

#line default
#line hidden
            BeginContext(5234, 600, true);
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js""></script>
<script>
    function readURL(input) {

        if (input.files && input.files[0]) {
            var reader = new FileReader();

            reader.onload = function (e) {
                $('#imgh').attr('src', e.target.result);
            }

            reader.readAsDataURL(input.files[0]);
        }
    }
    $(function () {
        var tmp = '<% signed %>';
        if (!tmp) {
            $('body').css('background-image', 'url(christmas.jpg)');
        }
        
    })
</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public RoleManager<Role> RoleManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<Sale> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<Sale> SignInManager { get; private set; }
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
