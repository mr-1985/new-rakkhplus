#pragma checksum "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Stock\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a19031f208fa6ff433999effd70dc39332f1619c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyShop.Web.Pages.Admin.Stock.Pages_Admin_Stock_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/Stock/Index.cshtml")]
namespace MyShop.Web.Pages.Admin.Stock
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
#line 2 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Stock\Index.cshtml"
using MyShop.Core.Convertors;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a19031f208fa6ff433999effd70dc39332f1619c", @"/Pages/Admin/Stock/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a64d1fd731b72411d1ffff6814740c98bcb244f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Stock_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Stock\Index.cshtml"
  
    ViewData["Title"] = "لیست انبار هاس ";
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
                لیست  انبار ها
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
            <a href=""/Admin/stock/AddStockForAgent"" class=""btn btn-outline btn-success"">افزودن انبار برای نماینده</a>
            <hr />
            <a href=""/Admin/stock/AddStockForOperative"" class=""btn btn-outline btn-success"">افزودن انبار برای پذیرنده</a>

                  <hr />
            <div class=""table-responsive"">
");
#nullable restore
#line 39 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Stock\Index.cshtml"
                  
                    int rowCount = 1;
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                <table id=""datatable-responsive"" class=""table table-striped table-bordered dt-responsive wrap""
                       cellspacing=""0"" width=""100%"">
                    <thead>
                        <tr>
                            <th>
                                <input type=""checkbox"" id=""checkAll"" />
                            </th>

                            <th>ردیف </th>
                            <th>نام انبار </th>
                            <th>نام نمایندگی</th>
                             <th>نوع </th>
                            <th>تاریخ ثبت</th>
                            <th>شناسه انبار</th>

                            <th class=""column-title no-link last"">
                                <span class=""nobr"">عملیات</span>
                            </th>

                        </tr>
                    </thead>

                    <tbody>
");
#nullable restore
#line 67 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Stock\Index.cshtml"
                         foreach (var store in Model.StoreViewModels)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr ");
            WriteLiteral(">\r\n\r\n                                <td>\r\n                                    <input type=\"checkbox\" class=\"checkBox\"");
            BeginWriteAttribute("value", " value=\"", 2420, "\"", 2442, 1);
#nullable restore
#line 72 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Stock\Index.cshtml"
WriteAttributeValue("", 2428, store.StoreId, 2428, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 75 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Stock\Index.cshtml"
                               Write(rowCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\" \">\r\n                                    ");
#nullable restore
#line 78 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Stock\Index.cshtml"
                               Write(store.StoreName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\" \">\r\n                                    ");
#nullable restore
#line 81 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Stock\Index.cshtml"
                               Write(store.Agentname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                 <td class=\" \">\r\n                                    ");
#nullable restore
#line 84 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Stock\Index.cshtml"
                               Write(store.AgentType);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\" \">\r\n                                    ");
#nullable restore
#line 87 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Stock\Index.cshtml"
                               Write(store.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\" \">\r\n                                    ");
#nullable restore
#line 90 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Stock\Index.cshtml"
                               Write(store.ShenaseAnbar);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </td>

                                <td class="" last"">
            
                                     <a href=""#"" target=""_blank"" class=""btn btn-primary btn-xs""><i class=""fa fa-trash""></i>حذف </a>
                                       <a href=""#"" target=""_blank"" class=""btn btn-primary btn-xs""><i class=""fa fa-pencil""></i>ویرایش </a>


                                </td>
                            </tr>
");
#nullable restore
#line 101 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Stock\Index.cshtml"
                            rowCount++;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"


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
            url: ""/Home/DeleteUser"",
            data: { ""userId"": selectedIDs },

            success: function(response) {
                window.location.href = ""/Admin/User"";
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyShop.Web.Pages.Admin.Stock.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyShop.Web.Pages.Admin.Stock.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyShop.Web.Pages.Admin.Stock.IndexModel>)PageContext?.ViewData;
        public MyShop.Web.Pages.Admin.Stock.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591