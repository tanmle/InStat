var resourceWait = 5,
    maxRenderWait = 5,
	url = "https://docs.google.com/spreadsheets/d/1hO0XZWeDyt2CpYlQi01L_KP0vxViZrvBb0bxESq_Jk4/edit#gid=944456593";

var page = require('webpage').create(),
	count = 0,
    forcedRenderTimeout,
    renderTimeout;
page.viewportSize = { width: 1280, height: 1024 };

// Clip screenshot
page.clipRect = {
    top: 100,
    left: 50,
    width: 370,
    height: 800
};

function doRender() {
    page.render('imgscr.png');
    phantom.exit();
}
page.open(url, function (status) {
    if (status !== "success") {
        console.log('Unable to load url');
        phantom.exit();
    } else {
        forcedRenderTimeout = setTimeout(function () {
            doRender();
        }, maxRenderWait);
    }
});