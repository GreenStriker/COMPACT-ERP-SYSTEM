#pragma checksum "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0845b055ead6a04467a7cd4575d7e3cee26a8fe5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Index.cshtml", typeof(AspNetCore.Views_Users_Index))]
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
#line 2 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 3 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#line 7 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
using vms.Utility;

#line default
#line hidden
#line 8 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
using vms.entity.viewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0845b055ead6a04467a7cd4575d7e3cee26a8fe5", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c551d0fb6d1cb6e33accdc0872f5172ad460dc03", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<vms.entity.models.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#line 9 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
  
    var session = Context.Session.GetComplexData<vms.entity.viewModels.vmSession>("session");

#line default
#line hidden
            DefineSection("breadcrumb", async() => {
                BeginContext(314, 64, true);
                WriteLiteral("\r\n    <ul class=\"page-breadcrumb\">\r\n        <li>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 378, "\"", 417, 1);
#line 16 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
WriteAttributeValue("", 385, Url.Action("Dashboard", "Home"), 385, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(418, 96, true);
                WriteLiteral(">Root</a>\r\n            <i class=\"fa fa-circle\"></i>\r\n        </li>\r\n        <li>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 514, "\"", 558, 1);
#line 20 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
WriteAttributeValue("", 521, Url.Action("Index", "Organizations"), 521, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(559, 105, true);
                WriteLiteral(">Adminstration</a>\r\n            <i class=\"fa fa-circle\"></i>\r\n        </li>\r\n        <li>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 664, "\"", 700, 1);
#line 24 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
WriteAttributeValue("", 671, Url.Action("Index", "Users"), 671, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(701, 38, true);
                WriteLiteral(">Users</a>\r\n        </li>\r\n    </ul>\r\n");
                EndContext();
            }
            );
            BeginContext(742, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 29 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
 using (Html.BeginForm("Index", "Users", FormMethod.Get, new { id = "frmProduct" }))
{


#line default
#line hidden
            BeginContext(835, 332, true);
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-md-6"">
            <h1 class=""custom-page-title"">Users</h1>
        </div>
        <div class=""col-md-5"">
            <div class=""input-group Search"" style=""margin-top:10px"">
                <input type=""text"" class=""form-control"" placeholder=""Search..."" id=""search"" name=""search""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1167, "\"", 1194, 1);
#line 38 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
WriteAttributeValue("", 1175, ViewBag.searchText, 1175, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1195, 263, true);
            WriteLiteral(@">
                <span class=""input-group-btn"">
                    <button type=""submit"" class=""btn submit "">
                        <i class=""icon-magnifier""></i>
                    </button>
                </span>
            </div>
        </div>
");
            EndContext();
#line 46 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
         if (UserRole.Check(FeatureList.ADMINSTRATION_USERS_CAN_ADD, session.Rights))
        {

#line default
#line hidden
            BeginContext(1556, 78, true);
            WriteLiteral("            <div class=\"col-md-1\">\r\n                <a style=\"margin-top:10px\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1634, "\"", 1671, 1);
#line 49 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
WriteAttributeValue("", 1641, Url.Action("Create", "Users"), 1641, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1672, 99, true);
            WriteLiteral(" class=\"btn btn-success btn-sm pull-right\"><i class=\"fa fa-plus\"></i> Add</a>\r\n            </div>\r\n");
            EndContext();
#line 51 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1782, 16, true);
            WriteLiteral("        </div>\r\n");
            EndContext();
#line 53 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"

}

#line default
#line hidden
            BeginContext(1803, 132, true);
            WriteLiteral("<table class=\"table table-bordered\">\r\n    <thead>\r\n        <tr>\r\n           \r\n            <th class=\"text-center\">\r\n                ");
            EndContext();
            BeginContext(1936, 44, false);
#line 60 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(1980, 75, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-center\">\r\n                ");
            EndContext();
            BeginContext(2056, 48, false);
#line 63 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(2104, 87, true);
            WriteLiteral("\r\n            </th>\r\n          \r\n            <th class=\"text-center\">\r\n                ");
            EndContext();
            BeginContext(2192, 42, false);
#line 67 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Mobile));

#line default
#line hidden
            EndContext();
            BeginContext(2234, 235, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-center\">\r\n                Status\r\n            </th>\r\n            <th class=\"text-center\">\r\n                Type\r\n            </th>\r\n            <th class=\"text-center\">\r\n                ");
            EndContext();
            BeginContext(2470, 42, false);
#line 76 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RoleId));

#line default
#line hidden
            EndContext();
            BeginContext(2512, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 82 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(2647, 94, true);
            WriteLiteral("            <tr>\r\n              \r\n                <td class=\"text-left\">\r\n                    ");
            EndContext();
            BeginContext(2742, 43, false);
#line 87 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(2785, 85, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-left\">\r\n                    ");
            EndContext();
            BeginContext(2871, 47, false);
#line 90 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(2918, 103, true);
            WriteLiteral("\r\n                </td>\r\n              \r\n                <td class=\"text-center\">\r\n                    ");
            EndContext();
            BeginContext(3022, 41, false);
#line 94 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Mobile));

#line default
#line hidden
            EndContext();
            BeginContext(3063, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 96 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
                 if (item.IsActive)
                {

#line default
#line hidden
            BeginContext(3144, 91, true);
            WriteLiteral("                <td class=\"text-left\">\r\n                    Active\r\n                </td>\r\n");
            EndContext();
#line 101 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(3295, 54, true);
            WriteLiteral("                <td class=\"text-left\">In Active</td>\r\n");
            EndContext();
#line 105 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(3368, 68, true);
            WriteLiteral("                    <td class=\"text-left\">\r\n                        ");
            EndContext();
            BeginContext(3437, 56, false);
#line 107 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.UserType.UserTypeName));

#line default
#line hidden
            EndContext();
            BeginContext(3493, 97, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-left\">\r\n                        ");
            EndContext();
            BeginContext(3591, 48, false);
#line 110 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Role.RoleName));

#line default
#line hidden
            EndContext();
            BeginContext(3639, 609, true);
            WriteLiteral(@"
                    </td>

                <td style=""width:75px;"">
                    <div class=""btn-group"">
                        <div class=""dropdown dropdown-user"">
                            <a style=""text-decoration:none"" href=""javascript:;"" class=""dropdown-toggle"" data-toggle=""dropdown"" data-hover=""dropdown"" data-close-others=""true"">
                                <span class=""""> Action </span>
                                <i class=""fa fa-angle-down""></i>
                            </a>
                            <ul class=""dropdown-menu dropdown-menu-default pull-right"">
");
            EndContext();
#line 121 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
                                 if (UserRole.Check(FeatureList.ADMINSTRATION_USERS_CAN_EDIT, session.Rights))
                                {

#line default
#line hidden
            BeginContext(4395, 82, true);
            WriteLiteral("                                    <li>\r\n                                        ");
            EndContext();
            BeginContext(4477, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cce52649c9814c2fbd7b617ff590cd77", async() => {
                BeginContext(4531, 42, true);
                WriteLiteral("<i class=\"fa fa-pencil-square-o\"></i> Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 124 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
                                                               WriteLiteral(item.EncryptedId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4577, 47, true);
            WriteLiteral("\r\n\r\n                                    </li>\r\n");
            EndContext();
#line 127 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(4659, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 128 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
                                 if (UserRole.Check(FeatureList.ADMINSTRATION_USERS_CAN_VIEW_DETAILS, session.Rights))
                                {

#line default
#line hidden
            BeginContext(4814, 82, true);
            WriteLiteral("                                    <li>\r\n                                        ");
            EndContext();
            BeginContext(4896, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97751f463c0942dab92586223f48e0ba", async() => {
                BeginContext(4955, 34, true);
                WriteLiteral("<i class=\"fa fa-info\"></i> Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-p_id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 131 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
                                                                    WriteLiteral(item.EncryptedId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["p_id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-p_id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["p_id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4993, 45, true);
            WriteLiteral("\r\n                                    </li>\r\n");
            EndContext();
#line 133 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(5073, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 134 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
                                 if (UserRole.Check(FeatureList.ADMINSTRATION_USERS_CAN_DELETE, session.Rights))
                                {

#line default
#line hidden
            BeginContext(5222, 86, true);
            WriteLiteral("                                    <li>\r\n\r\n                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5308, "\"", 5340, 2);
            WriteAttributeValue("", 5315, "Users/Delete/", 5315, 13, true);
#line 138 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
WriteAttributeValue("", 5328, item.UserId, 5328, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5341, 131, true);
            WriteLiteral(" type=\"button\" data-requiredconfirmation=\"true\"><i class=\"fa fa-trash\"></i> Delete</a>\r\n                                    </li>\r\n");
            EndContext();
#line 140 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(5507, 141, true);
            WriteLiteral("                                </ul>\r\n                        </div>\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 146 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(5659, 49, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<div class=\"pager\">\r\n    ");
            EndContext();
            BeginContext(5709, 110, false);
#line 150 "E:\personal\New folder\MoneyMoney\vms\Views\Users\Index.cshtml"
Write(Html.PagedListPager(
        (IPagedList)Model,
        page => Url.Action("Index", new { page })
        ));

#line default
#line hidden
            EndContext();
            BeginContext(5819, 57, true);
            WriteLiteral("\r\n</div>\r\n\r\n<script type=\"text/javascript\">\r\n\r\n</script> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<vms.entity.models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
