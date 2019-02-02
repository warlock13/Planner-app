function show_task(text) {
    var host = document.URL;
    if (!host.includes("Task")) {
        host = document.URL + "Task/Details/" + text;
    }
    else {
        host = host.replace("Index", "Details/" + text);
    }
    window.location.href = host;
}




