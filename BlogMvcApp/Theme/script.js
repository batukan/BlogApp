window.onscroll = function () {
    scrollFunction()
};

function scrollFunction() {
    console.log("Scroll : " + document.body.scrollTop);
    if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
        document.getElementById("myBtn").style.display = "block";
    } else {
        document.getElementById("myBtn").style.display = "none";
    }
}

function topFunction() {
    document.body.scrollTop = 0;
    document.documentElement.scrollTop = 0;    
}
$(function () {
    $('[data-toggle="tooltip"]').tooltip()
})
