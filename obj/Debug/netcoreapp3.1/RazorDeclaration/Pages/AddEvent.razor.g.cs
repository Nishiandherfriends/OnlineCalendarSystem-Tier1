// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace OnlineCalendarSystem_Tier1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\_Imports.razor"
using OnlineCalendarSystem_Tier1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\_Imports.razor"
using OnlineCalendarSystem_Tier1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\_Imports.razor"
using OnlineCalendarSystem_Tier1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\_Imports.razor"
using OnlineCalendarSystem_Tier1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class AddEvent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\Pages\AddEvent.razor"
       
    [Parameter]
    public Date EventDay { get; set; }
    private static Event _event = new Event();

    private Event calendarEvent = new Event
    {
        title = _event.title,
        description = _event.description,
        location = _event.location,
        startDate = _event.startDate,
        endDate = _event.endDate
    };
    private void addEventToSelectedDay()
    {
        _event.startDate = new DateTime(EventDay.DateTime.Year, EventDay.DateTime.Date.Month, EventDay.DateTime.Day, _event.startDate.Hour, _event.startDate.Minute, 0);
        _event.endDate = new DateTime(EventDay.DateTime.Year, EventDay.DateTime.Date.Month, EventDay.DateTime.Day, _event.endDate.Hour, _event.endDate.Minute, 0);
        if (EventDay.Events == null)
        {
            EventDay.Events = new List<Event>();
        }
        var calendarEvent = new Event
        {
            title = _event.title,
            description = _event.description,
            location =_event.location,
            startDate = _event.startDate,
            endDate = _event.endDate
        };
        EventDay.Events.Add(calendarEvent);
        
        Console.WriteLine($"Total Events in Day {EventDay.Events.Count} | {_event.description} | {_event.startDate} | {_event.endDate}");
        
         OnlineCalendarService.createEvent(1,calendarEvent);
    }
    public static event Action OnEventAdded = () =>{ };

    public void removeEvent()
    {
        EventDay.Events.Remove(_event);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OnlineCalendarService OnlineCalendarService { get; set; }
    }
}
#pragma warning restore 1591
