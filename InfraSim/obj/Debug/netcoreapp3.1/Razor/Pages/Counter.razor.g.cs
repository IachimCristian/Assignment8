#pragma checksum "D:\Engenharia_de_Software\Assignment2\InfraSim\Pages\Counter.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a01f942b5f980398b9991ceaf1a8993f848782231f152d365255e51dde915d61"
// <auto-generated/>
#pragma warning disable 1591
namespace InfraSim.Pages
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Engenharia_de_Software\Assignment2\InfraSim\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "D:\Engenharia_de_Software\Assignment2\InfraSim\_Imports.razor"
using Microsoft.AspNetCore.Authorization

#nullable disable
    ;
#nullable restore
#line 3 "D:\Engenharia_de_Software\Assignment2\InfraSim\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization

#nullable disable
    ;
#nullable restore
#line 4 "D:\Engenharia_de_Software\Assignment2\InfraSim\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 5 "D:\Engenharia_de_Software\Assignment2\InfraSim\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 6 "D:\Engenharia_de_Software\Assignment2\InfraSim\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 7 "D:\Engenharia_de_Software\Assignment2\InfraSim\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 8 "D:\Engenharia_de_Software\Assignment2\InfraSim\_Imports.razor"
using InfraSim

#nullable disable
    ;
#nullable restore
#line 9 "D:\Engenharia_de_Software\Assignment2\InfraSim\_Imports.razor"
using InfraSim.Shared

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "D:\Engenharia_de_Software\Assignment2\InfraSim\Pages\Counter.razor"
      "/counter"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class Counter : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "D:\Engenharia_de_Software\Assignment2\InfraSim\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "D:\Engenharia_de_Software\Assignment2\InfraSim\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "D:\Engenharia_de_Software\Assignment2\InfraSim\Pages\Counter.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
#nullable disable

    }
}
#pragma warning restore 1591
