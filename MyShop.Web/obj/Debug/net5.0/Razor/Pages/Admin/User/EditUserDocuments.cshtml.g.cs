#pragma checksum "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69cc66356b85f32474c233c29a5d07ce9f5bd600"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyShop.Web.Pages.Admin.User.Pages_Admin_User_EditUserDocuments), @"mvc.1.0.razor-page", @"/Pages/Admin/User/EditUserDocuments.cshtml")]
namespace MyShop.Web.Pages.Admin.User
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69cc66356b85f32474c233c29a5d07ce9f5bd600", @"/Pages/Admin/User/EditUserDocuments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a64d1fd731b72411d1ffff6814740c98bcb244f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_User_EditUserDocuments : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml"
  
    Layout = "Shared/_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12"">
        <h1 class=""page-header"">ویرایش مدارک کاربر </h1>
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
                ویرایش مدارک
            </h2>
            ");
            WriteLiteral("<div class=\"clearfix\">\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n        <div class=\"x_content\">\r\n\r\n            <div class=\"col-md-55\">\r\n                <div class=\"thumbnail\">\r\n                    <div class=\"image view view-first\">\r\n");
#nullable restore
#line 63 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml"
                         if (Model.Document == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img id=\"imgBaseFrontNationalImage\" src=\"/UserDocument/avatar.jpg\" class=\"img-thumbnail imgdefaultupload\" />\r\n");
#nullable restore
#line 66 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml"
                        }
                        else
                        {
                            string extention = System.IO.Path.GetExtension(Model.Document.FrontNationalImage);
                            if (extention == "gif" || extention == "jpg" || extention == "png" || extention == "jpeg" || extention == "bpm")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <img id=\"imgBaseFrontNationalImage\"");
            BeginWriteAttribute("src", " src=\"", 2046, "\"", 2100, 2);
            WriteAttributeValue("", 2052, "/UserDocument/", 2052, 14, true);
#nullable restore
#line 72 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml"
WriteAttributeValue("", 2066, Model.Document.FrontNationalImage, 2066, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail imgdefaultupload\" />\r\n");
#nullable restore
#line 73 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"btn btn-app\"");
            BeginWriteAttribute("href", " href=\"", 2303, "\"", 2358, 2);
            WriteAttributeValue("", 2310, "/UserDocument/", 2310, 14, true);
#nullable restore
#line 76 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml"
WriteAttributeValue("", 2324, Model.Document.FrontNationalImage, 2324, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" style=\"background-color: #0000ff63; color: #fff;\">\r\n                                            <i class=\"fa fa-download\"></i> دانلود\r\n                                        </a>\r\n");
#nullable restore
#line 79 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml"
                            }

                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml"
                                        
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                    </div>
                    <div class=""caption"">
                        <p>تصویر روی کارت ملی</p>
                        <input id=""FrontNationalImage"" name=""files"" type=""file"" size=""1"" accept=""image/png, image/gif, image/jpeg,image/jpg,image/bmp"" />
                        <input type=""button"" value=""آپلود تصویر "" onclick=""uploadFiles('FrontNationalImage', 'SpanFrontNationalImageUpload','fileProgressFrontNationalImage');"" class=""btn btn-success"" />
                        <span class=""text text-success"" id=""SpanFrontNationalImageUpload""></span>
                        <progress id=""fileProgressFrontNationalImage"" style=""display: none""></progress>
                    </div>
                </div>
            </div>
            <div class=""col-md-55"">
                <div class=""thumbnail"">
                    <div class=""image view view-first"">
");
#nullable restore
#line 116 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml"
                         if (Model.Document == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img id=\"imgBaseBackNationalImage\" src=\"/UserDocument/avatar.jpg\" class=\"img-thumbnail imgdefaultupload\" />\r\n");
#nullable restore
#line 119 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml"
                        }
                        else
                        {
                            string extention = System.IO.Path.GetExtension(Model.Document.BackNationalImage);
                            if (extention == "gif" || extention == "jpg" || extention == "png" || extention == "jpeg" || extention == "bpm")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <img id=\"imgBaseBackNationalImage\"");
            BeginWriteAttribute("src", " src=\"", 5191, "\"", 5244, 2);
            WriteAttributeValue("", 5197, "/UserDocument/", 5197, 14, true);
#nullable restore
#line 125 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml"
WriteAttributeValue("", 5211, Model.Document.BackNationalImage, 5211, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail imgdefaultupload\" />\r\n");
#nullable restore
#line 126 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"btn btn-app\"");
            BeginWriteAttribute("href", " href=\"", 5447, "\"", 5501, 2);
            WriteAttributeValue("", 5454, "/UserDocument/", 5454, 14, true);
