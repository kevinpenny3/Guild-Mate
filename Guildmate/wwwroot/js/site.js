// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//for each child in the div check for hidden class, if hidden exists dont add, if it doesnt not add





var factionOptions = document.getElementById("factionOptions")
var classOptions = document.getElementById("classOptions")

var factionSelect = document.querySelector("#FactionId")
var raceSelect = document.querySelector("#RaceId")
var classSelect = document.querySelector("#ClassId")


var factionIdSelect = document.querySelector("#FactionId")
factionIdSelect.addEventListener("change", e => {
    raceSelect.value = null
    classSelect.value = null
    var factionSelected = e.target.value
    var raceOptions = document.querySelectorAll("#RaceId option")
    raceOptions.forEach(option => {
        option.classList.remove("hidden")
        if (factionSelected == 1 && option.value > 4) {
            option.classList.add("hidden")
        } else if (factionSelected == 2 && option.value <= 4) {
            option.classList.add("hidden")
        }
    })

})

var raceIdSelect = document.querySelector("#RaceId")
raceIdSelect.addEventListener("change", e => {
    classSelect.value = null
    var raceSelected = e.target.value
    var classOptions = document.querySelectorAll("#ClassId option")
    classOptions.forEach(option => {
        option.classList.add("hidden")
        if (raceSelected == 1 && option.innerText === "Warrior") {
            option.classList.remove("hidden")
        } else if (raceSelected == 1 && option.innerText === "Paladin") {
            option.classList.remove("hidden")
        } else if (raceSelected == 1 && option.innerText === "Rogue") {
            option.classList.remove("hidden")
        } else if (raceSelected == 1 && option.innerText === "Priest") {
            option.classList.remove("hidden")
        } else if (raceSelected == 1 && option.innerText === "Mage") {
            option.classList.remove("hidden")
        } else if (raceSelected == 1 && option.innerText === "Warlock") {
            option.classList.remove("hidden")
        } else if (raceSelected == 2 && option.innerText === "Warrior") {
            option.classList.remove("hidden")
        } else if (raceSelected == 2 && option.innerText === "Paladin") {
            option.classList.remove("hidden")
        } else if (raceSelected == 2 && option.innerText === "Hunter") {
            option.classList.remove("hidden")
        } else if (raceSelected == 2 && option.innerText === "Rogue") {
            option.classList.remove("hidden")
        } else if (raceSelected == 2 && option.innerText === "Priest") {
            option.classList.remove("hidden")
        } else if (raceSelected == 3 && option.innerText === "Warrior") {
            option.classList.remove("hidden")
        } else if (raceSelected == 3 && option.innerText === "Hunter") {
            option.classList.remove("hidden")
        } else if (raceSelected == 3 && option.innerText === "Rogue") {
            option.classList.remove("hidden")
        } else if (raceSelected == 3 && option.innerText === "Priest") {
            option.classList.remove("hidden")
        } else if (raceSelected == 3 && option.innerText === "Druid") {
            option.classList.remove("hidden")
        } else if (raceSelected == 4 && option.innerText === "Warrior") {
            option.classList.remove("hidden")
        } else if (raceSelected == 4 && option.innerText === "Rogue") {
            option.classList.remove("hidden")
        } else if (raceSelected == 4 && option.innerText === "Mage") {
            option.classList.remove("hidden")
        } else if (raceSelected == 4 && option.innerText === "Warlock") {
            option.classList.remove("hidden")
        } else if (raceSelected == 5 && option.innerText === "Warrior") {
            option.classList.remove("hidden")
        } else if (raceSelected == 5 && option.innerText === "Rogue") {
            option.classList.remove("hidden")
        } else if (raceSelected == 5 && option.innerText === "Priest") {
            option.classList.remove("hidden")
        } else if (raceSelected == 5 && option.innerText === "Mage") {
            option.classList.remove("hidden")
        } else if (raceSelected == 5 && option.innerText === "Warlock") {
            option.classList.remove("hidden")
        } else if (raceSelected == 6 && option.innerText === "Warrior") {
            option.classList.remove("hidden")
        } else if (raceSelected == 6 && option.innerText === "Hunter") {
            option.classList.remove("hidden")
        } else if (raceSelected == 6 && option.innerText === "Shaman") {
            option.classList.remove("hidden")
        } else if (raceSelected == 6 && option.innerText === "Druid") {
            option.classList.remove("hidden")
        } else if (raceSelected == 7 && option.innerText === "Warrior") {
            option.classList.remove("hidden")
        } else if (raceSelected == 7 && option.innerText === "Hunter") {
            option.classList.remove("hidden")
        } else if (raceSelected == 7 && option.innerText === "Rogue") {
            option.classList.remove("hidden")
        } else if (raceSelected == 7 && option.innerText === "Shaman") {
            option.classList.remove("hidden")
        } else if (raceSelected == 7 && option.innerText === "Warlock") {
            option.classList.remove("hidden")
        } else if (raceSelected == 8 && option.innerText === "Warrior") {
            option.classList.remove("hidden")
        } else if (raceSelected == 8 && option.innerText === "Hunter") {
            option.classList.remove("hidden")
        } else if (raceSelected == 8 && option.innerText === "Rogue") {
            option.classList.remove("hidden")
        } else if (raceSelected == 8 && option.innerText === "Priest") {
            option.classList.remove("hidden")
        } else if (raceSelected == 8 && option.innerText === "Shaman") {
            option.classList.remove("hidden")
        } else if (raceSelected == 8 && option.innerText === "Mage") {
            option.classList.remove("hidden")
        }
    })
})



















