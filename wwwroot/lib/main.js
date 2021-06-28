/*
 * Change Navbar color while scrolling
*/

$(window).scroll(function () {
    handleTopNavAnimation();
});

$(window).load(function () {
    handleTopNavAnimation();
});

function handleTopNavAnimation() {
    var top = $(window).scrollTop();

    if (top > 10) {
        $('#site-nav').addClass('navbar-solid');
    }
    else {
        $('#site-nav').removeClass('navbar-solid');
    }
}

/*
 * Registration Form
*/

$('#registration-form').submit(function (e) {
    e.preventDefault();

    var postForm = { //Fetch form data
        'fname': $('#registration-form #fname').val(),
        'lname': $('#registration-form #lname').val(),
        'email': $('#registration-form #email').val(),
        'cell': $('#registration-form #cell').val(),
        'address': $('#registration-form #address').val(),
        'zip': $('#registration-form #zip').val(),
        'city': $('#registration-form #city').val(),
        'program': $('#registration-form #program').val()
    };

    $.ajax({
        type: 'POST',
        url: './assets/php/contact.php',
        data: postForm,
        dataType: 'json',
        success: function (data) {
            if (data.success) {
                $('#registration-msg .alert').html("Registration Successful");
                $('#registration-msg .alert').removeClass("alert-danger");
                $('#registration-msg .alert').addClass("alert-success");
                $('#registration-msg').show();
            }
            else {
                $('#registration-msg .alert').html("Registration Failed");
                $('#registration-msg .alert').removeClass("alert-success");
                $('#registration-msg .alert').addClass("alert-danger");
                $('#registration-msg').show();
            }
        }
    });
});

/*
 * SmoothScroll
*/

smoothScroll.init();
//retrieve all counters from body
let counters = document.getElementsByClassName('counter');

//retrieve all counter value
let vals = Array.from(counters).map(x => Number(x.innerHTML));

//convert counters element collection to an array
counters = Array.from(counters);

//loop through all counters
counters.forEach(el => {
    //set counter to 0
    el.innerHTML = '0';
    //set 'internal' counter to 0 -> obviously this isn't super efficient
    //could be faster if you used an array instead
    el.counter = 0;
});

//execute this function as often as possible using requestAnimationFrame()
let update = () => {
    //loop through all counters
    counters.forEach((el, i) => {
        if (vals[i] < 100) {
            //add one to 'internal counter'
            el.counter += 1;
            //update counter display value min(max, currentVal + 1)
            el.innerHTML = Math.min(vals[i], el.counter);
        }
        if (vals[i] > 100 && vals[i] < 1000) {
            //add one to 'internal counter'
            el.counter += 10;
            //update counter display value min(max, currentVal + 1)
            el.innerHTML = Math.min(vals[i], el.counter);
        }
        if (vals[i] > 1000) {
            //add one to 'internal counter'
            el.counter += 50;
            //update counter display value min(max, currentVal + 1)
            el.innerHTML = Math.min(vals[i], el.counter);
        }
    });
    requestAnimationFrame(update);
}
update();

