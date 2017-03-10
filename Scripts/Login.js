//Cuando se hace clic en #Siguiente aparece para cargar la #Contraseña
$(document).ready(function(){
    $('button').on('click',function(){
        event.preventDefault();
    });
    $('#Siguiente').click(function(){
        $(this).toggle();
        $('#Usuario').toggle();
        $('h2').html("Ingresar Contraseña");
        $('#Contraseña').fadeIn('slow');
        $('#Submit').toggle();
    });
});