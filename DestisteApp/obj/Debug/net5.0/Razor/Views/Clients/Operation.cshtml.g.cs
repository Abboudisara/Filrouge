#pragma checksum "C:\Users\Youcode\Desktop\Filrouge\DestisteApp\Views\Clients\Operation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d18bf12a9270b394b71e486c6bca23d2847c673"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Operation), @"mvc.1.0.view", @"/Views/Clients/Operation.cshtml")]
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
#line 1 "C:\Users\Youcode\Desktop\Filrouge\DestisteApp\Views\_ViewImports.cshtml"
using DestisteApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Youcode\Desktop\Filrouge\DestisteApp\Views\_ViewImports.cshtml"
using DestisteApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d18bf12a9270b394b71e486c6bca23d2847c673", @"/Views/Clients/Operation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3c47758619e837ad5fe94b49747b34dc3afbe41", @"/Views/_ViewImports.cshtml")]
    public class Views_Clients_Operation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DestisteApp.Models.OperationModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Youcode\Desktop\Filrouge\DestisteApp\Views\Clients\Operation.cshtml"
  
    ViewData["Title"] = "Operation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Operation</h1>\r\n\r\n<p>\r\n    <a >Operation Dr Mahmoud</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Youcode\Desktop\Filrouge\DestisteApp\Views\Clients\Operation.cshtml"
           Write(Html.DisplayNameFor(model => model.Operation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Youcode\Desktop\Filrouge\DestisteApp\Views\Clients\Operation.cshtml"
           Write(Html.DisplayNameFor(model => model.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\Youcode\Desktop\Filrouge\DestisteApp\Views\Clients\Operation.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n");
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\Youcode\Desktop\Filrouge\DestisteApp\Views\Clients\Operation.cshtml"
           Write(Html.DisplayFor(modelItem => item.Operation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\Youcode\Desktop\Filrouge\DestisteApp\Views\Clients\Operation.cshtml"
           Write(Html.DisplayFor(modelItem => item.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 45 "C:\Users\Youcode\Desktop\Filrouge\DestisteApp\Views\Clients\Operation.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DestisteApp.Models.OperationModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
