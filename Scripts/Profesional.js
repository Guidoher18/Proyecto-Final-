
$(document).ready(function(){

//El div Especialidad se inserta cuando se elige como #Titulo, Mg. o Dr.    
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
    
//Cuando se posiciona el cursor sobre #Firma cambia a #DragFirma, reversible cuando se aleja    
    $('#Firma').mouseenter(function(){
        $('#DragFirma').toggle();
        $('#Firma').toggle();
    });
    $('#DragFirma').mouseleave(function(){
        $('#DragFirma').toggle();
        $('#Firma').toggle();
    }); 
    
//Cuando se hace clic sobre #DragFirma se hace clic sobre el 'Seleccionar Archivo' del Input type="file"(#InputFirma) oculto    
    $('#DragFirma').on('click',function(){
        $('#InputFirma').click();
    });

//Cuando se posiciona el cursor sobre #FotoPerfil cambia a #DragFotoPerfil, reversible cuando se aleja    
    $('#FotoPerfil').mouseenter(function(){
        $('#DragFotoPerfil').toggle();
        $('#FotoPerfil').toggle();
    });
    $('#DragFotoPerfil').mouseleave(function(){
        $('#DragFotoPerfil').toggle();
        $('#FotoPerfil').toggle();
    });
    
//Cuando se hace clic sobre #DragFotoPerfil se hace clic sobre el 'Seleccionar Archivo' del Input type="file" (#InputFoto) oculto    
    $('#DragFotoPerfil').on('click',function(){
        $('#InputFoto').click();
    });









});











//VALIDAR CAMPOS DEL FORMULARIO
// FOTO 4x4
//Campos required

