#pragma checksum "C:\Users\User\iCloudDrive\GdipSA\Netcore\CA\Github\ShoppingCart\Views\Home\Gallery.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09f91b6e4ef4a3c4697ef5f7c6d410f368a0c20a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09f91b6e4ef4a3c4697ef5f7c6d410f368a0c20a", @"/Views/Home/Gallery.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a65a8198b297c3ea7f3bc4f7f8cdac67c148a265", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Gallery : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCart.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("SearchBar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"GalleryHeader\">\r\n    <div class=\"GalleryWelcome\">\r\n        <p>\r\n            Welcome to Our Gallery Page!\r\n        </p>\r\n    </div>\r\n    <div class=\'GallerySearch\'>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09f91b6e4ef4a3c4697ef5f7c6d410f368a0c20a4869", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09f91b6e4ef4a3c4697ef5f7c6d410f368a0c20a6810", async() => {
                WriteLiteral("\r\n    <div class=\"GalleryMain\" align=\"left\">\r\n");
#nullable restore
#line 28 "C:\Users\User\iCloudDrive\GdipSA\Netcore\CA\Github\ShoppingCart\Views\Home\Gallery.cshtml"
          
            foreach (Product p in DisplayProducts)
            {
                string img = "/images/" + p.Name.Replace(":", "") + ".jpg";
                string productName = p.Name;
                string productGenre = p.Genre;
                string productDesc = p.Description.Substring(0, 35) + "...";
                double productPrice = p.Price;
                string formactionAddToCart = "Gallery?cmd=AddToCart&ProductId=" + p.Id;

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"GalleryProduct\">\r\n                    <div class=\"GalleryProductPicture\" align=\"center\">\r\n                        <img");
                BeginWriteAttribute("src", " src=\"", 1513, "\"", 1523, 1);
#nullable restore
#line 39 "C:\Users\User\iCloudDrive\GdipSA\Netcore\CA\Github\ShoppingCart\Views\Home\Gallery.cshtml"
WriteAttributeValue("", 1519, img, 1519, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\'125\' height=\'150\' ;>\r\n                    </div>\r\n                    <p><span class=\"ProductGenre\">");
#nullable restore
#line 41 "C:\Users\User\iCloudDrive\GdipSA\Netcore\CA\Github\ShoppingCart\Views\Home\Gallery.cshtml"
                                             Write(productGenre);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span></p>\r\n                    <p><span class=\"ProductName\">&nbsp;&nbsp;");
#nullable restore
#line 42 "C:\Users\User\iCloudDrive\GdipSA\Netcore\CA\Github\ShoppingCart\Views\Home\Gallery.cshtml"
                                                        Write(productName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></p>\r\n");
#nullable restore
#line 43 "C:\Users\User\iCloudDrive\GdipSA\Netcore\CA\Github\ShoppingCart\Views\Home\Gallery.cshtml"
                      if (productName.Length < 31)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("<br>");
#nullable restore
#line 44 "C:\Users\User\iCloudDrive\GdipSA\Netcore\CA\Github\ShoppingCart\Views\Home\Gallery.cshtml"
                             }
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <span class=\"ProductDesc\">&nbsp;&nbsp;");
#nullable restore
#line 46 "C:\Users\User\iCloudDrive\GdipSA\Netcore\CA\Github\ShoppingCart\Views\Home\Gallery.cshtml"
                                                     Write(productDesc);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                    <p><span class=\"ProductPrice\">$ ");
#nullable restore
#line 47 "C:\Users\User\iCloudDrive\GdipSA\Netcore\CA\Github\ShoppingCart\Views\Home\Gallery.cshtml"
                                               Write(productPrice.ToString("0.00"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span> </p>\r\n");
                WriteLiteral("                    <button class=\"buttonGallery\" style=\"vertical-align:middle\" type=\"submit\"");
                BeginWriteAttribute("formaction", "\r\n                            formaction=\"", 2239, "\"", 2301, 1);
#nullable restore
#line 50 "C:\Users\User\iCloudDrive\GdipSA\Netcore\CA\Github\ShoppingCart\Views\Home\Gallery.cshtml"
WriteAttributeValue("", 2281, formactionAddToCart, 2281, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <span>Add To Cart</span>\r\n                    </button>\r\n                    <br><p style=\"color: grey;font-size:0.75rem\">You may also like... (For Reference) </p>\r\n                </div>\r\n");
#nullable restore
#line 55 "C:\Users\User\iCloudDrive\GdipSA\Netcore\CA\Github\ShoppingCart\Views\Home\Gallery.cshtml"
            }
        

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n");
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
