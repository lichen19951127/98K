#pragma checksum "F:\14.大实训\98K小说阅读网\98k1.1\ChineseNet_98K_.NetCore\ChineseNet_98K.Backstage\Views\Admin_Users\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f2fd2364d135c53cf858c6f005813f8a35d7f97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Users_Update), @"mvc.1.0.view", @"/Views/Admin_Users/Update.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin_Users/Update.cshtml", typeof(AspNetCore.Views_Admin_Users_Update))]
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
#line 1 "F:\14.大实训\98K小说阅读网\98k1.1\ChineseNet_98K_.NetCore\ChineseNet_98K.Backstage\Views\_ViewImports.cshtml"
using ChineseNet_98K.Backstage;

#line default
#line hidden
#line 2 "F:\14.大实训\98K小说阅读网\98k1.1\ChineseNet_98K_.NetCore\ChineseNet_98K.Backstage\Views\_ViewImports.cshtml"
using ChineseNet_98K.Backstage.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f2fd2364d135c53cf858c6f005813f8a35d7f97", @"/Views/Admin_Users/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d92d08f6d3a897c5d2a2bb605891af0ca35e761d", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Users_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form layui-form-pane"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\14.大实训\98K小说阅读网\98k1.1\ChineseNet_98K_.NetCore\ChineseNet_98K.Backstage\Views\Admin_Users\Update.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(58, 617, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c52fc62b1d54dad8d5c51d58d2e709e", async() => {
                BeginContext(64, 604, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Users_Update</title>
    <meta name=""renderer"" content=""webkit"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, maximum-scale=1"">
    <meta name=""apple-mobile-web-app-status-bar-style"" content=""black"">
    <meta name=""apple-mobile-web-app-capable"" content=""yes"">
    <meta name=""format-detection"" content=""telephone=no"">
    <link rel=""stylesheet"" href=""/css/x-admin.css"" media=""all"">
    <script src=""/js/jquery.min.js""></script>
");
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
            BeginContext(675, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(677, 6788, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e09f7f27232b4e3da0351815d907c394", async() => {
                BeginContext(683, 36, true);
                WriteLiteral("\r\n    <div class=\"x-body\">\r\n        ");
                EndContext();
                BeginContext(719, 3133, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fae81ef1b5894cc98847bb9691df6ec0", async() => {
                    BeginContext(795, 3050, true);
                    WriteLiteral(@"
            <input type=""hidden"" name=""CreateDate"" />

            <div class=""layui-form-item"">
                <label for=""name"" class=""layui-form-label"">
                    <span class=""x-red"">*</span>用户名
                </label>
                <div class=""layui-input-inline"">
                    <input type=""hidden"" name=""CreateDate"" />
                    <input type=""text"" id=""UserName"" name=""UserName"" required="""" lay-verify=""required""
                           autocomplete=""off"" class=""layui-input"">
                </div>
            </div>
            <div class=""layui-form-item"">
                <label for=""name"" class=""layui-form-label"">
                    <span class=""x-red"">*</span>用户密码
                </label>
                <div class=""layui-input-inline"">
                    <input type=""text"" id=""UserPwd"" name=""UserPwd"" required="""" lay-verify=""required""
                           autocomplete=""off"" class=""layui-input"">
                </div>
            </div>
     ");
                    WriteLiteral(@"       <div class=""layui-form-item"">
                <label for=""name"" class=""layui-form-label"">
                    <span class=""x-red"">*</span>确认密码
                </label>
                <div class=""layui-input-inline"">
                    <input type=""text"" id=""UserPwd0"" name=""UserPwd0"" required="""" lay-verify=""repass""
                           autocomplete=""off"" class=""layui-input"">
                </div>
            </div>


            <div class=""layui-form-item layui-form-text"">
                <label class=""layui-form-label"">
                    选择角色
                </label>
                <table class=""layui-table layui-input-block"">
                    <tbody>
                        <tr>
                            <td>
                                <div class=""layui-input-block"" id=""divTab"">

                                </div>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>");
                    WriteLiteral(@"
            <div class=""layui-form-item"">
                <label for=""name"" class=""layui-form-label"">
                    <span class=""x-red"">*</span>状态
                </label>
                <div class=""layui-input-inline"" id=""state"">
                    <input type=""radio"" name=""State"" value=""1"" required="""" lay-verify=""repass""
                           autocomplete=""off"" class=""layui-input"" title=""启用"" checked=""checked"" />
                    <input type=""radio"" name=""State"" value=""0"" required="""" lay-verify=""repass""
                           autocomplete=""off"" class=""layui-input"" title=""禁用"" />
                </div>
            </div>
            <div class=""layui-form-item"">
                <div class=""layui-input-block"">
                    <input type=""button"" class=""layui-btn"" lay-submit="""" lay-filter=""update"" value=""修改"" />
                    <button type=""reset"" class=""layui-btn layui-btn-primary"">重置</button>
                </div>
            </div>
        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3852, 3606, true);
                WriteLiteral(@"
    </div>
    <script src=""/lib/layui/layui.js"" charset=""utf-8"">
    </script>
    <script src=""/js/x-layui.js"" charset=""utf-8"">
    </script>
    <script>
        $(function () {
            //角色
            $.ajax({
                url: ""/Admin_Users/GetRoles"",
                type: ""post"",
                async: false,
                dataType: ""json"",
                success: function (data) {
                    for (var i = 0; i < data.length; i++) {
                        var tr = '<input name=""id[]"" type=""checkbox"" value=""' + data[i].RoleId + '"" pname=""' + data[i].RoleName + '"" />' + data[i].RoleName
                        $(""#divTab"").append(tr);
                    }
                }
            })

             //返填
            $.ajax({
                url: ""/Admin_Users/QueryById?Id=""+location.search.substring(4),
                type: ""post"",
                async: false,
                dataType: ""json"",
                success: function (data) {
               ");
                WriteLiteral(@"     $(""[name=UserName]"").val(data.Admin_UserName);
                    $(""[name=UserPwd]"").val(data.Admin_UserPwd);
                    $(""[name=UserPwd0]"").val(data.Admin_UserPwd);
                    $(""[name=CreateDate]"").val(data.CreateDate);
                    var arr = data.RoleIds.split(',');
                    for (var i = 0; i < arr.length; i++) {
                        $(""#divTab"").children(""[value="" + arr[i] + ""]"").prop(""checked"", ""checked"");
                    }
                    $(""#state"").children(""[value="" + data.State + ""]"").prop(""checked"",""checked"");

                }
            })
        })

        layui.use(['form', 'layer'], function () {
            $ = layui.jquery;
            var form = layui.form()
                , layer = layui.layer;


            //自定义验证规则
            form.verify({
                repass: function (value) {
                    if ($(""[name=UserPwd]"").val() != $(""[name=UserPwd0]"").val()) {
                        return '两次密码不一致'");
                WriteLiteral(@";
                    }
                }
            });

            //监听提交
            form.on('submit(update)', function () {
                var ids = [];
                var names = [];
                $(""[type=checkbox]:checked"").each(function () {
                    ids.push($(this).val());
                    names.push($(this).attr(""pname""));
                })

                $.ajax({
                    url: ""/Admin_Users/Update?Id=""+location.search.substring(4)+""&UserName="" + $(""[name=UserName]"").val() + ""&UserPwd="" + $(""[name=UserPwd]"").val() + ""&RoleIds="" + ids + ""&RoleNames="" + names + ""&State=""+$(""[name=State]:checked"").val(),
                    type: ""post"",
                    success: function (data) {
                        if (data) {
                            layer.alert(""更新成功"", { icon: 6 }, function () {
                                // 获得frame索引
                                var index = parent.layer.getFrameIndex(window.name);
                          ");
                WriteLiteral(@"      //关闭当前frame
                                parent.layer.close(index);
                                window.parent.location.reload();
                            });
                        }
                        else {
                            layer.msg('更新失败!', { icon: 2, time: 1000 });
                        }
                    },
                    error: function (e) {
                        console.log(e);
                    }
                })
            });
        });
    </script>
");
                EndContext();
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
            BeginContext(7465, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