#nullable restore
#line 129 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml"
WriteAttributeValue("", 5468, Model.Document.BackNationalImage, 5468, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" style=\"background-color: #0000ff63; color: #fff;\">\r\n                                            <i class=\"fa fa-download\"></i> دانلود\r\n                                        </a>\r\n");
#nullable restore
#line 132 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml"

                            }

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                    </div>
                    <div class=""caption"">
                        <p>تصویر پشت کارت ملی  </p>
                        <input id=""BackNationalImage"" name=""files"" type=""file"" size=""1"" accept=""image/png, image/gif, image/jpeg,image/jpg,image/bmp"" />
                        <input type=""button"" value=""آپلود تصویر "" onclick=""uploadFiles('BackNationalImage', 'SpanBackNationalImageUpload','fileProgressBackNationalImage');"" class=""btn btn-success"" />
                        <span class=""text text-success"" id=""SpanBackNationalImageUpload""></span>
                        <progress id=""fileProgressBackNationalImage"" style=""display: none""></progress>
                    </div>
                </div>
            </div>
            <div class=""col-md-55"">
                <div class=""thumbnail"">
                    <div class=""image view view-first"">
");
#nullable restore
#line 160 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml"
                         if (Model.Document == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img id=\"imgBaseFrontShenasnamehImage\" src=\"/UserDocument/avatar.jpg\" class=\"img-thumbnail imgdefaultupload\" />\r\n");
#nullable restore
#line 163 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml"
                        }
                        else
                        {
                            string extention = System.IO.Path.GetExtension(Model.Document.FrontShenasnamehImage);
                            if (extention == "gif" || extention == "jpg" || extention == "png" || extention == "jpeg" || extention == "bpm")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <img id=\"imgBaseFrontShenasnamehImage\"");
            BeginWriteAttribute("src", " src=\"", 7815, "\"", 7869, 2);
            WriteAttributeValue("", 7821, "/UserDocument/", 7821, 14, true);
#nullable restore
#line 169 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml"
WriteAttributeValue("", 7835, Model.Document.FrontNationalImage, 7835, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail imgdefaultupload\" />\r\n");
#nullable restore
#line 170 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"btn btn-app\"");
            BeginWriteAttribute("href", " href=\"", 8072, "\"", 8130, 2);
            WriteAttributeValue("", 8079, "/UserDocument/", 8079, 14, true);
#nullable restore
#line 173 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml"
WriteAttributeValue("", 8093, Model.Document.FrontShenasnamehImage, 8093, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" style=\"background-color: #0000ff63; color: #fff;\">\r\n                                            <i class=\"fa fa-download\"></i> دانلود\r\n                                        </a>\r\n");
#nullable restore
#line 176 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml"

                            }

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                    </div>
                    <div class=""caption"">
                        <p>تصویر صفحه اول شناسنامه </p>
                        <input id=""FrontShenasnamehImage"" name=""files"" type=""file"" size=""1"" accept=""image/png, image/gif, image/jpeg,image/jpg,image/bmp"" />
                        <input type=""button"" value=""آپلود تصویر "" onclick=""uploadFiles('FrontShenasnamehImage', 'SpanFrontShenasnamehImageUpload','fileProgressFrontShenasnamehImage');"" class=""btn btn-success"" />
                        <span class=""text text-success"" id=""SpanFrontShenasnamehImageUpload""></span>
                        <progress id=""fileProgressFrontShenasnamehImage"" style=""display: none""></progress>
                    </div>
                </div>
            </div>

            <div class=""col-md-55"">
                <div class=""thumbnail"">
                    <div class=""image view view-first"">
");
#nullable restore
#line 205 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml"
                         if (Model.Document == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img id=\"imgBaseDescriptionShenasnamehImage\" src=\"/UserDocument/avatar.jpg\" class=\"img-thumbnail imgdefaultupload\" />\r\n");
#nullable restore
#line 208 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml"
                        }
                        else
                        {
                            string extention = System.IO.Path.GetExtension(Model.Document.DescriptionShenasnamehImage);
                            if (extention == "gif" || extention == "jpg" || extention == "png" || extention == "jpeg" || extention == "bpm")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <img id=\"imgBaseDescriptionShenasnamehImage\"");
            BeginWriteAttribute("src", " src=\"", 10500, "\"", 10563, 2);
            WriteAttributeValue("", 10506, "/UserDocument/", 10506, 14, true);
#nullable restore
#line 214 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml"
WriteAttributeValue("", 10520, Model.Document.DescriptionShenasnamehImage, 10520, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail imgdefaultupload\" />\r\n");
#nullable restore
#line 215 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"btn btn-app\"");
            BeginWriteAttribute("href", " href=\"", 10766, "\"", 10830, 2);
            WriteAttributeValue("", 10773, "/UserDocument/", 10773, 14, true);
