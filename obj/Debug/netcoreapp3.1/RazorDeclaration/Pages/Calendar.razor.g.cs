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
#line 1 "c:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\_Imports.razor"
using OnlineCalendarSystem_Tier1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\_Imports.razor"
using OnlineCalendarSystem_Tier1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\_Imports.razor"
using OnlineCalendarSystem_Tier1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\_Imports.razor"
using OnlineCalendarSystem_Tier1.Data;

#line default
#line hidden
#nullable disable
    public partial class Calendar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 182 "c:\Users\javic\source\repos\OnlineCalendarSystem-Tier1\OnlineCalendarSystem-Tier1\Pages\Calendar.razor"
       
    [Parameter]
    public RenderFragment<Date> DayTemplate { get; set; }
    private List<Date> dates = new List<Date>();
    private int year = 2020;
    private int month = 5;
    private int rows = 0;
    
    public void SelectYear(ChangeEventArgs eventArgs)
    {
        year = Convert.ToInt32(eventArgs.Value.ToString());
        UpdateCalendar();
    }

    public void SelectMonth(ChangeEventArgs eventArgs)
    {
        month = Convert.ToInt32(eventArgs.Value.ToString());
        UpdateCalendar();
    }

    public void UpdateCalendar()
    {
        dates = new List<Date>();
        
        var firstDay = new DateTime(year, month, 1);
        int weekNumber = (int)firstDay.DayOfWeek;
        int numberOfEmptyDays = 0;
        if (weekNumber== 7)
        {
            numberOfEmptyDays = 0;
        }
        else
        {
            numberOfEmptyDays = weekNumber;
        }
        //Add empty days
        for (int i = 0; i < numberOfEmptyDays; i++)
        {
            dates.Add(new Date
            {
                 day = 0,
                isEmpty = true
            });
        }
        //Add month days
        int numberOfDaysInMonth = DateTime.DaysInMonth(year, month);
        for (int i = 0; i < numberOfDaysInMonth; i++)
        {
            dates.Add(new Date
            {
                day = i+ 1,
                isEmpty = false,
                DateTime = new DateTime(year, month, i+1)
            });
        }
        //number of rows
        int count = dates.Count % 7;
        if (count == 0)
        {
            rows = dates.Count / 7;
        }
        else
        {
            rows = Convert.ToInt32(dates.Count / 7) + 1;
            
        }
        Console.WriteLine($"Total Rows: {rows} | Number of Empty Days {numberOfEmptyDays} | Month Days {numberOfDaysInMonth}");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
