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
    
    #line 6 "..\..\Areas\manage\Views\Category\Index.cshtml"
    using HST.Art.Core;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Areas\manage\Views\Category\Index.cshtml"
    using HST.Art.Web;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Areas\manage\Views\Category\Index.cshtml"
    using HST.Utillity;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/manage/Views/Category/Index.cshtml")]
    public partial class _Areas_manage_Views_Category_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_manage_Views_Category_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\manage\Views\Category\Index.cshtml"
  
    Layout = null;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("\r\n");

            
            #line 9 "..\..\Areas\manage\Views\Category\Index.cshtml"
Write(Scripts.Render("~/bundles/saos"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 10 "..\..\Areas\manage\Views\Category\Index.cshtml"
Write(Scripts.Render("~/bundles/ajaxAsync"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 11 "..\..\Areas\manage\Views\Category\Index.cshtml"
Write(Scripts.Render("~/bundles/validate"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 12 "..\..\Areas\manage\Views\Category\Index.cshtml"
Write(Styles.Render("~/appcss"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<nav");

WriteLiteral(" class=\"breadcrumb\"");

WriteLiteral("><i");

WriteLiteral(" class=\"Hui-iconfont\"");

WriteLiteral(">&#xe67f;</i> 首页 <span");

WriteLiteral(" class=\"c-gray en\"");

WriteLiteral(">&gt;</span><a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" onclick=\"location.reload()\"");

WriteLiteral(">类别设置</a> </nav>\r\n<article");

WriteLiteral(" class=\"page-container\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"tabBar cl\"");

WriteLiteral(" id=\"tabBarList\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" data-type=\"");

            
            #line 17 "..\..\Areas\manage\Views\Category\Index.cshtml"
                    Write(CategoryType.Industry);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" class=\"current\"");

WriteLiteral(">");

            
            #line 17 "..\..\Areas\manage\Views\Category\Index.cshtml"
                                                            Write(CategoryType.Industry.GetDescription());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        <span");

WriteLiteral(" data-type=\"");

            
            #line 18 "..\..\Areas\manage\Views\Category\Index.cshtml"
                    Write(CategoryType.Association);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" class=\"\"");

WriteLiteral(">");

            
            #line 18 "..\..\Areas\manage\Views\Category\Index.cshtml"
                                                        Write(CategoryType.Association.GetDescription());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        <span");

WriteLiteral(" data-type=\"");

            
            #line 19 "..\..\Areas\manage\Views\Category\Index.cshtml"
                    Write(CategoryType.Examination);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" class=\"\"");

WriteLiteral(">");

            
            #line 19 "..\..\Areas\manage\Views\Category\Index.cshtml"
                                                        Write(CategoryType.Examination.GetDescription());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        <span");

WriteLiteral(" data-type=\"");

            
            #line 20 "..\..\Areas\manage\Views\Category\Index.cshtml"
                    Write(CategoryType.Social);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" class=\"\"");

WriteLiteral(">");

            
            #line 20 "..\..\Areas\manage\Views\Category\Index.cshtml"
                                                   Write(CategoryType.Social.GetDescription());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        <span");

WriteLiteral(" data-type=\"");

            
            #line 21 "..\..\Areas\manage\Views\Category\Index.cshtml"
                    Write(CategoryType.Member);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" class=\"\"");

WriteLiteral(">");

            
            #line 21 "..\..\Areas\manage\Views\Category\Index.cshtml"
                                                   Write(CategoryType.Member.GetDescription());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        <span");

WriteLiteral(" data-type=\"");

            
            #line 22 "..\..\Areas\manage\Views\Category\Index.cshtml"
                    Write(CategoryType.Download);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" class=\"\"");

WriteLiteral(">");

            
            #line 22 "..\..\Areas\manage\Views\Category\Index.cshtml"
                                                     Write(CategoryType.Download.GetDescription());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"tabCon tab-show\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"cl pd-10  mt-10 search-wrap\"");

WriteLiteral(" style=\"padding-left:0px;padding-right:0px\"");

WriteLiteral(">\r\n            <button");

WriteLiteral(" class=\"btn btn-primary float-right ml-20 hidden\"");

WriteLiteral(" id=\"btnParent\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 1362), Tuple.Create("\"", 1417)
, Tuple.Create(Tuple.Create("", 1372), Tuple.Create("category_parent(\'大类管理\',\'", 1372), true)
            
            #line 27 "..\..\Areas\manage\Views\Category\Index.cshtml"
                                     , Tuple.Create(Tuple.Create("", 1396), Tuple.Create<System.Object, System.Int32>(Url.Action("List")
            
            #line default
            #line hidden
, 1396), false)
, Tuple.Create(Tuple.Create("", 1415), Tuple.Create("\')", 1415), true)
);

