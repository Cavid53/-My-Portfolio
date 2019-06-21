
var li=document.querySelectorAll("#ul li");
var ul=document.querySelector("#ul");
var content=document.querySelectorAll(".content");

// for(var i=0;i<li.length;i++){
//     li[i].addEventListener("click",function(){
//    var active_content=document.querySelector(".active_content");
//   //  active_content.classList.remove("active_content")
//   //  ul.nextElementSibling.classList.add("active_content");
//   console.log(content[i])

//  // content[i].classList.add("active_content")
//     })
// }

for(let item of li)
{
  item.addEventListener("click",function(){
    removeActiveContent(".content");
     var clickedLi=this.getAttribute("data-click");
     document.querySelector(`div[data-click=${clickedLi}]`).classList.add("active_content")
  })
}

function removeActiveContent(selector)
{
   for(let item of document.querySelectorAll(selector))
   {
       item.classList.remove("active_content");
   }
}


