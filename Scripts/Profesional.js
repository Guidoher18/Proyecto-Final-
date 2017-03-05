
//Cuando se hace clic sobre la firma <p> se hace clic sobre el 'Seleccionar Archivo' del Input type="file" oculto
$(document).ready(function(){
    $('#Firma').on('click',function(){
        $('#InputFirma').click();
    });
});




$(document).ready(function(){
    $('#Firma').hover(function(){
        $('#DragFirma').css('display','none');
        $('#Firma').css('display','block');
    });
}); 











//VALIDAR CAMPOS DEL FORMULARIO
//FIRMA DIGITAL, por favor suba una imagen que ... etc
// FOTO 4x4
//Campos required

//El div Especialidad se inserta cuando se elige como #Titulo, Mg. o Dr.
$(document).ready(function(){
    $('#Titulo').change(function(){
        var $elegido = $("#Titulo").val();
        if ($elegido == "Mg."){
            $('#InsertarEspecialidad').css('display','inherit');
            $('#Profdiv1').css({'top':'7.41302vh', 'bottom':'7.41302vh'});
        }
        else if ($elegido == "Dr."){
            $('#InsertarEspecialidad').css('display','inherit');
            $('#Profdiv1').css({'top':'7.41302vh', 'bottom':'7.41302vh'});            
        }
        else{
            $('#InsertarEspecialidad').css('display','none');
            $('#Profdiv1').css({'top':'12.3298vh', 'bottom':'12.3298vh'});                        
        };        
    });
});