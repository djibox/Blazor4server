using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Blazor4Server.Services;
using Blazor4Server.Models;

namespace Blazor4Server.Pages
{
    public class StudentBase:ComponentBase
    {
        public List<Models.Student> _students ;
        StudentService Service;

        protected override async Task OnInitializedAsync()
        {
            _students = await Service.GetAllStudentsAsync();
        }
    }
}
