#pragma checksum "C:\Users\shikhajain01\Desktop\shikha-jain\MVC_Assignment\MVC_Assignment\Nagarro.BookReading.Web\Views\Comment\ViewComment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "813afd2e39cfc1cc4aba6faff5e2cf3f1eeea48e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_ViewComment), @"mvc.1.0.view", @"/Views/Comment/ViewComment.cshtml")]
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
#line 1 "C:\Users\shikhajain01\Desktop\shikha-jain\MVC_Assignment\MVC_Assignment\Nagarro.BookReading.Web\Views\_ViewImports.cshtml"
using Nagarro.BookReading.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shikhajain01\Desktop\shikha-jain\MVC_Assignment\MVC_Assignment\Nagarro.BookReading.Web\Views\_ViewImports.cshtml"
using Nagarro.BookReading.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\shikhajain01\Desktop\shikha-jain\MVC_Assignment\MVC_Assignment\Nagarro.BookReading.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"813afd2e39cfc1cc4aba6faff5e2cf3f1eeea48e", @"/Views/Comment/ViewComment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f20a1b69223e6b1c0b253c2fcdf9856c5d56b091", @"/Views/_ViewImports.cshtml")]
    public class Views_Comment_ViewComment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Nagarro.BookReading.Web.Models.CommentViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\shikhajain01\Desktop\shikha-jain\MVC_Assignment\MVC_Assignment\Nagarro.BookReading.Web\Views\Comment\ViewComment.cshtml"
  
    ViewData["Title"] = "View Comment";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ViewComment</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\shikhajain01\Desktop\shikha-jain\MVC_Assignment\MVC_Assignment\Nagarro.BookReading.Web\Views\Comment\ViewComment.cshtml"
       Write(Html.DisplayNameFor(model => model.comment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\shikhajain01\Desktop\shikha-jain\MVC_Assignment\MVC_Assignment\Nagarro.BookReading.Web\Views\Comment\ViewComment.cshtml"
       Write(Html.DisplayFor(model => model.comment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>      \r\n    </dl>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Nagarro.BookReading.Web.Models.CommentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
