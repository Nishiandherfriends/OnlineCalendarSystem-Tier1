#pragma checksum "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\DeleteEvent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b511129fc76fe9e8f028d32060f7bfadbd2d210"
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
#line 1 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\DeleteEvent.razor"
using OnlineCalendarSystem_Tier1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\DeleteEvent.razor"
using OnlineCalendarSystem_Tier1.Login;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\DeleteEvent.razor"
using OnlineCalendarSystem_Tier1.Models;

#line default
#line hidden
#nullable disable
    public partial class DeleteEvent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "ms-depth-10 card");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "model", "evt");
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\DeleteEvent.razor"
                                         removeEvent

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "<div class=\"calendar-toolbar\"><button class=\"toolbar-button\" type=\"submit\"><i class=\"ms-Icon ms-Icon--AddEvent\"></i>RemoveEvent</button></div>\r\n        ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "card-div");
                __builder2.OpenElement(9, "input");
                __builder2.AddAttribute(10, "type", "text");
                __builder2.AddAttribute(11, "class", "fl-input");
                __builder2.AddAttribute(12, "placeholder", "Event");
                __builder2.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\DeleteEvent.razor"
                                            evt.id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => evt.id = __value, evt.id));
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
#line 15 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\DeleteEvent.razor"
       
    [Parameter]
    public Date EventDay { get; set; }
    private Event evt;

    private async void removeEvent()
    {
        string message = (string) await OnlineCalendarService.deleteEvent(evt.id);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
