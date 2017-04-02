$(document).ready(function(){
    $('button').on('click',function(){
        event.preventDefault();
    });

//Cuando se hace clic en #Siguiente aparece para cargar la #Contraseña, Permanecer Conectado y Recuperar la Contraseña
    $('#Siguiente').click(function(){
        var $Usuario = $('#Usuario>input').val();
        $(this).toggle();
        $('#Usuario').toggle();
        $('h2').html("Ingresar Contraseña");
        $('#Contraseña').fadeIn('slow');
        $('#Submit').toggle();
        $('p').remove();
        $('#ACrearCuenta').html("<a href='&'> Recuperar Contraseña </a>");
        $('#Contraseña>label').html('Ingrese la Contraseña para: ' + $Usuario);        
    });
//Si presiona enter en el input de la Contraseña, hace clic en Submit
       $('#Contraseña>input:first-child').keypress(function(e) {
       if(e.which === 13) {
          // Acciones a realizar, por ej: enviar formulario.
           alert("Hola");
           //$('#Submit').click();
       }
    });
});




