#pragma checksum "F:\1.WORKSHOP\Repos\NPieShop\NPieShop\Views\Shared\Components\ShoppingCartSummary\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b524b9b4934ee41f9a20efc2c9c10dde994e56a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(NPieShop.Pages.Shared.Components.ShoppingCartSummary.Views_Shared_Components_ShoppingCartSummary_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ShoppingCartSummary/Default.cshtml")]
namespace NPieShop.Pages.Shared.Components.ShoppingCartSummary
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
#line 1 "F:\1.WORKSHOP\Repos\NPieShop\NPieShop\Views\_ViewImports.cshtml"
using NPieShop.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\1.WORKSHOP\Repos\NPieShop\NPieShop\Views\_ViewImports.cshtml"
using NPieShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b524b9b4934ee41f9a20efc2c9c10dde994e56a8", @"/Views/Shared/Components/ShoppingCartSummary/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41a031fbd841782d0bf5280142d68ec4bbed6f1a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ShoppingCartSummary_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCartViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\1.WORKSHOP\Repos\NPieShop\NPieShop\Views\Shared\Components\ShoppingCartSummary\Default.cshtml"
 if(Model.ShoppingCart.ShoppingCartItems.Count > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\r\n                    <a>\r\n                        <span class=\"glyphicon glyphicon-shopping-cart\"></span>\r\n                        <span id=\"cart-status\">\r\n                            ");
#nullable restore
#line 9 "F:\1.WORKSHOP\Repos\NPieShop\NPieShop\Views\Shared\Components\ShoppingCartSummary\Default.cshtml"
                       Write(Model.ShoppingCart.ShoppingCartItems.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                    </a>\r\n                </li>\r\n");
#nullable restore
#line 13 "F:\1.WORKSHOP\Repos\NPieShop\NPieShop\Views\Shared\Components\ShoppingCartSummary\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCartViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
