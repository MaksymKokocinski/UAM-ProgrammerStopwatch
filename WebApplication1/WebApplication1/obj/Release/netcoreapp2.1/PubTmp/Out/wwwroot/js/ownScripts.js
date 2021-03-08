function confirmDelete(idkey)
{
    var conDelete = confirm("Czy chcesz zakończyć to zadanie?");
    if (conDelete)
    {
        window.location.href = 'Users/Zakoncz/' + idkey;
    }
}
var timer;
function startZegara() {
    var komorki = document.getElementsByName("table-tr");
    for (var i = 0; i < komorki.length; i++) {
        var name = komorki[i].getElementsByTagName("td")[0].innerText;
        if (sesja == name) {
            var czas_komorka = komorki[i].getElementsByTagName("td")[2];
            timer=setInterval(zegar, 1000, czas_komorka);
        }
    }
}
function zegar(czas_komorka) {
    var czas = czas_komorka.innerText;
    var conT = parseInt(continueT);
    var int_czas = parseInt(czas);
    if (conT != 0) {
        int_czas += conT;
        continueT = 0;
    }
    console.log(parseInt(continueT));
    czas_komorka.innerText = (int_czas + 1);
}
function recoverClock() {
    var komorki = document.getElementsByName("table-tr");
    for (var i = 0; i < komorki.length; i++) {
        var name = komorki[i].getElementsByTagName("td")[0].innerText;
        if (sesja == name) {
            var czas_komorka = komorki[i].getElementsByTagName("td")[2];
            var timeTemp = parseInt(czas_komorka.innerText);
            if (parseInt(continueT) != 0) {
                timeTemp += parseInt(continueT);
                continueT = 0;
                czas_komorka.innerText = timeTemp;
            }
        }
    }
}
$.ajax({
    type: "Get",
    url: "/Users/Index",
    data: null,
    success: function (result) {
        if (sesja != "") {
            recoverClock();
            startZegara();
        }
    },
    error: function (req, status, error) {
        
    }
});