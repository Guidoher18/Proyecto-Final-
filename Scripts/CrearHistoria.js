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

//CalcularEdad() obtiene la diferencia entre la fecha actual y la ingresada. Toma como parámetro el selector entrecomillado y sin $() que refiere al input type=date, por ej.: '#fecha'
    var CalcularEdad = function (selector){
        var $FechaElegida = $(selector).val(); //devuelve la fecha elegida como yyyy-mm-dd
        
        var $yyyy= moment().get('year');
        var $mm = moment().get('month');
        var $dd = moment().get('date');
        var $FechaHoy = new Date($yyyy, $mm, $dd); //Obtengo la fecha de hoy
        
        var $fecha1 = moment($FechaElegida);
        var $fecha2 = moment($FechaHoy);
        
        var $Edad = $fecha2.diff($fecha1, 'years'); //Calculo la Edad en Años
        var $DifMeses = $fecha2.diff($fecha1, 'month'); //Calculo la Difencia en Meses
            $DifMeses %=12;

        if (selector == '#FechaNacimiento input[type="date"]')
        {
            if ($Edad < 18 && $DifMeses != 0) //Si es un menor de 18 años, devuelve la edad en Años y Meses
            {
                $('#FechaNacimiento label').html('<label class="col-md-2 Años">('+ $Edad + ' Años,'+' '+ $DifMeses + ' Mes[es] )</label>');
            }
            else //Si es mayor de 18 años, devuelve la edad en Años
            {
                $('#FechaNacimiento label').html('<label class="col-md-2 Años">('+ $Edad +' Años)</label>');
            };
        }
        else
        {
            if ($Edad < 18 && $DifMeses != 0) //Si es un menor de 18 años, devuelve la edad en Años y Meses
            {
                $('#VSFechaNacimientoLabel').html('<label id="VSFechaNacimientoLabel" class="col-md-3 Años">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;('+ $Edad + ' Años,'+' '+ $DifMeses + ' Mes[es] )</label>');
            }
            else //Si es mayor de 18 años, devuelve la edad en Años
            {
                $('#VSFechaNacimientoLabel').html('<label id="VSFechaNacimientoLabel" class="col-md-3 Años">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;('+ $Edad +' Años)</label>');
            };
        };
     };

    $('#FechaNacimiento input[type="date"]').on('focusout',function(){
            CalcularEdad('#FechaNacimiento input[type="date"]');
    });

    $('#VinculosSignificativos input[type="date"]').on('focusout',function(){
            CalcularEdad('#VinculosSignificativos input[type="date"]');
    }); 

});


    



