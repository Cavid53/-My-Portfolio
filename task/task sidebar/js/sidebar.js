var sidebar=document.querySelector(".sidebar");
var button=document.querySelector("#button");
var icon=document.querySelector(".sidebar span");

button.addEventListener("click",function(){

    sidebar.style.transform="translate(0,0)";
    
})
icon.addEventListener("click",function(){
    sidebar.style.transform="translate(-300px,0)";
})





