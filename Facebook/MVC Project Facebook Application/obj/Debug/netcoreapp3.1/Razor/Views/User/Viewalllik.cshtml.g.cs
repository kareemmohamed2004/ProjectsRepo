#pragma checksum "D:\Learning Projects\Facebook project\FaceBook_LastVersion(26-4-2020)\MVC Project Facebook Application\Views\User\Viewalllik.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1eef5933bebbf9572c77fb5184bf4075b06b896b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Viewalllik), @"mvc.1.0.view", @"/Views/User/Viewalllik.cshtml")]
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
#line 1 "D:\Learning Projects\Facebook project\FaceBook_LastVersion(26-4-2020)\MVC Project Facebook Application\Views\_ViewImports.cshtml"
using MVC_Project_Facebook_Application;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Learning Projects\Facebook project\FaceBook_LastVersion(26-4-2020)\MVC Project Facebook Application\Views\_ViewImports.cshtml"
using MVC_Project_Facebook_Application.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1eef5933bebbf9572c77fb5184bf4075b06b896b", @"/Views/User/Viewalllik.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad2817f46db8b5c1b71eedf9d1ccbad97748a514", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Viewalllik : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVC_Project_Facebook_Application.Core.Domain.Like>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Learning Projects\Facebook project\FaceBook_LastVersion(26-4-2020)\MVC Project Facebook Application\Views\User\Viewalllik.cshtml"
  
    ViewData["Title"] = "Viewalllik";

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n<table class=\"table\">\r\n    <thead>\r\n\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 12 "D:\Learning Projects\Facebook project\FaceBook_LastVersion(26-4-2020)\MVC Project Facebook Application\Views\User\Viewalllik.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <h4><a");
            BeginWriteAttribute("href", " href=\"", 302, "\"", 347, 2);
            WriteAttributeValue("", 309, "/User/Profile/?ProfileID=", 309, 25, true);
#nullable restore
#line 16 "D:\Learning Projects\Facebook project\FaceBook_LastVersion(26-4-2020)\MVC Project Facebook Application\Views\User\Viewalllik.cshtml"
WriteAttributeValue("", 334, item.User.Id, 334, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "D:\Learning Projects\Facebook project\FaceBook_LastVersion(26-4-2020)\MVC Project Facebook Application\Views\User\Viewalllik.cshtml"
                                                                    Write(item.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 16 "D:\Learning Projects\Facebook project\FaceBook_LastVersion(26-4-2020)\MVC Project Facebook Application\Views\User\Viewalllik.cshtml"
                                                                                         Write(item.User.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 19 "D:\Learning Projects\Facebook project\FaceBook_LastVersion(26-4-2020)\MVC Project Facebook Application\Views\User\Viewalllik.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVC_Project_Facebook_Application.Core.Domain.Like>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
