#pragma checksum "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "490a80654b9495cd82d2937b7bf893a95a3ffc2a"
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
#line 2 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\Pages\Index.razor"
using OnlineCalendarSystem_Tier1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\Pages\Index.razor"
using OnlineCalendarSystem_Tier1.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\Pages\Index.razor"
      
    List<string> monthNames = new List<string>();
    List<string> days = new List<string>();
    List<Date> weeks = new List<Date> ();
    DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
    DateTime endDate = (new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)).AddMonths(1).AddYears(-1);

    protected override void OnInitialized(){
        monthNames = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthGenitiveNames.ToList();
        GenerateCalendarHeader();
    }
    private void LocalCalendar(ChangeEventArgs e){
        var month = e.Value.ToString();
        int monthIndex = DateTime.ParseExact(month, "MMMM", System.Globalization.CultureInfo.CreateSpecificCulture("en-GB")).Month; 
        startDate =  new DateTime(DateTime.Now.Year, monthIndex, 1);
        endDate = (new DateTime(DateTime.Now.Year, monthIndex, 1)).AddMonths(1).AddYears(-1);
    }

    private void GenerateCalendarHeader(){
        var day1= new List<string>();
        for(var dt = startDate; dt <=endDate; dt = dt.AddDays(1)){
            day1.Add(dt.ToString("dddd"));
        }
        days = day1.Distinct().ToList();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
