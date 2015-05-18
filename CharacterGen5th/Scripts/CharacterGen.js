//This block is for Stat functions
$("#strScore, #dexScore, #conScore, #intScore, #wisScore, #chaScore").change(UpdateStat);
$("#strScore, #dexScore, #conScore, #intScore, #wisScore, #chaScore").keydown(ValidateInput);  //Must use Keycodes

function ValidateInput(event)
{
    var keyCode = event.keyCode;
    if (keyCode === 13)
    {
        var value = document.getElementById(this.id).value;
        noInput(parseInt(value, 10), this);
        UpdateStat();
    }

    else if (!((keyCode >= 96 && keyCode <= 105) || (keyCode >= 35 && keyCode <= 57) || keyCode <= 8 || event.ctrlKey))
    {
        event.preventDefault();
    }

}

function noInput(num, obj)
{
    if (isNaN(num) || num < 8)
    {
        document.getElementById(obj.id).value = 10;
    }
}

function UpdateStat()
{
    document.getElementById("strBonus").innerHTML = Math.floor(document.getElementById("strScore").value / 2 - 5);
    document.getElementById("dexBonus").innerHTML = Math.floor(document.getElementById("dexScore").value / 2 - 5);
    document.getElementById("conBonus").innerHTML = Math.floor(document.getElementById("conScore").value / 2 - 5);
    document.getElementById("intBonus").innerHTML = Math.floor(document.getElementById("intScore").value / 2 - 5);
    document.getElementById("wisBonus").innerHTML = Math.floor(document.getElementById("wisScore").value / 2 - 5);
    document.getElementById("chaBonus").innerHTML = Math.floor(document.getElementById("chaScore").value / 2 - 5);

    document.getElementById("strTotal").innerHTML = parseInt(document.getElementById("strBonus").innerHTML, 10) + parseInt(document.getElementById("strRacialMod").innerHTML, 10);
    document.getElementById("dexTotal").innerHTML = parseInt(document.getElementById("dexBonus").innerHTML, 10) + parseInt(document.getElementById("dexRacialMod").innerHTML, 10);
    document.getElementById("conTotal").innerHTML = parseInt(document.getElementById("conBonus").innerHTML, 10) + parseInt(document.getElementById("conRacialMod").innerHTML, 10);
    document.getElementById("intTotal").innerHTML = parseInt(document.getElementById("intBonus").innerHTML, 10) + parseInt(document.getElementById("intRacialMod").innerHTML, 10);
    document.getElementById("wisTotal").innerHTML = parseInt(document.getElementById("wisBonus").innerHTML, 10) + parseInt(document.getElementById("wisRacialMod").innerHTML, 10);
    document.getElementById("chaTotal").innerHTML = parseInt(document.getElementById("chaBonus").innerHTML, 10) + parseInt(document.getElementById("chaRacialMod").innerHTML, 10);

    if (document.getElementById("strScore").innerHTML <= 13)
    {
        document.getElementById("strPoints").innerHTML = document.getElementById("strScore").value - 8;
    }

    if (document.getElementById("dexScore").innerHTML <= 13)
    {
        document.getElementById("dexPoints").innerHTML = document.getElementById("dexScore").value - 8;
    }

    if (document.getElementById("conScore").innerHTML <= 13)
    {
        document.getElementById("conPoints").innerHTML = document.getElementById("conScore").value - 8;
    }

    if (document.getElementById("intScore").innerHTML <= 13)
    {
        document.getElementById("intPoints").innerHTML = document.getElementById("intScore").value - 8;
    }

    if (document.getElementById("wisScore").innerHTML <= 13)
    {
        document.getElementById("wisPoints").innerHTML = document.getElementById("wisScore").value - 8;
    }

    if (document.getElementById("chaScore").innerHTML <= 13)
    {
        document.getElementById("chaPoints").innerHTML = document.getElementById("chaScore").value - 8;
    }

    document.getElementById("pointBuyTotal").innerHTML = parseInt(document.getElementById("strPoints").innerHTML, 10) + parseInt(document.getElementById("dexPoints").innerHTML, 10) +
                                                         parseInt(document.getElementById("conPoints").innerHTML, 10) + parseInt(document.getElementById("intPoints").innerHTML, 10) +
                                                         parseInt(document.getElementById("wisPoints").innerHTML, 10) + parseInt(document.getElementById("chaPoints").innerHTML, 10);

    document.getElementById("pointBuyTotal").innerHTML = document.getElementById("pointBuyTotal").innerHTML + "/27";
}