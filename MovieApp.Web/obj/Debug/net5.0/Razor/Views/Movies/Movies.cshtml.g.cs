#pragma checksum "C:\Users\furka\source\repos\MovieApp\MovieApp.Web\Views\Movies\Movies.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5858262cda01e65b82467f0431a0d38027ea321d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Movies), @"mvc.1.0.view", @"/Views/Movies/Movies.cshtml")]
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
#line 1 "C:\Users\furka\source\repos\MovieApp\MovieApp.Web\Views\_ViewImports.cshtml"
using MovieApp.Web.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\furka\source\repos\MovieApp\MovieApp.Web\Views\_ViewImports.cshtml"
using MovieApp.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5858262cda01e65b82467f0431a0d38027ea321d", @"/Views/Movies/Movies.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30b669909948a695866ce63e47434c89f83f571f", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Movies : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MoviesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Film Listesi</h1>\r\n\r\n\r\n\r\n<div id=\"filmler\">\r\n");
#nullable restore
#line 8 "C:\Users\furka\source\repos\MovieApp\MovieApp.Web\Views\Movies\Movies.cshtml"
     if (Model.Movies.Count() > 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\furka\source\repos\MovieApp\MovieApp.Web\Views\Movies\Movies.cshtml"
         foreach (var movie in Model.Movies)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\furka\source\repos\MovieApp\MovieApp.Web\Views\Movies\Movies.cshtml"
       Write(await Html.PartialAsync("_movie", movie));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\furka\source\repos\MovieApp\MovieApp.Web\Views\Movies\Movies.cshtml"
                                                     
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\furka\source\repos\MovieApp\MovieApp.Web\Views\Movies\Movies.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-warning\">\r\n            film bulunamadı.\r\n        </div>\r\n");
#nullable restore
#line 20 "C:\Users\furka\source\repos\MovieApp\MovieApp.Web\Views\Movies\Movies.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
#nullable restore
#line 23 "C:\Users\furka\source\repos\MovieApp\MovieApp.Web\Views\Movies\Movies.cshtml"
 if (TempData["Message"] != null)
{
    

#line default
#line hidden
#nullable disable
            DefineSection("message", async() => {
                WriteLiteral("\r\n        ");
#nullable restore
#line 27 "C:\Users\furka\source\repos\MovieApp\MovieApp.Web\Views\Movies\Movies.cshtml"
   Write(await Html.PartialAsync("_message", (string)TempData["Message"]));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
            }
            );
#nullable restore
#line 28 "C:\Users\furka\source\repos\MovieApp\MovieApp.Web\Views\Movies\Movies.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("menu", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("    ");
#nullable restore
#line 35 "C:\Users\furka\source\repos\MovieApp\MovieApp.Web\Views\Movies\Movies.cshtml"
Write(await Component.InvokeAsync("Genres"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MoviesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
