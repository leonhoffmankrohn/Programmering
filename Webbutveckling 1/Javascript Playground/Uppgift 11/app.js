
// A/
for (let i = 0; i < 100; i++){
    console.log("Varv " + i + ", slumptal: " + Math.floor(Math.random()*100))
}

// B/
let x = 0;
let roof = 5;
for (let i = 0; i < roof; i++){
    x += i;
}
console.log("Loopresultat: " + x);

// C/
let antalSexor = 0;
for (let i = 0; i < 1000; i++){
    let tärning = Math.floor(Math.random()*6)+1;
    antalSexor += (tärning == 6) ? 1 : 0;
}
console.log("Antalet sexor: "+antalSexor)

// D/
let antalGgr = [0,0,0,0,0,0]
let antalSlag = 1000;

for (let i = 0; i < antalSlag; i++){
    let tärning = Math.floor(Math.random()*6) + 1;
    antalGgr[tärning-1] +=1;
}
let tot = 0;
for (let i = 1; i <= 6; i++){
    console.log(i + ":or - " + antalGgr[i-1]);
    tot += antalGgr[i-1];
}
console.log("Tot: " + tot)

// A(2)/

for (let i = 0; i < 50; i++){
    if (i == 25) break;
}