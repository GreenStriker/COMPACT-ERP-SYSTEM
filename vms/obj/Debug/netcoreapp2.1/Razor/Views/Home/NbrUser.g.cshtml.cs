#pragma checksum "E:\personal\New folder\MoneyMoney\vms\Views\Home\NbrUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da1c85b5ae30db176a2762189a4bc28e33bab5c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_NbrUser), @"mvc.1.0.view", @"/Views/Home/NbrUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/NbrUser.cshtml", typeof(AspNetCore.Views_Home_NbrUser))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da1c85b5ae30db176a2762189a4bc28e33bab5c1", @"/Views/Home/NbrUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c551d0fb6d1cb6e33accdc0872f5172ad460dc03", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_NbrUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<vms.entity.models.Organization>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\personal\New folder\MoneyMoney\vms\Views\Home\NbrUser.cshtml"
  
    ViewData["Title"] = "NbrUser";

    Layout = "_LayoutNBR";

#line default
#line hidden
            BeginContext(112, 549, true);
            WriteLiteral(@"
<h2>NBR OFFICIAL DASHBOARD </h2>



<div class=""row"">


    <div class=""col-lg-3 col-md-3 col-sm-6 col-xs-12"">
        <a class=""dashboard-stat dashboard-stat-v2 blue"" href=""#"">
            <div class=""visual"">
                <i class=""fa fa-comments""></i>
            </div>
            <div class=""details"">
                <div class=""number"">
                      <span data-counter=""counterup"" data-value=""105"">0</span>
                </div>
                <div class=""desc"">Total NBR Companies</div>
                <h3>");
            EndContext();
            BeginContext(662, 12, false);
#line 25 "E:\personal\New folder\MoneyMoney\vms\Views\Home\NbrUser.cshtml"
               Write(ViewBag.Name);

#line default
#line hidden
            EndContext();
            BeginContext(674, 2188, true);
            WriteLiteral(@"</h3>
            </div>
        </a>
    </div>

    <div class=""col-lg-3 col-md-3 col-sm-6 col-xs-12"">
        <a class=""dashboard-stat dashboard-stat-v2 purple"" href=""#"">
            <div class=""visual"">
                <i class=""fa fa-globe""></i>
            </div>
            <div class=""details"">
                <div class=""number"">
                    +  <span data-counter=""counterup"" data-value=""45"">0</span>
                </div>
                <div class=""desc"">Total 9.1 Submitions</div>
            </div>
        </a>
    </div>
    <div class=""col-lg-3 col-md-3 col-sm-6 col-xs-12"">
        <a class=""dashboard-stat dashboard-stat-v2 red"" href=""#"">
            <div class=""visual"">
                <i class=""fa fa-bar-chart-o""></i>
            </div>
            <div class=""details"">
                <div class=""number"">
                    +  <span data-counter=""counterup"" data-value=""24"">0</span>
                </div>
                <div class=""desc"">Request To Register ");
            WriteLiteral(@"In NBR</div>
            </div>
        </a>
    </div>
    <div class=""col-lg-3 col-md-3 col-sm-6 col-xs-12"">
        <a class=""dashboard-stat dashboard-stat-v2 green"" href=""#"">
            <div class=""visual"">
                <i class=""fa fa-shopping-cart""></i>
            </div>
            <div class=""details"">
                <div class=""number"">
                    ৳  <span data-counter=""counterup"" data-value=""3,769000.00"">0</span>
                </div>
                <div class=""desc"">Paid TAX (Current Month)</div>
            </div>
        </a>
    </div>

</div>

<div class=""row"">



    <div class=""col-md-6 col-xs-12 border responsive"" style=""border-color:#eee;width: auto; min-height:400px; margin-left:20px; margin-right:20px;"">

        <div id=""donutchart"" style=""min-width:480px; height: 380px; "">

        </div>

    </div>

    <div class=""col-md-6 col-xs-12 border responsive"" style=""border-color:#eee; width: auto;min-height:400px ;margin-right:20px;margin-left");
            WriteLiteral(":20px;\">\r\n\r\n        <div id=\"table_div\" style=\"min-width:480px; height: 380px; \" class=\"responsive\"></div>\r\n    </div>\r\n\r\n\r\n\r\n</div>\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2879, 2017, true);
                WriteLiteral(@"

    <script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
    <script type=""text/javascript"">
      google.charts.load(""current"", {packages:[""corechart""]});
      google.charts.setOnLoadCallback(drawChart);
      function drawChart() {
        var data = google.visualization.arrayToDataTable([
          ['Task', 'Hours per Day'],
            ['NBR Registered',     11],
            ['Requested To Register',  3],
          ['Not Register',  4],
          ['Plased For Aprovel', 7],
         
        ]);

        var options = {
          title: '',
          pieHole: 0.4,
        };

        var chart = new google.visualization.PieChart(document.getElementById('donutchart'));
        chart.draw(data, options);
        }






    </script>


    <script type=""text/javascript"">
        google.charts.load('current', { 'packages': ['table'] });
        google.charts.setOnLoadCallback(drawTable);

        function drawTable() {
            var");
                WriteLiteral(@" data = new google.visualization.DataTable();
            data.addColumn('string', 'Company Name');
            data.addColumn('number', 'Total Submitted Vat');
            data.addColumn('boolean', 'Generated 9.1');
            data.addRows([
                ['OrganizationA', { v: 10000, f: '৳15,00,00,000' }, true],
                ['OrganizationB', { v: 8000, f: '৳1,90,68,70,000' }, false],
                ['OrganizationC', { v: 12500, f: '৳25,20,00,050' }, true],
                ['Aarong', { v: 7000, f: '৳33,90,000' }, true],
                ['Brac', { v: 7000, f: '৳15,07,50,000' }, true],
                ['Aysha Abed Foundation', { v: 7000, f: '৳80,90,03,000' }, true],
                ['Yellow', { v: 7000, f: '৳99,50,02,000' }, true]
            ]);

            var table = new google.visualization.Table(document.getElementById('table_div'));

            table.draw(data, { showRowNumber: true, width: '100%', height: '100%' });
        }
    </script>


");
                EndContext();
            }
            );
            BeginContext(4899, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<vms.entity.models.Organization> Html { get; private set; }
    }
}
#pragma warning restore 1591
