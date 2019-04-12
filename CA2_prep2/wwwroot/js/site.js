// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

jQuery.validator.addMethod("age",
    function (value, element, param) {
        return (DateTime.Now.Year - browncoat.DOB.Year < 18);
    });
jQuery.validator.unobtrusive.adapters.addBool("age");