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
    using cncbk_resource;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ResAdmin/List.cshtml")]
    public partial class _Views_ResAdmin_List_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_ResAdmin_List_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 2 "..\..\Views\ResAdmin\List.cshtml"
  
    ViewBag.Title = "后台管理员";

            
            #line default
            #line hidden
WriteLiteral("\r\n<!--[if lt IE 9]>\r\n<script type=\"text/javascript\" src=\"lib/html5shiv.js\"></scri" +
"pt>\r\n<script type=\"text/javascript\" src=\"lib/respond.min.js\"></script>\r\n<![endif" +
"]-->\r\n");

            
            #line 9 "..\..\Views\ResAdmin\List.cshtml"
Write(Scripts.Render("~/bundles/saos"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 10 "..\..\Views\ResAdmin\List.cshtml"
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

WriteLiteral(">&gt;</span> 系统管理 <span");

WriteLiteral(" class=\"c-gray en\"");

WriteLiteral(">&gt;</span> 后台管理员 <a");

WriteLiteral(" class=\"btn btn-success radius r\"");

WriteLiteral(" style=\"line-height:1.6em;margin-top:3px\"");

WriteLiteral(" href=\"javascript:location.replace(location.href);\"");

WriteLiteral(" title=\"刷新\"");

WriteLiteral("><i");

WriteLiteral(" class=\"Hui-iconfont\"");

WriteLiteral(">&#xe68f;</i></a></nav>\r\n<div");

WriteLiteral(" class=\"page-container\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"cl pd-5 bg-1 bk-gray mt-10 search-wrap\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"label-inline\"");

WriteLiteral(">用户名：</span>\r\n        <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"userName\"");

WriteLiteral(" placeholder=\"请输入用户名\"");

WriteLiteral(" class=\"input-text lg inline\"");

WriteLiteral(" />\r\n        <span");

WriteLiteral(" class=\"label-inline\"");

WriteLiteral(">状态：</span>\r\n        <select");

WriteLiteral(" id=\"sel_userState\"");

WriteLiteral(" class=\"select select-box inline\"");

WriteLiteral(">\r\n            <option");

WriteLiteral(" value=\"-1\"");

WriteLiteral(">全部</option>\r\n            <option");

WriteLiteral(" value=\"1\"");

WriteLiteral(">启用</option>\r\n            <option");

WriteLiteral(" value=\"0\"");

WriteLiteral(">禁用</option>\r\n        </select>\r\n        <span");

WriteLiteral(" class=\"label-inline\"");

WriteLiteral(">创建时间：</span>\r\n        <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" onclick=\"WdatePicker()\"");

WriteLiteral(" placeholder=\"创建时间\"");

WriteLiteral(" id=\"sTime\"");

WriteLiteral(" class=\"input-text inline Wdate\"");

WriteLiteral(" />\r\n        <button");

WriteLiteral(" name=\"search\"");

WriteLiteral(" id=\"search\"");

WriteLiteral(" class=\"btn btn-success ml-10\"");

WriteLiteral(" type=\"button\"");

WriteLiteral("><i");

WriteLiteral(" class=\"Hui-iconfont\"");

WriteLiteral(">&#xe665;</i> 搜索</button>\r\n        <button");

WriteLiteral(" class=\"btn btn-warning\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 1592), Tuple.Create("\"", 1644)
, Tuple.Create(Tuple.Create("", 1602), Tuple.Create("resAdmin_add(\'添加管理员\',\'", 1602), true)
            
            #line 29 "..\..\Views\ResAdmin\List.cshtml"
, Tuple.Create(Tuple.Create("", 1624), Tuple.Create<System.Object, System.Int32>(Url.Action("Add")
            
            #line default
            #line hidden
, 1624), false)
, Tuple.Create(Tuple.Create("", 1642), Tuple.Create("\')", 1642), true)
);

WriteLiteral(" type=\"button\"");

WriteLiteral(">添加管理员</button>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"mt-10\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" id=\"tbTable\"");

WriteLiteral(" class=\"table table-border table-bordered table-bg table-sort\"");

WriteLiteral(">\r\n            <thead>\r\n                <tr");

WriteLiteral(" class=\"text-c\"");

WriteLiteral(">\r\n                    <th");

WriteLiteral(" width=\"8%\"");

WriteLiteral(">序号</th>\r\n                    <th");

WriteLiteral(" width=\"20%\"");

WriteLiteral(">用户名</th>\r\n                    <th");

WriteLiteral(" width=\"15%\"");

WriteLiteral(">手机号</th>\r\n                    <th");

WriteLiteral(" width=\"14%\"");

WriteLiteral(">角色</th>\r\n                    <th");

WriteLiteral(" width=\"14%\"");

WriteLiteral(">状态</th>\r\n                    <th");

WriteLiteral(" width=\"14%\"");

WriteLiteral(">创建时间</th>\r\n                    <th");

WriteLiteral(" width=\"15%\"");

WriteLiteral(">管理</th>\r\n                </tr>\r\n            </thead>\r\n        </table>\r\n    </di" +
"v>\r\n</div>\r\n\r\n");

            
            #line 48 "..\..\Views\ResAdmin\List.cshtml"
Write(Scripts.Render("~/bundles/datatable"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n\r\n    <script>\r\n        var roleList = \'");

            
            #line 52 "..\..\Views\ResAdmin\List.cshtml"
                   Write(Html.Raw(ViewBag.state));

            
            #line default
            #line hidden
WriteLiteral(@"';
        function checkValue(idstr) {
            if (roleList.length > 0) {
                var objjson = JSON.parse(roleList);
                for (var i in objjson) {
                    if (objjson[i].Id == idstr)
                        return objjson[i].RoleName;
                }
            }
        }
        function ChangeDateFormat(val) {
            if (val != null) {
                var date = new Date(parseInt(val.replace(""/Date("", """").replace("")/"", """"), 10));
                //月份为0-11，所以+1，月份小于10时补个0
                var month = date.getMonth() + 1 < 10 ? ""0"" + (date.getMonth() + 1) : date.getMonth() + 1;
                var currentDate = date.getDate() < 10 ? ""0"" + date.getDate() : date.getDate();
                return date.getFullYear() + ""-"" + month + ""-"" + currentDate;
            }
            return """";
        }
    </script>

    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        var table1 = null;\r\n        $(function () {\r\n            table1 = init" +
"ializeTable();\r\n            $(\"#search\").click(function () {\r\n                ta" +
"ble1.ajax.reload();\r\n            });\r\n\r\n            //输入名称回车查询\r\n            $(\"#" +
"userName\").keypress(function (e) {\r\n                if (e.which == 13) {\r\n      " +
"              table1.ajax.reload();\r\n                    $(\"#search\").focus();\r\n" +
"                }\r\n            });\r\n        });\r\n\r\n        /*更新*/\r\n        funct" +
"ion admin_update(title, url, id) {\r\n            var index = layer.open({\r\n      " +
"          type: 2,\r\n                title: title,\r\n                area: [\'700px" +
"\', \'500px\'],\r\n                content: url + \"?id=\" + id\r\n            });\r\n     " +
"   }\r\n        /*添加*/\r\n        function resAdmin_add(title, url) {\r\n            v" +
"ar index = layer.open({\r\n                type: 2,\r\n                title: title," +
"\r\n                area: [\'700px\', \'550px\'],\r\n                content: url\r\n     " +
"       });\r\n        }\r\n\r\n        /*删除*/\r\n        function admin_del(obj, id) {\r\n" +
"            layer.confirm(\'确认要删除该管理员吗？\', function (index) {\r\n                var" +
" thisobj = $(obj);\r\n                $.getJSON(\"/ResAdmin/delete\", { id: id }, fu" +
"nction (data) {\r\n                    if (data.isSuccess) {\r\n                    " +
"    layer.alert(\'操作成功！\', {\r\n                            icon: 6,\r\n              " +
"              closeBtn: 0,\r\n                            yes: function () {\r\n    " +
"                            table1.ajax.reload();\r\n                             " +
"   layer.closeAll();\r\n                            }\r\n                        });" +
"\r\n                    } else\r\n                        layer.alert(data.message, " +
"{ icon: 5 });\r\n                })\r\n            });\r\n        }\r\n        function " +
"initializeTable() {\r\n            var dataTable = $(\'#tbTable\').DataTable({\r\n    " +
"            \"serverSide\": true,\r\n                \"bRetrieve\": true,\r\n           " +
"     \"ajax\": {\r\n                    \"url\": \"");

            
            #line 134 "..\..\Views\ResAdmin\List.cshtml"
                       Write(Url.Action("GetJsonData"));

            
            #line default
            #line hidden
WriteLiteral("\",\r\n                    \"type\": \"post\",\r\n                    \"data\": function (da" +
"ta) {\r\n                        data.pageIndex = (data.start / data.length) + 1;\r" +
"\n                        data.name = $(\"#userName\").val();\r\n                    " +
"    data.state = $(\"#sel_userState\").val();\r\n                        data.stime " +
"= $(\"#sTime\").val();\r\n                    }\r\n                },\r\n               " +
" \"columns\": [\r\n                    { \"defaultContent\": \"\" },\r\n                  " +
"  { \"mDataProp\": \"UserName\" },\r\n                    { \"mDataProp\": \"Phone\" },\r\n " +
"                   { \"mDataProp\": \"RoleId\" },\r\n                    { \"mDataProp\"" +
": \"State\" },\r\n                    { \"mDataProp\": \"CreateTime\" },\r\n              " +
"      { \"defaultContent\": \"\" }\r\n                ],\r\n                \"columnDefs\"" +
": [\r\n                 {\r\n                     \"targets\": [4],\r\n                 " +
"    \"data\": \"State\",\r\n                     \"render\": function (data, type, full)" +
" {\r\n                         var result = data;\r\n                         if (da" +
"ta)\r\n                             result = \"<span class=\\\"label label-success ra" +
"dius\\\">启用</span>\";\r\n                         else\r\n                             " +
"result = \"<span class=\\\"label label-danger radius\\\">禁用</span>\";\r\n               " +
"          return result;\r\n                     }\r\n                 },\r\n         " +
"       {\r\n                    \"targets\": [-1],\r\n                    \"data\": \"Id\"" +
",\r\n                    \"render\": function (data, type, full) {\r\n                " +
"        if (full.IsSupAdmin && \"");

            
            #line 169 "..\..\Views\ResAdmin\List.cshtml"
                                           Write(ViewBag.IsAdmin);

            
            #line default
            #line hidden
WriteLiteral("\"==\"False\") {\r\n                        return  \"不可操作\"\r\n                        } " +
"else {\r\n                            var tmpString = \"<a href=\\\"javascript:;\\\" on" +
"Click=\\\"admin_update(\'修改管理员\',\'");

            
            #line 172 "..\..\Views\ResAdmin\List.cshtml"
                                                                                                 Write(Url.Action("Update"));

            
            #line default
            #line hidden
WriteLiteral("\',\" + data + \")\\\"  title=\\\"修改\\\">修改</a>\";\r\n                            if(!full.Is" +
"SupAdmin){\r\n                                tmpString += \"<a href=\\\"javascript:;" +
"\\\" onClick=\\\"admin_del(this,\" + data + \")\\\"  title=\\\"删除\\\">删除</a>\";\r\n            " +
"                }\r\n                            return tmpString;\r\n              " +
"          }\r\n                     \r\n                    }\r\n                }, {\r" +
"\n                    \"targets\": [3],\r\n                    \"data\": \"RoleId\",\r\n   " +
"                 \"render\": function (data, type, full) {\r\n                      " +
"  return checkValue(data)\r\n                    }\r\n                }, {\r\n        " +
"            \"targets\": [5],\r\n                    \"data\": \"CreateTime\",\r\n        " +
"            \"render\": function (data, type, full) {\r\n                        ret" +
"urn ChangeDateFormat(data)\r\n                    }\r\n                }\r\n          " +
"      ],\r\n                \"fnDrawCallback\": function () {\r\n                    v" +
"ar api = this.api();\r\n                    var startIndex = api.context[0]._iDisp" +
"layStart;\r\n                    api.column(0).nodes().each(function (cell, i) {\r\n" +
"                        cell.innerHTML = startIndex + i + 1;\r\n                  " +
"  });\r\n                },\r\n                \"rowCallback\": function (row, data, d" +
"isplayIndex) {\r\n                    $(row).attr(\"class\", \"text-c\");\r\n           " +
"         $(row).children(\'td\').eq(6).attr(\"class\", \"td-manage\");\r\n              " +
"  },\r\n                \"initComplete\": function (settings, json) {\r\n\r\n           " +
"     },\r\n                language: {\r\n                    lengthMenu: \'\',\r\n     " +
"               loadingRecords: \'数据加载中...\',\r\n                    paginate: {\r\n   " +
"                     previous: \"上一页\",\r\n                        next: \"下一页\",\r\n   " +
"                     first: \"\",\r\n                        last: \"\"\r\n             " +
"       },\r\n                    zeroRecords: \"暂无数据\",\r\n\r\n                    info:" +
" \"<span class=\'pagesStyle\'>总共<span class=\'recordsStyle\'> _TOTAL_ 条,计 _PAGES_ </s" +
"pan>页，当前显示 _START_ -- _END_ 条记录 </span>\",\r\n                    infoEmpty: \"0条记录\"" +
",\r\n                    infoFiltered: \"\"\r\n                },\r\n                \"se" +
"arching\": false,\r\n                \"ordering\": false,\r\n                \"autoWidth" +
"\": false,\r\n                \"iDisplayLength\": 10,\r\n                \"processing\": " +
"true,\r\n                //destroy: true, //Cannot reinitialise DataTable,解决重新加载表格" +
"内容问题\r\n\r\n            });\r\n            return dataTable;\r\n        }\r\n\r\n    </scrip" +
"t>\r\n");

});

        }
    }
}
#pragma warning restore 1591