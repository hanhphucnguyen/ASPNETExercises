const app11 = new Vue({
    el: '#app11',
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