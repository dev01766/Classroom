#pragma checksum "C:\Users\dev01766\source\repos\LiubaSys\LiubaSys\Views\MessageBoard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cb5a0b56ca0142f30117dd28d03691fff8e09f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MessageBoard_Index), @"mvc.1.0.view", @"/Views/MessageBoard/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MessageBoard/Index.cshtml", typeof(AspNetCore.Views_MessageBoard_Index))]
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
#line 1 "C:\Users\dev01766\source\repos\LiubaSys\LiubaSys\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\dev01766\source\repos\LiubaSys\LiubaSys\Views\_ViewImports.cshtml"
using LiubaSys.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\dev01766\source\repos\LiubaSys\LiubaSys\Views\_ViewImports.cshtml"
using LiubaSys.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cb5a0b56ca0142f30117dd28d03691fff8e09f5", @"/Views/MessageBoard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ba029598eb64af96f65490fafe6cd129dc78aa6", @"/Views/_ViewImports.cshtml")]
    public class Views_MessageBoard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MessagePublished>>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\dev01766\source\repos\LiubaSys\LiubaSys\Views\MessageBoard\Index.cshtml"
  
    ViewData["Title"] = "Message Board";

#line default
#line hidden
            BeginContext(87, 67, true);
            WriteLiteral("\r\n<nav class=\"teal lighten-2 center\" style=\"font-size: 200%\">\r\n    ");
            EndContext();
            BeginContext(155, 17, false);
#line 7 "C:\Users\dev01766\source\repos\LiubaSys\LiubaSys\Views\MessageBoard\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(172, 12, true);
            WriteLiteral("\r\n</nav>\r\n\r\n");
            EndContext();
            BeginContext(185, 121, false);
#line 10 "C:\Users\dev01766\source\repos\LiubaSys\LiubaSys\Views\MessageBoard\Index.cshtml"
Write(await Html.PartialAsync("~/Views/MessageBoard/_PublishMessage.cshtml", new LiubaSys.ViewModels.PublishMessageViewModel()));

#line default
#line hidden
            EndContext();
            BeginContext(306, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 12 "C:\Users\dev01766\source\repos\LiubaSys\LiubaSys\Views\MessageBoard\Index.cshtml"
 foreach (var row in Model)
{

#line default
#line hidden
            BeginContext(342, 145, true);
            WriteLiteral("    <div>\r\n        <div class=\"card grey lighten-3\">\r\n            <div class=\"card-content dark-text\">\r\n                <span class=\"card-title\">");
            EndContext();
            BeginContext(488, 17, false);
#line 17 "C:\Users\dev01766\source\repos\LiubaSys\LiubaSys\Views\MessageBoard\Index.cshtml"
                                    Write(row.DatePublished);

#line default
#line hidden
            EndContext();
            BeginContext(505, 28, true);
            WriteLiteral("</span>\r\n                <p>");
            EndContext();
            BeginContext(534, 11, false);
#line 18 "C:\Users\dev01766\source\repos\LiubaSys\LiubaSys\Views\MessageBoard\Index.cshtml"
              Write(row.Content);

#line default
#line hidden
            EndContext();
            BeginContext(545, 12, true);
            WriteLiteral("</p><br />\r\n");
            EndContext();
#line 19 "C:\Users\dev01766\source\repos\LiubaSys\LiubaSys\Views\MessageBoard\Index.cshtml"
                 if (row.File1 != null)
                {

#line default
#line hidden
            BeginContext(617, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(637, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62fb662fe32b485d8e3d45bc10a7188c", async() => {
                BeginContext(676, 9, false);
#line 21 "C:\Users\dev01766\source\repos\LiubaSys\LiubaSys\Views\MessageBoard\Index.cshtml"
                                                     Write(row.File1);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 646, "~/Files/", 646, 8, true);
#line 21 "C:\Users\dev01766\source\repos\LiubaSys\LiubaSys\Views\MessageBoard\Index.cshtml"
AddHtmlAttributeValue("", 654, row.File1, 654, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("download", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(689, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 22 "C:\Users\dev01766\source\repos\LiubaSys\LiubaSys\Views\MessageBoard\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(710, 174, true);
            WriteLiteral("            </div>\r\n            <div class=\"card-action\">\r\n                <a class=\"waves-effect waves-light btn\">Reply</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 29 "C:\Users\dev01766\source\repos\LiubaSys\LiubaSys\Views\MessageBoard\Index.cshtml"
}

#line default
#line hidden
            BeginContext(887, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(908, 742, true);
                WriteLiteral(@"
    <script>
        // Load the buttons bar under the message box onclick()
        // The messagebox comes from the partial view ""_PublishMessage.cshtml""
        $('#message').click(function() {
            $('#actionsBar').slideToggle(""slow"");
        });

        // Load thumbnail of loaded file
        document.getElementById(""files"").onchange = function () {
            var reader = new FileReader();

            reader.onload = function (e) {
                // Get loaded data and render thumbnail
                document.getElementById(""image"").src = e.target.result;
            };

            // Read the image file as a data URL
            reader.readAsDataURL(this.files[0]);
        }
    </script>
");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MessagePublished>> Html { get; private set; }
    }
}
#pragma warning restore 1591
