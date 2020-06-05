#pragma checksum "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/Pages/Exam/Pages/ProjectsAdd.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b7e5693a1c6b0647c5225d03ecdb898671ec521"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDesktopApp.Pages.Exam.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/_Imports.razor"
using BlazorDesktopApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/_Imports.razor"
using BlazorDesktopApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/_Imports.razor"
using WebWindows;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/Pages/Exam/Pages/ProjectsAdd.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Exam/Pages/projects-add")]
    public partial class ProjectsAdd : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<section class=""content-header"">
    <div class=""container-fluid"">
    <div class=""row mb-2"">
        <div class=""col-sm-6"">
        <h1>Project Add</h1>
        </div>
        <div class=""col-sm-6"">
        <ol class=""breadcrumb float-sm-right"">
            <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
            <li class=""breadcrumb-item active"">Project Add</li>
        </ol>
        </div>
    </div>
    </div>
</section>


");
            __builder.OpenElement(1, "section");
            __builder.AddAttribute(2, "class", "content");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddMarkupContent(6, "\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-6");
            __builder.AddMarkupContent(9, "\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card card-primary");
            __builder.AddMarkupContent(12, "\n        ");
            __builder.AddMarkupContent(13, @"<div class=""card-header"">
            <h3 class=""card-title"">General</h3>

            <div class=""card-tools"">
            <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"" data-toggle=""tooltip"" title=""Collapse"">
                <i class=""fas fa-minus""></i></button>
            </div>
        </div>
        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "card-body");
            __builder.AddMarkupContent(16, "\n            ");
            __builder.AddMarkupContent(17, "<div class=\"form-group\">\n            <label for=\"inputName\">Project Name</label>\n            <input type=\"text\" id=\"inputName\" class=\"form-control\">\n            </div>\n            ");
            __builder.AddMarkupContent(18, "<div class=\"form-group\">\n            <label for=\"inputDescription\">Project Description</label>\n            <textarea id=\"inputDescription\" class=\"form-control\" rows=\"4\"></textarea>\n            </div>\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "form-group");
            __builder.AddMarkupContent(21, "\n            ");
            __builder.AddMarkupContent(22, "<label for=\"inputStatus\">Status</label>\n            ");
            __builder.OpenElement(23, "select");
            __builder.AddAttribute(24, "class", "form-control custom-select");
            __builder.AddMarkupContent(25, "\n                ");
            __builder.OpenElement(26, "option");
            __builder.AddAttribute(27, "selected", true);
            __builder.AddAttribute(28, "disabled", true);
            __builder.AddContent(29, "Select one");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n                ");
            __builder.OpenElement(31, "option");
            __builder.AddContent(32, "On Hold");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n                ");
            __builder.OpenElement(34, "option");
            __builder.AddContent(35, "Canceled");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n                ");
            __builder.OpenElement(37, "option");
            __builder.AddContent(38, "Success");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n            ");
            __builder.AddMarkupContent(42, "<div class=\"form-group\">\n            <label for=\"inputClientCompany\">Client Company</label>\n            <input type=\"text\" id=\"inputClientCompany\" class=\"form-control\">\n            </div>\n            ");
            __builder.AddMarkupContent(43, "<div class=\"form-group\">\n            <label for=\"inputProjectLeader\">Project Leader</label>\n            <input type=\"text\" id=\"inputProjectLeader\" class=\"form-control\">\n            </div>\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n        \n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n        \n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n    ");
            __builder.AddMarkupContent(47, @"<div class=""col-md-6"">
        <div class=""card card-secondary"">
        <div class=""card-header"">
            <h3 class=""card-title"">Budget</h3>

            <div class=""card-tools"">
            <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"" data-toggle=""tooltip"" title=""Collapse"">
                <i class=""fas fa-minus""></i></button>
            </div>
        </div>
        <div class=""card-body"">
            <div class=""form-group"">
            <label for=""inputEstimatedBudget"">Estimated budget</label>
            <input type=""number"" id=""inputEstimatedBudget"" class=""form-control"">
            </div>
            <div class=""form-group"">
            <label for=""inputSpentBudget"">Total amount spent</label>
            <input type=""number"" id=""inputSpentBudget"" class=""form-control"">
            </div>
            <div class=""form-group"">
            <label for=""inputEstimatedDuration"">Estimated project duration</label>
            <input type=""number"" id=""inputEstimatedDuration"" class=""form-control"">
            </div>
        </div>
        
        </div>
        
    </div>
    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n    ");
            __builder.AddMarkupContent(49, "<div class=\"row\">\n    <div class=\"col-12\">\n        <a href=\"#\" class=\"btn btn-secondary\">Cancel</a>\n        <input type=\"submit\" value=\"Create new Porject\" class=\"btn btn-success float-right\">\n    </div>\n    </div>\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 110 "/Volumes/Macintosh HD2/CrossPlatformWork/DesktopApp/BlazorAdminLTE_side/BlazorAdminLTE/Pages/Exam/Pages/ProjectsAdd.razor"
 
    public async Task LoadJavaScript()
    {
        await JSRuntime.InvokeVoidAsync("loadJavaScript");
        //await JSRuntime.InvokeVoidAsync("loadMailBoxInBox");
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if(firstRender)
        {
            await LoadJavaScript();
            await base.OnAfterRenderAsync(firstRender);
            StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591