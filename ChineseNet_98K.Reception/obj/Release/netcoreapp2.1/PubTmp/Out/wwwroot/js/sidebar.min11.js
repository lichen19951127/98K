/* zongheng PC 2018 Copyright (c) 2018 (zongheng FETEAM) lastUpdate: 2018-10-12 16:01:36*/
require(["jquery"],function(e){var i=document.getElementsByTagName("body")[0].getAttribute("scriptSign");if(0===e("#zh_sidebar").length&&"chapter"!=i&&"chapterflow"!=i){function a(e){var i=31536e3;e||(i=0),CookieUtil.setCookie({name:"lang",value:"zht",path:"/",domain:".zongheng.com",expires:i}),location.reload()}var t=[];t[t.length]='<div id="zh_sidebar" class="sidebar">',"feedback"!==e("body").attr("scriptSign")&&(t[t.length]='<div id="zh_side_feedback" class="side_feedback"><a href="//www.zongheng.com/feedback?backUrl='+encodeURIComponent(location.href)+'" target="_blank">意见<br>反馈</a></div>'),"zht"===CookieUtil.getCookie("lang")?t[t.length]='<div id="zh_side_ls" class="side_zhs"><a href="javascript:void(0);" data-lang="zhs"></a></div>':t[t.length]='<div id="zh_side_lt" class="side_zht"><a href="javascript:void(0);" data-lang="zht"></a></div>',t[t.length]='<div class="sidekf"><a href="https://ikefu.baidu.com/web/zongheng" target="_blank"></a></div>',t[t.length]='<div class="returntop"><a href="javascript:;"></a></div>',t[t.length]="</div>",e("body").append(t.join("")),e("#zh_side_ls").click(function(){a(0)}),e("#zh_side_lt").click(function(){a(1)}),e("#zh_sidebar .returntop a").click(function(){e("body,html").animate({scrollTop:0},500)}),e(window).bind("scroll",function(){500<e(document).scrollTop()?e("#zh_sidebar .returntop").fadeIn():e("#zh_sidebar .returntop").fadeOut()}),e(window).resize(function(){1300<e(window).width()?e("#zh_sidebar").css({right:"50%","margin-right":"-650px"}):e("#zh_sidebar").css({right:"5px","margin-right":"auto"})})}});
