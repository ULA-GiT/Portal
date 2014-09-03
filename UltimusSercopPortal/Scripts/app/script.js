/// <reference path="../jquery-1.10.2.js" />
var root = location.protocol + "//" + location.host;

var url = root + "/UltimusSercopPortal/Home/Initiate?userLoged=true"

$('#myModal').modal('show')

$("#btnLogon").click(function () {
    location.href = "/ULAPW/Home/Index";
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
                  var tr = $("<tr></tr>");
                  tabla.append(tr);

                  var td = $("<td>" + v.NombreProceso + "</td>");
                  tr.append(td);

                  var td = $("<td>" + v.VersionProceso + "</td>");
                  tr.append(td);

                  var td = $("<td>" + v.NombreTarea + "</td>");
                  tr.append(td);

              });
          });
});