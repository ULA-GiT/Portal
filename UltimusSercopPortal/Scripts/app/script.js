/// <reference path="../jquery-1.10.2.js" />
var root = location.protocol + "//" + location.host;

var url = root + "/UltimusSercopPortal/Home/Initiate?userLoged=true"

$('#myModal').modal('show')

$("#btnLogon").click(function () {
    location.href = "/UltimusSercopPortal/Home/Index";
});

$("#btnClose").click(function () {
    location.href = url;
});

$("#x").click(function () {
    $(".accDenegado").removeClass("oculto");
});


$('[data-toggle=offcanvas]').click(function () {
    $('.row-offcanvas-left').toggleClass('active');
});

$('[data-toggle=offcanvasright]').click(function () {
    $('.row-offcanvas-right').toggleClass('active');
});


$("a.botones").tooltip({
    placement: 'bottom'
});

$(window).resize(function () {
    console.log($(window).width());
});

$(document).ready(function () {
    var domain = "soce.int";
    var usr = "alfresco"
    $.getJSON("http://192.168.110.10/InitiateApi/api/Initiates/" + domain + "/" + usr)
          .done(function (data) {
              var miObjeto = JSON.parse(data)
              var tabla = $("#tabla");
              miObjeto.forEach(function (v, i) {
                  var tr = $('<tr class="openWin"></tr>');
                  tabla.append(tr);

                  var td = $("<td>" + v.NombreProceso + "</td>");
                  tr.append(td);

                  var td = $("<td>" + v.VersionProceso + "</td>");
                  tr.append(td);

                  var td = $("<td>" + v.NombreTarea + "</td>");
                  tr.append(td);

                  var td = $("<td class='urlOpen'>" +v.Url.replace('.', 'http://192.168.110.10/UltWeb') + "</td>");
                  tr.append(td);
              });
          });
});

    $('#tabla').on('click', 'tbody tr.openWin' , function (e) {
       // alert(this.cells[3].innerText);
        window.open($(this).find('td:last').text(),"newWindow", "height="+ screen.height + ", width =" + screen.width);
    });


$("#inbox").attr("href", $("#blup").val());
$("#initiate").attr("href", $("#blupInitiate").val());

