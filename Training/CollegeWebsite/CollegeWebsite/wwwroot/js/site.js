$(document).ready(function () {
    function GetCourses() {
        $.ajax({
            url: '/CollegeWeb/Course',
            success: function (result) {
                console.log(result);
                $.each(result, function (i, data) {
                    $('#Courses').append('<option value=' + data.id + '>' + data.course + '</option>');
               });
            }
        });
    }
    GetCourses();
});