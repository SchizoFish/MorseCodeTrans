function myFunction() {
    document.getElementById("myDropdown").classList.toggle("show");
}

// Close the dropdown menu if the user clicks outside of it
window.onclick = function (event) {
    if (!event.target.matches('.dropbtn')) {
        var dropdowns = document.getElementsByClassName("dropdown-content");
        var i;
        for (i = 0; i < dropdowns.length; i++) {
            var openDropdown = dropdowns[i];
            if (openDropdown.classList.contains('show')) {
                openDropdown.classList.remove('show');
            }
        }
    }
}

var askCategory = function () {
    document.getElementById('showInDropDown').style.display = "block";

};

function playA() {
    var audio = new Audio(
        'http://morsecodealphabet.org/mp3/Morse%20Code%20Alphabet%20A%20Alpha.mp3');
    audio.play();
}

function playB() {
    var audio = new Audio(
        'http://morsecodealphabet.org/mp3/Morse%20Code%20Alphabet%20B%20Bravo.mp3');
    audio.play();
}

function playC() {
    var audio = new Audio(
        'http://morsecodealphabet.org/mp3/Morse%20Code%20Alphabet%20C%20Charlie.mp3');
    audio.play();
}

function playD() {
    var audio = new Audio(
        'http://morsecodealphabet.org/mp3/Morse%20Code%20Alphabet%20D%20Delta.mp3');
    audio.play();
}

function playE() {
    var audio = new Audio(
        'http://morsecodealphabet.org/mp3/Morse%20Code%20Alphabet%20E%20Echo.mp3');
    audio.play();
}

function playF() {
    var audio = new Audio(
        'http://morsecodealphabet.org/mp3/Morse%20Code%20Alphabet%20F%20Foxtrot.mp3');
    audio.play();
}

function playG() {
    var audio = new Audio(
        'http://morsecodealphabet.org/mp3/Morse%20Code%20Alphabet%20G%20Golf.mp3');
    audio.play();
}

function playH() {
    var audio = new Audio(
        'http://morsecodealphabet.org/mp3/Morse%20Code%20Alphabet%20H%20Hotel.mp3');
    audio.play();
}

function playI() {
    var audio = new Audio(
        'http://morsecodealphabet.org/mp3/Morse%20Code%20Alphabet%20I%20India.mp3');
    audio.play();
}

function playJ() {
    var audio = new Audio(
        'http://morsecodealphabet.org/mp3/Morse%20Code%20Alphabet%20J%20Juliet.mp3');
    audio.play();
}

function playK() {
    var audio = new Audio(
        'http://morsecodealphabet.org/mp3/Morse%20Code%20Alphabet%20K%20Kilo.mp3');
    audio.play();
}

function playL() {
    var audio = new Audio(
        'http://morsecodealphabet.org/mp3/Morse%20Code%20Alphabet%20L%20Lima.mp3');
    audio.play();
}

function playM() {
    var audio = new Audio(
        'http://morsecodealphabet.org/mp3/Morse%20Code%20Alphabet%20M%20Mike.mp3');
    audio.play();
}

function playN() {
    var audio = new Audio(
        'http://morsecodealphabet.org/mp3/Morse%20Code%20Alphabet%20N%20November.mp3');
    audio.play();
}

function playO() {
    var audio = new Audio(
        'http://morsecodealphabet.org/mp3/Morse%20Code%20Alphabet%20O%20Oscar.mp3');
    audio.play();
}

function playP() {
    var audio = new Audio(
        'http://morsecodealphabet.org/mp3/Morse%20Code%20Alphabet%20P%20Papa.mp3');
    audio.play();
}

function playQ() {
    var audio = new Audio(
        'http://morsecodealphabet.org/mp3/Morse%20Code%20Alphabet%20Q%20Quebec.mp3');
    audio.play();
}

function playR() {
    var audio = new Audio(
        'http://morsecodealphabet.org/mp3/Morse%20Code%20Alphabet%20R%20Romeo.mp3');
    audio.play();
}

function playS() {
    var audio = new Audio(
        'http://morsecodealphabet.org/mp3/Morse%20Code%20Alphabet%20S%20Sierra.mp3');
    audio.play();
}

function playT() {
    var audio = new Audio(
        'http://morsecodealphabet.org/mp3/Morse%20Code%20Alphabet%20T%20Tango.mp3');
    audio.play();
}

function playU() {
    var audio = new Audio(
        'http://morsecodealphabet.org/mp3/Morse%20Code%20Alphabet%20U%20Uniform.mp3');
    audio.play();
}

function playV() {
    var audio = new Audio(
        'http://morsecodealphabet.org/mp3/Morse%20Code%20Alphabet%20V%20Victor.mp3');
    audio.play();
}

function playW() {
    var audio = new Audio(
        'http://morsecodealphabet.org/mp3/Morse%20Code%20Alphabet%20W%20Whiskey.mp3');
    audio.play();
}

function playX() {
    var audio = new Audio(
        'http://morsecodealphabet.org/mp3/Morse%20Code%20Alphabet%20X%20Xray.mp3');
    audio.play();
}

function playY() {
    var audio = new Audio(
        'http://morsecodealphabet.org/mp3/Morse%20Code%20Alphabet%20Y%20Yankee.mp3');
    audio.play();
}

function playZ() {
    var audio = new Audio(
        'http://morsecodealphabet.org/mp3/Morse%20Code%20Alphabet%20Z%20Zulu.mp3');
    audio.play();
}

