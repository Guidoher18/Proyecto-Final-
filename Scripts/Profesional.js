//VALIDAR CAMPOS DEL FORMULARIO
//FIRMA DIGITAL, por favor suba una imagen que ... etc
// FOTO 4x4
//Campos required

$(document).ready(function(){
    $('#Titulo').change(function(){
        var $elegido = $("#Titulo").val();
        if ($elegido == "Mg."){
            $('#InsertarEspecialista').css('display','inherit');
            $('#Profdiv1').css({'top':'7.41302vh', 'bottom':'7.41302vh'});
        }
        else if ($elegido == "Dr."){
            $('#InsertarEspecialista').css('display','inherit');
            $('#Profdiv1').css({'top':'7.41302vh', 'bottom':'7.41302vh'});            
        }
        else{
            $('#InsertarEspecialista').css('display','none');
            $('#Profdiv1').css({'top':'12.3298vh', 'bottom':'12.3298vh'});                        
        };        
    });
});