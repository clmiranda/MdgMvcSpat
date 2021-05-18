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
            window.location.href = "/Home/Error/" + jqXHR.statusCode;
        })
};

jQueryAjaxPost = form => {
    //var datos = $("form")
    //    .removeData("validator") /* added by the raw jquery.validate plugin */
    //    .removeData("unobtrusiveValidation");  /* added by the jquery unobtrusive plugin*/
    event.preventDefault();
    if ($("form").valid()) {
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
                else
                    $('#form-modal .modal-body').html(res.html);
            },
            error: function (err) {
                console.log(err);
            }
        })
            .fail(function (jqXHR, textStatus, errorThrown) {
                window.location.href = "/Home/Error/" + jqXHR.status;
            })
        return false;
    }
};

jQueryAjaxDelete = form => {
    event.preventDefault();
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
                },
                error: function (err) {
                    console.log(err);
                }
            })
                .fail(function (jqXHR, textStatus, errorThrown) {
                    window.location.href = "/Home/Error/" + jqXHR.status;
                })
            return false;
        }
    })
};

jQueryAjaxPostList = form => {
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
            window.location.href = "/Home/Error/" + jqXHR.status;
        })
    return false;
};


jQueryAjaxPostAlterno = form => {
    $.ajax({
        type: "POST",
        url: form.action,
        data: new FormData(form),
        contentType: false,
        processData: false,
        success: function (res) {
            if (res.isValid) {
                $('#body-content-view').html(res.html);
                $('#body-content-action').html(res.html2);
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
            window.location.href = "/Home/Error/" + jqXHR.status;
        })
    return false;
};


showForm = form => {
    event.preventDefault();
    if ($("form").valid()) {
        $.ajax({
            type: "POST",
            url: form.action,
            data: new FormData(form),
            contentType: false,
            processData: false,
            success: function (res) {
                $('#body-content-view').html(res.html);
                $('#body-content-action').html(res.html2);
            },
            error: function (err) {
                console.log(err);
            }
        })
            .fail(function (jqXHR, textStatus, errorThrown) {
                window.location.href = "/Home/Error/" + jqXHR.status;
            })
        return false;
    }
};

jQueryAjaxDeleteForm = form => {
    event.preventDefault();
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
                },
                error: function (err) {
                    console.log(err);
                }
            })
                .fail(function (jqXHR, textStatus, errorThrown) {
                    window.location.href = "/Home/Error/" + jqXHR.status;
                })
            return false;
        }
    })
};

jQueryAjaxDeleteForm2 = form => {
    event.preventDefault();
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
                    window.location.href = "/Home/Error/" + jqXHR.status;
                })
            return false;
        }
    })
};

showFormAux = form => {
    event.preventDefault();
    if ($("form").valid()) {
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
                window.location.href = "/Home/Error/" + jqXHR.status;
            })
        return false;
    }
};