/// <reference path="../moment-with-locales.min.js" />

var domain = "soce.int";
var usr = "alfresco";
var codigo = "";
$(document).ready(function () {

    $.getJSON("http://192.168.110.10/InitiateApi/api/Completed/" + domain + "/" + usr)
          .done(function (data) {
              var tabla = $("#tablaCompleted");
              data.forEach(function (v, i) {
                  var tr = $('<tr class="openWin"></tr>');
                  tabla.append(tr);

                  var td = $("<td>" + v.PROCESSNAME + "</td>");
                  tr.append(td);

                  var td = $("<td>" + v.STEPLABEL + "</td>");
                  tr.append(td);

                  codigo = v.CodigoTipoContratacion + '-' + v.CodigoTipoCompra + "-" + v.CodigoInicialesEntidad + "-" + v.NumeroSecuenciaProceso + "-" + v.AnioCurso;
                  td = $("<td>" + codigo + "</td>");
                  tr.append(td);

                  moment.locale('es')
                  td = $("<td>" + moment(v.FechaProgramada).format('L') + "</td>");
                  tr.append(td);

                  td = $("<td>" + devuelveEstadoTarea(v.STATUS) + "</td>");
                  tr.append(td);

                  td = $("<td>" + v.ObjetoContratacion + "</td>");
                  tr.append(td);

                  var td = $("<td class='urlOpen'>" + v.TASKID + "</td>");
                  tr.append(td);
              });
          });
});

$('#tablaCompleted').on('click', 'tbody tr.openWin', function (e) {
    var id = $(this).find('td:last').text();
    var url = "http://192.168.110.10/Ultimus.Sercop.Compartidos/FrmUltimus.aspx?UserID=" + domain + "/" + usr + "&TaskID=" + id;
    window.open(url, "newWindow", "height=" + screen.height + ", width =" + screen.width);
});

function devuelveEstadoTarea(st) {
    if (st === 1) {
        return "Activo";
    }
    else if (st === 3) {
        return "Completado";
    }
}