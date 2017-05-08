(function($){
	// Menu Functions
	$(document).ready(function(){
  	$('#menuToggle').click(function(e){
    	var $parent = $(this).parent('nav');
      $parent.toggleClass("open");
      var navState = $parent.hasClass('open') ? "hide" : "show";
      $(this).attr("title", navState + " navigation");
			// Set the timeout to the animation length in the CSS.
			setTimeout(function(){
				console.log("timeout set");
				$('#menuToggle > span').toggleClass("navClosed").toggleClass("navOpen");
			}, 200);
    	e.preventDefault();
  	});
  });
})(jQuery);

function closeall(){
    closeformenu2();
    closeformenu3();
    closeformenu4();
    closeformenu5();
    closeformenu6();
    closeformenu7();
    closeformenu8();
    closeformenuworkers();
    closeformenushop();
    closeformenutransport();
}

function openformenu8() {
    closeall();
      document.getElementById("formenucl8").style.width = "680px";
    if (pageLoaded8 == 0)
        {
            pageLoaded8 = 1;
            loaded8('tw8',twDisplayTW8);
        }
}


function openformenu2() {
     closeall();
    document.getElementById("formenucl2").style.width = "680px";
    if (pageLoaded2 == 0)
        {
            pageLoaded2 = 1;
            loaded2('tw2',twDisplayTW2);
        }
}


function openformenu3() {
     closeall();
    document.getElementById("formenucl3").style.width = "680px";
    if (pageLoaded3 == 0)
        {
            pageLoaded3 = 1;
            loaded3('tw3',twDisplayTW3);
        }
}


function openformenu4() {
     closeall();
    document.getElementById("formenucl4").style.width = "680px";
    if (pageLoaded4 == 0)
        {
            pageLoaded4 = 1;
            loaded4('tw4',twDisplayTW4);
        }
}

function openformenu5() {
     closeall();
    document.getElementById("formenucl5").style.width = "680px";
    if (pageLoaded5 == 0)
        {
            pageLoaded5 = 1;
            loaded5('tw5',twDisplayTW5);
        }
}

function openformenu6() {
     closeall();
    document.getElementById("formenucl6").style.width = "680px";
    if (pageLoaded6 == 0)
        {
            pageLoaded6 = 1;
            loaded6('tw6',twDisplayTW6);
        }
}

function openformenu7() {
     closeall();
    document.getElementById("formenucl7").style.width = "680px";
    if (pageLoaded7 == 0)
        {
            pageLoaded7 = 1;
            loaded7('tw7',twDisplayTW7);
        }
}


function openformenuworkers() {
     closeall();

    document.getElementById("formenuclworkers").style.width = "680px";
    
}

function openformenushop() {
     closeall();
     document.getElementById("formenuclshop").style.width = "680px";
    
}


function openformenutransport() {
     closeall();
     document.getElementById("formenucltransport").style.width = "680px";
    
}

/* Set the width of the side navigation to 0 */
function closeformenu8() {
    document.getElementById("formenucl8").style.width = "0";
}

function closeformenu2() {
    document.getElementById("formenucl2").style.width = "0";
}

function closeformenu3() {
    document.getElementById("formenucl3").style.width = "0";
}

function closeformenu4() {
    document.getElementById("formenucl4").style.width = "0";
}

function closeformenu5() {
    document.getElementById("formenucl5").style.width = "0";
}

function closeformenu6() {
    document.getElementById("formenucl6").style.width = "0";
}

function closeformenu7() {
    document.getElementById("formenucl7").style.width = "0";
}


function closeformenuworkers() {
    document.getElementById("formenuclworkers").style.width = "0";
}

function closeformenushop() {
    document.getElementById("formenuclshop").style.width = "0";
}


function closeformenutransport() {
    document.getElementById("formenucltransport").style.width = "0";
}

var pageLoaded8 = 0; 
var pageLoaded2 = 0; 
var pageLoaded3 = 0; 
var pageLoaded4 = 0; 
var pageLoaded5 = 0; 
var pageLoaded6 = 0; 
var pageLoaded7 = 0; 

var content8 = " Приветствую тебя, мой милый друг! Здесь твоя задача - построить мне дом, и чтоб все остались этим довольны! Приступай к работе! <br> Удачи! Поверь, она тебе понадобится!";

