#pragma checksum "C:\Users\Michael\source\repos\Grand Circus\Week 7\Lab23SWWithFriends\Lab23SWWithFriends\Views\StarWars\GetPersonById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83bf5bca97cf1d08095d3a53a3c8d13fd2a231b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StarWars_GetPersonById), @"mvc.1.0.view", @"/Views/StarWars/GetPersonById.cshtml")]
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
#line 1 "C:\Users\Michael\source\repos\Grand Circus\Week 7\Lab23SWWithFriends\Lab23SWWithFriends\Views\_ViewImports.cshtml"
using Lab23SWWithFriends;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Michael\source\repos\Grand Circus\Week 7\Lab23SWWithFriends\Lab23SWWithFriends\Views\_ViewImports.cshtml"
using Lab23SWWithFriends.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83bf5bca97cf1d08095d3a53a3c8d13fd2a231b9", @"/Views/StarWars/GetPersonById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec8a747d7ff572e5de97088ac96bc8968d2939af", @"/Views/_ViewImports.cshtml")]
    public class Views_StarWars_GetPersonById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Person>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Michael\source\repos\Grand Circus\Week 7\Lab23SWWithFriends\Lab23SWWithFriends\Views\StarWars\GetPersonById.cshtml"
  
    ViewData["Title"] = "GetPersonById";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Star Wars Character</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Name</th>\r\n        <th>Gender</th>\r\n        <th>Height</th>\r\n        <th>Hair Color</th>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 18 "C:\Users\Michael\source\repos\Grand Circus\Week 7\Lab23SWWithFriends\Lab23SWWithFriends\Views\StarWars\GetPersonById.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 19 "C:\Users\Michael\source\repos\Grand Circus\Week 7\Lab23SWWithFriends\Lab23SWWithFriends\Views\StarWars\GetPersonById.cshtml"
       Write(Model.gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 20 "C:\Users\Michael\source\repos\Grand Circus\Week 7\Lab23SWWithFriends\Lab23SWWithFriends\Views\StarWars\GetPersonById.cshtml"
       Write(Model.height);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 21 "C:\Users\Michael\source\repos\Grand Circus\Week 7\Lab23SWWithFriends\Lab23SWWithFriends\Views\StarWars\GetPersonById.cshtml"
       Write(Model.hair_color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Person> Html { get; private set; }
    }
}
#pragma warning restore 1591
