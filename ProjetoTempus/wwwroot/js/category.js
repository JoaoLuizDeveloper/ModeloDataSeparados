var dataTable;

$(document).ready(function (){
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/Admin/Category/GetAll",
            "type": "Get",
            "datatype": "json",
        },
        "columns": [
            { "data": "name", "width": "50%" },
            { "data": "displayOrder", "width": "20%" },
            {
                "data": "id",
                "render": function (data) {
                    //Use `` for multiple lines
                    return `<div class="text-center" >
                                <a href="/Admin/Category/Upsert/${data}" class='btn btn-success text-white' style="cursor:pointer; width: 100px">
                                    <i class="far fa-edit"></i> Edit
                                </a>
                                &nbsp;
                                <a onclick=Delete("/Admin/Category/Delete/${data}") class='btn btn-danger text-white' style="cursor:pointer; width: 100px">
                                    <i class="far fa-trash-alt"></i> Delete
                                </a>
                            </div>
                            `
                }, "width": "30%"
            }
        ],
        "language": {
            "emptyTable": "No Records Found."
        },
        "width": "100%"
    });
}

function Delete(url) {
    swal({
        title: "Are you sure you want Delete?",
        text: "You will not be able to restore this content!",
        type: "warning",
        showCancelButton: true,
        confirmButtonColor: "#DD6B55",
        confirmbuttonText: "Yes, delete it!",
        closeOnconfirm: true
    }, function () {
            $.ajax({
                type: 'Delete',
                url: url,
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            });
    });
}