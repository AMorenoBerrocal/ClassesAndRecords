// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Web.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\a.moreno.berrocal\Desktop\repositorio-records\ClassesAndRecords\02\Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\a.moreno.berrocal\Desktop\repositorio-records\ClassesAndRecords\02\Web\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\a.moreno.berrocal\Desktop\repositorio-records\ClassesAndRecords\02\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\a.moreno.berrocal\Desktop\repositorio-records\ClassesAndRecords\02\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\a.moreno.berrocal\Desktop\repositorio-records\ClassesAndRecords\02\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\a.moreno.berrocal\Desktop\repositorio-records\ClassesAndRecords\02\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\a.moreno.berrocal\Desktop\repositorio-records\ClassesAndRecords\02\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\a.moreno.berrocal\Desktop\repositorio-records\ClassesAndRecords\02\Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\a.moreno.berrocal\Desktop\repositorio-records\ClassesAndRecords\02\Web\_Imports.razor"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\a.moreno.berrocal\Desktop\repositorio-records\ClassesAndRecords\02\Web\_Imports.razor"
using Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\a.moreno.berrocal\Desktop\repositorio-records\ClassesAndRecords\02\Web\_Imports.razor"
using Web.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\a.moreno.berrocal\Desktop\repositorio-records\ClassesAndRecords\02\Web\Pages\Index.razor"
using Web.Mappers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\a.moreno.berrocal\Desktop\repositorio-records\ClassesAndRecords\02\Web\Pages\Index.razor"
using Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\a.moreno.berrocal\Desktop\repositorio-records\ClassesAndRecords\02\Web\Pages\Index.razor"
using global::Shared.Dtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\a.moreno.berrocal\Desktop\repositorio-records\ClassesAndRecords\02\Web\Pages\Index.razor"
 
    IEnumerable<EventViewModel> _events;

    protected override async void OnInitialized()
    {
        var eventDtos = await HttpClient.GetFromJsonAsync<EventDto[]>("/event");
        _events = eventDtos.Select(d => EventMapper.ConvertDtoToViewModel(d));
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EventMapper EventMapper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591
