#pragma checksum "/home/richez/Bureau/Projet/Mega_20210526_23h/WebApplication1/Views/Devis/FormulaireDevis3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b4dcf788765b3790183788d9ff64d09e66b4aff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Devis_FormulaireDevis3), @"mvc.1.0.view", @"/Views/Devis/FormulaireDevis3.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b4dcf788765b3790183788d9ff64d09e66b4aff", @"/Views/Devis/FormulaireDevis3.cshtml")]
    public class Views_Devis_FormulaireDevis3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.ViewModels.DevisViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/richez/Bureau/Projet/Mega_20210526_23h/WebApplication1/Views/Devis/FormulaireDevis3.cshtml"
  
    Layout = "~/Views/Shared/_LayoutDeconnecte.cshtml";
    ViewBag.Title = "Formulaire Devis 3";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/richez/Bureau/Projet/Mega_20210526_23h/WebApplication1/Views/Devis/FormulaireDevis3.cshtml"
 if (!Context.User.Identity.IsAuthenticated)
{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""text-left"" style=""text-align:center"">
        <h3>Merci pour votre demande de devis.</h3> <br />
        <div class=""texte devis3"">
            Nous allons traiter votre demande au plus vite, vous recevrez une réponse de notre part sous 3 jours ouvrés. <br />
            <br />
            En attendant, vous allez recevoir par email vos identifiants afin de vous connecter à votre espace client à partir duquel vous pourrez suivre l'avancement de votre devis.
            <div style=""text-decoration: underline; color: white"">
                ");
#nullable restore
#line 16 "/home/richez/Bureau/Projet/Mega_20210526_23h/WebApplication1/Views/Devis/FormulaireDevis3.cshtml"
           Write(Html.ActionLink("Accéder à votre espace en ligne", "Index", "Connexion", null, new { @style = "color:white; text-decoration: underline;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n            Vous pouvez également nous contacter directement pour toute demande urgente.<br />\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 22 "/home/richez/Bureau/Projet/Mega_20210526_23h/WebApplication1/Views/Devis/FormulaireDevis3.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""text-left"" style=""text-align:center"">
        <h3>Merci pour votre nouvelle demande de devis.</h3> <br />
        <div class=""texte devis3"">
            Nous allons traiter votre demande au plus vite, vous recevrez une réponse de notre part sous 3 jours ouvrés. <br />
            <br />
            En attendant, n'hésitez pas à consulter le récapitulatif de vos devis dans votre espace.<br />
            <br />
            <div>
                ");
#nullable restore
#line 33 "/home/richez/Bureau/Projet/Mega_20210526_23h/WebApplication1/Views/Devis/FormulaireDevis3.cshtml"
           Write(Html.ActionLink("Consulter mes devis en cours", "DemandeDevis", "Connexion", null, new { @style = "color:white; text-decoration: underline;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n            Vous pouvez également nous contacter pour toute demande urgente.<br />\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 39 "/home/richez/Bureau/Projet/Mega_20210526_23h/WebApplication1/Views/Devis/FormulaireDevis3.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.ViewModels.DevisViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
