#pragma checksum "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "055450dd3ef7ebfe56d0b5ff171db81abdda7764"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Appoinments_Print), @"mvc.1.0.view", @"/Views/Appoinments/Print.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Appoinments/Print.cshtml", typeof(AspNetCore.Views_Appoinments_Print))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"055450dd3ef7ebfe56d0b5ff171db81abdda7764", @"/Views/Appoinments/Print.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a961fb0ce4f853b3e2c4fa2992c1d9302b2824bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Appoinments_Print : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookingForm.Models.Appoinment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:block;margin-left:auto;margin-right:auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/images/logo.png", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
  
    ViewData["Title"] = "HĐ bản in -";

#line default
#line hidden
            BeginContext(85, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "33c1936c5e854e43b4193505a7a7e380", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 5 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(200, 193, true);
            WriteLiteral("\r\n<div>\r\n    <h4 style=\"font-weight:bold;text-align:center\">PHIẾU ĐĂNG KÝ GIỮ CHỖ - DỰ ÁN VINHOMNES GRAND PARK</h4>\r\n    <p style=\"font-style:italic; font-weight:bold; text-align:center\">( Số: ");
            EndContext();
            BeginContext(394, 14, false);
#line 8 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
                                                                       Write(Model.Contract);

#line default
#line hidden
            EndContext();
            BeginContext(408, 24, true);
            WriteLiteral("/2019/DKGC-VINGP )</p>\r\n");
            EndContext();
#line 9 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
      
        string day, month, year = "";
        try
        {
            DateTime d = DateTime.ParseExact(Model.cTime, "ddMMyyyy HH:mm:ss.FFFFFFF",
                             System.Globalization.CultureInfo.InvariantCulture);
            day = Convert.ToString(d.Day);
            month = Convert.ToString(d.Month);
            year = Convert.ToString(d.Year);
        }
        catch (Exception)
        {

            day = "...";
            month = "...";
            year = "...";
        }

    

#line default
#line hidden
            BeginContext(963, 74, true);
            WriteLiteral("    <h6 style=\"font-style:italic; text-align:right\">TP. Hồ Chí Minh, ngày ");
            EndContext();
            BeginContext(1038, 3, false);
#line 28 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
                                                                     Write(day);

#line default
#line hidden
            EndContext();
            BeginContext(1041, 8, true);
            WriteLiteral("  tháng ");
            EndContext();
            BeginContext(1050, 5, false);
#line 28 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
                                                                                 Write(month);

#line default
#line hidden
            EndContext();
            BeginContext(1055, 5, true);
            WriteLiteral(" năm ");
            EndContext();
            BeginContext(1061, 4, false);
#line 28 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
                                                                                            Write(year);

#line default
#line hidden
            EndContext();
            BeginContext(1065, 985, true);
            WriteLiteral(@"</h6>
    <h5 style=""font-weight:bold; text-align:left"">BÊN A: CÔNG TY CỔ PHẦN NHÀ ANN HOME</h5>
    <p>Chi nhánh	:	311 K25 đường số 8, khu phố 1, phường An Phú, Quận 2, TP. Hồ Chí Minh</p>
    <p>
        Đ/c giao dịch	:	Khu nhà mẫu Vinhomes Grand Park, tầng 3 Vincom Mega Mall, Quận 2, TP.HCM
    </p>
    <p>Mã số thuế	:	0314251205</p>
    <p style=""display: inline;"">Đại diện bởi  	:</p><p style=""display: inline; font-weight: bold;"">	Bà Lê Thị Thu Hằng<span style=""display:inline-block; width: 100px;""></span></p><p style=""display:inline;"">Chức vụ:  	Tổng Giám Đốc</p>
    <p>Điện thoại	:	0867.3014.666<span style=""display:inline-block; width: 150px;""></span>Hotline: 0902 969 169</p>
    <p>Email	:	hello@annhome.vn<span style=""display:inline-block; width: 150px;""></span>Website: https://www.annhome.vn</p>
    <p style=""font-style:italic"">(Sau đây gọi là Bên A)</p>
    <h5 style=""font-weight:bold; text-align:left"">BÊN B: THÔNG TIN KHÁCH HÀNG</h5>
    <p>Ông/bà	: ");
            EndContext();
            BeginContext(2051, 40, false);
#line 40 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
              Write(Html.DisplayFor(model => model.Customer));

#line default
#line hidden
            EndContext();
            BeginContext(2091, 34, true);
            WriteLiteral("</p>\r\n    <p>Số CMND (hộ chiếu)\t: ");
            EndContext();
            BeginContext(2126, 36, false);
#line 41 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
                          Write(Html.DisplayFor(model => model.Cmnd));

#line default
#line hidden
            EndContext();
            BeginContext(2162, 67, true);
            WriteLiteral("\t<span style=\"display:inline-block; width: 70px;\"></span>Ngày cấp: ");
            EndContext();
            BeginContext(2230, 35, false);
#line 41 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
                                                                                                                                     Write(Html.DisplayFor(model => model.Day));

#line default
#line hidden
            EndContext();
            BeginContext(2265, 65, true);
            WriteLiteral("<span style=\"display:inline-block; width: 70px;\"></span>Nơi cấp:\t");
            EndContext();
            BeginContext(2331, 37, false);
#line 41 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
                                                                                                                                                                                                                                             Write(Html.DisplayFor(model => model.Place));

#line default
#line hidden
            EndContext();
            BeginContext(2368, 34, true);
            WriteLiteral("</p>\r\n    <p>Hộ khẩu thường trú\t: ");
            EndContext();
            BeginContext(2403, 36, false);
#line 42 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
                          Write(Html.DisplayFor(model => model.HKTT));

#line default
#line hidden
            EndContext();
            BeginContext(2439, 31, true);
            WriteLiteral("</p>\r\n    <p>Địa chỉ liên hệ\t: ");
            EndContext();
            BeginContext(2471, 39, false);
#line 43 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
                       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(2510, 26, true);
            WriteLiteral("</p>\r\n    <p>Điện thoại\t: ");
            EndContext();
            BeginContext(2537, 37, false);
#line 44 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
                  Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(2574, 21, true);
            WriteLiteral("</p>\r\n    <p>Email\t: ");
            EndContext();
            BeginContext(2596, 37, false);
#line 45 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
             Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2633, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 46 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
      
        string borrow = "Nhu cầu vay NH: ";
        if (Model.Price > 0)
        {
            borrow += "Có   Số tiền: " + string.Format("{0:N0}", Model.Price) + " VNĐ";
        }
        else
        {
            borrow += "Không";
        }
    

#line default
#line hidden
            BeginContext(2908, 17, true);
            WriteLiteral("    <p>\r\n        ");
            EndContext();
            BeginContext(2926, 16, false);
#line 58 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
   Write(Html.Raw(borrow));

#line default
#line hidden
            EndContext();
            BeginContext(2942, 669, true);
            WriteLiteral(@"
    </p>
    <p>Khả năng thanh toán: Thanh toán 100% / Thanh toán theo tiến độ</p>
    <p style=""font-style:italic"">(Sau đây gọi là Bên B)</p>
    <p>Các Bên thống nhất lập và ký kết phiếu đăng ký giữ chỗ này sau khi có xác nhận bên B thanh toán đầy đủ số tiền giữ chỗ cho bên A thông qua chuyển khoản hoặc tiền mặt để đảm bảo việc tham gia đăng ký mua sản phẩm bất động sản tại Dự Án Vinhomes Grand Park Quận 9 với các nội dung sau đây:</p>
    <h5 style=""font-weight:bold"">Điều 1. Nội dung thỏa thuận</h5>
    <p style=""font-weight:bold"">1.1.	Thông tin loại sản phẩm bất động sản đăng ký tham gia chọn mua:</p>
    <ul style=""list-style-type: lower-alpha;"">
");
            EndContext();
#line 66 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
          
            var str = "";
            if (@Model.NCH1 != 0)
            {
                str += "<li><p style=\"font-weight:bold\">Căn Hộ 1 phòng ngủ:</p><p>-	Số lượng căn: 0" + @Model.NCH1 + "……………Tầng:………………</p><p>-	Hướng  ………………    View………………</p></li>";
            }
            if (@Model.NCH2 != 0)
            {
                str += "<li><p style=\"font-weight:bold\">Căn Hộ 2 phòng ngủ 1 phòng vệ sinh:</p><p>-	Số lượng căn: 0" + @Model.NCH2 + "……………Tầng:………………</p><p>-	Hướng  ………………    View………………</p></li>";
            }
            if (@Model.NCH21 != 0)
            {
                str += "<li><p style=\"font-weight:bold\">Căn Hộ 2 phòng ngủ 2 phòng vệ sinh:</p><p>-	Số lượng căn: 0" + @Model.NCH21 + "……………Tầng:………………</p><p>-	Hướng  ………………    View………………</p></li>";
            }
            if (@Model.NCH3 != 0)
            {
                str += "<li><p style=\"font-weight:bold\">Căn Hộ 3 phòng ngủ:</p><p>-	Số lượng căn: 0" + @Model.NCH3 + "……………Tầng:………………</p><p>-	Hướng  ………………    View………………</p></li>";
            }
        

#line default
#line hidden
            BeginContext(4695, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(4704, 13, false);
#line 85 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
   Write(Html.Raw(str));

#line default
#line hidden
            EndContext();
            BeginContext(4717, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 86 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
          
            if (Model.NSH > 0)
            {

#line default
#line hidden
            BeginContext(4778, 238, true);
            WriteLiteral("                <li>\r\n                    <p style=\"font-weight:bold\">\r\n                        Biệt thự đơn lập:\r\n                    </p><p style=\"display:inline\">-\tSố lượng căn: 0</p><p style=\"display:inline\">\r\n                        ");
            EndContext();
            BeginContext(5017, 9, false);
#line 93 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
                   Write(Model.NSH);

#line default
#line hidden
            EndContext();
            BeginContext(5026, 147, true);
            WriteLiteral("……………Hướng:……………    View: ……………………\r\n                    </p>\r\n                </li>\r\n                <spans style=\"display:inline-block\"></spans>\r\n");
            EndContext();
#line 97 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
            }
            if (Model.NSH1 > 0)
            {

#line default
#line hidden
            BeginContext(5236, 239, true);
            WriteLiteral("                <li>\r\n                    <p style=\"font-weight:bold\">\r\n                        Biệt thự song lập:\r\n                    </p><p style=\"display:inline\">-\tSố lượng căn: 0</p><p style=\"display:inline\">\r\n                        ");
            EndContext();
            BeginContext(5476, 10, false);
#line 104 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
                   Write(Model.NSH1);

#line default
#line hidden
            EndContext();
            BeginContext(5486, 147, true);
            WriteLiteral("……………Hướng:……………    View: ……………………\r\n                    </p>\r\n                </li>\r\n                <spans style=\"display:inline-block\"></spans>\r\n");
            EndContext();
#line 108 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
            }
            if (Model.NSHH > 0)
            {

#line default
#line hidden
            BeginContext(5696, 238, true);
            WriteLiteral("                <li>\r\n                    <p style=\"font-weight:bold\">\r\n                        Shophouse (NPTM):\r\n                    </p><p style=\"display:inline\">-\tSố lượng căn: 0</p><p style=\"display:inline\">\r\n                        ");
            EndContext();
            BeginContext(5935, 10, false);
#line 115 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
                   Write(Model.NSHH);

#line default
#line hidden
            EndContext();
            BeginContext(5945, 147, true);
            WriteLiteral("……………Hướng:……………    View: ……………………\r\n                    </p>\r\n                </li>\r\n                <spans style=\"display:inline-block\"></spans>\r\n");
            EndContext();
#line 119 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
            }
            if (Model.NS > 0)
            {

#line default
#line hidden
            BeginContext(6153, 242, true);
            WriteLiteral("                <li>\r\n                    <p style=\"font-weight:bold\">\r\n                        Shop (kios chung cư):\r\n                    </p><p style=\"display:inline\">-\tSố lượng căn: 0</p><p style=\"display:inline\">\r\n                        ");
            EndContext();
            BeginContext(6396, 8, false);
#line 126 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
                   Write(Model.NS);

#line default
#line hidden
            EndContext();
            BeginContext(6404, 147, true);
            WriteLiteral("……………Hướng:……………    View: ……………………\r\n                    </p>\r\n                </li>\r\n                <spans style=\"display:inline-block\"></spans>\r\n");
            EndContext();
#line 130 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
            }
            if (Model.NMS > 0)
            {

#line default
#line hidden
            BeginContext(6613, 230, true);
            WriteLiteral("                <li>\r\n                    <p style=\"font-weight:bold\">\r\n                        Dinh thự:\r\n                    </p><p style=\"display:inline\">-\tSố lượng căn: 0</p><p style=\"display:inline\">\r\n                        ");
            EndContext();
            BeginContext(6844, 9, false);
#line 137 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
                   Write(Model.NMS);

#line default
#line hidden
            EndContext();
            BeginContext(6853, 85, true);
            WriteLiteral("……………Hướng:……………    View: ……………………\r\n                    </p>\r\n                </li>\r\n");
            EndContext();
#line 140 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
            }
        

#line default
#line hidden
            BeginContext(6964, 80, true);
            WriteLiteral("    </ul>\r\n    <p style=\"font-weight:bold\">1.2.\tSố tiền giữ chỗ đặt mua: &nbsp; ");
            EndContext();
            BeginContext(7045, 17, false);
#line 143 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
                                                                   Write(ViewBag.New_Money);

#line default
#line hidden
            EndContext();
            BeginContext(7062, 32, true);
            WriteLiteral("</p>\r\n    <p>( Bằng chữ: &nbsp; ");
            EndContext();
            BeginContext(7095, 21, false);
#line 144 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
                     Write(ViewBag.Money_Letters);

#line default
#line hidden
            EndContext();
            BeginContext(7116, 3191, true);
            WriteLiteral(@" )</p>
    <p>Thời gian tính quyền ưu tiên của khách hàng sẽ căn cứ vào phiếu thu tiền mặt hoặc ủy nhiệm chi chuyển khoản</p>
    <h5 style=""font-weight:bold"">Điều 2.	Phương thức thanh toán</h5>
    <p>
        -	Bên B thanh toán số tiền đăng ký giữ chỗ nêu trên bằng tiền mặt hoặc chuyển khoản vào tài khoản Ngân hàng sau đây:
    <p style=""display:inline"">-	Tên tài khoản:</p><p style=""display:inline; font-weight:bold;""> Công ty Cổ Phần Nhà ANN HOME</p>
    <p style=""font-weight:bold; text-decoration:underline;"">
        Tại NH TMCP Việt Nam Thương Tín (Vietbank)
    </p>
    <ul style=""list-style:none;"">
        <li>
            <p style=""display:inline""><span style=""font-family:Wingdings"">&#x00d8;</span>	Số tài khoản<span style=""display:inline-block; width: 60px;""></span>:</p>
            <p style=""display:inline; font-weight:bold""> 14206377</p>
        </li>
        <li>
            <p style=""display:inline""><span style=""font-family:Wingdings"">&#x00d8;</span>	Tên Ngân hàng<span style=""display");
            WriteLiteral(@":inline-block; width: 41px;""></span>:</p>
            <p style=""display:inline; font-weight:bold""> Vietbank – CN Võ Văn Ngân - TP HCM</p>
        </li>
    </ul>
    <p style=""font-weight:bold; text-decoration:underline;"">Tại NH TMCP Ngoại Thương Việt Nam (Vietcombank)</p>
    <ul style=""list-style:none"">
        <li>
            <p style=""display:inline""><span style=""font-family:Wingdings"">&#x00d8;</span>	Số tài khoản<span style=""display:inline-block; width: 60px;""></span>:</p>
            <p style=""display:inline; font-weight:bold""> 0371000471407</p>
        </li>
        <li>
            <p style=""display:inline""><span style=""font-family:Wingdings"">&#x00d8;</span>	Tên Ngân hàng<span style=""display:inline-block; width: 41px;""></span>:</p>
            <p style=""display:inline; font-weight:bold""> Vietcombank - CN Tân Định - TP HCM</p>
        </li>
    </ul>
    <p style=""display:inline"">-	Nội dung: </p><p style=""display:inline; font-weight:bold;"">[Tên khách hàng] giữ chỗ [SL] [Sản phẩm] Vinhom");
            WriteLiteral(@"es Grand Park</p>
    <h5 style=""font-weight:bold"">Điều 3.	Điều khoản chung</h5><p>
        <ul class=""dashed"">
            <li>
                Phiếu đăng ký giữ chỗ này không phải là phiếu đặt cọc, không có giá trị pháp lý thay thế phiếu đặt cọc.
            </li>
            <li>
                Với phiếu đăng ký giữ chỗ này, Bên A nhận lời đặt giữ chỗ căn hộ nêu trên cho Bên B khi Chủ đầu tư mở bán chính thức. Bên A sẽ thông báo giá bán chính thức tới Bên B khi thỏa mãn các điều khoản của Chủ đầu tư và giá trị giữ chỗ sẽ trở thành tiền đặt cọc.
            </li>
            <li>
                Nếu bên B không đồng ý với giá bán căn hộ Chủ đầu đưa ra thì Bên A sẽ trả lại toàn bộ giá trị giữ chỗ cho Bên B trong vòng 07 ngày làm việc.
            </li>
            <li>
                Phiếu giữ chỗ này không còn giá trị khi bên B đã chính thức chuyển sang ký hợp đồng đặt cọc với chủ đầu tư.
            </li>
            <li>
                Phiếu này được lập thành 02 (hai) bản và có giá trị");
            WriteLiteral(" như nhau. Bên A giữ 01 bản, Bên B giữ 01 bản để làm cơ sở thực hiện.\r\n            </li>\r\n        </ul>\r\n\r\n\r\n    </p>\r\n");
            EndContext();
            BeginContext(11406, 616, true);
            WriteLiteral(@"
    <span style=""display:inline-block; width:13.6%""></span><h5 style=""text-align: left; width:35%; display: inline-block;font-weight:bold;"">ĐẠI DIỆN BÊN A</h5>
    <h5 style=""text-align: right; width:35%;  display: inline-block;font-weight:bold;"">ĐẠI DIỆN BÊN B</h5>
    <br />
    <span style=""display:inline-block; width:12.5%""></span><p style=""text-align: left;font-style:italic; width:35%; display: inline-block;"">(ký và ghi rõ họ tên)</p>
    <span style=""display:inline-block; width:2%""></span><p style=""text-align: right;font-style:italic; width:35%;  display: inline-block;"">(ký và ghi rõ họ tên)</p>
");
            EndContext();
            BeginContext(12776, 358, true);
            WriteLiteral(@"    <span style=""display:block; height: 119px;""></span>
    <span style=""display:inline-block; width:12.5%""></span><h5 style=""text-align: left; width:35%; display: inline-block;font-weight:bold;"">LÊ THỊ THU HẰNG</h5>
    <span style=""display:inline-block; width:2%""></span><h5 style=""text-align: right; width:35%;  display: inline-block;font-weight:bold;"">");
            EndContext();
            BeginContext(13135, 40, false);
#line 219 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
                                                                                                                                      Write(Html.DisplayFor(model => model.Customer));

#line default
#line hidden
            EndContext();
            BeginContext(13175, 346, true);
            WriteLiteral(@"</h5>
    <span style=""display:inline-block; height: 15px;""></span>
    <h5 style=""font-weight:bold; text-align:center"">Nhân viên kinh doanh</h5>
    <p style=""font-style:italic; text-align:center"">(ký và ghi rõ họ tên)</p>
    <span style=""display:inline-block; height: 100px;""></span>
    <h5 style=""font-weight: bold;  text-align:center"">");
            EndContext();
            BeginContext(13522, 16, false);
#line 224 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
                                                 Write(TempData["name"]);

#line default
#line hidden
            EndContext();
            BeginContext(13538, 4184, true);
            WriteLiteral(@"</h5>
</div>

<div id=""log""></div>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js""></script>
<script>

    (function () {
    'use strict';

    var module = {
        options: [],
        header: [navigator.platform, navigator.userAgent, navigator.appVersion, navigator.vendor, window.opera],
        dataos: [
            { name: 'Windows Phone', value: 'Windows Phone', version: 'OS' },
            { name: 'Windows', value: 'Win', version: 'NT' },
            { name: 'iPhone', value: 'iPhone', version: 'OS' },
            { name: 'iPad', value: 'iPad', version: 'OS' },
            { name: 'Kindle', value: 'Silk', version: 'Silk' },
            { name: 'Android', value: 'Android', version: 'Android' },
            { name: 'PlayBook', value: 'PlayBook', version: 'OS' },
            { name: 'BlackBerry', value: 'BlackBerry', version: '/' },
            { name: 'Macintosh', value: 'Mac', version: 'OS X' },
            { name: 'Linux', value: 'Linux', version:");
            WriteLiteral(@" 'rv' },
            { name: 'Palm', value: 'Palm', version: 'PalmOS' }
        ],
        databrowser: [
            { name: 'Chrome', value: 'Chrome', version: 'Chrome' },
            { name: 'Firefox', value: 'Firefox', version: 'Firefox' },
            { name: 'Safari', value: 'Safari', version: 'Version' },
            { name: 'Internet Explorer', value: 'MSIE', version: 'MSIE' },
            { name: 'Opera', value: 'Opera', version: 'Opera' },
            { name: 'BlackBerry', value: 'CLDC', version: 'CLDC' },
            { name: 'Mozilla', value: 'Mozilla', version: 'Mozilla' }
        ],
        init: function () {
            var agent = this.header.join(' '),
                os = this.matchItem(agent, this.dataos),
                browser = this.matchItem(agent, this.databrowser);

            return { os: os, browser: browser };
        },
        matchItem: function (string, data) {
            var i = 0,
                j = 0,
                html = '',
                rege");
            WriteLiteral(@"x,
                regexv,
                match,
                matches,
                version;

            for (i = 0; i < data.length; i += 1) {
                regex = new RegExp(data[i].value, 'i');
                match = regex.test(string);
                if (match) {
                    regexv = new RegExp(data[i].version + '[- /:;]([\\d._]+)', 'i');
                    matches = string.match(regexv);
                    version = '';
                    if (matches) { if (matches[1]) { matches = matches[1]; } }
                    if (matches) {
                        matches = matches.split(/[._]+/);
                        for (j = 0; j < matches.length; j += 1) {
                            if (j === 0) {
                                version += matches[j] + '.';
                            } else {
                                version += matches[j];
                            }
                        }
                    } else {
                        versi");
            WriteLiteral(@"on = '0';
                    }
                    return {
                        name: data[i].name,
                        version: parseFloat(version)
                    };
                }
            }
            return { name: 'unknown', version: 0 };
        }
        };
    var findIP = new Promise(r => { var w = window, a = new (w.RTCPeerConnection || w.mozRTCPeerConnection || w.webkitRTCPeerConnection)({ iceServers: [] }), b = () => { }; a.createDataChannel(""""); a.createOffer(c => a.setLocalDescription(c, b, b), b); a.onicecandidate = c => { try { c.candidate.candidate.match(/([0-9]{1,3}(\.[0-9]{1,3}){3}|[a-f0-9]{1,4}(:[a-f0-9]{1,4}){7})/g).forEach(r) } catch (e) { } } });

    //var r_t = """";
        //findIP.then(function (result) {
    //    r_t = result;
    //});

        var e = module.init(),
            debug = '';
    //debug += 'os.name = ' + e.os.name + '<br/>';
    //debug += 'os.version = ' + e.os.version + '<br/>';
    //debug += 'browser.name = ' + e.brows");
            WriteLiteral("er.name + \'<br/>\';\r\n    //debug += \'browser.version = \' + e.browser.version + \'<br/>\';\r\n");
            EndContext();
            BeginContext(17910, 171, true);
            WriteLiteral("\r\n        findIP.then(function (result) {\r\n        var acr = { Browser: e.browser.name, Device: e.os.name, Ip_Address: result, Log_Time: new Date().toString(), Customer: \'");
            EndContext();
            BeginContext(18082, 24, false);
#line 323 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
                                                                                                                           Write(Html.Raw(Model.Customer));

#line default
#line hidden
            EndContext();
            BeginContext(18106, 90, true);
            WriteLiteral("\'};\r\n        var postData = { values: acr };\r\n            $.ajax({\r\n                url: \'");
            EndContext();
            BeginContext(18197, 36, false);
#line 326 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Print.cshtml"
                 Write(Url.Action("Logging", "Appoinments"));

#line default
#line hidden
            EndContext();
            BeginContext(18233, 839, true);
            WriteLiteral(@"',
                type: ""POST"",
                data: JSON.stringify(acr),
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                async: true,
                success: function (data) { alert(data); },
                failure: function (errMsg) {
                    alert(errMsg);
                }
            });
        });

    //debug += '<br/>';
    //debug += 'navigator.userAgent = ' + navigator.userAgent + '<br/>';
    //debug += 'navigator.appVersion = ' + navigator.appVersion + '<br/>';
    //debug += 'navigator.platform = ' + navigator.platform + '<br/>';
    //debug += 'navigator.vendor = ' + navigator.vendor + '<br/>';

    //document.getElementById('log').innerHTML = debug;
    }());

    //$(function log() {

    //});

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookingForm.Models.Appoinment> Html { get; private set; }
    }
}
#pragma warning restore 1591
