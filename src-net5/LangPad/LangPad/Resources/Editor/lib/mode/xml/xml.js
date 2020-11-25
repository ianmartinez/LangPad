'use strict';(function(g){"object"==typeof exports&&"object"==typeof module?g(require("../../lib/codemirror")):"function"==typeof define&&define.amd?define(["../../lib/codemirror"],g):g(CodeMirror)})(function(g){var D={autoSelfClosers:{area:!0,base:!0,br:!0,col:!0,command:!0,embed:!0,frame:!0,hr:!0,img:!0,input:!0,keygen:!0,link:!0,meta:!0,param:!0,source:!0,track:!0,wbr:!0,menuitem:!0},implicitlyClosed:{dd:!0,li:!0,optgroup:!0,option:!0,p:!0,rp:!0,rt:!0,tbody:!0,td:!0,tfoot:!0,th:!0,tr:!0},contextGrabbers:{dd:{dd:!0,
dt:!0},dt:{dd:!0,dt:!0},li:{li:!0},option:{option:!0,optgroup:!0},optgroup:{optgroup:!0},p:{address:!0,article:!0,aside:!0,blockquote:!0,dir:!0,div:!0,dl:!0,fieldset:!0,footer:!0,form:!0,h1:!0,h2:!0,h3:!0,h4:!0,h5:!0,h6:!0,header:!0,hgroup:!0,hr:!0,menu:!0,nav:!0,ol:!0,p:!0,pre:!0,section:!0,table:!0,ul:!0},rp:{rp:!0,rt:!0},rt:{rp:!0,rt:!0},tbody:{tbody:!0,tfoot:!0},td:{td:!0,th:!0},tfoot:{tbody:!0},th:{td:!0,th:!0},thead:{tbody:!0,tfoot:!0},tr:{tr:!0}},doNotIndent:{pre:!0},allowUnquoted:!0,allowMissing:!0,
caseFold:!0},E={autoSelfClosers:{},implicitlyClosed:{},contextGrabbers:{},doNotIndent:{},allowUnquoted:!1,allowMissing:!1,allowMissingTagName:!1,caseFold:!1};g.defineMode("xml",function(p,r){function k(a,c){function b(b){c.tokenize=b;return b(a,c)}var d=a.next();if("<"==d){if(a.eat("!"))return a.eat("[")?a.match("CDATA[")?b(t("atom","]]\x3e")):null:a.match("--")?b(t("comment","--\x3e")):a.match("DOCTYPE",!0,!0)?(a.eatWhile(/[\w\._\-]/),b(u(1))):null;if(a.eat("?"))return a.eatWhile(/[\w\._\-]/),c.tokenize=
t("meta","?>"),"meta";l=a.eat("/")?"closeTag":"openTag";c.tokenize=v;return"tag bracket"}if("&"==d)return(a.eat("#")?a.eat("x")?a.eatWhile(/[a-fA-F\d]/)&&a.eat(";"):a.eatWhile(/[\d]/)&&a.eat(";"):a.eatWhile(/[\w\.\-:]/)&&a.eat(";"))?"atom":"error";a.eatWhile(/[^&<]/);return null}function v(a,c){var b=a.next();if(">"==b||"/"==b&&a.eat(">"))return c.tokenize=k,l=">"==b?"endTag":"selfcloseTag","tag bracket";if("="==b)return l="equals",null;if("<"==b)return c.tokenize=k,c.state=m,c.tagName=c.tagStart=
null,(a=c.tokenize(a,c))?a+" tag error":"tag error";if(/['"]/.test(b))return c.tokenize=F(b),c.stringStartCol=a.column(),c.tokenize(a,c);a.match(/^[^\s\u00a0=<>"']*[^\s\u00a0=<>"'\/]/);return"word"}function F(a){var c=function(b,c){for(;!b.eol();)if(b.next()==a){c.tokenize=v;break}return"string"};c.isInAttribute=!0;return c}function t(a,c){return function(b,d){for(;!b.eol();){if(b.match(c)){d.tokenize=k;break}b.next()}return a}}function u(a){return function(c,b){for(var d;null!=(d=c.next());){if("<"==
d)return b.tokenize=u(a+1),b.tokenize(c,b);if(">"==d)if(1==a){b.tokenize=k;break}else return b.tokenize=u(a-1),b.tokenize(c,b)}return"meta"}}function G(a,c,b){this.prev=a.context;this.tagName=c;this.indent=a.indented;this.startOfLine=b;if(e.doNotIndent.hasOwnProperty(c)||a.context&&a.context.noIndent)this.noIndent=!0}function w(a){a.context&&(a.context=a.context.prev)}function y(a,c){for(var b;a.context;){b=a.context.tagName;if(!e.contextGrabbers.hasOwnProperty(b)||!e.contextGrabbers[b].hasOwnProperty(c))break;
w(a)}}function m(a,c,b){return"openTag"==a?(b.tagStart=c.column(),z):"closeTag"==a?H:m}function z(a,c,b){if("word"==a)return b.tagName=c.current(),f="tag",h;if(e.allowMissingTagName&&"endTag"==a)return f="tag bracket",h(a,c,b);f="error";return z}function H(a,c,b){if("word"==a){a=c.current();b.context&&b.context.tagName!=a&&e.implicitlyClosed.hasOwnProperty(b.context.tagName)&&w(b);if(b.context&&b.context.tagName==a||!1===e.matchClosing)return f="tag",q;f="tag error";return A}if(e.allowMissingTagName&&
"endTag"==a)return f="tag bracket",q(a,c,b);f="error";return A}function q(a,c,b){if("endTag"!=a)return f="error",q;w(b);return m}function A(a,c,b){f="error";return q(a,c,b)}function h(a,c,b){if("word"==a)return f="attribute",I;if("endTag"==a||"selfcloseTag"==a){c=b.tagName;var d=b.tagStart;b.tagName=b.tagStart=null;"selfcloseTag"==a||e.autoSelfClosers.hasOwnProperty(c)?y(b,c):(y(b,c),b.context=new G(b,c,d==b.indented));return m}f="error";return h}function I(a,c,b){if("equals"==a)return B;e.allowMissing||
(f="error");return h(a,c,b)}function B(a,c,b){if("string"==a)return C;if("word"==a&&e.allowUnquoted)return f="string",h;f="error";return h(a,c,b)}function C(a,c,b){return"string"==a?C:h(a,c,b)}var x=p.indentUnit,e={};p=r.htmlMode?D:E;for(var n in p)e[n]=p[n];for(n in r)e[n]=r[n];var l,f;k.isInText=!0;return{startState:function(a){var c={tokenize:k,state:m,indented:a||0,tagName:null,tagStart:null,context:null};null!=a&&(c.baseIndent=a);return c},token:function(a,c){!c.tagName&&a.sol()&&(c.indented=
a.indentation());if(a.eatSpace())return null;l=null;var b=c.tokenize(a,c);(b||l)&&"comment"!=b&&(f=null,c.state=c.state(l||b,a,c),f&&(b="error"==f?b+" error":f));return b},indent:function(a,c,b){var d=a.context;if(a.tokenize.isInAttribute)return a.tagStart==a.indented?a.stringStartCol+1:a.indented+x;if(d&&d.noIndent)return g.Pass;if(a.tokenize!=v&&a.tokenize!=k)return b?b.match(/^(\s*)/)[0].length:0;if(a.tagName)return!1!==e.multilineTagIndentPastTag?a.tagStart+a.tagName.length+2:a.tagStart+x*(e.multilineTagIndentFactor||
1);if(e.alignCDATA&&/<!\[CDATA\[/.test(c))return 0;if((c=c&&/^<(\/)?([\w_:\.-]*)/.exec(c))&&c[1])for(;d;)if(d.tagName==c[2]){d=d.prev;break}else if(e.implicitlyClosed.hasOwnProperty(d.tagName))d=d.prev;else break;else if(c)for(;d;)if((b=e.contextGrabbers[d.tagName])&&b.hasOwnProperty(c[2]))d=d.prev;else break;for(;d&&d.prev&&!d.startOfLine;)d=d.prev;return d?d.indent+x:a.baseIndent||0},electricInput:/<\/[\s\w:]+>$/,blockCommentStart:"\x3c!--",blockCommentEnd:"--\x3e",configuration:e.htmlMode?"html":
"xml",helperType:e.htmlMode?"html":"xml",skipAttribute:function(a){a.state==B&&(a.state=h)},xmlCurrentTag:function(a){return a.tagName?{name:a.tagName,close:"closeTag"==a.type}:null},xmlCurrentContext:function(a){var c=[];for(a=a.context;a;a=a.prev)a.tagName&&c.push(a.tagName);return c.reverse()}}});g.defineMIME("text/xml","xml");g.defineMIME("application/xml","xml");g.mimeModes.hasOwnProperty("text/html")||g.defineMIME("text/html",{name:"xml",htmlMode:!0})});