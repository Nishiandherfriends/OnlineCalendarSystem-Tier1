#pragma checksum "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2678f2d1394c80180022977356679e17c2afbc7f"
// <auto-generated/>
#pragma warning disable 1591
namespace OnlineCalendarSystem_Tier1.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-lg navbar-light bg-light");
            __builder.AddMarkupContent(2, "<a class=\"navbar-brand\" href=\"#\">OnlineCalendarSystem</a>\r\n    ");
            __builder.AddMarkupContent(3, "<button class=\"navbar-toggler\" type=\"button\" data-toggle=\"collapse\" data-target=\"#navbarText\" aria-controls=\"navbarText\" aria-expanded=\"false\" aria-label=\"Toggle navigation\"><span class=\"navbar-toggler-icon\"></span></button>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "collapse navbar-collapse");
            __builder.AddAttribute(6, "id", "navbarText");
            __builder.OpenElement(7, "ul");
            __builder.AddAttribute(8, "class", "navbar-nav mr-auto");
            __builder.AddMarkupContent(9, "<li class=\"nav-item active\"><a class=\"nav-link\" href=\"#\">Home <span class=\"sr-only\">(current)</span></a></li>\r\n            ");
            __builder.OpenElement(10, "li");
            __builder.AddAttribute(11, "class", "nav-item");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(12);
            __builder.AddAttribute(13, "class", "nav-link");
            __builder.AddAttribute(14, "href", "register");
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(16, "<span class=\"oi oi-person\" aria-hidden=\"true\"></span> About\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "span");
            __builder.AddAttribute(19, "class", "navbar-text");
            __builder.OpenElement(20, "LoginDisplay");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
