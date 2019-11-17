$(document).ready(function(){
		/*if( $(window).width() > 767 ){
			$(window).scroll(function() {
				if ($(this).scrollTop() > 1){
					$('#header').addClass("sticky-header");
				}
				else{
					$('#header').removeClass("sticky-header");
				}
			});

			$('ul.nav li.dropdown').hover(function() {
			  $(this).find('.dropdown-menu').stop(true, true).delay().fadeIn();
			}, function() {
			  $(this).find('.dropdown-menu').stop(true, true).delay().fadeOut();
			});

		}*/





		// sidebar
		$(".myside-bar .nav-item .nav-link").on("click", function() {
			if ($(this).hasClass("active")) {
				$(this).removeClass("active");
				$(this)
					.siblings(".subNav")
					.slideUp(200);
				$(this).parent('.myside-bar .nav-item').removeClass('activeItem');
			} else {
				$(".myside-bar .nav-item .nav-link").removeClass("active");
				$(".myside-bar .nav-item").removeClass("activeItem");
				$(this).addClass("active");
				$(this).parent('.myside-bar .nav-item').addClass('activeItem');
				$(".subNav").slideUp(200);
				$(this)
					.siblings(".subNav")
					.slideDown(200);
			}
		});

		$(".nav-handler, .myside-bar .nav-link .icon").click(function(e){
			e.stopPropagation()
				$(".nav-handler").toggleClass("nav-active-icon");
				$(".side-content").toggleClass("sidebar-close");
				$(".myside-bar .nav-item").removeClass("activeItem");
				$(".myside-bar .nav-item .nav-link").removeClass("active");
				$(".subNav").slideUp(200);
			});



			// $('.body-container, .nav-form-mobile, .top-bar, .footer').click(function(e){
			// 	$(".nav-handler").removeClass("nav-active-icon");
			// 	$(".side-content").removeClass("sidebar-open");
			//
			// 	if ($(".sidebar .nav-link").hasClass("active")) {
			// 		$('.sidebar .nav-link').parent('.nav-item').removeClass('activeItem');
			// 		$(".subNav").slideUp(200);
			// 	}
			// })

/*
		$('.body-container, .nav-form-mobile, .top-bar, .footer').click(function(e){
			$(".nav-handler").removeClass("nav-active-icon");
			$(".side-content").removeClass("sidebar-open");

			if ($(".nav-link").hasClass("active")) {
				$('.nav-link').parent('.nav-item').removeClass('activeItem');
				$(".subNav").slideUp(200);
			}
		})
*/


		//Begin left accordion menu
		/*
	   $('#left-nav > ul > li').click(function(){
		   if($(this).find('>ul').length){
			   $(this).find('>ul').slideToggle()
			   $(this).siblings('li').find('>ul').slideUp()
			   $(this).toggleClass('select')
			   $(this).siblings('li').removeClass('select')
		   }
	   })

	   $('#left-nav > ul > li >ul').click(function(e){
			   e.stopPropagation()
	   })
		 */

		// top search
		// if( $(window).width() > 480  ){
		// 	$(".top-search .search-btn").click(function(e){
		// 		e.stopPropagation()
		// 		$(".top-search .txtField").show('fast');
		// 	});
		//
		// 	$(".top-search .txtField").click(function(e){
		// 		e.stopPropagation()
		// 	});
		//
		// 	$('body').click(function(e){
		// 		$(".top-search .txtField").hide();
		// 	})
		// }

		// slider
		// $(window).load(function(){
		// 		$('#adsSlider').flexslider({
		// 			   animation: "slide",
		// 			   slideshow: true,
		// 			   controlNav: true,
		// 			   directionNav: false,
		// 			   useCSS : false,
		// 			   start: function(slider){
		// 				$('body').removeClass('loading');
		//
		// 			   },
		// 			   animationLoop: true
		// 		  });
		//
		// });


});
