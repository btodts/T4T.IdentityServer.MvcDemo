#pragma checksum "C:\T4T\T4T.IdentityServer.MvcDemo\src\T4T.IdentityServer.MvcDemo\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0c043097130ee15e32fd7f6ffa7a64a2bdf20e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\T4T\T4T.IdentityServer.MvcDemo\src\T4T.IdentityServer.MvcDemo\Views\_ViewImports.cshtml"
using T4T.IdentityServer.MvcDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\T4T\T4T.IdentityServer.MvcDemo\src\T4T.IdentityServer.MvcDemo\Views\_ViewImports.cshtml"
using T4T.IdentityServer.MvcDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\T4T\T4T.IdentityServer.MvcDemo\src\T4T.IdentityServer.MvcDemo\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0c043097130ee15e32fd7f6ffa7a64a2bdf20e0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3494d9099466f4f14a2609ea64cc657f8e8a4d9d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\T4T\T4T.IdentityServer.MvcDemo\src\T4T.IdentityServer.MvcDemo\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n\r\n</div>\r\n\r\n<h2>Claims</h2>\r\n\r\n<dl>\r\n");
#nullable restore
#line 14 "C:\T4T\T4T.IdentityServer.MvcDemo\src\T4T.IdentityServer.MvcDemo\Views\Home\Index.cshtml"
     foreach (var claim in User.Claims)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt>");
#nullable restore
#line 16 "C:\T4T\T4T.IdentityServer.MvcDemo\src\T4T.IdentityServer.MvcDemo\Views\Home\Index.cshtml"
       Write(claim.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd>");
#nullable restore
#line 17 "C:\T4T\T4T.IdentityServer.MvcDemo\src\T4T.IdentityServer.MvcDemo\Views\Home\Index.cshtml"
       Write(claim.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n");
#nullable restore
#line 18 "C:\T4T\T4T.IdentityServer.MvcDemo\src\T4T.IdentityServer.MvcDemo\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</dl>");
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