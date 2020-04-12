﻿(function ($) {
    app.modals.UtilityLookupTableModal = function () {

        var _modalManager;

        var _productUtilitiesService = abp.services.app.productUtilities;
        var _$utilityTable = $('#UtilityTable');

        this.init = function (modalManager) {
            _modalManager = modalManager;
        };


        var dataTable = _$utilityTable.DataTable({
            paging: true,
            serverSide: true,
            processing: true,
            listAction: {
                ajaxFunction: _productUtilitiesService.getAllUtilityForLookupTable,
                inputFilter: function () {
                    return {
                        filter: $('#UtilityTableFilter').val()
                    };
                }
            },
            columnDefs: [
                {
                    targets: 0,
                    data: null,
                    orderable: false,
                    autoWidth: false,
                    defaultContent: "<div class=\"text-center\"><input id='selectbtn' class='btn btn-success' type='button' width='25px' value='" + app.localize('Select') + "' /></div>"
                },
                {
                    autoWidth: false,
                    orderable: false,
                    targets: 1,
                    data: "displayName"
                }
            ]
        });

        $('#UtilityTable tbody').on('click', '[id*=selectbtn]', function () {
            var data = dataTable.row($(this).parents('tr')).data();
            _modalManager.setResult(data);
            _modalManager.close();
        });

        function getUtility() {
            dataTable.ajax.reload();
        }

        $('#GetUtilityButton').click(function (e) {
            e.preventDefault();
            getUtility();
        });

        $('#SelectButton').click(function (e) {
            e.preventDefault();
        });

        $(document).keypress(function (e) {
            if (e.which === 13) {
                getUtility();
            }
        });

    };
})(jQuery);
