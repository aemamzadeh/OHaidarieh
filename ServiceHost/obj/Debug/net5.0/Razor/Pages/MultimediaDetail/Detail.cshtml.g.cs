#pragma checksum "D:\NetCoreProjects\repos\OHaidariehProject\ServiceHost\Pages\MultimediaDetail\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5988d4f1fe9095d9485fe005920a94db84c03c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.MultimediaDetail.Pages_MultimediaDetail_Detail), @"mvc.1.0.razor-page", @"/Pages/MultimediaDetail/Detail.cshtml")]
namespace ServiceHost.Pages.MultimediaDetail
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5988d4f1fe9095d9485fe005920a94db84c03c0", @"/Pages/MultimediaDetail/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05dba1f137f38628cc46e082b6d169a931c7e4bb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MultimediaDetail_Detail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Theme/assets/css/fancybox.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%;height:180px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-fancybox", new global::Microsoft.AspNetCore.Html.HtmlString("gallery"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Theme/assets/js/fancybox.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "D:\NetCoreProjects\repos\OHaidariehProject\ServiceHost\Pages\MultimediaDetail\Detail.cshtml"
   Layout = "_Layout2";
    ViewData["title"] = Model.ceremony.Title;
    ViewData["Keywords"] = Model.ceremony.Keywords;
    ViewData["MetaDescription"] = Model.ceremony.MetaDescription;


#line default
#line hidden
#nullable disable
            WriteLiteral("<link rel=\"canonical\" href=\"www.haidarieh.com/ceremonies\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c5988d4f1fe9095d9485fe005920a94db84c03c05700", async() => {
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
            WriteLiteral(" ");
            WriteLiteral(@"<div class=""gap remove-gap"">
    <div class=""page-title-wrap"">
        <h2>فایلهای چندرسانه ای </h2>
    </div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12 col-sm-12 col-lg-12"">
                <div class=""sec-title"">
                    <div class=""sec-title2 text-center"">
                        <h1>مراسم<span> ");
#nullable restore
#line 19 "D:\NetCoreProjects\repos\OHaidariehProject\ServiceHost\Pages\MultimediaDetail\Detail.cshtml"
                                   Write(Model.ceremony.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h1>\n                        <h3><span>");
#nullable restore
#line 20 "D:\NetCoreProjects\repos\OHaidariehProject\ServiceHost\Pages\MultimediaDetail\Detail.cshtml"
                             Write(Model.ceremony.CeremonyDateFa);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></h3>\n");
#nullable restore
#line 21 "D:\NetCoreProjects\repos\OHaidariehProject\ServiceHost\Pages\MultimediaDetail\Detail.cshtml"
                         foreach (var itm in Model.ceremony.CeremonyGuests)
                        {
            

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h3>");
#nullable restore
#line 25 "D:\NetCoreProjects\repos\OHaidariehProject\ServiceHost\Pages\MultimediaDetail\Detail.cshtml"
                   Write(itm.GuestType);

#line default
#line hidden
#nullable disable
            WriteLiteral(":<span> ");
#nullable restore
#line 25 "D:\NetCoreProjects\repos\OHaidariehProject\ServiceHost\Pages\MultimediaDetail\Detail.cshtml"
                                         Write(itm.Guest);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></h3> \n");
#nullable restore
#line 35 "D:\NetCoreProjects\repos\OHaidariehProject\ServiceHost\Pages\MultimediaDetail\Detail.cshtml"
                                                      
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n                </div>\n");
            WriteLiteral("\n                <ul style=\"list-style:none;\" class=\"row\">\n");
#nullable restore
#line 43 "D:\NetCoreProjects\repos\OHaidariehProject\ServiceHost\Pages\MultimediaDetail\Detail.cshtml"
                     foreach (var item in Model.ceremony.Multimedias)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"col-md-3\">\n                <br />\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5988d4f1fe9095d9485fe005920a94db84c03c09510", async() => {
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c5988d4f1fe9095d9485fe005920a94db84c03c09783", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2032, "~/", 2032, 2, true);
#nullable restore
#line 49 "D:\NetCoreProjects\repos\OHaidariehProject\ServiceHost\Pages\MultimediaDetail\Detail.cshtml"
AddHtmlAttributeValue("", 2034, item.FileAddress, 2034, 17, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "D:\NetCoreProjects\repos\OHaidariehProject\ServiceHost\Pages\MultimediaDetail\Detail.cshtml"
                                                        Write(item.Title);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-caption", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1968, "~/", 1968, 2, true);
#nullable restore
#line 48 "D:\NetCoreProjects\repos\OHaidariehProject\ServiceHost\Pages\MultimediaDetail\Detail.cshtml"
AddHtmlAttributeValue("", 1970, item.FileAddress, 1970, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                <br />\n\n            </li>");
#nullable restore
#line 54 "D:\NetCoreProjects\repos\OHaidariehProject\ServiceHost\Pages\MultimediaDetail\Detail.cshtml"
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\n\n               </div>");
            WriteLiteral("            </div>\n\n        </div>\n    </div>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5988d4f1fe9095d9485fe005920a94db84c03c013831", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MultimediaDetail.DetailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MultimediaDetail.DetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MultimediaDetail.DetailModel>)PageContext?.ViewData;
        public MultimediaDetail.DetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
