#pragma checksum "E:\Projects\TomarForum\TomarForumUI\Views\Shared\Components\Footer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dee417ea69e9f17d7b1996f51c7858a8bf6d753c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Footer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Footer/Default.cshtml")]
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
#line 1 "E:\Projects\TomarForum\TomarForumUI\Views\_ViewImports.cshtml"
using TomarForumUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\TomarForum\TomarForumUI\Views\_ViewImports.cshtml"
using TomarForumViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dee417ea69e9f17d7b1996f51c7858a8bf6d753c", @"/Views/Shared/Components/Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d988ba2840277484357ab5c2e27c566601ba0513", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Privacy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("<!--Footer-->\r\n");
            WriteLiteral(@"
<footer>
    <div class=""footer-top"">
        <div class=""container"">
            <div class=""row"">
                <div class=""footer-about col-md-4 col-lg-4 wow fadeInUp animated"" style=""visibility: visible; animation-name: fadeInUp;"">
                    <img class=""logo-footer"" src=""/img/logo.png"" alt=""logo"" data-at2x=""assets/img/logo.png"">
                    <p>
                        Thank you for visiting our website.
                    </p>
                    <p><a href=""#"">Our Team</a></p>
                </div>
                <div class=""footer-contact col-md-4 col-lg-4 offset-lg-1 wow fadeInDown animated"" style=""visibility: visible; animation-name: fadeInDown;"">
                    <h3>Contact</h3>
                    <p><i class=""fas fa-map-marker-alt""></i> Arsuz 31225, Hatay TURKEY</p>
                    <p><i class=""fas fa-phone""></i> Phone: (0090) 549 268 1421</p></li>
                    <p><i class=""fas fa-envelope""></i> Email: <a href=""mailto:metekaba96@gmail.com"">mete");
            WriteLiteral(@"kaba96@gmail.com</a></p>
                    <p><i class=""fab fa-skype""></i> Skype: live:metekaba</p>
                </div>
                <div class=""footer-social col-md-4 col-lg-3 wow fadeInUp animated"" style=""visibility: visible; animation-name: fadeInUp;"">
                    <h3>Follow us</h3>
                    <p>
                        <a href=""https://www.instagram.com/metekaba/?hl=en""><i class=""fab fa-instagram""></i></a>
                        <a href=""https://www.linkedin.com/in/mete-kaba-89b5221b8/""><i class=""fab fa-linkedin""></i></a>
                        <a href=""https://github.com/MeteK7""><i class=""fab fa-github""></i></a>
                    </p>
                </div>
            </div>
        </div>
    </div>
    <div class=""footer-bottom"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-5 footer-copyright"">
                    <p>&copy; ");
#nullable restore
#line 41 "E:\Projects\TomarForum\TomarForumUI\Views\Shared\Components\Footer\Default.cshtml"
                         Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - TomarForum - ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dee417ea69e9f17d7b1996f51c7858a8bf6d753c6384", async() => {
                WriteLiteral("Privacy");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</footer>");
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
