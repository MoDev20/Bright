#pragma checksum "/Users/abdullahimohamud/Desktop/CodeDojo/CSharp/BrightIdeas/Views/Home/BrightIdeas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3baa3b66c822221ef54462f2af1d4cec9ffe082"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BrightIdeas), @"mvc.1.0.view", @"/Views/Home/BrightIdeas.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/BrightIdeas.cshtml", typeof(AspNetCore.Views_Home_BrightIdeas))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3baa3b66c822221ef54462f2af1d4cec9ffe082", @"/Views/Home/BrightIdeas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3089d01e8107546353dc71acbeb0ef609963fe45", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BrightIdeas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Idea>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/newidea"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/abdullahimohamud/Desktop/CodeDojo/CSharp/BrightIdeas/Views/Home/BrightIdeas.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(42, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(55, 119, true);
            WriteLiteral("<div class=\"text-center\">\n    <h1 class=\"display-5\">Bright Ideas Homepage</h1>\n    \n</div >\n<h4>Welcome! Hello Brother ");
            EndContext();
            BeginContext(175, 29, false);
#line 10 "/Users/abdullahimohamud/Desktop/CodeDojo/CSharp/BrightIdeas/Views/Home/BrightIdeas.cshtml"
                      Write(ViewBag.CurrentUser.UserAlias);

#line default
#line hidden
            EndContext();
            BeginContext(204, 32, true);
            WriteLiteral("</h4>\n\n<div class = \"box1\">\n    ");
            EndContext();
            BeginContext(236, 456, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3baa3b66c822221ef54462f2af1d4cec9ffe0825251", async() => {
                BeginContext(298, 42, true);
                WriteLiteral("\n        <div class=\"form-group\">\n        ");
                EndContext();
                BeginContext(340, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3baa3b66c822221ef54462f2af1d4cec9ffe0825670", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 15 "/Users/abdullahimohamud/Desktop/CodeDojo/CSharp/BrightIdeas/Views/Home/BrightIdeas.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserIdea);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(383, 302, true);
                WriteLiteral(@"
        <label class=""btn btn-dark"" for=""UserIdea"">Post Idea:</label>
        <textarea class=""form-control"" rows=""4""  id=""UserIdea"" type=""text"" name=""UserIdea""></textarea>
        <br>
        <input  class=""btn btn-success"" type=""submit"" name=""submit"" value=""Publish your Post!"">
        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(692, 6, true);
            WriteLiteral("\n<hr>\n");
            EndContext();
#line 23 "/Users/abdullahimohamud/Desktop/CodeDojo/CSharp/BrightIdeas/Views/Home/BrightIdeas.cshtml"
  
    foreach (var idea in ViewBag.AllIdeas)
    {

#line default
#line hidden
            BeginContext(750, 50, true);
            WriteLiteral("        <div class=\"container\">\n        <p>Alias: ");
            EndContext();
            BeginContext(801, 22, false);
#line 27 "/Users/abdullahimohamud/Desktop/CodeDojo/CSharp/BrightIdeas/Views/Home/BrightIdeas.cshtml"
             Write(idea.Blogger.UserAlias);

#line default
#line hidden
            EndContext();
            BeginContext(823, 54, true);
            WriteLiteral(" Says....</p>\n        <p class=\"alert alert-warning\" >");
            EndContext();
            BeginContext(878, 13, false);
#line 28 "/Users/abdullahimohamud/Desktop/CodeDojo/CSharp/BrightIdeas/Views/Home/BrightIdeas.cshtml"
                                   Write(idea.UserIdea);

#line default
#line hidden
            EndContext();
            BeginContext(891, 55, true);
            WriteLiteral("</p>\n        </div>\n        <p class=\"btn btn-light\" >\n");
            EndContext();
#line 31 "/Users/abdullahimohamud/Desktop/CodeDojo/CSharp/BrightIdeas/Views/Home/BrightIdeas.cshtml"
             if(idea.UserId == ViewBag.CurrentUser.UserId)
            {

#line default
#line hidden
            BeginContext(1019, 41, true);
            WriteLiteral("                <a class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1060, "\"", 1088, 2);
            WriteAttributeValue("", 1067, "/delete/", 1067, 8, true);
#line 33 "/Users/abdullahimohamud/Desktop/CodeDojo/CSharp/BrightIdeas/Views/Home/BrightIdeas.cshtml"
WriteAttributeValue("", 1075, idea.IdeasId, 1075, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1089, 12, true);
            WriteLiteral(">Delete</a>\n");
            EndContext();
#line 34 "/Users/abdullahimohamud/Desktop/CodeDojo/CSharp/BrightIdeas/Views/Home/BrightIdeas.cshtml"
            }

#line default
#line hidden
            BeginContext(1115, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 35 "/Users/abdullahimohamud/Desktop/CodeDojo/CSharp/BrightIdeas/Views/Home/BrightIdeas.cshtml"
          
            bool print = true;
            foreach (var like in idea.LikedBy)
            {
                if (like.UserId == ViewBag.CurrentUser.UserId)
                    {
                        print = false; 
                    }
            }
            if(print)
            {

#line default
#line hidden
            BeginContext(1415, 42, true);
            WriteLiteral("                <a class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1457, "\"", 1483, 2);
            WriteAttributeValue("", 1464, "/like/", 1464, 6, true);
#line 46 "/Users/abdullahimohamud/Desktop/CodeDojo/CSharp/BrightIdeas/Views/Home/BrightIdeas.cshtml"
WriteAttributeValue("", 1470, idea.IdeasId, 1470, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1484, 10, true);
            WriteLiteral(">Like</a>\n");
            EndContext();
#line 47 "/Users/abdullahimohamud/Desktop/CodeDojo/CSharp/BrightIdeas/Views/Home/BrightIdeas.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1539, 66, true);
            WriteLiteral("                <span class=\"btn btn-info\" >Already Liked!</span>\n");
            EndContext();
#line 51 "/Users/abdullahimohamud/Desktop/CodeDojo/CSharp/BrightIdeas/Views/Home/BrightIdeas.cshtml"
            }
        

#line default
#line hidden
            BeginContext(1629, 32, true);
            WriteLiteral("        Like Post</p>\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1661, "\"", 1694, 2);
            WriteAttributeValue("", 1668, "/BrightIdeas/", 1668, 13, true);
#line 54 "/Users/abdullahimohamud/Desktop/CodeDojo/CSharp/BrightIdeas/Views/Home/BrightIdeas.cshtml"
WriteAttributeValue("", 1681, idea.IdeasId, 1681, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1695, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1697, 18, false);
#line 54 "/Users/abdullahimohamud/Desktop/CodeDojo/CSharp/BrightIdeas/Views/Home/BrightIdeas.cshtml"
                                        Write(idea.LikedBy.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1715, 11, true);
            WriteLiteral(" likes</a>\n");
            EndContext();
#line 55 "/Users/abdullahimohamud/Desktop/CodeDojo/CSharp/BrightIdeas/Views/Home/BrightIdeas.cshtml"
    }

#line default
#line hidden
            BeginContext(1734, 149, true);
            WriteLiteral("</div>\n\n\n<div class=\"box2\">\n    <a href=\"/BrightIdeas\" class=\"btn btn-info\">Bright Ideas</a>\n    <a href=\"/\" class=\"btn btn-danger\">Logout</a>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Idea> Html { get; private set; }
    }
}
#pragma warning restore 1591
