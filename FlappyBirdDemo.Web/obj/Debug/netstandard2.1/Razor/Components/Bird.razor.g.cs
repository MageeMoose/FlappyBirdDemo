#pragma checksum "C:\Users\User\source\repos\FlappyBirdDemo\FlappyBirdDemo.Web\Components\Bird.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f2c133c9dfbf55d6aadb1c2bd052dc4b1ff8d5d"
// <auto-generated/>
#pragma warning disable 1591
namespace FlappyBirdDemo.Web.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\source\repos\FlappyBirdDemo\FlappyBirdDemo.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\FlappyBirdDemo\FlappyBirdDemo.Web\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\FlappyBirdDemo\FlappyBirdDemo.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\FlappyBirdDemo\FlappyBirdDemo.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\source\repos\FlappyBirdDemo\FlappyBirdDemo.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\source\repos\FlappyBirdDemo\FlappyBirdDemo.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\source\repos\FlappyBirdDemo\FlappyBirdDemo.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\source\repos\FlappyBirdDemo\FlappyBirdDemo.Web\_Imports.razor"
using FlappyBirdDemo.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\source\repos\FlappyBirdDemo\FlappyBirdDemo.Web\_Imports.razor"
using FlappyBirdDemo.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\source\repos\FlappyBirdDemo\FlappyBirdDemo.Web\_Imports.razor"
using FlappyBirdDemo.Web.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\source\repos\FlappyBirdDemo\FlappyBirdDemo.Web\_Imports.razor"
using FlappyBirdDemo.Web.Models;

#line default
#line hidden
#nullable disable
    public partial class Bird : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "bird");
            __builder.AddAttribute(2, "style", 
#nullable restore
#line 1 "C:\Users\User\source\repos\FlappyBirdDemo\FlappyBirdDemo.Web\Components\Bird.razor"
                          _birdCss

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\Users\User\source\repos\FlappyBirdDemo\FlappyBirdDemo.Web\Components\Bird.razor"
       

    [Parameter] public BirdModel Model { get; set; }

    string _birdCss => $"bottom: {Model.DistanceFromGround}px";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
