#pragma checksum "D:\Learning Projects\Facebook project\FaceBook_LastVersion(26-4-2020)\MVC Project Facebook Application\Views\User\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b1dffcff62d81541e2e6df7da057cea51a2f4b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Search), @"mvc.1.0.view", @"/Views/User/Search.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b1dffcff62d81541e2e6df7da057cea51a2f4b9", @"/Views/User/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad2817f46db8b5c1b71eedf9d1ccbad97748a514", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVC_Project_Facebook_Application.Models.SearchUserState>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/UserSearch.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 8 "D:\Learning Projects\Facebook project\FaceBook_LastVersion(26-4-2020)\MVC Project Facebook Application\Views\User\Search.cshtml"
   
    Layout = "~/Views/Shared/layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\Learning Projects\Facebook project\FaceBook_LastVersion(26-4-2020)\MVC Project Facebook Application\Views\User\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 22 "D:\Learning Projects\Facebook project\FaceBook_LastVersion(26-4-2020)\MVC Project Facebook Application\Views\User\Search.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=", 471, "", 540, 1);
#nullable restore
#line 26 "D:\Learning Projects\Facebook project\FaceBook_LastVersion(26-4-2020)\MVC Project Facebook Application\Views\User\Search.cshtml"
WriteAttributeValue("", 477, Url.Action("Profile", "User", new { @ProfileID = item.UserID}), 477, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 26 "D:\Learning Projects\Facebook project\FaceBook_LastVersion(26-4-2020)\MVC Project Facebook Application\Views\User\Search.cshtml"
                                                                                       Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 29 "D:\Learning Projects\Facebook project\FaceBook_LastVersion(26-4-2020)\MVC Project Facebook Application\Views\User\Search.cshtml"
                      
                        switch (item.State)
                        {
                            case "isFriend":

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button data-user-id=");
#nullable restore
#line 33 "D:\Learning Projects\Facebook project\FaceBook_LastVersion(26-4-2020)\MVC Project Facebook Application\Views\User\Search.cshtml"
                                                Write(item.UserID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" class=\"btn alert-danger js-RemoveFriend\">UnFriend</button>\r\n");
#nullable restore
#line 34 "D:\Learning Projects\Facebook project\FaceBook_LastVersion(26-4-2020)\MVC Project Facebook Application\Views\User\Search.cshtml"
                                                                                                                                                                  
                                break;
                            case "notFriend":
                                if (item.UserID != ViewBag.UserIDSession)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <button data-user-id=");
#nullable restore
#line 39 "D:\Learning Projects\Facebook project\FaceBook_LastVersion(26-4-2020)\MVC Project Facebook Application\Views\User\Search.cshtml"
                                                    Write(item.UserID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" class=\"btn alert-primary js-AddFriend\">Add Friend</button>\r\n");
#nullable restore
#line 40 "D:\Learning Projects\Facebook project\FaceBook_LastVersion(26-4-2020)\MVC Project Facebook Application\Views\User\Search.cshtml"
                                }
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\Learning Projects\Facebook project\FaceBook_LastVersion(26-4-2020)\MVC Project Facebook Application\Views\User\Search.cshtml"
                                                                                                                                                                      
                                break;
                            case "receivedFriendRequest":
                                if (item.UserID != ViewBag.UserIDSession)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <button data-user-id=");
#nullable restore
#line 46 "D:\Learning Projects\Facebook project\FaceBook_LastVersion(26-4-2020)\MVC Project Facebook Application\Views\User\Search.cshtml"
                                                    Write(item.UserID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" class=\"btn alert-success js-AcceptRequest\">Accept</button>\r\n                                    <hr />\r\n                                    <button data-user-id=");
#nullable restore
#line 48 "D:\Learning Projects\Facebook project\FaceBook_LastVersion(26-4-2020)\MVC Project Facebook Application\Views\User\Search.cshtml"
                                                    Write(item.UserID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" class=\"btn alert-warning js-DeclineRequest\">Decline</button>\r\n");
#nullable restore
#line 50 "D:\Learning Projects\Facebook project\FaceBook_LastVersion(26-4-2020)\MVC Project Facebook Application\Views\User\Search.cshtml"
                                                                                                                                                                       
                                }
                                break;
                            case "sentFriendRequest":
                                if (item.UserID != ViewBag.UserIDSession)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <button data-user-id=");
#nullable restore
#line 56 "D:\Learning Projects\Facebook project\FaceBook_LastVersion(26-4-2020)\MVC Project Facebook Application\Views\User\Search.cshtml"
                                                    Write(item.UserID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" class=\"btn alert-secondary js-DeleteRequest\">Delete Request</button>\r\n");
#nullable restore
#line 57 "D:\Learning Projects\Facebook project\FaceBook_LastVersion(26-4-2020)\MVC Project Facebook Application\Views\User\Search.cshtml"
                                }
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "D:\Learning Projects\Facebook project\FaceBook_LastVersion(26-4-2020)\MVC Project Facebook Application\Views\User\Search.cshtml"
                                                                                                                                                                 
                                break;

                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 65 "D:\Learning Projects\Facebook project\FaceBook_LastVersion(26-4-2020)\MVC Project Facebook Application\Views\User\Search.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b1dffcff62d81541e2e6df7da057cea51a2f4b911988", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b1dffcff62d81541e2e6df7da057cea51a2f4b913028", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVC_Project_Facebook_Application.Models.SearchUserState>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
