function scrollToTop(){
  $('html, body').animate({scrollTop:0},500);
}


// document ready
$(function(){

  $('.collapse-trigger').click(function(){
    var trigger = $(this);
    var target = $(trigger.attr('data-target'));

    if(target.hasClass('collapsed')){
      target.css({'height':'auto'});
      var targetHeight = target.css('height');
      target.css({'height':0});
      target.animate({'height':targetHeight},500,function(){
        target.css({'height':'auto'});
      }).removeClass('collapsed');
      trigger.find('.icon-plus').toggleClass('icon-plus icon-minus');
    }
    else{
      target.animate({'height':0},500,function(){
        target.addClass('collapsed');
        trigger.find('.icon-minus').toggleClass('icon-minus icon-plus');
      });
    }
  });


  $('.accordion-trigger').click(function(){

    var trigger = $(this);
    var target = $(trigger.attr('data-target'));
    var context = trigger.parents('.accordion-container');

    if(trigger.hasClass('active')){
      trigger.removeClass('active');
      target.animate({'height':0},500).css('padding',0).removeClass('active');
    }
    else{
      context.find('.accordion-trigger.active').removeClass('active');
      context.find('.accordion-target.active').css('height',0);

      trigger.addClass('active');
      target.css('height','auto');
      var targetHeight = target.css('height');
      target.css('height',0).animate({'height':targetHeight},250,function(){
        target.css({'height':'auto'}).addClass('active');
      });
    }

  });


  $('.tab').click(function(){

    var trigger = $(this);
    var target = $(trigger.attr('data-target'));
    var context = trigger.parents('.tabs-container');

    if(!trigger.hasClass('active')){
      context.find('.tabs button.active').removeClass('active');
      context.find('.tabs-content.active').removeClass('active');

      trigger.addClass('active');
      target.addClass('active');
    }

  });


  $('.modal-trigger').click(function(){
    var context = $('.modal-container');
    context.find('.modal').fadeOut(1);
    if(context.css('display') == 'none'){
      context.fadeIn();
    }
    $($(this).attr('data-target')).fadeIn();
  });

  $('.close-modal').click(function(){
    $(this).parent('.modal').fadeOut();
    $(this).parents('.modal-container').fadeOut();
  });


  $('.button-group button').click(function(){
    var trigger = $(this);
    var triggerInput = trigger.find('input[type="checkbox"], input[type="radio"]');

    if(triggerInput.attr('type') === "checkbox"){
      triggerInput.prop('checked',!triggerInput.prop('checked'));
    }
    else{
      trigger.parent('.button-group').find('button.active').removeClass('active');
      triggerInput.prop('checked',!triggerInput.prop('checked'));
    }

    if(triggerInput.prop('checked')){
      trigger.addClass('active');
    }
    else{
      trigger.removeClass('active');
    }
  });

});