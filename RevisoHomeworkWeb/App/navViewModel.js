var navViewModel = (function () {

    var pageHeader = ko.observable("Home");//default
    var setPageHeader = function (pageHeader) {
        switch (pageHeader) {
            case pageHeader === "Home":
                $("#body_container").attr("data-bind", "template:{name:'IndexTemplate'");
                break;
            case pageHeader === "Add Work":               
                $("#body_container").attr("data-bind", "template:{name:'addWorkTemplate'");
                break;               
            case pageHeader==="": break;
        }
    };
    var GoToAddWork = function ()
    {
        indexViewModel.visible = ko.observable(false);
        WorkViewModel.visible = ko.observable(true);


    }
    return {
        pageHeader: pageHeader,
        GoToAddWork: GoToAddWork
    };
}());




