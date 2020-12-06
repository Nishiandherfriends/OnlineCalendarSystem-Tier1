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
#line 1 "C:\Users\javic\RiderProjects\OnlineCalendarSystem-Tier1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\javic\RiderProjects\OnlineCalendarSystem-Tier1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\javic\RiderProjects\OnlineCalendarSystem-Tier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\javic\RiderProjects\OnlineCalendarSystem-Tier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\javic\RiderProjects\OnlineCalendarSystem-Tier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\javic\RiderProjects\OnlineCalendarSystem-Tier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\javic\RiderProjects\OnlineCalendarSystem-Tier1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\javic\RiderProjects\OnlineCalendarSystem-Tier1\_Imports.razor"
using OnlineCalendarSystem_Tier1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\javic\RiderProjects\OnlineCalendarSystem-Tier1\_Imports.razor"
using OnlineCalendarSystem_Tier1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\javic\RiderProjects\OnlineCalendarSystem-Tier1\Pages\Login.razor"
using OnlineCalendarSystem_Tier1.Login;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\javic\RiderProjects\OnlineCalendarSystem-Tier1\Pages\Login.razor"
using OnlineCalendarSystem_Tier1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\javic\RiderProjects\OnlineCalendarSystem-Tier1\Pages\Login.razor"
using login;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\javic\RiderProjects\OnlineCalendarSystem-Tier1\Pages\Login.razor"
using OnlineCalendarSystem_Tier1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\javic\RiderProjects\OnlineCalendarSystem-Tier1\Pages\Login.razor"
      
    private User user;
    OnlineCalendarService dayEvent = new OnlineCalendarService();
    private string username;
    private string password;
    private string errorMessage;
    protected override Task OnInitializedAsync()
    {
        user = new User();
        return base.OnInitializedAsync();
    }
    public async Task PerformLogin()
    {
        errorMessage = "";
        try
        {
            ((Authentication)AuthenticationStateProvider).validateLogin(username, password);
            username = "";
            password = "";
            NavigationManager.NavigateTo("/calendar");
        }
        catch (Exception e)
        {
            errorMessage = "404 User not found :( ";

        }
    }

    public async Task PerformLogOut()
    {
        errorMessage = "";
        username = "";
        password = "";
        try
        {
            ((Authentication)AuthenticationStateProvider).LogOut();
            NavigationManager.NavigateTo("/");
        }
        catch (Exception e)
        {
            errorMessage = "404 not found";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OnlineCalendarSystem_Tier1.Data.OnlineCalendarService OnlineCalendarService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUser UserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
