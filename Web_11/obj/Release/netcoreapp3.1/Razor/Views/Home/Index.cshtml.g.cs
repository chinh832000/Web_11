#pragma checksum "C:\Users\A\source\repos\Web_11\Web_11\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af6d226b105d25c8db20b82ea85241fbb445aa7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\A\source\repos\Web_11\Web_11\Views\_ViewImports.cshtml"
using Web_11;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\A\source\repos\Web_11\Web_11\Views\_ViewImports.cshtml"
using Web_11.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af6d226b105d25c8db20b82ea85241fbb445aa7f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c3107938e2543ce625f8860f97dc6c43a713e31", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\A\source\repos\Web_11\Web_11\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>

<div class=""row"">
    <div class="" header-data container-fluid "">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af6d226b105d25c8db20b82ea85241fbb445aa7f4440", async() => {
                WriteLiteral(@"
            <h3>Quản trị tin tức</h3>
            <input class=""form-control ml-auto d-none d-sm-block "" type=""text"" placeholder=""Search""
                   style=""width: 30% !important;border-radius: 8px; display:inline-block;"">
            <button class=""btn btn-success d-none d-sm-block"" type=""submit"">Search</button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <!--Table Data-->\r\n    <div class=\"container-fluid\" style=\"font:menu\">\r\n        <div class=\"row padding\">\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 835, "\"", 843, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"form-group\">\r\n                    <label for=\"sel1\">Thời gian:</label>\r\n                    <select class=\"form-control\" id=\"sel1\" style=\"font-size: x-small;\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af6d226b105d25c8db20b82ea85241fbb445aa7f6709", async() => {
                WriteLiteral("Tuần này");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af6d226b105d25c8db20b82ea85241fbb445aa7f7693", async() => {
                WriteLiteral("Tháng này");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af6d226b105d25c8db20b82ea85241fbb445aa7f8678", async() => {
                WriteLiteral("Quý này");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af6d226b105d25c8db20b82ea85241fbb445aa7f9661", async() => {
                WriteLiteral("Năm này");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af6d226b105d25c8db20b82ea85241fbb445aa7f10644", async() => {
                WriteLiteral("Tất cả");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </select>\r\n                </div>\r\n            </div>\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 1379, "\"", 1387, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"form-group\">\r\n                    <label for=\"sel2\">Trạng thái:</label>\r\n                    <select class=\"form-control\" id=\"sel2\" style=\"font-size: x-small;\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af6d226b105d25c8db20b82ea85241fbb445aa7f12077", async() => {
                WriteLiteral("Đang hiển thị");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af6d226b105d25c8db20b82ea85241fbb445aa7f13067", async() => {
                WriteLiteral("Không hiển thị");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af6d226b105d25c8db20b82ea85241fbb445aa7f14058", async() => {
                WriteLiteral("Tất cả");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </select>\r\n                </div>\r\n            </div>\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 1834, "\"", 1842, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"form-group\">\r\n                    <label for=\"sel3\">Sắp xếp theo:</label>\r\n                    <select class=\"form-control\" id=\"sel3\" style=\"font-size: x-small;\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af6d226b105d25c8db20b82ea85241fbb445aa7f15493", async() => {
                WriteLiteral("Lượt tương tác");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af6d226b105d25c8db20b82ea85241fbb445aa7f16484", async() => {
                WriteLiteral("Lượt tương tác giảm dần");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af6d226b105d25c8db20b82ea85241fbb445aa7f17484", async() => {
                WriteLiteral("Tất cả");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </select>
                </div>
            </div>
            <div class=""ml-auto""></div>
            <div class=""ml-auto"">
                <button type=""button"" class="" btn btn-outline-dark ml-auto "" id=""btn-refresh-new"">
                    <i class=""fas fa-sync""></i> Cập Nhật
                </button>
                <button type=""button"" class="" btn btn-outline-success ml-auto"" id=""btn-refresh-new"">
                    <i class=""far fa-plus-square""></i> Thêm tin mới
                </button>
            </div>
        </div>
    </div>
    <div class=""container col-md-12"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"">
                <thead>
                    <tr>
                        <th>STT</th>
                        <th>ID</th>
                        <th>Tiêu Đề</th>
                        <th>Nội Dung</th>
                        <th>Trạng Thái</th>
                        <th>Lượt tương tác</th>
      ");
            WriteLiteral(@"                  <th>Hành động</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>1</td>
                        <td>000001</td>
                        <td>Tiêu đề tin 1</td>
                        <td>Nội dung của dòng đầu tin 1</td>
                        <td>
                            <div class=""form-check-inline"">
                                <label class=""form-check-label"">
                                    <input type=""checkbox"" class=""form-check-input active""");
            BeginWriteAttribute("value", " value=\"", 3808, "\"", 3816, 0);
            EndWriteAttribute();
            WriteLiteral(@">Hiển thị
                                </label>
                            </div>
                        </td>
                        <td>100</td>
                        <td>
                            <div>
                                <button type=""button"" class=""btn btn-outline-dark ml-auto"">
                                    <i class=""far fa-edit""></i> Sửa
                                </button>
                                <button type=""button"" class=""btn btn-outline-danger ml-auto"">
                                    <i class=""fas fa-trash-alt""></i> Xoá
                                </button>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td>2</td>
                        <td>000002</td>
                        <td>Tiêu đề tin 1</td>
                        <td>Nội dung của dòng đầu tin 1</td>
                        <td>
                            <div class=""form-ch");
            WriteLiteral("eck-inline\">\r\n                                <label class=\"form-check-label\">\r\n                                    <input type=\"checkbox\" class=\"form-check-input active\"");
            BeginWriteAttribute("value", " value=\"", 5011, "\"", 5019, 0);
            EndWriteAttribute();
            WriteLiteral(@">Hiển thị
                                </label>
                            </div>
                        </td>
                        <td>100</td>
                        <td>
                            <div>
                                <button type=""button"" class=""btn btn-outline-dark ml-auto"">
                                    <i class=""far fa-edit""></i> Sửa
                                </button>
                                <button type=""button"" class=""btn btn-outline-danger ml-auto"">
                                    <i class=""fas fa-trash-alt""></i> Xoá
                                </button>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td>1</td>
                        <td>000001</td>
                        <td>Tiêu đề tin 1</td>
                        <td>Nội dung của dòng đầu tin 1</td>
                        <td>
                            <div class=""form-ch");
            WriteLiteral("eck-inline\">\r\n                                <label class=\"form-check-label\">\r\n                                    <input type=\"checkbox\" class=\"form-check-input active\"");
            BeginWriteAttribute("value", " value=\"", 6214, "\"", 6222, 0);
            EndWriteAttribute();
            WriteLiteral(@">Hiển thị
                                </label>
                            </div>
                        </td>
                        <td>100</td>
                        <td>
                            <div>
                                <button type=""button"" class=""btn btn-outline-dark ml-auto"">
                                    <i class=""far fa-edit""></i> Sửa
                                </button>
                                <button type=""button"" class=""btn btn-outline-danger ml-auto"">
                                    <i class=""fas fa-trash-alt""></i> Xoá
                                </button>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td>1</td>
                        <td>000001</td>
                        <td>Tiêu đề tin 1</td>
                        <td>Nội dung của dòng đầu tin 1</td>
                        <td>
                            <div class=""form-ch");
            WriteLiteral("eck-inline\">\r\n                                <label class=\"form-check-label\">\r\n                                    <input type=\"checkbox\" class=\"form-check-input active\"");
            BeginWriteAttribute("value", " value=\"", 7417, "\"", 7425, 0);
            EndWriteAttribute();
            WriteLiteral(@">Hiển thị
                                </label>
                            </div>
                        </td>
                        <td>100</td>
                        <td>
                            <div>
                                <button type=""button"" class=""btn btn-outline-dark ml-auto"">
                                    <i class=""far fa-edit""></i> Sửa
                                </button>
                                <button type=""button"" class=""btn btn-outline-danger ml-auto"">
                                    <i class=""fas fa-trash-alt""></i> Xoá
                                </button>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td>1</td>
                        <td>000001</td>
                        <td>Tiêu đề tin 1</td>
                        <td>Nội dung của dòng đầu tin 1</td>
                        <td>
                            <div class=""form-ch");
            WriteLiteral("eck-inline\">\r\n                                <label class=\"form-check-label\">\r\n                                    <input type=\"checkbox\" class=\"form-check-input active\"");
            BeginWriteAttribute("value", " value=\"", 8620, "\"", 8628, 0);
            EndWriteAttribute();
            WriteLiteral(@">Hiển thị
                                </label>
                            </div>
                        </td>
                        <td>100</td>
                        <td>
                            <div>
                                <button type=""button"" class=""btn btn-outline-dark ml-auto"">
                                    <i class=""far fa-edit""></i> Sửa
                                </button>
                                <button type=""button"" class=""btn btn-outline-danger ml-auto"">
                                    <i class=""fas fa-trash-alt""></i> Xoá
                                </button>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td>1</td>
                        <td>000001</td>
                        <td>Tiêu đề tin 1</td>
                        <td>Nội dung của dòng đầu tin 1</td>
                        <td>
                            <div class=""form-ch");
            WriteLiteral("eck-inline\">\r\n                                <label class=\"form-check-label\">\r\n                                    <input type=\"checkbox\" class=\"form-check-input active\"");
            BeginWriteAttribute("value", " value=\"", 9823, "\"", 9831, 0);
            EndWriteAttribute();
            WriteLiteral(@">Hiển thị
                                </label>
                            </div>
                        </td>
                        <td>100</td>
                        <td>
                            <div>
                                <button type=""button"" class=""btn btn-outline-dark ml-auto"">
                                    <i class=""far fa-edit""></i> Sửa
                                </button>
                                <button type=""button"" class=""btn btn-outline-danger ml-auto"">
                                    <i class=""fas fa-trash-alt""></i> Xoá
                                </button>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td>1</td>
                        <td>000001</td>
                        <td>Tiêu đề tin 1</td>
                        <td>Nội dung của dòng đầu tin 1</td>
                        <td>
                            <div class=""form-ch");
            WriteLiteral("eck-inline\">\r\n                                <label class=\"form-check-label\">\r\n                                    <input type=\"checkbox\" class=\"form-check-input active\"");
            BeginWriteAttribute("value", " value=\"", 11026, "\"", 11034, 0);
            EndWriteAttribute();
            WriteLiteral(@">Hiển thị
                                </label>
                            </div>
                        </td>
                        <td>100</td>
                        <td>
                            <div>
                                <button type=""button"" class=""btn btn-outline-dark ml-auto"">
                                    <i class=""far fa-edit""></i> Sửa
                                </button>
                                <button type=""button"" class=""btn btn-outline-danger ml-auto"">
                                    <i class=""fas fa-trash-alt""></i> Xoá
                                </button>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td>1</td>
                        <td>000001</td>
                        <td>Tiêu đề tin 1</td>
                        <td>Nội dung của dòng đầu tin 1</td>
                        <td>
                            <div class=""form-ch");
            WriteLiteral("eck-inline\">\r\n                                <label class=\"form-check-label\">\r\n                                    <input type=\"checkbox\" class=\"form-check-input active\"");
            BeginWriteAttribute("value", " value=\"", 12229, "\"", 12237, 0);
            EndWriteAttribute();
            WriteLiteral(@">Hiển thị
                                </label>
                            </div>
                        </td>
                        <td>100</td>
                        <td>
                            <div>
                                <button type=""button"" class=""btn btn-outline-dark ml-auto"">
                                    <i class=""far fa-edit""></i> Sửa
                                </button>
                                <button type=""button"" class=""btn btn-outline-danger ml-auto"">
                                    <i class=""fas fa-trash-alt""></i> Xoá
                                </button>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td>1</td>
                        <td>000001</td>
                        <td>Tiêu đề tin 1</td>
                        <td>Nội dung của dòng đầu tin 1</td>
                        <td>
                            <div class=""form-ch");
            WriteLiteral("eck-inline\">\r\n                                <label class=\"form-check-label\">\r\n                                    <input type=\"checkbox\" class=\"form-check-input active\"");
            BeginWriteAttribute("value", " value=\"", 13432, "\"", 13440, 0);
            EndWriteAttribute();
            WriteLiteral(@">Hiển thị
                                </label>
                            </div>
                        </td>
                        <td>100</td>
                        <td>
                            <div>
                                <button type=""button"" class=""btn btn-outline-dark ml-auto"">
                                    <i class=""far fa-edit""></i> Sửa
                                </button>
                                <button type=""button"" class=""btn btn-outline-danger ml-auto"">
                                    <i class=""fas fa-trash-alt""></i> Xoá
                                </button>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td>1</td>
                        <td>000001</td>
                        <td>Tiêu đề tin 1</td>
                        <td>Nội dung của dòng đầu tin 1</td>
                        <td>
                            <div class=""form-ch");
            WriteLiteral("eck-inline\">\r\n                                <label class=\"form-check-label\">\r\n                                    <input type=\"checkbox\" class=\"form-check-input active\"");
            BeginWriteAttribute("value", " value=\"", 14635, "\"", 14643, 0);
            EndWriteAttribute();
            WriteLiteral(@">Hiển thị
                                </label>
                            </div>
                        </td>
                        <td>100</td>
                        <td>
                            <div>
                                <button type=""button"" class=""btn btn-outline-dark ml-auto"">
                                    <i class=""far fa-edit""></i> Sửa
                                </button>
                                <button type=""button"" class=""btn btn-outline-danger ml-auto"">
                                    <i class=""fas fa-trash-alt""></i> Xoá
                                </button>
                            </div>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
        <!--Table navi-->
        <div class=""ml-auto col-11 col-md-8"">
            <ul class=""pagination"">
                <li class=""page-item disabled""><a class=""page-link"" href=""#"">Previous</a></li>
                <li");
            WriteLiteral(@" class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
                <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
                <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                <li class=""page-item""><a class=""page-link"" href=""#"">Next</a></li>
            </ul>
        </div>
    </div>
</div>
<hr>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
