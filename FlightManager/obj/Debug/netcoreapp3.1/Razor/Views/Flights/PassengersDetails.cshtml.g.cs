#pragma checksum "C:\Users\fourt\Desktop\FlightManagerProject\FlightManager\Views\Flights\PassengersDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2121855261d41e79be4dc3db0608acb65bb867ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flights_PassengersDetails), @"mvc.1.0.view", @"/Views/Flights/PassengersDetails.cshtml")]
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
#line 1 "C:\Users\fourt\Desktop\FlightManagerProject\FlightManager\Views\_ViewImports.cshtml"
using FlightManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fourt\Desktop\FlightManagerProject\FlightManager\Views\_ViewImports.cshtml"
using FlightManager.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\fourt\Desktop\FlightManagerProject\FlightManager\Views\_ViewImports.cshtml"
using FlightManager.Models.Details;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\fourt\Desktop\FlightManagerProject\FlightManager\Views\_ViewImports.cshtml"
using FlightManager.Models.Filters;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2121855261d41e79be4dc3db0608acb65bb867ea", @"/Views/Flights/PassengersDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cad5f11263978fb8a6a74d9b692a40afcaf2b533", @"/Views/_ViewImports.cshtml")]
    public class Views_Flights_PassengersDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FlightManager.Models.PassengerListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">


<h1>Passengers details</h1>
<div class=""container-fluid"">
    <div class=""card"">
        <div class=""card-body"">
            <table class=""w3-table-all"">
                <thead>
                <th>Reservation id</th>
                <th>First name</th>
                <th>Middle name</th>
                <th>Last name</th>
                <th>EGN</th>
                <th>Phone</th>
                <th>Ticket type</th>
                </th>
                <tbody>
");
#nullable restore
#line 20 "C:\Users\fourt\Desktop\FlightManagerProject\FlightManager\Views\Flights\PassengersDetails.cshtml"
                     foreach (var item in Model.Items)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr class=\"w3-hover-blue\">\r\n                            <td>");
#nullable restore
#line 23 "C:\Users\fourt\Desktop\FlightManagerProject\FlightManager\Views\Flights\PassengersDetails.cshtml"
                           Write(item.ReservationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 24 "C:\Users\fourt\Desktop\FlightManagerProject\FlightManager\Views\Flights\PassengersDetails.cshtml"
                           Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 25 "C:\Users\fourt\Desktop\FlightManagerProject\FlightManager\Views\Flights\PassengersDetails.cshtml"
                           Write(item.MiddleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 26 "C:\Users\fourt\Desktop\FlightManagerProject\FlightManager\Views\Flights\PassengersDetails.cshtml"
                           Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 27 "C:\Users\fourt\Desktop\FlightManagerProject\FlightManager\Views\Flights\PassengersDetails.cshtml"
                           Write(item.EGN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 28 "C:\Users\fourt\Desktop\FlightManagerProject\FlightManager\Views\Flights\PassengersDetails.cshtml"
                           Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 29 "C:\Users\fourt\Desktop\FlightManagerProject\FlightManager\Views\Flights\PassengersDetails.cshtml"
                           Write(item.IsBusiness);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 31 "C:\Users\fourt\Desktop\FlightManagerProject\FlightManager\Views\Flights\PassengersDetails.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FlightManager.Models.PassengerListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591