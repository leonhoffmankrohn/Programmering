let literBensinKvar = 9;
let totVolymTanken = 50;
let literpris = 14.50;

if (literBensinKvar < 10)
{
    let kanTanka = totVolymTanken - literBensinKvar;
    console.log("Bensin i tanken: " + literBensinKvar + 
                " l\nDu kan tanka: " + kanTanka +
                " l\nDet kostar: " + (kanTanka * literpris) + " kr")
}
else console.log("Du kan köra vidare");