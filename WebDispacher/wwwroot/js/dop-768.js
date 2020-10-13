$(function() {
    $('.tab a').on('click', function(e){
        e.preventDefault();
        $(".tab a").removeClass("active");
        $(this).addClass("active");
        $('.try_block').show().addClass("active").not($(this).data('rel')).hide().removeClass("active");
    });
});