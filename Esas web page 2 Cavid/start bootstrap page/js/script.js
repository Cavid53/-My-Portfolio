$(document).ready(function () {

    $(window).scroll(function () {
        if (scrollY > 20) {
            $(".nav-head").css("height","50px");
            $(".logo").css({

                "font-size": "25px",
                "transition": "all 0.5s"
            })
        }else{

            $(".logo").css({

                "font-size": "",
                "transition": "all 0.5s"
            })
        }


    })






})