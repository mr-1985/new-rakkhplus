#pragma checksum "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Operative\AddOperativeDocument.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b2b53340803ae8c396d56c69a5fbd075c86f91f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyShop.Web.Pages.Admin.Operative.Pages_Admin_Operative_AddOperativeDocument), @"mvc.1.0.razor-page", @"/Pages/Admin/Operative/AddOperativeDocument.cshtml")]
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
#line 4 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Operative\AddOperativeDocument.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b2b53340803ae8c396d56c69a5fbd075c86f91f", @"/Pages/Admin/Operative/AddOperativeDocument.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a64d1fd731b72411d1ffff6814740c98bcb244f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Operative_AddOperativeDocument : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Operative\AddOperativeDocument.cshtml"
  
    Layout = "Shared/_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12"">
        <h1 class=""page-header"">بارگذاری مدارک نمایندگی </h1>
    </div>
    <!-- /.col-lg-12 -->
</div>


<style>
    .img-thumbnail {
        max-height: 108px !important;
        min-height: 108px;
    }

    .view-first img {
        transition: all .2s linear;
        width: 100%;
    }

    .col-md-55 {
        float: right !important;
    }

    .thumbnail {
        height: 231px !important;
        display: block;
        padding: 0px;
        margin-bottom: 23px;
        line-height: 1.42857143;
        background-color: #fff;
        border: 1px solid #ddd;
        border-radius: 4px;
        -webkit-transition: border .2s ease-in-out;
        -o-transition: border .2s ease-in-out;
        transition: border .2s ease-in-out;
    }
</style>

<div class=""col-md-12 col-sm-12 col-xs-12"">
    <div class=""x_panel"">
        <div class=""x_title"">
            <h2>
                بارگزاری مدارک
            </h2>
     ");
            WriteLiteral("       <div class=\"clearfix\">\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"x_content\">\r\n\r\n            <div class=\"col-md-55\">\r\n                <div class=\"thumbnail\">\r\n                    <div class=\"image view view-first\">\r\n");
#nullable restore
#line 63 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Operative\AddOperativeDocument.cshtml"
                         if (Model.OperativeDocument == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img id=\"imgSarDarbForoushgahImage\" src=\"/OperativeDocuments/media.jpg\" class=\"img-thumbnail imgdefaultupload\" />\r\n");
#nullable restore
#line 66 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Operative\AddOperativeDocument.cshtml"
                        }
                        else
                        {
                            string extention = System.IO.Path.GetExtension(Model.OperativeDocument.SarDarbForoushgahImage);
                            if (extention == "gif" || extention == "jpg" || extention == "png" || extention == "jpeg" || extention == "bpm")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img id=\"imgBaseSarDarbForoushgahImage\"");
            BeginWriteAttribute("src", " src=\"", 2097, "\"", 2170, 2);
            WriteAttributeValue("", 2103, "/OperativeDocuments/", 2103, 20, true);
#nullable restore
#line 72 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Operative\AddOperativeDocument.cshtml"
WriteAttributeValue("", 2123, Model.OperativeDocument.SarDarbForoushgahImage, 2123, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail imgdefaultupload\" />\r\n");
#nullable restore
#line 73 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Operative\AddOperativeDocument.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a class=\"btn btn-app\"");
            BeginWriteAttribute("href", " href=\"", 2365, "\"", 2439, 2);
            WriteAttributeValue("", 2372, "/OperativeDocuments/", 2372, 20, true);
#nullable restore
#line 76 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Operative\AddOperativeDocument.cshtml"
WriteAttributeValue("", 2392, Model.OperativeDocument.SarDarbForoushgahImage, 2392, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" style=\"background-color: #0000ff63; color: #fff;\">\r\n                                    <i class=\"fa fa-download\"></i> دانلود\r\n                                </a>\r\n");
#nullable restore
#line 79 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Operative\AddOperativeDocument.cshtml"
                            }


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"mask\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2737, "\"", 2811, 2);
            WriteAttributeValue("", 2744, "/OperativeDocuments/", 2744, 20, true);
