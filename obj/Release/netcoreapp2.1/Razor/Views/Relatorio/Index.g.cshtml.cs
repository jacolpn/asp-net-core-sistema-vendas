#pragma checksum "C:\Users\jacol\source\repos\SistemaVendasAspNetCore\Views\Relatorio\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5632e184e669367bdc42f0681386677d76690cc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Relatorio_Index), @"mvc.1.0.view", @"/Views/Relatorio/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Relatorio/Index.cshtml", typeof(AspNetCore.Views_Relatorio_Index))]
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
#line 1 "C:\Users\jacol\source\repos\SistemaVendasAspNetCore\Views\_ViewImports.cshtml"
using SistemaVendasAspNetCore;

#line default
#line hidden
#line 2 "C:\Users\jacol\source\repos\SistemaVendasAspNetCore\Views\_ViewImports.cshtml"
using SistemaVendasAspNetCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5632e184e669367bdc42f0681386677d76690cc2", @"/Views/Relatorio/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a94a07b345e062074d715a4d42b5cc3b194252ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Relatorio_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 505, true);
            WriteLiteral(@"<h2>Relatórios do Sistema</h2>

<button class=""btn btn-block btn-primary"" type=""button"" onclick=""Relatorio('Vendas')"">Vendas por Período</button>
<button class=""btn btn-block btn-warning"" type=""button"" onclick=""Relatorio('Grafico')"">Gráfico de Vendas</button>
<button class=""btn btn-block btn-success"" type=""button"" onclick=""Relatorio('Comissao')"">Comissão de Vendedores</button>

<script>
    function Relatorio(action) {
        window.location.href = ""../Relatorio/"" + action;
    }
</script>");
            EndContext();
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
