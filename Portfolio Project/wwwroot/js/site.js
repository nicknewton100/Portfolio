// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


//resizes the background with javascript so that its bigger and seems brighter on mobile. if i use background-size: cover, it makes the image dark because it makes it so small
function resizeBackground() {
    if (window.innerWidth > 1000) {
        document.getElementById("container").style.backgroundSize = "cover";
        return;
    }

    var body = document.body,
        html = document.documentElement;
    var height = Math.max(body.scrollHeight, body.offsetHeight,
        html.clientHeight, html.scrollHeight, html.offsetHeight);

    document.getElementById("container").style.backgroundSize = (height + 500).toString() + "px";
}
window.onload = resizeBackground;
window.addEventListener('resize', resizeBackground);