#pragma checksum "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok6P4.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52a0ab52ac7aaa67937500798c54f72bdc365ef3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reports_Mushok6P4), @"mvc.1.0.view", @"/Views/Reports/Mushok6P4.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reports/Mushok6P4.cshtml", typeof(AspNetCore.Views_Reports_Mushok6P4))]
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
#line 1 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok6P4.cshtml"
using vms.Utility;

#line default
#line hidden
#line 2 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok6P4.cshtml"
using vms.entity.viewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52a0ab52ac7aaa67937500798c54f72bdc365ef3", @"/Views/Reports/Mushok6P4.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c551d0fb6d1cb6e33accdc0872f5172ad460dc03", @"/Views/_ViewImports.cshtml")]
    public class Views_Reports_Mushok6P4 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<vms.entity.viewModels.ReportsViewModel.VmPurchaseReport>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/typeahead.bundle.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-ui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok6P4.cshtml"
  
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
#line 13 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok6P4.cshtml"
WriteAttributeValue("", 317, Url.Action("Dashboard", "Home"), 317, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(350, 96, true);
                WriteLiteral(">Root</a>\r\n            <i class=\"fa fa-circle\"></i>\r\n        </li>\r\n        <li>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 446, "\"", 492, 1);
#line 17 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok6P4.cshtml"
WriteAttributeValue("", 453, Url.Action("PurchaseReport","Reports"), 453, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(493, 99, true);
                WriteLiteral(">Reports</a>\r\n            <i class=\"fa fa-circle\"></i>\r\n        </li>\r\n        <li>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 592, "\"", 633, 1);
#line 21 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok6P4.cshtml"
WriteAttributeValue("", 599, Url.Action("Mushok6P4","Reports"), 599, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(634, 53, true);
                WriteLiteral(">PURCHASE VDS INVOICE</a>\r\n        </li>\r\n    </ul>\r\n");
                EndContext();
            }
            );
            BeginContext(690, 73, true);
            WriteLiteral("    <h1 class=\"custom-page-title\">Mushak-6.4(Contractual Chalan)</h1>\r\n\r\n");
            EndContext();
            BeginContext(763, 1099, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "682b2499fa55408291188ac358210ca6", async() => {
                BeginContext(783, 648, true);
                WriteLiteral(@"

    <input type=""hidden"" class=""form-control"" id=""InvoiceNo"" name=""InvoiceNo"" />
    <input type=""hidden"" class=""form-control"" id=""PurchaseId"" name=""PurchaseId"" />

    <div class=""portlet-body form"">

        <div class=""col-md-11"">

            <div class=""col-md-2"">
                <div class=""form-group"">
                    <input type=""hidden"" name=""IsReportVisible"" id=""IsReportVisible"" value=""true"" />
                    <label for=""VendorInfo"">Invoice No.</label>
                    <input type=""text"" class=""form-control"" id=""Invoice"">

                </div>
            </div>
            <div class=""col-md-2"">
");
                EndContext();
#line 45 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok6P4.cshtml"
                 if (UserRole.Check(FeatureList.REPORTS_PURCHASE_REPORT_BY_GR_NO_CAN_VIEW, session.Rights))
                {



#line default
#line hidden
                BeginContext(1563, 219, true);
                WriteLiteral("                    <div class=\"form-group \" style=\"margin-top: -2px;\">\r\n                        <input class=\"btn  btn-success\" style=\"margin-top:25px;\" type=\"submit\" value=\"ViewReport\" />\r\n                    </div>\r\n");
                EndContext();
#line 52 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok6P4.cshtml"
                }

#line default
#line hidden
                BeginContext(1801, 54, true);
                WriteLiteral("            </div>\r\n\r\n        </div>\r\n\r\n\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1862, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 60 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok6P4.cshtml"
 if (Model.PurchaseId > 0)
{

#line default
#line hidden
            BeginContext(1895, 11, true);
            WriteLiteral("    <iframe");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1906, "\"", 1928, 1);
#line 62 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok6P4.cshtml"
WriteAttributeValue("", 1912, Model.ReportUrl, 1912, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1929, 64, true);
            WriteLiteral(" style=\"width: 100%; min-height: 1000px;border:0px;\"></iframe>\r\n");
            EndContext();
#line 63 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok6P4.cshtml"
}

#line default
#line hidden
            BeginContext(1996, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2015, 10, true);
                WriteLiteral("\r\n\r\n\r\n    ");
                EndContext();
                BeginContext(2025, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f19aeeaccbe44f4abe2af1ec5900231c", async() => {
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
                BeginContext(2073, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2079, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a673e4dd8f41454dbc25c423bdcff241", async() => {
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
                BeginContext(2120, 1806, true);
                WriteLiteral(@"
    <script>


        $(""#FromDate"").datepicker();
        $(""#FromDate"").datepicker('option', 'dateFormat', 'dd M, yy');

        $(""#ToDate"").datepicker();
        $(""#ToDate"").datepicker('option', 'dateFormat', 'dd M, yy');

        var Report = {
            init: function () { },
            count: 1,
            unitAmount: 0,
            totalPrice: 0,
            totalVat: 0,
            purchaseOrders: [],
            PurchaseOrderDetailList: [],
            item: [],
            product: {
                init: function () { },
                InvoiceAutoComplete: function () {
                    var materialforrequsition = {
                        Initialize: function () {
                            materialforrequsition.Typehead();
                        },

                        Typehead: function () {
                            $('#Invoice').typeahead('destroy');
                           // document.getElementById(""Invoice"").value = """";
                  ");
                WriteLiteral(@"          //document.getElementById(""Invoice"").value = """";
                            $('#Invoice').typeahead({
                                hint: true,
                                highlight: true,
                                minLength: 2,
                            },
                                {
                                    items: 8,
                                    name: 'Product',

                                    displayKey: function (s) {

                                        return s.invoiceNo;
                                    },
                                    property: ""Invoice"",
                                    source: function (strmaterial, process) {
                                        var url = '");
                EndContext();
                BeginContext(3927, 53, false);
#line 115 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok6P4.cshtml"
                                              Write(Url.Content("~/Sales/InvoiceKeyWordSearchByContract"));

#line default
#line hidden
                EndContext();
                BeginContext(3980, 1461, true);
                WriteLiteral(@"';
                                        return $.getJSON(url, { filterText: $(""#Invoice"").val() }, function (Data) {

                                            return process(Data);
                                        });
                                    },
                                    updater: function (item) {
                                        return item.invoiceNo;
                                    }
                                }).on('typeahead:selected', function (obj, datum) {
                                    $(""#Invoice"").text(datum.invoiceNo);
                                    //$(""#PurchaseId"").val(datum.purchaseId);
                                    document.getElementById(""InvoiceNo"").value = datum.invoiceNo;
                                    document.getElementById(""PurchaseId"").value = datum.id;
                                  //  alert(datum.invoiceNo);
                                    //$(""#Invoice"").val(datum.Invoice);
               ");
                WriteLiteral(@"                     //$(""#InvoiceNo"").val(datum.Invoice);
                                 });
                            $(""#Invoice"").focus();

                        }
                    }
                    materialforrequsition.Initialize();
                },


            }
        }
        $(document).ready(function () {

            Report.product.InvoiceAutoComplete();

        });

    </script>

");
                EndContext();
            }
            );
            BeginContext(5444, 12, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
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
