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

    var init = function (reservedSeat) {
        var str = [], numeroAsiento, className;
        for (i = 0; i < settings.rows; i++) {
            for (j = 0; j < settings.cols; j++) {
                numeroAsiento = (i + j * settings.rows + 1);
                className = settings.seatCss + ' ' + settings.rowCssPrefix + i.toString() + ' ' + settings.colCssPrefix + j.toString();
                if ($.isArray(reservedSeat) && $.inArray(numeroAsiento, reservedSeat) != -1) {
                    className += ' ' + settings.selectedSeatCss;
                }
                str.push('<li class="' + className + '"' +
                          'style="top:' + (i * settings.seatHeight).toString() + 'px;left:' + (j * settings.seatWidth).toString() + 'px">' +
                          '<a title="' + numeroAsiento + '">' + numeroAsiento + '</a>' +
                          '</li>');
            }
        }
        $('#lugar').html(str.join(''));
    };

    //case I: Show from starting
    init();

   // Case II: If already booked
    //var bookedSeats = [5, 10, 25];
    //init(bookedSeats);


    $('.' + settings.seatCss).click(function () {
        if ($(this).hasClass(settings.selectedSeatCss)) {
            alert('Este asiento ya fue reservado');
        }
        else {
            $(this).toggleClass(settings.selectingSeatCss);
        }
    });

    /*
    $('#btnShow').click(function () {
        var str = [];
        $.each($('#lugar li.' + settings.selectedSeatCss + ' a, #lugar li.' + settings.selectingSeatCss + ' a'), function (index, value) {
            str.push($(this).attr('title'));
        });
        //alert(str.join(','));
        window.open("FormFinCompra.aspx");
    }) 
    */
    
    $('#btnComprar').click(function () {
        var str = [], item;
        $.each($('#lugar li.' + settings.selectingSeatCss + ' a'), function (index, value) {
            item = $(this).attr('title');
            str.push(item);
        });
        alert(str.join(','));
        window.open("FormFinCompra.aspx");
    })
});