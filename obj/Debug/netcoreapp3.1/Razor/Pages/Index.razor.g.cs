#pragma checksum "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "652281b4525d90a902bf90e953d6018b57abe827"
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
#line 2 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\Pages\Index.razor"
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
            __builder.AddMarkupContent(0, @"<style type=""text/css"">
    #tblParent tbody tr td {
        width: 200px;
        height: 200px;
    }

    #divParent {
        position: relative;
    }

    #divModal {
        z-index: 10;
        position: absolute;
        border: 1px solid #000000;
        border-radius: 3px;
        background-color: #ffffff;
        left: 40%;
        top: 20%;
        width: 400px;
        min-height: 300px;
    }

    .modalHeading {
        text-align: center;
        font-size: 50px;
        text-decoration: underline;
        margin-bottom: 36px;
    }
</style>

");
            __builder.AddMarkupContent(1, "<h1>Blazor Calender Example</h1>\r\n\r\n");
#nullable restore
#line 36 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\Pages\Index.razor"
 if (displayModal)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "id", "divModal");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "container");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "panel panel-default");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, "<div class=\"panel-heading modalHeading\">Set Description</div>\r\n                ");
            __builder.AddMarkupContent(13, @"<div class=""panel-body"">
                    <div class=""row"">
                        <div class=""col-md-4"">
                            <label>From Date : </label>
                        </div>
                        <div class=""col-md-8"">
                            <input type=""date"" style=""width:100%;"">
                        </div>
                    </div>
                </div>
                ");
            __builder.AddMarkupContent(14, @"<div class=""row"">
                    <div class=""col-md-4"">
                        <label>To Date : </label>
                    </div>
                    <div class=""col-md-8"">
                        <input type=""date"" style=""width:100%;"">
                    </div>
                </div>
                ");
            __builder.AddMarkupContent(15, @"<div class=""row"">
                    <div class=""col-md-4"">
                        <label>Description : </label>
                    </div>
                    <div class=""col-md-8"">
                        <input type=""text"" placeholder=""Type here..."">
                    </div>
                </div>
                ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "row");
            __builder.AddAttribute(18, "style", "margin-bottom:10px;");
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.AddMarkupContent(20, "<div class=\"col-md-6\">\r\n                    </div>\r\n                    ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "col-md-6");
            __builder.AddAttribute(23, "style", "text-align:right;");
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.AddMarkupContent(25, "<button class=\"btn btn-success\" style=\"float:left;margin-right:5px;\">Save</button>\r\n                        ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "class", "btn btn-danger");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\Pages\Index.razor"
                                                                 CloseModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "style", "float:left;");
            __builder.AddContent(30, "Close");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 79 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(37, "\r\n");
            __builder.OpenElement(38, "select");
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 81 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\Pages\Index.razor"
                   LocalCalender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 82 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\Pages\Index.razor"
     foreach (string monthName in monthNames)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "        ");
            __builder.OpenElement(42, "option");
            __builder.AddContent(43, 
#nullable restore
#line 84 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\Pages\Index.razor"
                 monthName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 85 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n\r\n");
            __builder.OpenElement(46, "table");
            __builder.AddAttribute(47, "class", "table table-bordered table-striped");
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.OpenElement(49, "thead");
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.OpenElement(51, "tr");
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 91 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\Pages\Index.razor"
             for (var dayIndex = 0; dayIndex < days.Count(); dayIndex++)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "                ");
            __builder.OpenElement(54, "th");
            __builder.AddMarkupContent(55, "\r\n                    ");
            __builder.AddContent(56, 
#nullable restore
#line 94 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\Pages\Index.razor"
                     days[dayIndex]

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
#nullable restore
#line 96 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(59, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n    ");
            __builder.OpenElement(62, "tbody");
            __builder.AddMarkupContent(63, "\r\n");
#nullable restore
#line 100 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\Pages\Index.razor"
         for (var weekIndex = 0; weekIndex < weeks.Count(); weekIndex++)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(64, "            ");
            __builder.OpenElement(65, "tr");
            __builder.AddMarkupContent(66, "\r\n");
#nullable restore
#line 103 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\Pages\Index.razor"
                 for (var dayIndex = 0; dayIndex < weeks[weekIndex].Dates.Count(); dayIndex++)
                {
                    var wIndex = weekIndex;
                    var dIndex = dayIndex;


#line default
#line hidden
#nullable disable
            __builder.AddContent(67, "                    ");
            __builder.OpenElement(68, "td");
            __builder.AddAttribute(69, "ondblclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 108 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\Pages\Index.razor"
                                       () => OpenModal(wIndex, dIndex)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(70, "\r\n                        ");
            __builder.AddContent(71, 
#nullable restore
#line 109 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\Pages\Index.razor"
                         weeks[weekIndex].Dates[dayIndex].value

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(72, "\r\n                        <br><br>\r\n\r\n                        ");
            __builder.OpenElement(73, "label");
            __builder.AddAttribute(74, "style", "color:#c00;font-weight:bold");
            __builder.AddContent(75, 
#nullable restore
#line 112 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\Pages\Index.razor"
                                                                    weeks[weekIndex].Dates[dayIndex].description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                        <br><br>\r\n\r\n                        Cell Number : [");
            __builder.AddContent(77, 
#nullable restore
#line 115 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\Pages\Index.razor"
                                        weekIndex

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(78, ", ");
            __builder.AddContent(79, 
#nullable restore
#line 115 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\Pages\Index.razor"
                                                    dayIndex

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(80, "]\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n");
#nullable restore
#line 117 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(82, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n");
#nullable restore
#line 119 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(84, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 123 "C:\Users\javic\Documents\GitHub\OnlineCalendarSystem-Tier1\Pages\Index.razor"
      
    
    List<string> monthNames = new List<string>();
    List<string> days = new List<string>();
    List<WeekClass> weeks = new List<WeekClass>();
    DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
    DateTime endDate = (new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)).AddMonths(1).AddDays(-1);
    bool displayModal = false;

    protected override void OnInitialized()
    {
        monthNames = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthGenitiveNames.ToList();
        GenerateCalenderHeader();
        GenerateCalenderBody();
    }
    private void LocalCalender(ChangeEventArgs e)
    {
        var month = e.Value.ToString();
        int monthIndex = DateTime.ParseExact(month, "MMMM", System.Globalization.CultureInfo.CreateSpecificCulture("en-GB")).Month;
        startDate = new DateTime(DateTime.Now.Year, monthIndex, 1);
        endDate = (new DateTime(DateTime.Now.Year, monthIndex, 1)).AddMonths(1).AddDays(-1);

        GenerateCalenderHeader();
        GenerateCalenderBody();
    }
    private void GenerateCalenderHeader()
    {
        var day1 = new List<string>();
        for (var dt = startDate; dt <= endDate; dt = dt.AddDays(1))
        {
            day1.Add(dt.ToString("dddd"));
        }
        days = day1.Distinct().ToList();
    }
    private void GenerateCalenderBody()
    {
        weeks = new List<WeekClass>();

        int flag = 0;
        WeekClass week = new WeekClass();
        List<Event> dates = new List<Event>();
        var totalDays = (int)(endDate - startDate).TotalDays;
        int countdays = 0;

        for (var dt = startDate; dt <= endDate; dt = dt.AddDays(1))
        {
            flag++;

            dates.Add(new Event()
            {
                value = dt.ToString("dd-MMM-yyyy"),
                dayName = dt.ToString("dddd")
            });

            if (flag == 7)
            {
                week = new WeekClass();
                week.Dates = dates;
                weeks.Add(week);

                dates = new List<Event>();
                flag = 0;
            }
            if (countdays == totalDays)
            {
                week = new WeekClass();
                week.Dates = dates;
                weeks.Add(week);
                break;
            }
            countdays++;
        }
    }
    private void CloseModal()
    {
        displayModal = false;
    }
    private void OpenModal(int wIndex, int dIndex)
    {
        displayModal = true;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
