#pragma checksum "B:\Web Obligatorio\WebObligatorio\Views\Usuario\AltaUsuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4078304c97a7dab81ee7f0171064de5d53ca705c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_AltaUsuario), @"mvc.1.0.view", @"/Views/Usuario/AltaUsuario.cshtml")]
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
#line 1 "B:\Web Obligatorio\WebObligatorio\Views\Usuario\AltaUsuario.cshtml"
using Dominio;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4078304c97a7dab81ee7f0171064de5d53ca705c", @"/Views/Usuario/AltaUsuario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d50df6fb068349548760056cbe3d1883fc65b24d", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_AltaUsuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Usuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("formulario"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("registro"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4078304c97a7dab81ee7f0171064de5d53ca705c4357", async() => {
                WriteLiteral("\r\n    <label");
                BeginWriteAttribute("for", " for=\"", 230, "\"", 236, 0);
                EndWriteAttribute();
                WriteLiteral(">Nombre </label>\r\n    <input type=\"text\" name=\"nombre\"");
                BeginWriteAttribute("value", " value=\"", 291, "\"", 314, 1);
#nullable restore
#line 11 "B:\Web Obligatorio\WebObligatorio\Views\Usuario\AltaUsuario.cshtml"
WriteAttributeValue("", 299, ViewBag.nombre, 299, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><br>\r\n    <label");
                BeginWriteAttribute("for", " for=\"", 332, "\"", 338, 0);
                EndWriteAttribute();
                WriteLiteral(">Apellido</label>\r\n    <input type=\"text\" name=\"apellido\"");
                BeginWriteAttribute("value", " value=\"", 396, "\"", 421, 1);
#nullable restore
#line 13 "B:\Web Obligatorio\WebObligatorio\Views\Usuario\AltaUsuario.cshtml"
WriteAttributeValue("", 404, ViewBag.apellido, 404, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><br>\r\n    <label");
                BeginWriteAttribute("for", " for=\"", 439, "\"", 445, 0);
                EndWriteAttribute();
                WriteLiteral(">E-Mail </label>\r\n    <input type=\"text\" name=\"email\"");
                BeginWriteAttribute("value", " value=\"", 499, "\"", 521, 1);
#nullable restore
#line 15 "B:\Web Obligatorio\WebObligatorio\Views\Usuario\AltaUsuario.cshtml"
WriteAttributeValue("", 507, ViewBag.email, 507, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><br>\r\n    <label");
                BeginWriteAttribute("for", " for=\"", 539, "\"", 545, 0);
                EndWriteAttribute();
                WriteLiteral(">Fecha de Nacimiento</label>\r\n    <input type=\"date\" name=\"fechaNacimiento\"");
                BeginWriteAttribute("value", " value=\"", 621, "\"", 653, 1);
#nullable restore
#line 17 "B:\Web Obligatorio\WebObligatorio\Views\Usuario\AltaUsuario.cshtml"
WriteAttributeValue("", 629, ViewBag.fechaNacimiento, 629, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required><br>\r\n    <label");
                BeginWriteAttribute("for", " for=\"", 680, "\"", 686, 0);
                EndWriteAttribute();
                WriteLiteral(">Nombre de Usuario </label>\r\n    <input type=\"text\" name=\"nombreUsuario\"");
                BeginWriteAttribute("value", " value=\"", 759, "\"", 789, 1);
#nullable restore
#line 19 "B:\Web Obligatorio\WebObligatorio\Views\Usuario\AltaUsuario.cshtml"
WriteAttributeValue("", 767, ViewBag.nombreUsuario, 767, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><br>\r\n    <label");
                BeginWriteAttribute("for", " for=\"", 807, "\"", 813, 0);
                EndWriteAttribute();
                WriteLiteral(">Contrase??a </label>\r\n    <input type=\"password\" name=\"contrase??a\"><br>\r\n    <input type=\"submit\" value=\"Registrar\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 26 "B:\Web Obligatorio\WebObligatorio\Views\Usuario\AltaUsuario.cshtml"
 if (ViewBag.ResultadoOk != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        ");
#nullable restore
#line 29 "B:\Web Obligatorio\WebObligatorio\Views\Usuario\AltaUsuario.cshtml"
   Write(ViewBag.ResultadoOk);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 31 "B:\Web Obligatorio\WebObligatorio\Views\Usuario\AltaUsuario.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 33 "B:\Web Obligatorio\WebObligatorio\Views\Usuario\AltaUsuario.cshtml"
 if (ViewBag.ResultadoError != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
#nullable restore
#line 36 "B:\Web Obligatorio\WebObligatorio\Views\Usuario\AltaUsuario.cshtml"
   Write(ViewBag.ResultadoError);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 38 "B:\Web Obligatorio\WebObligatorio\Views\Usuario\AltaUsuario.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
