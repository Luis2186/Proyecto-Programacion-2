#pragma checksum "B:\Web Obligatorio\WebObligatorio\Views\Compra\ComprasEntreFechas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8b1c5fb1f6d3fd6cba638e8e23b56436694577a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Compra_ComprasEntreFechas), @"mvc.1.0.view", @"/Views/Compra/ComprasEntreFechas.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "B:\Web Obligatorio\WebObligatorio\Views\_ViewImports.cshtml"
using WebObligatorio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "B:\Web Obligatorio\WebObligatorio\Views\_ViewImports.cshtml"
using WebObligatorio.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "B:\Web Obligatorio\WebObligatorio\Views\Compra\ComprasEntreFechas.cshtml"
using Dominio;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8b1c5fb1f6d3fd6cba638e8e23b56436694577a", @"/Views/Compra/ComprasEntreFechas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d50df6fb068349548760056cbe3d1883fc65b24d", @"/Views/_ViewImports.cshtml")]
    public class Views_Compra_ComprasEntreFechas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("formulario"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n<h1>Lista de Compras Entre Fechas</h1>\r\n\r\n<br>\r\n<br>\r\n<div class=\"listafechas\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8b1c5fb1f6d3fd6cba638e8e23b56436694577a4157", async() => {
                WriteLiteral(@"
        <h3> Seleccione el rango de fecha</h3>
        <label> Desde</label>
        <input type=""datetime-local"" name=""desde"">
        <br> <br>
        <label> Hasta </label>
        <input type=""datetime-local"" name=""hasta"">
        <br>
        <br>
        <input type=""submit"" value=""Buscar"">
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <br>\r\n    <br>\r\n</div>\r\n\r\n");
#nullable restore
#line 31 "B:\Web Obligatorio\WebObligatorio\Views\Compra\ComprasEntreFechas.cshtml"
 if (ViewBag.unaC != null && @ViewBag.unaC.Count != 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-dark table-striped"">
        <thead>
            <tr>
                <th scope=""col"">Id</th>
                <th scope=""col"">Actividad</th>
                <th scope=""col"">Cantidad de Entradas</th>
                <th scope=""col"">Usuario</th>
                <th scope=""col"">Fecha y Hora</th>
                <th scope=""col"">Precio</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 45 "B:\Web Obligatorio\WebObligatorio\Views\Compra\ComprasEntreFechas.cshtml"
             foreach (Compra unaC in @ViewBag.unaC)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 48 "B:\Web Obligatorio\WebObligatorio\Views\Compra\ComprasEntreFechas.cshtml"
                               Write(unaC.IdCompra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 49 "B:\Web Obligatorio\WebObligatorio\Views\Compra\ComprasEntreFechas.cshtml"
                   Write(unaC.ActividadComprada.NombreActividad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 50 "B:\Web Obligatorio\WebObligatorio\Views\Compra\ComprasEntreFechas.cshtml"
                   Write(unaC.CantidadDeEntradas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 51 "B:\Web Obligatorio\WebObligatorio\Views\Compra\ComprasEntreFechas.cshtml"
                   Write(unaC.IdUsuarioCompra.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 52 "B:\Web Obligatorio\WebObligatorio\Views\Compra\ComprasEntreFechas.cshtml"
                   Write(unaC.FechaYHoraCompra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 53 "B:\Web Obligatorio\WebObligatorio\Views\Compra\ComprasEntreFechas.cshtml"
                   Write(unaC.PrecioFinal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 55 "B:\Web Obligatorio\WebObligatorio\Views\Compra\ComprasEntreFechas.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            WriteLiteral("    <p>Precio Total Recaudado:");
#nullable restore
#line 59 "B:\Web Obligatorio\WebObligatorio\Views\Compra\ComprasEntreFechas.cshtml"
                         Write(ViewBag.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 60 "B:\Web Obligatorio\WebObligatorio\Views\Compra\ComprasEntreFechas.cshtml"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "B:\Web Obligatorio\WebObligatorio\Views\Compra\ComprasEntreFechas.cshtml"
     if(@ViewBag.Respuesta !=null )
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
#nullable restore
#line 66 "B:\Web Obligatorio\WebObligatorio\Views\Compra\ComprasEntreFechas.cshtml"
   Write(ViewBag.Respuesta);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 68 "B:\Web Obligatorio\WebObligatorio\Views\Compra\ComprasEntreFechas.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "B:\Web Obligatorio\WebObligatorio\Views\Compra\ComprasEntreFechas.cshtml"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
