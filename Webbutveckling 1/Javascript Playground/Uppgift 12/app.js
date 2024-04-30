let talArray = [2,3,6,9,11,12,13,15,16,17,18,21,23,25];

let even = 0;
let odd = 0;
    
for (let i = 0; i < talArray.length; i++){
    if ((talArray[i] % 2) == 0) even++;
    else odd++;
}

console.log("Even: " + even + "\nOdd: " + odd);