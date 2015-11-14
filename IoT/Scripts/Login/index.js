$(function() {
    $('#submitbutton').click(function (e) {
        e.preventDefault();
        var data = {
            grant_type: 'password',
            username: $('#email').val().trim(),
            password: $('#password').val().trim()
        };
        if(data.username.length && data.password.length) {

            $.post('Token', data, function(res) {
                sessionStorage.setItem('access_token', res.access_token);
                //$('#output').text('Done');
            }).fail(function(e) {
                console.log(e.statusText);
                //alert(e);
                //$('#output').text(e.responseJSON.error_description);
            });

            //signin(data.Email, data.Password);
        }
    });
});


var signin = function (username, password) {
    var loginData = {
        grant_type: 'password',
        username: username,
        password: password
    };

    $.post('Token', loginData, function(data) {
        sessionStorage.setItem('access_token', data.access_token);
        //$('#output').text('Done');
    }).fail(function(e) {
        console.log(e.statusText);
        //alert(e);
        //$('#output').text(e.responseJSON.error_description);
    });
};
