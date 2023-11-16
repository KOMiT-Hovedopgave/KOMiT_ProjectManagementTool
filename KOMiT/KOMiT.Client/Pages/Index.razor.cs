using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using KOMiT.Client;
using KOMiT.Client.Shared;
using static System.Net.WebRequestMethods;
using KOMiT.Core.Model;
using BlazorBootstrap;

namespace KOMiT.Client.Pages
{
    public partial class Index
    {
        private IEnumerable<Project>? _projects;
        private HttpClient _httpclient;

        public Index(IEnumerable<Project> projects, HttpClient httpclient)
        {
            _projects = projects;
            _httpclient = httpclient;
        }

        protected override async Task OnInitializedAsync()
        {
            _projects = await _httpclient.GetFromJsonAsync<IEnumerable<Project>>($"api/project/GetAll");
        }

        private async Task<GridDataProviderResult<Project>> ProjectDataProvider(GridDataProviderRequest<Project> request)
        {
            return await Task.FromResult(request.ApplyTo(_projects));
        }
    }
}