$(function () {
    $('#cat_id').on('change', function () {
        var id = $(this).val();
        //alert(id);
        $.get('/Orders/getProducts', { id: id }, function (data) {
            $('#product_id').empty();
            $.each(data, function (index, row) {
                $('#product_id').append("<option value='" + row.id + "'>" + row.product_name + "</option>")
            });
            });
    });
});

//Getting unit price
$(function () {
    $('#product_id').on('change', function () {
        var product_id = $(this).val();
        //alert(product_id);
        $.get('/Orders/getUnitPrice', { product_id: product_id }, function (data) {
            $('.unit-price').val(data.unit_price);
        });
    });
});