#nullable restore
#line 218 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml"
WriteAttributeValue("", 10787, Model.Document.DescriptionShenasnamehImage, 10787, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" style=\"background-color: #0000ff63; color: #fff;\">\r\n                                            <i class=\"fa fa-download\"></i> دانلود\r\n                                        </a>\r\n");
#nullable restore
#line 221 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml"

                            }

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                    </div>
                    <div class=""caption"">
                        <p>تصویر صفحه توضیحات شناسنامه</p>
                        <input id=""DescriptionShenasnamehImage"" name=""files"" type=""file"" size=""1"" accept=""image/png, image/gif, image/jpeg,image/jpg,image/bmp"" />
                        <input type=""button"" value=""آپلود تصویر "" onclick=""uploadFiles('DescriptionShenasnamehImage', 'SpanDescriptionShenasnamehImageUpload','fileProgressDescriptionShenasnamehImage');"" class=""btn btn-success"" />
                        <span class=""text text-success"" id=""SpanDescriptionShenasnamehImageUpload""></span>
                        <progress id=""fileProgressDescriptionShenasnamehImage"" style=""display: none""></progress>
                    </div>
                </div>
            </div>
            <div class=""col-md-55"">
                <div class=""thumbnail"">
                    <div class=""image view view-first"">
");
#nullable restore
#line 249 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml"
                         if (Model.Document == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img id=\"imgBasePersonalImage\" src=\"/UserDocument/avatar.jpg\" class=\"img-thumbnail imgdefaultupload\" />\r\n");
#nullable restore
#line 252 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml"
                        }
                        else
                        {
                            string extention = System.IO.Path.GetExtension(Model.Document.PersonalImage);
                            if (extention == "gif" || extention == "jpg" || extention == "png" || extention == "jpeg" || extention == "bpm")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <img id=\"imgBasePersonalImage\"");
            BeginWriteAttribute("src", " src=\"", 13200, "\"", 13249, 2);
            WriteAttributeValue("", 13206, "/UserDocument/", 13206, 14, true);
#nullable restore
#line 258 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml"
WriteAttributeValue("", 13220, Model.Document.PersonalImage, 13220, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail imgdefaultupload\" />\r\n");
#nullable restore
#line 259 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"btn btn-app\"");
            BeginWriteAttribute("href", " href=\"", 13452, "\"", 13502, 2);
            WriteAttributeValue("", 13459, "/UserDocument/", 13459, 14, true);
#nullable restore
#line 262 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml"
WriteAttributeValue("", 13473, Model.Document.PersonalImage, 13473, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" style=\"background-color: #0000ff63; color: #fff;\">\r\n                                            <i class=\"fa fa-download\"></i> دانلود\r\n                                        </a>\r\n");
#nullable restore
#line 265 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml"

                            }

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                    </div>
                    <div class=""caption"">
                        <p>تصویر عکس 4*3  </p>
                        <input id=""PersonalImage"" name=""files"" type=""file"" size=""1"" accept=""image/png, image/gif, image/jpeg,image/jpg,image/bmp"" />
                        <input type=""button"" value=""آپلود تصویر "" onclick=""uploadFiles('PersonalImage', 'SpanPersonalImageUpload','fileProgressPersonalImage');"" class=""btn btn-success"" />
                        <span class=""text text-success"" id=""SpanPersonalImageUpload""></span>
                        <progress id=""fileProgressPersonalImage"" style=""display: none""></progress>
                    </div>
                </div>
            </div>

        </div>

    </div>
</div>
<hr />
<input type=""button"" value=""بازگشت"" onclick=""location='/Admin/User/Index'"" class=""btn btn-success"" />
<script>


          function uploadFiles(inputId, spanId,fileprocess) {
              //debugger;
                var input = document.getEleme");
            WriteLiteral(@"ntById(inputId);
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
                        url: ""/Home/UploadUserDocument?term="" + inputId + ""&userId="" +");
#nullable restore
#line 318 "C:\Users\mohsen\source\repos\rakhshplus1\MyShop.Web\Pages\Admin\User\EditUserDocuments.cshtml"
                                                                                 Write(ViewData["UserId"].ToString());

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

        $(""#FrontNationalImage"").change(function () {
                readURL(this);
            });

        $(""#BackNationalImage"").change(function () {
                readURL(this);
            });
        $(""#FrontShenasnamehImage"").change(function () {
                readURL(this);
            });
        $(""#DescriptionShenasnamehImage"").change(function () {
                readURL(this);
            });
        $(""#PersonalImage"").change(function () {
                readURL(this);
            });



</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyShop.Web.Pages.Admin.User.EditUserDocumentsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyShop.Web.Pages.Admin.User.EditUserDocumentsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyShop.Web.Pages.Admin.User.EditUserDocumentsModel>)PageContext?.ViewData;
        public MyShop.Web.Pages.Admin.User.EditUserDocumentsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
