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

    return false;

  });


  $('.tab').click(function(){

    var trigger = $(this);
    var target = $(trigger.attr('data-target'));

    if(!trigger.hasClass('active')){
      trigger.siblings('.active').removeClass('active');
      target.siblings('.active').removeClass('active');

      trigger.addClass('active');
      target.addClass('active');
    }

    return false;

  });


  $('.modal-trigger').click(function(){
    var context = $('.overlay-container');
    context.find('.modal').removeClass('show');
    if(!context.hasClass('show')){
      context.addClass('show');
      context.find('.overlay-backdrop').addClass('show');
    }
    $($(this).attr('data-target')).addClass('show');
  });


  $('.close-modal').click(function(){
    var context = $('.overlay-container');
    $(this).parents('.modal').removeClass('show');
    context.find('.overlay-backdrop').removeClass('show');
    context.removeClass('show');
  });


  $('.dialog-trigger').click(function(){
    var context = $('.overlay-container');
    context.find('.dialog').removeClass('show');
    if(!context.hasClass('show')){
      context.addClass('show');
      context.find('.overlay-backdrop').addClass('show');
    }
    $($(this).attr('data-target')).addClass('show');
  });


  $('.close-dialog').click(function(){
    var context = $('.overlay-container');
    $(this).parents('.dialog').removeClass('show');
    context.find('.overlay-backdrop').removeClass('show');
    context.removeClass('show');
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
