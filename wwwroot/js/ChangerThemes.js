const darkToggle = document.querySelector('#option1');
const lightToggle = document.querySelector('#option2');
let theme = localStorage.getItem("theme");
if (!theme) {
    theme = "#fcfcfc";
    localStorage.setItem("theme", theme);
}
const body = document.querySelector('body');
body.style.backgroundColor = theme;
if (theme == "#fcfcfc") {
    lightToggle.setAttribute("checked", "checked");
} else {
    darkToggle.setAttribute("checked", "checked");
}
darkToggle.addEventListener('click', changeTheme.bind(null, '#a9a9a9'));

lightToggle.addEventListener('click', changeTheme.bind(null, '#fcfcfc'));


function changeTheme(color) {
    theme = color;
    localStorage.setItem("theme", theme);
    body.style.backgroundColor = theme;
}