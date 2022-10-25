
document.getElementById("plus").addEventListener('click', function () {


    let btn1 = document.getElementById('quantity');
    quantity = btn1.innerHTML;
    quantity = parseInt(quantity);
    quantity += 1;

    btn1.innerHTML = quantity;

    let btn2 = document.getElementById('unit_price');
    unit = btn2.innerHTML;
    unit = parseInt(unit);

    let btn3 = document.getElementById('price');
    price = unit * quantity;
    btn3.innerHTML = price;
});

document.getElementById("minus").addEventListener('click', function () {


    let btn1 = document.getElementById('quantity');
    quantity = btn1.innerHTML;
    quantity = parseInt(quantity);
    if (quantity >1) {


        quantity -= 1;

        btn1.innerHTML = quantity;

        let btn2 = document.getElementById('unit_price');
        unit = btn2.innerHTML;
        unit = parseInt(unit);

        let btn3 = document.getElementById('price');
        price = unit * quantity;
        btn3.innerHTML = price;
    }
});