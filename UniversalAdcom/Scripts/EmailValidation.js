
////Function to validate phone
$("#emailContact").on('submit', function (e) {
    var isValid = $("#emailContact").valid();
    if (isValid, validatePhone('Phone')) {
        console.log("valid");
        return true;
    }
    else {
        console.log("not valid");
        e.preventDefault();
        return false;
    }
});


function validatePhone(txtPhone) {
    var a = document.getElementById(txtPhone).value;
    var filter = /(\d{3})\-?(\d{3})\-?(\d{4})/;
    if (filter.test(a)) {
        return true;
    }
    else {
        return false;
    }
}


//email contact form
$(document).ready(function () {
    $("input[name='Phone']").keyup(function () {
        $(this).val($(this).val().replace(/(\d{3})\-?(\d{3})\-?(\d{4})/, '$1-$2-$3'));

        if (validatePhone('Phone')) {
            $('#spnPhoneStatus').html('Valid Phone');
            $('#spnPhoneStatus').css('color', 'green');
        }

        else {
            $('#spnPhoneStatus').html('Invalid Phone');
            $('#spnPhoneStatus').css('color', 'red');
        }
    });
});

