let isTooltipVisible = false;

function UpdateTooltipVisibility() {
    if (isTooltipVisible) {
        $("#tooltip").show();
        console.log('show tooltip');
    }
    else {
        $("#tooltip").hide();
    }
}

$(document).ready(function () {
    $(".planet-card").click(function () {
        isTooltipVisible = true;
        UpdateTooltipVisibility();
        let name = $(this).data('name');
        console.log(name);

        $.ajax({
            url: "/Home/Tooltip",
            type: "GET",
            data: { name: name }
        })
            .done(function (partialViewResult) {
                $('#tooltip').html(partialViewResult);
            });
    });
});