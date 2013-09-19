/// <reference path="../jquery-2.0.3-vsdoc.js" />

// could do namespace checking

var MainFunction = function () {
    
    var totalOperations = 0,


    init = function () {
        
    },

    add = function (parameter1, parameter2) {
        totalOperations++;
        var result = parameter1 + parameter2;
        return result;
    };

    return {
        init: init,
        Soma : add
    };
}();
