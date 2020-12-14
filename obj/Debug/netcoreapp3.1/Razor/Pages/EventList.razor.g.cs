#pragma checksum "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\Pages\EventList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce8bc32f962b85d195255f06bd76de6e74a6f25e"
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
    public partial class EventList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "ms-depth-16 card");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card-div");
            __builder.OpenElement(4, "h3");
            __builder.AddAttribute(5, "class", "ms-fontSize-20 ms-fontWeight-regular");
            __builder.AddContent(6, 
#nullable restore
#line 3 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\Pages\EventList.razor"
                                                          EventDay.DateTime.ToString("D")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 4 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\Pages\EventList.razor"
          
            if (EventDay.Events ==null || EventDay.Events.Count == 0)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<h3 class=\"ms-fontSize-15 ms-fontWeight-regular\">No events in this day </h3>");
#nullable restore
#line 8 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\Pages\EventList.razor"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\Pages\EventList.razor"
                 foreach (var item in EventDay.Events)
                {
                    string color = item.Color;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "event" + " shadow" + " " + (
#nullable restore
#line 14 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\Pages\EventList.razor"
                                              color

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(10, "h3");
            __builder.AddAttribute(11, "class", "ms-fontSize-15 ms-fontWeight-regular");
            __builder.AddContent(12, 
#nullable restore
#line 15 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\Pages\EventList.razor"
                                                                          item.startDate.ToString("HH:mm")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(13, " to ");
            __builder.AddContent(14, 
#nullable restore
#line 15 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\Pages\EventList.razor"
                                                                                                               item.endDate.ToString("HH:mm")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                        ");
            __builder.OpenElement(16, "p");
            __builder.AddAttribute(17, "class", "ms-fontSize-10 ms-fontWeight-regular");
            __builder.AddContent(18, 
#nullable restore
#line 16 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\Pages\EventList.razor"
                                                                         item.title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "p");
            __builder.AddAttribute(21, "class", "ms-fontSize-7 ms-fontWeight-regular");
            __builder.AddContent(22, 
#nullable restore
#line 17 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\Pages\EventList.razor"
                                                                        item.description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "p");
            __builder.AddAttribute(25, "class", "ms-fontSize-7 ms-fontWeight-regular");
            __builder.AddContent(26, 
#nullable restore
#line 18 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\Pages\EventList.razor"
                                                                        item.location

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\Pages\EventList.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\Pages\EventList.razor"
                  
            }
        

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\Pages\EventList.razor"
       
    [Parameter]
    public Date EventDay { get; set; }
    
    private Event _event = new Event();

    protected override void OnInitialized()
        {
           AddEvent.OnEventAdded += ()=>{
               StateHasChanged();
           };
        }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
