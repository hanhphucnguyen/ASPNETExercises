const app10 = new Vue({
    el: '#app10',
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