(function() {
  var koViewModel;

  koViewModel = (function() {

    koViewModel.name = 'koViewModel';

    function koViewModel(modelData) {
      this.description = modelData.Description;
    }

    return koViewModel;

  })();

  $(function() {
    return ko.applyBindings(new koViewModel(window.mvcKnockoutExample.modelData));
  });

}).call(this);
