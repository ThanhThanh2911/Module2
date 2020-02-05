var brand = brand || {};
brand.drawTable = function () {

    brandtable = $("#tbBrand").DataTable({
        "processing": true, // for show progress bar  
        "serverSide": true, // for process server side  
        "filter": true, // this is for disable filter (search box)  
        "orderMulti": false, // for disable multiple column at once  
        "ajax": {
            "url": "/Brand/Gets",
            "type": "POST",
            "datatype": "json"
        },
        "columns": [
            { "data": "brandName", "name": "BrandName", "autoWidth": true, "title": "Brand Name" },
            { "data": "parenID", "name": "ParenID", "autoWidth": true, "title": "Catagory" },
            {
                data: "iD",
                render: function (data, type, row) {
                    return "<a href='javascript:void(0);' onclick= brand.getDetail('" + data + "')><i class='fas fa-edit'></i></a>" + " " +
                        "<a href='javascript:void(0);' onclick= brand.delete('" + data + "')><i class='far fa-trash-alt'></i></a>";
                },
                "sortable": false
            },
        ]
    });

};

brand.initSex = function () {
    $('#Sex').append(
        "<option value = '1'>Male</option> <option value = '0'>Female</option>"
    );
};

brand.openAddEditModal = function () {
    brand.resetForm();
    $('#addEditModel').modal('show');
};

brand.initClasses = function () {
    $.ajax({
        url: '/Home/GetClasses',
        method: 'GET',
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            if (data.status === 1) {
                var response = data.response;
                $.each(response, function (index, value) {
                    $('#ClassName').append(
                        "<option value = '" + value.id + "'>" + value.name + "</option>"
                    );
                });
            }
        }
    });
};

brand.save = function () {
    if ($('#formAddEditBrand').valid()) {
        var brandObj = {};
        brandObj["BrandName"] = $('#BrandName').val();
        brandObj["ParenID"] = $('#ParenID').val();

        $.ajax({
            url: '/Brand/Save',
            method: 'POST',
            data: JSON.stringify(brandObj),
            dataType: 'json',
            contentType: 'application/json',
            success: function (data) {
                if (data.status === 1) {
                    $('#addEditModel').modal('hide');
                    bootbox.alert(data.message);
                    brand.reloadTable();
                }
            }
        });
    }
};

brand.delete = (id) => {
    bootbox.confirm("Are you sure to delete?", function (result) {
        if (result) {
            $.ajax({
                url: '/Brand/Deletebrand/' + id,
                method: 'GET',
                dataType: 'json',
                contentType: 'application/json',
                success: function (data) {
                    if (data.status === 1) {
                        //brand.drawTable();
                        brand.reloadTable();
                    }
                }
            });
        }
    });
};

brand.getDetail = (id) => {
    $.ajax({
        url: '/Brand/Get/' + id,
        //url: '/Home/Get' + id + "/" + roomId,
        method: 'GET',
        dataType: 'json',
        contentType: 'application/json',
        success: function (data) {
            if (data.status === 1) {
                var response = data.response;

                $('#FullName').val(response.fullName);
                $('#DOB').val(response.dob);
                $('#Sex').val(response.sex);
                $('#ClassName').val(response.classRoomId);
                $('#brandId').val(response.brandId);
            }
            $('#addEditModel').find('.modal-title').text('Update new brand');
            $('#addEditModel').modal('show');
        }
    });
};

brand.resetForm = () => {
    $('#BrandName').val('');
    $('#ParenID').val('');
    $('#addEditModel').find('.modal-title').text('Create new brand');

    $('#formAddEditBrand').validate().resetForm();
};

brand.reloadTable = () => {
    brandtable.ajax.reload(null, false);
};

brand.init = function () {
    //brand.initSex();
    brand.drawTable();
    //brand.initClasses();
    //brand.resetForm();
};

$(document).ready(function () {
    brand.init();
});