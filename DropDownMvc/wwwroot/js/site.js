// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(".dropdown-toggle").next(".dropdown-menu").children().on("click", function () {
    const menu = $(this).closest(".dropdown-menu");
    const button = menu.prev(".dropdown-toggle");
    button.text($(this).text());
    const input = button.prev("input[type='hidden']");
    input.val($(this).attr('value'));
});