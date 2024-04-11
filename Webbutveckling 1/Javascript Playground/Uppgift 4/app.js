// Variabler:
let hyrdagar = 5;
let kosnatPerDag = 300;

console.log("Totala kostnaden: " + (hyrdagar * kosnatPerDag) + " kr")

// Del 2
let förbrukadBensin = 140;
let mätarställning = 20000;
let mätarställningGamla = 19000;
let antalMilPerÅr = (mätarställning - mätarställningGamla) / 10;
let bensinPerMil = förbrukadBensin / antalMilPerÅr;

console.log("Dagens mätarställning: " + mätarställning + " km");
console.log("Mätarställningen för ett år sedan: " + mätarställningGamla + " km");
console.log("Bensinförbrukning är: " + förbrukadBensin + " liter");
console.log("Bilen har gått: " + antalMilPerÅr + " mil")
console.log("Bilen har förbrukat: " + bensinPerMil + "liter bensin per mil")

