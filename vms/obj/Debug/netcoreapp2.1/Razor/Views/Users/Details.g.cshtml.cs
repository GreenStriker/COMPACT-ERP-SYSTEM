#pragma checksum "E:\personal\New folder\MoneyMoney\vms\Views\Users\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15ecc5b89d107867291ca474a782394c77a4f0d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Details), @"mvc.1.0.view", @"/Views/Users/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Details.cshtml", typeof(AspNetCore.Views_Users_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15ecc5b89d107867291ca474a782394c77a4f0d5", @"/Views/Users/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c551d0fb6d1cb6e33accdc0872f5172ad460dc03", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<vms.entity.models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Users/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("breadcrumb", async() => {
                BeginContext(59, 64, true);
                WriteLiteral("\r\n    <ul class=\"page-breadcrumb\">\r\n        <li>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 123, "\"", 162, 1);
#line 7 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Details.cshtml"
WriteAttributeValue("", 130, Url.Action("Dashboard", "Home"), 130, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(163, 96, true);
                WriteLiteral(">Root</a>\r\n            <i class=\"fa fa-circle\"></i>\r\n        </li>\r\n        <li>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 259, "\"", 312, 1);
#line 11 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Details.cshtml"
WriteAttributeValue("", 266, Url.Action("GeneralSettings", "Organization"), 266, 46, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(313, 105, true);
                WriteLiteral(">Adminstration</a>\r\n            <i class=\"fa fa-circle\"></i>\r\n        </li>\r\n        <li>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 418, "\"", 454, 1);
#line 15 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Details.cshtml"
WriteAttributeValue("", 425, Url.Action("Index", "Users"), 425, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(455, 97, true);
                WriteLiteral(">Users</a>\r\n            <i class=\"fa fa-circle\"></i>\r\n        </li>\r\n        <li>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 552, "\"", 589, 1);
#line 19 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Details.cshtml"
WriteAttributeValue("", 559, Url.Action("Details","Users"), 559, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(590, 45, true);
                WriteLiteral(">User Details</a>\r\n        </li>\r\n    </ul>\r\n");
                EndContext();
            }
            );
            BeginContext(638, 383, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12"" style=""margin-bottom:30px"">
        <h1 class=""custom-page-title"">User Details </h1>
    </div>
</div>

<div class=""row"">

    <div class=""col-md-12 "">
        <div class=""col-md-5 "">

            <div class=""col-md-12 "">
                <div class=""form-group"">

                    <label for=""form_control"">Full Name : ");
            EndContext();
            BeginContext(1022, 14, false);
#line 38 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Details.cshtml"
                                                     Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(1036, 196, true);
            WriteLiteral("</label>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"col-md-12 \">\r\n                <div class=\"form-group\">\r\n\r\n                    <label for=\"form_control\">User Name : ");
            EndContext();
            BeginContext(1233, 14, false);
#line 45 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Details.cshtml"
                                                     Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1247, 190, true);
            WriteLiteral("</label>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-12 \">\r\n                <div class=\"form-group\">\r\n                    <label for=\"form_control_1\">Email : ");
            EndContext();
            BeginContext(1438, 18, false);
#line 50 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Details.cshtml"
                                                   Write(Model.EmailAddress);

#line default
#line hidden
            EndContext();
            BeginContext(1456, 199, true);
            WriteLiteral("</label>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"col-md-12 \">\r\n                <div class=\"form-group \">\r\n\r\n                    <label for=\"form_control_1\">Is Active : ");
            EndContext();
            BeginContext(1656, 14, false);
#line 57 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Details.cshtml"
                                                       Write(Model.IsActive);

#line default
#line hidden
            EndContext();
            BeginContext(1670, 244, true);
            WriteLiteral("</label>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"col-md-5 \">\r\n            <div class=\"col-md-12 \">\r\n                <div class=\"form-group\">\r\n\r\n                    <label for=\"form_control_1\">Mobile : ");
            EndContext();
            BeginContext(1915, 12, false);
#line 66 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Details.cshtml"
                                                    Write(Model.Mobile);

#line default
#line hidden
            EndContext();
            BeginContext(1927, 191, true);
            WriteLiteral("</label>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-12 \">\r\n                <div class=\"form-group\">\r\n\r\n                    <label for=\"form_control_1\">Role : ");
            EndContext();
            BeginContext(2119, 19, false);
#line 72 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Details.cshtml"
                                                  Write(Model.Role.RoleName);

#line default
#line hidden
            EndContext();
            BeginContext(2138, 198, true);
            WriteLiteral("</label>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"col-md-12 \">\r\n                <div class=\"form-group\">\r\n\r\n                    <label for=\"form_control_1\">User Type : ");
            EndContext();
            BeginContext(2337, 27, false);
#line 79 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Details.cshtml"
                                                       Write(Model.UserType.UserTypeName);

#line default
#line hidden
            EndContext();
            BeginContext(2364, 209, true);
            WriteLiteral("</label>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-12 \">\r\n                <div class=\"form-group\">\r\n\r\n                    <label for=\"form_control_1\">Company Representative : ");
            EndContext();
            BeginContext(2574, 29, false);
#line 85 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Details.cshtml"
                                                                    Write(Model.IsCompanyRepresentative);

#line default
#line hidden
            EndContext();
            BeginContext(2603, 311, true);
            WriteLiteral(@"</label>
                </div>
            </div>
        </div>



    </div>
    <!-- END SAMPLE FORM PORTLET-->

    <div class=""form-actions"">
        <div class=""row"" style=""margin-bottom:20px"">
            <div class=""col-md-12"" style=""padding-top: 30px; padding-left:60px"">
                ");
            EndContext();
            BeginContext(2914, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a6a8454c5594d0eabd5a32d83c7f910", async() => {
                BeginContext(2962, 30, true);
                WriteLiteral("<i class=\"fa fa-ban\"></i> Back");
                EndContext();
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
            BeginContext(2996, 60, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<vms.entity.models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
