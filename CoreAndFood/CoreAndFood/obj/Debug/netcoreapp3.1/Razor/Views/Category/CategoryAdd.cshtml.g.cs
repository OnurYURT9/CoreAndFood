#pragma checksum "C:\Users\Ali Güral Lojman\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96e1d4fd123cc26686fe02d840679c845696e074"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_CategoryAdd), @"mvc.1.0.view", @"/Views/Category/CategoryAdd.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96e1d4fd123cc26686fe02d840679c845696e074", @"/Views/Category/CategoryAdd.cshtml")]
    public class Views_Category_CategoryAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreAndFood.Data.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ali Güral Lojman\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryAdd.cshtml"
  
    ViewData["Title"] = "CategoryAdd";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>CategoryAdd</h1>\r\n\r\n<br />\r\n");
#nullable restore
#line 10 "C:\Users\Ali Güral Lojman\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryAdd.cshtml"
 using (Html.BeginForm("CategoryAdd", "Category", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Ali Güral Lojman\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryAdd.cshtml"
Write(Html.LabelFor(x => x.CategoryName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Ali Güral Lojman\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryAdd.cshtml"
Write(Html.TextBoxFor(x => x.CategoryName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Ali Güral Lojman\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryAdd.cshtml"
Write(Html.ValidationMessageFor(x=>x.CategoryName,"",new { @style= "color:red"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 16 "C:\Users\Ali Güral Lojman\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryAdd.cshtml"
Write(Html.LabelFor(x => x.CategoryDescription));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Ali Güral Lojman\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryAdd.cshtml"
Write(Html.TextBoxFor(x => x.CategoryDescription, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-info\">Save</button>\r\n");
#nullable restore
#line 20 "C:\Users\Ali Güral Lojman\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryAdd.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreAndFood.Data.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
