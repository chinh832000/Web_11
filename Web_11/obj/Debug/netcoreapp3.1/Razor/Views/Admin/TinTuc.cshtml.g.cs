#pragma checksum "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Admin\TinTuc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1638de11df0cc593b2d3be7fbb93ebd4a5358119"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_TinTuc), @"mvc.1.0.view", @"/Views/Admin/TinTuc.cshtml")]
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
#line 1 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\_ViewImports.cshtml"
using Web_11;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\_ViewImports.cshtml"
using Web_11.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1638de11df0cc593b2d3be7fbb93ebd4a5358119", @"/Views/Admin/TinTuc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c3107938e2543ce625f8860f97dc6c43a713e31", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_TinTuc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TinTucModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Admin\TinTuc.cshtml"
  
    ViewData["Title"] = "Home Page";
    var index = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\" header-data container-fluid \">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1638de11df0cc593b2d3be7fbb93ebd4a53581195804", async() => {
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
            WriteLiteral("\r\n        </div>\r\n        <!--Table Data-->\r\n        <div class=\"container-fluid\" style=\"font:menu\">\r\n            <div class=\"row padding\">\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 736, "\"", 744, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"form-group\">\r\n                        <label for=\"sel1\">Thời gian:</label>\r\n                        <select class=\"form-control\" id=\"sel1\" style=\"font-size: x-small;\">\r\n");
#nullable restore
#line 23 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Admin\TinTuc.cshtml"
                             foreach (var p in Model.ListLoc)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1638de11df0cc593b2d3be7fbb93ebd4a53581198416", async() => {
#nullable restore
#line 25 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Admin\TinTuc.cshtml"
                                                    Write(p.display);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Admin\TinTuc.cshtml"
                                   WriteLiteral(p.value);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Admin\TinTuc.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 1259, "\"", 1267, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"form-group\">\r\n                        <label for=\"sel2\">Trạng thái:</label>\r\n                        <select class=\"form-control\" id=\"sel2\" style=\"font-size: x-small;\">\r\n");
#nullable restore
#line 34 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Admin\TinTuc.cshtml"
                             foreach (var p in Model.ListTrangThai)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1638de11df0cc593b2d3be7fbb93ebd4a535811911240", async() => {
#nullable restore
#line 36 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Admin\TinTuc.cshtml"
                                                    Write(p.display);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Admin\TinTuc.cshtml"
                                   WriteLiteral(p.value);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Admin\TinTuc.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 1789, "\"", 1797, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"form-group\">\r\n                        <label for=\"sel3\">Sắp xếp theo:</label>\r\n                        <select class=\"form-control\" id=\"sel3\" style=\"font-size: x-small;\">\r\n");
#nullable restore
#line 45 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Admin\TinTuc.cshtml"
                             foreach (var p in Model.ListSapXep)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1638de11df0cc593b2d3be7fbb93ebd4a535811914064", async() => {
#nullable restore
#line 47 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Admin\TinTuc.cshtml"
                                                    Write(p.display);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Admin\TinTuc.cshtml"
                                   WriteLiteral(p.value);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 48 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Admin\TinTuc.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
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
          ");
            WriteLiteral("                  <th>Trạng Thái</th>\r\n                            <th>Lượt tương tác</th>\r\n                            <th>Hành động</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 78 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Admin\TinTuc.cshtml"
                         foreach (var item in Model.Tintucs)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 81 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Admin\TinTuc.cshtml"
                               Write(index);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 81 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Admin\TinTuc.cshtml"
                                             index = index + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 82 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Admin\TinTuc.cshtml"
                               Write(item.IdTinTuc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 83 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Admin\TinTuc.cshtml"
                               Write(item.TieuDe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 84 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Admin\TinTuc.cshtml"
                               Write(item.TomTat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n");
#nullable restore
#line 86 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Admin\TinTuc.cshtml"
                                      if (item.TrangThaiHienThi == "Hiển Thị")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<input type=\"checkbox\" id=\"idHienThi\" name=\"CB-HienThi\" value=\"HienThi\" checked>\r\n                                            <label for=\"idHienThi\">Hiển thị</label>");
#nullable restore
#line 88 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Admin\TinTuc.cshtml"
                                                                                   }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <input type=\"checkbox\" id=\"idHienThi\" name=\"CB-HienThi\" value=\"HienThi\">\r\n                                            <label for=\"idHienThi\">Hiển thị</label> ");
#nullable restore
#line 91 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Admin\TinTuc.cshtml"
                                                                                    }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td>");
#nullable restore
#line 94 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Admin\TinTuc.cshtml"
                               Write(item.LuotTuongTac);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <div>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1638de11df0cc593b2d3be7fbb93ebd4a535811920959", async() => {
                WriteLiteral("\r\n                                            <i class=\"far fa-edit\"></i> Sửa\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 97 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Admin\TinTuc.cshtml"
                                                               WriteLiteral(item.IdTinTuc);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1638de11df0cc593b2d3be7fbb93ebd4a535811923378", async() => {
                WriteLiteral("\r\n                                            <i class=\"fas fa-trash-alt\"></i> Xoá\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 100 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Admin\TinTuc.cshtml"
                                                                 WriteLiteral(item.IdTinTuc);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 106 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Admin\TinTuc.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>

                </table>
            </div>
            <!--Table navi-->
            <div class=""ml-auto col-11 col-md-8"">
                <ul class=""pagination"">
                    <li class=""page-item disabled""><a class=""page-link"" href=""#"">Previous</a></li>
                    <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TinTucModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
