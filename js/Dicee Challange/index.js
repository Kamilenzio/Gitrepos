
var randomNumber1 = Math.random();
randomNumber1 = (randomNumber1 * 6) + 1;
randomNumber1 = Math.floor(randomNumber1);

var randomDiceImage = "dice" + randomNumber1 + ".png"
var randomImageSource = "images/" + randomDiceImage;

var img1 = document.querySelectorAll("img")[0];
img1.setAttribute("src", randomImageSource)

var randomNumber2 = Math.random();
randomNumber2 = (randomNumber2 *6) +1;
randomNumber2 = Math.floor(randomNumber2);

var randomPath = "images/dice"+randomNumber2+".png";
var localizeSecondDice = document.querySelectorAll("img")[1];
localizeSecondDice.setAttribute("src", randomPath);

var whoWonText = document.querySelector("h1")
whoWonText.innerHTML = "Player 1 won"

if (randomNumber1 > randomNumber2) {
    whoWonText.innerHTML = "📢Player 1 wins"
}

else if (randomNumber1 === randomNumber2) {
    whoWonText.innerHTML = "Draft!=Equal"
    alert("It's DRAFT!")
}

else {
    whoWonText.innerHTML = "Player 2 wins!💣"

}