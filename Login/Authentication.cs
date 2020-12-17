using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using OnlineCalendarSystem_Tier1.Data;
using OnlineCalendarSystem_Tier1.Login;
using OnlineCalendarSystem_Tier1.Models;
namespace OnlineCalendarSystem_Tier1.login
{
    public class Authentication : AuthenticationStateProvider
    {
        private readonly IJSRuntime jsRuntime;
        private User cachedUser;
        
        public Authentication(IJSRuntime jsRuntime)
        {
            this.jsRuntime = jsRuntime;
        }


        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            ClaimsIdentity identity = new ClaimsIdentity();
            identity = SetupClaimsForUser(cachedUser);
            ClaimsPrincipal cashedClaimsPrincipal = new ClaimsPrincipal(identity);
            return await Task.FromResult(new AuthenticationState(cashedClaimsPrincipal));
        }

        public async Task validateLogin(User user)
        {
            ClaimsIdentity identity = new ClaimsIdentity();
            identity = SetupClaimsForUser(user);
            string serializedData = JsonSerializer.Serialize(user);
            await jsRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", serializedData);
            cachedUser = user;
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(new ClaimsPrincipal(identity))));
        }
        
        public void LogOut()
        {
            cachedUser = null;
            var user = new ClaimsPrincipal(new ClaimsIdentity());
            jsRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", "");
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        private ClaimsIdentity SetupClaimsForUser(User user)
        {
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, user.username)); // Need to do the login first
            claims.Add(new Claim("securityLevel", user.securityLevel));
            ClaimsIdentity identity = new ClaimsIdentity(claims, "apiauth_type");
            return identity;
        }
    }
}