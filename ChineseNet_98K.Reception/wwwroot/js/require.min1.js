var requirejs, require, define;
!function (Y) {
    function I(e) {
        return "[object Function]" === L.call(e)
    }
    function J(e) {
        return "[object Array]" === L.call(e)
    }
    function x(e, t) {
        if (e) {
            var i; for (i = 0; i < e.length && (!e[i] || !t(e[i], i, e)); i += 1);
        }
    }
    function M(e, t) {
        if (e) {
            var i; for (i = e.length - 1; i > -1 && (!e[i] || !t(e[i], i, e)); i -= 1);
        }
    }
    function r(e, t) {
        return da.call(e, t)
    }
    function i(e, t) {
        return r(e, t) && e[t]
    }
    function E(e, t) {
        for (var i in e)
            if (r(e, i) && t(e[i], i))
                break
    }
    function Q(e, t, i, n) {
        return t && E(t, function (t, o) {
            (i || !r(e, o)) && (n && "string" != typeof t ? (e[o] || (e[o] = {}), Q(e[o], t, i, n)) : e[o] = t)
        }), e
    }
    function t(e, t) {
        return function () {
            return t.apply(e, arguments)
        }
    }
    function Z(e) {
        if (!e)
            return e;
        var t = Y;
        return x(e.split("."), function (e) {
            t = t[e]
        }), t
    }
    function F(e, t, i, n) {
        return t = Error(t + "\nhttp://requirejs.org/docs/errors.html#" + e), t.requireType = e, t.requireModules = n, i && (t.originalError = i), t
    }
    function ea(e) {
        function n(e, t, n) {
            var r, o, a, s, u, d, c, l = t && t.split("/"); r = l;
            var f = j.map, p = f && f["*"];
            if (e && "." === e.charAt(0))
                if (t) {
                    for (r = i(j.pkgs, t) ? l = [t] : l.slice(0, l.length - 1), t = e = r.concat(e.split("/")), r = 0; t[r]; r += 1)
                        if (o = t[r], "." === o) t.splice(r, 1), r -= 1;
                        else if (".." === o) {
                            if (1 === r && (".." === t[2] || ".." === t[0]))
                                break;
                            r > 0 && (t.splice(r - 1, 2), r -= 2)
                        } r = i(j.pkgs, t = e[0]), e = e.join("/"), r && e === t + "/" + r.main && (e = t)
                } else 0 === e.indexOf("./") && (e = e.substring(2));
            if (n && (l || p) && f) {
                for (t = e.split("/"), r = t.length; r > 0; r -= 1) {
                    if (a = t.slice(0, r).join("/"), l)
                        for (o = l.length; o > 0; o -= 1)
                            if ((n = i(f, l.slice(0, o).join("/"))) && (n = i(n, a))) { s = n, u = r; break }
                    if (s) break;
                    !d && p && i(p, a) && (d = i(p, a), c = r)
                } !s && d && (s = d, u = c), s && (t.splice(0, u, s), e = t.join("/"))
            } return e
        }
        function o(e) {
            z && x(document.getElementsByTagName("script"), function (t) {
                return t.getAttribute("data-requiremodule") === e && t.getAttribute("data-requirecontext") === k.contextName ? (t.parentNode.removeChild(t), !0) : void 0
            })
        }
        function a(e) {
            var t = i(j.paths, e);
            return t && J(t) && 1 < t.length ? (o(e), t.shift(), k.require.undef(e), k.require([e]), !0) : void 0
        }
        function s(e) {
            var t, i = e ? e.indexOf("!") : -1;
            return i > -1 && (t = e.substring(0, i), e = e.substring(i + 1, e.length)), [t, e]
        }
        function u(e, t, r, o) {
            var a, u, d = null, c = t ? t.name : null, l = e, f = !0, p = ""; return e || (f = !1, e = "_@r" + (D += 1)), e = s(e), d = e[0], e = e[1], d && (d = n(d, c, o), u = i(B, d)), e && (d ? p = u && u.normalize ? u.normalize(e, function (e) { return n(e, c, o) }) : n(e, c, o) : (p = n(e, c, o), e = s(p), d = e[0], p = e[1], r = !0, a = k.nameToUrl(p))), r = !d || u || r ? "" : "_unnormalized" + (A += 1), { prefix: d, name: p, parentMap: t, unnormalized: !!r, url: a, originalName: l, isDefine: f, id: (d ? d + "!" + p : p) + r }
        }
        function d(e) {
            var t = e.id, n = i(w, t); return n || (n = w[t] = new k.Module(e)), n
        }
        function c(e, t, n) {
            var o = e.id, a = i(w, o); !r(B, o) || a && !a.defineEmitComplete ? d(e).on(t, n) : "defined" === t && n(B[o])
        }
        function f(e, t) {
            var n = e.requireModules, r = !1; t ? t(e) : (x(n, function (t) { (t = i(w, t)) && (t.error = e, t.events.error && (r = !0, t.emit("error", e))) }), r || l.onError(e))
        }
        function p() {
            R.length && (fa.apply(C, [C.length - 1, 0].concat(R)), R = [])
        }
        function h(e, t, n) {
            var r = e.map.id; e.error ? e.emit("error", e.error) : (t[r] = !0, x(e.depMaps, function (r, o) { var a = r.id, s = i(w, a); s && !e.depMatched[o] && !n[a] && (i(t, a) ? (e.defineDep(o, B[a]), e.check()) : h(s, t, n)) }), n[r] = !0)
        }
        function m() {
            var e, t, i, n, r = (i = 1e3 * j.waitSeconds) && k.startTime + i < (new Date).getTime(), s = [], u = [], d = !1, c = !0; if (!q) { if (q = !0, E(w, function (i) { if (e = i.map, t = e.id, i.enabled && (e.isDefine || u.push(i), !i.error)) if (!i.inited && r) a(t) ? d = n = !0 : (s.push(t), o(t)); else if (!i.inited && i.fetched && e.isDefine && (d = !0, !e.prefix)) return c = !1 }), r && s.length) return i = F("timeout", "Load timeout for modules: " + s, null, s), i.contextName = k.contextName, f(i); c && x(u, function (e) { h(e, {}, {}) }), r && !n || !d || !z && !$ || T || (T = setTimeout(function () { T = 0, m() }, 50)), q = !1 }
        }
        function g(e) {
            r(B, e[0]) || d(u(e[0], null, !0)).init(e[1], e[2])
        }
        function v(e) {
            var e = e.currentTarget || e.srcElement, t = k.onScriptLoad; return e.detachEvent && !V ? e.detachEvent("onreadystatechange", t) : e.removeEventListener("load", t, !1), t = k.onScriptError, (!e.detachEvent || V) && e.removeEventListener("error", t, !1), { node: e, id: e && e.getAttribute("data-requiremodule") }
        }
        function b() {
            var e; for (p(); C.length;) { if (e = C.shift(), null === e[0]) return f(F("mismatch", "Mismatched anonymous define() module: " + e[e.length - 1])); g(e) }
        }
        var q, y, k, M, T, j = { waitSeconds: 7, baseUrl: "./", paths: {}, pkgs: {}, shim: {}, map: {}, config: {} }, w = {}, S = {}, C = [], B = {}, L = {}, D = 1, A = 1;
        return M = { require: function (e) { return e.require ? e.require : e.require = k.makeRequire(e.map) }, exports: function (e) { return e.usingExports = !0, e.map.isDefine ? e.exports ? e.exports : e.exports = B[e.map.id] = {} : void 0 }, module: function (e) { return e.module ? e.module : e.module = { id: e.map.id, uri: e.map.url, config: function () { return j.config && i(j.config, e.map.id) || {} }, exports: B[e.map.id] } } }, y = function (e) { this.events = i(S, e.id) || {}, this.map = e, this.shim = i(j.shim, e.id), this.depExports = [], this.depMaps = [], this.depMatched = [], this.pluginMaps = {}, this.depCount = 0 }, y.prototype = { init: function (e, i, n, r) { r = r || {}, this.inited || (this.factory = i, n ? this.on("error", n) : this.events.error && (n = t(this, function (e) { this.emit("error", e) })), this.depMaps = e && e.slice(0), this.errback = n, this.inited = !0, this.ignore = r.ignore, r.enabled || this.enabled ? this.enable() : this.check()) }, defineDep: function (e, t) { this.depMatched[e] || (this.depMatched[e] = !0, this.depCount -= 1, this.depExports[e] = t) }, fetch: function () { if (!this.fetched) { this.fetched = !0, k.startTime = (new Date).getTime(); var e = this.map; if (!this.shim) return e.prefix ? this.callPlugin() : this.load(); k.makeRequire(this.map, { enableBuildCallback: !0 })(this.shim.deps || [], t(this, function () { return e.prefix ? this.callPlugin() : this.load() })) } }, load: function () { var e = this.map.url; L[e] || (L[e] = !0, k.load(this.map.id, e)) }, check: function () { if (this.enabled && !this.enabling) { var e, t, i = this.map.id; t = this.depExports; var n = this.exports, r = this.factory; if (this.inited) { if (this.error) this.emit("error", this.error); else if (!this.defining) { if (this.defining = !0, 1 > this.depCount && !this.defined) { if (I(r)) { if (this.events.error) try { n = k.execCb(i, r, t, n) } catch (o) { e = o } else n = k.execCb(i, r, t, n); if (this.map.isDefine && ((t = this.module) && void 0 !== t.exports && t.exports !== this.exports ? n = t.exports : void 0 === n && this.usingExports && (n = this.exports)), e) return e.requireMap = this.map, e.requireModules = [this.map.id], e.requireType = "define", f(this.error = e) } else n = r; this.exports = n, this.map.isDefine && !this.ignore && (B[i] = n, l.onResourceLoad) && l.onResourceLoad(k, this.map, this.depMaps), delete w[i], this.defined = !0 } this.defining = !1, this.defined && !this.defineEmitted && (this.defineEmitted = !0, this.emit("defined", this.exports), this.defineEmitComplete = !0) } } else this.fetch() } }, callPlugin: function () { var e = this.map, o = e.id, a = u(e.prefix); this.depMaps.push(a), c(a, "defined", t(this, function (a) { var s, p; p = this.map.name; var h = this.map.parentMap ? this.map.parentMap.name : null, m = k.makeRequire(e.parentMap, { enableBuildCallback: !0 }); this.map.unnormalized ? (a.normalize && (p = a.normalize(p, function (e) { return n(e, h, !0) }) || ""), a = u(e.prefix + "!" + p, this.map.parentMap), c(a, "defined", t(this, function (e) { this.init([], function () { return e }, null, { enabled: !0, ignore: !0 }) })), (p = i(w, a.id)) && (this.depMaps.push(a), this.events.error && p.on("error", t(this, function (e) { this.emit("error", e) })), p.enable())) : (s = t(this, function (e) { this.init([], function () { return e }, null, { enabled: !0 }) }), s.error = t(this, function (e) { this.inited = !0, this.error = e, e.requireModules = [o], E(w, function (e) { 0 === e.map.id.indexOf(o + "_unnormalized") && delete w[e.map.id] }), f(e) }), s.fromText = t(this, function (t, i) { var n = e.name, a = u(n), c = O; i && (t = i), c && (O = !1), d(a), r(j.config, o) && (j.config[n] = j.config[o]); try { l.exec(t) } catch (p) { return f(F("fromtexteval", "fromText eval for " + o + " failed: " + p, p, [o])) } c && (O = !0), this.depMaps.push(a), k.completeLoad(n), m([n], s) }), a.load(e.name, m, s, j)) })), k.enable(a, this), this.pluginMaps[a.id] = a }, enable: function () { this.enabling = this.enabled = !0, x(this.depMaps, t(this, function (e, n) { var o, a; if ("string" == typeof e) { if (e = u(e, this.map.isDefine ? this.map : this.map.parentMap, !1, !this.skipMap), this.depMaps[n] = e, o = i(M, e.id)) return void (this.depExports[n] = o(this)); this.depCount += 1, c(e, "defined", t(this, function (e) { this.defineDep(n, e), this.check() })), this.errback && c(e, "error", this.errback) } o = e.id, a = w[o], !r(M, o) && a && !a.enabled && k.enable(e, this) })), E(this.pluginMaps, t(this, function (e) { var t = i(w, e.id); t && !t.enabled && k.enable(e, this) })), this.enabling = !1, this.check() }, on: function (e, t) { var i = this.events[e]; i || (i = this.events[e] = []), i.push(t) }, emit: function (e, t) { x(this.events[e], function (e) { e(t) }), "error" === e && delete this.events[e] } }, k = { config: j, contextName: e, registry: w, defined: B, urlFetched: L, defQueue: C, Module: y, makeModuleMap: u, nextTick: l.nextTick, configure: function (e) { e.baseUrl && "/" !== e.baseUrl.charAt(e.baseUrl.length - 1) && (e.baseUrl += "/"); var t = j.pkgs, i = j.shim, n = { paths: !0, config: !0, map: !0 }; E(e, function (e, t) { n[t] ? "map" === t ? Q(j[t], e, !0, !0) : Q(j[t], e, !0) : j[t] = e }), e.shim && (E(e.shim, function (e, t) { J(e) && (e = { deps: e }), !e.exports && !e.init || e.exportsFn || (e.exportsFn = k.makeShimExports(e)), i[t] = e }), j.shim = i), e.packages && (x(e.packages, function (e) { e = "string" == typeof e ? { name: e } : e, t[e.name] = { name: e.name, location: e.location || e.name, main: (e.main || "main").replace(ga, "").replace(aa, "") } }), j.pkgs = t), E(w, function (e, t) { !e.inited && !e.map.unnormalized && (e.map = u(t)) }), (e.deps || e.callback) && k.require(e.deps || [], e.callback) }, makeShimExports: function (e) { return function () { var t; return e.init && (t = e.init.apply(Y, arguments)), t || e.exports && Z(e.exports) } }, makeRequire: function (t, o) { function a(i, n, s) { var c, p; return o.enableBuildCallback && n && I(n) && (n.__requireJsBuild = !0), "string" == typeof i ? I(n) ? f(F("requireargs", "Invalid require call"), s) : t && r(M, i) ? M[i](w[t.id]) : l.get ? l.get(k, i, t) : (c = u(i, t, !1, !0), c = c.id, r(B, c) ? B[c] : f(F("notloaded", 'Module name "' + c + '" has not been loaded yet for context: ' + e + (t ? "" : ". Use require([])")))) : (b(), k.nextTick(function () { b(), p = d(u(null, t)), p.skipMap = o.skipMap, p.init(i, n, s, { enabled: !0 }), m() }), a) } return o = o || {}, Q(a, { isBrowser: z, toUrl: function (e) { var i, r = e.lastIndexOf("."), o = e.split("/")[0]; return -1 !== r && ("." !== o && ".." !== o || r > 1) && (i = e.substring(r, e.length), e = e.substring(0, r)), e = k.nameToUrl(n(e, t && t.id, !0), i || ".fake"), i ? e : e.substring(0, e.length - 5) }, defined: function (e) { return r(B, u(e, t, !1, !0).id) }, specified: function (e) { return e = u(e, t, !1, !0).id, r(B, e) || r(w, e) } }), t || (a.undef = function (e) { p(); var n = u(e, t, !0), r = i(w, e); delete B[e], delete L[n.url], delete S[e], r && (r.events.defined && (S[e] = r.events), delete w[e]) }), a }, enable: function (e) { i(w, e.id) && d(e).enable() }, completeLoad: function (e) { var t, n, o = i(j.shim, e) || {}, s = o.exports; for (p(); C.length;) { if (n = C.shift(), null === n[0]) { if (n[0] = e, t) break; t = !0 } else n[0] === e && (t = !0); g(n) } if (n = i(w, e), !t && !r(B, e) && n && !n.inited) { if (j.enforceDefine && (!s || !Z(s))) return a(e) ? void 0 : f(F("nodefine", "No define call for " + e, null, [e])); g([e, o.deps || [], o.exportsFn]) } m() }, nameToUrl: function (e, t) { var n, r, o, a, s, u; if (l.jsExtRegExp.test(e)) a = e + (t || ""); else { for (n = j.paths, r = j.pkgs, a = e.split("/"), s = a.length; s > 0; s -= 1) { if (u = a.slice(0, s).join("/"), o = i(r, u), u = i(n, u)) { J(u) && (u = u[0]), a.splice(0, s, u); break } if (o) { n = e === o.name ? o.location + "/" + o.main : o.location, a.splice(0, s, n); break } } a = a.join("/"), a += t || (/\?/.test(a) ? "" : ".js"), a = ("/" === a.charAt(0) || a.match(/^[\w\+\.\-]+:/) ? "" : j.baseUrl) + a } return j.urlArgs ? a + ((-1 === a.indexOf("?") ? "?" : "&") + j.urlArgs) : a }, load: function (e, t) { l.load(k, e, t) }, execCb: function (e, t, i, n) { return t.apply(n, i) }, onScriptLoad: function (e) { ("load" === e.type || ha.test((e.currentTarget || e.srcElement).readyState)) && (P = null, e = v(e), k.completeLoad(e.id)) }, onScriptError: function (e) { var t = v(e); return a(t.id) ? void 0 : f(F("scripterror", "Script error", e, [t.id])) } }, k.require = k.makeRequire(), k
    } var l, w, B, D, s, H, P, K, ba, ca, ia = /(\/\*([\s\S]*?)\*\/|([^:]|^)\/\/(.*)$)/gm, ja = /[^.]\s*require\s*\(\s*["']([^'"\s]+)["']\s*\)/g, aa = /\.js$/, ga = /^\.\//; w = Object.prototype; var L = w.toString, da = w.hasOwnProperty, fa = Array.prototype.splice, z = !("undefined" == typeof window || !navigator || !document), $ = !z && "undefined" != typeof importScripts, ha = z && "PLAYSTATION 3" === navigator.platform ? /^complete$/ : /^(complete|loaded)$/, V = "undefined" != typeof opera && "[object Opera]" === opera.toString(), C = {}, q = {}, R = [], O = !1;
    if ("undefined" == typeof define) {
        if ("undefined" != typeof requirejs) {
            if (I(requirejs)) return; q = requirejs, requirejs = void 0
        } "undefined" != typeof require && !I(require) && (q = require, require = void 0), l = requirejs = function (e, t, n, r) {
            var o, a = "_";
            return !J(e) && "string" != typeof e && (o = e, J(t) ? (e = t, t = n, n = r) : e = []), o && o.context && (a = o.context), (r = i(C, a)) || (r = C[a] = l.s.newContext(a)), o && r.configure(o), r.require(e, t, n)
        }, l.config = function (e) {
            return l(e)
        }, l.nextTick = "undefined" != typeof setTimeout ? function (e) {
            setTimeout(e, 4)
        } : function (e) {
            e()
        }, require || (require = l), l.version = "2.1.4", l.jsExtRegExp = /^\/|:|\?|\.js$/, l.isBrowser = z, w = l.s = { contexts: C, newContext: ea }, l({}), x(["toUrl", "undef", "defined", "specified"], function (e) {
            l[e] = function () {
                var t = C._; return t.require[e].apply(t, arguments)
            }
        }), z && (B = w.head = document.getElementsByTagName("head")[0], D = document.getElementsByTagName("base")[0]) && (B = w.head = D.parentNode), l.onError = function (e) {
            throw e
        }, l.load = function (e, t, i) {
            var n, r = e && e.config || {};
            return z ? (n = r.xhtml ? document.createElementNS("http://www.w3.org/1999/xhtml", "html:script") : document.createElement("script"), n.type = r.scriptType || "text/javascript", n.charset = "utf-8", n.async = !0, n.setAttribute("data-requirecontext", e.contextName), n.setAttribute("data-requiremodule", t), !n.attachEvent || n.attachEvent.toString && 0 > n.attachEvent.toString().indexOf("[native code") || V ? (n.addEventListener("load", e.onScriptLoad, !1), n.addEventListener("error", e.onScriptError, !1)) : (O = !0, n.attachEvent("onreadystatechange", e.onScriptLoad)), n.src = i, K = n, D ? B.insertBefore(n, D) : B.appendChild(n), K = null, n) : void ($ && (importScripts(i), e.completeLoad(t)))
        }, z && M(document.getElementsByTagName("script"), function (e) {
            return B || (B = e.parentNode), (s = e.getAttribute("data-main")) ? (q.baseUrl || (H = s.split("/"), ba = H.pop(), ca = H.length ? H.join("/") + "/" : "./", q.baseUrl = ca, s = ba), s = s.replace(aa, ""), q.deps = q.deps ? q.deps.concat(s) : [s], !0) : void 0
        }), define = function (e, t, i) {
            var n, r; "string" != typeof e && (i = t, t = e, e = null), J(t) || (i = t, t = []), !t.length && I(i) && i.length && (i.toString().replace(ia, "").replace(ja, function (e, i) {
                t.push(i)
            }), t = (1 === i.length ? ["require"] : ["require", "exports", "module"]).concat(t)), O && ((n = K) || (P && "interactive" === P.readyState || M(document.getElementsByTagName("script"), function (e) {
                return "interactive" === e.readyState ? P = e : void 0
            }), n = P), n && (e || (e = n.getAttribute("data-requiremodule")), r = C[n.getAttribute("data-requirecontext")])), (r ? r.defQueue : R).push([e, t, i])
        }, define.amd = { jQuery: !0 }, l.exec = function (b) { return eval(b) }, l(q)
    }
}(this);