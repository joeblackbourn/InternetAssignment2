const bar = document.getElementById("bar");
const close = document.getElementById("close");
const nav = documnet.getElementById("navbar");

if (bar) {
    bar.addEventListener("click", () => {
        navclassList.add("active")
    })
}

if (close) {
    bar.addEventListener("click", () => {
        navclassList.add("active")
    })
}

function changeFontSize(type){

    let ids = ["#h", "#p"];

    ids.forEach(id => {
        let el = document.querySelector(id);
        let fontSize = window.getComputedStyle(el, null).getPropertyValue("font-size")
        fontSize = parseFloat(fontSize);

        if (type === "increase"){
            el.style.fontSize = (fontSize + 5) + "px";
        } else {
            el.style.fontSize = (fontSize - 5) + "px";
        }
    });

}