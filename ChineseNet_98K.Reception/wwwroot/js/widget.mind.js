/* zongheng PC 2018 Copyright (c) 2018 (zongheng FETEAM) lastUpdate: 2018-08-13 16:35:44*/
define(["jquery"],function(c){var a={options:{zIndex:9e5,Messagers:[],tabIds:[]},setPos:function(i,t){t.height||(t.height=i.height()),t.width||(t.width=i.width()),i.css({width:t.width+"px",height:t.height+"px","margin-left":-t.width/2+"px","margin-top":-t.height/2+"px"})},open:function(i){i.css({zIndex:this.options.zIndex}).addClass("popin").removeClass("popout").show(),this.options.zIndex++},close:function(i){i.removeClass("popin").addClass("popout"),setTimeout(function(){i.hide()},350)},destroy:function(i){i.remove()},deepclose:function(i){i.removeClass("popin").addClass("popout"),setTimeout(function(){i.remove()},300)}},t=function(i){var t=this;t.id="ui_widget_toast_"+(new Date).getTime(),t.options={txt:"操作成功",time:3e3,mask:!1},"string"==typeof i?t.options.txt=i:t.options=c.extend(o,i);var o=t.options,s=[];s[s.length]='<div id="'+t.id,!0===o.mask?(s[s.length]='" class="ui_widget_section">',s[s.length]='<div class="ui_shadow"></div>'):s[s.length]='" class="ui_toast_section">',s[s.length]='<div class="ui_toast">'+o.txt+"</div>",s[s.length]="</div>",c("body").append(s.join("")),this.dom=c("#"+t.id),this.win=this.dom.find(".ui_toast"),a.open(this.dom),a.setPos(t.win,o),o.onShow&&(o.onShow,1)&&o.onShow(),t.km=setTimeout(function(){a.deepclose(t.dom),o.onHide&&"function"==typeof o.onHide&&o.onHide()},o.time)},e=function(i){var o=this;o.id="ui_widget_message_"+(new Date).getTime();var t={id:o.id,tit:"提示",con:"是否确定此操作",cancel:!1,close:!1,confirmTxt:"确定",cancelTxt:"取消",showbtn:!0,buttons:[],tip:0,tipinfo:0};"string"!=typeof i?this.options=c.extend(t,i):(this.options=t,this.options.con=i);var s=[];s[s.length]='<div id="'+this.id+'" class="ui_widget_section">',s[s.length]='<div class="ui_shadow"></div><div class="ui_widget_box brds">',s[s.length]='<div class="ui_widget_tit">'+this.options.tit+"</div>",s[s.length]='<div class="ui_widget_con clearfix">',this.options.html&&"string"==typeof this.options.html?s[s.length]=this.options.html:(s[s.length]='    <div class="ui_widget_contxt">',s[s.length]='        <p class="contit">'+this.options.con+"</p>",0!==this.options.tip&&(s[s.length]='        <p class="concon">'+this.options.tip+"</p>"),s[s.length]="    </div>"),!0===this.options.showbtn&&(s[s.length]='    <div class="ui_widget_conbtn clearfix">',s[s.length]='        <button class="confirm" id="'+this.id+'_confirm" data-cb="confirm">'+this.options.confirmTxt+"</button>",this.options.buttons.push("confirm"),!0===this.options.cancel&&(s[s.length]='        <button class="cancel" id="'+this.id+'_cancel" data-cb="cancel">'+this.options.cancelTxt+"</button>",this.options.buttons.push("cancel")),s[s.length]="    </div>"),s[s.length]="</div>",!0===this.options.close&&(s[s.length]='<div class="ui_widget_close" id="'+this.id+'_close" data-cb="close"></div>',this.options.buttons.push("close")),s[s.length]="</div></div></div>",c("body").append(s.join("")),this.dom=c("#"+o.id),this.win=this.dom.find(".ui_widget_box"),o.close=function(){a.deepclose(this.dom)},o.loading=function(){return c("#"+o.id+"_confirm").addClass("unclick").removeClass("confirm").unbind("click"),c("#"+o.id+"_cancel").addClass("unclick").removeClass("cancel").unbind("click"),!0};var n=this.options.buttons;if(0<n.length){function e(i,t){c("#"+o.id+"_"+i).unbind().click(function(){noclose=t.call(o),!0!==noclose&&o.close()})}for(var d=0;d<n.length;d++)i.cb&&"function"==typeof i.cb[n[d]]?e(n[d],i.cb[n[d]]):e(n[d],o.close)}this.options.beforeOpen&&"function"==typeof this.options.beforeOpen&&this.options.beforeOpen.call(o),a.open(c("#"+o.id)),a.setPos(this.win,this.options)};e.prototype.close=function(){a.deepclose(this.dom)};var i=function(i){var t=this;t.id=i.id||"ui_widget_cus_"+(new Date).getTime();var o={id:t.id,tit:"是否继续",close:!0,header:!0};"string"!=typeof i?this.options=c.extend(o,i):(this.options=o,this.options.con=i);var s=[];s[s.length]='<div id="'+this.id+'" class="ui_widget_section">',s[s.length]='<div class="ui_shadow"></div>',!(s[s.length]='<div class="ui_widget_box">')!==this.options.header&&(s[s.length]='<div class="ui_widget_tit">'+this.options.tit+"</div>"),s[s.length]='<div class="ui_widget_con clearfix">',s[s.length]=this.options.html,!(s[s.length]="</div>")!==this.options.close&&(s[s.length]='<div class="ui_widget_close" id="'+this.id+'_close" data-cb="close"></div>'),s[s.length]='<div class="ui_widget_customloading"></div></div></div></div>',c("body").append(s.join("")),this.dom=c("#"+t.id),this.win=this.dom.find(".ui_widget_box"),this.win.find(".ui_widget_close").click(function(){t.close(this.dom)})};i.prototype={open:function(){a.open(this.dom),a.setPos(this.win,this.options)},loading:function(i){!0===i?this.dom.find(".ui_widget_customloading").show():this.dom.find(".ui_widget_customloading").hide()},close:function(){a.close(this.dom)},destroy:function(){a.destroy(this.dom)}};var o=function(i){var t=this;t.options={close:!0,width:572,height:416},this.id=i.id,a.options.tabIds.toString().indexOf(i.id)<0&&a.options.tabIds.push(i.id);var o=c.extend(this.options,i),s="<div id="+i.id+' class="ui_widget_section"><div class="ui_shadow"></div><div class="ui_widget_box"><div class="ui_widget_tab"></div><div class="ui_widget_tab_con"></div><div class="ui_widget_close"></div><div class="ui_widget_tabloading"></div></div></div>';c("body").append(s),this.dom=c("#"+o.id),this.win=this.dom.find(".ui_widget_box"),this.tabTit=this.win.find(".ui_widget_tab"),this.tabCon=this.win.find(".ui_widget_tab_con"),a.setPos(this.win,this.options);for(var n=0;n<o.tab.length;n++)this.tabTit.append("<span>"+o.tab[n]+"</span>"),this.tabCon.append("<div>"+o.con[n]+"</div>");o.defaultTab&&this.win.attr("data-tabIndex",o.defaultTab),this.tabTit.children("span").bind("click",function(){var i=c(this).index();t["switch"](i)}),this["switch"]=function(i){var t=this.tabTit.children("span").eq(i);this.tabTit.children("span").eq(i).addClass("active").siblings().removeClass("active"),this.tabCon.children("div").eq(i).show().siblings().hide(),o.onTab&&o.onTab[i+1]&&"function"==typeof o.onTab[i+1]&&0!=t.attr("data-status")&&o.onTab[i+1].call(o)},this.tabSwitch=function(i,t){if(i&&!isNaN(i)){var o=this.tabTit.children("span").eq(i-1);t?o.attr("data-status",t):0!=o.attr("data-status")?o.attr("data-status",0):o.attr("data-status",1)}},o.close||this.win.find(".ui_widget_close").hide(),this.win.find(".ui_widget_close").click(function(){t.close(this.dom)}),o.init&&"function"==typeof o.init&&o.init.call(this)};return o.prototype={open:function(i){i&&!isNaN(i)?i--:i=0,this["switch"](i),this.options&&this.options.opencb&&"function"==typeof this.options.opencb&&this.options.opencb.call(this),a.open(this.dom)},loading:function(i){!0===i?this.dom.find(".ui_widget_tabloading").show():this.dom.find(".ui_widget_tabloading").hide()},close:function(){a.close(this.dom)},destroy:function(){a.destroy(this.dom)}},{Tab:o,Alert:function(i,t,o){var s={cb:{}};i&&"string"==typeof i&&(s.con=i),t&&"string"==typeof t&&(s.tip=t);var n=arguments[arguments.length-1];return"function"==typeof n&&(s.cb.confirm=n),"object"==typeof n&&(s=c.extend(s,n)),new e(s)},Toast:function(i){return new t(i)},Custom:i,Confirm:function(i,t,o){var s={cancel:!0,cb:{}};i&&"string"==typeof i&&(s.con=i),t&&"string"==typeof t&&(s.tip=t);var n=arguments[arguments.length-1];return"function"==typeof n&&(s.cb.confirm=n),"object"==typeof n&&(s=c.extend(s,n)),new e(s)}}});