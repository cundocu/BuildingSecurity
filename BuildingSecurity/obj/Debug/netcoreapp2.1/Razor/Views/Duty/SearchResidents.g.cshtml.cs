#pragma checksum "C:\Projects\BuildingSecurity\BuildingSecurity\Views\Duty\SearchResidents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b87611b65b628d5036c457d85a82a751ee89258"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Duty_SearchResidents), @"mvc.1.0.view", @"/Views/Duty/SearchResidents.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Duty/SearchResidents.cshtml", typeof(AspNetCore.Views_Duty_SearchResidents))]
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
#line 1 "C:\Projects\BuildingSecurity\BuildingSecurity\Views\_ViewImports.cshtml"
using BuildingSecurity;

#line default
#line hidden
#line 2 "C:\Projects\BuildingSecurity\BuildingSecurity\Views\_ViewImports.cshtml"
using BuildingSecurity.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b87611b65b628d5036c457d85a82a751ee89258", @"/Views/Duty/SearchResidents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e293d28f23ab288a8103915b9ba0dd1e00e179b", @"/Views/_ViewImports.cshtml")]
    public class Views_Duty_SearchResidents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Projects\BuildingSecurity\BuildingSecurity\Views\Duty\SearchResidents.cshtml"
  
    ViewData["Title"] = "SearchResidents";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(100, 30, true);
            WriteLiteral("\r\n<h2>SearchResidents</h2>\r\n\r\n");
            EndContext();
#line 9 "C:\Projects\BuildingSecurity\BuildingSecurity\Views\Duty\SearchResidents.cshtml"
 foreach (string s in Model.buildinglist) {

#line default
#line hidden
            BeginContext(175, 10, true);
            WriteLiteral("    <div> ");
            EndContext();
            BeginContext(186, 1, false);
#line 10 "C:\Projects\BuildingSecurity\BuildingSecurity\Views\Duty\SearchResidents.cshtml"
     Write(s);

#line default
#line hidden
            EndContext();
            BeginContext(187, 10, true);
            WriteLiteral("  </div>\r\n");
            EndContext();
#line 11 "C:\Projects\BuildingSecurity\BuildingSecurity\Views\Duty\SearchResidents.cshtml"
}

#line default
#line hidden
            BeginContext(200, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
