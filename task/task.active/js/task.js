let liList = document.querySelectorAll("ul li");



for (let i = 0; i < liList.length; i++) {
    liList[i].addEventListener("click", function () {
        let active = document.querySelector(".active");
        this.classList.add("active");
        active.classList.remove("active")

    })

}

