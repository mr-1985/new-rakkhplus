#pragma checksum "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Operative\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b898abe65161e2b8819c1d4d7f0207059984b88a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyShop.Web.Pages.Admin.Operative.Pages_Admin_Operative_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/Operative/Index.cshtml")]
namespace MyShop.Web.Pages.Admin.Operative
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
#line 1 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\_ViewImports.cshtml"
using MyShop.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Operative\Index.cshtml"
using MyShop.Core.Convertors;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b898abe65161e2b8819c1d4d7f0207059984b88a", @"/Pages/Admin/Operative/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a64d1fd731b72411d1ffff6814740c98bcb244f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Operative_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "CreateOperative", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Operative\Index.cshtml"
  
    ViewData["Title"] = "لیست نمایندگی ها ";
    Layout = "Shared/_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .checkBox {
    }
</style>

<div class=""col-md-12 col-sm-12 col-xs-12"">
    <div class=""x_panel"">
        <div class=""x_title"">
            <h2>
                لیست نمایندگی ها
            </h2>
            <ul class=""nav navbar-right panel_toolbox"">
                <li>
                    <a class=""collapse-link""><i class=""fa fa-chevron-up""></i></a>
                </li>
                <li>
                    <a class=""close-link""><i class=""fa fa-close""></i></a>
                </li>
            </ul>
            <div class=""clearfix""></div>
        </div>

        <div class=""x_content"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b898abe65161e2b8819c1d4d7f0207059984b88a4800", async() => {
                WriteLiteral("افزودن نمایندگی جدید");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <button type=\"button\" id=\"delete\" class=\"btn btn-danger\">حذف</button>\r\n\r\n            <div class=\"table-responsive\">\r\n");
#nullable restore
#line 38 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Operative\Index.cshtml"
                  
                    int rowCount = 1;
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <table id=""datatable-responsive"" class=""table table-striped table-bordered dt-responsive wrap""
                       cellspacing=""0"" width=""100%"">
                    <thead>
                        <tr>
                            <th>
                                <input type=""checkbox"" id=""checkAll"" />
                            </th>
                            <th></th>
                            <th class=""column-title"">نام نمایندگی</th>
                            <th class=""column-title"">استان</th>
                            <th class=""column-title"">شهر</th>
                            <th class=""column-title""> کد پستی </th>
                            <th class=""column-title"">تلفن ثابت</th>
                            <th class=""column-title"">ایمیل</th>
                            <th class=""column-title"">آدرس</th>
                            <th class=""column-title"">تاریخ ثبت نام</th>
                            <th class=""column-title no-link last"">
          ");
            WriteLiteral("                      <span class=\"nobr\">عملیات</span>\r\n                            </th>\r\n\r\n                        </tr>\r\n                    </thead>\r\n\r\n                    <tbody>\r\n");
#nullable restore
#line 65 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Operative\Index.cshtml"
                         foreach (var operative in Model.Operatives)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n\r\n                                <td>\r\n                                    <input type=\"checkbox\" class=\"checkBox\"");
            BeginWriteAttribute("value", " value=\"", 2588, "\"", 2618, 1);
#nullable restore
#line 70 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Operative\Index.cshtml"
WriteAttributeValue("", 2596, operative.OperativeId, 2596, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 73 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Operative\Index.cshtml"
                               Write(rowCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\" \">\r\n                                    ");
#nullable restore
#line 76 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Operative\Index.cshtml"
                               Write(operative.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\" \">\r\n                                    ");
#nullable restore
#line 79 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Operative\Index.cshtml"
                               Write(operative.Ostan);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\" \">\r\n                                    ");
#nullable restore
#line 82 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Operative\Index.cshtml"
                               Write(operative.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\" \">\r\n                                    ");
#nullable restore
#line 85 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Operative\Index.cshtml"
                               Write(operative.PostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\" \">\r\n                                    ");
#nullable restore
#line 88 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Operative\Index.cshtml"
                               Write(operative.TelePhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\" \">\r\n                                    ");
#nullable restore
#line 91 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Operative\Index.cshtml"
                               Write(operative.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\" \">\r\n                                    ");
#nullable restore
#line 94 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Operative\Index.cshtml"
                               Write(operative.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 97 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Operative\Index.cshtml"
                               Write(operative.CreateDtae.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\" last\">\r\n                                   \r\n\r\n                                   <a");
            BeginWriteAttribute("href", "  href=\"", 4058, "\"", 4128, 2);
            WriteAttributeValue("", 4066, "/Admin/Operative/ShowOperativeDocuments/", 4066, 40, true);
#nullable restore
#line 102 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Operative\Index.cshtml"
WriteAttributeValue("", 4106, operative.OperativeId, 4106, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  target=\"_blank\" class=\"btn btn-primary btn-xs\"><i class=\"fa fa-file\"></i>مدارک </a>\r\n                                     <a");
            BeginWriteAttribute("href", "   href=\"", 4255, "\"", 4317, 2);
            WriteAttributeValue("", 4264, "/Admin/Operative/EditOperative/", 4264, 31, true);
#nullable restore
#line 103 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Operative\Index.cshtml"
WriteAttributeValue("", 4295, operative.OperativeId, 4295, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("target=\"_blank\" class=\"btn btn-primary btn-xs\"><i class=\"fa fa-pencil\"></i>ویرایش </a>\r\n                                </td>\r\n                           </tr>\r\n");
#nullable restore
#line 106 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Operative\Index.cshtml"
                            rowCount++;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                       \r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<script>

    $(document).ready(function() {
        $(""#myTable"").DataTable();
    });
</script>

<script>
    $(""#checkAll"").click(function() {
        $("".checkBox"").prop('checked',
            $(this).prop('checked'));
    });

    $(""#delete"").click(function() {
        var selectedIDs = new Array();

        $('input:checkbox.checkBox').each(function() {
            if ($(this).prop('checked')) {
                selectedIDs.push($(this).val());
            }
        });

        $.ajax({
            type: ""POST"",
            url: ""/Home/DeleteOperative"",
            data: { ""operativeId"": selectedIDs },

            success: function(response) {
                window.location.href = ""/Admin/Operative"";
            },
            failure: function(response) {
                alert(response.responseText);
            },
            error: function(response) {
                alert(response.responseText);
            }

        });

    });

</script>

");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyShop.Web.Pages.Admin.Operative.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyShop.Web.Pages.Admin.Operative.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyShop.Web.Pages.Admin.Operative.IndexModel>)PageContext?.ViewData;
        public MyShop.Web.Pages.Admin.Operative.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591