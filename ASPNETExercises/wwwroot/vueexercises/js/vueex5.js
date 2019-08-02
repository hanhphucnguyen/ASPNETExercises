const app5 = new Vue({
    el: "#app5",
    data: {
        message: "Hello Vue.js!"
    },
    methods: {
        reverseMessage() {
            this.message = this.message.split("").reverse().join("");
        }
    }
});