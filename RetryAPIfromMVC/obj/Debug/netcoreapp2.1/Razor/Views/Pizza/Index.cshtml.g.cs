#pragma checksum "C:\Users\hrist\Desktop\RetryAPIfromMVC\RetryAPIfromMVC\RetryAPIfromMVC\Views\Pizza\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "377124f6a25b6d2ccb1e888c89daaf5d17f67aaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizza_Index), @"mvc.1.0.view", @"/Views/Pizza/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pizza/Index.cshtml", typeof(AspNetCore.Views_Pizza_Index))]
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
#line 1 "C:\Users\hrist\Desktop\RetryAPIfromMVC\RetryAPIfromMVC\RetryAPIfromMVC\Views\_ViewImports.cshtml"
using RetryAPIfromMVC;

#line default
#line hidden
#line 2 "C:\Users\hrist\Desktop\RetryAPIfromMVC\RetryAPIfromMVC\RetryAPIfromMVC\Views\_ViewImports.cshtml"
using RetryAPIfromMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"377124f6a25b6d2ccb1e888c89daaf5d17f67aaf", @"/Views/Pizza/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54d7764ca2ff145a229b29aec1074912d817d2ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizza_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RetryAPIfromMVC.Models.Pizza>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\hrist\Desktop\RetryAPIfromMVC\RetryAPIfromMVC\RetryAPIfromMVC\Views\Pizza\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(93, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(122, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3347c04039bb45aab5b79717d1f40748", async() => {
                BeginContext(145, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(159, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(252, 43, false);
#line 16 "C:\Users\hrist\Desktop\RetryAPIfromMVC\RetryAPIfromMVC\RetryAPIfromMVC\Views\Pizza\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PizzaId));

#line default
#line hidden
            EndContext();
            BeginContext(295, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(351, 45, false);
#line 19 "C:\Users\hrist\Desktop\RetryAPIfromMVC\RetryAPIfromMVC\RetryAPIfromMVC\Views\Pizza\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PizzaName));

#line default
#line hidden
            EndContext();
            BeginContext(396, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(452, 41, false);
#line 22 "C:\Users\hrist\Desktop\RetryAPIfromMVC\RetryAPIfromMVC\RetryAPIfromMVC\Views\Pizza\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(493, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\hrist\Desktop\RetryAPIfromMVC\RetryAPIfromMVC\RetryAPIfromMVC\Views\Pizza\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(611, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(660, 42, false);
#line 31 "C:\Users\hrist\Desktop\RetryAPIfromMVC\RetryAPIfromMVC\RetryAPIfromMVC\Views\Pizza\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PizzaId));

#line default
#line hidden
            EndContext();
            BeginContext(702, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(758, 44, false);
#line 34 "C:\Users\hrist\Desktop\RetryAPIfromMVC\RetryAPIfromMVC\RetryAPIfromMVC\Views\Pizza\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PizzaName));

#line default
#line hidden
            EndContext();
            BeginContext(802, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(858, 40, false);
#line 37 "C:\Users\hrist\Desktop\RetryAPIfromMVC\RetryAPIfromMVC\RetryAPIfromMVC\Views\Pizza\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(898, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(954, 57, false);
#line 40 "C:\Users\hrist\Desktop\RetryAPIfromMVC\RetryAPIfromMVC\RetryAPIfromMVC\Views\Pizza\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new {  id=item.PizzaId }));

#line default
#line hidden
            EndContext();
            BeginContext(1011, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1032, 64, false);
#line 41 "C:\Users\hrist\Desktop\RetryAPIfromMVC\RetryAPIfromMVC\RetryAPIfromMVC\Views\Pizza\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.PizzaId }));

#line default
#line hidden
            EndContext();
            BeginContext(1096, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1117, 62, false);
#line 42 "C:\Users\hrist\Desktop\RetryAPIfromMVC\RetryAPIfromMVC\RetryAPIfromMVC\Views\Pizza\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.PizzaId }));

#line default
#line hidden
            EndContext();
            BeginContext(1179, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 45 "C:\Users\hrist\Desktop\RetryAPIfromMVC\RetryAPIfromMVC\RetryAPIfromMVC\Views\Pizza\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1218, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RetryAPIfromMVC.Models.Pizza>> Html { get; private set; }
    }
}
#pragma warning restore 1591
