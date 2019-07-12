$(function () {

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
}