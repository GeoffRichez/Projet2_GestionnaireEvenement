#pragma checksum "/home/richez/Bureau/Projet/Mega_20210526_23h/WebApplication1/Views/Informations/ModifierEntreprise.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6dd0a57191ed517126b40cb7563166d6dfcd031"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Informations_ModifierEntreprise), @"mvc.1.0.view", @"/Views/Informations/ModifierEntreprise.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6dd0a57191ed517126b40cb7563166d6dfcd031", @"/Views/Informations/ModifierEntreprise.cshtml")]
    public class Views_Informations_ModifierEntreprise : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.Entreprise>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/informations.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/richez/Bureau/Projet/Mega_20210526_23h/WebApplication1/Views/Informations/ModifierEntreprise.cshtml"
  
    Layout = "~/Views/Shared/_LayoutPF.cshtml";
    ViewBag.Title = "Mes informations";


#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6dd0a57191ed517126b40cb7563166d6dfcd0313772", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c6dd0a57191ed517126b40cb7563166d6dfcd0314030", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<div class=\"text-left\">\n\n\n    <div class=\"container\">\n        <!--<div class=\"col-10\">        \n        </div>-->\n         <div class=\"col-10\">\r\n             <h3 class=\"section-title\">Coordonnées de la société</h3>\r\n            </div><br />   \n\n");
#nullable restore
#line 25 "/home/richez/Bureau/Projet/Mega_20210526_23h/WebApplication1/Views/Informations/ModifierEntreprise.cshtml"
         using (Html.BeginForm("ModifierEntreprise", "Informations", FormMethod.Post))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "/home/richez/Bureau/Projet/Mega_20210526_23h/WebApplication1/Views/Informations/ModifierEntreprise.cshtml"
       Write(Html.HiddenFor(m => m.UtilisateurEntreprise.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("             <div class=\"form-group row\">\r\n                    <label for=\"NomSociete\" class=\"col-sm-2 col-form-label\">Nom de la société</label>\r\n                    <div class=\"col-sm-10\">\n                        ");
#nullable restore
#line 32 "/home/richez/Bureau/Projet/Mega_20210526_23h/WebApplication1/Views/Informations/ModifierEntreprise.cshtml"
                   Write(Html.TextBoxFor(m => Model.NomEntreprise, new { @class = "form-control", style = "margin-top: 10px", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\r\n             </div>\n");
            WriteLiteral("             <div class=\"form-group row\">\r\n                    <label for=\"NumeroSiret\" class=\"col-sm-2 col-form-label\">Numéro de Siret</label>\r\n                    <div class=\"col-sm-10\">\n                        ");
#nullable restore
#line 39 "/home/richez/Bureau/Projet/Mega_20210526_23h/WebApplication1/Views/Informations/ModifierEntreprise.cshtml"
                   Write(Html.TextBoxFor(m => Model.Siret, new { @class = "form-control", style = "margin-top: 10px", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\r\n             </div>\n             <div class=\"form-group row\">\n                 <label for=\"AdresseLieu\" class=\"col-sm-2 col-form-label\">Adresse</label>\n                 <div class=\"col-sm-10\">\n                     ");
#nullable restore
#line 45 "/home/richez/Bureau/Projet/Mega_20210526_23h/WebApplication1/Views/Informations/ModifierEntreprise.cshtml"
                Write(Html.TextBoxFor(m => Model.Adresse.AdresseLieu, new { @class = "form-control", style = "margin-top: 10px", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                 </div>\n             </div>\n");
            WriteLiteral("             <div class=\"form-group row\">\n                 <label for=\"AdresseCP\" class=\"col-sm-2 col-form-label\">Code postal</label>\n                 <div class=\"col-sm-10\">\n                     ");
#nullable restore
#line 52 "/home/richez/Bureau/Projet/Mega_20210526_23h/WebApplication1/Views/Informations/ModifierEntreprise.cshtml"
                Write(Html.TextBoxFor(m => Model.Adresse.CPLieu, new { @class = "form-control", style = "margin-top: 10px", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                 </div>\n             </div>\n");
            WriteLiteral("             <div class=\"form-group row\">\n                 <label for=\"AdresseVille\" class=\"col-sm-2 col-form-label\">Ville</label>\n                 <div class=\"col-sm-10\">\n                     ");
#nullable restore
#line 59 "/home/richez/Bureau/Projet/Mega_20210526_23h/WebApplication1/Views/Informations/ModifierEntreprise.cshtml"
                Write(Html.TextBoxFor(m => Model.Adresse.VilleLieu, new { @class = "form-control", style = "margin-top: 10px", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                 </div>\n             </div>\n            <br /><br />\n");
            WriteLiteral("            <div class=\"col-10\">\r\n                <h3 class=\"section-title\">Informations de l\'interlocuteur</h3>\r\n                Vous pouvez mettre ces informations à jour si vous le souhaitez.\r\n            </div>          \n");
            WriteLiteral("            <div class=\"form-group row\">\n                <label for=\"nomUser\" class=\"col-sm-2 col-form-label\">Nom</label>\n                <div class=\"col-sm-10\">\n                    ");
#nullable restore
#line 72 "/home/richez/Bureau/Projet/Mega_20210526_23h/WebApplication1/Views/Informations/ModifierEntreprise.cshtml"
               Write(Html.TextBoxFor(m => Model.UtilisateurEntreprise.NomUtilisateur, new { @class = "form-control", style = "margin-top: 10px" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n");
            WriteLiteral("            <div class=\"form-group row\">\n                <label for=\"prenomUser\" class=\"col-sm-2 col-form-label\">Prénom</label>\n                <div class=\"col-sm-10\">\n                    ");
#nullable restore
#line 79 "/home/richez/Bureau/Projet/Mega_20210526_23h/WebApplication1/Views/Informations/ModifierEntreprise.cshtml"
               Write(Html.TextBoxFor(m => Model.UtilisateurEntreprise.PrenomUtilisateur, new { @class = "form-control", style = "margin-top: 10px" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n");
            WriteLiteral("            <div class=\"form-group row\">\n                <label for=\"FonctionUser\" class=\"col-sm-2 col-form-label\">Fonction</label>\n                <div class=\"col-sm-10\">\n                    ");
#nullable restore
#line 86 "/home/richez/Bureau/Projet/Mega_20210526_23h/WebApplication1/Views/Informations/ModifierEntreprise.cshtml"
               Write(Html.TextBoxFor(m => Model.UtilisateurEntreprise.FonctionUtilisateur, new { @class = "form-control", style = "margin-top: 10px" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n");
            WriteLiteral("            <div class=\"form-group row\">\n                <label for=\"TelUser\" class=\"col-sm-2 col-form-label\">Téléphone</label>\n                <div class=\"col-sm-10\">\n                    ");
#nullable restore
#line 93 "/home/richez/Bureau/Projet/Mega_20210526_23h/WebApplication1/Views/Informations/ModifierEntreprise.cshtml"
               Write(Html.TextBoxFor(m => Model.UtilisateurEntreprise.TelephoneUtilisateur, new { @class = "form-control", style = "margin-top: 10px" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n");
            WriteLiteral("            <div class=\"form-group row\">\n                <label for=\"melUser\" class=\"col-sm-2 col-form-label\">Email</label>\n                <div class=\"col-sm-10\">\n                    ");
#nullable restore
#line 100 "/home/richez/Bureau/Projet/Mega_20210526_23h/WebApplication1/Views/Informations/ModifierEntreprise.cshtml"
               Write(Html.TextBoxFor(m => Model.UtilisateurEntreprise.Mail, new { @class = "form-control", style = "margin-top: 10px" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n");
            WriteLiteral(@"                <div align=""right"" style=""padding-top: 20px"">
                        <a class=""button"" href=""#popup1"">Modifier</a>                   
                    <div id=""popup1"" class=""overlay"">
                        <div class=""popup"">
                            <h6 style=""text-align:center; color:black"";> Etes-vous sûr de vouloir modifier ces informations ? </h6>
                            <a class=""close"" href=""#"">&times;</a>
                            <div class=""content"" style=""text-align:center"">
                                <input type=""submit"" value=""Valider"" />
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 116 "/home/richez/Bureau/Projet/Mega_20210526_23h/WebApplication1/Views/Informations/ModifierEntreprise.cshtml"
               
         }   

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n\n</div>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.Entreprise> Html { get; private set; }
    }
}
#pragma warning restore 1591
