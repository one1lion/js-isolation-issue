// Required to extend the Window interface to add the fullAppFuncs object
interface Window {
    fullAppFuncs?: any
}

window.fullAppFuncs = {
    doAlert: function (msg: string) {
        alert(`From fullAppFuncs: ${msg}`);
    }
};