

var liList = document.querySelectorAll("#tabs ul li");

for (var i = 0; i < liList.length; i++) {
    liList[i].addEventListener("click", function () {
        //    menu
        var active_menu = document.querySelector(".active_menu");
        this.classList.add("active_menu");
        active_menu.classList.remove("active_menu");

        //  console.log(this.classList.item(0))
        var active_contain = document.querySelector(".active_contain");
        var id = this.classList.item(0);
        document.getElementById(id).classList.add("active_contain");

        active_contain.classList.remove("active_contain");

    })
}