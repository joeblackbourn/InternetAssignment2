const signInbutton = document.querySelector("#signInButton");
const signUpbutton = document.querySelector("#signUpButton");
const overlay_container = document.querySelector(".container .overlay-container");
const overlay = document.querySelector(".container .overlay-container .overlay");
const signInForm = document.querySelector(".container .sign-in-form");
const signUpForm = document.querySelector(".container .sign-up-form");

signInbutton.addEventListener("click", () => {
    overlay_container.style.transform = "translateX(100%)";
    overlay.style.transform = "translateX(-50%)";
    signInForm.classList.add("active");
    signUpForm.classList.remove("active");
});
signUpbutton.addEventListener("click", () => {
    overlay_container.style.transform = "translateX(0%)";
    overlay.style.transform = "translateX(0%)";
    signUpForm.classList.add("active");
    signInForm.classList.remove("active");
});