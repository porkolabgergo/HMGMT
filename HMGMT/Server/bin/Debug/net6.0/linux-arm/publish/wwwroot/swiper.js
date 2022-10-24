function initSwiper() {
    var swiper = new Swiper(".mySwiper", {
        slidesPerView: "2.5",
        freeMode: true,
        spaceBetween: 1,
        slidesPerGroup: 3,
        pagination: {
            el: ".swiper-pagination",
            clickable: true,
        },
        navigation: {
            nextEl: ".swiper-button-next",
            prevEl: ".swiper-button-prev",
        },
    });
}
