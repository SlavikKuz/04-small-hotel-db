#pragma checksum "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\ShowAllPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d81cd2291098c8e8dba49f9fdd66ddee1694a47d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookingModel_ShowAllPage), @"mvc.1.0.view", @"/Views/BookingModel/ShowAllPage.cshtml")]
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
#line 1 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d81cd2291098c8e8dba49f9fdd66ddee1694a47d", @"/Views/BookingModel/ShowAllPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_BookingModel_ShowAllPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HotelDb.WebUI.Models.BookingViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\ShowAllPage.cshtml"
  
    ViewData["Title"] = "ShowAll";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 12 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\ShowAllPage.cshtml"
               Write(Html.DisplayNameFor(model => model.Booking.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 15 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\ShowAllPage.cshtml"
               Write(Html.DisplayNameFor(model => model.Client.ClientFullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 18 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\ShowAllPage.cshtml"
               Write(Html.DisplayNameFor(model => model.Booking.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 21 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\ShowAllPage.cshtml"
               Write(Html.DisplayNameFor(model => model.Booking.DayFrom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 24 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\ShowAllPage.cshtml"
               Write(Html.DisplayNameFor(model => model.Booking.DayTill));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 27 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\ShowAllPage.cshtml"
               Write(Html.DisplayNameFor(model => model.Booking.WithKids));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 30 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\ShowAllPage.cshtml"
               Write(Html.DisplayNameFor(model => model.Invoice.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 33 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\ShowAllPage.cshtml"
               Write(Html.DisplayNameFor(model => model.Booking.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n                <th>\r\n                    ");
#nullable restore
#line 37 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\ShowAllPage.cshtml"
               Write(Html.DisplayNameFor(model => model.Booking.Info));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 42 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\ShowAllPage.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 46 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\ShowAllPage.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Booking.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 49 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\ShowAllPage.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Client.ClientFullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 52 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\ShowAllPage.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Booking.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 55 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\ShowAllPage.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Booking.DayFrom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 58 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\ShowAllPage.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Booking.DayTill));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 61 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\ShowAllPage.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Booking.WithKids));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 64 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\ShowAllPage.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Invoice.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 67 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\ShowAllPage.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Booking.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <span class=\"badge badge-light\">\r\n                                    ");
#nullable restore
#line 71 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\ShowAllPage.cshtml"
                               Write(Html.ActionLink("Edit", "Edit", new { id = item.Booking.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </span>\r\n                                <span class=\"badge badge-light\">\r\n                                    ");
#nullable restore
#line 74 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\ShowAllPage.cshtml"
                               Write(Html.ActionLink("Invoice", "Invoice", "ClientModel", new { id = item.Booking.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </span>\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 78 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\ShowAllPage.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Booking.Info));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 81 "d:\Repos\04 - HotelDB\HotelDb.WebUI\Views\BookingModel\ShowAllPage.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HotelDb.WebUI.Models.BookingViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
