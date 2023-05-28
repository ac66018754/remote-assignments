function countAandB(input){
    let ans=0;
    input.forEach(element => {
        if(element==='a'||element==='b')ans++
    });
    return ans;
}
function toNumber(input){
    let ans=[];
    input.forEach(element=>{
      ans.push(element.toLowerCase().codePointAt()-96)  
    })
    return ans;
}
let input1=['a','b','c','a','c','a','c']
let input2=['e','d','c','d','e']
console.log(countAandB(input1))
console.log(toNumber(input1))
console.log(countAandB(input2))
console.log(toNumber(input2))