#pragma checksum "C:\Users\USER\Downloads\65e9150c-d1c2-47c4-b270-33f2dd043879_OHaidarieh\OHaidarieh\ServiceHost\Areas\Admin\Pages\Multimedias\EditAlbum.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c6705251d9b853d1fd6b4d008f6dc50f5de9eff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Areas.Admin.Pages.Multimedias.Areas_Admin_Pages_Multimedias_EditAlbum), @"mvc.1.0.razor-page", @"/Areas/Admin/Pages/Multimedias/EditAlbum.cshtml")]
namespace ServiceHost.Areas.Admin.Pages.Multimedias
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
#line 5 "C:\Users\USER\Downloads\65e9150c-d1c2-47c4-b270-33f2dd043879_OHaidarieh\OHaidarieh\ServiceHost\Areas\Admin\Pages\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c6705251d9b853d1fd6b4d008f6dc50f5de9eff", @"/Areas/Admin/Pages/Multimedias/EditAlbum.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cfab432600b8205c2cbdbddb69cb692b1a4da87", @"/Areas/Admin/Pages/_ViewImports.cshtml")]
    public class Areas_Admin_Pages_Multimedias_EditAlbum : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 70px; height: 70px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning pull-right m-rl-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "EditAlbum", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <h3 class=""panel-title"">ویرایش فایلهای چندرسانه ای </h3>
            </div>
            <div class=""panel-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c6705251d9b853d1fd6b4d008f6dc50f5de9eff6316", async() => {
                WriteLiteral(@"
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <table id=""datatable"" class=""table table-striped table-bordered"">
                                <thead>
                                    <tr>
                                        <th>عکس</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 23 "C:\Users\USER\Downloads\65e9150c-d1c2-47c4-b270-33f2dd043879_OHaidarieh\OHaidarieh\ServiceHost\Areas\Admin\Pages\Multimedias\EditAlbum.cshtml"
                                       int m = Model.Command.Count % 4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\USER\Downloads\65e9150c-d1c2-47c4-b270-33f2dd043879_OHaidarieh\OHaidarieh\ServiceHost\Areas\Admin\Pages\Multimedias\EditAlbum.cshtml"
                                       int k = Model.Command.Count - 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\USER\Downloads\65e9150c-d1c2-47c4-b270-33f2dd043879_OHaidarieh\OHaidarieh\ServiceHost\Areas\Admin\Pages\Multimedias\EditAlbum.cshtml"
                                       int t = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\USER\Downloads\65e9150c-d1c2-47c4-b270-33f2dd043879_OHaidarieh\OHaidarieh\ServiceHost\Areas\Admin\Pages\Multimedias\EditAlbum.cshtml"
                                     if (m == 0)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\USER\Downloads\65e9150c-d1c2-47c4-b270-33f2dd043879_OHaidarieh\OHaidarieh\ServiceHost\Areas\Admin\Pages\Multimedias\EditAlbum.cshtml"
                                         for (int i = 0; i < Model.Command.Count / 4; i++)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <tr>\r\n");
#nullable restore
#line 31 "C:\Users\USER\Downloads\65e9150c-d1c2-47c4-b270-33f2dd043879_OHaidarieh\OHaidarieh\ServiceHost\Areas\Admin\Pages\Multimedias\EditAlbum.cshtml"
                                                 for (int j = 0; j < 4; j++)
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <td>\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4c6705251d9b853d1fd6b4d008f6dc50f5de9eff9195", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1586, "~/", 1586, 2, true);
#nullable restore
#line 34 "C:\Users\USER\Downloads\65e9150c-d1c2-47c4-b270-33f2dd043879_OHaidarieh\OHaidarieh\ServiceHost\Areas\Admin\Pages\Multimedias\EditAlbum.cshtml"
AddHtmlAttributeValue("", 1588, Model.Command[j].FileAddress, 1588, 29, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c6705251d9b853d1fd6b4d008f6dc50f5de9eff11075", async() => {
                    WriteLiteral("\r\n                                                            <i class=\"fa fa-edit\"></i>حذف\r\n                                                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\USER\Downloads\65e9150c-d1c2-47c4-b270-33f2dd043879_OHaidarieh\OHaidarieh\ServiceHost\Areas\Admin\Pages\Multimedias\EditAlbum.cshtml"
                                                                                                                                                      WriteLiteral(Model.Command[j].Id);

#line default
#line hidden
#nullable disable
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
                WriteLiteral("\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4c6705251d9b853d1fd6b4d008f6dc50f5de9eff14011", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 40 "C:\Users\USER\Downloads\65e9150c-d1c2-47c4-b270-33f2dd043879_OHaidarieh\OHaidarieh\ServiceHost\Areas\Admin\Pages\Multimedias\EditAlbum.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Command[j].CeremonyId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\USER\Downloads\65e9150c-d1c2-47c4-b270-33f2dd043879_OHaidarieh\OHaidarieh\ServiceHost\Areas\Admin\Pages\Multimedias\EditAlbum.cshtml"
                                                                                                               WriteLiteral(Model.Command[j].CeremonyId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                    </td>\r\n");
#nullable restore
#line 42 "C:\Users\USER\Downloads\65e9150c-d1c2-47c4-b270-33f2dd043879_OHaidarieh\OHaidarieh\ServiceHost\Areas\Admin\Pages\Multimedias\EditAlbum.cshtml"
                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            </tr>\r\n");
#nullable restore
#line 44 "C:\Users\USER\Downloads\65e9150c-d1c2-47c4-b270-33f2dd043879_OHaidarieh\OHaidarieh\ServiceHost\Areas\Admin\Pages\Multimedias\EditAlbum.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\USER\Downloads\65e9150c-d1c2-47c4-b270-33f2dd043879_OHaidarieh\OHaidarieh\ServiceHost\Areas\Admin\Pages\Multimedias\EditAlbum.cshtml"
                                         
                                    }
                                    else
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\USER\Downloads\65e9150c-d1c2-47c4-b270-33f2dd043879_OHaidarieh\OHaidarieh\ServiceHost\Areas\Admin\Pages\Multimedias\EditAlbum.cshtml"
                                         for (int i = 0; i < Model.Command.Count / 4 + 1; i++)
                                        {
                                            t = 0;

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <tr>\r\n");
#nullable restore
#line 52 "C:\Users\USER\Downloads\65e9150c-d1c2-47c4-b270-33f2dd043879_OHaidarieh\OHaidarieh\ServiceHost\Areas\Admin\Pages\Multimedias\EditAlbum.cshtml"
                                                 while (t < 4 && k >= 0)
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <td>\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4c6705251d9b853d1fd6b4d008f6dc50f5de9eff18740", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3082, "~/", 3082, 2, true);
#nullable restore
#line 55 "C:\Users\USER\Downloads\65e9150c-d1c2-47c4-b270-33f2dd043879_OHaidarieh\OHaidarieh\ServiceHost\Areas\Admin\Pages\Multimedias\EditAlbum.cshtml"
AddHtmlAttributeValue("", 3084, Model.Command[k].FileAddress, 3084, 29, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c6705251d9b853d1fd6b4d008f6dc50f5de9eff20621", async() => {
                    WriteLiteral("\r\n                                                            <i class=\"fa fa-edit\"></i>حذف\r\n                                                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\USER\Downloads\65e9150c-d1c2-47c4-b270-33f2dd043879_OHaidarieh\OHaidarieh\ServiceHost\Areas\Admin\Pages\Multimedias\EditAlbum.cshtml"
                                                                                                                                                      WriteLiteral(Model.Command[k].Id);

#line default
#line hidden
#nullable disable
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
                WriteLiteral("\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4c6705251d9b853d1fd6b4d008f6dc50f5de9eff23557", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 61 "C:\Users\USER\Downloads\65e9150c-d1c2-47c4-b270-33f2dd043879_OHaidarieh\OHaidarieh\ServiceHost\Areas\Admin\Pages\Multimedias\EditAlbum.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Command[k].CeremonyId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "C:\Users\USER\Downloads\65e9150c-d1c2-47c4-b270-33f2dd043879_OHaidarieh\OHaidarieh\ServiceHost\Areas\Admin\Pages\Multimedias\EditAlbum.cshtml"
                                                                                                               WriteLiteral(Model.Command[k].CeremonyId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                    </td>\r\n");
#nullable restore
#line 63 "C:\Users\USER\Downloads\65e9150c-d1c2-47c4-b270-33f2dd043879_OHaidarieh\OHaidarieh\ServiceHost\Areas\Admin\Pages\Multimedias\EditAlbum.cshtml"
                                                    t += 1;
                                                    k -= 1;
                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            </tr>\r\n");
#nullable restore
#line 67 "C:\Users\USER\Downloads\65e9150c-d1c2-47c4-b270-33f2dd043879_OHaidarieh\OHaidarieh\ServiceHost\Areas\Admin\Pages\Multimedias\EditAlbum.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\USER\Downloads\65e9150c-d1c2-47c4-b270-33f2dd043879_OHaidarieh\OHaidarieh\ServiceHost\Areas\Admin\Pages\Multimedias\EditAlbum.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n");
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceHost.Areas.Admin.Pages.Multimedias.EditAlbumModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Areas.Admin.Pages.Multimedias.EditAlbumModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Areas.Admin.Pages.Multimedias.EditAlbumModel>)PageContext?.ViewData;
        public ServiceHost.Areas.Admin.Pages.Multimedias.EditAlbumModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
