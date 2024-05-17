Initialize();

let playingNumber = document.querySelector(".game-number");
let dice1 = document.querySelector(".dice1");
let dice2 = document.querySelector(".dice2");
let setup = document.querySelector(".setup");
let roller = document.querySelector(".roller");
let gameOverDiv = document.querySelector(".game-over-div");

let score = 0;

// Kommentarer må blanda sig i språk, jobbigt att läsa kod på engelska och beskriva dem på svenska

// Checkar om spelaren kan spela, varnar annars spelaren att välja ett annat nummer
function Play(){
    if (+playingNumber.value <= 9 && +playingNumber.value >= 6 ){
        setup.style.visibility = "collapse";
        roller.style.visibility = "visible";
    }
    else{
        alert("Please enter a valid number");
    }
}

// Körs varje gång spelaren väljer att köra om sitt spel
function PlayAgain(){
    Reset();
    setup.style.visibility = "visible";
    gameOverDiv.style.visibility = "collapse";
}

// Updaterar värdefull information för spelaren
function UpdateInfo(txtInfo){
    document.querySelector(".info-text").textContent = txtInfo;
}

// Runs when the game is over, turns on the gameover screen
function GameOver(){
    roller.style.visibility = "collapse";
    gameOverDiv.style.visibility = "visible";
    UpdateInfo("Selected death \"" + playingNumber.value + "\" but you got " + score + " points")
}

// Gets två randomized dices, gets the sum, compares the sum to endnumber and is either game over or not.
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

// returns true if the dicesum equals the playingnumber else false
function IsPlayingNr(playingNr, theSum){
    console.log(playingNr + " - " + theSum);
    return (+playingNr == +theSum);
}

// Calculates sum of to inputs (dices)
function CalculateSum(x, y){
    return x+y;
}

// Randomizes the two dices to a different value 1-6 and sets their textcontent to it.
function RandomateDice(elem){
    let randomint = Math.floor(Math.random()*6)+1;
    elem.textContent = randomint;
}

// Resets eventual numbers for play again, not including the status/info-text for it is nice to know the previous score.
function Reset(){
    playingNumber.textContent = "";
    dice1.textContent = "0";
    dice2.textContent = "0";
    score = 0;
}

// Sets initial sizes and style properties, Math.max statement not intierly created by me.
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

