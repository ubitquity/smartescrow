// JavaScript Document

//$('#datepicker').datepicker();


function hide_element(selector) {
    $(selector).hide();
}

function hide_login_label() {
    if (localStorage.getItem('Ubitquity_Login_UserID') > 0)
        hide_element('#lbl-login');
}

