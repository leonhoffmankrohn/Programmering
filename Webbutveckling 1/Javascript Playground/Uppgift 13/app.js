// Del 13 A

let counter = 0;

while (true){
    counter++;
    console.log(counter)
    if (counter >= 10) break;
}

// Del 13 B /

// A
function Greet(){
    return "hello world";
}

console.log(Greet());

// B

Hello();
function Hello(){
    console.log("Yo");
    Helloagain();
}
function Helloagain(){
    console.log("Yo again");
}

// C
function Calculator(int1, int2, operand){
    // if (!((operand == '+') || (operand == '-') || (operand == '*') || (operand == '/'))) return "error";
    switch(operand){
        case '+':
            return int1+int2;
        
        case '-':
            return int1-int2;

        case '*':
            return int1*int2;

        case '/':
            return int1/int2;
        
        default:
            return "error"
    }
}

console.log("57+3 = " + Calculator(57,3,'+'))
console.log("57-3 = " + Calculator(57,3,'a'))
console.log("57*3 = " + Calculator(57,3,'*'))
console.log("57/3 = " + Calculator(57,3,'/'))