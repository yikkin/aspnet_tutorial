﻿$(function () {
    $('#cat_id').on('change', function () {
        var id = $(this).val();
        //alert(id);
        $.get('/Orders/getProducts', { id: id }, function (data) {
            $('#product_id').empty();
            $.each(data, function (index, row) {
                $('#product_id').append("<option value='" + row.product_id + "'>" + row.product_name + "</option>")
            });
            });
    });
});