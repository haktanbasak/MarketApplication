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

$(document).on("click", "#besin", function () {
    bootbox.alert({
        title: "Besin Değeri",
        message: "her 100g - Kaloriler: 498kcal | Yağ: 25,80g | Karb: 57,80g | Prot: 6,70g ",
        size: 'medium'
    });
})

$(document).on("click", "#icindekiler", function () {
    bootbox.alert({
        title: "İçindekiler",
        message: "her 100g - Kaloriler: 498kcal | Yağ: 25,80g | Karb: 57,80g | Prot: 6,70g ",
        size: 'large'
    });
})