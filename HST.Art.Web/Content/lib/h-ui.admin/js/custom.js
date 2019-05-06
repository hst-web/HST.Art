/*自定义脚本*/

//去除字符串最后一个符号
function trimEnd(data) {
    if (data.length > 0) {
        return data.substr(0, data.length - 1);
    }

    return data;
}

//验证url地址
function IsURL(str_url) {
    var strRegex = "^(https?|ftp|file)://[-A-Za-z0-9+&@#/%?=~_|!:,.;]+[-A-Za-z0-9+&@#/%=~_|]$";
    var re = new RegExp(strRegex);
    if (re.test(str_url)) {
        return true;
    } else {
        return false;
    }
}

//验证邮箱
function validEmail(email) {
    return /^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$/.test(email);
}

//验证固话，手机号码，400热线合法返回true,反之,返回false
function IsTelephone(value) {
    var isPhone = /^([0-9]{3,4}-)?[0-9]{7,8}$/;
    var isMob = /^((\+?86)|(\(\+86\)))?(13[012356789][0-9]{8}|15[012356789][0-9]{8}|18[02356789][0-9]{8}|147[0-9]{8}|1349[0-9]{7})$/;
    var isServer = /^400[016789]\d{6}$/;
    if (isMob.test(value) || isPhone.test(value) || isServer.test(value)) {
        return true;
    }
    else {
        return false;
    }
}

//初始化check、radio样式
function initUniform() {
    if (!$().uniform) {
        return;
    }
    var uncheck = $("input[type=checkbox]:not(.toggle,.magic-checkbox, .md-check, .md-radiobtn, .make-switch, .icheck), input[type=radio]:not(.toggle, .md-check, .md-radiobtn, .star, .make-switch, .icheck)");
    if (uncheck.size() > 0) {
        uncheck.each(function () {
            if ($(this).parents(".checker").size() === 0) {
                $(this).show();
                $(this).uniform();
            }
        });
    }
}

//字符串处理
function StringBuffer(str) {
    var arr = [];
    str = str || "";
    var size = 0;  // 存放数组大小
    arr.push(str);
    // 追加字符串
    this.append = function (str1) {
        arr.push(str1);
        return this;
    };
    // 返回字符串
    this.toString = function () {
        return arr.join("");
    };
    // 清空
    this.clear = function (key) {
        size = 0;
        arr = [];
    }
    // 返回数组大小
    this.size = function () {
        return size;
    }
    // 返回数组
    this.toArray = function () {
        return buffer;
    }
    // 倒序返回字符串
    this.doReverse = function () {
        var str = buffer.join('');
        str = str.split('');
        return str.reverse().join('');
    }
};


//改变数量
function changecount(input, type, min) {
    var ex = /^\d+$/;
    if (type > 1) {
        ex = /^[0-9]+([.]{1}[0-9]{1,2})?$/;
    }

    if ($(input).val() < min || !ex.test($(input).val())) {
        $(input).val("" + min + "");
    }
}


function showLoading() {
    $(".dataTables_processing").attr("style", "display:block")
}


function hideLoading() {
    $(".dataTables_processing").attr("style", "display: none;")
}

function showException() {
    layer.alert('操作数据请求失败，请稍后再试', { icon: 2 });
}

   function disSubmit(id,title) {
        title = title || "正在提交...";
        var obj = $("#" + id);
        var hisVal = "";
        if (obj[0].tagName.toLowerCase()=="input") {
            hisVal = obj.val();
            obj.val(title).css("opacity", "0.7").attr("disabled", "disabled");
        } else {
            hisVal = obj.html();
            obj.html(title).css("opacity", "0.7").attr("disabled", "disabled");
        }

        obj.attr("data-bind", hisVal);
    }

    function enSubmit(id,title) {
        var obj = $("#" + id);
        var hisVal=obj.attr("data-bind");
        title = title || hisVal;
        if (obj[0].tagName.toLowerCase()=="input") {
            obj.val(title).removeAttr("style").removeAttr("disabled");
        } else {
            obj.html(title).removeAttr("style").removeAttr("disabled");
        }
    }
