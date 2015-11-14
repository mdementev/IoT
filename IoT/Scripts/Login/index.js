$(function() {
    $('#submitbutton').click(function (e) {
        var data = {
            Email: $('#email').val(),
            Password: $('#password').val()
        };
        signin(data.Email, data.Password);
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
        $('#output').text('Done');
    }).fail(function(e) {
        $('#output').text(e.responseJSON.error_description);
    });
};
