#pragma checksum "F:\14.大实训\98K小说阅读网\98k1.1\ChineseNet_98K_.NetCore\ChineseNet_98K.Backstage\Views\Grades\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3903d10552af02d840c22dfac6783666b2efebb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grades_Index), @"mvc.1.0.view", @"/Views/Grades/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Grades/Index.cshtml", typeof(AspNetCore.Views_Grades_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3903d10552af02d840c22dfac6783666b2efebb4", @"/Views/Grades/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d92d08f6d3a897c5d2a2bb605891af0ca35e761d", @"/Views/_ViewImports.cshtml")]
    public class Views_Grades_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\14.大实训\98K小说阅读网\98k1.1\ChineseNet_98K_.NetCore\ChineseNet_98K.Backstage\Views\Grades\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(58, 691, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0aac9bac4c2f4837b7be8eceafa65923", async() => {
                BeginContext(64, 678, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Index</title>
    <meta name=""renderer"" content=""webkit"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, maximum-scale=1"">
    <meta name=""apple-mobile-web-app-status-bar-style"" content=""black"">
    <meta name=""apple-mobile-web-app-capable"" content=""yes"">
    <meta name=""format-detection"" content=""telephone=no"">
    <link rel=""stylesheet"" href=""/css/x-admin.css"" media=""all"">
    <script src=""/js/jquery.min.js""></script>
    <style>
        .ua {
            display: none;
        }
    </style>
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
            BeginContext(749, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(751, 8444, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77d9f5ed5d634c06bd74d77f8b7699ea", async() => {
                BeginContext(757, 8431, true);
                WriteLiteral(@"
    <div class=""x-nav"">
        <span class=""layui-breadcrumb"">
            <a><cite>首页</cite></a>
            <a><cite>用户管理</cite></a>
            <a><cite>等级管理</cite></a>
        </span>
        <a class=""layui-btn layui-btn-small"" style=""line-height:1.6em;margin-top:3px;float:right"" href=""javascript:location.replace(location.href);"" title=""刷新""><i class=""layui-icon"" style=""line-height:30px"">ဂ</i></a>
    </div>
    <div class=""layui-form-pane x-center"" style=""margin-top: 15px; width:800px;"">
        <div class=""layui-form-item"">

            <label class=""layui-form-label"">日期范围</label>
            <div class=""layui-input-inline"">
                <input class=""layui-input"" placeholder=""开始日"" id=""LAY_demorange_s"">
            </div>
            <div class=""layui-input-inline"">
                <input class=""layui-input"" placeholder=""截止日"" id=""LAY_demorange_e"">
            </div>
            <div class=""layui-input-inline"" style=""width:80px"">
                <button id=""sel"" class=""layui-btn""");
                WriteLiteral(@" lay-submit="""" lay-filter=""sreach""><i class=""layui-icon"">&#xe615;</i></button>
            </div>
        </div>
    </div>
    <xblock>
        <button class=""layui-btn layui-btn-danger"" onclick=""delAll()""><i class=""layui-icon"">&#xe640;</i>批量删除</button>
        <button class=""layui-btn"" onclick=""Permissions_add('添加权限','/Grades/Add','500','400')""><i class=""layui-icon"">&#xe608;</i>添加</button><span class=""x-right"" style=""line-height:40px""></span>
    </xblock>
    <div class=""x-body"">
        <table class=""layui-table"">
            <thead>
                <tr>
                    <th><input type=""checkbox"" id=""qx"" name="""" value=""""></th>
                    <th>ID</th>
                    <th>等级名称</th>
                    <th>经验值</th>
                    <th>创建时间</th>
                    <th>操作</th>
                </tr>
            </thead>
            <tbody id=""tbodyList""></tbody>
        </table>
        <div id=""page""></div>
    </div>
    <script src=""/js/jquery.min.js""></script>
 ");
                WriteLiteral(@"   <script src=""/lib/layui/layui.js"" charset=""utf-8""></script>
    <script src=""/js/x-layui.js"" charset=""utf-8""></script>
    <script src=""/js/page.js""></script>
    <script>
        //定义全局变量记录页码信息
        var PageIndex = 1;
        layui.use(['form', 'laydate', 'element', 'laypage', 'layer'], function () {
            var form = layui.form();
            $ = layui.jquery;//jquery
            laydate = layui.laydate;//日期插件
            lement = layui.element();//面包导航
            laypage = layui.laypage;//分页
            layer = layui.layer;//弹出层



            var start = {
                min: '1999-01-01 00:00:00'
                , max: '2099-06-16 23:59:59'
                , istoday: false
                , choose: function (datas) {
                    end.min = datas; //开始日选好后，重置结束日的最小日期
                    end.start = datas //将结束日的初始值设定为开始日
                }
            };

            var end = {
                min: '1999-01-01 00:00:00'
                , max: '2099-06-16 23:");
                WriteLiteral(@"59:59'
                , istoday: false
                , choose: function (datas) {
                    start.max = datas; //结束日选好后，重置开始日的最大日期
                }
            };

            document.getElementById('LAY_demorange_s').onclick = function () {
                start.elem = this;
                laydate(start);
            }

            document.getElementById('LAY_demorange_e').onclick = function () {
                end.elem = this
                laydate(end);
            }

            //以上模块根据需要引入
            show(PageIndex);

            //全选
            $(""#qx"").click(function () {
                $(""[name=ck]"").prop(""checked"", $(this).prop(""checked""));
            })



        });



        $(""#sel"").click(function () {
            show(PageIndex);
        })


        function show(PageIndex) {
            $.ajax({
                url: ""/Grades/Query?startDate="" + $(""#LAY_demorange_s"").val() + ""&endDate="" + $(""#LAY_demorange_e"").val() + ""&pageIndex=");
                WriteLiteral(@""" + PageIndex + ""&pageSize=5"",
                type: ""post"",
                dataType: ""json"",
                success: function (data) {
                    console.log(data);
                    $(""#tbodyList"").empty();
                    for (var i = 0; i < data.Data.length; i++) {
                        var tr = '<tr>'
                            + '<td><input type=""checkbox"" value=""' + data.Data[i].GradeId + '"" name=""ck""></td>'
                            + '<td>' + data.Data[i].GradeId + '</td>'
                            + '<td>' + data.Data[i].GradeName + '</td>'
                            + '<td>' + data.Data[i].Experience + '</td>'
                            + '<td>' + data.Data[i].CreateDate + '</td>'
                            + '<td class=""td-manage""><a title=""编辑"" href=""javascript:;"" onclick=""Permissions_edit(\'编辑\',\'/Grades/Update\',' + data.Data[i].GradeId + ',\'500\',\'400\')"" class=""ml-5"" style=""text-decoration:none""><i id=""uaa' + i + '""  class=""layui-icon"">&#xe642;</i></a");
                WriteLiteral(@"><a title=""删除"" 0href=""javascript:;"" onclick=""Permissions_del(this,\'' + data.Data[i].GradeId + '\')"" style=""text-decoration:none""><i class=""layui-icon"">&#xe640;</i></a></td></tr>'

                        $(""#tbodyList"").append(tr);
                    }
                    var page = Math.ceil(data.PageCount / 5);  //总页数
                    var curr = PageIndex;    //当前页

                    laypage({
                        cont: 'page',   //分页需要显示的地方
                        pages: page,    //总页数
                        curr: curr,     //当前页
                        groups: 3,      //连续显示分页数
                        skip: true,     //是否开启跳页
                        first: '首页',
                        last: '尾页',
                        skin: 'molv',   //加载内置皮肤，也可以直接赋值16进制颜色值，如:#c00
                        prev: '<em><</em>',      // 若不显示，设置false即可
                        next: '<em>></em>',      //若不显示，设置false即可
                        jump: function (e, first) { //触发分页后的回调
                ");
                WriteLiteral(@"            if (!first) { //一定要加此判断，否则初始时会无限刷新
                                PageIndex = e.curr;
                                show(PageIndex);
                            }
                        }
                    });
                }
            })
        }

        /*添加*/
        function Permissions_add(title, url, w, h) {
            x_admin_show(title, url, w, h);
        }

        //编辑
        function Permissions_edit(title, url, id, w, h) {
            x_admin_show(title, url + ""?Id="" + id, w, h);
        }

        //批量删除提交
        function delAll() {
            layer.confirm('确认要删除吗？', function (index) {
                //捉到所有被选中的，发异步进行删除
                var ids = [];
                $(""[name=ck]:checked"").each(function () {
                    ids.push($(this).val());
                })
                console.log(ids);
                if (ids.length == 0) {
                    alert(""请选择要操作的数据"");
                    return;
                }
         ");
                WriteLiteral(@"       $.ajax({
                    url: ""Grades/Delete?Ids="" + ids,
                    type: ""post"",
                    success: function (data) {
                        console.log(data);
                        if (data) {
                            layer.msg('删除成功', { icon: 1 });
                            show();
                        }

                    }
                })
            });
        }

        /*删除*/
        function Permissions_del(obj, id) {
            layer.confirm('确认要删除吗？', function (index) {
                //发异步删除数据
                $.ajax({
                    url: ""Grades/Delete?Ids="" + id,
                    type: ""post"",
                    success: function (data) {
                        console.log(data);
                        if (data) {
                            layer.msg('删除成功', { icon: 1 });
                            $(obj).parents(""tr"").remove();
                            layer.msg('已删除!', { icon: 1, time: 1000 });
       ");
                WriteLiteral("                 }\r\n                        else {\r\n                            layer.msg(\'删除失败!\', { icon: 2, time: 1000 });\r\n                        }\r\n                    }\r\n                })\r\n            });\r\n        }\r\n    </script>\r\n");
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
            BeginContext(9195, 15, true);
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
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