WriteLiteral(" type=\"button\"");

WriteLiteral(">大类管理</button>\r\n            <button");

WriteLiteral(" name=\"search\"");

WriteLiteral(" class=\"btn btn-primary  float-right\"");

WriteLiteral(" id=\"btn_add\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(">添加类别</button>\r\n            <span");

WriteLiteral(" class=\"help-block help-tip  \"");

WriteLiteral(" style=\"font-size:13px\"");

WriteLiteral(">添加和编辑类别将在表格中完成，便于您对类别的维护</span>\r\n        </div>\r\n        <div");

WriteLiteral(" style=\"margin-top:-10px\"");

WriteLiteral(">\r\n            <table");

WriteLiteral(" id=\"tbTable\"");

WriteLiteral(" class=\"table table-border table-bordered table-bg table-sort\"");

WriteLiteral(">\r\n                <thead>\r\n                    <tr");

WriteLiteral(" class=\"text-c\"");

WriteLiteral(">\r\n                        <th");

WriteLiteral(" width=\"8%\"");

WriteLiteral(">序号</th>\r\n                        <th");

WriteLiteral(" style=\"display:none\"");

WriteLiteral(">所属类别</th>\r\n                        <th>类别名称</th>\r\n                        <th");

WriteLiteral(" width=\"10%\"");

WriteLiteral(">状态</th>\r\n                        <th");

WriteLiteral(" width=\"15%\"");

WriteLiteral(">创建时间</th>\r\n                        <th");

WriteLiteral(" width=\"10%\"");

WriteLiteral(">创建人</th>\r\n                        <th");

WriteLiteral(" width=\"15%\"");

WriteLiteral(">操作</th>\r\n                    </tr>\r\n                </thead>\r\n            </tabl" +
"e>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"hidden\"");

WriteLiteral(">\r\n        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"categoryType\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2404), Tuple.Create("\"", 2436)
            
            #line 48 "..\..\Areas\manage\Views\Category\Index.cshtml"
, Tuple.Create(Tuple.Create("", 2412), Tuple.Create<System.Object, System.Int32>(ViewBag.DefaultCategory
            
            #line default
            #line hidden
, 2412), false)
);

WriteLiteral(" />\r\n        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"categoryId\"");

WriteLiteral(" value=\"0\"");

WriteLiteral(" />\r\n        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"categoryParentId\"");

WriteLiteral(" value=\"0\"");

WriteLiteral(" />\r\n        <select");

WriteLiteral(" class=\"hidden\"");

WriteLiteral(" id=\"selEnabled\"");

WriteLiteral(">\r\n            <option");

WriteLiteral(" value=\"0\"");

