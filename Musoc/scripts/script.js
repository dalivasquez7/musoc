$(function () {
    var settings = {
        rows: 4,
        cols: 15,
        rowCssPrefix: 'row-',
        colCssPrefix: 'col-',
        seatWidth: 35,
        seatHeight: 35,
        seatCss: 'asiento',
        selectedSeatCss: 'AsientoSeleccionado',
        selectingSeatCss: 'EligiendoAsiento'
    };

    var chargePerSheet;
    var init = function (reservedSeat) {
        var str = [], seatNo, className;
        for (i = 0; i < settings.rows; i++) {
            for (j = 0; j < settings.cols; j++) {
                seatNo = (i + j * settings.rows + 1);
                className = settings.seatCss + ' ' + settings.rowCssPrefix + i.toString() + ' ' + settings.colCssPrefix + j.toString();
                if ($.isArray(reservedSeat) && $.inArray(seatNo, reservedSeat) != -1) {
                    className += ' ' + settings.selectedSeatCss;
                }
                str.push('<li class="' + className + '"' +
                          'style="top:' + (i * settings.seatHeight).toString() + 'px;left:' + (j * settings.seatWidth).toString() + 'px">' +
                              '<a title="' + seatNo + '">' + seatNo + '</a>' +
                          '</li>');
            }
        }
        $('#lugar').html(str.join(''));
        chargePerSheet = $('#txtMonto').val();
    };

    //case I: Show from starting
    init();

   // Case II: If already booked
    //var bookedSeats = [5, 10, 25];
    //init(bookedSeats);


    $('.' + settings.seatCss).live('click', function () {
        if ($(this).hasClass(settings.selectedSeatCss)) {
            alert('Este asiento ya est');
        }
        else {
            $(this).toggleClass(settings.selectingSeatCss);
        }
    });

    $('#btnComprar').click(function () {
        var str = [];
        $.each($('#lugar li.' + settings.selectingSeatCss + ' a'), function (index, value) {
            str.push($(this).attr('title'));
        });
        if (str.length > 0) {
            $('#txtMonto').val(str.length * chargePerSheet);
            $('#txtNumAsiento').val(str.join(','));
        //alert(str.join(','));
            //window.open("FormFinCompra.aspx");
        }
        
    }) 
    
});