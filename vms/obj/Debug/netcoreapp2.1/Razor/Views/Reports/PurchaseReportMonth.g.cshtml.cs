#pragma checksum "E:\personal\New folder\MoneyMoney\vms\Views\Reports\PurchaseReportMonth.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dc09798aa88f5af559b0d320db59ef845bd10bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reports_PurchaseReportMonth), @"mvc.1.0.view", @"/Views/Reports/PurchaseReportMonth.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reports/PurchaseReportMonth.cshtml", typeof(AspNetCore.Views_Reports_PurchaseReportMonth))]
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
#line 1 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\PurchaseReportMonth.cshtml"
using vms.Utility;

#line default
#line hidden
#line 2 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\PurchaseReportMonth.cshtml"
using vms.entity.viewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dc09798aa88f5af559b0d320db59ef845bd10bd", @"/Views/Reports/PurchaseReportMonth.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c551d0fb6d1cb6e33accdc0872f5172ad460dc03", @"/Views/_ViewImports.cshtml")]
    public class Views_Reports_PurchaseReportMonth : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<vms.entity.viewModels.ReportsViewModel.VmPurchaseReport>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/typeahead.bundle.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-ui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\PurchaseReportMonth.cshtml"
  
    var session = Context.Session.GetComplexData<vms.entity.viewModels.vmSession>("session");

#line default
#line hidden
            BeginContext(216, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("breadcrumb", async() => {
                BeginContext(246, 64, true);
                WriteLiteral("\r\n    <ul class=\"page-breadcrumb\">\r\n        <li>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 310, "\"", 349, 1);
#line 13 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\PurchaseReportMonth.cshtml"
WriteAttributeValue("", 317, Url.Action("Dashboard", "Home"), 317, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(350, 96, true);
                WriteLiteral(">Root</a>\r\n            <i class=\"fa fa-circle\"></i>\r\n        </li>\r\n        <li>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 446, "\"", 492, 1);
#line 17 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\PurchaseReportMonth.cshtml"
WriteAttributeValue("", 453, Url.Action("PurchaseReport","Reports"), 453, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(493, 99, true);
                WriteLiteral(">Reports</a>\r\n            <i class=\"fa fa-circle\"></i>\r\n        </li>\r\n        <li>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 592, "\"", 643, 1);
#line 21 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\PurchaseReportMonth.cshtml"
WriteAttributeValue("", 599, Url.Action("PurchaseReportMonth","Reports"), 599, 44, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(644, 56, true);
                WriteLiteral(">Monthly Purchase Report</a>\r\n        </li>\r\n    </ul>\r\n");
                EndContext();
            }
            );
            BeginContext(703, 63, true);
            WriteLiteral("<h1 class=\"custom-page-title\">Monthly Purchase Report </h1>\r\n\r\n");
            EndContext();
#line 27 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\PurchaseReportMonth.cshtml"
 using (Html.BeginForm())
{


#line default
#line hidden
            BeginContext(798, 80, true);
            WriteLiteral("    <input type=\"hidden\" class=\"form-control\" id=\"vendorId\" name=\"vendorId\" />\r\n");
            EndContext();
            BeginContext(880, 230, true);
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            <div class=\"form-group\">\r\n                <label>Select Date:</label>\r\n                <input class=\"form-control\" autocomplete=\"off\" id=\"FromDate\" name=\"FromDate\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1110, "\"", 1133, 1);
#line 36 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\PurchaseReportMonth.cshtml"
WriteAttributeValue("", 1118, Model.FromDate, 1118, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1134, 99, true);
            WriteLiteral(" type=\"text\">\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n        <div class=\"col-md-2\">\r\n");
            EndContext();
#line 48 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\PurchaseReportMonth.cshtml"
             if (UserRole.Check(FeatureList.REPORTS_MONTHLY_PURCHASE_REPORT_CAN_VIEW, session.Rights))
            {


#line default
#line hidden
            BeginContext(1354, 191, true);
            WriteLiteral("                <div class=\"form-group pull-left\">\r\n                    <input class=\"btn  btn-success\" style=\"margin-top:25px;\" type=\"submit\" value=\"View Report\" />\r\n                </div>\r\n");
            EndContext();
#line 54 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\PurchaseReportMonth.cshtml"
            }

#line default
#line hidden
            BeginContext(1560, 42, true);
            WriteLiteral("            </div>\r\n\r\n\r\n\r\n\r\n\r\n    </div>\r\n");
            EndContext();
#line 62 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\PurchaseReportMonth.cshtml"


}

#line default
#line hidden
            BeginContext(1609, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 66 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\PurchaseReportMonth.cshtml"
 if (Model.reason == 1)
{

#line default
#line hidden
            BeginContext(1639, 11, true);
            WriteLiteral("    <iframe");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1650, "\"", 1672, 1);
#line 68 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\PurchaseReportMonth.cshtml"
WriteAttributeValue("", 1656, Model.ReportUrl, 1656, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1673, 64, true);
            WriteLiteral(" style=\"width: 100%; min-height: 1000px;border:0px;\"></iframe>\r\n");
            EndContext();
#line 69 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\PurchaseReportMonth.cshtml"
}

#line default
#line hidden
            BeginContext(1740, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1759, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(1767, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b42a820859d45af91a8ed03fb4287b2", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1815, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1821, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0763d35f165b49e09f3ac0c6b6854f2c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1862, 257, true);
                WriteLiteral(@"
    <script>

        $(""#FromDate"").datepicker();
        $(""#FromDate"").datepicker('option', 'dateFormat', 'dd M, yy');

        $(""#ToDate"").datepicker();
        $(""#ToDate"").datepicker('option', 'dateFormat', 'dd M, yy');



    </script>
");
                EndContext();
            }
            );
            BeginContext(2122, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<vms.entity.viewModels.ReportsViewModel.VmPurchaseReport> Html { get; private set; }
    }
}
#pragma warning restore 1591
