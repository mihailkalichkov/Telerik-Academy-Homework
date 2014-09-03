function isMozillaCurrentBrowserAlert(event, args) {
    var myWindow = window,
    browser = myWindow.navigator.appCodeName,
    isMozzila = (browser == "Mozilla");

    if (isMozzila) {
        alert("Yes");
    }
    else {
        alert("No");
    }
}