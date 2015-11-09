<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true" CodeFile="maps.aspx.cs" Inherits="maps" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript" src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCnv3nWtIfwW9Gttt91qg8NQdB9VWK6_eI&libraries=places"></script>
    <script>
        var map;
        var service;
        var infowindow;

        function initialize() {
            var pyrmont = new google.maps.LatLng(-33.8665433, 151.1956316);

            map = new google.maps.Map(document.getElementById('map'), {
                center: pyrmont,
                zoom: 15
            });

            var request = {
                location: pyrmont,
                radius: '500',
                query: 'restaurant'
            };

            service = new google.maps.places.PlacesService(map);
            service.textSearch(request, callback);
        }

        function callback(results, status) {
            if (status == google.maps.places.PlacesServiceStatus.OK) {
                for (var i = 0; i < results.length; i++) {
                    var place = results[i];
                    createMarker(results[i]);
                }
            }
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="map"></div>

</asp:Content>

