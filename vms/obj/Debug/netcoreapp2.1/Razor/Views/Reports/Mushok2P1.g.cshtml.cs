#pragma checksum "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok2P1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "354d474e882b88b030642cdcd924d1e24cab5ca3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reports_Mushok2P1), @"mvc.1.0.view", @"/Views/Reports/Mushok2P1.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reports/Mushok2P1.cshtml", typeof(AspNetCore.Views_Reports_Mushok2P1))]
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
#line 1 "E:\personal\New folder\MoneyMoney\vms\Views\_ViewImports.cshtml"
using vms;

#line default
#line hidden
#line 2 "E:\personal\New folder\MoneyMoney\vms\Views\_ViewImports.cshtml"
using vms.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"354d474e882b88b030642cdcd924d1e24cab5ca3", @"/Views/Reports/Mushok2P1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c551d0fb6d1cb6e33accdc0872f5172ad460dc03", @"/Views/_ViewImports.cshtml")]
    public class Views_Reports_Mushok2P1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<vms.entity.viewModels.ReportsViewModel.ReoportOption>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Reports/Mushak_2.1_.pdf"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%; min-height: 1000px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            DefineSection("breadcrumb", async() => {
                BeginContext(87, 52, true);
                WriteLiteral("\r\n<ul class=\"page-breadcrumb\">\r\n    <li>\r\n        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 139, "\"", 178, 1);
#line 6 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok2P1.cshtml"
WriteAttributeValue("", 146, Url.Action("Dashboard", "Home"), 146, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(179, 80, true);
                WriteLiteral(">Root</a>\r\n        <i class=\"fa fa-circle\"></i>\r\n    </li>\r\n    <li>\r\n        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 259, "\"", 298, 1);
#line 10 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok2P1.cshtml"
WriteAttributeValue("", 266, Url.Action("Mushok1","Reports"), 266, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(299, 83, true);
                WriteLiteral(">Reports</a>\r\n        <i class=\"fa fa-circle\"></i>\r\n    </li>\r\n    <li>\r\n        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 382, "\"", 423, 1);
#line 14 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok2P1.cshtml"
WriteAttributeValue("", 389, Url.Action("Mushok2P1","Reports"), 389, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(424, 35, true);
                WriteLiteral(">Mushak-2.1</a>\r\n    </li>\r\n</ul>\r\n");
                EndContext();
            }
            );
            BeginContext(462, 53, true);
            WriteLiteral("<h1 class=\"custom-page-title\">Mushak-2.1</h1>\r\n\r\n    ");
            EndContext();
            BeginContext(515, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("iframe", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5e85186cebb47acbf1baa3051c9e9bc", async() => {
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
            BeginContext(604, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<vms.entity.viewModels.ReportsViewModel.ReoportOption> Html { get; private set; }
    }
}
#pragma warning restore 1591
