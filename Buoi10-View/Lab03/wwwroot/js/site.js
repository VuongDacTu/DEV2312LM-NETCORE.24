// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $('.single-item').slick({
        infinite: true,
        autoplay: true,
        autoplaySpeed: 1500,
        arrows: false,
        dots: true,
    });
    $('.spnb').slick({
        infinite: true,
        slidesToShow: 4,
        slidesToScroll: 1,
        arrows: true,
        autoplay: true,
        autoplaySpeed: 2500,
        prevArrow: "<button type='button' class='slick-prev pull-left'><i class='fa fa-angle-left' aria-hidden='true'></i></button>",
        nextArrow: "<button type='button' class='slick-next pull-right'><i class='fa fa-angle-right' aria-hidden='true'></i></button>"
    });
    $('.slideCTSP').slick({
        infinite: true,
        slidesToShow: 3,
        slidesToScroll: 1,
        arrows: true,
        vertical: true,
        verticalSwiping: true,

        prevArrow: "<button type='button' class='slick-prev pull-left'><i class='bi bi-chevron-compact-up'></i></button>",
        nextArrow: "<button type='button' class='slick-next pull-right'><i class='bi bi-chevron-compact-down'></i></button>"
    });

});