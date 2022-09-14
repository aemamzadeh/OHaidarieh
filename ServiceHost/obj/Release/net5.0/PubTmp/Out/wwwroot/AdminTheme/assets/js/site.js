var SinglePage = {};

SinglePage.LoadModal = function () {
    var url = window.location.hash.toLowerCase();
    if (!url.startsWith("#showmodal")) {
        return;
    }
    url = url.split("showmodal=")[1];
    $.get(url,
        null,
        function (htmlPage) {
            $("#ModalContent").html(htmlPage);
            const container = document.getElementById("ModalContent");
            const forms = container.getElementsByTagName("form");
            const newForm = forms[forms.length - 1];
            $.validator.unobtrusive.parse(newForm);
            showModal();
        }).fail(function (error) {
            alert("خطایی رخ داده، لطفا با مدیر سیستم تماس بگیرید.");
        });
};

function showModal() {
    $("#MainModal").modal("show");
}

function hideModal() {
    $("#MainModal").modal("hide");
}

$(document).ready(function () {
    window.onhashchange = function () {
        SinglePage.LoadModal();
    };
    $("#MainModal").on("shown.bs.modal",
        function () {
            window.location.hash = "##";
            $('.persianDateInput').persianDatepicker({
                format: 'YYYY/MM/DD',
                autoClose: true
            });
        });

    $(document).on("submit",
        'form[data-ajax="true"]',
        function (e) {
            e.preventDefault();
            var form = $(this);
            const method = form.attr("method").toLocaleLowerCase();
            const url = form.attr("action");
            var action = form.attr("data-action");

            if (method === "get") {
                const data = form.serializeArray();
                $.get(url,
                    data,
                    function (data) {
                        CallBackHandler(data, action, form);
                    });
            } else {
                var formData = new FormData(this);
                $.ajax({
                    url: url,
                    type: "post",
                    data: formData,
                    enctype: "multipart/form-data",
                    dataType: "json",
                    processData: false,
                    contentType: false,
                    success: function (data) {
                        CallBackHandler(data, action, form);
                    },
                    xhr: function () {
                        var fileXhr = $.ajaxSettings.xhr();
                        //var progressnum = (100.0 * file.Data.Position / file.Size).ToString("0");
                        if (fileXhr.upload) {
                            $("#progress").show();
                            fileXhr.upload.addEventListener("progress", function (e) {
                                if (e.lengthComputable) {
                                    //$("#fileProgress").attr('aria-valuemax', e.total);
                                    //$("#fileProgress").attr('aria-valuenow', e.loaded);
                                    //$("#fileProgress").css('width', e.loaded);
                                    var percentComplete = e.loaded / e.total;
                                    percentComplete = parseInt(percentComplete * 100);
                                    $("#progress").height(20);
                                    $('.progress-bar').width(percentComplete + '%');
                                    $('.progress-bar').html(percentComplete + '%');
                                }
                            }, false);
                        }
                        return fileXhr;
                    },
                    error: function (data) {
                        alert("خطایی رخ داده است. لطفا با مدیر سیستم تماس بگیرید.");
                    }
                });
            }
            return false;
        });
});


