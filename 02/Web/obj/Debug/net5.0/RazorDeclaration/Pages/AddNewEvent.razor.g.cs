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
#line 2 "C:\Users\a.moreno.berrocal\Desktop\repositorio-records\ClassesAndRecords\02\Web\Pages\AddNewEvent.razor"
using Web.Mappers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\a.moreno.berrocal\Desktop\repositorio-records\ClassesAndRecords\02\Web\Pages\AddNewEvent.razor"
using Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\a.moreno.berrocal\Desktop\repositorio-records\ClassesAndRecords\02\Web\Pages\AddNewEvent.razor"
using global::Shared.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\a.moreno.berrocal\Desktop\repositorio-records\ClassesAndRecords\02\Web\Pages\AddNewEvent.razor"
using global::Shared.Dtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/addnew")]
    public partial class AddNewEvent : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 91 "C:\Users\a.moreno.berrocal\Desktop\repositorio-records\ClassesAndRecords\02\Web\Pages\AddNewEvent.razor"
 
    private EventViewModel _eventViewModel = new();

    private void EventTypeChanged(EventType eventType)
    {
        if (_eventViewModel.EventType == eventType)
            return;

        EventViewModel newViewModel;

        switch (eventType)
        {
            case EventType.Unknown:
                newViewModel = new EventViewModel();
                break;
            case EventType.Conference:
                newViewModel = new ConferenceViewModel();
                break;
            case EventType.MultiDayConference:
                newViewModel = new MultiDayConferenceViewModel();
                break;
            case EventType.Concert:
                newViewModel = new ConcertViewModel();
                break;
            case EventType.SportsGame:
                newViewModel = new SportsGameViewModel();
                break;
            default:
                throw new ArgumentException($"Unknown event type {eventType}");
        }

        EventMapper.CopyBaseProperties(_eventViewModel, newViewModel);
        newViewModel.EventType = eventType;
        _eventViewModel = newViewModel;
    }

    private async Task HandleValidSubmit()
    {
        EventDto dto = null;
        if (_eventViewModel is ConferenceViewModel conferenceViewModel)
            dto = EventMapper.ConvertConferenceViewModelToDto(conferenceViewModel);
        if (_eventViewModel is MultiDayConferenceViewModel multiDayConferenceViewModel)
            dto = EventMapper.ConvertMultiDayConferenceViewModelToDto(multiDayConferenceViewModel);
        if (_eventViewModel is ConcertViewModel concertViewModel)
            dto = EventMapper.ConvertConcertViewModelToDto(concertViewModel);
        if (_eventViewModel is SportsGameViewModel sportsGameViewModel)
            dto = EventMapper.ConvertSportsGameViewModelToDto(sportsGameViewModel);
        if (dto == null)
            throw new ArgumentException("Unknown viewmodel type");

        var result = await HttpClient.PostAsJsonAsync(_eventViewModel.ApiEndpoint, dto);
        result.EnsureSuccessStatusCode();
        NavigationManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EventMapper EventMapper { get; set; }
    }
}
#pragma warning restore 1591
