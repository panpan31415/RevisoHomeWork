var WorkViewModel =
    (function () {
        
        var projectname = ko.observable();
        var price = ko.observable();
        var workType = ko.observable();
        var date = ko.observable();
        var startTime = ko.observable();
        var endTime = ko.observable();
        var workDescription = ko.observable();
        var paymentState = ko.observable();
        var visible = ko.observable(false);
       
        var addWork = function ()
        {
           
            
            var work = {
                'ProjectName': projectname,
                'Date': date,
                'Type': workType,
                'beginTime': startTime,
                'EndTime': endTime,
                'Description': workDescription,
                'Price': price,
                'paymentstate': paymentState
            };
            $.ajax({
                url: "http://localhost:1102/api/works/",
                type: 'POST',
                data: work,
                dataType: 'json',
                success: function () { alert('Success!'); },
                error: function () { alert('boo!'); }//for testing purpose
                //beforeSend: PaginationViewModel.setRequestHeader
            });
            return {
                projectname: projectname,
                price: price,
                workType: workType,
                date: date,
                startTime: startTime,
                endTime: endTime,
                workDescription: workDescription,
                paymentState: paymentState,
                visible: visible,
                //getById: getById,
                //getByUrl: getByUrl,
                //getByCustomerName: getByCustomerName,
                addWork: addWork
            };
        };
   
        //var getByUrl = function (Url, callback_success, callback_error) {

        //    $.ajax({
        //        url: Url,
        //        type: 'GET',
        //        dataType: 'json',
        //        success: callback_success,
        //        error: callback_error
        //        //beforeSend: null   ,can be used to add header and authentication
        //    });
        //};
        //var getById = function (workID, callback_success, callback_error) {
        //    $.ajax({
        //        url: "/api/works/" + workID,
        //        type: 'GET',
        //        dataType: 'json',
        //        success: callback_success,
        //        error: callback_error
        //        //beforeSend: null   ,can be used to add header and authentication
        //    });
        //};
   
        //var getByCustomerName = function (customerName, callback) {
        //    $.ajax({
        //        url: "/api/customers/Work/" + customerName,
        //        type: 'GET',
        //        dataType: 'json',
        //        success: callback,
        //        error: function () { alert('boo!'); },//for testing purpose
        //        //beforeSend: PaginationViewModel.setRequestHeader
        //    });
        //};
   
})();


