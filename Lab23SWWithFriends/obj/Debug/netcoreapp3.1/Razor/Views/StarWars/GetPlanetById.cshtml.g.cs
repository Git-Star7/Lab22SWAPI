#pragma checksum "C:\Users\Michael\source\repos\Grand Circus\Week 7\Lab23SWWithFriends\Lab23SWWithFriends\Views\StarWars\GetPlanetById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4111d1933ef217af4b272b9466efd50ccb2bbd5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StarWars_GetPlanetById), @"mvc.1.0.view", @"/Views/StarWars/GetPlanetById.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4111d1933ef217af4b272b9466efd50ccb2bbd5e", @"/Views/StarWars/GetPlanetById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec8a747d7ff572e5de97088ac96bc8968d2939af", @"/Views/_ViewImports.cshtml")]
    public class Views_StarWars_GetPlanetById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Planet>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Michael\source\repos\Grand Circus\Week 7\Lab23SWWithFriends\Lab23SWWithFriends\Views\StarWars\GetPlanetById.cshtml"
  
    ViewData["Title"] = "GetPlanetById";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<h1>Star Wars Planet</h1>

<table class=""table"">
    <tr>
        <th>Name</th>
        <th>Day Length</th>
        <th>Year Length</th>
        <th>Terrain</th>
        <th>Climate</th>
        <th>Population</th>
    </tr>
    <tr>
        <td>");
#nullable restore
#line 20 "C:\Users\Michael\source\repos\Grand Circus\Week 7\Lab23SWWithFriends\Lab23SWWithFriends\Views\StarWars\GetPlanetById.cshtml"
       Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 21 "C:\Users\Michael\source\repos\Grand Circus\Week 7\Lab23SWWithFriends\Lab23SWWithFriends\Views\StarWars\GetPlanetById.cshtml"
       Write(Model.rotation_period);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 22 "C:\Users\Michael\source\repos\Grand Circus\Week 7\Lab23SWWithFriends\Lab23SWWithFriends\Views\StarWars\GetPlanetById.cshtml"
       Write(Model.orbital_period);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 23 "C:\Users\Michael\source\repos\Grand Circus\Week 7\Lab23SWWithFriends\Lab23SWWithFriends\Views\StarWars\GetPlanetById.cshtml"
       Write(Model.terrain);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 24 "C:\Users\Michael\source\repos\Grand Circus\Week 7\Lab23SWWithFriends\Lab23SWWithFriends\Views\StarWars\GetPlanetById.cshtml"
       Write(Model.climate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 25 "C:\Users\Michael\source\repos\Grand Circus\Week 7\Lab23SWWithFriends\Lab23SWWithFriends\Views\StarWars\GetPlanetById.cshtml"
       Write(Model.population);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Planet> Html { get; private set; }
    }
}
#pragma warning restore 1591
