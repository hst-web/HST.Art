// JavaScript Document
//手机导航显示
$(document).click(function(){
	$('.nav-list').removeClass('open')
	})
$('.nav-menu,.nav-list').click(function(e){e.stopPropagation()})
$('nav').find('.nav-menu').click(function(e){
	$('.nav-list').toggleClass('open')
	})
//banner
var swiper = new Swiper('.swiper-container', {
    pagination: '.swiper-pagination',
    nextButton: '.swiper-button-next',
    prevButton: '.swiper-button-prev',
    paginationClickable: true,
    spaceBetween: 30,
    loop: true,
    centeredSlides: true,
    autoplay: 3500,
    autoplayDisableOnInteraction: false
});
//pc固定导航
$(document).ready(function () {
		var topMain = $("header").height() + 15
		var nav = $("nav");
		$(window).scroll(function () {
			if ($(window).scrollTop() > topMain) {
				nav.addClass("nav_scroll");

			} else {
				nav.removeClass("nav_scroll");
			}
		});
	})