//$(function () {
//    $("#loaderbody").addClass('hide');

//    $(document).bind('ajaxStart', function () {
//        $("#loaderbody").removeClass('hide');
//    }).bind('ajaxStop', function () {
//        $("#loaderbody").addClass('hide');
//    });
//});

showInPopup = (url, title) => {
    jQuery.ajax({
        type: "GET",
        url: url,
        success: function (res) {
            $('#form-modal .modal-body').html(res);
            $('#form-modal .modal-title').html(title);
            $('#form-modal').modal('show');
        }
    })
        .fail(function (jqXHR, textStatus, errorThrown) {
            window.location.href = "/Home/Error";
        })
};

//postInPopup = (url, title) => {
//    $.ajax({
//        type: "GET",
//        url: url,
//        success: function (res) {
//            $('#form-modal .modal-body').html(res);
//            $('#form-modal .modal-title').html(title);
//            $('#form-modal').modal('show');
//        }
//    })
//};

jQueryAjaxPost = form => {
    //var datos = $("form")
    //    .removeData("validator") /* added by the raw jquery.validate plugin */
    //    .removeData("unobtrusiveValidation");  /* added by the jquery unobtrusive plugin*/
    event.preventDefault(); 

    //$.validator.unobtrusive.parse(datos);
    if ($("form").valid()) {
        try {
            jQuery.ajax({
                type: "POST",
                url: form.action,
                data: new FormData(form),
                contentType: false,
                processData: false,
                success: function (res) {
                    if (res.isValid) {
                        $('#view-all').html(res.html);
                        $('#form-modal .modal-body').html('');
                        $('#form-modal .modal-title').html('');
                        $('#form-modal').modal('hide');
                    }
                    //descomentado, para q permita hacer el llamado desde la vista
                    //a los scripts o vistas externas
                    else
                        $('#form-modal .modal-body').html(res.html);
                },
                //fail: function (jqXHR, textStatus, errorThrown) {

                //},
                error: function (err) {
                    console.log(err);
                }
            })
                .fail(function (jqXHR, textStatus, errorThrown) {
                    window.location.href = "/Home/Error";
                })
            //para prevenir el evento submit del form
            return false;
        } catch (e) {
            console.log(e);
        }
    }
};

jQueryAjaxDelete = form => {
    event.preventDefault();
    try {
        Swal.fire({
            title: '¿Estás seguro de eliminar este registro?',
            text: "No podrás revertir los cambios.",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Eliminar',
            cancelButtonText: 'Cancelar'
        }).then((result) => {
            if (result.value) {
                $.ajax({
                    type: "POST",
                    url: form.action,
                    data: new FormData(form),
                    contentType: false,
                    processData: false,
                    success: function (res) {
                            $('#view-all').html(res.html);
                        //$('#example').DataTable().draw();
                    },
                    error: function (err) {
                        console.log(err);
                    }
                })
                    .fail(function (jqXHR, textStatus, errorThrown) {
                        window.location.href = "/Home/Error";
                    })
                return false;
            }
        })
    } catch (e) {
        console.log(e);
    }
};

jQueryAjaxPostList = form => {
    try {
        $.ajax({
            type: "POST",
            url: form.action,
            data: new FormData(form),
            contentType: false,
            processData: false,
            success: function (res) {
                    $('#view-all').html(res.html);
            },
            error: function (err) {
                console.log(err);
            }
        })
            .fail(function (jqXHR, textStatus, errorThrown) {
                window.location.href = "/Home/Error";
            })
        //para prevenir el evento submit del form
        return false;
    } catch (e) {
        console.log(e);
    }
};


jQueryAjaxPostAlterno = form => {
    try {
        $.ajax({
            type: "POST",
            url: form.action,
            data: new FormData(form),
            contentType: false,
            processData: false,
            success: function (res) {
                if (res.isValid) {
                    $('#body-content-view').html(res.html);
                    //if (res.html2 != null) {
                        $('#body-content-action').html(res.html2);
                    //}
                    $('#form-modal .modal-body').html('');
                    $('#form-modal .modal-title').html('');
                    $('#form-modal').modal('hide');
                }
                else
                    $('#form-modal .modal-body').html(res.html);
            },
            error: function (err) {
                console.log(err);
            }
        })
            .fail(function (jqXHR, textStatus, errorThrown) {
                window.location.href = "/Home/Error";
            })
        //para prevenir el evento submit del form
        return false;
    } catch (e) {
        console.log(e);
    }
};


