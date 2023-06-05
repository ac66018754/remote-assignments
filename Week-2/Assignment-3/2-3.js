function count(data){
    let ans={}
    data.forEach(element => {
        if(!ans[element])ans[element]=1
        else ans[element]+=1
    });
    return ans
}
let input1=["a","b","c","a","c","a","x"]
console.log(count(input1))

function groupByKey(input){
    let ans={}
    input.forEach(element => {
        if(!ans[element.key])ans[element.key]=element.value
        else ans[element.key]+=element.value
    });
    return ans
}
let input2=[
    {key:"a",value:3},
    {key:"b",value:1},
    {key:"c",value:2},
    {key:"a",value:3},
    {key:"c",value:5},
]
console.log(groupByKey(input2))


// function count(data){
//     let m=new Map()
//     let ans=[]
//     data.forEach(element => {
//         if(!m.has(element))m.set(element,1)
//         else m.set(element,m.get(element)+1)
//     });
//     for (let [key, value] of m) {
//         ans.push(value);
//     }
//     return m
// }