WriteLiteral(">所属类别</option>\r\n");

            
            #line 53 "..\..\Areas\manage\Views\Category\Index.cshtml"
            
            
            #line default
            #line hidden
            
            #line 53 "..\..\Areas\manage\Views\Category\Index.cshtml"
             foreach (CategoryDictionary item in ViewBag.EnabledCategory)
            {

            
            #line default
            #line hidden
WriteLiteral("                <option");

WriteAttribute("value", Tuple.Create(" value=\"", 2773), Tuple.Create("\"", 2789)
            
            #line 55 "..\..\Areas\manage\Views\Category\Index.cshtml"
, Tuple.Create(Tuple.Create("", 2781), Tuple.Create<System.Object, System.Int32>(item.Id
            
            #line default
            #line hidden
, 2781), false)
);

WriteLiteral(">");

            
            #line 55 "..\..\Areas\manage\Views\Category\Index.cshtml"
                                    Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 56 "..\..\Areas\manage\Views\Category\Index.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </select>\r\n        <select");

WriteLiteral(" class=\"hidden\"");

WriteLiteral(" id=\"selAll\"");

WriteLiteral(">\r\n            <option");

WriteLiteral(" value=\"0\"");

WriteLiteral(">所属类别</option>\r\n");

            
            #line 60 "..\..\Areas\manage\Views\Category\Index.cshtml"
            
            
            #line default
            #line hidden
            
            #line 60 "..\..\Areas\manage\Views\Category\Index.cshtml"
             foreach (CategoryDictionary item in ViewBag.AllCategory)
            {

            
            #line default
            #line hidden
WriteLiteral("                <option");

WriteAttribute("value", Tuple.Create(" value=\"", 3045), Tuple.Create("\"", 3061)
            
            #line 62 "..\..\Areas\manage\Views\Category\Index.cshtml"
, Tuple.Create(Tuple.Create("", 3053), Tuple.Create<System.Object, System.Int32>(item.Id
            
            #line default
            #line hidden
, 3053), false)
);

WriteLiteral(">");

            
            #line 62 "..\..\Areas\manage\Views\Category\Index.cshtml"
                                    Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 63 "..\..\Areas\manage\Views\Category\Index.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </select>\r\n\r\n        <table");

WriteLiteral(" id=\"tableCategory1\"");

WriteLiteral(">\r\n            <tr");

WriteLiteral(" class=\"text-c bg-warning\"");

WriteLiteral(">\r\n                <td>1</td>\r\n                <td");

WriteLiteral(" colspan=\"5\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" data-bind=\"category-form\"");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"formControls col-xs-4  hidden\"");

WriteLiteral(">\r\n                            <select");

WriteLiteral(" class=\"select select-box\"");

WriteLiteral(" name=\"selParCategory\"");

WriteLiteral(" onchange=\"bindCategory(this)\"");

WriteLiteral("></select>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"formControls col-xs-4 \"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"input-text \"");

WriteLiteral(" autocomplete=\"off\"");

WriteLiteral(" value=\"\"");

WriteLiteral(" onfocus=\"clearError(this)\"");

WriteLiteral(" placeholder=\"请输入类别名\"");

WriteLiteral(" name=\"CategoryName\"");

WriteLiteral(" />\r\n                            <label");

WriteLiteral(" class=\"error hidden\"");

WriteLiteral(">请输入类别名</label>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"formControls col-xs-4 hidden\"");

WriteLiteral(" data-bind=\"btn-add\"");

WriteLiteral(">\r\n                            <button");

WriteLiteral(" class=\"btn btn-primary radius btn-xs float-left\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 4059), Tuple.Create("\"", 4103)
, Tuple.Create(Tuple.Create("", 4069), Tuple.Create("subForm(this,\'", 4069), true)
            
            #line 79 "..\..\Areas\manage\Views\Category\Index.cshtml"
                            , Tuple.Create(Tuple.Create("", 4083), Tuple.Create<System.Object, System.Int32>(Url.Action("Add")
            
            #line default
            #line hidden
, 4083), false)
, Tuple.Create(Tuple.Create("", 4101), Tuple.Create("\')", 4101), true)
);

WriteLiteral(">保存</button>\r\n                            <button");

WriteLiteral(" class=\"btn btn-default radius btn-xs float-left\"");

WriteLiteral(" onclick=\"removeParent(this)\"");

WriteLiteral(">取消</button>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"formControls col-xs-4 hidden\"");

