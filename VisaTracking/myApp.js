
var visaApp = angular.module('visaApp', []);
visaApp.factory('Excel', function ($window) {
    var uri = 'data:application/vnd.ms-excel;base64,',
        template = '<html xmlns:o="urn:schemas-microsoft-com:office:office" xmlns:x="urn:schemas-microsoft-com:office:excel" xmlns="http://www.w3.org/TR/REC-html40"><head><meta http-equiv="Content-Type" content="text/html; charset=UTF-8"><!--[if gte mso 9]><xml><x:ExcelWorkbook><x:ExcelWorksheets><x:ExcelWorksheet><x:Name>{worksheet}</x:Name><x:WorksheetOptions><x:DisplayGridlines/></x:WorksheetOptions></x:ExcelWorksheet></x:ExcelWorksheets></x:ExcelWorkbook></xml><![endif]--></head><body><table>{table}</table></body></html>',
        base64 = function (s) { return $window.btoa(unescape(encodeURIComponent(s))); },
        format = function (s, c) { return s.replace(/{(\w+)}/g, function (m, p) { return c[p]; }) };
    return {
        tableToExcel: function (tableId, worksheetName) {
            var table = $(tableId),
                ctx = { worksheet: worksheetName, table: table.html() },
                href = uri + base64(format(template, ctx));
            return href;
        }
    };
})
    .controller('visaController', function ($scope, $http, Excel, $timeout) {
        $scope.isVisible = false;       
        //$http.get('/API/Visa/').success(function (response) {
        //    $scope.visaAppls = response;
        //});

        $scope.GetEmpVisaByName = function (SearchText) {
            $http.get('/API/Visa/?name=' + SearchText).success(function (response) {
                $scope.visaAppls = response;
                $scope.isVisible = true;               
            });
        }

        $scope.GetEmpVisaById = function (SearchText) {
            $http.get('/API/Visa/?id=' + SearchText).success(function (response) {
                $scope.visaAppls = response;
            });
        }

        $scope.exportToExcel = function (tableId) {
            var exportHref = Excel.tableToExcel(tableId, 'EMP-Visa-Status');
            var a = document.createElement('a');
            a.href = exportHref;
            a.download = 'EMP-Visa-Status.xls';
            a.click();
        }
    });






