#pragma checksum "C:\Users\elaku\Desktop\aps.net dersleri\Proje2\Proje2\Views\Defalut\BirimGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1576de459ece64811923654a8951d9e77070630c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Defalut_BirimGetir), @"mvc.1.0.view", @"/Views/Defalut/BirimGetir.cshtml")]
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
#line 1 "C:\Users\elaku\Desktop\aps.net dersleri\Proje2\Proje2\Views\_ViewImports.cshtml"
using Proje2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\elaku\Desktop\aps.net dersleri\Proje2\Proje2\Views\_ViewImports.cshtml"
using Proje2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1576de459ece64811923654a8951d9e77070630c", @"/Views/Defalut/BirimGetir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcf623c21345221fb47b2c4365df2e40ed5ebe0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Defalut_BirimGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Proje2.Models.Birim>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\elaku\Desktop\aps.net dersleri\Proje2\Proje2\Views\Defalut\BirimGetir.cshtml"
  
    ViewData["Title"] = "DepartmanGetir";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\elaku\Desktop\aps.net dersleri\Proje2\Proje2\Views\Defalut\BirimGetir.cshtml"
 using (Html.BeginForm("BirimGüncelle", "Defalut", FormMethod.Post))
{



#line default
#line hidden
#nullable disable
            WriteLiteral("    <b>Birim ID</b>\r\n");
#nullable restore
#line 13 "C:\Users\elaku\Desktop\aps.net dersleri\Proje2\Proje2\Views\Defalut\BirimGetir.cshtml"
Write(Html.TextAreaFor(x => x.BirimId, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <b>Birim Adı</b>\r\n");
#nullable restore
#line 17 "C:\Users\elaku\Desktop\aps.net dersleri\Proje2\Proje2\Views\Defalut\BirimGetir.cshtml"
Write(Html.TextAreaFor(x => x.Ad, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-info\" style=\"background-color:cyan\">Birim Güncelle</button>\r\n");
#nullable restore
#line 20 "C:\Users\elaku\Desktop\aps.net dersleri\Proje2\Proje2\Views\Defalut\BirimGetir.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Proje2.Models.Birim> Html { get; private set; }
    }
}
#pragma warning restore 1591