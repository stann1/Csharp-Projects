(function () {
    function launchOnClick(event, parameters) {
        var myWindow = window;
        var browserType = window.navigator.appCodeName;
        var isMoz = browserType === "Mozilla";
        if (isMoz) {
            alert("Current browser is Mozilla");
        }
        else {
            alert("Current browser is NOT Mozilla");
        }
    }
})();