// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


var budgetSlider = document.querySelector("#slider");
var budgetValue = document.querySelector("#sliderLabel");

noUiSlider.create(budgetSlider, {
    start: [5],
    connect: 'lower',
    range: {
        "min": 1,
        "max": 500
    }
});

budgetSlider.noUiSlider.on("update", function (values, handle) {
    budgetValue.innerHTML = Math.round(values[handle]);
    if (handle) {
        budgetValue.innerHTML = Math.round(values[handle]);
    }
});