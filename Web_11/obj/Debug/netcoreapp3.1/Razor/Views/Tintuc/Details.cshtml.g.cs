#pragma checksum "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Tintuc\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f4c871fc3c8bc62a1db731b5965bd40072ddc69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tintuc_Details), @"mvc.1.0.view", @"/Views/Tintuc/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f4c871fc3c8bc62a1db731b5965bd40072ddc69", @"/Views/Tintuc/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db27c94a1db61bb63f2851a7314cd4dd61a63bed", @"/Views/_ViewImports.cshtml")]
    public class Views_Tintuc_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web_11.Models.Data.Tintuc>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ui reply form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Tintuc\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f4c871fc3c8bc62a1db731b5965bd40072ddc694946", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Tin Hot</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"" integrity=""sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""tinhot.css"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/semantic-ui/2.4.1/semantic.min.css"" integrity=""sha512-8bHTC73gkZ7rZ7vpqUQThUDhqcNFyYi2xgDgPDHc+GXVGHXq+xPjynxIopALmOPqzo9JZj0k6OqqewdGO3EsrQ=="" crossorigin=""anonymous"" />

    <link rel=""stylesheet"" href=""https://pro.fontawesome.com/releases/v5.10.0/css/all.css"" integrity=""sha384-AYmEC3Yw5cVb3ZcuHtOA93w35dYTsvhLPVnYs9eStHfGJvOvKxVfELGroGkvsg+p"" crossorigin=""anonymous"" />
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f4c871fc3c8bc62a1db731b5965bd40072ddc696790", async() => {
                WriteLiteral(@"
    <!-- Hashtag -->
    <div class=""container"">
        <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
            <div class=""row"">

                <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-1"">

                </div>

                <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-10"">
                    <article>
                        <p>
                            <p>
");
                WriteLiteral(@"                        </p>
                        </p>

                    </article>
                </div>
                <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-1"">

                </div>

            </div>

        </div>
    </div>

    <!-- Tin Chính -->
    <div class=""container"">
        <div class=""row TinChinh"">
            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-9"">
                <div class=""row"">
                    <section>
                        <div class=""row"">
                            <h1>");
#nullable restore
#line 66 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Tintuc\Details.cshtml"
                           Write(Model.TieuDe);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                            <br>\r\n                            <h4");
                BeginWriteAttribute("class", " class=\"", 2353, "\"", 2361, 0);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 68 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Tintuc\Details.cshtml"
                                    Write(Model.TomTat);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h4>

                        </div>

                        <div class=""row"">
                            <h4>Sai lầm của Kepa trước Liverpool (Bản quyền K+)</h4>
                            <iframe src=""https://www.youtube.com/embed/w5-LuhAknNo"" class=""mb-3"" width=""95%"" height=""400px""></iframe>
                            <p>
                                Trong trận cầu đinh với Liverpool tại vòng 2 Ngoại hạng Anh, Chelsea thiệt quân cuối hiệp 1 và bị đối thủ vươn lên dẫn trước. Trong tình cảnh khó khăn ấy, Kepa lại mắc thêm sai lầm tai hại khi chuyền bóng thẳng vào chân của Sadio Mane, tạo điều kiện cho tiền đạo người Senegal dễ dàng ghi bàn thứ hai cho Liverpool.
                            </p>
                            <img src=""https://cdn.24h.com.vn/upload/3-2020/images/2020-09-21/Trieu-fan-Chelsea-doi-tong-co-Kepa-HLV-Lampard-sap-co-nguoi-thay-the-c2--1--1600651384-982-width660height428.jpg"" class=""img-fluid mt-3 mb-3 img""");
                BeginWriteAttribute("alt", " alt=\"", 3337, "\"", 3343, 0);
                EndWriteAttribute();
                WriteLiteral(@">

                            <p>Chứng kiến tình huống đó, nhiều cổ động viên Chelsea không giữ nổi sự bình tĩnh và muốn tống khứ thủ thành này đi ngay lập tức. “Kepa Arrizabalaga đã để thủng lưới 11 bàn sau 16 cú sút trúng đích gần nhất mà anh ta phải đối mặt”. Một bình luận khác cho biết. “Đúng là một cú sốc, Sane đã nhận món quà. Thật tiếc Mendy không đến sớm hơn”.</p>
                            <p>Thậm chí có những lời chia sẻ còn gay gắt hơn: “Kepa là thủ môn tệ nhất tôi từng thấy ở Premier League”. Một cổ động viên lên tiếng: “Thủ môn đắt giá nhất thế giới thế giới không cản nổi những cú sút xa và còn mắc sai lầm ngay cả một thủ môn 10 tuổi cũng sẽ không mắc phải. Anh ta cần phải ra đi và tôi không cần quan tâm số tiền chuyển nhượng là bao nhiêu.”</p>
                            <p>Sau trận đấu này, HLV Frank Lampard cũng thừa nhận Kepa đã phạm sai lầm tai hại: “Đối với trường hợp của Kepa, cậu ấy rõ ràng đã mắc lỗi lớn. Một sai lầm đã khiến chúng tôi phải trả giá vào thời điểm đó.</p>
          ");
                WriteLiteral(@"                  <p>Tuy nhiên, chúng tôi vẫn phải tiếp tục làm việc, và cá nhân Kepa cũng vậy. Cậu ấy vẫn sẽ nhận được sự ủng hộ của cả đội, đặc biệt là từ tôi. Chẳng ai cố tình mắc lỗi cả. Kepa vẫn ở đây, cậu ấy là thủ môn của chúng tôi và tôi hài lòng với cậu ấy"". Lampard chia sẻ.</p>
                            <p>Nhưng khi được hỏi liệu có sử dụng thủ môn dự bị Willy Caballero ở trận gặp Barnsley tại vòng 3 Cúp Liên Đoàn sắp tới hay không, nhà cầm quân người Anh thẳng thắn trả lời: ""Tôi có thể nói luôn từ bây giờ là Willy Caballero sẽ ra sân và tôi nghĩ cậu ấy sẽ thi đấu trong trận đấu ấy trước cả ngày hôm nay.”</p>
                        </div>
                    </section>
                </div>
                <!-- Comment -->
                <div class=""row mt-3 ml-5 mr-5 comment"">
                    <div class=""ui comments"">
                        <h3 class=""ui dividing header"">Comments</h3>
                        <div class=""comment"">
                            <a class=""avatar"">
 ");
                WriteLiteral(@"                               <img src=""https://semantic-ui.com/images/avatar/small/matt.jpg"">
                            </a>
                            <div class=""content"">
                                <a class=""author"">Matt</a>
                                <div class=""metadata"">
                                    <span class=""date"">Today at 5:42PM</span>
                                </div>
                                <div class=""text"">
                                    How artistic!
                                </div>
                                <div class=""actions"">
                                    <a class=""reply"">Reply</a>
                                </div>
                            </div>
                        </div>
                        <div class=""comment"">
                            <a class=""avatar"">
                                <img src=""https://semantic-ui.com/images/avatar/small/elliot.jpg"">
                            </a>
        ");
                WriteLiteral(@"                    <div class=""content"">
                                <a class=""author"">Elliot Fu</a>
                                <div class=""metadata"">
                                    <span class=""date"">Yesterday at 12:30AM</span>
                                </div>
                                <div class=""text"">
                                    <p>This has been very useful for my research. Thanks as well!</p>
                                </div>
                                <div class=""actions"">
                                    <a class=""reply"">Reply</a>
                                </div>
                            </div>
                            <div class=""comments"">
                                <div class=""comment"">
                                    <a class=""avatar"">
                                        <img src=""https://semantic-ui.com/images/avatar/small/jenny.jpg"">
                                    </a>
                                  ");
                WriteLiteral(@"  <div class=""content"">
                                        <a class=""author"">Jenny Hess</a>
                                        <div class=""metadata"">
                                            <span class=""date"">Just now</span>
                                        </div>
                                        <div class=""text"">
                                            Elliot you are always so right :)
                                        </div>
                                        <div class=""actions"">
                                            <a class=""reply"">Reply</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""comment"">
                            <a class=""avatar"">
                                <img src=""https://semantic-ui.com/images/avatar/small/joe.jpg"">
                   ");
                WriteLiteral(@"         </a>
                            <div class=""content"">
                                <a class=""author"">Joe Henderson</a>
                                <div class=""metadata"">
                                    <span class=""date"">5 days ago</span>
                                </div>
                                <div class=""text"">
                                    Dude, this is awesome. Thanks so much
                                </div>
                                <div class=""actions"">
                                    <a class=""reply"">Reply</a>
                                </div>
                            </div>
                        </div>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f4c871fc3c8bc62a1db731b5965bd40072ddc6916046", async() => {
                    WriteLiteral(@"
                            <div class=""field"">
                                <textarea></textarea>
                            </div>
                            <div class=""ui blue labeled submit icon button"">
                                <i class=""icon edit""></i> Add Reply
                            </div>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>
                </div>



            </div>

            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-3 "">


                <div class=""row QC"">
                    <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12 "">
                        <img src=""https://pvonline.vn/wp-content/uploads/2017/03/quang-cao-facebook-pvonline.jpg"" width=""100%"" height=""400px"" class=""img-responsive img-fluid"" alt=""Image"">
                    </div>

                </div>


            </div>
        </div>
    </div>
    <!-- Tin liên quan -->
    <div class=""container"">
        <div class=""row Tintrongtuan"">

            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-9"">
                <div class=""row mt-3 mb-3"">
                    <h3>Tin trong tuần</h3>
                </div>

                <div class=""row"">
                    <div class=""col-xs-6 col-sm-6 col-md-6 col-lg-6"">

                        <div class=""row"">
                            <d");
                WriteLiteral("iv class=\"card mb-3 \" style=\"max-width: 540px;\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 10679, "\"", 10686, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                    <div class=""row no-gutters mt-3 ml-3"">
                                        <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                                            <h5 class=""card-title"">Barca thanh lý Suarez: Koeman tranh Cavani với Real, trợ chiến Messi.</h5>
                                        </div>
                                        <div class=""row"">
                                            <div class=""col-md-4 mb-1"">
                                                <img src=""https://cdn.24h.com.vn/upload/3-2020/images/2020-09-22/medium/1600740504-377-thumbnail-width640height480.jpg"" height=""100%"" width=""100%"" class=""card-img img-fluid"" alt=""..."">
                                            </div>
                                            <div class=""col-md-8"">
                                                <div class=""card-body"">
                                                    <p class=""card-text"">Cavani có thành ngôi sao th");
                WriteLiteral(@"ế chỗ Suarez để ""chia lửa"" với Messi ở Barcelona?</p>
                                                    <p class=""card-text""><small class=""text-muted"">Last updated time</small></p>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </a>
                            </div>
                            <div class=""card mb-3"" style=""max-width: 540px;"">
                                <a");
                BeginWriteAttribute("href", " href=\"", 12283, "\"", 12290, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                    <div class=""row no-gutters mt-3 ml-3"">
                                        <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                                            <h5 class=""card-title"">Chelsea mua siêu thủ môn Ligue 1, MU cay đắng săn hụt Son Heung Min. </h5>
                                        </div>
                                        <div class=""row"">
                                            <div class=""col-md-4 mb-1"">
                                                <img src=""https://cdn.24h.com.vn/upload/3-2020/images/2020-09-22/medium/clip-ava-1600771095-216-width640height480.jpg"" height=""100%"" width=""100%"" class=""card-img img-fluid"" alt=""..."">
                                            </div>
                                            <div class=""col-md-8"">
                                                <div class=""card-body"">
                                                    <p class=""card-text"">Thất bại trước Liverpool đã ");
                WriteLiteral(@"bộc lộ nhiều điểm yếu nơi hàng phòng ngự Chelsea</p>
                                                    <p class=""card-text""><small class=""text-muted"">Last updated time</small></p>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </a>
                            </div>
                        </div>
                    </div>
                    <div class=""col-xs-6 col-sm-6 col-md-6 col-lg-6"">

                        <div class=""row"">
                            <div class=""card mb-3"" style=""max-width: 540px;"">
                                <a");
                BeginWriteAttribute("href", " href=\"", 14062, "\"", 14069, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                    <div class=""row no-gutters mt-3 ml-3"">
                                        <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                                            <h5 class=""card-title"">Trọng tài trẻ và bạn gái mỹ nhân bị sát hại gây chấn động bóng đá Ý.</h5>
                                        </div>
                                        <div class=""row"">
                                            <div class=""col-md-4 mb-1"">
                                                <img src=""https://cdn.24h.com.vn/upload/3-2020/images/2020-09-22/medium/1600749606-499-thumbnail-width640height480.jpg"" height=""100%"" width=""100%"" class=""card-img img-fluid"" alt=""..."">
                                            </div>
                                            <div class=""col-md-8"">
                                                <div class=""card-body"">
                                                    <p class=""card-text"">Hai án mạng khi trọng tài và");
                WriteLiteral(@" bạn gái xinh đẹp tử vong khiến bóng đá Ý rúng động.</p>
                                                    <p class=""card-text""><small class=""text-muted"">Last updated time</small></p>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </a>
                            </div>
                            <div class=""card mb-3"" style=""max-width: 540px;"">
                                <a");
                BeginWriteAttribute("href", " href=\"", 15669, "\"", 15676, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                    <div class=""row no-gutters mt-3 ml-3"">
                                        <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
                                            <h5 class=""card-title"">Khốn khổ Barca: Messi dễ lỡ Siêu kinh điển đấu Real, Koeman tính sao?</h5>
                                        </div>
                                        <div class=""row"">
                                            <div class=""col-md-4 mb-1"">
                                                <img src=""https://cdn.24h.com.vn/upload/3-2020/images/2020-09-17/medium/1582900958_522512_1582901120_noticia_normal-6440-1600315743-424-width640height480.jpg"" height=""100%"" width=""100%"" class=""card-img img-fluid"" alt=""..."">
                                            </div>
                                            <div class=""col-md-8"">
                                                <div class=""card-body"">
                                                    <p class=");
                WriteLiteral(@"""card-text"">Tưởng Messi ở lại là mọi chuyện đơn giản hơn cho Barca nhưng thực tế lại khác.</p>
                                                    <p class=""card-text""><small class=""text-muted"">Last updated time</small></p>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </a>
                            </div>
                        </div>
                    </div>

                </div>
            </div>

            <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-3 "">


                <div class=""row QC"">
                    <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12 "">
                        <img src=""https://pvonline.vn/wp-content/uploads/2017/03/quang-cao-facebook-pvonline.jpg"" width=""100%"" height=""400px"" class=""img-responsive img-fluid"" alt=""Image"">
                    </div>

            ");
                WriteLiteral(@"    </div>


            </div>
        </div>
    </div>
    <!-- footer -->
    <div class=""jumbotron jumbotron-fluid"">
        <div class=""container"">
            <div class=""row"">

                <div class=""col-xs-6 col-sm-6 col-md-6 col-lg-6"">
                    <h1 class=""display-4"">Tin Tức Thể Thao</h1>
                    <a class=""navbar-brand"" href=""#"">
                        <img src=""https://secureservercdn.net/166.62.108.43/bns.d72.myftpupload.com/wp-content/uploads/2018/12/BongdaEx_2.png"" alt=""Responsive image"" height=""50"" width=""100"">
                    </a>
                    <p>Tòa soạn: 59c Nguyễn Đình Chiểu, Q.3 ,TP.Hồ Chí Minh</p>
                    <p>Cơ sở chủ quản: Hội xuất bản Việt Nam</p>
                    <p>&#64; 2020 Copyright: QuanLiBongDa.com</p>
                </div>

                <div class=""col-xs-6 col-sm-6 col-md-6 col-lg-6 Lien-He"">
                    <p>HotLine: <b>0523364071</b></p>
                    <p>Liên Hệ Quảng Cáo: <b>09795287");
                WriteLiteral(@"20</b></p>
                    <p>Liên Kết Qua Các Ứng Dụng</p>
                    <a class=""navbar-brand"" href=""#"">
                        <img src=""https://upload.wikimedia.org/wikipedia/commons/0/05/Facebook_Logo_%282019%29.png"" alt=""Responsive image"" height=""50"" width=""50"">
                    </a>
                    <a class=""navbar-brand"" href=""#"">
                        <img src=""https://seoiclick.com/content/uploads/googleplus.png"" alt=""Responsive image"" height=""50"" width=""50"">
                    </a>


                </div>


            </div>

        </div>
    </div>
    <script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js"" integrity=""sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"" integrity=""sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN"" crossorigin=""anonymous""></script>
    <script src=""https");
                WriteLiteral("://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js\" integrity=\"sha384-B4gt1jrGC7Jh4AgTPSdUtOBvfO8shuf57BaghqFfPlYxofvL8/KUEfYiJOMMV+rV\" crossorigin=\"anonymous\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n<div>\r\n    <h4>Tintuc</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 392 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Tintuc\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TieuDe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 395 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Tintuc\Details.cshtml"
       Write(Html.DisplayFor(model => model.TieuDe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 398 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Tintuc\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Avatar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 401 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Tintuc\Details.cshtml"
       Write(Html.DisplayFor(model => model.Avatar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 404 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Tintuc\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TomTat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 407 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Tintuc\Details.cshtml"
       Write(Html.DisplayFor(model => model.TomTat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 410 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Tintuc\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LuotTuongTac));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 413 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Tintuc\Details.cshtml"
       Write(Html.DisplayFor(model => model.LuotTuongTac));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 416 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Tintuc\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LuotXem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 419 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Tintuc\Details.cshtml"
       Write(Html.DisplayFor(model => model.LuotXem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 422 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Tintuc\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TrangThaiHienThi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 425 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Tintuc\Details.cshtml"
       Write(Html.DisplayFor(model => model.TrangThaiHienThi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f4c871fc3c8bc62a1db731b5965bd40072ddc6934125", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 430 "C:\Users\A\Desktop\WEB-ST001-Group11\Web_11\Web_11\Views\Tintuc\Details.cshtml"
                           WriteLiteral(Model.IdTinTuc);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f4c871fc3c8bc62a1db731b5965bd40072ddc6936274", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web_11.Models.Data.Tintuc> Html { get; private set; }
    }
}
#pragma warning restore 1591