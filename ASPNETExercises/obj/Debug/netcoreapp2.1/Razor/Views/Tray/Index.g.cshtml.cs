#pragma checksum "C:\Users\Phuc-pc\source\repos\ASPNETExercises\ASPNETExercises\Views\Tray\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce5dd99cb958ff8b4e82e09163dbf2aa0247ef64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tray_Index), @"mvc.1.0.view", @"/Views/Tray/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tray/Index.cshtml", typeof(AspNetCore.Views_Tray_Index))]
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
#line 1 "C:\Users\Phuc-pc\source\repos\ASPNETExercises\ASPNETExercises\Views\_ViewImports.cshtml"
using ASPNetExercises;

#line default
#line hidden
#line 2 "C:\Users\Phuc-pc\source\repos\ASPNETExercises\ASPNETExercises\Views\_ViewImports.cshtml"
using ASPNetExercises.Models;

#line default
#line hidden
#line 3 "C:\Users\Phuc-pc\source\repos\ASPNETExercises\ASPNETExercises\Views\_ViewImports.cshtml"
using ASPNETExercises.Models;

#line default
#line hidden
#line 4 "C:\Users\Phuc-pc\source\repos\ASPNETExercises\ASPNETExercises\Views\_ViewImports.cshtml"
using ASPNetExercises.Utils;

#line default
#line hidden
#line 5 "C:\Users\Phuc-pc\source\repos\ASPNETExercises\ASPNETExercises\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 6 "C:\Users\Phuc-pc\source\repos\ASPNETExercises\ASPNETExercises\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce5dd99cb958ff8b4e82e09163dbf2aa0247ef64", @"/Views/Tray/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c2c278e98f7f086015cb7cd5ebb8c7167609aa4", @"/Views/_ViewImports.cshtml")]
    public class Views_Tray_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tray", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddTray", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Phuc-pc\source\repos\ASPNETExercises\ASPNETExercises\Views\Tray\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(88, 255, true);
            WriteLiteral("<div class=\"card\">\r\n    <div class=\"card-title text-center mt-5\">\r\n        <h3 class=\"font-weight-bold\">Tray Contents</h3>\r\n        <img src=\"/images/tray.png\" style=\"height:10%;width:10%;padding-bottom:5%;\" />\r\n    </div>\r\n    <div class=\"text-center\">\r\n");
            EndContext();
#line 11 "C:\Users\Phuc-pc\source\repos\ASPNETExercises\ASPNETExercises\Views\Tray\Index.cshtml"
          
            Dictionary<int, object> tray = Context.Session.Get<Dictionary<int, Object>>("tray");
            int calTot = 0;
            decimal fatTot = 0.0M;
            int saltTot = 0;
            int cholTot = 0;
            int proTot = 0;
            int fbrTot = 0;
        

#line default
#line hidden
            BeginContext(647, 216, true);
            WriteLiteral("        <table class=\"table table-striped\">\r\n            <tr style=\"font-weight:bolder;\">\r\n                <th class=\"text-center\">Qty</th>\r\n                <th class=\"text-left\">Description</th>\r\n            </tr>\r\n");
            EndContext();
#line 25 "C:\Users\Phuc-pc\source\repos\ASPNETExercises\ASPNETExercises\Views\Tray\Index.cshtml"
              
                if (tray != null)
                {
                    foreach (var key in tray.Keys)
                    {
                        MenuItemViewModel item = JsonConvert.DeserializeObject
                        <MenuItemViewModel>
                        (Convert.ToString(tray[key]));
                        if (item.Qty > 0)
                        {
                            fbrTot += item.FBR * item.Qty;
                            calTot += item.CAL * item.Qty;
                            saltTot += item.SALT * item.Qty;
                            fatTot += item.FAT * item.Qty;
                            cholTot += item.CHOL * item.Qty;
                            proTot += item.PRO * item.Qty;

#line default
#line hidden
            BeginContext(1623, 90, true);
            WriteLiteral("                            <tr>\r\n                                <td class=\"text-center\">");
            EndContext();
            BeginContext(1714, 8, false);
#line 42 "C:\Users\Phuc-pc\source\repos\ASPNETExercises\ASPNETExercises\Views\Tray\Index.cshtml"
                                                   Write(item.Qty);

#line default
#line hidden
            EndContext();
            BeginContext(1722, 61, true);
            WriteLiteral("</td>\r\n                                <td class=\"text-left\">");
            EndContext();
            BeginContext(1784, 16, false);
#line 43 "C:\Users\Phuc-pc\source\repos\ASPNETExercises\ASPNETExercises\Views\Tray\Index.cshtml"
                                                 Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1800, 42, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n");
            EndContext();
#line 45 "C:\Users\Phuc-pc\source\repos\ASPNETExercises\ASPNETExercises\Views\Tray\Index.cshtml"
                        }
                    }
                }
            