function FillSerializeDropdown(source, action, dist) {
    $('#' + dist).empty();
    var selectedId = $('#' + source).find("option:selected").val();
    $.getJSON('?handler=' + action + '&Id=' + selectedId, function (data) {
        $.each(data, function (key, parentlist) {
            //$('select#' + dist).append('<option value="0">Select One</option>');
            // loop through the TM Managers and fill the dropdown
            //$.each(parentlist, function (index, parent) {
            $('select#' + dist).append(
                '<option value="' + parentlist.id + '">'
                + parentlist.title +
                '</option>');
            //});
        });
    });
}

    function CallBackHandler(data, action, form) {
        switch (action) {
            case "Message":
                alert(data.Message);
                break;
            case "Refresh":
                if (data.isSuccedded) {
                    window.location.reload();
                } else {
                    alert(data.message);
                }
                break;
            case "RefereshList":
                {
                    hideModal();
                    const refereshUrl = form.attr("data-refereshurl");
                    const refereshDiv = form.attr("data-refereshdiv");
                    get(refereshUrl, refereshDiv);
                }
                break;
            case "setValue":
                {
                    const element = form.data("element");
                    $(`#${element}`).html(data);
                }
                break;
            default:
        }
    }

    function get(url, refereshDiv) {
        const searchModel = window.location.search;
        $.get(url,
            searchModel,
            function (result) {
                $("#" + refereshDiv).html(result);
            });
    }

    function makeSlug(source, dist) {
        const value = $('#' + source).val();
        $('#' + dist).val(convertToSlug(value));
    }

    var convertToSlug = function (str) {
        var $slug = '';
        const trimmed = $.trim(str);
        $slug = trimmed.replace(/[^a-z0-9-آ-ی-]/gi, '-').replace(/-+/g, '-').replace(/^-|-$/g, '');
        return $slug.toLowerCase();
    };

    function checkSlugDuplication(url, dist) {
        const slug = $('#' + dist).val();
        const id = convertToSlug(slug);
        $.get({
            url: url + '/' + id,
            success: function (data) {
                if (data) {
                    sendNotification('error', 'top right', "خطا", "اسلاگ نمی تواند تکراری باشد");
                }
            }
        });
    }

    function fillField(source, dist) {
        const value = $('#' + source).val();
        $('#' + dist).val(value);
    }


    $(document).on("click",
        'button[data-ajax="true"]',
        function () {
            const button = $(this);
            const form = button.data("request-form");
            const data = $(`#${form}`).serialize();
            let url = button.data("request-url");
            const method = button.data("request-method");
            const field = button.data("request-field-id");
            if (field !== undefined) {
                const fieldValue = $(`#${field}`).val();
                url = url + "/" + fieldValue;
            }
            if (button.data("request-confirm") == true) {
                if (confirm("آیا از انجام این عملیات اطمینان دارید؟")) {
                    handleAjaxCall(method, url, data);
                }
            } else {
                handleAjaxCall(method, url, data);
            }
        });

    function handleAjaxCall(method, url, data) {
        if (method === "post") {
            $.post(url,
                data,
                "application/json; charset=utf-8",
                "json",
                function (data) {

                }).fail(function (error) {
                    alert("خطایی رخ داده است. لطفا با مدیر سیستم تماس بگیرید.");
                });
        }
    }


function AddCount(id, elementid) {
    //$.ajax({
        //url: '?handler=AddVisitCount' + '&id=' + id,
        //type: "get",
        //data: formData,
        //newdata: document.getElementById(elementid),
        //success: function (data) {
            //$('#' + dist).location.reload();
            //get("ReloadCounter", function (data) {
            //    $("ReloadCounter").html(data);
            //});
            //$('#' + elementid).load(location.href + "#" + elementid);
            //let url = "#counter[" + this.attr(id) + "]";
            //$(url ).html("");
            //$(url).reload(location.href + url);
            //$("select #counter[" + id + "]").html("");
           // $("#counter['" + id + "']").append('<span style="color:white" id="counter[' + id + ']"><span class="fa fa-eye" aria-hidden="true"></span>' + data + '</span>');
            $.get("?handler=AddVisitCount&id=" + id, function (result) {
            $('.counter[data-videoid="' + id + '"]').html('<span class="fa fa-eye" aria-hidden="true"></span>' + result);
            });
        //},
        //failure: function (response) {
        //    alert(response.responseText);
        //},
        //error: function (response) {
        //    alert(response.responseText);
        }
    //});
    //}



//$(function () {
//    //On click of .AddToCart
//    $(".AddVisitCount").click(function () {
//        // Get the id from the link
//        var addToCart = $(this).attr("data-id");
//        if (addToCart != '') {
//            $.post("/ShoppingCart/AddToCart", { "id": addToCart }).success(function (data) {
//                $('#cart-status').fadeIn().html('Cart  ' + '<span class="badge">' + data.CartCount + '</span>');
//            });
//            return false;
//        };
//    });
//});




    
    jQuery.validator.addMethod("maxFileSize",
        function (value, element, params) {
            var size = element.files[0].size;
            var maxSize = 300 * 1024 * 1024;
            if (size > maxSize)
                return false;
            else {
                return true;
            }
        });
    jQuery.validator.unobtrusive.adapters.addBool("maxFileSize");

    //jQuery.validator.addMethod("maxFileSize",
    //    function (value, element, params) {
    //        var size = element.files[0].size;
    //        var maxSize = 3 * 1024 * 1024;
    //        debugger;
    //        if (size > maxSize)
    //            return false;
    //        else {
    //            return true;
    //        }
    //    });
    //jQuery.validator.unobtrusive.adapters.addBool("maxFileSize");

