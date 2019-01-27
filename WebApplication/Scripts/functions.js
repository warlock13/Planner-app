function show_task(text) {
    var host = document.URL;
    if (!host.includes("Task")) {
        host = document.URL + "Task/Details/" + text;
    }
    else {
        host = host.replace("Index", "Details/" + text);
    }
    //alert(host);
    window.location.href = host;

}

function test() {
    alert("tested");
}