WriteLiteral(" data-bind=\"btn-edit\"");

WriteLiteral(">\r\n                            <button");

WriteLiteral(" class=\"btn btn-primary radius btn-xs float-left\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 4450), Tuple.Create("\"", 4495)
, Tuple.Create(Tuple.Create("", 4460), Tuple.Create("subForm(this,\'", 4460), true)
            
            #line 83 "..\..\Areas\manage\Views\Category\Index.cshtml"
                            , Tuple.Create(Tuple.Create("", 4474), Tuple.Create<System.Object, System.Int32>(Url.Action("Edit")
            
            #line default
            #line hidden
, 4474), false)
, Tuple.Create(Tuple.Create("", 4493), Tuple.Create("\')", 4493), true)
);

WriteLiteral(">保存</button>\r\n                            <button");

WriteLiteral(" class=\"btn btn-default radius btn-xs float-left\"");

WriteLiteral(" onclick=\"cancelEdit(this)\"");

WriteLiteral(">取消</button>\r\n                        </div>\r\n                    </div>\r\n       " +
"         </td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n</article>\r\n\r\n");

            
            #line 93 "..\..\Areas\manage\Views\Category\Index.cshtml"
Write(Scripts.Render("~/bundles/datatable"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
    var tempTr;
    var table1 = null;
    $(function () {
        table1 = initializeTable();
        $(""#tabBarList span"").each(function () {
            $(this).click(function () {
                $(this).addClass(""current"").siblings().removeClass(""current"");
                var attrType = $(this).attr(""data-type"");
                if (attrType != '");

            
            #line 103 "..\..\Areas\manage\Views\Category\Index.cshtml"
                            Write(CategoryType.UnKnown);

            
            #line default
            #line hidden
WriteLiteral("\') {\r\n                    if (attrType == \'");

            
            #line 104 "..\..\Areas\manage\Views\Category\Index.cshtml"
                                Write(CategoryType.Examination);

            
            #line default
            #line hidden
WriteLiteral(@"') {
                        $(""#btnParent"").removeClass(""hidden"");
                        $('#tbTable').find('th:eq(1)').show();
                    } else {
                        $(""#btnParent"").addClass(""hidden"");
                        $('#tbTable').find('th:eq(1)').hide();
                    }

                    $(""#categoryType"").val(attrType);
                    table1.ajax.reload();
                }
            })
        });

        $(""#btn_add"").click(function () {
            $(""#categoryId,#categoryParentId"").val(0);
            if ($(""#tbTable div[data-bind=category-form]"").length > 0) {
                $(""#tbTable input[name=CategoryName]"").focus();
                top.layer.alert(""当前有未编辑完的项目，请操作完成后再进行添加"", 3);
                return false;
            }

            if ($(""#categoryType"").val() == '");

            
            #line 126 "..\..\Areas\manage\Views\Category\Index.cshtml"
                                        Write(CategoryType.Examination);

            
            #line default
            #line hidden
WriteLiteral("\') {\r\n                $(\"#tableCategory1 select\").parent().removeClass(\"hidden\");" +
"\r\n                $(\"#tableCategory1 tbody td:last\").attr(\"colspan\", 6);\r\n      " +
"      } else {\r\n                $(\"#tableCategory1 select\").parent().addClass(\"h" +
"idden\");\r\n                $(\"#tableCategory1 tbody td:last\").attr(\"colspan\", 5);" +
"\r\n            }\r\n\r\n            $(\"#tableCategory1 select\").empty().html($(\"#selE" +
"nabled\").html());\r\n            $(\"#tableCategory1 div[data-bind=btn-add]\").remov" +
"eClass(\"hidden\");\r\n            $(\"#tableCategory1 div[data-bind=btn-edit]\").addC" +
"lass(\"hidden\");\r\n            var trCount = $(\"#tbTable tbody tr\").length + 1;\r\n " +
"           $(\"#tableCategory1\").find(\"td:first\").html(trCount);\r\n            $(\"" +
"#tbTable tbody\").append($(\"#tableCategory1 tbody\").html());\r\n        })\r\n    });" +
"\r\n\r\n    function bindCategory(obj) {\r\n        $(\"#categoryParentId\").val($(obj)." +
"val());\r\n        $(obj).removeClass(\"error\");\r\n    }\r\n\r\n    function clearError(" +
"obj) {\r\n        $(obj).removeClass(\"error\").siblings().addClass(\"hidden\");\r\n    " +
"}\r\n    function cancelEdit(obj) {\r\n        $(obj).parents(\"tr\").empty().html(tem" +
"pTr).removeClass(\"bg-warning\");\r\n    }\r\n\r\n    function removeParent(obj) {\r\n    " +
"    $(obj).parents(\"tr\").remove();\r\n    }\r\n\r\n    function subForm(obj, url) {\r\n " +
"       if ($(\"#tbTable input[name=CategoryName]\").val().length <= 0) {\r\n        " +
"    $(\"#tbTable input[name=CategoryName]\").siblings(\"label\").removeClass(\"hidden" +
"\");\r\n            $(\"#tbTable input[name=CategoryName]\").addClass(\"error\");\r\n    " +
"        return false;\r\n        }\r\n\r\n        if ($(\"#categoryType\").val() == \'");

            
            #line 166 "..\..\Areas\manage\Views\Category\Index.cshtml"
                                    Write(CategoryType.Examination);

            
            #line default
            #line hidden
WriteLiteral(@"' && $(""#tbTable select[name=selParCategory]"").val() <= 0) {
            $(""#tbTable select[name=selParCategory]"").addClass(""error"");
            return false;
        }

        $.ajax({
            url: url,
            type: ""Post"",
            data: { ""CategoryName"": $(""#tbTable input[name=CategoryName]"").val(), ""CategoryType"": $(""#categoryType"").val(), ""Id"": $(""#categoryId"").val(), ParentId: $(""#categoryParentId"").val() },
            dataType: ""json"",
            success: function (data) {
                if (data.isSuccess) {
                    layer.msg(""操作成功"");
                    table1.ajax.reload();
                } else {
                    top.layer.alert(data.message, 3);
                }
            }
        })

    }

    function reloadParCategory() {
        console.log(""获取类别被执行了"");
        $.ajax({
            url: """);

            
            #line 191 "..\..\Areas\manage\Views\Category\Index.cshtml"
             Write(Url.Action("GetParentCategory"));

            
            #line default
            #line hidden
WriteLiteral("\",\r\n            type: \"Get\",          \r\n            dataType: \"json\",\r\n          " +
"  success: function (data) {\r\n                var sbAll = new StringBuffer();\r\n " +
"               var sbEnabled = new StringBuffer();\r\n                $.each(data." +
"allList, function (i, v) {\r\n                    sbAll.append(\"<option value=\'\" +" +
" v.Id + \"\'>\" + v.Name + \"</option>\");\r\n                });\r\n\r\n                $." +
"each(data.enabledList, function (i, v) {\r\n                    sbEnabled.append(\"" +
"<option value=\'\" + v.Id + \"\'>\" + v.Name + \"</option>\");\r\n                });\r\n\r\n" +
"\r\n                $(\"#selAll\").empty().append(\"<option value=\'0\'>所属类别</option>\")" +
".append(sbAll.toString());\r\n                $(\"#selEnabled\").empty().append(\"<op" +
"tion value=\'0\'>所属类别</option>\").append(sbEnabled.toString());\r\n            }\r\n   " +
"     })\r\n    }\r\n\r\n    function category_parent(title, url) {\r\n        if ($(\"#tb" +
"Table div[data-bind=category-form]\").length > 0) {\r\n            top.layer.alert(" +
"\"当前有未编辑完的项目，请操作完成后再进行大类管理\", 3);\r\n            return false;\r\n        }\r\n\r\n       " +
" var index = top.layer.open({\r\n            type: 2,\r\n            title: title,\r\n" +
"            area: [\'950px\', \'650px\'],\r\n            content: url\r\n        });\r\n  " +
"  }\r\n\r\n    function category_deit(obj, id, parentId) {\r\n        if ($(\"#tbTable " +
"div[data-bind=category-form]\").length > 0) {\r\n            $(\"#tbTable input[name" +
"=CategoryName]\").focus();\r\n            top.layer.alert(\"当前有未编辑完的项目，请操作完成后再进行添加\"," +
" 3);\r\n            return false;\r\n        }\r\n\r\n        if (parentId > 0) {\r\n     " +
"       $(\"#tableCategory1 select\").parent().removeClass(\"hidden\");\r\n            " +
"$(\"#tableCategory1 tbody td:last\").attr(\"colspan\", 6);\r\n        } else {\r\n      " +
"      $(\"#tableCategory1 select\").parent().addClass(\"hidden\");\r\n            $(\"#" +
"tableCategory1 tbody td:last\").attr(\"colspan\", 5);\r\n        }\r\n\r\n        $(\"#cat" +
"egoryId\").val(id);\r\n        $(\"#categoryParentId\").val(parentId);\r\n        $(\"#t" +
"ableCategory1 select\").empty().html($(\"#selAll\").html());\r\n        var categroyV" +
"al = $(obj).attr(\"data-bind\");\r\n        $(\"#tableCategory1 div[data-bind=btn-add" +
"]\").addClass(\"hidden\");\r\n        $(\"#tableCategory1 div[data-bind=btn-edit]\").re" +
"moveClass(\"hidden\");\r\n        var trCount = $(obj).parents(\"tr\").find(\"td:first\"" +
").html();\r\n        $(\"#tableCategory1\").find(\"td:first\").html(trCount);\r\n       " +
" tempTr = $(obj).parents(\"tr\").html();\r\n        $(obj).parents(\"tr\").addClass(\"b" +
"g-warning\").empty().html($(\"#tableCategory1 tbody tr:first\").html());\r\n\r\n       " +
" $(\"#tbTable\").find(\"input[name=CategoryName]\").val(categroyVal);\r\n        $(\"#t" +
"bTable\").find(\"select\").val(parentId);\r\n    }\r\n\r\n    function initializeTable() " +
"{\r\n        var dataTable = $(\'#tbTable\').DataTable({\r\n            \"serverSide\": " +
"true,\r\n            \"ajax\": {\r\n                \"url\": \"");

            
            #line 260 "..\..\Areas\manage\Views\Category\Index.cshtml"
                   Write(Url.Action("GetJsonData"));

            
            #line default
            #line hidden
WriteLiteral("\",\r\n                \"type\": \"post\",\r\n                \"data\": function (data) {\r\n " +
"                   data.pageIndex = (data.start / data.length) + 1;\r\n           " +
"         data.categoryType = $(\"#categoryType\").val();\r\n                    data" +
".isParent = false;\r\n                }\r\n            },\r\n            \"columns\": [\r" +
"\n                { \"defaultContent\": \"\" },\r\n                { \"mDataProp\": \"Pare" +
"ntName\" },\r\n                { \"mDataProp\": \"CategoryName\" },\r\n                 {" +
" \"mDataProp\": \"State\" },\r\n                { \"mDataProp\": \"CreateTime\" },\r\n      " +
"           { \"mDataProp\": \"UserName\" },\r\n                { \"defaultContent\": \"\" " +
"}\r\n            ],\r\n            \"columnDefs\": [\r\n             {\r\n                " +
" \"targets\": [3],\r\n                 \"data\": \"State\",\r\n                 \"render\": " +
"function (data, type, full) {\r\n                     var result = data;\r\n        " +
"             if (data > 0) {\r\n                         result = \"<span class=\\\"l" +
"abel label-success radius\\\">已上架</span>\";\r\n                     } else {\r\n       " +
"                  result = \"<span class=\\\"label label-danger radius\\\">已下架</span>" +
"\";\r\n                     }\r\n\r\n                     return result;\r\n             " +
"    }\r\n             },\r\n            {\r\n                \"targets\": [-1],\r\n       " +
"         \"data\": \"Id\",\r\n                \"render\": function (data, type, full) {\r" +
"\n                    var tmpString = \"<a data-bind=\'\" + full.CategoryName + \"\'  " +
"onClick=\\\"category_deit(this,\" + data + \",\" + full.ParentId + \")\\\" href=\\\"javasc" +
"ript:;\\\" title=\\\"编辑\\\">编辑</a>\";\r\n                    if (full.State == 0)\r\n      " +
"                  tmpString += \"<a href=\\\"javascript:;\\\" onClick=\\\"obj_publish(\'" +
"");

            
            #line 298 "..\..\Areas\manage\Views\Category\Index.cshtml"
                                                                                 Write(Url.Action("Publish"));

            
            #line default
            #line hidden
WriteLiteral("\',\" + data + \")\\\"  title=\\\"上架\\\">上架</a>\";\r\n                    else\r\n             " +
"           tmpString += \"<a href=\\\"javascript:;\\\" onClick=\\\"obj_shelves(\'");

            
            #line 300 "..\..\Areas\manage\Views\Category\Index.cshtml"
                                                                                 Write(Url.Action("Shelves"));

            
            #line default
            #line hidden
WriteLiteral("\',\" + data + \")\\\"  title=\\\"下架\\\">下架</a>\";\r\n                    tmpString += \"<a hr" +
"ef=\\\"javascript:;\\\" onClick=\\\"obj_del(\'类别\',\'");

            
            #line 301 "..\..\Areas\manage\Views\Category\Index.cshtml"
                                                                              Write(Url.Action("Delete"));

            
            #line default
            #line hidden
WriteLiteral(@"',"" + data + "")\""  title=\""删除\"">删除</a>"";

                    return tmpString;
                }
            }
            ],
            ""fnDrawCallback"": function () {
                var api = this.api();
                var startIndex = api.context[0]._iDisplayStart;
                api.column(0).nodes().each(function (cell, i) {
                    cell.innerHTML = startIndex + i + 1;
                });
            },
            ""rowCallback"": function (row, data, displayIndex) {
                $(row).attr(""class"", ""text-c"").attr(""data-bind"", data.Id);
                if ($(""#categoryType"").val() == '");

            
            #line 316 "..\..\Areas\manage\Views\Category\Index.cshtml"
                                            Write(CategoryType.Examination);

            
            #line default
            #line hidden
WriteLiteral(@"') {
                    $(row).children('td').eq(1).css(""display"", ""block"");
                } else {
                    $(row).children('td').eq(1).css(""display"", ""none"");
                }

                $(row).children('td').eq(3).attr(""class"", ""td-status"");
                $(row).children('td').eq(6).attr(""class"", ""td-manage"");
            },
            ""initComplete"": function (settings, json) {
            },
            language: {
                lengthMenu: '',
                loadingRecords: '数据加载中...',
                paginate: {
                    previous: ""上一页"",
                    next: ""下一页"",
                    first: """",
                    last: """"
                },
                zeroRecords: ""暂无数据"",

                info: ""<span class='pagesStyle'>总共<span class='recordsStyle'> _TOTAL_ 条,计 _PAGES_ </span>页，当前显示 _START_ -- _END_ 条记录 </span>"",
                infoEmpty: ""0条记录"",
                infoFiltered: """"
            },
            ""searching"": false,
            ""ordering"": false,
            ""autoWidth"": false,
            ""iDisplayLength"": 50,
            ""processing"": true,
            //destroy: true, //Cannot reinitialise DataTable,解决重新加载表格内容问题

        });

        return dataTable;
    }

</script>
");

        }
    }
}
#pragma warning restore 1591
