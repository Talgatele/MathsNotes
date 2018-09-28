// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    console.log("loaded");

    $("#input-pane").keyup(function () {
        $("#output-pane").text($("#input-pane").val());
    });

    $('#input-pane').on('keyup paste', function () {
        var $inputPane = $(this);
        var $outputPane = $("#output-pane");
        var offset = $inputPane.innerHeight() - $inputPane.height();

        if ($inputPane.innerHeight < this.scrollHeight) {
            //Grow the field if scroll height is smaller
            $inputPane.height(this.scrollHeight - offset);
            $outputPane.height(this.scrollHeight - offset);
        } else {
            //Shrink the field and then re-set it to the scroll height in case it needs to shrink
            $inputPane.height(1);
            $outputPane.height(1);
            $inputPane.height(this.scrollHeight - offset);
            $outputPane.height(this.scrollHeight - offset);
        }
    });
});    