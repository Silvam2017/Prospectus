
// Add third party table functionality to our SQL QB table

// When document is ready, turn 'qbTable' into a DataTable with ensuing options

$(document).ready(function () {
    $('#qbTable').DataTable({
        "scrollY": "450px",
        "scrollCollapse": true,
        "paging": false
    })
});

$(document).ready(function () {
    $('#qbTable2').DataTable({
        "scrollY": "450px",
        "scrollCollapse": true,
        "paging": false
    })
});