var content2 = " Привет! Я отвечаю за качество выполненной работы! Я заполнил твой список дел слева! " ;

var content3 = "  Привет! Я буду помогать тебе следить за процессами. Это индикаторы времени, баланса на счете, здоровья работников и всеобщей радости.";

var content4 = " Привет! Я буду помогать тебе с закупкой материалов. Заходи в магазин!";

var content5 = " Привет! Я помогу быстро доставить материалы и необходимый транспорт к тебе на участок! Следи за поставками.";

var content6 = " Привет! Обращайся ко мне, если понадобятся рабочие!";

var content7 = " Привет! Я отвечаю за зарплату! С моей помощью ты можешь ее повысить работникам для высшей скорости работы, но смотри, не обанкроться!";

function twDisplayTW8() {
    twDisplay('tw8',content8,0);
}

function twDisplayTW2() {
    twDisplay('tw2',content2,0);
}

function twDisplayTW3() {
    twDisplay('tw3',content3,0);
}

function twDisplayTW4() {
    twDisplay('tw4',content4,0);
}

function twDisplayTW5() {
    twDisplay('tw5',content5,0);
}


function twDisplayTW6() {
    twDisplay('tw6',content6,0);
}

function twDisplayTW7() {
    twDisplay('tw7',content7,0);
}

var brk = '~'; // character to use for line break

var resetTime = 0; // set to 0 to not reset or seconds to delay before reset

function twDisplay(id,content,num) {
    var delay = 40; 
    if (num <= content.length)  {
        var lt = content.substr(0,num); 
        document.getElementById(id).innerHTML = lt.replace(RegExp(brk,'g'),'<br \/>'); 
        num++; 
        if (num > content.length) 
            delay = resetTime * 1000;} 
    else {
        document.getElementById(id).innerHTML = ''; 
        num = 0;
    } if (delay > 0) 
        setTimeout('twDisplay("'+id+'","'+content+'","'+num+'")',delay);
} 


function loaded8(i,f) {
    if (document.getElementById && document.getElementById(i) != null) f(); 
    else 
        if (!pageLoaded8) setTimeout('loaded(\''+i+'\','+f+')',100);}

function loaded2(i,f) {
    if (document.getElementById && document.getElementById(i) != null) f(); 
    else 
        if (!pageLoaded2) setTimeout('loaded(\''+i+'\','+f+')',100);}

function loaded3(i,f) {
    if (document.getElementById && document.getElementById(i) != null) f(); 
    else 
        if (!pageLoaded3) setTimeout('loaded(\''+i+'\','+f+')',100);}

function loaded4(i,f) {
    if (document.getElementById && document.getElementById(i) != null) f(); 
    else 
        if (!pageLoaded4) setTimeout('loaded(\''+i+'\','+f+')',100);}

function loaded5(i,f) {
    if (document.getElementById && document.getElementById(i) != null) f(); 
    else 
        if (!pageLoaded5) setTimeout('loaded(\''+i+'\','+f+')',100);}

function loaded6(i,f) {
    if (document.getElementById && document.getElementById(i) != null) f(); 
    else 
        if (!pageLoaded6) setTimeout('loaded(\''+i+'\','+f+')',100);}

function loaded7(i,f) {
    if (document.getElementById && document.getElementById(i) != null) f(); 
    else 
        if (!pageLoaded7) setTimeout('loaded(\''+i+'\','+f+')',100);}



function move5() {
    var elem = document.getElementById("myBar5"); 
    var width = 20*0.4;
    var id = setInterval(frame, 10);
    function frame() {
        if (width >= 100) {
            clearInterval(id);
        } else {
            width++; 
            elem.style.width = width *0.6
                + '%'; 
            elem.innerHTML = width + '%';
        }
    }
}



function move6() {
    var elem = document.getElementById("myBar6"); 
    var width = 20*0.4;
    var id = setInterval(frame, 10);
    function frame() {
        if (width >= 100) {
            clearInterval(id);
        } else {
            width++; 
            elem.style.width = width *0.6
                + '%'; 
            elem.innerHTML = width + '%';
        }
    }
}



