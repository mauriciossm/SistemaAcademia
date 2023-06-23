// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function formataValorCpfCnpj(campo) {
    var vr = campo.value;

    if (vr.length > 0) {
        vr = vr.replace(new RegExp("\\.", "gm"), "").replace("-", "").replace("/", "");
    }
    var tam = vr.length;
    if ((tam == 11)) {
        campo.value = vr.substr(0, tam - 8) + '.' + vr.substr(tam - 8, 3) + '.' + vr.substr(tam - 5, 3) + '-' + vr.substr(tam - 2, tam);
    }
    if (tam >= 14) { //00.000.000.000/0000-00 01.234.567.890/1234-56
        campo.value = vr.substr(0, 2) + '.' + vr.substr(2, 3) + '.' + vr.substr(5, 3) + '/' + vr.substr(8, 4) + '-' + vr.substr(12, tam);
    }
};
