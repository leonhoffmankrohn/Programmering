let tärning1 = Math.floor(Math.random() * 6) + 1;
let tärning2 = Math.floor(Math.random() * 6) + 1;

console.log("tärning1: " + tärning1 + "\ntärning2: " + tärning2 + "\n");

if ((tärning1 + tärning2) == 12){
    console.log("knockout!");
}
