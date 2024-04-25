let personer = ["Jack", "Peter", "Sara", "Linda", "Johan"];
let löner = [40000, 42000, 48000, 32000, 28000];

console.log("Antal personer: " + personer.length);
for (let i = 1; i <= personer.length; i++){
    console.log("Person " + i + ": " + personer[i-1] + " har en lön " + löner[i-1] + " kr");
}