#pragma checksum "D:\NetCoreProjects\repos\OHaidariehProject\ServiceHost\Pages\Shared\Components\Banners\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "918021f29c04ff682013aaa152a85efcb0ee4c72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Shared.Components.Banners.Pages_Shared_Components_Banners_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/Banners/Default.cshtml")]
namespace ServiceHost.Pages.Shared.Components.Banners
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"918021f29c04ff682013aaa152a85efcb0ee4c72", @"/Pages/Shared/Components/Banners/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05dba1f137f38628cc46e082b6d169a931c7e4bb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_Banners_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<_01_HaidariehQuery.Contracts.Ceremonies.CeremonyQueryModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/theme/assets/images/resources/bsml-txt.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("bsml-txt.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"gap no-gap clearfix\">\n    <img class=\"botm-shp shp-img\" src=\"theme/assets/images/shp2-1.png\" alt=\"shp2-1.png\">\n    <div class=\"featured-area-wrap text-center\">\n        <div class=\"featured-area2 owl-carousel\">\n\n");
#nullable restore
#line 8 "D:\NetCoreProjects\repos\OHaidariehProject\ServiceHost\Pages\Shared\Components\Banners\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"featured-item style2\"");
            BeginWriteAttribute("style", " style=\"", 404, "\"", 446, 4);
            WriteAttributeValue("", 412, "background-image:", 412, 17, true);
            WriteAttributeValue(" ", 429, "url(", 430, 5, true);
#nullable restore
#line 10 "D:\NetCoreProjects\repos\OHaidariehProject\ServiceHost\Pages\Shared\Components\Banners\Default.cshtml"
WriteAttributeValue("", 434, item.Image, 434, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 445, ")", 445, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n                        <div class=\"featured-cap\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "918021f29c04ff682013aaa152a85efcb0ee4c725109", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            WriteLiteral("                            <h3>");
#nullable restore
#line 14 "D:\NetCoreProjects\repos\OHaidariehProject\ServiceHost\Pages\Shared\Components\Banners\Default.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                            <h4 class=\"text-white\">");
#nullable restore
#line 15 "D:\NetCoreProjects\repos\OHaidariehProject\ServiceHost\Pages\Shared\Components\Banners\Default.cshtml"
                                              Write(item.CeremonyDateFa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                            <h4 class=\"text-white\">ساعت:<span>");
#nullable restore
#line 16 "D:\NetCoreProjects\repos\OHaidariehProject\ServiceHost\Pages\Shared\Components\Banners\Default.cshtml"
                                                         Write(item.CeremonyTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h4>\n\n");
#nullable restore
#line 18 "D:\NetCoreProjects\repos\OHaidariehProject\ServiceHost\Pages\Shared\Components\Banners\Default.cshtml"
                             if (!System.Convert.IsDBNull(item.CeremonyDate))
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\NetCoreProjects\repos\OHaidariehProject\ServiceHost\Pages\Shared\Components\Banners\Default.cshtml"
                                 if (item.IsLive && (DateTime.Compare(item.CeremonyDate, DateTime.Now) < 0))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a class=\"btn btn-danger brd-rd5\" href=\"http://www.aparat.com\"");
            BeginWriteAttribute("title", " title=\"", 1294, "\"", 1302, 0);
            EndWriteAttribute();
            WriteLiteral(">پخش زنده</a>\n");
#nullable restore
#line 23 "D:\NetCoreProjects\repos\OHaidariehProject\ServiceHost\Pages\Shared\Components\Banners\Default.cshtml"
                                }
                                else if (item.IsLive && (DateTime.Compare(item.CeremonyDate, DateTime.Now) > 0))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a class=\"btn btn-success brd-rd5\"");
            BeginWriteAttribute("title", " title=\"", 1568, "\"", 1576, 0);
            EndWriteAttribute();
            WriteLiteral(">پخش زنده</a>\n");
#nullable restore
#line 27 "D:\NetCoreProjects\repos\OHaidariehProject\ServiceHost\Pages\Shared\Components\Banners\Default.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\NetCoreProjects\repos\OHaidariehProject\ServiceHost\Pages\Shared\Components\Banners\Default.cshtml"
                                 
                            }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\n                    </div>\n");
#nullable restore
#line 32 "D:\NetCoreProjects\repos\OHaidariehProject\ServiceHost\Pages\Shared\Components\Banners\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div><!-- Featured Area Wrap -->\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<_01_HaidariehQuery.Contracts.Ceremonies.CeremonyQueryModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
