/*AGREGAR FUNCIÓN PARA QUE CUANDO HAGA CLIC EN DR. o MG. se AGREGUE ESP. EN .... */
//VALIDAR CAMPOS DEL FORMULARIO
//FIRMA DIGITAL, por favor suba una imagen que ... etc
// FOTO 4x4

$(document).ready(function(){
    $('#Titulo option[value="Mg."]').on(click, function(){
        $('#InsertarEspecialista').append('<br><div id="Especialista"><label>Especialista en: </label><input type="text" name="Esp." class="form-control col-md-6"/></div><br>');
    });
});