#nullable restore
#line 82 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Operative\AddOperativeDocument.cshtml"
WriteAttributeValue("", 2764, Model.OperativeDocument.SarDarbForoushgahImage, 2764, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" target=""_blank"">
                                    <p>تصویر سر درب فروشگاه </p>
                                    <div class=""tools tools-bottom"">
                                        <i class=""fa fa-link""></i>
                                        <i class=""fa fa-pencil""></i>

                                    </div>
                                </a>
                            </div>
");
#nullable restore
#line 91 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Operative\AddOperativeDocument.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                    </div>
                    <div class=""caption"">
                        <p>تصویر مجوز کسب</p>
                        <input id=""SarDarbForoushgahImage"" name=""files"" type=""file"" size=""1"" accept=""image/png, image/gif, image/jpeg,image/jpg,image/bmp"" />
                        <input type=""button"" value=""آپلود تصویر "" onclick=""uploadFiles('SarDarbForoushgahImage', 'SpanSarDarbForoushgahImageUpload','fileProgressSarDarbForoushgahImage');"" class=""btn btn-success"" />
                        <span class=""text text-success"" id=""SpanSarDarbForoushgahImageUpload""></span>
                        <progress id=""fileProgressSarDarbForoushgahImage"" style=""display: none""></progress>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<hr />
<input type=""button"" value=""بازگشت"" onclick=""location='/Admin/Operative/Index'"" class=""btn btn-success"" />


<script>


          function uploadFiles(inputId, spanId,fileprocess) {
              ");
            WriteLiteral(@"//debugger;
                var input = document.getElementById(inputId);
                var spanMessage = document.getElementById(spanId);
                var fileprocessId = document.getElementById(fileprocess);

                $(spanMessage).html('');
                var files = input.files;
                var formData = new FormData();

                //console.log(files);

                for (var i = 0; i != files.length; i++) {
                    formData.append(""files"", files[i]);
                }

                $.ajax(
                    {
                        url: ""/Home/UploadOperativeDocument?term="" + inputId + ""&operativeId="" +");
#nullable restore
#line 141 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\Operative\AddOperativeDocument.cshtml"
                                                                                           Write(ViewData["OperativeId"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"+"""",
                        data: formData,
                        processData: false,
                        contentType: false,
                        type: ""POST"",
                        success: function (data) {

                             $(fileprocessId).hide();
                            if (data == ""success"") {
                                $(spanMessage).html('فایل با موفقیت بارگزاری شد');
                            }
                            if (data == ""maxfile"") {
                                $(spanMessage).html('حداکثر حجم فایل بایستی 30 مگ باشد');
                            }
                            if (data == ""failed"") {
                                $(spanMessage).html('لطفا فایل مورد نظر را انتخاب کنید');
                            }
                        },
                                                                    xhr: function() {
                                                                        var fileXhr = $.ajaxSettings.xhr");
            WriteLiteral(@"();
                                                                        if (fileXhr.upload) {
                                                                            $(fileprocessId).show();
                                                                            fileXhr.upload.addEventListener(""progress"", function(e) {
                                                                                if (e.lengthComputable) {
                                                                                    $(fileprocessId).attr({
                                                                                        value: e.loaded,
                                                                                        max: e.total
                                                                                    });
                                                                                }
                                                                            }, false);
   ");
            WriteLiteral(@"                                                                     }
                                                                        return fileXhr;
                                                                    },
                                                                    error: function(err) {
                                                                        alert(err.statusText);
                                                                    }
                    }
                );
            }

            function readURL(input) {

                debugger;
                var name = $(input).attr(""id"");
                ImageBase = ""#imgBase"" + name;
                if (input.files && input.files[0]) {
                    var reader = new FileReader();

                    reader.onload = function (e) {

                        $(ImageBase).attr('src', e.target.result);
                    }

                    reader.readAsDataURL(input.files");
            WriteLiteral(@"[0]);
                }

            }

    function getFileExtension(filename)
    {
      var ext = /^.+\.([^.]+)$/.exec(filename);
      return ext == null ? """" : ext[1];
    }


              $(""#SarDarbForoushgahImage"").change(function () {
                readURL(this);
            });



</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyShop.Web.Pages.Admin.Operative.AddOperativeDocumentModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyShop.Web.Pages.Admin.Operative.AddOperativeDocumentModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyShop.Web.Pages.Admin.Operative.AddOperativeDocumentModel>)PageContext?.ViewData;
        public MyShop.Web.Pages.Admin.Operative.AddOperativeDocumentModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591