//var factionChildren = Array.prototype.slice.call(document.getElementById("raceOptions").children);


////factionChildren.forEach(child => child.classList.add("hidden"));

//const factionFilter = (factionChildren) => {
//    factionChildren.forEach(child => child.classList.add("hidden"))
//    factionChildren.forEach(child => child.querySelector("select").id = "")
//    document.getElementById("HordeId").value = null
//    document.getElementById("AllianceId").value = null

//}

//var raceChildren = Array.prototype.slice.call(document.getElementById("classOptions").children);
////raceChildren.forEach(child => child.classList.add("hidden"));


//const raceFilter = (raceChildren) => {
//    raceChildren.forEach(child => child.classList.add("hidden"))

//    document.querySelectorAll("#RaceId").forEach(el => el.id = "")

//    classSelects.forEach(child => child.id = "")
//    document.getElementById("HumanId").value = null
//    document.getElementById("DwarfId").value = null
//    document.getElementById("NightElfId").value = null
//    document.getElementById("GnomeId").value = null
//    document.getElementById("UndeadId").value = null
//    document.getElementById("TaurenId").value = null
//    document.getElementById("OrcId").value = null
//    document.getElementById("TrollId").value = null

//}







//var select_id = document.getElementById("factionId");
//select_id.addEventListener("change", e => {

//    factionFilter(factionChildren)
//    raceFilter(raceChildren)

//    var factionSelected = e.target.value
//    console.log(factionSelected)
//    if (factionSelected == 1) {
//        document.getElementById("AllianceId").classList.remove("hidden")
//        document.getElementById("AllianceId").querySelector("select").id = "RaceId"
//    } else if (factionSelected == 2) {
//        document.getElementById("HordeId").classList.remove("hidden")
//        document.getElementById("HordeId").querySelector("select").id = "RaceId"
//    }
//})




////for each child in the div check for hidden class, if hidden exists dont add, if it doesnt add




//var allianceRace_id = document.getElementById("AllianceId");
//allianceRace_id.addEventListener("change",  event => {
//    raceFilter(classOptions.children)
//    var allianceRaceSelected = event.target.value
//    console.log(allianceRaceSelected)
//    debugger

//    if (allianceRaceSelected == 1) {
//        document.getElementById("HumanId").classList.remove("hidden")
//        document.getElementById("HumanId").querySelector("select").id = "ClassId"
//    } else if (allianceRaceSelected == 2) {
//        document.getElementById("DwarfId").classList.remove("hidden")
//        document.getElementById("DwarfId").querySelector("select").id = "ClassId"
//    } else if (allianceRaceSelected == 3) {
//        document.getElementById("NightElfId").classList.remove("hidden")
//        document.getElementById("NightElfId").querySelector("select").id = "ClassId"
//    } else if (allianceRaceSelected == 4) {
//        document.getElementById("GnomeId").classList.remove("hidden")
//        document.getElementById("GnomeId").querySelector("select").id = "ClassId"
//    }
    
//})






//var hordeRace_id = document.getElementById("HordeId");
//hordeRace_id.addEventListener("change",  event => {
//    var hordeRaceSelected = event.target.value
//    raceFilter(raceChildren)
//    console.log(hordeRaceSelected)
//    if (hordeRaceSelected == 5) {
//        document.getElementById("UndeadId").classList.remove("hidden")
//        document.getElementById("UndeadId").querySelector("select").id = "ClassId"
//    } else if (hordeRaceSelected == 6) {
//        document.getElementById("TaurenId").classList.remove("hidden")
//        document.getElementById("TaurenId").querySelector("select").id = "ClassId"
//    } else if (hordeRaceSelected == 7) {
//        document.getElementById("OrcId").classList.remove("hidden")
//        document.getElementById("OrcId").querySelector("select").id = "ClassId"
//    } else if (hordeRaceSelected == 8) {
//        document.getElementById("TrollId").classList.remove("hidden")
//        document.getElementById("TrollId").querySelector("select").id = "ClassId"
//    }
//})


