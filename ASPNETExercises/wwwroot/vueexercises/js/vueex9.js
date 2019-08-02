const app9 = new Vue({
    el: '#app9',
    methods: {
        async getTrays() {
            try {
                this.status = 'Loading... ';
                let response = await fetch(`/GetTrays`);
                if (!response.ok) // or check for response.status
                    throw new Error(`Status - ${response.status}, Text - ${response.statusText}`);
                let data = await response.json(); // this returns a promise, so we await it
                this.trays = data;
                this.status = '';
            } catch (error) {
                this.status = error;
                console.log(error);
            }
        },      
        formatDate : (date) => {
            let _date;
            date === undefined ? _date = new Date() : _date = new Date(Date.parse(date));
            let _day = _date.getDate();
            let _month = _date.getMonth() + 1;
            let _year = _date.getFullYear();
            let _hour = _date.getHours();
            let _min = _date.getMinutes();
            if (_min < 10) { _min = "0" + _min; }
            return _year + "-" + _month + "-" + _day + " " + _hour + ":" + _min;
        }
    },
    mounted() { this.getTrays(); },
    data: {
        trays: [],
        status: ''
    }
});