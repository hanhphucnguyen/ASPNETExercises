#pragma checksum "C:\Users\Phuc-pc\source\repos\ASPNETExercises\ASPNETExercises\Views\Tray\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45339d20652d11f5d57f0e8f57964a58ca040faf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tray_List), @"mvc.1.0.view", @"/Views/Tray/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tray/List.cshtml", typeof(AspNetCore.Views_Tray_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45339d20652d11f5d57f0e8f57964a58ca040faf", @"/Views/Tray/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c2c278e98f7f086015cb7cd5ebb8c7167609aa4", @"/Views/_ViewImports.cshtml")]
    public class Views_Tray_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/vuemodal.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/traylist.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Phuc-pc\source\repos\ASPNETExercises\ASPNETExercises\Views\Tray\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(87, 135, true);
            WriteLiteral("<!-- development version, includes helpful console warnings -->\r\n<script src=\"https://cdn.jsdelivr.net/npm/vue/dist/vue.js\"></script>\r\n");
            EndContext();
            BeginContext(222, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "10e72c872184427f824690d91916b8ed", async() => {
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
            EndContext();
            BeginContext(273, 1198, true);
            WriteLiteral(@"
<div id=""trays"">
    <div class=""mt-5"">
        <div class=""card"">
            <div class=""card-title text-center mt-3"">
                <h3>Trays You've Ordered</h3>
            </div>
            <div class=""card-body"">
                <table class=""table table-bordered table-striped"">
                    <thead>
                        <tr>
                            <td>Id</td>
                            <th class=""text-center"">Date</th>
                            <th class=""text-center"">Total Calories</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr href=""#"" v-for=""tray in trays"" v-on:click=""trayForModal=tray;loadAndShowModal();"">
                            <td>{{tray.id}}</td>
                            <td>{{formatDate(tray.dateCreated)}}</td>
                            <td class=""text-right"">{{tray.totalCalories}}</td>
                        </tr>
                    </tbody>
                </table>");
            WriteLiteral("\n            </div>\r\n        </div>\r\n    </div>\r\n    <modal v-if=\"showModal\" v-on:close=\"showModal = false\" :tray=\"trayForModal\" :details=\"detailsForModal\"></modal>\r\n</div>\r\n");
            EndContext();
            BeginContext(1471, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0933e757e6764b83bcc2391db10e4ed4", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1511, 2895, true);
            WriteLiteral(@"
<!-- template for the modal component -->
<script type=""text/x-template"" id=""modal-template"">
    <transition name=""modal"">
        <div class=""modal-mask"">
            <div class=""modal-wrapper"">
                <div class=""modal-container"">
                    <button type=""button"" class=""close"" style=""font-size:xx-large;"" v-on:click=""$emit('close')"">
                        X
                    </button>
                    <div class=""text-center"" style=""font-size:larger;"">
                        <h3>Tray:{{tray.id}}</h3>
                        {{formatDate(tray.dateCreated)}}<p></p>
                        <img src=""../images/Tray.png"" style=""height:60px;width:60px;margin:10px;"" />
                        <ul class=""list-group vuerow"">
                            <li class=""list-group-item vuerow"" style=""background-color:lightgray;"">
                                <span class=""vuecol20 text-center"">Qty</span>
                                <span class=""vuecol80"">Description</span>");
            WriteLiteral(@"
                            </li>
                            <li v-for=""detail in details"" class=""list-group-item vuerow"">
                                <span class=""vuecol20 text-center"">{{detail.qty}}</span>
                                <span class=""vuecol80 text-left"">{{detail.description}}</span>
                            </li>
                        </ul>
                        <div v-if=""details[0]"" class=""text-right"">
                            <div class=""vuerow"">
                                <div class=""vuecol80"">Total Calories:</div>
                                <div class=""vuecol20 pr-2"">{{details[0].totalCalories}}</div>
                            </div>
                            <div class=""vuerow"">
                                <div class=""vuecol80"">Total Protein:</div>
                                <div class=""vuecol20 pr-2"">{{details[0].totalProtein}}</div>
                            </div>
                            <div class=""vuerow"">
             ");
            WriteLiteral(@"                   <div class=""vuecol80"">Total Fat:</div>
                                <div class=""vuecol20 pr-2"">{{details[0].totalFat}}</div>
                            </div>
                            <div class=""vuerow"">
                                <div class=""vuecol80"">Total Salt:</div>
                                <div class=""vuecol20 pr-2"">{{details[0].totalSalt}}</div>
                            </div>
                            <div class=""vuerow"">
                                <div class=""vuecol80"">Total Cholesterol:</div>
                                <div class=""vuecol20 pr-2"">{{details[0].totalCholesterol}}</div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </transition>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
