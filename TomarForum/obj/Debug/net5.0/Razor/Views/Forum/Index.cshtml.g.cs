#pragma checksum "C:\Lessons\ASP.NET\Educational Examples\TomarForum\TomarForum\Views\Forum\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8534a42f09c36b591e81be0d2a20b1ed2d47f7c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Forum_Index), @"mvc.1.0.view", @"/Views/Forum/Index.cshtml")]
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
#line 1 "C:\Lessons\ASP.NET\Educational Examples\TomarForum\TomarForum\Views\_ViewImports.cshtml"
using TomarForum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Lessons\ASP.NET\Educational Examples\TomarForum\TomarForum\Views\_ViewImports.cshtml"
using TomarForum.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8534a42f09c36b591e81be0d2a20b1ed2d47f7c2", @"/Views/Forum/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d15f68a43f71f435fdbacb01ddbecacb59a8ce41", @"/Views/_ViewImports.cshtml")]
    public class Views_Forum_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TomarForumUI.ViewModels.ForumViewModels.ForumIndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Forums</h1>\r\n\r\n<table class=\"table table-hover\" id=\"forum-index-table\">\r\n    <tbody>\r\n");
#nullable restore
#line 7 "C:\Lessons\ASP.NET\Educational Examples\TomarForum\TomarForum\Views\Forum\Index.cshtml"
         foreach (var forum in Model.ForumList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 11 "C:\Lessons\ASP.NET\Educational Examples\TomarForum\TomarForum\Views\Forum\Index.cshtml"
               Write(forum.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 14 "C:\Lessons\ASP.NET\Educational Examples\TomarForum\TomarForum\Views\Forum\Index.cshtml"
               Write(forum.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 17 "C:\Lessons\ASP.NET\Educational Examples\TomarForum\TomarForum\Views\Forum\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TomarForumUI.ViewModels.ForumViewModels.ForumIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
