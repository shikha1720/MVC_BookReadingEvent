#pragma checksum "C:\Users\shikhajain01\OneDrive - Nagarro\Desktop\MVC_Assignment\Nagarro.BookReading.Web\Views\Comment\GetComments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be5083ed22b6bce66bafdff8bf09bcd86dffd3ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_GetComments), @"mvc.1.0.view", @"/Views/Comment/GetComments.cshtml")]
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
#line 1 "C:\Users\shikhajain01\OneDrive - Nagarro\Desktop\MVC_Assignment\Nagarro.BookReading.Web\Views\_ViewImports.cshtml"
using Nagarro.BookReading.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shikhajain01\OneDrive - Nagarro\Desktop\MVC_Assignment\Nagarro.BookReading.Web\Views\_ViewImports.cshtml"
using Nagarro.BookReading.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\shikhajain01\OneDrive - Nagarro\Desktop\MVC_Assignment\Nagarro.BookReading.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be5083ed22b6bce66bafdff8bf09bcd86dffd3ed", @"/Views/Comment/GetComments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f20a1b69223e6b1c0b253c2fcdf9856c5d56b091", @"/Views/_ViewImports.cshtml")]
    public class Views_Comment_GetComments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Nagarro.BookReading.Web.Models.CommentViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\shikhajain01\OneDrive - Nagarro\Desktop\MVC_Assignment\Nagarro.BookReading.Web\Views\Comment\GetComments.cshtml"
  
    ViewData["Title"] = "Fetch Comment";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n           \r\n            <th>\r\n                ");
#nullable restore
#line 11 "C:\Users\shikhajain01\OneDrive - Nagarro\Desktop\MVC_Assignment\Nagarro.BookReading.Web\Views\Comment\GetComments.cshtml"
           Write(Html.DisplayNameFor(model => model.comment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\shikhajain01\OneDrive - Nagarro\Desktop\MVC_Assignment\Nagarro.BookReading.Web\Views\Comment\GetComments.cshtml"
           Write(Html.DisplayNameFor(model => model.timeStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 20 "C:\Users\shikhajain01\OneDrive - Nagarro\Desktop\MVC_Assignment\Nagarro.BookReading.Web\Views\Comment\GetComments.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                \r\n                <td>\r\n                    ");
#nullable restore
#line 25 "C:\Users\shikhajain01\OneDrive - Nagarro\Desktop\MVC_Assignment\Nagarro.BookReading.Web\Views\Comment\GetComments.cshtml"
               Write(Html.DisplayFor(modelItem => item.comment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 28 "C:\Users\shikhajain01\OneDrive - Nagarro\Desktop\MVC_Assignment\Nagarro.BookReading.Web\Views\Comment\GetComments.cshtml"
               Write(Html.DisplayFor(modelItem => item.timeStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                \r\n            </tr>\r\n");
#nullable restore
#line 32 "C:\Users\shikhajain01\OneDrive - Nagarro\Desktop\MVC_Assignment\Nagarro.BookReading.Web\Views\Comment\GetComments.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Nagarro.BookReading.Web.Models.CommentViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
