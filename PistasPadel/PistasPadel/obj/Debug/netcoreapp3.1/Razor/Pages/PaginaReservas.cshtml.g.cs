#pragma checksum "C:\Users\steve\Source\Repos\thedragonflu\PistasPadel\PistasPadel\PistasPadel\Pages\PaginaReservas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "318d8849bb5b267bc9fe1d83806abab50a10056e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PistasPadel.Pages.Pages_PaginaReservas), @"mvc.1.0.razor-page", @"/Pages/PaginaReservas.cshtml")]
namespace PistasPadel.Pages
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
#line 1 "C:\Users\steve\Source\Repos\thedragonflu\PistasPadel\PistasPadel\PistasPadel\Pages\_ViewImports.cshtml"
using PistasPadel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"318d8849bb5b267bc9fe1d83806abab50a10056e", @"/Pages/PaginaReservas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a857f7d8d0ed1ccd039a80c6d41cfcf8e8ba67b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_PaginaReservas : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\steve\Source\Repos\thedragonflu\PistasPadel\PistasPadel\PistasPadel\Pages\PaginaReservas.cshtml"
  
    ViewData["Title"] = "Reservas";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""container"">
        <div class=""row"">
            <div class='col-sm-6'>
                <div class=""form-group"">
                    <div class='input-group date' id='datetimepicker1'>
                        <input type='text' class=""form-control"" />
                        <span class=""input-group-addon"">
                            <span class=""glyphicon glyphicon-calendar""></span>
                        </span>
                    </div>
                </div>
            </div>
            <script type=""text/javascript"">
            $(function () {
                $('#datetimepicker1').datetimepicker();
            });
            </script>
        </div>
    </div>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PistasPadel.Pages.PaginaReservasModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PistasPadel.Pages.PaginaReservasModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PistasPadel.Pages.PaginaReservasModel>)PageContext?.ViewData;
        public PistasPadel.Pages.PaginaReservasModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
