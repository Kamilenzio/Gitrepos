var userClickedPattern = [];
var gamePattern = [];
var buttonColours = ["red", "blue", "green", "yellow"];
var started = false;
var level = 0;

function nextSequence(){
    userClickedPattern = [];
    var randomNumber = Math.random()*4
    randomNumber = Math.floor(randomNumber)
    randomChosenColour = buttonColours[randomNumber];
    gamePattern.push(randomChosenColour)
    animateEffect()
    sequenceSoundEffect(randomChosenColour)
    level++
    $("#level-title").text("Level "+ level)
    
}

function animateEffect(){
    $("#"+randomChosenColour).fadeIn(100).fadeOut(100).fadeIn(100).animate({margin: "20%"}, 150).animate({margin: "25px"});

}

function sequenceSoundEffect(color){
        var audio = new Audio ("sounds/"+color+".mp3")
        audio.play()
}


$(".btn").click(function(){
    var userChosenColour =$(this).attr("id");
    userClickedPattern.push(userChosenColour);
    console.log(userClickedPattern)
    playSound(userChosenColour)
    animatePress(userChosenColour)
    checkAnswer(userClickedPattern.length-1);

    })

function playSound(name){
    var playerClick = new Audio ("sounds/"+name+".mp3")
    playerClick.play()
}

function animatePress(currentColor){
    var addedClass = $("#"+currentColor).addClass("pressed");
    setTimeout(function(){
        addedClass.removeClass("pressed")
    }, 200)
}

$(document).keypress(function(keyClicked){
    console.log(keyClicked)
    if (!started)
    {
        $("#level-title").text("Level "+ level)
        nextSequence()
        started = true
    }
});

function checkAnswer(currentLevel){
    if (gamePattern[currentLevel] === userClickedPattern[currentLevel])
    {
        console.log("success")
        if (userClickedPattern.length === gamePattern.length){
            setTimeout(function(){
                nextSequence()
            }, 1000);
        }
    }
    else
    {
        var audio = new Audio ("sounds/wrong.mp3")
        audio.play();
        $("body").addClass("game-over")
        setTimeout(function(){
            $("body").removeClass("game-over")
        }, 300)
        $("h1").text("😤Game Over, Press Any Key to Restart😤")
        console.log("wrong")
        startOverGame()
    }
};

function startOverGame(){
    level = 0;
    gamePattern = [];
    started = false;
}