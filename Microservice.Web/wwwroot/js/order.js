﻿var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: "/order/getall" },
        "columns": [
            {data: 'orderHeaderId', "width": "5%"},
            {data: 'email', "width": "25%"}
        ]
    })
}