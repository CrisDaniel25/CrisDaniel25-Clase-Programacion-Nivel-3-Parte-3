#pragma checksum "C:\Users\crist\Desktop\Programacion III\Tarea-3\Pages\Ejercicio_4.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9432767972ab286e529e45f2976c517c83950e0"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea_3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\crist\Desktop\Programacion III\Tarea-3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\crist\Desktop\Programacion III\Tarea-3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\crist\Desktop\Programacion III\Tarea-3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\crist\Desktop\Programacion III\Tarea-3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\crist\Desktop\Programacion III\Tarea-3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\crist\Desktop\Programacion III\Tarea-3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\crist\Desktop\Programacion III\Tarea-3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\crist\Desktop\Programacion III\Tarea-3\_Imports.razor"
using Tarea_3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\crist\Desktop\Programacion III\Tarea-3\_Imports.razor"
using Tarea_3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\crist\Desktop\Programacion III\Tarea-3\Pages\Ejercicio_4.razor"
using Tarea_3.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\crist\Desktop\Programacion III\Tarea-3\Pages\Ejercicio_4.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Ejercicio-4")]
    public partial class Ejercicio_4 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"text-center\">Ejercicio #4</h1>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<div class=\"row justify-content-center\">\r\n        <p>Programa que acepte el codigo de un video de youtube, mostrar en la pagina el video con opcion a reproducir. Ejemplo ICfaQ8mSppM. </p>\r\n    </div>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "class", "form-control");
            __builder.AddAttribute(13, "placeholder", "Escriba aqui");
            __builder.AddAttribute(14, "type", "text");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\crist\Desktop\Programacion III\Tarea-3\Pages\Ejercicio_4.razor"
                                                                                      code

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => code = __value, code));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col");
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "btn btn-dark");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\crist\Desktop\Programacion III\Tarea-3\Pages\Ejercicio_4.razor"
                                                   Search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Buscar");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "<br>\r\n    ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "col justify-content-center");
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.OpenElement(32, "ul");
            __builder.AddAttribute(33, "class", "list-group");
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.OpenElement(35, "li");
            __builder.AddAttribute(36, "class", "list-group-item text-center");
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "iframe");
            __builder.AddAttribute(39, "width", "auto");
            __builder.AddAttribute(40, "height", "auto");
            __builder.AddAttribute(41, "src", 
#nullable restore
#line 22 "C:\Users\crist\Desktop\Programacion III\Tarea-3\Pages\Ejercicio_4.razor"
                          video

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, " \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\crist\Desktop\Programacion III\Tarea-3\Pages\Ejercicio_4.razor"
       
    private string URL_API = "https://www.youtube.com/embed/";
    public string video =  "";
    public string code {get; set;}

    public void Search() { video = string.IsNullOrEmpty(code) ? "" : URL_API + code; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
