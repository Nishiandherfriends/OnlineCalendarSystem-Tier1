#pragma checksum "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0c4d3081b20ce589f5b0d82d4f5ad243b4869a6"
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
#line 1 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\_Imports.razor"
using OnlineCalendarSystem_Tier1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\_Imports.razor"
using OnlineCalendarSystem_Tier1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\Pages\Login.razor"
using OnlineCalendarSystem_Tier1.Login;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\Pages\Login.razor"
using login;

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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-6 card");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-12 row");
            __builder.AddMarkupContent(8, "\r\n            \r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-6");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "form");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.AddMarkupContent(14, "<div>\r\n                        <br><br><br><br><br>\r\n                    </div>\r\n                    ");
            __builder.AddMarkupContent(15, "<div>\r\n                        <h3 style=\"font-weight:bold; color:purple\">Calendar Login</h3>\r\n                    </div>\r\n                    ");
            __builder.AddMarkupContent(16, "<div>\r\n                        <br>\r\n                    </div>\r\n                    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-12 row");
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "name", "username");
            __builder.AddAttribute(22, "placeholder", "Username");
            __builder.AddAttribute(23, "type", "text");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\Pages\Login.razor"
                                                                                               username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    <br>\r\n                    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col-12 row");
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "name", "password");
            __builder.AddAttribute(33, "placeholder", "Password");
            __builder.AddAttribute(34, "type", "password");
            __builder.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\Pages\Login.razor"
                                                                                                   password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    <br>\r\n                    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "col-12 row");
            __builder.AddMarkupContent(41, "\r\n                        <span class=\"col-12\"></span>\r\n                         ");
            __builder.OpenElement(42, "a");
            __builder.AddAttribute(43, "href", "");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\Pages\Login.razor"
                                              PerformLogin

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.AddMarkupContent(46, "<button class=\"btn btn-outline-dark\" type=\"submit\">Log in</button>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                    <br>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.AddMarkupContent(51, "<div class=\"col-6\">\r\n                <img src=\"/images/pngegg.png\" style=\"margin-top: 40px;\" width=\"300px\" height=\"300px\">\r\n            </div>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\Pages\Login.razor"
      
    private User user;

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
            ((Authentication) AuthenticationStateProvider).validateLogin(username, password);
            username = "";
            password = "";
            NavigationManager.NavigateTo("/calendar");
        }
        catch(Exception e)
        {
            errorMessage = "404 User not found :( ";
             
        }
    }

    public async Task PerformLogOut(){
        errorMessage = "";
        username = "";
        password = "";
        try{
            ((Authentication)AuthenticationStateProvider).LogOut();
            NavigationManager.NavigateTo("/");
        }catch(Exception e){
            errorMessage = "404 not found";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUser UserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591