document.addEventListener("DOMContentLoaded", function (event) {

    const showNavbar = (toggleId, navId, bodyId, headerId) => {
        const toggle = document.getElementById(toggleId),
            nav = document.getElementById(navId),
            bodypd = document.getElementById(bodyId),
            headerpd = document.getElementById(headerId)

        // Validate that all variables exist
        if (toggle && nav && bodypd && headerpd) {
            toggle.addEventListener('click', () => {
                // show navbar
                nav.classList.toggle('mostrar')
                // change icon
                toggle.classList.toggle('bx-x')
                // add padding to body
                bodypd.classList.toggle('body-pd')
            })
        }
    }

    showNavbar('header-toggle', 'nav-bar', 'body-pd', 'header')


    // Your code to run since DOM is loaded and ready
    !function (l) { "use strict"; l("body .sidebar").on("mousewheel DOMMouseScroll wheel", function (o) { if (768 < l(window).width()) { var e = o.originalEvent, t = e.wheelDelta || -e.detail; this.scrollTop += 30 * (t < 0 ? 1 : -1), o.preventDefault() } }), l(document).on("scroll", function () { 100 < l(this).scrollTop() ? l(".scroll-to-top").fadeIn() : l(".scroll-to-top").fadeOut() }), l(document).on("click", "a.scroll-to-top", function (o) { var e = l(this); l("html, body").stop().animate({ scrollTop: 0 }, 1e3, "easeInOutExpo"), o.preventDefault() }) }(jQuery);
});