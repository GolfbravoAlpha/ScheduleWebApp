//test

function testLoop(uniqueStaffIdtest) {
    for (j = 0; j < uniqueStaffIdtest.length; j++) {
        console.log(uniqueStaffIdtest[j]);
    }
}

function loopDayTabletest(uniqueStaffIdtest) {
    startWorkTime = 800;
    endWorkTime = 1900;    

    for (j = 0; j < uniqueStaffIdtest.length; j++) {
        i = startWorkTime;
        modulusTable = i;     
                    
        $('#' + j + '_RowTable').append('<td id="r' + j + 'staff"' + '></td>');

        for (i; i <= endWorkTime; i++) {
            if (i % modulusTable == 60) {
                modulusTable += 100;
                i += 39;
            }
            else if (i == endWorkTime) {
                $('#' + j + '_RowTable').append("<td id='staff_" + j + "'>" + "&nbsp;" + "</td>");
            }
            else {
                $('#' + j + '_RowTable').append('<td id=t_' + i + '_r' + j + '>' + "&nbsp;" + '</td>');
                //i += 14;
            }
        }
        k = j + 1;

        $('#' + j + '_RowTable').after('<tr id="' + k + '_RowTable"></tr>')
    }
}

//loop tables
function loopIndividualTable() {
    startWorkTime = 800;
    endWorkTime = 1900; 

    for (j = 0; j < 7; j++) {
        i = startWorkTime;
        modulusTable = i;
        $('#' + j + '_RowTable').append('<td id="r' + j + 'days"' + '>' + days[j] + '</td>');

        for (i; i <= endWorkTime; i++) {
            if (i % modulusTable == 60) {
                modulusTable += 100;
                i += 39;
            }
            else if (i == endWorkTime) {
                $('#' + j + '_RowTable').append("<td id=hours_" + days[j] + ">" + "&nbsp;" + "</td>");
            }
            else {
                $('#' + j + '_RowTable').append('<td id=t_' + i + '_d_' + days[j] + '>' + "&nbsp;" + '</td>');
                i += 14;
            }

        }
        k = j + 1;

        $('#' + j + '_RowTable').after('<tr id="' + k + '_RowTable"></tr>')
    }




}

function loopDayTable() {
    startWorkTime = 800;
    endWorkTime = 1900; 

    for (j = 0; j < 7; j++) {
        i = startWorkTime;
        modulusTable = i;
        $('#' + j + '_RowTable').append('<td id="r' + j + 'staff"' + '></td>');

        for (i; i <= endWorkTime; i++) {
            if (i % modulusTable == 60) {
                modulusTable += 100;
                i += 39;
            }
            else if (i == endWorkTime) {
                $('#' + j + '_RowTable').append("<td id='staff_" + j + "'>" + "&nbsp;" + "</td>");
            }
            else {
                $('#' + j + '_RowTable').append('<td id=t_' + i + '_r' + j + '>' + "&nbsp;" + '</td>');
                //i += 1;
            }

        }
        k = j + 1;

        $('#' + j + '_RowTable').after('<tr id="' + k + '_RowTable"></tr>')
    }
}

    // to loop through the start time to the end time by 15 minute intervals and missing the end time

    function loopDataOntoTable(intFullStartTimeM, intFullEndTimeM, intHourStartM, DayNameM) {

        ModulusintFullStartTime = intHourStartM * 100;

        for (i = intFullStartTimeM; i < intFullEndTimeM; i++) {

            if (i % ModulusintFullStartTime == 60) {
                ModulusintFullStartTime += 100;
                i += 40;
                if (i == intFullEndTime) {
                    break;
                }
                else {

                    $('#t_' + i + '_d_' + DayNameM).replaceWith("<td id=t_" + i + '_d_' + DayNameM + " bgcolor='#0000FF'></td>");
                }
            }
            else {
                $('#t_' + i + '_d_' + DayNameM).replaceWith("<td id=t_" + i + '_d_' + DayNameM + " bgcolor='#0000FF'></td>");

            }
            i += 14;
        }

    }




    //clearing table method
    function tableClear(intFullStartTimeM, intFullEndTimeM, DayNameM) {

        for (j = 0; j < 7; j++) {

            ModulusintFullStartTime = intFullStartTimeM;

            for (i = intFullStartTimeM; i < intFullEndTimeM; i++) {

                if (i % ModulusintFullStartTime == 60) {
                    ModulusintFullStartTime += 100;
                    i += 40;
                    if (i == intFullEndTimeM) {
                        break;
                    }
                    else {

                        $('#t_' + i + '_d_' + DayNameM[j]).replaceWith("<td id=t_" + i + '_d_' + DayNameM[j] + "></td>");
                    }
                }
                else {
                    $('#t_' + i + '_d_' + DayNameM[j]).replaceWith("<td id=t_" + i + '_d_' + DayNameM[j] + "></td>");

                }
                i += 14;
            }

            $('#hours_' + days[j]).replaceWith("<td id=hours_" + days[j] + ">" + "&nbsp;" + "</td>");


        }

    };


    //calculate hour difference
    function Hourdiff(start, end) {
        start = start.split(":");
        end = end.split(":");
        var startDate = new Date(0, 0, 0, start[0], start[1], 0);
        var endDate = new Date(0, 0, 0, end[0], end[1], 0);
        var diff = endDate.getTime() - startDate.getTime();
        var hours = Math.floor(diff / 1000 / 60 / 60);
        diff -= hours * 1000 * 60 * 60;
        var minutes = Math.floor(diff / 1000 / 60);

        // If using time pickers with 24 hours format, add the below line get exact hours
        if (hours < 0)
            hours = hours + 24;

        return (hours <= 9 ? "0" : "") + hours + ":" + (minutes <= 9 ? "0" : "") + minutes;
    }

    //calculate total hours
    function AddingTimes(t1, t2) {
        var m = (t1.substring(0, t1.indexOf(':')) - 0) * 60 +
            (t1.substring(t1.indexOf(':') + 1, t1.length) - 0) +
            (t2.substring(0, t2.indexOf(':')) - 0) * 60 +
            (t2.substring(t2.indexOf(':') + 1, t2.length) - 0);
        var h = Math.floor(m / 60);
        return (h + ':' + (m - (h * 60)));
    }


