#pragma checksum "F:\14.大实训\98K小说阅读网\98k1.1\ChineseNet_98K_.NetCore\ChineseNet_98K.Reception\Views\Novel\DemoPageMarginsPDF.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bae7df642052fd30d2314ece404751f1872ab3ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Novel_DemoPageMarginsPDF), @"mvc.1.0.view", @"/Views/Novel/DemoPageMarginsPDF.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Novel/DemoPageMarginsPDF.cshtml", typeof(AspNetCore.Views_Novel_DemoPageMarginsPDF))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bae7df642052fd30d2314ece404751f1872ab3ec", @"/Views/Novel/DemoPageMarginsPDF.cshtml")]
    public class Views_Novel_DemoPageMarginsPDF : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ChineseNet_98K.Entity.ChapterHelper>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\14.大实训\98K小说阅读网\98k1.1\ChineseNet_98K_.NetCore\ChineseNet_98K.Reception\Views\Novel\DemoPageMarginsPDF.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(77, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(106, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3869aed8cdaa41be9d3db6ea3a477821", async() => {
                BeginContext(112, 100, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>DemoPageMarginsPDF</title>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(219, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(221, 250, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba0c210fb28d4ac09eb2b9511886ccec", async() => {
                BeginContext(227, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 14 "F:\14.大实训\98K小说阅读网\98k1.1\ChineseNet_98K_.NetCore\ChineseNet_98K.Reception\Views\Novel\DemoPageMarginsPDF.cshtml"
     for (int i = 0; i < Model.Count; i++)
    {

#line default
#line hidden
                BeginContext(280, 46, true);
                WriteLiteral("        <br />\r\n        <br />\r\n        <h2>第 ");
                EndContext();
                BeginContext(328, 3, false);
#line 18 "F:\14.大实训\98K小说阅读网\98k1.1\ChineseNet_98K_.NetCore\ChineseNet_98K.Reception\Views\Novel\DemoPageMarginsPDF.cshtml"
          Write(i+1);

#line default
#line hidden
                EndContext();
                BeginContext(332, 3, true);
                WriteLiteral(" 章 ");
                EndContext();
                BeginContext(336, 20, false);
#line 18 "F:\14.大实训\98K小说阅读网\98k1.1\ChineseNet_98K_.NetCore\ChineseNet_98K.Reception\Views\Novel\DemoPageMarginsPDF.cshtml"
                  Write(Model[i].ChapterName);

#line default
#line hidden
                EndContext();
                BeginContext(356, 18, true);
                WriteLiteral("</h2>\r\n        <p>");
                EndContext();
                BeginContext(375, 44, false);
#line 19 "F:\14.大实训\98K小说阅读网\98k1.1\ChineseNet_98K_.NetCore\ChineseNet_98K.Reception\Views\Novel\DemoPageMarginsPDF.cshtml"
      Write(Model[i].ChapterContent.Replace("\r","\r\n"));

#line default
#line hidden
                EndContext();
                BeginContext(419, 38, true);
                WriteLiteral("</p>\r\n        <br />\r\n        <br />\r\n");
                EndContext();
#line 22 "F:\14.大实训\98K小说阅读网\98k1.1\ChineseNet_98K_.NetCore\ChineseNet_98K.Reception\Views\Novel\DemoPageMarginsPDF.cshtml"
    }

#line default
#line hidden
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
            EndContext();
            BeginContext(471, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ChineseNet_98K.Entity.ChapterHelper>> Html { get; private set; }
    }
}
#pragma warning restore 1591
