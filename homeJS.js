/*$(document).ready(function(){
    $(window).scroll(function(){
        var scroll = $(window).scrollTop();
        if (scroll > 50) {
          $("ul").css("background" , "blue");
        }
        else if(scroll > 100 && scroll < 200){
            $("ul").css("background", "pink");
        }
        else{
            $(".navigation").css("background" , "#333");  	
        }
    })
  })
  window.onscroll = function() {scrollFunction()};*/

 /*$(function() {
    $(window).on("scroll", function() {
        if($(window).scrollTop() > 50) {
            $(".header").addClass("active");
        } else {
            //remove the background property so it comes transparent again (defined in your css)
           $(".header").removeClass("active");
        }
    });
}); */
window.onscroll = () => {
    const nav = document.querySelector('ul');
    if(this.scrollY < 950 && this.scrollY>=300) nav.className = 'scrollP';
    else if (this.scrollY < 1600 && this.scrollY>=951)nav.className = 'scrollR';
    else if(this.scrollY >=1601) nav.className = 'scrollAM';
    else nav.className = '';
  };
function enableBtn() {
    document.getElementById("PButton").disabled = false;
    document.getElementById("AMButton").disabled = false;
    document.getElementById("RButton").disabled = false;
}