#pragma checksum "C:\Users\hp\Desktop\Hellow-Good\Hellow\Hellow\Views\Home\GetContacts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5ecb13d91074a632486846c1fadd9bb68a7789b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetContacts), @"mvc.1.0.view", @"/Views/Home/GetContacts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/GetContacts.cshtml", typeof(AspNetCore.Views_Home_GetContacts))]
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
#line 1 "C:\Users\hp\Desktop\Hellow-Good\Hellow\Hellow\Views\_ViewImports.cshtml"
using Hellow;

#line default
#line hidden
#line 2 "C:\Users\hp\Desktop\Hellow-Good\Hellow\Hellow\Views\_ViewImports.cshtml"
using Hellow.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5ecb13d91074a632486846c1fadd9bb68a7789b", @"/Views/Home/GetContacts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a614ba705d1ec94b76b277b390005b32f01f8941", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetContacts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\hp\Desktop\Hellow-Good\Hellow\Hellow\Views\Home\GetContacts.cshtml"
  
    ViewData["Title"] = "GetContacts";

#line default
#line hidden
            BeginContext(49, 76, true);
            WriteLiteral("<table>\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Name</th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\hp\Desktop\Hellow-Good\Hellow\Hellow\Views\Home\GetContacts.cshtml"
     foreach (var r in ViewBag.o)
    {


#line default
#line hidden
            BeginContext(169, 12, true);
            WriteLiteral("        <td>");
            EndContext();
            BeginContext(182, 4, false);
#line 14 "C:\Users\hp\Desktop\Hellow-Good\Hellow\Hellow\Views\Home\GetContacts.cshtml"
       Write(r.Id);

#line default
#line hidden
            EndContext();
            BeginContext(186, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(206, 6, false);
#line 15 "C:\Users\hp\Desktop\Hellow-Good\Hellow\Hellow\Views\Home\GetContacts.cshtml"
       Write(r.Name);

#line default
#line hidden
            EndContext();
            BeginContext(212, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 16 "C:\Users\hp\Desktop\Hellow-Good\Hellow\Hellow\Views\Home\GetContacts.cshtml"

    }

#line default
#line hidden
            BeginContext(228, 10, true);
            WriteLiteral("</table>\r\n");
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