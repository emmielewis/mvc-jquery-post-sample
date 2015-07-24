$("#btnSubmit").on("click", function () {
    SearchForData();
});

function SearchForData() {
    //Need to get the URL for the search method on the controller.
    //Afterwards, we need to create a serialized string for the search and scope data.
    //post the data to the page and then add to a HTML div to show.
    $.post(performSearchURL, 'SearchScope=' + $("select#SearchScope").val() + '&SearchString=' + $("input#SearchString").val(),
        function (data) {
            $.jsontotable(data, { id: '#resultsView', header: false });
        });
}
