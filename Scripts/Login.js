$(document).ready(function(){
    $('button').on('click',function(){
        event.preventDefault();
    });

//Cuando se hace clic en #Siguiente aparece para cargar la #Contraseña, Permanecer Conectado y Recuperar la Contraseña
    $('#Siguiente').click(function(){
        $(this).toggle();
        $('#Usuario').toggle();
        $('h2').html("Ingresar Contraseña");
        $('#Contraseña').fadeIn('slow');
        $('#Submit').toggle();
        $('p').remove();
        $('a').html("<a href='&'> Recuperar Contraseña </a>");        
    });
});