#pragma checksum "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fffe1dc47b99378b562d6ac5ce7c06058e70f8ad12ff7b76c49437be4b1e3033"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\_ViewImports.cshtml"
using Warmhouse

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\_ViewImports.cshtml"
using Warmhouse_Models

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
 using Warmhouse_Utility

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
 using System.Globalization

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"fffe1dc47b99378b562d6ac5ce7c06058e70f8ad12ff7b76c49437be4b1e3033", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b24fe75f8b75d64838c300a165753f978bac0f3156c0fd90c94d6eb8b8f01458", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Clear", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("formmethod", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("Update"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Update Cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_17 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
 if (Model.Count() > 0)
{



#line default
#line hidden
#nullable disable

            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fffe1dc47b99378b562d6ac5ce7c06058e70f8ad12ff7b76c49437be4b1e303310529", async() => {
                WriteLiteral(@"
        <br />
        <div class=""backgroundWhiteBorder"">
            <div class=""container row"">
                <div class=""col -8"">
                    <div class=""card mt-4"">
                        <div class=""card-header bg-dark text-light ml-0 row container"">
                            <div class=""col-6"">
                                <i class=""fa fa-shopping-cart""></i> &nbsp;
                                Кошик
                            </div>
                            <div class=""col-6 text-right"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fffe1dc47b99378b562d6ac5ce7c06058e70f8ad12ff7b76c49437be4b1e303311381", async() => {
                    WriteLiteral("Очистити кошик");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fffe1dc47b99378b562d6ac5ce7c06058e70f8ad12ff7b76c49437be4b1e303312750", async() => {
                    WriteLiteral("Продовжити покупки");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""card-body"">
                            <div class="" d-none d-lg-block"">
                                <div class=""row"" style=""color:#821f3d"">
                                    <div class=""col-lg-2"">
                                    </div>
");
#nullable restore
#line 29 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
                                     if (User.IsInRole(WC.AdminRole))
                                    {

#line default
#line hidden
#nullable disable

                WriteLiteral("                                        <div class=\"col-12 col-lg-3\">\n                                            Деталі товару\n                                        </div>\n");
#nullable restore
#line 34 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable

                WriteLiteral("                                        <div class=\"col-12 col-lg-7\">\n                                            Деталі товару\n                                        </div>\n");
#nullable restore
#line 40 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable

                WriteLiteral("                                    <div class=\"col-12 col-lg-2\">\n                                        Ціна\n                                    </div>\n");
#nullable restore
#line 44 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
                                     if (User.IsInRole(WC.AdminRole))
                                    {

#line default
#line hidden
#nullable disable

                WriteLiteral(@"                                        <div class=""col-6 col-lg-2"">
                                            Кількість
                                        </div>
                                        <div class=""col-6 col-lg-2"">
                                            Загальна ціна
                                        </div>
");
#nullable restore
#line 52 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable

                WriteLiteral("                                    <div class=\"col-6 col-sm-4 col-lg-1\">\n                                    </div>\n                                </div>\n                            </div>\n\n                            <hr />\n");
#nullable restore
#line 59 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
                              
                                var orderTotal = 0.0;
                            

#line default
#line hidden
#nullable disable

#nullable restore
#line 62 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
                             for (int i = 0; i < Model.Count(); i++)
                            {

#line default
#line hidden
#nullable disable

                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fffe1dc47b99378b562d6ac5ce7c06058e70f8ad12ff7b76c49437be4b1e303317729", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => 
#nullable restore
#line 64 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
                                                        Model[i].Id

#line default
#line hidden
#nullable disable
                );
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                <div class=\"row h-100\">\n                                    <div class=\"col-4 col-md-2 text-center py-2\">\n                                        <img");
                BeginWriteAttribute("src", " src=\"", 3204, "\"", 3238, 2);
                WriteAttributeValue("", 3210, 
#nullable restore
#line 67 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
                                                   WC.ImagePath

#line default
#line hidden
#nullable disable
                , 3210, 13, false);
                WriteAttributeValue("", 3223, 
#nullable restore
#line 67 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
                                                                Model[i].Image

#line default
#line hidden
#nullable disable
                , 3223, 15, false);
                EndWriteAttribute();
                WriteLiteral(" class=\"rounded\" width=\"100%\" />\n                                    </div>\n");
#nullable restore
#line 69 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
                                     if (User.IsInRole(WC.AdminRole))
                                    {


#line default
#line hidden
#nullable disable

                WriteLiteral("                                        <div class=\"col-8 col-lg-3\">\n                                            <h5>");
                Write(
#nullable restore
#line 73 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
                                                 Model[i].Name

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</h5>\n                                            <div style=\"font-size:11px;\">");
                Write(
#nullable restore
#line 74 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
                                                                          Model[i].ShortDesc

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</div>\n                                        </div>\n");
#nullable restore
#line 76 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable

                WriteLiteral("                                        <div class=\"col-8 col-lg-7\">\n                                            <h5>");
                Write(
#nullable restore
#line 80 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
                                                 Model[i].Name

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</h5>\n                                            <div style=\"font-size:11px;\">");
                Write(
#nullable restore
#line 81 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
                                                                          Model[i].ShortDesc

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</div>\n                                        </div>\n");
#nullable restore
#line 83 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable

                WriteLiteral("                                    <div class=\"col-3 col-lg-2 pt-lg-4\" style=\"font-size:11px;\">\n                                        <span style=\"font-size:17px;\"> ");
                Write(
#nullable restore
#line 85 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
                                                                        string.Format(CultureInfo.GetCultureInfo("en-US"), "{0:c2}", Model[i].Price)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</span>\n\n                                    </div>\n");
#nullable restore
#line 88 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
                                     if (User.IsInRole(WC.AdminRole))
                                    {

#line default
#line hidden
#nullable disable

                WriteLiteral("                                        <div class=\"col-4 col-lg-2 pt-lg-4\" style=\"font-size:11px;\">\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fffe1dc47b99378b562d6ac5ce7c06058e70f8ad12ff7b76c49437be4b1e303324350", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => 
#nullable restore
#line 91 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
                                                                         Model[i].Quantity

#line default
#line hidden
#nullable disable
                );
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fffe1dc47b99378b562d6ac5ce7c06058e70f8ad12ff7b76c49437be4b1e303326310", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => 
#nullable restore
#line 92 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
                                                                       Model[i].Quantity

#line default
#line hidden
#nullable disable
                );
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                        </div>\n                                        <div class=\"col-3 col-lg-2 pt-lg-4\" style=\"font-size:11px;\">\n                                            <span style=\"font-size:17px;\"> $");
                Write(
#nullable restore
#line 95 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
                                                                              Model[i].Price * Model[i].Quantity

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</span>\n\n\n                                        </div>\n");
#nullable restore
#line 99 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable

                WriteLiteral("                                    <div class=\"col-2 col-lg-1 p-0 pt-lg-4 text-center\">\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fffe1dc47b99378b562d6ac5ce7c06058e70f8ad12ff7b76c49437be4b1e303329085", async() => {
                    WriteLiteral("\n                                            <i class=\"fas fa-trash\"></i>\n                                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
                WriteLiteral(
#nullable restore
#line 101 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
                                                                              Model[i].Id

#line default
#line hidden
#nullable disable
                );
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                    </div>\n                                </div>\n");
#nullable restore
#line 106 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
                                orderTotal += Model[i].Price * Model[i].Quantity;

#line default
#line hidden
#nullable disable

                WriteLiteral("                                <hr />\n");
#nullable restore
#line 108 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable

                WriteLiteral("\n");
#nullable restore
#line 110 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
                             if (User.IsInRole(WC.AdminRole))
                            {

#line default
#line hidden
#nullable disable

                WriteLiteral("                                <div class=\"row\">\n                                    <div class=\"col-12 text-right pr-4\" style=\"color:#821f3d\">\n                                        Order Total : ");
                Write(
#nullable restore
#line 114 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
                                                       string.Format("{0:c}", orderTotal)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\n                                    </div>\n                                </div>\n");
#nullable restore
#line 117 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable

                WriteLiteral("                        </div>\n                        <div class=\"card-footer\">\n                            <div class=\"row\">\n\n                                <div class=\"col-6 col-md-3 offset-md-6\">\n");
#nullable restore
#line 123 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
                                     if (User.IsInRole(WC.AdminRole))
                                    {

#line default
#line hidden
#nullable disable

                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fffe1dc47b99378b562d6ac5ce7c06058e70f8ad12ff7b76c49437be4b1e303333925", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 127 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable

                WriteLiteral(@"                                </div>
                                <div class=""col-6 col-md-3"">
                                    <button type=""submit"" class=""btn btn-success form-control "">
                                        <span>Continue</span>
                                    </button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_16.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_16);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 141 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <p>Please add items to cart.</p>\n");
#nullable restore
#line 145 "C:\Users\kpops\OneDrive\Рабочий стол\1\Warmhouse\Views\Cart\Index.cshtml"
}

#line default
#line hidden
#nullable disable

            WriteLiteral("\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fffe1dc47b99378b562d6ac5ce7c06058e70f8ad12ff7b76c49437be4b1e303338011", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_17.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_17);
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
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
