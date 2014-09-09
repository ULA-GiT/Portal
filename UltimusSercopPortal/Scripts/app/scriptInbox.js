$(document).ready(function () {
    var domain = "soce.int";
    var usr = "alfresco";
    var codigo ="";
    $.getJSON("http://192.168.110.10/InboxApi/api/Inbox/" + domain + "/" + usr)
          .done(function (data) {
              var tabla = $("#tablaInbox");
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

                  td = $("<td>" +v.FechaProgramada + "</td>");
                  tr.append(td);
              });
          });
    });