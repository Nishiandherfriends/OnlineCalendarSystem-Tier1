#pragma checksum "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\Calendar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ca95d8aa2e989fca053523c8f2e8d0e681fbcba"
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
#line 1 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\Calendar.razor"
using OnlineCalendarSystem_Tier1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\Calendar.razor"
using OnlineCalendarSystem_Tier1.Login;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\Calendar.razor"
using OnlineCalendarSystem_Tier1.Models;

#line default
#line hidden
#nullable disable
    public partial class Calendar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    header {\r\n        padding: 25px;\r\n    }\r\n\r\n    .shadow {\r\n        transition: 0.3s\r\n    }\r\n\r\n    .shadow:hover {\r\n        -webkit-box-shadow: 0px 4px 15px -6px rgba(0,0,0,0.75);\r\n        -moz-box-shadow: 0px 4px 15px -6px rgba(0,0,0,0.75);\r\n        box-shadow: 0px 4px 15px -6px rgba(0,0,0,0.75);\r\n    }\r\n\r\n    .calendar {\r\n        padding: 10px;\r\n    }\r\n\r\n    .calendar-table {\r\n        margin: 10px;\r\n        width: 100%;\r\n        background-color: #f3f2f1;\r\n        text-align: center;\r\n    }\r\n\r\n        .calendar-table thead {\r\n            background-color: white;\r\n        }\r\n\r\n        .calendar-table td {\r\n            padding: 4px;\r\n        }\r\n\r\n        .calendar-table .day {\r\n            width: 125px;\r\n            height: 125px;\r\n            min-width: 125px;\r\n            margin: 5px;\r\n            border-radius: 5px;\r\n            background-color: white;\r\n            padding: 5px;\r\n            cursor: pointer;\r\n        }\r\n\r\n    .current-day {\r\n        border: 2px solid #1b6ec2;\r\n        color: #1b6ec2;\r\n    }\r\n\r\n    .selected-day {\r\n        border: 2px solid #002752;\r\n        color: #002752;\r\n        background-color: #abdde5 !important;\r\n    }\r\n\r\n    .day .day-event {\r\n        font-size: 10px;\r\n        padding: 5px;\r\n    }\r\n\r\n    .red-orange {\r\n        background: #da3b01;\r\n        color: white;\r\n    }\r\n\r\n    .magenta {\r\n        background: #881798;\r\n        color: white;\r\n    }\r\n\r\n    .pink-red {\r\n        background-color: #750b1c;\r\n        color: white;\r\n    }\r\n\r\n    .yellow {\r\n        background: #fce100;\r\n        color: black;\r\n    }\r\n\r\n    .yellow-green {\r\n        background: #8cbd18;\r\n        color: black;\r\n    }\r\n\r\n    .calendar-toolbar {\r\n        background-color: #1b6ec2;\r\n        color: white;\r\n    }\r\n\r\n    .toolbar-button {\r\n        background: #1b6ec2;\r\n        margin: 0px;\r\n        padding: 5px 10px;\r\n        text-align: center;\r\n        vertical-align: middle;\r\n        outline: none;\r\n        font-size: 25px;\r\n        font-weight: 100;\r\n        color: white;\r\n        border: none;\r\n    }\r\n\r\n        .toolbar-button:hover {\r\n            background: #002752;\r\n        }\r\n\r\n        .toolbar-button:focus {\r\n            border: none;\r\n            outline: none;\r\n        }\r\n\r\n    .fl-input {\r\n        display: block;\r\n        width: 100%;\r\n        padding: 3px 7px;\r\n        margin: 10px 0px;\r\n        border: 1px solid #3b3a39;\r\n    }\r\n\r\n    .input:focus {\r\n        outline: none;\r\n        border: 2px dashed #1b6ec2;\r\n    }\r\n\r\n    .card-div {\r\n        padding: 10px;\r\n    }\r\n\r\n    .event {\r\n        border-radius: 5px;\r\n        margin: 10px 5px;\r\n        padding: 5px;\r\n    }\r\n\r\n    .card {\r\n        margin: 10px;\r\n    }\r\n</style>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "calendar");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-sm-12  col-lg-2");
            __builder.OpenElement(7, "select");
            __builder.AddAttribute(8, "class", "fl-input");
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 148 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\Calendar.razor"
                                                SelectYear

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 149 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\Calendar.razor"
                 for (int i = 2019; i < 2025; i++)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "option");
            __builder.AddContent(11, 
#nullable restore
#line 151 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\Calendar.razor"
                             i

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 152 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\Calendar.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-sm-12  col-lg-2");
            __builder.OpenElement(15, "select");
            __builder.AddAttribute(16, "class", "fl-input");
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 156 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\Calendar.razor"
                                                SelectMonth

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(18, "option");
            __builder.AddAttribute(19, "value", "1");
            __builder.AddContent(20, "January");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "option");
            __builder.AddAttribute(23, "value", "2");
            __builder.AddContent(24, "February");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "option");
            __builder.AddAttribute(27, "value", "3");
            __builder.AddContent(28, "March");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "option");
            __builder.AddAttribute(31, "value", "4");
            __builder.AddContent(32, "April");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenElement(34, "option");
            __builder.AddAttribute(35, "value", "5");
            __builder.AddContent(36, "May");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "option");
            __builder.AddAttribute(39, "value", "6");
            __builder.AddContent(40, "June");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.OpenElement(42, "option");
            __builder.AddAttribute(43, "value", "7");
            __builder.AddContent(44, "July");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "option");
            __builder.AddAttribute(47, "value", "8");
            __builder.AddContent(48, "August");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.OpenElement(50, "option");
            __builder.AddAttribute(51, "value", "9");
            __builder.AddContent(52, "September");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                ");
            __builder.OpenElement(54, "option");
            __builder.AddAttribute(55, "value", "10");
            __builder.AddContent(56, "October");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.OpenElement(58, "option");
            __builder.AddAttribute(59, "value", "11");
            __builder.AddContent(60, "November");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.OpenElement(62, "option");
            __builder.AddAttribute(63, "value", "12");
            __builder.AddContent(64, "December");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n    ");
            __builder.OpenElement(66, "table");
            __builder.AddAttribute(67, "class", "calendar-table");
            __builder.AddMarkupContent(68, "<thead><tr><td>Sun</td>\r\n                <td>Mon</td>\r\n                <td>Tue</td>\r\n                <td>Wed</td>\r\n                <td>Thu</td>\r\n                <td>Fri</td>\r\n                <td>Sat</td></tr></thead>\r\n        ");
            __builder.OpenElement(69, "tbody");
#nullable restore
#line 185 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\Calendar.razor"
             for (int i = 0; i < rows; i++)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(70, "tr");
#nullable restore
#line 188 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\Calendar.razor"
                     foreach (var item in dates.Skip(i * 7).Take(7))
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(71, "td");
            __builder.AddContent(72, 
#nullable restore
#line 190 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\Calendar.razor"
                              DayTemplate(item)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 191 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\Calendar.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 193 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\Calendar.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(73, "<tr><td></td></tr>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 204 "C:\Users\joaob\source\repos\OnlineCalendarSystem Tier1\OnlineCalendarSystem Tier1\Pages\Calendar.razor"
       
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
        if (weekNumber == 7)
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
            dates.Add(new Date());
        }
        //Add month days
        int numberOfDaysInMonth = DateTime.DaysInMonth(year, month);
        for (int i = 0; i < numberOfDaysInMonth; i++)
        {
            dates.Add(new Date());
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
