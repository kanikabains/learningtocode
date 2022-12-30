﻿$(document).ready(function () {
    function GetCourses() {
        $.ajax({
            url: '/CollegeWebController/Course',
            success: function (result) {
                $.each(result, function (i, data) {
                    $('#Courses').append('<option value=' + data.id + '>' + data.course + '</option>');
               });
            }
        });
    }
    GetCourses();
});