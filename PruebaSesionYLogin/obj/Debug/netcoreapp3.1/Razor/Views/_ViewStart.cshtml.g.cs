#pragma checksum "C:\Users\Nicolin\Desktop\PruebaSesionYLogin\PruebaSesionYLogin\Views\_ViewStart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "033fb7f1ce1d9e448a71a21efc743738c40e705a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views__ViewStart), @"mvc.1.0.view", @"/Views/_ViewStart.cshtml")]
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
#line 1 "C:\Users\Nicolin\Desktop\PruebaSesionYLogin\PruebaSesionYLogin\Views\_ViewImports.cshtml"
using PruebaSesionYLogin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nicolin\Desktop\PruebaSesionYLogin\PruebaSesionYLogin\Views\_ViewImports.cshtml"
using PruebaSesionYLogin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"033fb7f1ce1d9e448a71a21efc743738c40e705a", @"/Views/_ViewStart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9d795497589b495b5038ce1608c3f5967dc4b5d", @"/Views/_ViewImports.cshtml")]
    public class Views__ViewStart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Nicolin\Desktop\PruebaSesionYLogin\PruebaSesionYLogin\Views\_ViewStart.cshtml"
   

    // Layout = "_Layout_General";

    PruebaSesionYLogin.Sessions.SessionUser objSesion = new PruebaSesionYLogin.Sessions.SessionUser();

    //User u = objSesion.GetUsuarioSession(Context);



    // object c = Context.User.Claims;

    string rolUsuario = objSesion.GetRolUsuarioClaim(Context);


    //string nombreUsuario = Context.User.Claims.FirstOrDefault(x => x.Type == System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
    //string apellido = Context.User.Claims.FirstOrDefault(x => x.Type == System.Security.Claims.ClaimTypes.Surname).Value;
    //string usuario = Context.User.Claims.FirstOrDefault(x => x.Type == System.Security.Claims.ClaimTypes.NameIdentifier).Value;

   // Layout = "_Layout_General";
    if (rolUsuario != null)
    {
        switch (rolUsuario)
        {
            case "general":
                Layout = "_Layout_General";
                break;
            //case "gerente":
            //    Layout = "_Layout_Gerente";
            //    break;
            default:
                break;
        }
    }
    else
    {


    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
