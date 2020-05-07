// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


var select_id = document.getElementById("factionId");
select_id.addEventListener("change", async e => {
    var factionSelected = e.target.value
    console.log(factionSelected)
    debugger
    if (factionSelected == 1) {
        document.getElementById("AllianceId").classList.remove("hidden")
    } else if (factionSelected == 2) {
        document.getElementById("HordeId").classList.remove("hidden")
    }
})

