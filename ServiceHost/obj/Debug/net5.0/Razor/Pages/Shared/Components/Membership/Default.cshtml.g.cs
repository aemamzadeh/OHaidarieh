#pragma checksum "D:\NetCoreProjects\repos\OHaidariehProject\ServiceHost\Pages\Shared\Components\Membership\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "209d72c805d9c031a0b341eea07920ae6d36584c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Shared.Components.Membership.Pages_Shared_Components_Membership_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/Membership/Default.cshtml")]
namespace ServiceHost.Pages.Shared.Components.Membership
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"209d72c805d9c031a0b341eea07920ae6d36584c", @"/Pages/Shared/Components/Membership/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05dba1f137f38628cc46e082b6d169a931c7e4bb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_Membership_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_01_HaidariehQuery.Contracts.Members.MemberQueryModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <div class=""gap opc9"">
        <div class=""container"">
            <div class=""evnt-pry-wrap"">
                <div class=""row"">
                    <div class=""col-md-8 col-sm-12 col-lg-8"">
                        <div class=""gap thm-layer opc9"">
                            <div class=""sec-title2 text-right"">
                                <div class=""sec-title-inner2 text-right"">
                                    <h3><span>عضویت در خبرنامه</span></h3>
                                </div>
                                <p>جهت دریافت آخرین اخبار، رویداد ها و مراسمات فرم زیر را تکمیل نمایید.</p>
                            </div>
                            <div class=""nwsltr-wrp text-right"">
                                <div class=""contact-form text-center"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "209d72c805d9c031a0b341eea07920ae6d36584c4112", async() => {
                WriteLiteral(@"
                                        <input type=""text"" placeholder="" نام و نام خانوادگی خود را وارد کنید"">
                                        <input type=""tel"" placeholder=""شماره تلفن همراه خود را وارد کنید"">
                                        <br />

                                        <button class=""thm-btn brd-rd40"" type=""submit"">عضویت در خبرنامه</button>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </div>\n                            </div>\n                        </div>\n                    </div>\n                </div>\n            </div><!-- Events & Prayer Wrap -->\n        </div>\n    </div>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_01_HaidariehQuery.Contracts.Members.MemberQueryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
