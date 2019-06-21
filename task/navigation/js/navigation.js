let ul=document.querySelector("#ul");
// console.log(ul.parentNode)
// console.log(ul.children[0])
// console.log(ul.childElementCount)
// console.log(ul.children[1].previousElementSibling)

for(let i=0;i<ul.childElementCount;i++){
    ul.children[i].addEventListener("click",function(){
    
      if (this.children[1].classList.contains("fa-times")){
        this.children[1].classList.replace("fa-times","fa-check");
      }else{
        this.children[1].classList.replace("fa-check","fa-times");
      }
        
       
       
        
    

        
    })
}

