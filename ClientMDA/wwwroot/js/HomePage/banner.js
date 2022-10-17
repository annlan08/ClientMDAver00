////banner
var swiper = new Swiper(".mySwiper", {
    spaceBetween: 30,
    centeredSlides: true,
    autoplay: {
        delay: 3500,
        disableOnInteraction: false,
    },
    pagination: {
        el: ".swiper-pagination",
        clickable: true,
    },
    navigation: {
        nextEl: ".swiper-button-next",
        prevEl: ".swiper-button-prev",
    },
});



/*rate*/
var swiper = new Swiper(".mySwiperRATE", {
    slidesPerView: 4,
    spaceBetween: 30,   
    autoplay: {
        delay: 3500,
        disableOnInteraction: false,
    },
    pagination: {
        el: ".swiper-paginationR",
        clickable: true,
    },   
    
});


$(document).ready(function () {
    $('#rateMe2').mdbRate();
});

//rate

//const openmodalBtn = document.querySelectorAll('[data-modal-target]');
//const openmodalBtn = document.querySelectorAll('[data-close-button]');
//const overlay = document.querySelector('#overlay')

//openmodalBtn.forEach(button => {
//    button.addEventListener('click', () => {
//        const modal = document.querySelector(button.dataset.modalstarTarget)
//        openModal(modal);
//    })
//})

//closemodalBtn.forEach(button => {
//    button.addEventListener('click', () => {
//        const modal = button.closest('.modalstar')
//        closeModal(modal);
//    })
//})

//overlay.addEventListener("click", () => {
//    const modals = document.querySelectorAll('.modalstar.active')
//    modals.forEach(modal => {
//        closeModal(modal);
//    })
//})

//function openModal(modalstar) {
//    if (modalstar == null) return
//    modalstar.classList.add('active')
//    overlay.classList.add('active')
//}

//function closeModal(modalstar) {
//    if (modalstar == null) return
//    modalstar.classList.remove('active')
//    overlay.classList.remove('active')
//}