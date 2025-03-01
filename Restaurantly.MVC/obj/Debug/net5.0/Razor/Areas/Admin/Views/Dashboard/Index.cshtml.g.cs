#pragma checksum "C:\Users\fatih\source\repos\Restaurantly\Restaurantly.MVC\Areas\Admin\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a040b6f022c70e1a4ddc5af41b01c7abedce8a84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
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
#line 2 "C:\Users\fatih\source\repos\Restaurantly\Restaurantly.MVC\Areas\Admin\Views\_ViewImports.cshtml"
using Restaurantly.Entity.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\fatih\source\repos\Restaurantly\Restaurantly.MVC\Areas\Admin\Views\_ViewImports.cshtml"
using Restaurantly.MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\fatih\source\repos\Restaurantly\Restaurantly.MVC\Areas\Admin\Views\_ViewImports.cshtml"
using Restaurantly.Entity.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a040b6f022c70e1a4ddc5af41b01c7abedce8a84", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6425ecbd0f4419d26b50a9009bf467491f1e21f1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\fatih\source\repos\Restaurantly\Restaurantly.MVC\Areas\Admin\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid pt-4 px-4 "">
    <div class=""row g-4 mb-3"">
        <div class=""col-sm-6 col-xl-4"">
            <div class=""bg-light rounded d-flex align-items-center justify-content-between p-4"">
                <i class=""fa fa-chart-line fa-3x text-primary""></i>
                <div class=""ms-3"">
                    <p class=""mb-2""> Rezervasyon Sayısı</p>
                    <h5 class=""mb-0"">");
#nullable restore
#line 14 "C:\Users\fatih\source\repos\Restaurantly\Restaurantly.MVC\Areas\Admin\Views\Dashboard\Index.cshtml"
                                Write(ViewData["ReservationCount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Rezervasyon</h5>
                </div>
            </div>
        </div>
        <div class=""col-sm-6 col-xl-4"">
            <div class=""bg-light rounded d-flex align-items-center justify-content-between p-4"">
                <i class=""fa fa-chart-bar fa-3x text-primary""></i>
                <div class=""ms-3"">
                    <p class=""mb-2"">Misafir Sayısı</p>
                    <h5 class=""mb-0"">");
#nullable restore
#line 23 "C:\Users\fatih\source\repos\Restaurantly\Restaurantly.MVC\Areas\Admin\Views\Dashboard\Index.cshtml"
                                Write(ViewData["UserCount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Kullanıcı</h5>
                </div>
            </div>
        </div>
        <div class=""col-sm-6 col-xl-4"">
            <div class=""bg-light rounded d-flex align-items-center justify-content-between p-4"">
                <i class=""fa fa-chart-area fa-3x text-primary""></i>
                <div class=""ms-3"">
                    <p class=""mb-2"">Menü Sayısı</p>
                    <h5 class=""mb-0"">");
#nullable restore
#line 32 "C:\Users\fatih\source\repos\Restaurantly\Restaurantly.MVC\Areas\Admin\Views\Dashboard\Index.cshtml"
                                Write(ViewData["MenuCount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Menü</h5>
                </div>
            </div>
        </div>
    </div>
</div>
<table class=""table table-bordered table-striped mt-4 "">
    <h4 class=""text-primary text-center mt-3""> Rezervasyon Listesi</h4>
    <thead>
        <tr>
            <th>#</th>
            <th>Name</th>
            <th>Email</th>
            <th>Telefon</th>
            <th>Tarih</th>
            <th>Kişi Sayısı</th>
            <th>Mesaj</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 52 "C:\Users\fatih\source\repos\Restaurantly\Restaurantly.MVC\Areas\Admin\Views\Dashboard\Index.cshtml"
         foreach (var item in Model.Reservations)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 55 "C:\Users\fatih\source\repos\Restaurantly\Restaurantly.MVC\Areas\Admin\Views\Dashboard\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 56 "C:\Users\fatih\source\repos\Restaurantly\Restaurantly.MVC\Areas\Admin\Views\Dashboard\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 57 "C:\Users\fatih\source\repos\Restaurantly\Restaurantly.MVC\Areas\Admin\Views\Dashboard\Index.cshtml"
               Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 58 "C:\Users\fatih\source\repos\Restaurantly\Restaurantly.MVC\Areas\Admin\Views\Dashboard\Index.cshtml"
               Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 59 "C:\Users\fatih\source\repos\Restaurantly\Restaurantly.MVC\Areas\Admin\Views\Dashboard\Index.cshtml"
               Write(item.Date.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 60 "C:\Users\fatih\source\repos\Restaurantly\Restaurantly.MVC\Areas\Admin\Views\Dashboard\Index.cshtml"
               Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 61 "C:\Users\fatih\source\repos\Restaurantly\Restaurantly.MVC\Areas\Admin\Views\Dashboard\Index.cshtml"
               Write(item.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 64 "C:\Users\fatih\source\repos\Restaurantly\Restaurantly.MVC\Areas\Admin\Views\Dashboard\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<!-- Widgets End -->
<!-- Footer Start -->
<div class=""container-fluid pt-4 px-4"">
    <div class=""bg-light rounded-top p-4"">
        <div class=""row"">
            <div class=""col-12 col-sm-6 text-center text-sm-start"">
                &copy; <a href=""#"">Sarıdağ Restaurant </a>, Tüm hakları saklıdır.
            </div>
            <div class=""col-12 col-sm-6 text-center text-sm-end"">
                <!--/*** This template is free as long as you keep the footer author’s credit link/attribution link/backlink. If you'd like to use the template without the footer author’s credit link/attribution link/backlink, you can purchase the Credit Removal License from ""https://htmlcodex.com/credit-removal"". Thank you for your support. ***/-->
                Designed By <a href=""#"">Fatih Sarıdağ</a>
            </div>
        </div>
    </div>
</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
