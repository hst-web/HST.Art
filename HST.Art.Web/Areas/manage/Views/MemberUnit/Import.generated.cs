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
    
    #line 6 "..\..\Areas\manage\Views\MemberUnit\Import.cshtml"
    using HST.Art.Core;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Areas\manage\Views\MemberUnit\Import.cshtml"
    using HST.Art.Web;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Areas\manage\Views\MemberUnit\Import.cshtml"
    using HST.Utillity;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/manage/Views/MemberUnit/Import.cshtml")]
    public partial class _Areas_manage_Views_MemberUnit_Import_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_manage_Views_MemberUnit_Import_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\manage\Views\MemberUnit\Import.cshtml"
  
    Layout = null;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("\r\n");

            
            #line 9 "..\..\Areas\manage\Views\MemberUnit\Import.cshtml"
Write(Scripts.Render("~/bundles/saos"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 10 "..\..\Areas\manage\Views\MemberUnit\Import.cshtml"
Write(Styles.Render("~/appcss"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<script");

WriteAttribute("src", Tuple.Create(" src=\"", 163), Tuple.Create("\"", 219)
, Tuple.Create(Tuple.Create("", 169), Tuple.Create<System.Object, System.Int32>(Href("~/Content/lib/webuploader/0.1.5/webuploader.min.js")
, 169), false)
);

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral("></script>\r\n<style");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(">\r\n    .form-horizontal .form-label {\r\n        text-align: right;\r\n    }\r\n</style" +
">\r\n\r\n<article");

WriteLiteral(" class=\"page-container\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"formControls \"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"form-group upload-wrap\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" id=\"upfile\"");

WriteLiteral(" style=\"float:left;\"");

WriteLiteral(" class=\"wrap-section\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"wrap-bg\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"Hui-iconfont\"");

WriteLiteral(">&#xe642;</i>\r\n                    <div");

WriteLiteral(" style=\"color:#333\"");

WriteLiteral(">上传文件</div>\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"formControls file-up\"");

WriteLiteral(">\r\n                <ul");

WriteLiteral(" id=\"filelist\"");

WriteLiteral(" class=\"\"");

WriteLiteral("></ul>\r\n                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"loc_temp_inp\"");

WriteLiteral(" />\r\n            </div>\r\n\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 938), Tuple.Create("\"", 968)
, Tuple.Create(Tuple.Create("", 945), Tuple.Create<System.Object, System.Int32>(Href("~/Content/协会会员导入模板.xlsx")
, 945), false)
);

WriteLiteral(" class=\"down-temp\"");

WriteLiteral(">点击下载导入模板</a>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"upload-info\"");

WriteLiteral(@">
            <h4>导入须知</h4>
            <ul>
                <li>1、请按照模板要求输入要导入的数据</li>
                <li>2、导入的数据默认为下架状态</li>
                <li>3、一次导入数据建议在500条以内，请不要重复导入相同数据</li>
                <li>4、如遇到导入失败可通过下载失败数据进行核对</li>
            </ul>
        </div>
        <div");

WriteLiteral(" class=\"upload-button\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" name=\"\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(" onclick=\"layer_close();\"");

WriteLiteral(" class=\"btn btn-default radius \"");

WriteLiteral(" value=\"关 闭\"");

WriteLiteral(">\r\n        </div>\r\n\r\n    </div>\r\n</article>\r\n\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n    $(function () {\r\n\r\n    });\r\n\r\n\r\n</script>\r\n\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
    var maxcount = 8;
    //上传参数
    var jq_uploadFormData = { BidFileDomain: ' ', uploadQueryData: { Suffix: 0 } };
    if (!WebUploader.Uploader.support()) {
        $("".FJsp2"").html(""说明：当前浏览器不支持附件上传"");
        $(""#upfile"").hide();
        //alert( 'Web Uploader 不支持您的浏览器！如果你使用的是IE浏览器，请尝试升级 flash 播放器');
        alert(""当前浏览器不支持附件上传，如果你使用的是IE浏览器，请尝试升级 flash 播放器"");
        throw new Error('WebUploader does not support the browser you are using.');
    }
    var BASE_URL = ""/content/webuploader-0.1.5"";
    var file_ids = []; //已上传文件的路径
    var file_info = []; //记录文件的GUID和存储路径
    var isfilesuping = false;
    // 文件上传
    jQuery(function () {
        var id = ""upfile"";
        var $ = jQuery,
    state = 'pending',
    $probar = $(""#"" + id).siblings(""div"").find("".pros""),
    uploader;
        uploader = WebUploader.create({
            // 不压缩image
            resize: false,
            //发送后台时参数
            formData: jq_uploadFormData.uploadQueryData,
            fileVal: jq_uploadFormData.BidFileDomain,
            method: ""POST"",
            //是否分块（大文件上传）
            chunked: true,
            //设置文件上传域名称
            fileVal: 'file',
            //每块最大限制（默认5M 因为是.net 所以设置2M）
            chunkSize: 2097152,
            // swf文件路径
            swf: BASE_URL + '/Uploader.swf',
            // 文件接收服务端。
            server: jq_uploadFormData.BidFileDomain + '");

            
            #line 96 "..\..\Areas\manage\Views\MemberUnit\Import.cshtml"
                                                  Write(Url.Action("ImportExcel"));

            
            #line default
            #line hidden
WriteLiteral("\',\r\n            //创建选择文件按钮\r\n            pick: { id: \"#\" + id, innerHTML: \"\", mult" +
"iple: false },\r\n            //选择文件自动上传\r\n            auto: true,\r\n            //a" +
"ccept:{title:\"只能上传rar,zip文件\",extensions :\'rar,zip\',mimeTypes:\'application/x-zip-" +
"compressed\'},\r\n            fileNumLimit: maxcount\r\n        });\r\n\r\n        //文件大小" +
"限制,超过则不加入队列\r\n        uploader.on(\'beforeFileQueued\', function (file, han, msg) {" +
"\r\n            var xzlist = (\"xlsx,xls\").split(\",\");\r\n            var filenamelis" +
"t = file.name.split(\'.\');\r\n            var filehz = filenamelist[filenamelist.le" +
"ngth - 1];\r\n\r\n            if (xzlist.indexOf(filehz) < 0) {\r\n                lay" +
"er.alert(\"请上传指定类型格式的文件\", 0);\r\n                return false;\r\n            }\r\n\r\n  " +
"          if (file.size > (1024 * 1024 * 5)) {\r\n                layer.alert(\"文件大" +
"小不可超过5M\", 0);\r\n                return false;\r\n            }\r\n\r\n            var f" +
"ilelen = $(\"#filelist>li\").length;\r\n            if (filelen >= maxcount) {\r\n    " +
"            layer.alert(\"超出最大上传数量\", 0);\r\n                return false;\r\n        " +
"    }\r\n        });\r\n        //某个文件开始上传前触发，一个文件只会触发一次。\r\n        uploader.on(\'uplo" +
"adStart\', function (file) {\r\n            uploader.options.formData.guid = WebUpl" +
"oader.Base.guid();\r\n        });\r\n        // 当有文件添加进来的时候\r\n        uploader.on(\'fi" +
"leQueued\', function (file) {\r\n            $(\".help-file\").hide();\r\n            $" +
"(\".yangli\").hide()\r\n            $(\".yulan\").show();\r\n            uploader.makeTh" +
"umb(file, function (error, ret) {\r\n                var file_list = [];\r\n        " +
"        file_list.push(\"<li id=\'\" + file.id + \"\'>\");\r\n                file_list." +
"push(\"<em class=\'rar\'></em>\");\r\n                file_list.push(\"<span class=\'tit" +
"le\'><span/>\");\r\n                file_list.push(\"<div class=\'percent_small\'>\");\r\n" +
"                file_list.push(\"<div class=\'per_pic2\'>\");\r\n                file_" +
"list.push(\"<div class=\'change_per2\' style=\'width:1%\'></div>\");\r\n                " +
"file_list.push(\"</div>\");\r\n                file_list.push(\"<span class=\'showtitl" +
"e\'>正准备上传…</span></div>\");\r\n                file_list.push(\"</div></li>\");\r\n     " +
"           $(\"#filelist\").empty().append(file_list.join(\'\'));\r\n            });\r\n" +
"        });\r\n        //重置\r\n        uploader.on(\'reset\', function (file) {\r\n\r\n   " +
"     });\r\n        // 文件上传过程中创建进度条实时显示。\r\n        uploader.on(\'uploadProgress\', fu" +
"nction (file, percentage) {\r\n            var jd = parseInt(percentage * 100);\r\n " +
"           if (jd > 1) {\r\n                $(\"#\" + file.id).find(\".change_per2\")." +
"css(\"width\", jd + \'%\');\r\n                $(\"#\" + file.id).find(\".per_pic2,.showt" +
"itle\").attr(\"title\", \'已上传\' + jd + \'%\');\r\n                $(\"#\" + file.id).find(\"" +
".showtitle\").text(\'已上传\' + jd + \'%\');\r\n            }\r\n            if (jd >= 100) " +
"{\r\n                $(\"#\" + file.id).find(\".per_pic2,.showtitle\").attr(\"title\", \"" +
"处理中...\");\r\n            }\r\n            isfilesuping = uploader.getStats().progres" +
"sNum != 0;\r\n        });\r\n\r\n        uploader.on(\'uploadSuccess\', function (file, " +
"obj) {\r\n\r\n            isfilesuping = uploader.getStats().progressNum != 0;\r\n    " +
"        var jsonresult = obj._raw;\r\n            jsonresult = eval(\'(\' + jsonresu" +
"lt + \')\');\r\n            if (jsonresult.FileName) {\r\n                $(\"#\" + file" +
".id).find(\".showtitle\").text(\"\");\r\n                $(\"#\" + file.id).find(\"span.t" +
"itle\").html(jsonresult.FileName);\r\n                $(\"#filelist\").removeClass(\"h" +
"idden\");\r\n            } else {\r\n                $(\"#filelist\").addClass(\"hidden\"" +
");\r\n            }\r\n\r\n            if (!jsonresult.IsSuccess) {\r\n                i" +
"f (CheckIsNotNullOrEmpty(jsonresult.FilePath)) {\r\n                    top.layer." +
"open({\r\n                        type: 1,\r\n                        anim: 2,\r\n    " +
"                    shadeClose: true, //开启遮罩关闭\r\n                        content:" +
" \'<div  style=\"padding: 20px 60px 25px;\"   >\' + jsonresult.Message + \'</br><a st" +
"yle=\"color:#3bb4f2;display:inline-block;margin-top:5px\" href=\"\' + jsonresult.Fil" +
"ePath + \'\">点击此处下载失败数据<a/></div>\'\r\n                    });\r\n                } els" +
"e {\r\n                    top.layer.alert(jsonresult.Message, { icon: 8 });\r\n    " +
"            }\r\n            } else {\r\n                layer.msg(\"导入成功\");\r\n       " +
"     }\r\n\r\n            if (parent[1] != null) {\r\n                parent[pageIndex" +
"()].table1.ajax.reload();\r\n            } else {\r\n                parent.table1.a" +
"jax.reload();\r\n            }\r\n\r\n            uploader.reset();\r\n        });\r\n\r\n  " +
"      uploader.on(\'uploadError\', function (file, reason) {\r\n            layer.ms" +
"g(reason);\r\n        });\r\n        uploader.on(\'error\', function (handler) {\r\n    " +
"        if (handler == \"Q_EXCEED_NUM_LIMIT\") {\r\n                layer.alert(\"超出最" +
"大张数\");\r\n            }\r\n            if (handler == \"F_DUPLICATE\") {\r\n            " +
"    layer.alert(\"该文件已在上传列表\", 3);\r\n            }\r\n\r\n            if (handler == \"Q" +
"_TYPE_DENIED\") {\r\n                layer.alert(\"该文件不满足上传要求，可能您上传的文件为0KB\");\r\n     " +
"       }\r\n        });\r\n        uploader.on(\'uploadComplete\', function (file) {\r\n" +
"            $(\'#\' + file.id).find(\'.percent_small\').fadeOut();\r\n        });\r\n\r\n " +
"   });\r\n\r\n</script>");

        }
    }
}
#pragma warning restore 1591
