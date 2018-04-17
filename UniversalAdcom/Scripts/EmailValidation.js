
////Function to validate phone
$(".submit").click(function () {
    if ($(".freeartwork").hasClass('in')) {
        console.log("free");
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
    } else if ($(".campaign").hasClass("in")) {
        $("#campaigncontact").on('submit', function (e) {
            console.log("campaign");
            var isValid = $("#campaigncontact").valid();
            if (isValid, validatePhone('PhoneCampaign')) {
                console.log("valid");
                return true;
            }
            else {
                console.log("not valid");
                e.preventDefault();
                return false;
            }
        });
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
$("input[name='Phone']").keyup(function () {
    $(this).val($(this).val().replace(/(\d{3})\-?(\d{3})\-?(\d{4})/, '$1-$2-$3'));

    if ($(".campaign").hasClass("in")) {
        console.log("campaign");
        if (validatePhone('PhoneCampaign')) {
            console.log("valid");

            $('#campaignPhoneStatus').html('Valid Phone');
            $('#campaignPhoneStatus').css('color', 'green');
        }

        else {
            $('#campaignPhoneStatus').html('Invalid Phone');
            $('#campaignPhoneStatus').css('color', 'red');
            console.log("invald");

        }
    }

    else if ($(".freeartwork").hasClass("in")) {
        if (validatePhone('Phone')) {
            $('#spnPhoneStatus').html('Valid Phone');
            $('#spnPhoneStatus').css('color', 'green');
        }

        else {
            $('#spnPhoneStatus').html('Invalid Phone');
            $('#spnPhoneStatus').css('color', 'red');
        }
    }
});



