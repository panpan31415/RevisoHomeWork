var masterViewModel = masterViewModel || (function () {
    this.navViewModel = navViewModel;
    this.WorkViewModel = WorkViewModel;
    this.indexViewModel = indexViewModel;
})();
ko.applyBindings(masterViewModel);