#line default
#line hidden
            BeginContext(1926, 419, true);
            WriteLiteral(@"        </table>
        <hr />
        <table class=""table table-striped"">
            <tr>
                <th colspan=""4"" class=""text-left"" style=""font-size:large;font-weight:bold;"">
                    Tray
                    Totals
                </th>
            </tr>
            <tr>
                <td class=""text-right font-weight-bold"">Cals</td>
                <td class=""text-left"" id=""cal"">");
            EndContext();
            BeginContext(2346, 6, false);
#line 60 "C:\Users\Phuc-pc\source\repos\ASPNETExercises\ASPNETExercises\Views\Tray\Index.cshtml"
                                          Write(calTot);

#line default
#line hidden
            EndContext();
            BeginContext(2352, 125, true);
            WriteLiteral("</td>\r\n                <td class=\"text-right font-weight-bold\">Choles.</td>\r\n                <td class=\"text-left\" id=\"chol\">");
            EndContext();
            BeginContext(2478, 7, false);
#line 62 "C:\Users\Phuc-pc\source\repos\ASPNETExercises\ASPNETExercises\Views\Tray\Index.cshtml"
                                           Write(cholTot);

#line default
#line hidden
            EndContext();
            BeginContext(2485, 157, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td class=\"text-right font-weight-bold\">Fat</td>\r\n                <td class=\"text-left\" id=\"fat\">");
            EndContext();
            BeginContext(2643, 6, false);
#line 66 "C:\Users\Phuc-pc\source\repos\ASPNETExercises\ASPNETExercises\Views\Tray\Index.cshtml"
                                          Write(fatTot);

#line default
#line hidden
            EndContext();
            BeginContext(2649, 124, true);
            WriteLiteral("</td>\r\n                <td class=\"text-right font-weight-bold\">Fibre</td>\r\n                <td class=\"text-left\" id=\"fibre\">");
            EndContext();
            BeginContext(2774, 6, false);
#line 68 "C:\Users\Phuc-pc\source\repos\ASPNETExercises\ASPNETExercises\Views\Tray\Index.cshtml"
                                            Write(fbrTot);

#line default
#line hidden
            EndContext();
            BeginContext(2780, 161, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td class=\"text-right font-weight-bold\">Protein</td>\r\n                <td class=\"text-left\" id=\"pro\">");
            EndContext();
            BeginContext(2942, 6, false);
#line 72 "C:\Users\Phuc-pc\source\repos\ASPNETExercises\ASPNETExercises\Views\Tray\Index.cshtml"
                                          Write(proTot);

#line default
#line hidden
            EndContext();
            BeginContext(2948, 122, true);
            WriteLiteral("</td>\r\n                <td class=\"text-right font-weight-bold\">Salt</td>\r\n                <td class=\"text-left\" id=\"salt\">");
            EndContext();
            BeginContext(3071, 7, false);
#line 74 "C:\Users\Phuc-pc\source\repos\ASPNETExercises\ASPNETExercises\Views\Tray\Index.cshtml"
                                           Write(saltTot);

#line default
#line hidden
            EndContext();
            BeginContext(3078, 96, true);
            WriteLiteral("</td>\r\n            </tr>\r\n        </table>\r\n        <div class=\"text-center mb-2\">\r\n            ");
            EndContext();
            BeginContext(3174, 409, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af3fb5ea1d55407ab50f45ba4b8fa84c", async() => {
                BeginContext(3249, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 79 "C:\Users\Phuc-pc\source\repos\ASPNETExercises\ASPNETExercises\Views\Tray\Index.cshtml"
                 if (Context.Session.Get(SessionVariables.User) != null)
                {

#line default
#line hidden
                BeginContext(3344, 106, true);
                WriteLiteral("                    <button type=\"submit\" class=\"btn btn-sm btn-primary\" id=\"modalbtn\">Add Tray</button>\r\n");
                EndContext();
#line 82 "C:\Users\Phuc-pc\source\repos\ASPNETExercises\ASPNETExercises\Views\Tray\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(3469, 107, true);
                WriteLiteral("                &nbsp;<a href=\"/Tray/ClearTray\" class=\"btn btn-sm btn-success\">Clear Tray</a>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
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
            BeginContext(3583, 36, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
