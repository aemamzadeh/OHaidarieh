#pragma checksum "D:\NetCoreProjects\repos\OHaidariehProject\ServiceHost\Pages\ContactInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77824ad1f0f98a539a50a2b5a3151565e1128d60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Pages_ContactInfo), @"mvc.1.0.razor-page", @"/Pages/ContactInfo.cshtml")]
namespace ServiceHost.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\NetCoreProjects\repos\OHaidariehProject\ServiceHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77824ad1f0f98a539a50a2b5a3151565e1128d60", @"/Pages/ContactInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05dba1f137f38628cc46e082b6d169a931c7e4bb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ContactInfo : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "D:\NetCoreProjects\repos\OHaidariehProject\ServiceHost\Pages\ContactInfo.cshtml"
   Layout = "_Layout2";
    ViewData["title"] = "اطلاعات تماس"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""gap"">
    <div class=""container"">
        <div class=""sec-title text-center"">
            <div class=""sec-title-inner"">
                <span>آگاهی پیدا کنید</span>
                <h3>اطلاعات تماس</h3>
            </div>
        </div>
        <div class=""contact-info-wrap text-center remove-ext3"">
            <div class=""row"">
                <div class=""col-md-4 col-sm-6 col-lg-4"">
                    <div class=""contact-info-box"">
                        <i class=""flaticon-location-pin""></i>
                        <strong>آدرس ما</strong>
                        <span>خیابان ری - سه راه امین حضور - حیدریة النجف الاشرف </span>
                        <a href=""mailto:info@haidarieh.com""");
            BeginWriteAttribute("title", " title=\"", 808, "\"", 816, 0);
            EndWriteAttribute();
            WriteLiteral(@">info@haidarieh.com</a>
                    </div>
                </div>
                <div class=""col-md-4 col-sm-6 col-lg-4"">
                    <div class=""contact-info-box"">
                        <i class=""flaticon-call""></i>
                        <strong>تماس با ما</strong>
                        <span>021تلفن: 33552301</span>
                    </div>
                </div>
                <div class=""col-md-4 col-sm-6 col-lg-4"">
                    <div class=""contact-info-box"">
                        <i class=""flaticon-email""></i>
                        <strong>ارسال پیام</strong>
                        <a");
            BeginWriteAttribute("title", " title=\"", 1451, "\"", 1459, 0);
            EndWriteAttribute();
            WriteLiteral("> آماده پاسخگویی</a>\n                        <a href=\"mailto:info@haidarieh.com\"");
            BeginWriteAttribute("title", " title=\"", 1540, "\"", 1548, 0);
            EndWriteAttribute();
            WriteLiteral(">info@haidarieh.com</a>\n                    </div>\n                </div>\n            </div>\n        </div><!-- Contact Info Wrap -->\n    </div>\n</div>\n<div class=\"gap no-gap\">\n    <div class=\"contact-loc\" id=\"contact-loc\"></div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactInfoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactInfoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactInfoModel>)PageContext?.ViewData;
        public ContactInfoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
