#pragma checksum "C:\Codigos\Miniblog.Core-master\Miniblog.Core-master\src\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3373fc89d2651bd4cd3d4aae5b41e1c7ddaea814"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
#line 1 "C:\Codigos\Miniblog.Core-master\Miniblog.Core-master\src\Views\_ViewImports.cshtml"
using Myblog.Core;

#line default
#line hidden
#line 2 "C:\Codigos\Miniblog.Core-master\Miniblog.Core-master\src\Views\_ViewImports.cshtml"
using Myblog.Core.Models;

#line default
#line hidden
#line 3 "C:\Codigos\Miniblog.Core-master\Miniblog.Core-master\src\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#line 4 "C:\Codigos\Miniblog.Core-master\Miniblog.Core-master\src\Views\_ViewImports.cshtml"
using WebEssentials.AspNetCore.Pwa;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3373fc89d2651bd4cd3d4aae5b41e1c7ddaea814", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab07e2c6471fbc9eb38de095ad192aa07a2555d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Codigos\Miniblog.Core-master\Miniblog.Core-master\src\Views\Shared\Error.cshtml"
  
    var statusCode = Model;
    var statusmessage = "";
    switch (statusCode)
    {
        case 400:
            statusmessage = "Bad request: The request cannot be fulfilled due to bad syntax";
            break;
        case 403:
            statusmessage = "Forbidden";
            break;
        case 404:
            statusmessage = "Page not found";
            break;
        case 408:
            statusmessage = "The server timed out waiting for the request";
            break;
        case 500:
            statusmessage = "Internal Server Error - server was unable to finish processing the request";
            break;
        default:
            statusmessage = "That’s odd... Something we didn't expect happened";
            break;
    }

    ViewData["Title"] = statusmessage;

#line default
#line hidden
            BeginContext(813, 39, true);
            WriteLiteral("\n<div class=\"container\">\n    <h1>Error ");
            EndContext();
            BeginContext(853, 5, false);
#line 31 "C:\Codigos\Miniblog.Core-master\Miniblog.Core-master\src\Views\Shared\Error.cshtml"
         Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(858, 13, true);
            WriteLiteral("</h1>\n    <p>");
            EndContext();
            BeginContext(872, 13, false);
#line 32 "C:\Codigos\Miniblog.Core-master\Miniblog.Core-master\src\Views\Shared\Error.cshtml"
  Write(statusmessage);

#line default
#line hidden
            EndContext();
            BeginContext(885, 11, true);
            WriteLiteral("</p>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
