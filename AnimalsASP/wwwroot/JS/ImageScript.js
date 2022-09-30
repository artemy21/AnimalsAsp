document.addEventListener('DOMContentLoaded', (event) => {
    const inputURL = document.getElementById('inputURL');
    const displayURL = document.getElementById('displayURL');
    displayURL.src = inputURL.value;
});

function updateUrl() {
    displayURL.src = inputURL.value;
}