#pragma checksum "C:\Users\fourt\Desktop\FlightManagerProject\FlightManager\Views\Reservations\AddPassengers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4150a56c0bb17cba52315787abacff98a07d935c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservations_AddPassengers), @"mvc.1.0.view", @"/Views/Reservations/AddPassengers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4150a56c0bb17cba52315787abacff98a07d935c", @"/Views/Reservations/AddPassengers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cad5f11263978fb8a6a74d9b692a40afcaf2b533", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservations_AddPassengers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PassengerViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\fourt\Desktop\FlightManagerProject\FlightManager\Views\Reservations\AddPassengers.cshtml"
   
    ViewData["Title"] = "Add Passengers";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n");
#nullable restore
#line 6 "C:\Users\fourt\Desktop\FlightManagerProject\FlightManager\Views\Reservations\AddPassengers.cshtml"
     using (Html.BeginForm("AddPassengers", "Reservations", FormMethod.Post,
       new { @class = "" }))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4150a56c0bb17cba52315787abacff98a07d935c4528", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 9 "C:\Users\fourt\Desktop\FlightManagerProject\FlightManager\Views\Reservations\AddPassengers.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 11 "C:\Users\fourt\Desktop\FlightManagerProject\FlightManager\Views\Reservations\AddPassengers.cshtml"
       Write(Html.LabelFor(model => model.FirstName, "First name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 12 "C:\Users\fourt\Desktop\FlightManagerProject\FlightManager\Views\Reservations\AddPassengers.cshtml"
       Write(Html.EditorFor(model => model.FirstName, new { htmlAttributes = new { placeholder = "First name", @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 15 "C:\Users\fourt\Desktop\FlightManagerProject\FlightManager\Views\Reservations\AddPassengers.cshtml"
       Write(Html.LabelFor(model => model.MiddleName, "Middle name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 16 "C:\Users\fourt\Desktop\FlightManagerProject\FlightManager\Views\Reservations\AddPassengers.cshtml"
       Write(Html.EditorFor(model => model.MiddleName, new { htmlAttributes = new { placeholder = "Middle name", @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 19 "C:\Users\fourt\Desktop\FlightManagerProject\FlightManager\Views\Reservations\AddPassengers.cshtml"
       Write(Html.LabelFor(model => model.LastName, "Last name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 20 "C:\Users\fourt\Desktop\FlightManagerProject\FlightManager\Views\Reservations\AddPassengers.cshtml"
       Write(Html.EditorFor(model => model.LastName, new { htmlAttributes = new { placeholder = "Last name", @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 23 "C:\Users\fourt\Desktop\FlightManagerProject\FlightManager\Views\Reservations\AddPassengers.cshtml"
       Write(Html.LabelFor(model => model.EGN, "EGN"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 24 "C:\Users\fourt\Desktop\FlightManagerProject\FlightManager\Views\Reservations\AddPassengers.cshtml"
       Write(Html.EditorFor(model => model.EGN, new { htmlAttributes = new { placeholder = "EGN", @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 27 "C:\Users\fourt\Desktop\FlightManagerProject\FlightManager\Views\Reservations\AddPassengers.cshtml"
       Write(Html.LabelFor(model => model.PhoneNumber, "Phone number"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 28 "C:\Users\fourt\Desktop\FlightManagerProject\FlightManager\Views\Reservations\AddPassengers.cshtml"
       Write(Html.EditorFor(model => model.PhoneNumber, new { htmlAttributes = new { placeholder = "Phone number", @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 31 "C:\Users\fourt\Desktop\FlightManagerProject\FlightManager\Views\Reservations\AddPassengers.cshtml"
       Write(Html.LabelFor(model => model.TicketType, "Ticket type"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 34 "C:\Users\fourt\Desktop\FlightManagerProject\FlightManager\Views\Reservations\AddPassengers.cshtml"
       Write(Html.DropDownListFor(model => model.TicketType, (IEnumerable<SelectListItem>)ViewBag.TicketsType, new { htmlAttributes = new { placeholder = "Ticket type", @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\r\n");
#nullable restore
#line 37 "C:\Users\fourt\Desktop\FlightManagerProject\FlightManager\Views\Reservations\AddPassengers.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PassengerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591