//Evita que cuando se hace clic en #AgregarVinculo se recargue por Default la página
document.getElementById("AgregarVinculo").addEventListener("click", function(event){
    event.preventDefault()
});


$(document).ready(function(){
//Cuando se posiciona el cursor sobre #FotoPerfil cambia a #DragFotoPerfil 
    $('#FotoPerfil').mouseenter(function(){
        $('#DragFotoPerfil').fadeToggle(900);
        $('#FotoPerfil').toggle();
    });
    
//Cuando se hace clic sobre #DragFotoPerfil se hace clic sobre el 'Seleccionar Archivo' del Input type="file" (#InputFoto) oculto    
    $('#DragFotoPerfil').on('click',function(){
        $('#InputFoto').click();
    });

//CalcularEdad() obtiene la diferencia entre la fecha actual y la ingresada. Toma como parámetro los selectores entrecomillados y sin $() que refiere al input type=date, y a su Label correspondiente por ej.: '#fecha', '#fechaLabel'.
    var CalcularEdad = function (inputDate, inputDateLabel){
        var $FechaElegida = $(inputDate).val(); //devuelve la fecha elegida como yyyy-mm-dd
        
        var $yyyy= moment().get('year');
        var $mm = moment().get('month');
        var $dd = moment().get('date');
        var $FechaHoy = new Date($yyyy, $mm, $dd); //Obtengo la fecha de hoy
        
        var $fecha1 = moment($FechaElegida);
        var $fecha2 = moment($FechaHoy);
        
        var $Edad = $fecha2.diff($fecha1, 'years'); //Calculo la Edad en Años
        var $DifMeses = $fecha2.diff($fecha1, 'month'); //Calculo la Difencia en Meses
            $DifMeses %=12;
        var $PalabraMes = '';
        
        if ($DifMeses == 1) // Hace que en el Label aparezca Mes si tiene Por ej.: 8 Años, 1 Mes.
        {
            $PalabraMes = 'Mes'
        }
        else
        {
            $PalabraMes = 'Meses'
        }

        if (inputDate == '#FechaNacimiento input[type="date"]')
        {
            if ($Edad < 18 && $DifMeses != 0) //Si es un menor de 18 años, devuelve la edad en Años y Meses
            {
                $(inputDateLabel).html('('+ $Edad + ' Años,'+' '+ $DifMeses + ' ' + $PalabraMes + ')');
            }
            else //Si es mayor de 18 años, devuelve la edad en Años
            {
                $(inputDateLabel).html('('+ $Edad +' Años)');
            };
        }
        else
        {
            if ($Edad < 18 && $DifMeses != 0) //Si es un menor de 18 años, devuelve la edad en Años y Meses
            {
                $(inputDateLabel).html('&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;('+ $Edad + ' Años,'+' '+ $DifMeses + ' ' + $PalabraMes + ')');
            }
            else //Si es mayor de 18 años, devuelve la edad en Años
            {
                $(inputDateLabel).html('&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;('+ $Edad +' Años)');
            };
        };
     };

//Inserta una nueva fila de campos para cargar otro Vinculo Significativo
    var $Contador = 0;
    var a = '';
    var b = '';
    
    $('#AgregarVinculo').on('click', function(){
        $Contador +=1;
        
        var $NuevoVinculo = '<div id="VinculosSignificativos' + $Contador + '" class="col-md-6"><label class="col-md-3"> </label><label id="VSFechaNacimientoLabel' + $Contador + '" class="col-md-2 Años">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(?? Años)</label><button class="btn btn-danger QuitarVinculo"><span class="glyphicon glyphicon-remove"></span></button><br><input type="text" name="VSVinculo' + $Contador + '" class="form-control col-md-1" placeholder="VÍNCULO"/><input type="text" name="VSApellidoNombre' + $Contador + '" class="form-control col-md-2" placeholder="APELLIDO Y NOMBRE"/><input type="date" name="VSFechaNacimiento' + $Contador + '" class="form-control col-md-1" id="VSFechaNacimiento" style="font-size:9px"/><input type="text" name="VSOcupacion' + $Contador + '" class="form-control col-md-1" placeholder="OCUPACIÓN"/><select name="VSConvive' + $Contador + '" class="form-control col-md-1" style="font-size:9px"><option value="Convive" default>CONVIVE</option><option value="No Convive"> NO CONVIVE</option></select></div>';
        
        $($NuevoVinculo).insertAfter($('#VinculosSignificativos'));
    });
//Calcula la Edad para el (?? Años) de #FechaNacimiento
    $('#FechaNacimiento input[type="date"]').on('focusout',function(){
        CalcularEdad('#FechaNacimiento input[type="date"]','#FechaNacimiento>label');
    });

//Calcula la Edad para el (?? Años) de #VSFechaNacimiento 
    $('#VSFechaNacimiento').on('focusout',function(){
        CalcularEdad('#VSFechaNacimiento','#VSFechaNacimientoLabel');
    }); 

//Intento de que Calcule la Edad de los otros Vínculos Agregado y que elimine la file cuando se cliquea en un '.QuitarVinculo'
    /*a = 'VSFechaNacimiento'+ $Contador; //string del Nombre del inputDate
    b = 'VSFechaNacimientoLabel'+ $Contador; //string del Nombre del inputDateLabel

    $(a).on('focusout',function(){
    CalcularEdad(a,b);});*/


});
 