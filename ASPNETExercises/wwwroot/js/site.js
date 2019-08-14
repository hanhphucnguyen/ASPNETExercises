$(function () {

    if ($("#register_popup") !== undefined) {
        $('#register_popup').modal('show');
    }

    if ($("#login_popup") !== undefined) {
        $('#login_popup').modal('show');
    }

    $("#jsondatartns").on("click", (e) => {
        busySignal("/Data/Json");
    });
    $("#csvdatartns").on("click", (e) => {
        busySignal("/Data/LoadCsv");
    });

    // re-pop modal to show newly created add message
    if ($("#selectedId").val() > 0) {
        let data = $("#catbtn" + $("#selectedId").val()).data("details");
        CopyToModal($("#selectedId").val(), data);
        $("#details_popup").modal("show");
    }

    // details click - to load popup on catalogue
    $("a.btn-outline-dark").on("click", (e) => {
        $("#results").text("");
        let id = e.target.dataset.id;
        let data = JSON.parse(e.target.dataset.details); // it's a string need an object
        CopyToModal(id, data);
    });
    $(".nav-tabs a").on("show.bs.tab", function (e) {
        if ($(e.relatedTarget).text() === "Demographic") { // tab 1
            $("#Firstname").valid();
            $("#Lastname").valid();
            if ($("#Firstname").valid() === false || $("#Lastname").valid() === false) {
                return false; // suppress click
            }
        }
        if ($(e.relatedTarget).text() === "Address") { // tab 2
            $("#Address1").valid();
            $("#City").valid();
            if ($("#Address1").valid() === false || $("#City").valid() === false) {
                return false; // suppress click
            }
        }
        if ($(e.relatedTarget).text() === "Account") { // tab 3
            $("#Email").valid();
            $("#Password").valid();
            $("#RepeatPassword").valid();
            if ($("#Email").valid() === false || $("#Password").valid() === false ||
                $("#RepeatPassword").valid() === false) {
                return false; // suppress click
            }
        }
    }); // show bootstrap tab
});
// populate the modal fields
const CopyToModal = (id, data) => {
    $("#qty").val("0");
    $("#cal").text(data.CAL);
    $("#carb").text(data.CARB);
    $("#chol").text(data.CHOL);
    $("#fat").text(data.FAT);
    $("#fibre").text(data.FBR);
    $("#pro").text(data.PRO);
    $("#salt").text(data.SALT);
    $("#description").text(data.Description);
    $("#detailsGraphic").attr("src", "/images/burger.png");
    $("#selectedId").val(id);
};

let busySignal = (url) => {
    let busyImg = $("<img/>", { src: "/images/wait.gif" });
    $("#busy").empty();
    $("#busy").append(busyImg);
    window.location.href = url;
};