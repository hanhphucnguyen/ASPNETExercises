Vue.component('grocery-items', {
    props: ['gitem'],
    template: '<li>{{ gitem.text }}</li>'
});
const app7 = new Vue({
    el: '#app7',
    data: {
        groceryList: [
            { id: 0, text: 'Vegetables' },
            { id: 1, text: 'Cheese' },
            { id: 2, text: 'Pizza' }
        ]
    }
});