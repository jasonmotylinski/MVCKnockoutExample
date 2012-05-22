class koViewModel
	constructor: (modelData) ->
		@description = modelData.Description


$ ->
	ko.applyBindings new koViewModel window.mvcKnockoutExample.modelData