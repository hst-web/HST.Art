﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 6 "..\..\Areas\manage\Views\Student\List.cshtml"
    using HST.Art.Core;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Areas\manage\Views\Student\List.cshtml"
    using HST.Art.Web;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Areas\manage\Views\Student\List.cshtml"
    using HST.Utillity;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/manage/Views/Student/List.cshtml")]
    public partial class _Areas_manage_Views_Student_List_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_manage_Views_Student_List_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<!--[if lt IE 9]>\r\n<script type=\"text/javascript\" src=\"lib/html5shiv.js\"></script" +
">\r\n<script type=\"text/javascript\" src=\"lib/respond.min.js\"></script>\r\n<![endif]-" +
"->\r\n");

            
            #line 8 "..\..\Areas\manage\Views\Student\List.cshtml"
Write(Scripts.Render("~/bundles/saos"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 9 "..\..\Areas\manage\Views\Student\List.cshtml"
Write(Styles.Render("~/appcss"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<!--[if IE 6]>\r\n<script type=\"text/javascript\" src=\"lib/DD_belatedPNG_0.0.8a-mi" +
"n.js\" ></script>\r\n<script>DD_belatedPNG.fix(\'*\');</script>\r\n<![endif]-->\r\n<nav");

WriteLiteral(" class=\"breadcrumb\"");

WriteLiteral("><i");

WriteLiteral(" class=\"Hui-iconfont\"");

WriteLiteral(">&#xe67f;</i> 首页 <span");

WriteLiteral(" class=\"c-gray en\"");

WriteLiteral(">&gt;</span>证书管理 <span");

WriteLiteral(" class=\"c-gray en\"");

WriteLiteral(">&gt;</span> 学员证书 <a");

WriteLiteral(" class=\"btn btn-primary radius r\"");

WriteLiteral(" style=\"line-height:1.6em;margin-top:3px\"");

WriteLiteral(" href=\"javascript:location.replace(location.href);\"");

WriteLiteral(" title=\"刷新\"");

WriteLiteral("><i");

WriteLiteral(" class=\"Hui-iconfont\"");

WriteLiteral(">&#xe68f;</i></a></nav>\r\n<div");

WriteLiteral(" class=\"page-container\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"cl pd-10 bg-1 bk-gray mt-10 search-wrap\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"label-inline\"");

WriteLiteral(">筛选：</span>\r\n        <select");

WriteLiteral(" name=\"sel_orderstate\"");

WriteLiteral(" id=\"sel_filType\"");

WriteLiteral(" class=\"select select-box sm inline\"");

WriteLiteral(">\r\n            <option");

WriteLiteral(" value=\"\"");

WriteLiteral(">请选择筛选条件</option>\r\n            <option");

WriteAttribute("value", Tuple.Create(" value=\"", 1070), Tuple.Create("\"", 1101)
            
            #line 20 "..\..\Areas\manage\Views\Student\List.cshtml"
, Tuple.Create(Tuple.Create("", 1078), Tuple.Create<System.Object, System.Int32>((int)SearchType.Name
            
            #line default
            #line hidden
, 1078), false)
);

WriteLiteral(">学员姓名</option>\r\n            <option");

WriteAttribute("value", Tuple.Create(" value=\"", 1137), Tuple.Create("\"", 1170)
            
            #line 21 "..\..\Areas\manage\Views\Student\List.cshtml"
, Tuple.Create(Tuple.Create("", 1145), Tuple.Create<System.Object, System.Int32>((int)SearchType.Number
            
            #line default
            #line hidden
, 1145), false)
);

WriteLiteral(">证书编号</option>\r\n            <option");

WriteAttribute("value", Tuple.Create(" value=\"", 1206), Tuple.Create("\"", 1237)
            
            #line 22 "..\..\Areas\manage\Views\Student\List.cshtml"
, Tuple.Create(Tuple.Create("", 1214), Tuple.Create<System.Object, System.Int32>((int)SearchType.Area
            
            #line default
            #line hidden
, 1214), false)
);

WriteLiteral(">所在地区</option>\r\n            <option");

WriteAttribute("value", Tuple.Create(" value=\"", 1273), Tuple.Create("\"", 1304)
            
            #line 23 "..\..\Areas\manage\Views\Student\List.cshtml"
, Tuple.Create(Tuple.Create("", 1281), Tuple.Create<System.Object, System.Int32>((int)SearchType.Type
            
            #line default
            #line hidden
, 1281), false)
);

WriteLiteral(">证书类别</option>\r\n        </select>\r\n        <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"sel_filVal\"");

WriteLiteral(" placeholder=\"请输入筛选关键字\"");

WriteLiteral(" class=\"input-text lg inline hidden\"");

WriteLiteral(" />\r\n        <select");

WriteLiteral(" name=\"sel_orderstate\"");

WriteLiteral(" id=\"sel_type\"");

WriteLiteral(" class=\"select select-box sm inline hidden\"");

WriteLiteral(" style=\"width:150px\"");

WriteLiteral(">\r\n            <option");

WriteLiteral(" value=\"\"");

WriteLiteral(">请选择证书类别</option>\r\n            <option");

WriteAttribute("value", Tuple.Create(" value=\"", 1629), Tuple.Create("\"", 1666)
            
            #line 28 "..\..\Areas\manage\Views\Student\List.cshtml"
, Tuple.Create(Tuple.Create("", 1637), Tuple.Create<System.Object, System.Int32>((int)CertificateType.Prize
            
            #line default
            #line hidden
, 1637), false)
);

WriteLiteral(">获奖证书</option>\r\n            <option");

WriteAttribute("value", Tuple.Create(" value=\"", 1702), Tuple.Create("\"", 1739)
            
            #line 29 "..\..\Areas\manage\Views\Student\List.cshtml"
, Tuple.Create(Tuple.Create("", 1710), Tuple.Create<System.Object, System.Int32>((int)CertificateType.Train
            
            #line default
            #line hidden
, 1710), false)
);

WriteLiteral(">学员认证</option>\r\n        </select>\r\n        <select");

WriteLiteral(" name=\"sel_orderstate\"");

WriteLiteral(" id=\"sel_area\"");

WriteLiteral(" class=\"select select-box sm inline hidden\"");

WriteLiteral(" style=\"width:150px\"");

WriteLiteral(">\r\n            <option");

WriteLiteral(" value=\"\"");

WriteLiteral(">请选择所在地区</option>\r\n");

            
            #line 33 "..\..\Areas\manage\Views\Student\List.cshtml"
            
            
            #line default
            #line hidden
            
            #line 33 "..\..\Areas\manage\Views\Student\List.cshtml"
             foreach (KeyValuePair<int, string> item in ViewBag.AreaCity)
            {

            
            #line default
            #line hidden
WriteLiteral("                <option");

WriteAttribute("value", Tuple.Create(" value=\"", 2052), Tuple.Create("\"", 2069)
            
            #line 35 "..\..\Areas\manage\Views\Student\List.cshtml"
, Tuple.Create(Tuple.Create("", 2060), Tuple.Create<System.Object, System.Int32>(item.Key
            
            #line default
            #line hidden
, 2060), false)
);

WriteLiteral(">");

            
            #line 35 "..\..\Areas\manage\Views\Student\List.cshtml"
                                     Write(item.Value);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 36 "..\..\Areas\manage\Views\Student\List.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </select>\r\n        <button");

WriteLiteral(" name=\"search\"");

WriteLiteral(" id=\"search\"");

WriteLiteral(" class=\"btn btn-success ml-20\"");

WriteLiteral(" type=\"button\"");

WriteLiteral("><i");

WriteLiteral(" class=\"Hui-iconfont\"");

WriteLiteral(">&#xe665;</i> 查询</button>\r\n        <button");

WriteLiteral(" class=\"btn btn-primary ml-20\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 2308), Tuple.Create("\"", 2354)
, Tuple.Create(Tuple.Create("", 2318), Tuple.Create("stu_add(\'新建证书\',\'", 2318), true)
            
            #line 39 "..\..\Areas\manage\Views\Student\List.cshtml"
, Tuple.Create(Tuple.Create("", 2334), Tuple.Create<System.Object, System.Int32>(Url.Action("Add")
            
            #line default
            #line hidden
, 2334), false)
, Tuple.Create(Tuple.Create("", 2352), Tuple.Create("\')", 2352), true)
);

WriteLiteral(" type=\"button\"");

WriteLiteral(">新建证书</button>\r\n        <button");

WriteLiteral(" class=\"btn btn-default\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 2424), Tuple.Create("\"", 2476)
, Tuple.Create(Tuple.Create("", 2434), Tuple.Create("stu_import(\'证书导入\',\'", 2434), true)
            
            #line 40 "..\..\Areas\manage\Views\Student\List.cshtml"
, Tuple.Create(Tuple.Create("", 2453), Tuple.Create<System.Object, System.Int32>(Url.Action("Import")
            
            #line default
            #line hidden
, 2453), false)
, Tuple.Create(Tuple.Create("", 2474), Tuple.Create("\')", 2474), true)
);

WriteLiteral(" type=\"button\"");

WriteLiteral(">证书导入</button>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"mt-10\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" id=\"tbTable\"");

WriteLiteral(" class=\"table table-border table-bordered table-bg table-sort\"");

WriteLiteral(">\r\n            <thead>\r\n                <tr");

WriteLiteral(" class=\"text-c\"");

WriteLiteral(">\r\n                    <th");

WriteLiteral(" width=\"8%\"");

WriteLiteral(">序号</th>\r\n                    <th");

WriteLiteral(" width=\"9%\"");

WriteLiteral(">姓名</th>\r\n                    <th");

WriteLiteral(" width=\"8%\"");

WriteLiteral(">性别</th>\r\n                    <th");

WriteLiteral(" width=\"10%\"");

WriteLiteral(">证书编号</th>\r\n                    <th");

WriteLiteral(" width=\"10%\"");

WriteLiteral(">所在地区</th>\r\n                    <th");

WriteLiteral(" width=\"10%\"");

WriteLiteral(">证书类别</th>\r\n                    <th");

WriteLiteral(" width=\"9%\"");

WriteLiteral(">状态</th>\r\n                    <th");

WriteLiteral(" width=\"8%\"");

WriteLiteral(">创建人</th>\r\n                    <th");

WriteLiteral(" width=\"12%\"");

WriteLiteral(">创建时间</th>\r\n                    <th");

WriteLiteral(" width=\"12%\"");

WriteLiteral(">操作</th>\r\n                </tr>\r\n            </thead>\r\n        </table>\r\n    </di" +
"v>\r\n</div>\r\n\r\n");

            
            #line 62 "..\..\Areas\manage\Views\Student\List.cshtml"
Write(Scripts.Render("~/bundles/datatable"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
        var table1 = null;
        $(function () {
            table1 = initializeTable();
            $(""#search"").click(function () {
                table1.ajax.reload();
            });

            //输入名称回车查询
            $(""#sel_filVal"").keypress(function (e) {
                if (e.which == 13) {
                    table1.ajax.reload();
                    $(""#search"").focus();
                }
            });

            $(""#sel_filType"").change(function () {
                if ($(this).val() == """") {
                    $(""#sel_filVal"").addClass(""hidden"");
                    $(""#sel_area"").addClass(""hidden"");
                    $(""#sel_type"").addClass(""hidden"");
                }
               else if ($(this).val() == '");

            
            #line 86 "..\..\Areas\manage\Views\Student\List.cshtml"
                                      Write((int)SearchType.Type);

            
            #line default
            #line hidden
WriteLiteral("\') {\r\n                    $(\"#sel_type\").removeClass(\"hidden\");\r\n                " +
"    $(\"#sel_area\").addClass(\"hidden\");\r\n                    $(\"#sel_filVal\").add" +
"Class(\"hidden\");\r\n                } else if ($(this).val() == \'");

            
            #line 90 "..\..\Areas\manage\Views\Student\List.cshtml"
                                         Write((int)SearchType.Area);

            
            #line default
            #line hidden
WriteLiteral(@"') {
                    $(""#sel_filVal"").addClass(""hidden"");
                    $(""#sel_area"").removeClass(""hidden"");
                    $(""#sel_type"").addClass(""hidden"");
                } else {
                    $(""#sel_filVal"").removeClass(""hidden"");
                    $(""#sel_area"").addClass(""hidden"");
                    $(""#sel_type"").addClass(""hidden"");
                }

                $(""#sel_filVal,#sel_area,#sel_type"").val("""");
            })
        });

        /*编辑*/
        function stu_edit(title, url, id) {
            var index = top.layer.open({
                type: 2,
                title: title,
                area: ['750px', '500px'],
                content: url + ""?id="" + id
            });
        }

        /*添加*/
        function stu_add(title, url) {
            var index = top.layer.open({
                type: 2,
                title: title,
                area: ['750px', '500px'],
                content: url
            });
        }

        function stu_import(title, url) {
            var index = top.layer.open({
                type: 2,
                title: title,
                area: ['750px', '500px'],
                content: url
            });
        }

        
        function getFilterVal() {
            if ($(""#sel_filType"").val() == '");

            
            #line 135 "..\..\Areas\manage\Views\Student\List.cshtml"
                                        Write((int)SearchType.Type);

            
            #line default
            #line hidden
WriteLiteral("\') {\r\n                return $(\"#sel_type\").val();\r\n            } else if ($(\"#se" +
"l_filType\").val() == \'");

            
            #line 137 "..\..\Areas\manage\Views\Student\List.cshtml"
                                               Write((int)SearchType.Area);

            
            #line default
            #line hidden
WriteLiteral(@"') {
                return $(""#sel_area"").val();
            } else {
                return $(""#sel_filVal"").val();
            }

        }

        function initializeTable() {
            var dataTable = $('#tbTable').DataTable({
                ""serverSide"": true,
                ""ajax"": {
                    ""url"": """);

            
            #line 149 "..\..\Areas\manage\Views\Student\List.cshtml"
                       Write(Url.Action("GetJsonData"));

            
            #line default
            #line hidden
WriteLiteral("\",\r\n                    \"type\": \"post\",\r\n                    \"data\": function (da" +
"ta) {\r\n                        data.pageIndex = (data.start / data.length) + 1;\r" +
"\n                        data.filterKey = $(\"#sel_filType\").val();\r\n            " +
"            data.filterVal = getFilterVal();\r\n                    }\r\n           " +
"     },\r\n                \"columns\": [\r\n                      { \"defaultContent\":" +
" \"\" },\r\n                      { \"mDataProp\": \"StudentName\" },\r\n                 " +
"      { \"mDataProp\": \"GenderName\" },\r\n                      { \"mDataProp\": \"Numb" +
"er\" },\r\n                      { \"mDataProp\": \"Area\" },\r\n                      { " +
"\"mDataProp\": \"CategoryName\" },\r\n                      { \"mDataProp\": \"State\" },\r" +
"\n                      { \"mDataProp\": \"UserName\" },\r\n                      { \"mD" +
"ataProp\": \"CreateTime\" },\r\n                      { \"defaultContent\": \"\" }\r\n\r\n   " +
"             ],\r\n                \"columnDefs\": [\r\n                 {\r\n          " +
"           \"targets\": [6],\r\n                     \"data\": \"State\",\r\n             " +
"        \"render\": function (data, type, full) {\r\n                         var re" +
"sult = data;\r\n                         if (data > 0) {\r\n                        " +
"     result = \"<span class=\\\"label label-success radius\\\">已上架</span>\";\r\n        " +
"                 } else {\r\n                             result = \"<span class=\\\"" +
"label label-danger radius\\\">已下架</span>\";\r\n                         }\r\n\r\n        " +
"                 return result;\r\n                     }\r\n                 },\r\n  " +
"              {\r\n                    \"targets\": [-1],\r\n                    \"data" +
"\": \"Id\",\r\n                    \"render\": function (data, type, full) {\r\n         " +
"               var tmpString = \"<a  onClick=\\\"stu_edit(\'修改证书\',\'");

            
            #line 189 "..\..\Areas\manage\Views\Student\List.cshtml"
                                                                   Write(Url.Action("Edit"));

            
            #line default
            #line hidden
WriteLiteral("\',\" + data + \")\\\" href=\\\"javascript:;\\\" title=\\\"编辑\\\">编辑</a>\";\r\n                  " +
"      if (full.State == 0)\r\n                            tmpString += \"<a href=\\\"" +
"javascript:;\\\" onClick=\\\"obj_publish(\'");

            
            #line 191 "..\..\Areas\manage\Views\Student\List.cshtml"
                                                                                     Write(Url.Action("Publish"));

            
            #line default
            #line hidden
WriteLiteral("\',\" + data + \")\\\"  title=\\\"上架\\\">上架</a>\";\r\n                        else\r\n         " +
"                   tmpString += \"<a href=\\\"javascript:;\\\" onClick=\\\"obj_shelves(" +
"\'");

            
            #line 193 "..\..\Areas\manage\Views\Student\List.cshtml"
                                                                                     Write(Url.Action("Shelves"));

            
            #line default
            #line hidden
WriteLiteral("\',\" + data + \")\\\"  title=\\\"下架\\\">下架</a>\";\r\n                        tmpString += \"<" +
"a href=\\\"javascript:;\\\" onClick=\\\"obj_del(\'证书\',\'");

            
            #line 194 "..\..\Areas\manage\Views\Student\List.cshtml"
                                                                                  Write(Url.Action("Delete"));

            
            #line default
            #line hidden
WriteLiteral("\',\" + data + \")\\\"  title=\\\"删除\\\">删除</a>\";\r\n\r\n                        return tmpStr" +
"ing;\r\n                    }\r\n                }\r\n                ],\r\n            " +
"    \"fnDrawCallback\": function () {\r\n                    var api = this.api();\r\n" +
"                    var startIndex = api.context[0]._iDisplayStart;\r\n           " +
"         api.column(0).nodes().each(function (cell, i) {\r\n                      " +
"  cell.innerHTML = startIndex + i + 1;\r\n                    });\r\n               " +
" },\r\n                \"rowCallback\": function (row, data, displayIndex) {\r\n      " +
"              $(row).attr(\"class\", \"text-c\");\r\n                    $(row).childr" +
"en(\'td\').eq(6).attr(\"class\", \"td-status\");\r\n                    $(row).children(" +
"\'td\').eq(9).attr(\"class\", \"td-manage\");\r\n                },\r\n                \"in" +
"itComplete\": function (settings, json) {\r\n\r\n                },\r\n                " +
"language: {\r\n                    lengthMenu: \'\',\r\n                    loadingRec" +
"ords: \'数据加载中...\',\r\n                    paginate: {\r\n                        prev" +
"ious: \"上一页\",\r\n                        next: \"下一页\",\r\n                        firs" +
"t: \"\",\r\n                        last: \"\"\r\n                    },\r\n              " +
"      zeroRecords: \"暂无数据\",\r\n\r\n                    info: \"<span class=\'pagesStyle" +
"\'>总共<span class=\'recordsStyle\'> _TOTAL_ 条,计 _PAGES_ </span>页，当前显示 _START_ -- _EN" +
"D_ 条记录 </span>\",\r\n                    infoEmpty: \"0条记录\",\r\n                    in" +
"foFiltered: \"\"\r\n                },\r\n                \"searching\": false,\r\n       " +
"         \"ordering\": false,\r\n                \"autoWidth\": false,\r\n              " +
"  \"iDisplayLength\": 10,\r\n                \"processing\": true,\r\n                //" +
"destroy: true, //Cannot reinitialise DataTable,解决重新加载表格内容问题\r\n\r\n            });\r\n" +
"            return dataTable;\r\n        }\r\n\r\n    </script>\r\n");

});

        }
    }
}
#pragma warning restore 1591
