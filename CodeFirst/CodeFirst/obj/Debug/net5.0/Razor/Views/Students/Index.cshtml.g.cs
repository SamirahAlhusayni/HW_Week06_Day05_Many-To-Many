#pragma checksum "C:\Users\HP\source\repos\CodeFirst\CodeFirst\Views\Students\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "994d8573275e9ad2b39a395c8dfaf0ee7234a708"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Index), @"mvc.1.0.view", @"/Views/Students/Index.cshtml")]
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
#line 1 "C:\Users\HP\source\repos\CodeFirst\CodeFirst\Views\_ViewImports.cshtml"
using CodeFirst;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\source\repos\CodeFirst\CodeFirst\Views\_ViewImports.cshtml"
using CodeFirst.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"994d8573275e9ad2b39a395c8dfaf0ee7234a708", @"/Views/Students/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2893f32809c6984f1f4f51fb32c8f7d676103953", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HP\source\repos\CodeFirst\CodeFirst\Views\Students\Index.cshtml"
   
    var Students= (List<Student>)ViewData["Students"];

   // string stName = (string)ViewBag.fullName;
   // var greatThanOne = (List<Student>)ViewData["greatThanOne"];
    


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>FirstCode _ Fetch Data</h1>

<table class=""table table-dark"">
    <thead>
        <tr>

            <td>Id</td>
            <td>Full Name</td>
            <td>last Name</td>
            <td>Email</td>

        </tr>
    </thead>
    
 
    <tbody>
");
#nullable restore
#line 25 "C:\Users\HP\source\repos\CodeFirst\CodeFirst\Views\Students\Index.cshtml"
         foreach (var Student in Students)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\HP\source\repos\CodeFirst\CodeFirst\Views\Students\Index.cshtml"
           Write(Student.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\HP\source\repos\CodeFirst\CodeFirst\Views\Students\Index.cshtml"
           Write(Student.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\HP\source\repos\CodeFirst\CodeFirst\Views\Students\Index.cshtml"
           Write(Student.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\HP\source\repos\CodeFirst\CodeFirst\Views\Students\Index.cshtml"
           Write(Student.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 34 "C:\Users\HP\source\repos\CodeFirst\CodeFirst\Views\Students\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
