#pragma checksum "C:\Users\Anca\source\repos\carmen-iagar23\situatie-salarii\CalculatorSalarii\CalculatorSalarii\Views\StatPlata\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0336bd7e8f2e461fa8a44a2add34890793b1a59a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StatPlata_Index), @"mvc.1.0.view", @"/Views/StatPlata/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Anca\source\repos\carmen-iagar23\situatie-salarii\CalculatorSalarii\CalculatorSalarii\Views\_ViewImports.cshtml"
using CalculatorSalarii;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anca\source\repos\carmen-iagar23\situatie-salarii\CalculatorSalarii\CalculatorSalarii\Views\_ViewImports.cshtml"
using CalculatorSalarii.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0336bd7e8f2e461fa8a44a2add34890793b1a59a", @"/Views/StatPlata/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8efc0d4f3c6e4632ecf15e2e3bf6e8bf58e76bb4", @"/Views/_ViewImports.cshtml")]
    public class Views_StatPlata_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CalculatorSalarii.Models.StatPlata>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Anca\source\repos\carmen-iagar23\situatie-salarii\CalculatorSalarii\CalculatorSalarii\Views\StatPlata\Index.cshtml"
  
    ViewData["Title"] = "Stat de plata";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Stat de plata</h1>\r\n\r\n<table class=\"table table-striped\">\r\n    <thead class=\"bg-primary text-light\">\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Anca\source\repos\carmen-iagar23\situatie-salarii\CalculatorSalarii\CalculatorSalarii\Views\StatPlata\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Angajat.Nume));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 16 "C:\Users\Anca\source\repos\carmen-iagar23\situatie-salarii\CalculatorSalarii\CalculatorSalarii\Views\StatPlata\Index.cshtml"
                                                             Write(Html.DisplayNameFor(model => model.Angajat.Prenume));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Anca\source\repos\carmen-iagar23\situatie-salarii\CalculatorSalarii\CalculatorSalarii\Views\StatPlata\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Angajat.VenitBrut));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Anca\source\repos\carmen-iagar23\situatie-salarii\CalculatorSalarii\CalculatorSalarii\Views\StatPlata\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ContributieCAS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />(25%)\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\Anca\source\repos\carmen-iagar23\situatie-salarii\CalculatorSalarii\CalculatorSalarii\Views\StatPlata\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ContributieCASS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />(10%)\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\Anca\source\repos\carmen-iagar23\situatie-salarii\CalculatorSalarii\CalculatorSalarii\Views\StatPlata\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DeducerePersonala));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\Anca\source\repos\carmen-iagar23\situatie-salarii\CalculatorSalarii\CalculatorSalarii\Views\StatPlata\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SumaImpozit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />(10%)\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\Anca\source\repos\carmen-iagar23\situatie-salarii\CalculatorSalarii\CalculatorSalarii\Views\StatPlata\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SalariuNet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 42 "C:\Users\Anca\source\repos\carmen-iagar23\situatie-salarii\CalculatorSalarii\CalculatorSalarii\Views\StatPlata\Index.cshtml"
     foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class=\"font-weight-bold\">\r\n                ");
#nullable restore
#line 45 "C:\Users\Anca\source\repos\carmen-iagar23\situatie-salarii\CalculatorSalarii\CalculatorSalarii\Views\StatPlata\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Angajat.Nume));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 45 "C:\Users\Anca\source\repos\carmen-iagar23\situatie-salarii\CalculatorSalarii\CalculatorSalarii\Views\StatPlata\Index.cshtml"
                                                            Write(Html.DisplayFor(modelItem => item.Angajat.Prenume));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"font-weight-bold\">\r\n                ");
#nullable restore
#line 48 "C:\Users\Anca\source\repos\carmen-iagar23\situatie-salarii\CalculatorSalarii\CalculatorSalarii\Views\StatPlata\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Angajat.VenitBrut));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "C:\Users\Anca\source\repos\carmen-iagar23\situatie-salarii\CalculatorSalarii\CalculatorSalarii\Views\StatPlata\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ContributieCAS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "C:\Users\Anca\source\repos\carmen-iagar23\situatie-salarii\CalculatorSalarii\CalculatorSalarii\Views\StatPlata\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ContributieCASS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 57 "C:\Users\Anca\source\repos\carmen-iagar23\situatie-salarii\CalculatorSalarii\CalculatorSalarii\Views\StatPlata\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DeducerePersonala));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "C:\Users\Anca\source\repos\carmen-iagar23\situatie-salarii\CalculatorSalarii\CalculatorSalarii\Views\StatPlata\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SumaImpozit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"font-weight-bold\">\r\n                ");
#nullable restore
#line 63 "C:\Users\Anca\source\repos\carmen-iagar23\situatie-salarii\CalculatorSalarii\CalculatorSalarii\Views\StatPlata\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SalariuNet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 66 "C:\Users\Anca\source\repos\carmen-iagar23\situatie-salarii\CalculatorSalarii\CalculatorSalarii\Views\StatPlata\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    <tfoot class=\"bg-primary text-light font-weight-bold\">\r\n        <tr>\r\n            <td>\r\n                TOTAL\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 74 "C:\Users\Anca\source\repos\carmen-iagar23\situatie-salarii\CalculatorSalarii\CalculatorSalarii\Views\StatPlata\Index.cshtml"
           Write(Model.Sum(m => m.Angajat.VenitBrut));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 77 "C:\Users\Anca\source\repos\carmen-iagar23\situatie-salarii\CalculatorSalarii\CalculatorSalarii\Views\StatPlata\Index.cshtml"
           Write(Model.Sum(m => m.ContributieCAS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 80 "C:\Users\Anca\source\repos\carmen-iagar23\situatie-salarii\CalculatorSalarii\CalculatorSalarii\Views\StatPlata\Index.cshtml"
           Write(Model.Sum(m => m.ContributieCASS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "C:\Users\Anca\source\repos\carmen-iagar23\situatie-salarii\CalculatorSalarii\CalculatorSalarii\Views\StatPlata\Index.cshtml"
           Write(Model.Sum(m => m.SumaImpozit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 88 "C:\Users\Anca\source\repos\carmen-iagar23\situatie-salarii\CalculatorSalarii\CalculatorSalarii\Views\StatPlata\Index.cshtml"
           Write(Model.Sum(m => m.SalariuNet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </tfoot>\r\n</table>\r\n\r\n<hr />\r\n<h4>Contributia CAM (2.25%): ");
#nullable restore
#line 95 "C:\Users\Anca\source\repos\carmen-iagar23\situatie-salarii\CalculatorSalarii\CalculatorSalarii\Views\StatPlata\Index.cshtml"
                        Write(Model.Sum(m => m.SumaCAM));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Lei</h4>\r\n<hr />\r\n<h5>Total cheltuieli firma: ");
#nullable restore
#line 97 "C:\Users\Anca\source\repos\carmen-iagar23\situatie-salarii\CalculatorSalarii\CalculatorSalarii\Views\StatPlata\Index.cshtml"
                       Write(Model.Sum(m => (m.Angajat.VenitBrut + m.SumaCAM)));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Lei</h5>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IEnumerable<CalculatorSalarii.Data.CalculatorSalariiContext> Context { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CalculatorSalarii.Models.StatPlata>> Html { get; private set; }
    }
}
#pragma warning restore 1591
