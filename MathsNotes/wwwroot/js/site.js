﻿$(document).ready(function () {
    setDivHeight();
    var navOpen = false;

    //mirror text in input textarea to output textarea on each key up action
    $("#input-pane").keyup(function () {
        var inputText = $("#input-pane").val();
        $("#output-pane").text(inputText);

        if (inputText.length > 0) {
            $.post("/Notepad/Parse", { inputText: inputText });
        }

        var math = document.getElementById("output-pane");
        MathJax.Hub.Queue(["Typeset", MathJax.Hub, math]);
    });

    //grow the length of the textareas, and shrink based on the amount of content
    $('#input-pane').on('input paste', function () {
        setDivHeight();
    });

    //sets scroll height
    function setDivHeight() {
        var scroll_height = $("#input-pane").get(0).scrollHeight;

        $("#input-pane").css('height', scroll_height + 'px');
        $("#output-pane").css('height', scroll_height + 'px');
    }

    ///toggles the nav wiki to be open or closed
    $("#navToggleBtn").on('click', function () {
       if (navOpen) {
            $("#mySidenav").css('width', '0px');
            $("#main").css('marginLeft', '0px');
            $("#navToggleBtn").text('☰ Open Wiki');
            navOpen = false;
        }
        else {
            $("#mySidenav").css('width', '390px');
            $("#main").css('marginLeft', '10%');
            $("#navToggleBtn").text('☰ Close Wiki');
            navOpen = true;
        }
    });

    $("#printBtn").on('click', function () {
        var printWindow = window.open('', 'PRINT', 'height=400,width=600');

        printWindow.document.write('<html><head><title>' + document.title + '</title>');
        printWindow.document.write('</head><body >');
        printWindow.document.write('<h1>' + document.title + '</h1>');
        printWindow.document.write(document.getElementById('output-pane').innerHTML);
        printWindow.document.write('</body></html>');
        printWindow.document.close(); // necessary for IE >= 10
        printWindow.focus(); // necessary for IE >= 10*/

        printWindow.print();
        printWindow.close();
    });
});   