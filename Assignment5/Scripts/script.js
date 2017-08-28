$(document).ready(function () {
    $('#TableId').DataTable
    ({
        "columnDefs": [
          {
              "width": "5%",
              "targets": [0]
          },
          {
              "className": "text-center custom-middle-align",
              "targets": [0, 1, 2, 3, 4, 5, 6]
          }, ],
        "language":
        {
            "processing": "<div class='overlay custom-loader-background'><i class='fa fa-cog fa-spin custom-loader-color'></i></div>"
        },
        "processing": true,
        "serverSide": true,
        "ajax":
      {
          "url": "/Plugin/GetData",
          "type": "POST",
          "dataType": "JSON"
      },
        "columns": [
          {
              "data": "Id"
          },
          {
              "data": "Name"
          },
          {
              "data": "Email"
          },
          {
              "data": "Phone"
          },
          {
              "data": "Marital Status"
          },
          {
              "data": "Action"
          }]

    });
})
function FillCity() {
    var stateId = $('#State').val();
    $.ajax({
        url: '/Home/FillCity',
        type: "GET",
        dataType: "JSON",
        data: { State: stateId },
        success: function (Cty) {
            $("#Cty").html(""); // clear before appending new list
            $.each(cities, function (i, city) {
                $("#Cty").append(
                    $('<option></option>').val(city.CtyId).html(Cty.Name));
            });
        }
    });
}

