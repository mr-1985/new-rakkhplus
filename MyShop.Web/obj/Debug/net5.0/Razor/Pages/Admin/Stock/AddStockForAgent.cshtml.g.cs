#pragma checksum "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Stock\AddStockForAgent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e37b48415f9997746921e0f4bbc479dc3fab8a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyShop.Web.Pages.Admin.Stock.Pages_Admin_Stock_AddStockForAgent), @"mvc.1.0.razor-page", @"/Pages/Admin/Stock/AddStockForAgent.cshtml")]
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
#line 3 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Stock\AddStockForAgent.cshtml"
using MyShop.DataLayer.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e37b48415f9997746921e0f4bbc479dc3fab8a9", @"/Pages/Admin/Stock/AddStockForAgent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a64d1fd731b72411d1ffff6814740c98bcb244f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Stock_AddStockForAgent : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-round"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("demo-form2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-parsley-validate", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal form-label-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Stock\AddStockForAgent.cshtml"
  
    ViewData["Title"] = "لیست زیرمجموعه ها";
        Layout = "Shared/_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .dataTables_filter, div.dataTables_wrapper div.dataTables_filter {\r\n        float: right !important;\r\n    }\r\n</style>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e37b48415f9997746921e0f4bbc479dc3fab8a95916", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" id=\"AgentId\" name=\"AgentId\" />\r\n    <input type=\"hidden\" id=\"StoreId\" name=\"StoreId\"");
                BeginWriteAttribute("value", " value=\"", 539, "\"", 567, 1);
#nullable restore
#line 15 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Stock\AddStockForAgent.cshtml"
WriteAttributeValue("", 547, ViewData["StoreId"], 547, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />

    <div class=""form-group"">
        <label class=""control-label col-md-3 col-sm-3 col-xs-12"" for=""first-name"">
            نام تامین کننده
            <span class=""required"">*</span>
        </label>
        <div class=""col-md-6 col-sm-6 col-xs-12"">
            <div class=""input-group"">
                <input type=""text"" class=""form-control"" id=""AgentName"" required disabled=""disabled"">
                <span class=""input-group-btn"">
                    <button type=""button"" class=""btn btn-primary"" onclick=""ShowAgents();"">انتخاب تامین کننده!</button>
                </span>
            </div>
        </div>
    </div>
    <div class=""form-group"">
        <label class=""control-label col-md-3 col-sm-3 col-xs-12"" for=""last-name"">
            شناسه انبار <span class=""required"">*</span>
        </label>
        <div class=""col-md-6 col-sm-6 col-xs-12"">
            <input type=""text"" id=""ShenaseAnbar"" name=""ShenaseAnbar"" required=""required"" class=""form-control col-md-7 col-xs-12"">
        ");
                WriteLiteral(@"</div>
    </div>
     <div class=""form-group"">
        <label class=""control-label col-md-3 col-sm-3 col-xs-12"" for=""last-name"">
            نام انبار <span class=""required"">*</span>
        </label>
        <div class=""col-md-6 col-sm-6 col-xs-12"">
            <input type=""text"" id=""StoreName"" name=""StoreName"" required=""required"" class=""form-control col-md-7 col-xs-12"">
        </div>
    </div>
    
    <div class=""ln_solid""></div>
    <div class=""form-group"">
        <div class=""col-md-6 col-sm-6 col-xs-12 col-md-offset-3"">
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e37b48415f9997746921e0f4bbc479dc3fab8a98387", async() => {
                    WriteLiteral("انصراف");
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
                WriteLiteral("\r\n            <button type=\"submit\" class=\"btn btn-success\">ذخیره</button>\r\n        </div>\r\n    </div>\r\n    <h2 class=\"ui-pnotify-text text-danger\">");
#nullable restore
#line 55 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Stock\AddStockForAgent.cshtml"
                                       Write(ViewData["Result"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<div class=""modal fade docs-cropped"" id=""getAgentsModel"" aria-hidden=""true""
     aria-labelledby=""getCroppedCanvasTitle"" role=""dialog"" tabindex=""-1"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal""
                        aria-hidden=""true"">
                    &times;
                </button>
                <h4 class=""modal-title"" id=""getCroppedCanvasTitle"">لیست تامین کننده ها</h4>
            </div>
            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""col-sm-12"">
                        <div id=""divagents"">
");
#nullable restore
#line 74 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Stock\AddStockForAgent.cshtml"
                              
                                int rowCountagent = 1;

                            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <table id=""agentstable"" class=""table table-striped table-bordered dt-responsive wrap"" cellspacing=""0"" width=""100%"" role=""grid"" aria-describedby=""datatable-responsive_info"" style=""width: 100%;"">
                                <thead>
                                    <tr>
                                        <th>ردیف</th>
                                        <th>نام نمایندگی</th>
                                        <th>شماره تماس </th>
                                        <th>عملیات</th>
                                    </tr>
                                </thead>
                                <tbody>

");
#nullable restore
#line 89 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Stock\AddStockForAgent.cshtml"
                                     foreach (var item in ViewData["Agents"] as IEnumerable<Agent>)
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr role=\"row\" class=\"odd\">\r\n\r\n                                            <td>");
#nullable restore
#line 94 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Stock\AddStockForAgent.cshtml"
                                           Write(rowCountagent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 95 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Stock\AddStockForAgent.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 96 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Stock\AddStockForAgent.cshtml"
                                           Write(item.TelePhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>\r\n                                                <input class=\"btn btn-primary btn-xs\" value=\"انتخاب\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4472, "\"", 4525, 5);
            WriteAttributeValue("", 4482, "SelectAgent(", 4482, 12, true);
#nullable restore
#line 98 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Stock\AddStockForAgent.cshtml"
WriteAttributeValue(" ", 4494, item.AgentId, 4495, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4508, ",", 4508, 1, true);
#nullable restore
#line 98 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Stock\AddStockForAgent.cshtml"
WriteAttributeValue("", 4509, item.TelePhone, 4509, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4524, ")", 4524, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 101 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Stock\AddStockForAgent.cshtml"
                                        rowCountagent++;
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">
                    بستن
                </button>

            </div>
        </div>
    </div>
</div><!-- /.modal -->

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"



    <script>
        $(document).ready(function () {
            $(""#agentstable"").DataTable();
        });
        function SelectAgent(agentId, agentname) {

            $(""#AgentId"").val(agentId);
            $(""#AgentName"").val(agentname);
            $('#getAgentsModel').modal('toggle');
            $('#getAgentsModel').modal('hide');

        }
        function ShowAgents() {

            $(""#getAgentsModel"").modal('show');


        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyShop.Web.Pages.Admin.Stock.AddStockForAgentModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyShop.Web.Pages.Admin.Stock.AddStockForAgentModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyShop.Web.Pages.Admin.Stock.AddStockForAgentModel>)PageContext?.ViewData;
        public MyShop.Web.Pages.Admin.Stock.AddStockForAgentModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
