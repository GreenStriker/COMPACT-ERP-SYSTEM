#pragma checksum "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok6P2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df1a69c5e0b617b2e12b412e21d856496e5c33c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reports_Mushok6P2), @"mvc.1.0.view", @"/Views/Reports/Mushok6P2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reports/Mushok6P2.cshtml", typeof(AspNetCore.Views_Reports_Mushok6P2))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df1a69c5e0b617b2e12b412e21d856496e5c33c8", @"/Views/Reports/Mushok6P2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c551d0fb6d1cb6e33accdc0872f5172ad460dc03", @"/Views/_ViewImports.cshtml")]
    public class Views_Reports_Mushok6P2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<vms.entity.viewModels.ReportsViewModel.VmSalesCalcBook>
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
            BeginContext(63, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("breadcrumb", async() => {
                BeginContext(93, 64, true);
                WriteLiteral("\r\n    <ul class=\"page-breadcrumb\">\r\n        <li>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 157, "\"", 196, 1);
#line 8 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok6P2.cshtml"
WriteAttributeValue("", 164, Url.Action("Dashboard", "Home"), 164, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(197, 96, true);
                WriteLiteral(">Root</a>\r\n            <i class=\"fa fa-circle\"></i>\r\n        </li>\r\n        <li>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 293, "\"", 332, 1);
#line 12 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok6P2.cshtml"
WriteAttributeValue("", 300, Url.Action("Mushok1","Reports"), 300, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(333, 99, true);
                WriteLiteral(">Reports</a>\r\n            <i class=\"fa fa-circle\"></i>\r\n        </li>\r\n        <li>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 432, "\"", 473, 1);
#line 16 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok6P2.cshtml"
WriteAttributeValue("", 439, Url.Action("Mushok6P2","Reports"), 439, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(474, 43, true);
                WriteLiteral(">Mushak-6.2</a>\r\n        </li>\r\n    </ul>\r\n");
                EndContext();
            }
            );
            BeginContext(520, 47, true);
            WriteLiteral("<h1 class=\"custom-page-title\">Mushak-6.2</h1>\r\n");
            EndContext();
#line 21 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok6P2.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(597, 77, true);
            WriteLiteral("    <input type=\"hidden\" class=\"form-control\" id=\"productId\" name=\"productId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 674, "\"", 698, 1);
#line 23 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok6P2.cshtml"
WriteAttributeValue("", 682, Model.productID, 682, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(699, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
            BeginContext(708, 227, true);
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-2\">\r\n            <div class=\"form-group\">\r\n                <label>From Date</label>\r\n                <input class=\"form-control\" autocomplete=\"off\" id=\"FromDate\" name=\"FromDate\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 935, "\"", 958, 1);
#line 30 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok6P2.cshtml"
WriteAttributeValue("", 943, Model.fromDate, 943, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(959, 251, true);
            WriteLiteral(" type=\"text\">\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"col-md-2\">\r\n            <div class=\"form-group\">\r\n                <label>To Date</label>\r\n                <input class=\"form-control\" autocomplete=\"off\" id=\"ToDate\" name=\"ToDate\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1210, "\"", 1231, 1);
#line 37 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok6P2.cshtml"
WriteAttributeValue("", 1218, Model.toDate, 1218, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1232, 246, true);
            WriteLiteral(" type=\"text\">\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"col-md-2\">\r\n            <div class=\"form-group\">\r\n                <label>Product</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"Product\" name=\"Product\"");
            EndContext();
            BeginWriteAttribute("value", "  value=\"", 1478, "\"", 1509, 1);
#line 44 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok6P2.cshtml"
WriteAttributeValue("", 1487, ViewBag.searchProduct, 1487, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1510, 288, true);
            WriteLiteral(@">
            </div>
        </div>
        <div class=""col-md-2"">
            <div class=""form-group pull-left"">
                <input class=""btn  btn-success"" style=""margin-top:25px;"" type=""submit"" value=""View Report"" />
            </div>
        </div>





    </div>
");
            EndContext();
#line 58 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok6P2.cshtml"


}

#line default
#line hidden
            BeginContext(1805, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 62 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok6P2.cshtml"
 if (Model.organizationId != 0)
{

#line default
#line hidden
            BeginContext(1843, 11, true);
            WriteLiteral("    <iframe");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1854, "\"", 1876, 1);
#line 64 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok6P2.cshtml"
WriteAttributeValue("", 1860, Model.ReportUrl, 1860, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1877, 64, true);
            WriteLiteral(" style=\"width: 100%; min-height: 1000px;border:0px;\"></iframe>\r\n");
            EndContext();
#line 65 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok6P2.cshtml"
}

#line default
#line hidden
            BeginContext(1944, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1963, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1969, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b899ec44eeaa4ae5bb1e92025d2b75ba", async() => {
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
                BeginContext(2017, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2023, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6599ccac06ac4078a637d41eb114e0c5", async() => {
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
                BeginContext(2064, 1574, true);
                WriteLiteral(@"
    <script>

        $(""#FromDate"").datepicker();
        $(""#FromDate"").datepicker('option', 'dateFormat', 'dd M, yy');

        $(""#ToDate"").datepicker();
        $(""#ToDate"").datepicker('option', 'dateFormat', 'dd M, yy');

    </script>
    <script>
        var report = {
            product : {
                init: function () { },
                productAutoComplete: function () {
                    var materialforrequsition = {
                        Initialize: function () {
                            materialforrequsition.Typehead();
                        },

                        Typehead: function () {
                            $('#Product').typeahead('destroy');
                            $('#Product').typeahead({
                                    hint: true,
                                    highlight: true,
                                    minLength: 2,
                                },
                                {
                           ");
                WriteLiteral(@"         items: 8,
                                    name: 'Product',
                                    //displayKey: 'Material.Name',
                                    displayKey: function (s) {
                                        //alert(s.Name);
                                        return s.name;
                                    },
                                    property: ""productId"",
                                    source: function (strmaterial, process) {
                                        var url = '");
                EndContext();
                BeginContext(3639, 45, false);
#line 106 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok6P2.cshtml"
                                              Write(Url.Content("~/Products/ProductAutoComplete"));

#line default
#line hidden
                EndContext();
                BeginContext(3684, 2105, true);
                WriteLiteral(@"';
                                        return $.getJSON(url, { filterText: $(""#Product"").val() }, function (Data) {

                                            return process(Data);
                                        });
                                    },
                                    updater: function (item) {
                                        return item.name;
                                    }
                                }).on('typeahead:selected', function (obj, datum) {

                                    $(""#productId"").val(datum.id);


                            });
                            $(""#Product"").focus();

                        }
                    }
                    materialforrequsition.Initialize();
                }
            },

            vendor: {
                init: function () { },
                productAutoComplete: function () {
                    var materialforrequsition = {
                        Initia");
                WriteLiteral(@"lize: function () {
                            materialforrequsition.Typehead();
                        },

                        Typehead: function () {
                            $('#Vendor').typeahead('destroy');
                            $('#Vendor').typeahead({
                                    hint: true,
                                    highlight: true,
                                    minLength: 2,
                                },
                                {
                                    items: 8,
                                    name: 'Vendor',
                                    //displayKey: 'Material.Name',
                                    displayKey: function (s) {
                                        //alert(s.Name);
                                        return s.name;
                                    },
                                    property: ""vendorId"",
                                    source: function (strmaterial, proces");
                WriteLiteral("s) {\r\n                                        var url = \'");
                EndContext();
                BeginContext(5790, 42, false);
#line 154 "E:\personal\New folder\MoneyMoney\vms\Views\Reports\Mushok6P2.cshtml"
                                              Write(Url.Content("~/Vendor/VendorAutoComplete"));

#line default
#line hidden
                EndContext();
                BeginContext(5832, 1005, true);
                WriteLiteral(@"';
                                        return $.getJSON(url, { filterText: $(""#Vendor"").val() }, function (Data) {

                                            return process(Data);
                                        });
                                    },
                                    updater: function (item) {
                                        return item.name;
                                    }
                                }).on('typeahead:selected', function (obj, datum) {

                                    $(""#vendorId"").val(datum.id);


                            });
                            $(""#Product"").focus();

                        }
                    }
                    materialforrequsition.Initialize();
                }
            }
        }
        $(document).ready(function() {

            report.product.productAutoComplete();
            report.vendor.productAutoComplete();
        });
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<vms.entity.viewModels.ReportsViewModel.VmSalesCalcBook> Html { get; private set; }
    }
}
#pragma warning restore 1591
