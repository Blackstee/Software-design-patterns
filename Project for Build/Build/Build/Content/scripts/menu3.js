/* Set the width of the side navigation to 250px */
function openNav2() {
    closeformenu3();
    document.getElementById("mySidenav2").style.height = "250px";
}

/* Set the width of the side navigation to 0 */
function closeNav2() {
    document.getElementById("mySidenav2").style.height = "0";
}

function move() {
    var elem = document.getElementById("myBar"); 
    var width = 15*0.4;
    var id = setInterval(frame, 10);
    function frame() {
        if (width >= 100) {
            clearInterval(id);
        } else {
            width++; 
            elem.style.width = width *0.6  + '%'; 
            elem.innerHTML = width + '%';
        }
    }
}

function move2() {
    var elem = document.getElementById("myBar2"); 
    var width = 45*0.4;
    var id = setInterval(frame, 10);
    function frame() {
        if (width >= 100) {
            clearInterval(id);
        } else {
            width++; 
            elem.style.width = width *0.6  + '%'; 
            elem.innerHTML = width + '%';
        }
    }
}

function move3() {
    var elem = document.getElementById("myBar3"); 
    var width = 50*0.4;
    var id = setInterval(frame, 10);
    function frame() {
        if (width >= 100) {
            clearInterval(id);
        } else {
            width++; 
            elem.style.width = width *0.6  + '%'; 
            elem.innerHTML = width + '%';
        }
    }
}

function move4() {
    var elem = document.getElementById("myBar4"); 
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