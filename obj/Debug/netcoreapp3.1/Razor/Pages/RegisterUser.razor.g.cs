#pragma checksum "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\Pages\RegisterUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "999ee9e48728fb95137256772bd6e8a6aad44228"
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
#nullable restore
#line 3 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\Pages\RegisterUser.razor"
using OnlineCalendarSystem_Tier1.login;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\Pages\RegisterUser.razor"
using OnlineCalendarSystem_Tier1.Login;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AuthLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class RegisterUser : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-12");
            __builder.AddMarkupContent(4, "<h2>Create a new account</h2>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\Pages\RegisterUser.razor"
                         user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\Pages\RegisterUser.razor"
                                              Register

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(9);
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(12, "\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(13);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(14, "\r\n\r\n                ");
                    __builder3.AddMarkupContent(15, "<label>Username</label>\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(16);
                    __builder3.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\Pages\RegisterUser.razor"
                                            user.username

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.username = __value, user.username))));
                    __builder3.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.username));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(20, "\r\n                \r\n                ");
                    __builder3.AddMarkupContent(21, "<label>Password</label>\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPassword>(22);
                    __builder3.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\Pages\RegisterUser.razor"
                                             user.password

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.password = __value, user.password))));
                    __builder3.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.password));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\r\n                \r\n                <hr>\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(27);
                    __builder3.AddAttribute(28, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 23 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\Pages\RegisterUser.razor"
                                          Radzen.ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "Text", "Register");
                    __builder3.AddAttribute(30, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 24 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\Pages\RegisterUser.razor"
                                           Radzen.ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(31, "class", "btn-block mr-2");
                    __builder3.AddAttribute(32, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\Pages\RegisterUser.razor"
                                        flag

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(34);
                    __builder3.AddAttribute(35, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 26 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\Pages\RegisterUser.razor"
                                          Radzen.ButtonType.Button

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "Text", "Login");
                    __builder3.AddAttribute(37, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 27 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\Pages\RegisterUser.razor"
                                           Radzen.ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(38, "class", "btn-block mr-2");
                    __builder3.AddAttribute(39, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\Pages\RegisterUser.razor"
                                        flag

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(40, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\Pages\RegisterUser.razor"
                                                     GoToLogin

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\Pages\RegisterUser.razor"
       
    User user =new User();
    bool flag= false;
     
    public bool isSuccess { get; set; }
    public async Task Register()
    {
        flag = true;
        userService.AddUser(user.username, user.password);
        flag = false;
    }

    public void GoToLogin()
    {
        NavigationManager.NavigateTo("login");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUser userService { get; set; }
    }
}
#pragma warning restore 1591
