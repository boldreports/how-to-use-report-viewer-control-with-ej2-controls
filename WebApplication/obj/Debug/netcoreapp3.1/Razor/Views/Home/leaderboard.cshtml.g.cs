#pragma checksum "C:\Users\RichardBalakrishnan\source\repos\WebApplication\WebApplication\Views\Home\leaderboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95d78404edf802468dd01e878e522de4ad0cb513"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_leaderboard), @"mvc.1.0.view", @"/Views/Home/leaderboard.cshtml")]
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
#line 1 "C:\Users\RichardBalakrishnan\source\repos\WebApplication\WebApplication\Views\_ViewImports.cshtml"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\RichardBalakrishnan\source\repos\WebApplication\WebApplication\Views\_ViewImports.cshtml"
using WebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\RichardBalakrishnan\source\repos\WebApplication\WebApplication\Views\_ViewImports.cshtml"
using BoldReports.TagHelpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95d78404edf802468dd01e878e522de4ad0cb513", @"/Views/Home/leaderboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75e617ea26e75dabe6f476228a9d15faced5e5fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_leaderboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\RichardBalakrishnan\source\repos\WebApplication\WebApplication\Views\Home\leaderboard.cshtml"
  
    ViewData["Title"] = "LeaderBoard";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table"">
    <div id=""top-bar"">
        <div class=""component"">
            <span class=""header"">Components</span>
            <span><i class=""fa fa-angle-right"" style=""font-size:16px""></i></span>
            <span class=""header"">Layouts</span>
            <span><i class=""fa fa-angle-right"" style=""font-size:16px""></i></span>
            <span class=""header"">Avatar</span>
        </div>
    </div>
    <div id=""feature"">
        <div class=""content"">
            <div class=""body-inner"">
                Avatar
            </div>
            <div style=""text-align:left"">
                <div style=""font-size:2vw"">Overview</div>
                <div class=""text"">The ASP.NET MVC Avatar is a pure CSS control used to add initials, icons, or images representing people or objects in different shapes and sizes. Easily integrate the Avatar with other controls like ListView, Card, NavBar, and Badge.</div>
            </div>
            <div style=""padding:2vw 0 2vw 0;text-align:left"">
  ");
            WriteLiteral(@"              <div style=""font-size:1.5vw"">Key Features</div>
                <div class=""text"">
                    <p>1. <b>Types : </b>Provided 2 types of avatars such as default and circle.</p>
                    <p>2. <b>Sizes : </b>Supports 7 different sizes to adapt the various application scenario.</p>
                </div>
            </div>
        </div>
    </div>
</table>");
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
