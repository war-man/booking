#pragma checksum "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Managers\Employee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4f5d3c657b900a72ee0a393c18c82432d64eac3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Managers_Employee), @"mvc.1.0.view", @"/Views/Managers/Employee.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Managers/Employee.cshtml", typeof(AspNetCore.Views_Managers_Employee))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4f5d3c657b900a72ee0a393c18c82432d64eac3", @"/Views/Managers/Employee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a961fb0ce4f853b3e2c4fa2992c1d9302b2824bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Managers_Employee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookingForm.Models.ManagerModal>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("badge badge-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(160, 54, true);
            WriteLiteral("\r\n<div style=\"display:block; height:15px\">\r\n\r\n</div>\r\n");
            EndContext();
#line 8 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Managers\Employee.cshtml"
 foreach (var sale in Model.sales)
{
    if (sale.Email.Equals("khang.trinh@annhome.vn") || sale.Email.Equals("hang.le@annhome.vn"))
    {
        continue;
    }

#line default
#line hidden
            BeginContext(430, 328, true);
            WriteLiteral(@"    <div class=""image-flip"" style=""float:left; width: 33%; height:100%"" ontouchstart=""this.classList.toggle('hover');"">
        <div class=""mainflip"">
            <div style=""float:left; width: 100%; height:100%"" class=""frontside"">
                <div class=""card"">
                    <div class=""card-body text-center"">
");
            EndContext();
#line 20 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Managers\Employee.cshtml"
                          
                            var src = "/images/Profile/profile.png";
                            var signed = false;
                            if (sale.Portrait != null)
                            {
                                var base64 = Convert.ToBase64String(sale.Portrait);
                                src = String.Format("data:image/gif;base64,{0}", base64);
                            }

                        

#line default
#line hidden
            BeginContext(1228, 50, true);
            WriteLiteral("                        <p><img class=\" img-fluid\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1278, "\"", 1288, 1);
#line 30 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Managers\Employee.cshtml"
WriteAttributeValue("", 1284, src, 1284, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1289, 66, true);
            WriteLiteral(" alt=\"photo\"></p>\r\n                        <h4 class=\"card-title\">");
            EndContext();
            BeginContext(1356, 9, false);
#line 31 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Managers\Employee.cshtml"
                                          Write(sale.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1365, 93, true);
            WriteLiteral("</h4>\r\n                        <p class=\"card-text\">\r\n                            Birthday:\r\n");
            EndContext();
#line 34 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Managers\Employee.cshtml"
                             if (sale.DOB != null)
                            {
                                

#line default
#line hidden
            BeginContext(1574, 47, false);
#line 36 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Managers\Employee.cshtml"
                           Write(DateTime.Parse(sale.DOB).ToString("dd-MM-yyyy"));

#line default
#line hidden
            EndContext();
#line 36 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Managers\Employee.cshtml"
                                                                                
                            }

#line default
#line hidden
            BeginContext(1654, 115, true);
            WriteLiteral("                        </p>\r\n                        <p class=\"card-text\">\r\n                            Position: ");
            EndContext();
#line 40 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Managers\Employee.cshtml"
                                       if (sale.Info != null)
                            {
                                if (sale.Info.Contains("-"))
                                {
                                    

#line default
#line hidden
            BeginContext(1959, 23, false);
#line 44 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Managers\Employee.cshtml"
                               Write(sale.Info.Split("-")[1]);

#line default
#line hidden
            EndContext();
#line 44 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Managers\Employee.cshtml"
                                                            ;
                                }
                                else
                                {
                                    

#line default
#line hidden
            BeginContext(2130, 9, false);
#line 48 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Managers\Employee.cshtml"
                               Write(sale.Info);

#line default
#line hidden
            EndContext();
#line 48 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Managers\Employee.cshtml"
                                              ;
                                }
                            }

#line default
#line hidden
            BeginContext(2208, 91, true);
            WriteLiteral("                        </p>\r\n                        <p class=\"card-text\">Contact number: ");
            EndContext();
            BeginContext(2300, 16, false);
#line 52 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Managers\Employee.cshtml"
                                                        Write(sale.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2316, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
            BeginContext(2425, 391, true);
            WriteLiteral(@"                    </div>
                </div>
            </div>
            <div style=""float:left; width: 100%; height:100%"" class=""backside"">
                <div class=""card"">
                    <div class=""card-body text-center mt-4"">
                        <h4 class=""card-title"">Thông tin booking</h4>
                        <p>(confirmed / unconfirmed / canceled)</p>
");
            EndContext();
#line 62 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Managers\Employee.cshtml"
                          
                            bool DatesAreInTheSameWeek(DateTime date1, DateTime date2)
                            {
                                var cal = System.Globalization.DateTimeFormatInfo.CurrentInfo.Calendar;
                                var da1 = date1.Date.AddDays(-1 * (int)cal.GetDayOfWeek(date1));
                                var da2 = date2.Date.AddDays(-1 * (int)cal.GetDayOfWeek(date2));

                                return da1 == da2;
                            }
                        

#line default
#line hidden
            BeginContext(3376, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 72 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Managers\Employee.cshtml"
                           int d1, d2, d3, w1, w2, w3, m1, m2, m3 = 0;
                            d1 = Model.appoinments.Count(m => m.SEmail == sale.Email && m.Confirm == true && m.IsActive == true && m.cTime.Contains(DateTime.Now.Date.ToString("ddMMyyyy")));
                            d2 = Model.appoinments.Count(m => m.SEmail == sale.Email && m.Confirm == false && m.IsActive == true && m.cTime.Contains(DateTime.Now.Date.ToString("ddMMyyyy")));
                            d3 = Model.appoinments.Count(m => m.SEmail == sale.Email && m.Confirm == true && m.IsActive == false && m.WDay.Date == DateTime.Now.Date);
                            w1 = Model.appoinments.Count(m => m.SEmail == sale.Email && m.Confirm == true && m.IsActive == true && DatesAreInTheSameWeek(DateTime.Now.Date, DateTime.ParseExact(m.cTime, "ddMMyyyy HH:mm:ss.FFFFFFF", null)));
                            w2 = Model.appoinments.Count(m => m.SEmail == sale.Email && m.Confirm == false && m.IsActive == true && DatesAreInTheSameWeek(DateTime.Now.Date, DateTime.ParseExact(m.cTime, "ddMMyyyy HH:mm:ss.FFFFFFF", null)));
                            w3 = Model.appoinments.Count(m => m.SEmail == sale.Email && m.Confirm == true && m.IsActive == false && m.WDay.Date.Year != 1 && DatesAreInTheSameWeek(DateTime.Now.Date, m.WDay.Date));
                            m1 = Model.appoinments.Count(m => m.SEmail == sale.Email && m.Confirm == true && m.IsActive == true && m.cTime.Substring(2, 6).Contains(DateTime.Now.ToString("MMyyyy")));
                            m2 = Model.appoinments.Count(m => m.SEmail == sale.Email && m.Confirm == false && m.IsActive == true && m.cTime.Substring(2, 6).Contains(DateTime.Now.ToString("MMyyyy")));
                            m3 = Model.appoinments.Count(m => m.SEmail == sale.Email && m.Confirm == true && m.IsActive == false && m.WDay.Date.Month == DateTime.Now.Date.Month && m.WDay.Date.Year == DateTime.Now.Date.Year);
                            double cash = Model.appoinments.Where(m => m.SEmail == sale.Email && m.Confirm == true && m.IsActive == true && m.cTime.Contains(DateTime.Now.Date.ToString("ddMMyyyy"))).Sum(m => m.Cash);
                            cash -= Model.appoinments.Where(m => m.SEmail == sale.Email && m.Confirm == true && m.IsActive == false && m.cTime.Contains(DateTime.Now.Date.ToString("ddMMyyyy"))).Sum(m => m.Cash);
                        

#line default
#line hidden
            BeginContext(5777, 68, true);
            WriteLiteral("                        <ul>\r\n                            <li>Ngày: ");
            EndContext();
            BeginContext(5846, 2, false);
#line 86 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Managers\Employee.cshtml"
                                 Write(d1);

#line default
#line hidden
            EndContext();
            BeginContext(5848, 4, true);
            WriteLiteral("  / ");
            EndContext();
            BeginContext(5853, 2, false);
#line 86 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Managers\Employee.cshtml"
                                        Write(d2);

#line default
#line hidden
            EndContext();
            BeginContext(5855, 4, true);
            WriteLiteral("  / ");
            EndContext();
            BeginContext(5860, 2, false);
#line 86 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Managers\Employee.cshtml"
                                               Write(d3);

#line default
#line hidden
            EndContext();
            BeginContext(5862, 45, true);
            WriteLiteral("</li>\r\n                            <li>Tuần: ");
            EndContext();
            BeginContext(5908, 2, false);
#line 87 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Managers\Employee.cshtml"
                                 Write(w1);

#line default
#line hidden
            EndContext();
            BeginContext(5910, 4, true);
            WriteLiteral("  / ");
            EndContext();
            BeginContext(5915, 2, false);
#line 87 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Managers\Employee.cshtml"
                                        Write(w2);

#line default
#line hidden
            EndContext();
            BeginContext(5917, 4, true);
            WriteLiteral("  / ");
            EndContext();
            BeginContext(5922, 2, false);
#line 87 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Managers\Employee.cshtml"
                                               Write(w3);

#line default
#line hidden
            EndContext();
            BeginContext(5924, 46, true);
            WriteLiteral("</li>\r\n                            <li>Tháng: ");
            EndContext();
            BeginContext(5971, 2, false);
#line 88 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Managers\Employee.cshtml"
                                  Write(m1);

#line default
#line hidden
            EndContext();
            BeginContext(5973, 4, true);
            WriteLiteral("  / ");
            EndContext();
            BeginContext(5978, 2, false);
#line 88 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Managers\Employee.cshtml"
                                         Write(m2);

#line default
#line hidden
            EndContext();
            BeginContext(5980, 4, true);
            WriteLiteral("  / ");
            EndContext();
            BeginContext(5985, 2, false);
#line 88 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Managers\Employee.cshtml"
                                                Write(m3);

#line default
#line hidden
            EndContext();
            BeginContext(5987, 89, true);
            WriteLiteral("</li>\r\n                        </ul>\r\n                        <p>Tổng tiền (trong ngày): ");
            EndContext();
            BeginContext(6077, 29, false);
#line 90 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Managers\Employee.cshtml"
                                              Write(String.Format("{0:N0}", cash));

#line default
#line hidden
            EndContext();
            BeginContext(6106, 35, true);
            WriteLiteral(" vnđ.</p>\r\n                        ");
            EndContext();
            BeginContext(6141, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "445a395fe50f4623ab08245993503f83", async() => {
                BeginContext(6216, 8, true);
                WriteLiteral("Chi tiết");
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
#line 91 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Managers\Employee.cshtml"
                                                    WriteLiteral(sale.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6228, 1365, true);
            WriteLiteral(@"
                        <ul class=""list-inline"">
                            <li class=""list-inline-item"">
                                <a class=""social-icon text-xs-center"" target=""_blank"" href=""#"">
                                    <i class=""fa fa-facebook""></i>
                                </a>
                            </li>
                            <li class=""list-inline-item"">
                                <a class=""social-icon text-xs-center"" target=""_blank"" href=""#"">
                                    <i class=""fa fa-twitter""></i>
                                </a>
                            </li>
                            <li class=""list-inline-item"">
                                <a class=""social-icon text-xs-center"" target=""_blank"" href=""#"">
                                    <i class=""fa fa-skype""></i>
                                </a>
                            </li>
                            <li class=""list-inline-item"">
                          ");
            WriteLiteral(@"      <a class=""social-icon text-xs-center"" target=""_blank"" href=""#"">
                                    <i class=""fa fa-google""></i>
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
            EndContext();
#line 119 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Managers\Employee.cshtml"
}

#line default
#line hidden
            BeginContext(7596, 3178, true);
            WriteLiteral(@"
<style>
    /* FontAwesome for working BootSnippet :> */
#team {
    background: #eee !important;
}

.btn-primary:hover,
.btn-primary:focus {
    background-color: #108d6f;
    border-color: #108d6f;
    box-shadow: none;
    outline: none;
}

.btn-primary {
    color: #fff;
    background-color: #007b5e;
    border-color: #007b5e;
}

section {
    padding: 60px 0;
}

section .section-title {
    text-align: center;
    color: #007b5e;
    margin-bottom: 50px;
    text-transform: uppercase;
}

#team .card {
    border: none;
    background: #ffffff;
}

    .image-flip:hover .backside,
    .image-flip.hover .backside {
        -webkit-transform: rotateY(0deg);
        -moz-transform: rotateY(0deg);
        -o-transform: rotateY(0deg);
        -ms-transform: rotateY(0deg);
        transform: rotateY(0deg);
        border-radius: .25rem;
       
    }

.image-flip:hover .frontside,
.image-flip.hover .frontside {
    -webkit-transform: rotateY(180deg);
    -moz-");
            WriteLiteral(@"transform: rotateY(180deg);
    -o-transform: rotateY(180deg);
    transform: rotateY(180deg);
}

.mainflip {
    -webkit-transition: 1s;
    -webkit-transform-style: preserve-3d;
    -ms-transition: 1s;
    -moz-transition: 1s;
    -moz-transform: perspective(1000px);
    -moz-transform-style: preserve-3d;
    -ms-transform-style: preserve-3d;
    transition: 1s;
    transform-style: preserve-3d;
    position: relative;
}

    .frontside {
        position: relative;
        -webkit-transform: rotateY(0deg);
        -ms-transform: rotateY(0deg);
        z-index: 2;
        margin-bottom: 30px;
        margin-left: 1.5%;
        margin-right: 1.5%;
    }

    .backside {
        position: absolute;
        top: 0;
        left: 0;
        background: white;
        -webkit-transform: rotateY(-180deg);
        -moz-transform: rotateY(-180deg);
        -o-transform: rotateY(-180deg);
        -ms-transform: rotateY(-180deg);
        transform: rotateY(-180deg);
        -webk");
            WriteLiteral(@"it-box-shadow: 5px 7px 9px -4px rgb(158, 158, 158);
        -moz-box-shadow: 5px 7px 9px -4px rgb(158, 158, 158);
        box-shadow: 5px 7px 9px -4px rgb(158, 158, 158);
        margin-bottom: 30px;
        margin-left: 1.5%;
        margin-right: 1.5%;
    }

.frontside,
.backside {
    -webkit-backface-visibility: hidden;
    -moz-backface-visibility: hidden;
    -ms-backface-visibility: hidden;
    backface-visibility: hidden;
    -webkit-transition: 1s;
    -webkit-transform-style: preserve-3d;
    -moz-transition: 1s;
    -moz-transform-style: preserve-3d;
    -o-transition: 1s;
    -o-transform-style: preserve-3d;
    -ms-transition: 1s;
    -ms-transform-style: preserve-3d;
    transition: 1s;
    transform-style: preserve-3d;
}

.frontside .card,
.backside .card {
    min-height: 312px;
}

.backside .card a {
    font-size: 18px;
    color: #007b5e !important;
}

.frontside .card .card-title,
.backside .card .card-title {
    color: #007b5e !important;
}

.fro");
            WriteLiteral("ntside .card .card-body img {\r\n    width: 120px;\r\n    height: 120px;\r\n    border-radius: 50%;\r\n}\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookingForm.Models.ManagerModal> Html { get; private set; }
    }
}
#pragma warning restore 1591
