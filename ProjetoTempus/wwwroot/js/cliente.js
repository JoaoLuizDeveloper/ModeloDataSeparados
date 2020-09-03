var dataTable;

$(document).ready(function (){
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/Admin/Cliente/GetAll",
            "type": "Get",
            "datatype": "json",
        },
        "columns": [
            { "data": "nome", "width": "30%" },
            {
                "data": "rendaFamiliar", "render": function (data) {
                    if (data <= 980) {
                        return `<div class="text-center" >
                                <div class='btn text-black renda' style="cursor:pointer; width: 160px; border-radius: 10px; background-color:red;>">
                                   R$ ${data}
                                </div>
                            </div>`
                    }
                    else if (data > 980 && data <= 2500) {
                        return `<div class="text-center" >
                                <div class='btn text-black renda' style="cursor:pointer; width: 160px; border-radius: 10px; background-color:yellow;>">
                                   R$ ${data}
                                </div>
                            </div>`
                    }
                    else if (data > 2500){
                        return `<div class="text-center" >
                                <div class='btn text-black renda' style="cursor:pointer; width: 160px; border-radius: 10px; background-color:green;>">
                                   R$ ${data}
                                </div>
                            </div>`
                    }
                    

                }, "width": "20%"
            },
            {
                "data": "id",
                "render": function (data) {
                    //Use `` for multiple lines
                    return `<div class="text-center" >
                                <a href="/Admin/Cliente/Details/${data}" class='btn btn-primary text-white' style="cursor:pointer; width: 100px">
                                    <i class="far fa-edit"></i> Detalhes
                                </a>
                                &nbsp;
                                <a href="/Admin/Cliente/Edit/${data}" class='btn btn-success text-white' style="cursor:pointer; width: 100px">
                                    <i class="far fa-edit"></i> Editar
                                </a>
                                &nbsp;
                                <a onclick=Delete("/Admin/Cliente/Delete/${data}") class='btn btn-danger text-white' style="cursor:pointer; width: 100px">
                                    <i class="far fa-trash-alt"></i> Deletar
                                </a>
                            </div>
                            `
                }, "width": "50%"
            }
        ],
        "language": {
            "lengthMenu": "Mostrando _MENU_ entradas",
            "emptyTable": "Sem Dados encotrados.",
            "zeroRecords": "Sem Dados encontrados",
            "info": "Mostrando Pagina _PAGE_ de _PAGES_",
            "search": "Procurar",
            "paginate": {
                "previous": "Pagina Anterior",
                "next": "Proxima Pagina",
                "first": "Primeira Pagina"
            }
        },
        "width": "100%"
    });
}

function Delete(url) {
    swal({
        title: "Você tem certeza que quer deletar?",
        text: "Voce não será capaz de restaurar o Cliente!",
        type: "warning",
        showCancelButton: true,
        confirmButtonColor: "#DD6B55",
        confirmbuttonText: "Sim, delete!",
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