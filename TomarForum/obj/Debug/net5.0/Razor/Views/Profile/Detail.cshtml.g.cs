#pragma checksum "C:\Lessons\ASP.NET\Educational Examples\TomarForum\TomarForum\Views\Profile\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11e1c08dabe822e4084cd6a536f5a8cd133e6ed2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Detail), @"mvc.1.0.view", @"/Views/Profile/Detail.cshtml")]
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
using TomarForumUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Lessons\ASP.NET\Educational Examples\TomarForum\TomarForum\Views\_ViewImports.cshtml"
using TomarForumUI.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Lessons\ASP.NET\Educational Examples\TomarForum\TomarForum\Views\Profile\Detail.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11e1c08dabe822e4084cd6a536f5a8cd133e6ed2", @"/Views/Profile/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0eae1a8d66d5c4620e4bdcfd36ce5acc3bffa792", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TomarForumUI.ViewModels.ApplicationUserViewModel.ProfileViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UploadProfileImage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""container body-content"">
    <div class=""row section-header"">
        <div class=""section-heading"">
            User Profile
        </div>
    </div>
    <div class=""row user-profile"">
        <div class=""col-md-4"">
            <div id=""user-profile-image""");
            BeginWriteAttribute("style", " style=\"", 471, "\"", 523, 3);
            WriteAttributeValue("", 479, "background-image:url(", 479, 21, true);
#nullable restore
#line 14 "C:\Lessons\ASP.NET\Educational Examples\TomarForum\TomarForum\Views\Profile\Detail.cshtml"
WriteAttributeValue("", 500, Model.ProfileImageUrl, 500, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 522, ")", 522, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n");
#nullable restore
#line 15 "C:\Lessons\ASP.NET\Educational Examples\TomarForum\TomarForum\Views\Profile\Detail.cshtml"
             if (User.Identity.Name == Model.UserName)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11e1c08dabe822e4084cd6a536f5a8cd133e6ed25953", async() => {
                WriteLiteral(@"
                    <div id=""upload"">
                        <label class=""btn btn-default btn-file"">
                            Browse<input type=""file"" name=""file"" style=""display:none"" />
                        </label>
                    </div>
                    <button type=""submit"" id=""btn-profile"" class=""btn btn-default"">Submit</button>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 25 "C:\Lessons\ASP.NET\Educational Examples\TomarForum\TomarForum\Views\Profile\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"col-md-8\">\r\n            <span id=\"user-name\">");
#nullable restore
#line 28 "C:\Lessons\ASP.NET\Educational Examples\TomarForum\TomarForum\Views\Profile\Detail.cshtml"
                            Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 29 "C:\Lessons\ASP.NET\Educational Examples\TomarForum\TomarForum\Views\Profile\Detail.cshtml"
             if (@Model.IsAdmin)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"is-admin\">Admin</span>\r\n");
#nullable restore
#line 32 "C:\Lessons\ASP.NET\Educational Examples\TomarForum\TomarForum\Views\Profile\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span id=\"user-rating\">Current Rating: ");
#nullable restore
#line 33 "C:\Lessons\ASP.NET\Educational Examples\TomarForum\TomarForum\Views\Profile\Detail.cshtml"
                                              Write(Model.UserRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <span id=\"lbl-user-email\">Email: ");
#nullable restore
#line 34 "C:\Lessons\ASP.NET\Educational Examples\TomarForum\TomarForum\Views\Profile\Detail.cshtml"
                                        Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <span id=\"lbl-user-created\">Member since: ");
#nullable restore
#line 35 "C:\Lessons\ASP.NET\Educational Examples\TomarForum\TomarForum\Views\Profile\Detail.cshtml"
                                                 Write(Model.MembershipCreatedOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<TomarForumData.EntityModels.ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TomarForumUI.ViewModels.ApplicationUserViewModel.ProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
