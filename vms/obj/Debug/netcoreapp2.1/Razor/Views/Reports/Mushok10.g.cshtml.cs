#pragma checksum "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok10.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d81ffbb84caa741519125f1c5e72db0cf99cc3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reports_Mushok10), @"mvc.1.0.view", @"/Views/Reports/Mushok10.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reports/Mushok10.cshtml", typeof(AspNetCore.Views_Reports_Mushok10))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d81ffbb84caa741519125f1c5e72db0cf99cc3e", @"/Views/Reports/Mushok10.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c551d0fb6d1cb6e33accdc0872f5172ad460dc03", @"/Views/_ViewImports.cshtml")]
    public class Views_Reports_Mushok10 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<vms.entity.viewModels.ReportsViewModel.ReoportOption>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ReportSearchOption", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Reports/mushak1.pdf"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%; min-height: 1000px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("breadcrumb", async() => {
                BeginContext(87, 64, true);
                WriteLiteral("\r\n    <ul class=\"page-breadcrumb\">\r\n        <li>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 151, "\"", 190, 1);
#line 6 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok10.cshtml"
WriteAttributeValue("", 158, Url.Action("Dashboard", "Home"), 158, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(191, 96, true);
                WriteLiteral(">Root</a>\r\n            <i class=\"fa fa-circle\"></i>\r\n        </li>\r\n        <li>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 287, "\"", 326, 1);
#line 10 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok10.cshtml"
WriteAttributeValue("", 294, Url.Action("Mushok1","Reports"), 294, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(327, 98, true);
                WriteLiteral(">Mushak</a>\r\n            <i class=\"fa fa-circle\"></i>\r\n        </li>\r\n        <li>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 425, "\"", 465, 1);
#line 14 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok10.cshtml"
WriteAttributeValue("", 432, Url.Action("Mushok10","Reports"), 432, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(466, 42, true);
                WriteLiteral(">Mushak-10</a>\r\n        </li>\r\n    </ul>\r\n");
                EndContext();
            }
            );
            BeginContext(511, 46, true);
            WriteLiteral("<h1 class=\"custom-page-title\">Mushak-10</h1>\r\n");
            EndContext();
            BeginContext(557, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dd2d30c4d2f94a53a3fecddcd88ac02f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(595, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 20 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok10.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(621, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(625, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("iframe", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a641103c28c04adf980cc903ead5044d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(710, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 23 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok10.cshtml"
}

#line default
#line hidden
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
