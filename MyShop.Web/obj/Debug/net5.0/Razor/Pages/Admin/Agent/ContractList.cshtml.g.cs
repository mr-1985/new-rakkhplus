#pragma checksum "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Agent\ContractList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ade3cdbd2f160d07fc0f45225ef4ad3cc59b0745"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyShop.Web.Pages.Admin.Agent.Pages_Admin_Agent_ContractList), @"mvc.1.0.razor-page", @"/Pages/Admin/Agent/ContractList.cshtml")]
namespace MyShop.Web.Pages.Admin.Agent
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
#line 2 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Agent\ContractList.cshtml"
using MyShop.Core.Convertors;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ade3cdbd2f160d07fc0f45225ef4ad3cc59b0745", @"/Pages/Admin/Agent/ContractList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a64d1fd731b72411d1ffff6814740c98bcb244f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Agent_ContractList : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "CreateContract", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Agent\ContractList.cshtml"
  
    ViewData["Title"] = " لیست قراردادهای پذیرنده";
    Layout = "Shared/_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-md-12 col-sm-12 col-xs-12"">
    <div class=""x_panel"">
        <div class=""x_title"">
            <h2>
                لیست  قراردادهای پذیرنده
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ade3cdbd2f160d07fc0f45225ef4ad3cc59b07454778", async() => {
                WriteLiteral("افزودن قرارداد جدید");
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n        <div class=\"table-responsive\">\r\n");
#nullable restore
#line 32 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Agent\ContractList.cshtml"
              
                int rowCount = 1;
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table id=""datatable-responsive"" class=""table table-striped table-bordered dt-responsive wrap""
                   cellspacing=""0"" width=""100%"">
                <thead>
                    <tr>
                        <th>
                            <input type=""checkbox"" id=""checkAll"" />
                        </th>
                        <th></th>
                        <th class=""column-title"">شماره قرارداد </th>
                        <th class=""column-title"">تاریخ شروع</th>
                        <th class=""column-title"">تاریخ پایان</th>

                        <th class=""column-title"">تاریخ ثبت </th>
                        <th class=""column-title no-link last"">
                            <span class=""nobr"">عملیات</span>
                        </th>

                    </tr>
                </thead>

                <tbody>
");
#nullable restore
#line 56 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Agent\ContractList.cshtml"
                     foreach (var contract in Model.Contract)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr ");
            WriteLiteral(">\r\n\r\n                            <td>\r\n                                <input type=\"checkbox\" class=\"checkBox\"");
            BeginWriteAttribute("value", " value=\"", 2222, "\"", 2250, 1);
#nullable restore
#line 61 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Agent\ContractList.cshtml"
WriteAttributeValue("", 2230, contract.ContractId, 2230, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 64 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Agent\ContractList.cshtml"
                           Write(rowCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\" \">\r\n                                ");
#nullable restore
#line 67 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Agent\ContractList.cshtml"
                           Write(contract.ContractNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\" \">\r\n                                ");
#nullable restore
#line 70 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Agent\ContractList.cshtml"
                           Write(contract.StartDate.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\" \">\r\n                                ");
#nullable restore
#line 73 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Agent\ContractList.cshtml"
                           Write(contract.EndDate.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 77 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Agent\ContractList.cshtml"
                           Write(contract.CreateDate.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\" last\">\r\n");
            WriteLiteral("                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 84 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Agent\ContractList.cshtml"
                        rowCount++;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
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
            url: ""/Home/DeleteAgent"",
            data: { ""agentId"": selectedIDs },

            success: function(response) {
                window.location.href = ""/Admin/Agent"";
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyShop.Web.Pages.Admin.Agent.ContractListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyShop.Web.Pages.Admin.Agent.ContractListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyShop.Web.Pages.Admin.Agent.ContractListModel>)PageContext?.ViewData;
        public MyShop.Web.Pages.Admin.Agent.ContractListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591