#pragma checksum "C:\Users\admin\Source\Repos\darylkouk\ShoppingCart\Views\Home\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f113c8313304390c9673b24731278659159afc3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Cart), @"mvc.1.0.view", @"/Views/Home/Cart.cshtml")]
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
#line 1 "C:\Users\admin\Source\Repos\darylkouk\ShoppingCart\Views\_ViewImports.cshtml"
using ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Source\Repos\darylkouk\ShoppingCart\Views\_ViewImports.cshtml"
using ShoppingCart.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f113c8313304390c9673b24731278659159afc3b", @"/Views/Home/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a65a8198b297c3ea7f3bc4f7f8cdac67c148a265", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\admin\Source\Repos\darylkouk\ShoppingCart\Views\Home\Cart.cshtml"
  
    ViewData["Title"] = "Cart";
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""table-responsive text-nowrap"">
    <table class=""table"">
        <thead><tr><td><h2>Cart</h2></td></tr></thead>
        <thead>
            <tr>
                <th scope=""col""></th>
                <th scope=""col"">Name</th>
                <th scope=""col"">Description</th>
                <th scope=""col"">Genere</th>
                <th scope=""col"">Price</th>
                <th scope=""col"">Quantity</th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <th scope=""row""></th>
                <td>Cell</td>
                <td>Cell</td>
                <td>Cell</td>
                <td>Cell</td>
                <td>Cell</td>
                <td>
                    <button id=""minus"" class=""btn btn-primary btn-sm"">-</button>
                    <span id=""number"" style=""padding:6px"">0</span>
                    <button id=""plus"" class=""btn btn-primary btn-sm"">+</button>
                </td>
           ");
            WriteLiteral(@" </tr>
            <tr>
                <th scope=""row""></th>
                <td>Cell</td>
                <td>Cell</td>
                <td>Cell</td>
                <td>Cell</td>
                <td>Cell</td>
                <td>
                    <button id=""minus"" class=""btn btn-primary btn-sm"">-</button>
                    <span id=""number"" style=""padding:6px"">0</span>
                    <button id=""plus"" class=""btn btn-primary btn-sm"">+</button>
                </td>
            </tr>
            <tr>
                <th scope=""row""></th>
                <td>Cell</td>
                <td>Cell</td>
                <td>Cell</td>
                <td>Cell</td>
                <td>Cell</td>
                <td>
                    <button id=""minus"" class=""btn btn-primary btn-sm"">-</button>
                    <span id=""number"" style=""padding:6px"">0</span>
                    <button id=""plus"" class=""btn btn-primary btn-sm"">+</button>
                </td>
            </tr>
  ");
            WriteLiteral(@"      </tbody>
        <tbody>
            <tr>
                <td scope=""col"" colspan=""5"">
                    <u><a href=""/Home/Gallery"">Continue Shopping</a></u>
                </td>
                <td scope=""col"">Total</td>
                <td scope=""col"">111111</td>
            </tr>
            <tr>
                <td colspan=""6""></td>
                <td scope=""col"">
                    <button type=""button"" class=""btn btn-primary"">Procced to check out</button>
                </td>
            </tr>
        </tbody>
       
    </table>

</div>


");
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
