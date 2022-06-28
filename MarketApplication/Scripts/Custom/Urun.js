function SepeteEkle(urunId,adet) {
    $.ajax({
        type: "GET",
        url: "/urun/sepetEkle?id=" + urunId + "&adet=" + adet,
        success: function (res) {
            alert(res);
        },
        error: function () {
            alert("bir hata oluştu");
        }
    })
}

$(document).on("click", '[event="SepeteEkle"]', function (e) {
    e.preventDefault();
    debugger;
    var adet = $("#adet").val();
    var urunId = $(this).attr("UrunId");
    SepeteEkle(urunId, adet);
})