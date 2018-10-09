// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {

    //mirror text in input textarea to output textarea on each keypress
    $("#input-pane").keyup(function () {
        var inputText = $("#input-pane").val();
        $("#output-pane").text(inputText);

        if (inputText.length > 0) {
            $.post("/Notepad/Parse", { inputText: inputText });
        }
    });

    //grow the length of the textareas, and shrink based on the amount of content
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