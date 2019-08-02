const app8 = new Vue({
    el: '#app8',
    methods: {
        async getCategories() {
            try {
                this.status = 'Loading... ';
                let response = await fetch(`/GetCategories`);
                if (!response.ok) // or check for response.status
                    throw new Error(`Status - ${response.status}, Text - ${response.statusText}`);
                let data = await response.json(); // this returns a promise, so we await it
                this.categories = data;
                this.status = '';
            } catch (error) {
                this.status = error;
                console.log(error);
            }
        },
    },
    mounted() { this.getCategories(); },
    data: {
        categories: [],
        status: ''
    }
});