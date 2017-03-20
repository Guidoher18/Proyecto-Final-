$(document).ready(function(){

//El div Especialidad se inserta cuando se elige como #Titulo, Mg. o Dr.    
    $('#Titulo').change(function(){
        var $elegido = $("#Titulo").val();
        if ($elegido == "Mg."){
            $('#InsertarEspecialidad').css('display','inherit');
            $('#Profdiv1').css({'top':'3.1271vh', 'bottom':'3.1271vh'});
        }
        else if ($elegido == "Dr."){
            $('#InsertarEspecialidad').css('display','inherit');
            $('#Profdiv1').css({'top':'3.1271vh', 'bottom':'3.1271vh'});            
        }
        else{
            $('#InsertarEspecialidad').css('display','none');
            $('#Profdiv1').css({'top':'8.0439vh', 'bottom':'8.0439vh'});                        
        };        
    });    
    
//Cuando se posiciona el cursor sobre #Firma cambia a #DragFirma 
    $('#Firma').mouseenter(function(){
        $('#DragFirma').fadeToggle(900);
        $('#Firma').toggle();
    });

    
//Cuando se hace clic sobre #DragFirma se hace clic sobre el 'Seleccionar Archivo' del Input type="file"(#InputFirma) oculto    
    $('#DragFirma').on('click',function(){
        $('#InputFirma').click();
    });

//Cuando se posiciona el cursor sobre #FotoPerfil cambia a #DragFotoPerfil 
    $('#FotoPerfil').mouseenter(function(){
        $('#DragFotoPerfil').fadeToggle(900);
        $('#FotoPerfil').toggle();
    });

    
//Cuando se hace clic sobre #DragFotoPerfil se hace clic sobre el 'Seleccionar Archivo' del Input type="file" (#InputFoto) oculto    
    $('#DragFotoPerfil').on('click',function(){
        $('#InputFoto').click();
    });














    












});
