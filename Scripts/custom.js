﻿$(function () {
    $("#tblDepartmanlar").DataTable();
    $("#tblDepartmanlar").on("click", ".btnDepartmanSil", function () {
        var btn = $(this);
        bootbox.confirm("Departmanı silmek istediğinize emin misiniz ? ", function (result) {
            if (result) {
                var id = btn.data("id");
                
                $.ajax({
                    type: "GET",
                    url: "/Departman/Sil/" + id,
                    success: function () {
                        btn.parent().parent().remove();
                    }
                });
            }
            
        })
    });
});