const welcomeBlock=document.getElementById('welcome');
welcomeBlock.addEventListener('click',(e)=>{
    e.target.children[0].innerHTML="Have a Good Time!";
})

const button=document.getElementById("Footer_div");
const secondContentBlock=document.getElementById("secondContentBlock");
button.addEventListener('click',()=>{
    secondContentBlock.className=secondContentBlock.className.replace('none','')
})