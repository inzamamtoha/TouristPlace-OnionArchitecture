#pragma checksum "C:\Users\inzamam\source\repos\OnionArchitecture\PresentationLayer\Views\Home\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6923b0222e87e71be2438c44bae347b20737ecc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Update), @"mvc.1.0.view", @"/Views/Home/Update.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Update.cshtml", typeof(AspNetCore.Views_Home_Update))]
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
#line 1 "C:\Users\inzamam\source\repos\OnionArchitecture\PresentationLayer\Views\_ViewImports.cshtml"
using WebLayer;

#line default
#line hidden
#line 2 "C:\Users\inzamam\source\repos\OnionArchitecture\PresentationLayer\Views\_ViewImports.cshtml"
using WebLayer.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6923b0222e87e71be2438c44bae347b20737ecc8", @"/Views/Home/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5849482f2217ccd5137c55b87447d80eebf64ab1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebLayer.Models.PlaceViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("updateForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("backU"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\inzamam\source\repos\OnionArchitecture\PresentationLayer\Views\Home\Update.cshtml"
  
    ViewData["Title"] = "Update";

#line default
#line hidden
            BeginContext(83, 66, true);
            WriteLiteral("\r\n<div id=\'update\'>\r\n    <h2>Update the Tourist Place</h2>\r\n\r\n    ");
            EndContext();
            BeginContext(149, 1531, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec9a0642af6343639b4b6b436cb42174", async() => {
                BeginContext(235, 49, true);
                WriteLiteral("\r\n        <p>Name: <input type=\'text\' name=\'Name\'");
                EndContext();
                BeginWriteAttribute("value", " value=\'", 284, "\'", 329, 1);
#line 11 "C:\Users\inzamam\source\repos\OnionArchitecture\PresentationLayer\Views\Home\Update.cshtml"
WriteAttributeValue("", 292, Html.DisplayFor(model => model.Name), 292, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(330, 127, true);
                WriteLiteral(" class=\"form-control\" placeholder=\'Enter the place name\' required /></p>\r\n        <p>Address: <input type=\'text\' name=\'Address\'");
                EndContext();
                BeginWriteAttribute("value", " value=\'", 457, "\'", 505, 1);
#line 12 "C:\Users\inzamam\source\repos\OnionArchitecture\PresentationLayer\Views\Home\Update.cshtml"
WriteAttributeValue("", 465, Html.DisplayFor(model => model.Address), 465, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(506, 146, true);
                WriteLiteral(" class=\"form-control\" placeholder=\'Enter the place address\' required /></p>\r\n        <p>Rating: <input type=\'number\' min=\'1\' max=\'5\' name=\'Rating\'");
                EndContext();
                BeginWriteAttribute("value", " value=\'", 652, "\'", 699, 1);
#line 13 "C:\Users\inzamam\source\repos\OnionArchitecture\PresentationLayer\Views\Home\Update.cshtml"
WriteAttributeValue("", 660, Html.DisplayFor(model => model.Rating), 660, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(700, 216, true);
                WriteLiteral(" class=\"form-control\" placeholder=\'Rate the palace\' required /></p>\r\n        <p>Picture: <input type=\'file\' name=\'Picture\' id=\'loadUpdateImage\' class=\"form-control\" /></p>\r\n        <input type=\"hidden\" name=\"PicPath\"");
                EndContext();
                BeginWriteAttribute("value", " value=\'", 916, "\'", 964, 1);
#line 15 "C:\Users\inzamam\source\repos\OnionArchitecture\PresentationLayer\Views\Home\Update.cshtml"
WriteAttributeValue("", 924, Html.DisplayFor(model => model.Picture), 924, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(965, 96, true);
                WriteLiteral(" />\r\n        <p>\r\n            Country: <select name=\"CountryId\" class=\"form-control\" required>\r\n");
                EndContext();
#line 18 "C:\Users\inzamam\source\repos\OnionArchitecture\PresentationLayer\Views\Home\Update.cshtml"
                 foreach (var item in ViewData["Country"] as IEnumerable<WebLayer.Models.CountryViewModel>)
                {
                    

#line default
#line hidden
#line 20 "C:\Users\inzamam\source\repos\OnionArchitecture\PresentationLayer\Views\Home\Update.cshtml"
                     if (Model.Country == @item.Name)
                    {

#line default
#line hidden
                BeginContext(1267, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(1291, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a237ddf3d654a829977597ebf0a2b0f", async() => {
                    BeginContext(1325, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(1327, 9, false);
#line 22 "C:\Users\inzamam\source\repos\OnionArchitecture\PresentationLayer\Views\Home\Update.cshtml"
                                                      Write(item.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 22 "C:\Users\inzamam\source\repos\OnionArchitecture\PresentationLayer\Views\Home\Update.cshtml"
                           WriteLiteral(item.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1345, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 23 "C:\Users\inzamam\source\repos\OnionArchitecture\PresentationLayer\Views\Home\Update.cshtml"
                    }
                    else
                    {

#line default
#line hidden
                BeginContext(1419, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(1443, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87d2fe9fc13d4673a0d7bd9c83caf6e6", async() => {
                    BeginContext(1468, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(1470, 9, false);
#line 26 "C:\Users\inzamam\source\repos\OnionArchitecture\PresentationLayer\Views\Home\Update.cshtml"
                                             Write(item.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 26 "C:\Users\inzamam\source\repos\OnionArchitecture\PresentationLayer\Views\Home\Update.cshtml"
                           WriteLiteral(item.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1488, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 27 "C:\Users\inzamam\source\repos\OnionArchitecture\PresentationLayer\Views\Home\Update.cshtml"
                    }

#line default
#line hidden
#line 27 "C:\Users\inzamam\source\repos\OnionArchitecture\PresentationLayer\Views\Home\Update.cshtml"
                     

                }

#line default
#line hidden
                BeginContext(1534, 139, true);
                WriteLiteral("            </select>\r\n        <p><button type=\'submit\' value=\'\' id=\'submitUpdateBtn\' class=\"btn btn-default\">Update</button><br></p>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
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
            BeginContext(1680, 18, true);
            WriteLiteral("\r\n\r\n    <br>\r\n    ");
            EndContext();
            BeginContext(1698, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6cb4f596e854f798e571b852f44ccbe", async() => {
                BeginContext(1765, 26, true);
                WriteLiteral("Back to Tourist Place List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1795, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebLayer.Models.PlaceViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
