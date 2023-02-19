$(document).ready(function () {
    $(".addToBasket").click(function (e) {
        e.preventDefault();
        let productId = $(this).data('id')

        fetch('basket/AddBasket?id=' + productId)
            .then(res => { return res.text() })
            .then(data => {
                console.log(data);
                $('.header-cart').html(data)
            })




    })
    $(".productModal").click(function (e) {
        e.preventDefault();
        let url = $(this).attr("href");
        //console.log(url);
        fetch(url).then(res => {
            return res.text();
        })
            .then(data => {
                $('.modal-content').html(data);

                $('.quick-view-image').slick({
                    slidesToShow: 1,
                    slidesToScroll: 1,
                    arrows: false,
                    dots: false,
                    fade: true,
                    asNavFor: '.quick-view-thumb',
                    speed: 400,
                });

                $('.quick-view-thumb').slick({
                    slidesToShow: 4,
                    slidesToScroll: 1,
                    asNavFor: '.quick-view-image',
                    dots: false,
                    arrows: false,
                    focusOnSelect: true,
                    speed: 400,
                });


           
                console.log(data)
            })
    })
    $(document).on('keyup', '.productCount', function () {
        let count = $(this).val();
        let productId = $(this).attr('data-productId');

        fetch('/Product/ChangeBasketProductCount/' + productId + '?count=' + count).then(res => {
            return res.text();
        }).then(data => {
            console.log(data);
            $(".productTable").html(data);
        })

    })
})