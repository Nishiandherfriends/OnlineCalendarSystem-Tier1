#pragma checksum "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\AddEvent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f6ab3dac4d1125c22c26a7e14d156bd929a3680"
// <auto-generated/>
#pragma warning disable 1591
namespace OnlineCalendarSystem_Tier1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\_Imports.razor"
using OnlineCalendarSystem_Tier1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\_Imports.razor"
using OnlineCalendarSystem_Tier1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\AddEvent.razor"
using OnlineCalendarSystem_Tier1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\AddEvent.razor"
using OnlineCalendarSystem_Tier1.Login;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\AddEvent.razor"
using OnlineCalendarSystem_Tier1.Models;

#line default
#line hidden
#nullable disable
    public partial class AddEvent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "ms-depth-18 card");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "model", "_event");
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\AddEvent.razor"
                                            createEvent

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "<div class=\"calendar-toolbar\"><button class=\"toolbar-button\" type=\"submit\"><i class=\"ms-Icon ms-Icon--AddEvent\"></i> Add Event</button></div>\r\n\r\n        ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "card-div");
                __builder2.OpenElement(9, "h3");
                __builder2.AddAttribute(10, "class", "ms-fontsize-25 ms-fontweight-regular");
                __builder2.AddContent(11, 
#nullable restore
#line 13 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\AddEvent.razor"
                                                              DateTime.Now.ToString("D")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenElement(13, "input");
                __builder2.AddAttribute(14, "type", "text");
                __builder2.AddAttribute(15, "class", "fl-input");
                __builder2.AddAttribute(16, "placeholder", "Event");
                __builder2.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\AddEvent.razor"
                                            evt.title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => evt.title = __value, evt.title));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.OpenElement(20, "input");
                __builder2.AddAttribute(21, "type", "text");
                __builder2.AddAttribute(22, "class", "fl-input");
                __builder2.AddAttribute(23, "placeholder", "Description");
                __builder2.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\AddEvent.razor"
                                            evt.description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => evt.description = __value, evt.description));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n            ");
                __builder2.OpenElement(27, "input");
                __builder2.AddAttribute(28, "type", "text");
                __builder2.AddAttribute(29, "class", "fl-input");
                __builder2.AddAttribute(30, "placeholder", "Location");
                __builder2.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\AddEvent.razor"
                                            evt.location

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => evt.location = __value, evt.location));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n            ");
                __builder2.OpenElement(34, "input");
                __builder2.AddAttribute(35, "type", "time");
                __builder2.AddAttribute(36, "class", "fl-input");
                __builder2.AddAttribute(37, "placeholder", "");
                __builder2.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\AddEvent.razor"
                                            sDate

#line default
#line hidden
#nullable disable
                , format: "HH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => sDate = __value, sDate, format: "HH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n            ");
                __builder2.OpenElement(41, "input");
                __builder2.AddAttribute(42, "type", "time");
                __builder2.AddAttribute(43, "class", "fl-input");
                __builder2.AddAttribute(44, "placeholder", "");
                __builder2.AddAttribute(45, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\AddEvent.razor"
                                            eDate

#line default
#line hidden
#nullable disable
                , format: "HH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(46, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => eDate = __value, eDate, format: "HH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\AddEvent.razor"
       
    private Event evt;
    private string title, description, location;
    private DateTime sDate, eDate;

    private async void createEvent()
    {
        Date startDate = new Date(sDate.Year, sDate.Month, sDate.Day, sDate.Hour, sDate.Minute, sDate.Second);
        Date endDate = new Date(eDate.Year, eDate.Month, eDate.Day, eDate.Hour, eDate.Minute, eDate.Second);

        evt = new Event(1, title, description, location, startDate, endDate);

        string message = await OnlineCalendarService.createEvent(UserService.GetUser().id, evt);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
