﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using GitCandy;
    using GitCandy.Base;
    using GitCandy.Configuration;
    using GitCandy.Extensions;
    using GitCandy.Models;
    using GitCandy.Web;
    using GitCandy.Web.App_GlobalResources;
    using NewLife;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Serialization;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Setting/Edit.cshtml")]
    public partial class _Views_Setting_Edit_cshtml : System.Web.Mvc.WebViewPage<GitCandy.Models.SettingModel>
    {
        public _Views_Setting_Edit_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Setting\Edit.cshtml"
  
    ViewBag.Title = String.Format(SR.Shared_TitleFormat, SR.Setting_EditTitle);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h4>");

            
            #line 7 "..\..\Views\Setting\Edit.cshtml"
Write(SR.Setting_EditTitle);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n\r\n\r\n");

            
            #line 10 "..\..\Views\Setting\Edit.cshtml"
 using (Html.BeginForm("Edit", "Setting", FormMethod.Post))
{

            
            #line default
            #line hidden
WriteLiteral("    <dl");

WriteLiteral(" class=\"dl-horizontal col-md-8\"");

WriteLiteral(">\r\n        <dt>");

            
            #line 13 "..\..\Views\Setting\Edit.cshtml"
       Write(Html.DisplayNameFor(s => s.IsPublicServer));

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n        <dd>\r\n            <div");

WriteLiteral(" class=\"switch\"");

WriteLiteral(" data-on-label=\"");

            
            #line 15 "..\..\Views\Setting\Edit.cshtml"
                                          Write(SR.Shared_Yes);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-off-label=\"");

            
            #line 15 "..\..\Views\Setting\Edit.cshtml"
                                                                          Write(SR.Shared_No);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 16 "..\..\Views\Setting\Edit.cshtml"
           Write(Html.CheckBoxFor(s => s.IsPublicServer, new { data_size = "small" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </dd>\r\n\r\n        <dt>");

            
            #line 20 "..\..\Views\Setting\Edit.cshtml"
       Write(Html.DisplayNameFor(s => s.ForceSsl));

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n        <dd>\r\n            <div");

WriteLiteral(" class=\"switch\"");

WriteLiteral(" data-on-label=\"");

            
            #line 22 "..\..\Views\Setting\Edit.cshtml"
                                          Write(SR.Shared_Yes);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-off-label=\"");

            
            #line 22 "..\..\Views\Setting\Edit.cshtml"
                                                                          Write(SR.Shared_No);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 23 "..\..\Views\Setting\Edit.cshtml"
           Write(Html.CheckBoxFor(s => s.ForceSsl, new { data_size = "small" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </dd>\r\n\r\n        <dt>");

            
            #line 27 "..\..\Views\Setting\Edit.cshtml"
       Write(Html.DisplayNameFor(s => s.SslPort));

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n        <dd>");

            
            #line 28 "..\..\Views\Setting\Edit.cshtml"
       Write(Html.TextBoxFor(s => s.SslPort, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n\r\n        <dt>");

            
            #line 30 "..\..\Views\Setting\Edit.cshtml"
       Write(Html.DisplayNameFor(s => s.LocalSkipCustomError));

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n        <dd>\r\n            <div");

WriteLiteral(" class=\"switch\"");

WriteLiteral(" data-on-label=\"");

            
            #line 32 "..\..\Views\Setting\Edit.cshtml"
                                          Write(SR.Shared_Yes);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-off-label=\"");

            
            #line 32 "..\..\Views\Setting\Edit.cshtml"
                                                                          Write(SR.Shared_No);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 33 "..\..\Views\Setting\Edit.cshtml"
           Write(Html.CheckBoxFor(s => s.LocalSkipCustomError, new { data_size = "small" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </dd>\r\n\r\n        <dt>");

            
            #line 37 "..\..\Views\Setting\Edit.cshtml"
       Write(Html.DisplayNameFor(s => s.AllowRegisterUser));

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n        <dd>\r\n            <div");

WriteLiteral(" class=\"switch\"");

WriteLiteral(" data-on-label=\"");

            
            #line 39 "..\..\Views\Setting\Edit.cshtml"
                                          Write(SR.Shared_Yes);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-off-label=\"");

            
            #line 39 "..\..\Views\Setting\Edit.cshtml"
                                                                          Write(SR.Shared_No);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 40 "..\..\Views\Setting\Edit.cshtml"
           Write(Html.CheckBoxFor(s => s.AllowRegisterUser, new { data_size = "small" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </dd>\r\n\r\n        <dt>");

            
            #line 44 "..\..\Views\Setting\Edit.cshtml"
       Write(Html.DisplayNameFor(s => s.AllowRepositoryCreation));

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n        <dd>\r\n            <div");

WriteLiteral(" class=\"switch\"");

WriteLiteral(" data-on-label=\"");

            
            #line 46 "..\..\Views\Setting\Edit.cshtml"
                                          Write(SR.Shared_Yes);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-off-label=\"");

            
            #line 46 "..\..\Views\Setting\Edit.cshtml"
                                                                          Write(SR.Shared_No);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 47 "..\..\Views\Setting\Edit.cshtml"
           Write(Html.CheckBoxFor(s => s.AllowRepositoryCreation, new { data_size = "small" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </dd>\r\n\r\n        <dt>");

            
            #line 51 "..\..\Views\Setting\Edit.cshtml"
       Write(Html.DisplayNameFor(s => s.RepositoryPath));

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n        <dd>");

            
            #line 52 "..\..\Views\Setting\Edit.cshtml"
       Write(Html.TextBoxFor(s => s.RepositoryPath, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n\r\n        <dt>");

            
            #line 54 "..\..\Views\Setting\Edit.cshtml"
       Write(Html.DisplayNameFor(s => s.CachePath));

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n        <dd>");

            
            #line 55 "..\..\Views\Setting\Edit.cshtml"
       Write(Html.TextBoxFor(s => s.CachePath, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n\r\n        <dt>");

            
            #line 57 "..\..\Views\Setting\Edit.cshtml"
       Write(Html.DisplayNameFor(s => s.GitCorePath));

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n        <dd>");

            
            #line 58 "..\..\Views\Setting\Edit.cshtml"
       Write(Html.TextBoxFor(s => s.GitCorePath, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n\r\n        <dt>");

            
            #line 60 "..\..\Views\Setting\Edit.cshtml"
       Write(Html.DisplayNameFor(s => s.NumberOfCommitsPerPage));

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n        <dd>");

            
            #line 61 "..\..\Views\Setting\Edit.cshtml"
       Write(Html.TextBoxFor(s => s.NumberOfCommitsPerPage, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n\r\n        <dt>");

            
            #line 63 "..\..\Views\Setting\Edit.cshtml"
       Write(Html.DisplayNameFor(s => s.NumberOfItemsPerList));

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n        <dd>");

            
            #line 64 "..\..\Views\Setting\Edit.cshtml"
       Write(Html.TextBoxFor(s => s.NumberOfItemsPerList, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n\r\n        <dt>");

            
            #line 66 "..\..\Views\Setting\Edit.cshtml"
       Write(Html.DisplayNameFor(s => s.NumberOfRepositoryContributors));

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n        <dd>");

            
            #line 67 "..\..\Views\Setting\Edit.cshtml"
       Write(Html.TextBoxFor(s => s.NumberOfRepositoryContributors, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n\r\n");

            
            #line 69 "..\..\Views\Setting\Edit.cshtml"
        
            
            #line default
            #line hidden
            
            #line 69 "..\..\Views\Setting\Edit.cshtml"
         if (!ViewData.ModelState.IsValid)
        {

            
            #line default
            #line hidden
WriteLiteral("        <dt></dt>\r\n");

WriteLiteral("        <dd>");

            
            #line 72 "..\..\Views\Setting\Edit.cshtml"
       Write(Html.ValidationSummary(true, SR.Setting_UpdateSettingsUnsuccessfull, new { @class = "alert alert-dismissable alert-danger" }));

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n");

            
            #line 73 "..\..\Views\Setting\Edit.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n        <dt></dt>\r\n        <dd>\r\n            <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">");

            
            #line 77 "..\..\Views\Setting\Edit.cshtml"
                                                     Write(SR.Shared_Save);

            
            #line default
            #line hidden
WriteLiteral("</button> &nbsp;\r\n            <button");

WriteLiteral(" type=\"reset\"");

WriteLiteral(" class=\"btn btn-inverse\"");

WriteLiteral(">");

            
            #line 78 "..\..\Views\Setting\Edit.cshtml"
                                                    Write(SR.Shared_Reset);

            
            #line default
            #line hidden
WriteLiteral("</button> &nbsp;\r\n");

WriteLiteral("            ");

            
            #line 79 "..\..\Views\Setting\Edit.cshtml"
       Write(Html.ActionLink(SR.Shared_Restart, "Restart", null, new { @class = "btn btn-danger" }));

            
            #line default
            #line hidden
WriteLiteral(" &nbsp;\r\n        </dd>\r\n    </dl>\r\n");

            
            #line 82 "..\..\Views\Setting\Edit.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
