function loadEditor(teaxAreaId) {
    let textArea = document.getElementById(teaxAreaId);

    let instance = CodeMirror.fromTextArea(textArea, {
        mode: "htmlmixed",
        theme: "ttcn",
        lineNumbers: true,
        gutter: true
    });

    instance.setSize("100%", "100%");

    return instance;
}

let codeMirrorInstance = loadEditor("editor");

function setEditorTheme(themeName) {

}

function setEditorContent(content) {
    codeMirrorInstance.setValue(content);
}

function getEditorContent() {
    return codeMirrorInstance.getValue();
}