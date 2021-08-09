function loadEditor(teaxAreaId) {
    var textArea = document.getElementById(teaxAreaId);

    var instance = CodeMirror.fromTextArea(textArea, {
        mode: "htmlmixed",
        theme: "ttcn",
        lineNumbers: true,
        gutter: true
    });

    instance.setSize("100%", "100%");

    return instance;
}

var codeMirrorInstance = loadEditor("textEdit");

function setEditorTheme(themeName) {

}

function setEditorContent(content) {
    codeMirrorInstance.setValue(content);
}

function getEditorContent() {
    return codeMirrorInstance.getValue();
}

window.onerror = function (msg, url, linenumber) {
    alert('Error message: ' + msg + '\nURL: ' + url + '\nLine Number: ' + linenumber);
    return true;
}