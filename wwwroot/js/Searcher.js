function searcher() {
    let text = document.querySelector("#input-search").value;
    let link = document.createElement("a");
    link.href = "/Search/Result/" + text;
    link.click();
};