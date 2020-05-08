// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//for each child in the div check for hidden class, if hidden exists dont add, if it doesnt not add

var factionChildren = Array.prototype.slice.call(document.getElementById("raceOptions").children);

factionChildren.forEach(child => child.classList.add("hidden"));

const factionFilter = (factionChildren) => {
    factionChildren.forEach(child => child.classList.add("hidden"));
}

var raceChildren = Array.prototype.slice.call(document.getElementById("classOptions").children);

raceChildren.forEach(child => child.classList.add("hidden"));

const raceFilter = (raceChildren) => {
    raceChildren.forEach(child => child.classList.add("hidden"));
}

var select_id = document.getElementById("factionId");
select_id.addEventListener("change", async e => {
    factionFilter(factionChildren)
    raceFilter(raceChildren)
    var factionSelected = e.target.value
    console.log(factionSelected)
    if (factionSelected == 1) {
        document.getElementById("AllianceId").classList.remove("hidden")
    } else if (factionSelected == 2) {
        document.getElementById("HordeId").classList.remove("hidden")
    }
})




//for each child in the div check for hidden class, if hidden exists dont add, if it doesnt add




var allianceRace_id = document.getElementById("AllianceId");
allianceRace_id.addEventListener("change", async event => {
    raceFilter(raceChildren)
    var allianceRaceSelected = event.target.value
    console.log(allianceRaceSelected)
    debugger

    if (allianceRaceSelected == 1) {
        document.getElementById("HumanId").classList.remove("hidden")
    } else if (allianceRaceSelected == 2) {
        document.getElementById("DwarfId").classList.remove("hidden")
    } else if (allianceRaceSelected == 3) {
        document.getElementById("NightElfId").classList.remove("hidden")
    } else if (allianceRaceSelected == 4) {
        document.getElementById("GnomeId").classList.remove("hidden")
    }
    
})






var hordeRace_id = document.getElementById("HordeId");
hordeRace_id.addEventListener("change", async event => {
    var hordeRaceSelected = event.target.value
    raceFilter(raceChildren)
    console.log(hordeRaceSelected)
    if (hordeRaceSelected == 5) {
        document.getElementById("UndeadId").classList.remove("hidden")
    } else if (hordeRaceSelected == 6) {
        document.getElementById("TaurenId").classList.remove("hidden")
    } else if (hordeRaceSelected == 7) {
        document.getElementById("OrcId").classList.remove("hidden")
    } else if (hordeRaceSelected == 8) {
        document.getElementById("TrollId").classList.remove("hidden")
    }
})


