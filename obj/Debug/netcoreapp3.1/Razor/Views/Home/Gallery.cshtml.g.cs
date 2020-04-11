#pragma checksum "C:\Users\User\iCloudDrive\GdipSA\Netcore\CA\Github\ShoppingCart\Views\Home\Gallery.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52a4f8f5198315b0e542797a246d0911e585d35f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Gallery), @"mvc.1.0.view", @"/Views/Home/Gallery.cshtml")]
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
#line 1 "C:\Users\User\iCloudDrive\GdipSA\Netcore\CA\Github\ShoppingCart\Views\_ViewImports.cshtml"
using ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\iCloudDrive\GdipSA\Netcore\CA\Github\ShoppingCart\Views\_ViewImports.cshtml"
using ShoppingCart.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52a4f8f5198315b0e542797a246d0911e585d35f", @"/Views/Home/Gallery.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a65a8198b297c3ea7f3bc4f7f8cdac67c148a265", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Gallery : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCart.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("SearchBar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\iCloudDrive\GdipSA\Netcore\CA\Github\ShoppingCart\Views\Home\Gallery.cshtml"
  
    ViewData["Title"] = "Gallery";
    List<Product> DisplayProducts = (List<Product>)ViewData["AllProducts"];
    if (ViewData["search"] != null)
        DisplayProducts = (List<Product>)ViewData["search"];
    //hmmm...

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"GalleryHeader\">\r\n    <div class=\"GalleryWelcome\">\r\n        <p>Welcome to Our Gallery Page!\r\n        </p>\r\n    </div>\r\n    <div class=\'GallerySearch\'>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52a4f8f5198315b0e542797a246d0911e585d35f5600", async() => {
                WriteLiteral(@"
            <img src=""/images/search.png"" width=""25"" style=""float:left;"">
            <input type=""text"" name=""searchInput"" id=""search"" placeholder=""Enter your search here..."" style=""float:left;"">
            &nbsp;&nbsp;<button type=""submit"" value=""search"">Search</button>
        ");
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
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<br>\r\n<br>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52a4f8f5198315b0e542797a246d0911e585d35f7541", async() => {
                WriteLiteral("\r\n    <div class=\"GalleryMain\" align=\"left\">\r\n");
#nullable restore
#line 27 "C:\Users\User\iCloudDrive\GdipSA\Netcore\CA\Github\ShoppingCart\Views\Home\Gallery.cshtml"
          
            if (DisplayProducts.Count() == 0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p>No Search Results</p>\r\n");
#nullable restore
#line 31 "C:\Users\User\iCloudDrive\GdipSA\Netcore\CA\Github\ShoppingCart\Views\Home\Gallery.cshtml"
            }
            else
            {
                foreach (Product p in DisplayProducts)
                {
                    string img = "/images/" + p.Name.Replace(":", "") + ".jpg";
                    string productName = p.Name;
                    string productGenre = p.Genre;
                    string productDesc = p.Description.Substring(0, 35) + "...";
                    double productPrice = p.Price;
                    string formactionAddToCart = "/Home/Gallery?cmd=AddToCart&ProductId=" + p.Id;

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"GalleryProduct\">\r\n                        <div class=\"GalleryProductPicture\" align=\"center\">\r\n                            <img");
                BeginWriteAttribute("src", " src=\"", 1707, "\"", 1717, 1);
#nullable restore
#line 44 "C:\Users\User\iCloudDrive\GdipSA\Netcore\CA\Github\ShoppingCart\Views\Home\Gallery.cshtml"
WriteAttributeValue("", 1713, img, 1713, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\'125\' height=\'150\' ;>\r\n                        </div>\r\n                        <p><span class=\"ProductGenre\">");
#nullable restore
#line 46 "C:\Users\User\iCloudDrive\GdipSA\Netcore\CA\Github\ShoppingCart\Views\Home\Gallery.cshtml"
                                                 Write(productGenre);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span></p>\r\n                        <p>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52a4f8f5198315b0e542797a246d0911e585d35f9906", async() => {
                    WriteLiteral("<span class=\"ProductName\">");
#nullable restore
#line 47 "C:\Users\User\iCloudDrive\GdipSA\Netcore\CA\Github\ShoppingCart\Views\Home\Gallery.cshtml"
                                                                                                                                    Write(productName);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</span>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-selected", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\User\iCloudDrive\GdipSA\Netcore\CA\Github\ShoppingCart\Views\Home\Gallery.cshtml"
                                                                                     WriteLiteral(productName);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["selected"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-selected", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["selected"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</p>\r\n");
#nullable restore
#line 48 "C:\Users\User\iCloudDrive\GdipSA\Netcore\CA\Github\ShoppingCart\Views\Home\Gallery.cshtml"
                          if (productName.Length < 31)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("<br>");
#nullable restore
#line 49 "C:\Users\User\iCloudDrive\GdipSA\Netcore\CA\Github\ShoppingCart\Views\Home\Gallery.cshtml"
                                 }
                        

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <span class=\"ProductDesc\">&nbsp;&nbsp;");
#nullable restore
#line 51 "C:\Users\User\iCloudDrive\GdipSA\Netcore\CA\Github\ShoppingCart\Views\Home\Gallery.cshtml"
                                                         Write(productDesc);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                        <p><span class=\"ProductPrice\">$ ");
#nullable restore
#line 52 "C:\Users\User\iCloudDrive\GdipSA\Netcore\CA\Github\ShoppingCart\Views\Home\Gallery.cshtml"
                                                   Write(productPrice.ToString("0.00"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span> </p>\r\n");
                WriteLiteral("                        <button class=\"buttonGallery\" style=\"vertical-align:middle\" type=\"submit\"");
                BeginWriteAttribute("formaction", "\r\n                                formaction=\"", 2549, "\"", 2615, 1);
#nullable restore
#line 55 "C:\Users\User\iCloudDrive\GdipSA\Netcore\CA\Github\ShoppingCart\Views\Home\Gallery.cshtml"
WriteAttributeValue("", 2595, formactionAddToCart, 2595, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <span>Add To Cart</span>\r\n                        </button>\r\n                        <br>\r\n                    </div>\r\n");
#nullable restore
#line 60 "C:\Users\User\iCloudDrive\GdipSA\Netcore\CA\Github\ShoppingCart\Views\Home\Gallery.cshtml"
                }
            }
        

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCart.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
