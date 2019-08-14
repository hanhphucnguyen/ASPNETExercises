const app12 = new Vue({
    el: '#app12',
    methods: {
        getLatAndLng() {
            try {
                // A service for converting between an address to LatLng
                let geocoder = new google.maps.Geocoder();
                geocoder.geocode({ address: this.address }, (results, status) => {
                    if (status === google.maps.GeocoderStatus.OK) {
                        // only if google gives us the OK
                        this.lat = results[0].geometry.location.lat();
                        this.lng = results[0].geometry.location.lng();
                        let myLatLng = new google.maps.LatLng(this.lat, this.lng);
                        let map_canvas = document.getElementById("map");
                        let options = {
                            zoom: 10, center: myLatLng, mapTypeId:
                                google.maps.MapTypeId.ROADMAP
                        };
                        let map = new google.maps.Map(map_canvas, options);
                        let center = map.getCenter();
                        map.setCenter(center);
                        google.maps.event.trigger(map, "resize");
                        infowindow = new google.maps.InfoWindow({ content: "" });
                        // add the markers, event handlers, infowindows for each location
                        marker = new google.maps.Marker({
                            position: new google.maps.LatLng(this.lat, this.lng),
                            map: map,
                            animation: google.maps.Animation.DROP,
                            icon: `../images/marker1.png`,
                            title: `Some hover info goes here`,
                            html: `<div>Some interesting<br/>information about<br/>this location goes here</div>`
                        });
                        google.maps.event.addListener(marker, "click", () => {
                            infowindow.setContent(marker.html);
                            infowindow.close();
                            infowindow.open(map, marker);
                        });
                    }
                });
            } catch (error) {
                console.log(error);
            }
        }
    },
    data: {
        address: '',
        lat: '',
        lng: ''
    }
});