showForm = form => {
    event.preventDefault();
    if ($("form").valid()) {
        try {
            $.ajax({
                type: "POST",
                url: form.action,
                data: new FormData(form),
                contentType: false,
                processData: false,
                success: function (res) {
                        if (res.html2 != null) {
                            $('#body-content-action').html(res.html2);
                        }
                        $('#body-content-view').html(res.html);
                    //else {
                    //    $('#body-content-action').html(res.html2);
                    //}
                },
                error: function (err) {
                    console.log(err);
                }
            })
                .fail(function (jqXHR, textStatus, errorThrown) {
                    window.location.href = "/Home/Error";
                })
            //para prevenir el evento submit del form
            return false;
        } catch (e) {
            console.log(e);
        }
    }
};

jQueryAjaxDeleteForm = form => {
    event.preventDefault();
    try {
        Swal.fire({
            title: '¿Estás seguro de eliminar este registro?',
            text: "No podrás revertir los cambios.",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Eliminar'
        }).then((result) => {
            if (result.value) {
                $.ajax({
                    type: "POST",
                    url: form.action,
                    data: new FormData(form),
                    contentType: false,
                    processData: false,
                    success: function (res) {
                        if (res.html != null) {
                            $('#body-content-action').html(res.html);
                        }
                        $('#body-content-view').html(res.html2);
                        //$('#body-content-viewfoto').html(res.html3);
                    },
                    error: function (err) {
                        console.log(err);
                    }
                })
                    .fail(function (jqXHR, textStatus, errorThrown) {
                        window.location.href = "/Home/Error";
                    })
                return false;
            }
        })
    } catch (e) {
        console.log(e);
    }
};

jQueryAjaxDeleteForm2 = form => {
    event.preventDefault();
    try {
        Swal.fire({
            title: '¿Estás seguro de eliminar este registro?',
            text: "No podrás revertir los cambios.",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Eliminar'
        }).then((result) => {
            if (result.value) {
                $.ajax({
                    type: "POST",
                    url: form.action,
                    data: new FormData(form),
                    contentType: false,
                    processData: false,
                    success: function (res) {
                            $('#body-content-action').html(res.html);
                    },
                    error: function (err) {
                        console.log(err);
                    }
                })
                    .fail(function (jqXHR, textStatus, errorThrown) {
                        window.location.href = "/Home/Error";
                    })
                return false;
            }
        })
    } catch (e) {
        console.log(e);
    }
};



//removeVoluntarioChecked = form => {
//    try {
//        Swal.fire({
//            title: '¿Estás seguro de desvincular al usuario de este seguimiento?',
//            text: "El seguimiento actual se desvinculara del usuario seleccionado.",
//            icon: 'warning',
//            showCancelButton: true,
//            confirmButtonColor: '#3085d6',
//            cancelButtonColor: '#d33',
//            confirmButtonText: 'Aceptar'
//        }).then((result) => {
//            if (result.value) {
//                $.ajax({
//                    type: "POST",
//                    url: form.action,
//                    data: new FormData(form),
//                    contentType: false,
//                    processData: false,
//                    success: function (res) {
//                        $('#view-all').html(res.html);
//                    },
//                    error: function (err) {
//                        console.log(err);
//                    }
//                })
//                    .fail(function (jqXHR, textStatus, errorThrown) {
//                        window.location.href = "/Home/Error";
//                    })
//                return false;
//            }
//        })
//    } catch (e) {
//        console.log(e);
//    }
//};



//showChangedState = form => {

//};

//$('select').on('change', function() {
//    try {
//        $.ajax({
//            type: "POST",
//            url: this.form.action,
//            data: new FormData(this.form),
//            contentType: false,
//            processData: false,
//            success: function (res) {
//                    $('#body-content-view').html(res.html);
//                    //$('#example').DataTable().draw();
//            },
//            error: function (err) {
//                console.log(err);
//            }
//        })
//        //para prevenir el evento submit del form
//        //return false;
//    } catch (e) {
//        console.log(e);
//    }
//});



showFormAux = form => {
    //alert($("form").valid());
    event.preventDefault();
    if ($("form").valid()) {
        try {
            $.ajax({
                type: "POST",
                url: form.action,
                data: new FormData(form),
                contentType: false,
                processData: false,
                success: function (res) {
                        $('#body-content-action').html(res.html);
                },
                error: function (err) {
                    console.log(err);
                }
            })
                .fail(function (jqXHR, textStatus, errorThrown) {
                    window.location.href = "/Home/Error";
                })
            return false;
        } catch (e) {
            console.log(e);
        }
    }
};