#pragma checksum "C:\Users\leger\source\repos\Blazor4Server\Blazor4Server\Pages\StudentDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65712ea3a8e4bae6bf27841a514e80c106402d4c"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor4Server.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\leger\source\repos\Blazor4Server\Blazor4Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\leger\source\repos\Blazor4Server\Blazor4Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\leger\source\repos\Blazor4Server\Blazor4Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\leger\source\repos\Blazor4Server\Blazor4Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\leger\source\repos\Blazor4Server\Blazor4Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\leger\source\repos\Blazor4Server\Blazor4Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\leger\source\repos\Blazor4Server\Blazor4Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\leger\source\repos\Blazor4Server\Blazor4Server\_Imports.razor"
using Blazor4Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\leger\source\repos\Blazor4Server\Blazor4Server\_Imports.razor"
using Blazor4Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\leger\source\repos\Blazor4Server\Blazor4Server\Pages\StudentDetail.razor"
using System.Runtime.InteropServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\leger\source\repos\Blazor4Server\Blazor4Server\Pages\StudentDetail.razor"
using Blazor4Server.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\leger\source\repos\Blazor4Server\Blazor4Server\Pages\StudentDetail.razor"
using Blazor4Server.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\leger\source\repos\Blazor4Server\Blazor4Server\Pages\StudentDetail.razor"
using Blazor4Server.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/studentdetail/{StudentId}")]
    public partial class StudentDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>StudentDetail</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-group");
            __builder.AddMarkupContent(3, "\r\n    <hr>\r\n    ");
            __builder.OpenElement(4, "dl");
            __builder.AddAttribute(5, "class", "dl-horizontal");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "dt");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "label");
            __builder.AddContent(10, 
#nullable restore
#line 14 "C:\Users\leger\source\repos\Blazor4Server\Blazor4Server\Pages\StudentDetail.razor"
                    student.Firstname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "dt");
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "label");
            __builder.AddContent(16, 
#nullable restore
#line 17 "C:\Users\leger\source\repos\Blazor4Server\Blazor4Server\Pages\StudentDetail.razor"
                    student.Lastname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "dt");
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "label");
            __builder.AddContent(22, 
#nullable restore
#line 20 "C:\Users\leger\source\repos\Blazor4Server\Blazor4Server\Pages\StudentDetail.razor"
                    student.School

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\leger\source\repos\Blazor4Server\Blazor4Server\Pages\StudentDetail.razor"
       
    Models.Student student;

    [Parameter]
    public string StudentId { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await load();
    }

    protected async Task load()
    {
        student = await Service.GetStudentByIdAsync(StudentId);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StudentService Service { get; set; }
    }
}
#pragma warning restore 1591
