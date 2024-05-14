Initialize();

let playingNumber = document.querySelector(".game-number");
let dice1 = document.querySelector(".dice1");
let dice2 = document.querySelector(".dice2");
let setup = document.querySelector(".setup");
let roller = document.querySelector(".roller");
let gameOverDiv = document.querySelector(".game-over-div");


let score = 0;

function Play(){
    if (+playingNumber.value <= 9 && +playingNumber.value >= 6 ){
        setup.style.visibility = "collapse";
        roller.style.visibility = "visible";
    }
    else{
        alert("Please enter a valid number");
    }
}

function PlayAgain(){
    Reset();
    setup.style.visibility = "visible";
    gameOverDiv.style.visibility = "collapse";
}

function UpdateInfo(txtInfo){
    document.querySelector(".info-text").textContent = txtInfo;
}

function GameOver(){
    roller.style.visibility = "collapse";
    gameOverDiv.style.visibility = "visible";
    UpdateInfo("Selected death \"" + playingNumber.value + "\" but you got " + score + " points")
}

function Roll(){
    RandomateDice(dice1);
    RandomateDice(dice2);
    let sum = CalculateSum(+dice1.textContent, +dice2.textContent)
    let gameOver = IsPlayingNr(+playingNumber.value, sum);
    
    if (gameOver){
        GameOver();
    }
    else{
        score += sum;
        UpdateInfo("Selected death \"" + playingNumber.value + "\" but you have " + score + " points");
    }
}

function IsPlayingNr(playingNr, theSum){
    console.log(playingNr + " - " + theSum);
    return (+playingNr == +theSum);
}

function CalculateSum(x, y){
    return x+y;
}

function RandomateDice(elem){
    let randomint = Math.floor(Math.random()*6)+1;
    elem.textContent = randomint;
}


function Reset(){
    playingNumber.textContent = "";
    dice1.textContent = "0";
    dice2.textContent = "0";
    score = 0;
}

function Initialize(){
    let htmlElement = document.documentElement;
    let bodyElement = document.body;
    let height = Math.max(
        htmlElement.clientHeight,
        htmlElement.scrollHeight,
        htmlElement.offsetHeight,
        bodyElement.scrollHeight,
        bodyElement.offsetHeight
    );
    bodyElement.style.backgroundColor = "lightblue";
    document.body.style.height = height + 'px';
}

