#pragma checksum "C:\Users\ADMIN\Documents\projects\Demo\MVC\Views\Student\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc51f39e767176d3da65cd360f30838914842bc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Detail), @"mvc.1.0.view", @"/Views/Student/Detail.cshtml")]
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
#line 1 "C:\Users\ADMIN\Documents\projects\Demo\MVC\Views\_ViewImports.cshtml"
using MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADMIN\Documents\projects\Demo\MVC\Views\_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc51f39e767176d3da65cd360f30838914842bc2", @"/Views/Student/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a8f56340c239c091cff637a00cc2fdf252300", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ADMIN\Documents\projects\Demo\MVC\Views\Student\Detail.cshtml"
  
    ViewData["Title"] = "Student's Detail Page";
    var student = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 7 "C:\Users\ADMIN\Documents\projects\Demo\MVC\Views\Student\Detail.cshtml"
 if (student!=null){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>");
#nullable restore
#line 8 "C:\Users\ADMIN\Documents\projects\Demo\MVC\Views\Student\Detail.cshtml"
   Write(student.StudentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n    <h3>");
#nullable restore
#line 9 "C:\Users\ADMIN\Documents\projects\Demo\MVC\Views\Student\Detail.cshtml"
   Write(student.StudentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n    <h3>");
#nullable restore
#line 10 "C:\Users\ADMIN\Documents\projects\Demo\MVC\Views\Student\Detail.cshtml"
   Write(student.BirthDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n    <h3>");
#nullable restore
#line 11 "C:\Users\ADMIN\Documents\projects\Demo\MVC\Views\Student\Detail.cshtml"
   Write(student.Class.ClassName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n");
#nullable restore
#line 12 "C:\Users\ADMIN\Documents\projects\Demo\MVC\Views\Student\Detail.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
