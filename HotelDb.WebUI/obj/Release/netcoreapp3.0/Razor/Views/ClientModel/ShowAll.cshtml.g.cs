#pragma checksum "D:\Repos\04 - HotelDB\HotelDb.WebUI\Views\ClientModel\ShowAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e7ae8cb480990a4c8d9b6d5c329e4348be0b364"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ClientModel_ShowAll), @"mvc.1.0.view", @"/Views/ClientModel/ShowAll.cshtml")]
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
#line 1 "D:\Repos\04 - HotelDB\HotelDb.WebUI\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Repos\04 - HotelDB\HotelDb.WebUI\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e7ae8cb480990a4c8d9b6d5c329e4348be0b364", @"/Views/ClientModel/ShowAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_ClientModel_ShowAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HotelDb.WebUI.Models.ClientModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Repos\04 - HotelDB\HotelDb.WebUI\Views\ClientModel\ShowAll.cshtml"
  
    ViewData["Title"] = "ShowAll";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 11 "D:\Repos\04 - HotelDB\HotelDb.WebUI\Views\ClientModel\ShowAll.cshtml"
           Write(Html.DisplayNameFor(model => model.ClientFullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "D:\Repos\04 - HotelDB\HotelDb.WebUI\Views\ClientModel\ShowAll.cshtml"
           Write(Html.DisplayNameFor(model => model.ClientFullAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "D:\Repos\04 - HotelDB\HotelDb.WebUI\Views\ClientModel\ShowAll.cshtml"
           Write(Html.DisplayNameFor(model => model.Tel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "D:\Repos\04 - HotelDB\HotelDb.WebUI\Views\ClientModel\ShowAll.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "D:\Repos\04 - HotelDB\HotelDb.WebUI\Views\ClientModel\ShowAll.cshtml"
           Write(Html.DisplayNameFor(model => model.ClientInfo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "D:\Repos\04 - HotelDB\HotelDb.WebUI\Views\ClientModel\ShowAll.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "D:\Repos\04 - HotelDB\HotelDb.WebUI\Views\ClientModel\ShowAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.ClientFullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "D:\Repos\04 - HotelDB\HotelDb.WebUI\Views\ClientModel\ShowAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.ClientFullAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "D:\Repos\04 - HotelDB\HotelDb.WebUI\Views\ClientModel\ShowAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.Tel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "D:\Repos\04 - HotelDB\HotelDb.WebUI\Views\ClientModel\ShowAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "D:\Repos\04 - HotelDB\HotelDb.WebUI\Views\ClientModel\ShowAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.ClientInfo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <span class=\"badge badge-light\">\r\n                    ");
#nullable restore
#line 47 "D:\Repos\04 - HotelDB\HotelDb.WebUI\Views\ClientModel\ShowAll.cshtml"
               Write(Html.ActionLink("Edit Client", "Edit", new { id = item.ClientId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n                <span class=\"badge badge-light\">\r\n                    ");
#nullable restore
#line 50 "D:\Repos\04 - HotelDB\HotelDb.WebUI\Views\ClientModel\ShowAll.cshtml"
               Write(Html.ActionLink("Booking History", "History", new { id = item.ClientId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 54 "D:\Repos\04 - HotelDB\HotelDb.WebUI\Views\ClientModel\ShowAll.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HotelDb.WebUI.Models.ClientModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
