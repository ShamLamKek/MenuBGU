#pragma checksum "C:\Users\csgos\source\repos\MenuBGU\MenuBGU\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41433db54b21389556a15058614ca9af536e3d90"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41433db54b21389556a15058614ca9af536e3d90", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MenuBGU.Models.Food>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\csgos\source\repos\MenuBGU\MenuBGU\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Холодные закуски";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table-condensed\">\r\n    <tr>\r\n        <td>Код</td>\r\n        <td>Название</td>\r\n        <td>Цена</td>\r\n    </tr>\r\n");
#nullable restore
#line 12 "C:\Users\csgos\source\repos\MenuBGU\MenuBGU\Views\Home\Index.cshtml"
    foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 15 "C:\Users\csgos\source\repos\MenuBGU\MenuBGU\Views\Home\Index.cshtml"
       Write(item.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 16 "C:\Users\csgos\source\repos\MenuBGU\MenuBGU\Views\Home\Index.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 17 "C:\Users\csgos\source\repos\MenuBGU\MenuBGU\Views\Home\Index.cshtml"
       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td><input type=\"submit\" value=\"Добавить в корзину\"></td>\r\n    </tr>\r\n");
#nullable restore
#line 20 "C:\Users\csgos\source\repos\MenuBGU\MenuBGU\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MenuBGU.Models.Food>> Html { get; private set; }
    }
}
#pragma warning restore 1591
