#pragma checksum "C:\Users\ACER - PC\Desktop\HousesPeru\HousesPeru\Views\Usuario\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4138cc7514dc92154ec94b6050c93839c88fec2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Login), @"mvc.1.0.view", @"/Views/Usuario/Login.cshtml")]
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
#line 1 "C:\Users\ACER - PC\Desktop\HousesPeru\HousesPeru\Views\_ViewImports.cshtml"
using HousesPeru;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACER - PC\Desktop\HousesPeru\HousesPeru\Views\_ViewImports.cshtml"
using HousesPeru.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4138cc7514dc92154ec94b6050c93839c88fec2f", @"/Views/Usuario/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"769d36433304ae6c2cc172655e10850fdeaf3c3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ACER - PC\Desktop\HousesPeru\HousesPeru\Views\Usuario\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""modal fade"" id=""LogIn"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel""
     aria-hidden=""true"">
    <div class=""modal-dialog form-dark"" role=""document"">
        <!--Content-->
        <div class=""modal-content card card-image img-fluid"" style=""background-image: url('https://www.gratistodo.com/wp-content/uploads/2017/02/Casas-Modernas-7.jpg');"">
            <div class=""text-white rgba-stylish-strong py-5 px-5 z-depth-4"">
                <!--Header-->
                <div class=""modal-header text-center pb-4"">
                    <h3 class=""modal-title w-100 white-text font-weight-bold"" id=""myModalLabel"">
                        <strong>INGRESAR</strong> <a class=""green-text font-weight-bold""><strong></strong></a>
                    </h3>
                    <button type=""button"" class=""close white-text"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
           ");
            WriteLiteral(@"     <!--Body-->
                <div class=""modal-body"">
                    <!--Body-->
                    <div class=""md-form mb-5"">
                        <input type=""email"" id=""Form-email5"" class=""form-control validate white-text""¨placeholder=""Email"">
                        <label data-error=""wrong"" data-success=""right"" for=""Form-email5"">Tu correo electronico</label>
                    </div>

                    <div class=""md-form pb-3"">
                        <input type=""password"" id=""Form-pass5"" class=""form-control validate white-text""placeholder=""password"">
                        <label data-error=""wrong"" data-success=""right"" for=""Form-pass5"">Tu contraseña</label>
");
            WriteLiteral(@"                    </div>

                    <!--Grid row-->
                    <div class=""row d-flex align-items-center mb-4"">

                        <!--Grid column-->
                        <div class=""text-center mb-3 col-md-12"">
                            <button type=""button"" class=""btn btn-success btn-block btn-rounded z-depth-1"">Ingresar</button>
                        </div>
                        <!--Grid column-->

                    </div>
                    <!--Grid row-->
                    <!--Grid row-->
                    <div class=""row"">

                        <!--Grid column-->
                        <div class=""col-md-12"">
                            <p class=""font-small white-text d-flex justify-content-end"">
                                ¿Nuevo en HousesInPeru? <a href=""#"" class=""green-text ml-1 font-weight-bold"">
                                    Registrarse
                                </a>
                            </p>
              ");
            WriteLiteral("          </div>\r\n                        <!--Grid column-->\r\n\r\n                    </div>\r\n                    <!--Grid row-->\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!--/.Content-->\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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