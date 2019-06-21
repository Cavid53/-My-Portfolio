var sidebar=document.querySelector(".sidebar");
var icon=document.querySelector(".sidebar span");
var button=document.querySelector("#button");

button.addEventListener("click",function(){
   sidebar.style.transform="translateY(0)";
})

icon.addEventListener("click",function(){
    sidebar.style.transform="translateY(-150px)";
})