$(function () {
    $('.id').on('change', function () {
        var id = $(this).val();
        //alert(id);
        $.get('/Orders/getProducts', { id: id }, function (data) {
            $('#product_id').html(data);
            });
    });
});