#pragma checksum "/Users/abdullahimohamud/Desktop/CodeDojo/CSharp/BrightIdeas/Views/Home/UserInform.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37614f31e8967601c6ffa47170dc9fe484cd49d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserInform), @"mvc.1.0.view", @"/Views/Home/UserInform.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/UserInform.cshtml", typeof(AspNetCore.Views_Home_UserInform))]
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
#line 1 "/Users/abdullahimohamud/Desktop/CodeDojo/CSharp/BrightIdeas/Views/_ViewImports.cshtml"
using BrightIdeas;

#line default
#line hidden
#line 2 "/Users/abdullahimohamud/Desktop/CodeDojo/CSharp/BrightIdeas/Views/_ViewImports.cshtml"
using BrightIdeas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37614f31e8967601c6ffa47170dc9fe484cd49d1", @"/Views/Home/UserInform.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3089d01e8107546353dc71acbeb0ef609963fe45", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserInform : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/abdullahimohamud/Desktop/CodeDojo/CSharp/BrightIdeas/Views/Home/UserInform.cshtml"
  
    ViewData["Title"] = "BrightIdeas: Bright Ideas - UserInfor";

#line default
#line hidden
            BeginContext(70, 61, true);
            WriteLiteral("<div class = \"box1\"> \n<ul>\n  <li class=\"btn btn-info\" >Name: ");
            EndContext();
            BeginContext(132, 29, false);
#line 6 "/Users/abdullahimohamud/Desktop/CodeDojo/CSharp/BrightIdeas/Views/Home/UserInform.cshtml"
                             Write(ViewBag.SelectedUser.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(161, 52, true);
            WriteLiteral("</li>\n  <li class=\"btn btn-outline-success\" >Alias: ");
            EndContext();
            BeginContext(214, 30, false);
#line 7 "/Users/abdullahimohamud/Desktop/CodeDojo/CSharp/BrightIdeas/Views/Home/UserInform.cshtml"
                                         Write(ViewBag.SelectedUser.UserAlias);

#line default
#line hidden
            EndContext();
            BeginContext(244, 52, true);
            WriteLiteral("</li>\n  <li class=\"btn btn-outline-success\" >Email: ");
            EndContext();
            BeginContext(297, 26, false);
#line 8 "/Users/abdullahimohamud/Desktop/CodeDojo/CSharp/BrightIdeas/Views/Home/UserInform.cshtml"
                                         Write(ViewBag.SelectedUser.Email);

#line default
#line hidden
            EndContext();
            BeginContext(323, 82, true);
            WriteLiteral("</li>\n</ul>\n<hr>\n<h1><p>Total number of Ideas:<span class=\"badge badge-secondary\">");
            EndContext();
            BeginContext(406, 37, false);
#line 11 "/Users/abdullahimohamud/Desktop/CodeDojo/CSharp/BrightIdeas/Views/Home/UserInform.cshtml"
                                                            Write(ViewBag.SelectedUser.UsersIdeas.Count);

#line default
#line hidden
            EndContext();
            BeginContext(443, 74, true);
            WriteLiteral("</span> </p></h1>\n<h1><p>People Who Liked :<span class=\"badge badge-info\">");
            EndContext();
            BeginContext(518, 36, false);
#line 12 "/Users/abdullahimohamud/Desktop/CodeDojo/CSharp/BrightIdeas/Views/Home/UserInform.cshtml"
                                                   Write(ViewBag.SelectedUser.UserLikes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(554, 166, true);
            WriteLiteral("</span> </p></h1>\n</div>\n\n<div class=\"box2\">\n    <a href=\"/BrightIdeas\" class=\"btn btn-info\">Bright Ideas</a>\n    <a href=\"/\" class=\"btn btn-danger\">Logout</a>\n</div>");
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
