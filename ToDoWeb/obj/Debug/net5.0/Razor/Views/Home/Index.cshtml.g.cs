#pragma checksum "/Users/shubhamdhamane/Projects/ToDoWeb/ToDoWeb/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b26f1a305806cf12f1c50a1c4750ca74832ceba"
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
#line 1 "/Users/shubhamdhamane/Projects/ToDoWeb/ToDoWeb/Views/_ViewImports.cshtml"
using ToDoWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/shubhamdhamane/Projects/ToDoWeb/ToDoWeb/Views/_ViewImports.cshtml"
using ToDoWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b26f1a305806cf12f1c50a1c4750ca74832ceba", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b3f8a0c4131ff90fa6d6e716f2f16c543c1ea7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ToDoWeb>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/shubhamdhamane/Projects/ToDoWeb/ToDoWeb/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n\n<h2>To Do List</h2>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 26 "/Users/shubhamdhamane/Projects/ToDoWeb/ToDoWeb/Views/Home/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 29 "/Users/shubhamdhamane/Projects/ToDoWeb/ToDoWeb/Views/Home/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 32 "/Users/shubhamdhamane/Projects/ToDoWeb/ToDoWeb/Views/Home/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.isCompleted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 35 "/Users/shubhamdhamane/Projects/ToDoWeb/ToDoWeb/Views/Home/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.completedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 41 "/Users/shubhamdhamane/Projects/ToDoWeb/ToDoWeb/Views/Home/Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 45 "/Users/shubhamdhamane/Projects/ToDoWeb/ToDoWeb/Views/Home/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 48 "/Users/shubhamdhamane/Projects/ToDoWeb/ToDoWeb/Views/Home/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 51 "/Users/shubhamdhamane/Projects/ToDoWeb/ToDoWeb/Views/Home/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.isCompleted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 54 "/Users/shubhamdhamane/Projects/ToDoWeb/ToDoWeb/Views/Home/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.completedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 57 "/Users/shubhamdhamane/Projects/ToDoWeb/ToDoWeb/Views/Home/Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                    ");
#nullable restore
#line 58 "/Users/shubhamdhamane/Projects/ToDoWeb/ToDoWeb/Views/Home/Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                    ");
#nullable restore
#line 59 "/Users/shubhamdhamane/Projects/ToDoWeb/ToDoWeb/Views/Home/Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 62 "/Users/shubhamdhamane/Projects/ToDoWeb/ToDoWeb/Views/Home/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ToDoWeb>> Html { get; private set; }
    }
}
#pragma warning restore 1591
