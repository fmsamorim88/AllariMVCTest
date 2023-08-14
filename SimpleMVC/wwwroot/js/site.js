const xPosElement = document.getElementById('xPos');
const yPosElement = document.getElementById('yPos');

function updateMousePosition(event) {
    const xPos = event.clientX;
    const yPos = event.clientY;

    xPosElement.textContent = `X: ${xPos}`;
    yPosElement.textContent = `Y: ${yPos}`;
}

function updateClock() {
    const now = new Date();
    const hours = String(now.getHours()).padStart(2, '0');
    const minutes = String(now.getMinutes()).padStart(2, '0');
    const seconds = String(now.getSeconds()).padStart(2, '0');

    const clockElement = document.getElementById('clock');
    clockElement.textContent = `${hours}:${minutes}:${seconds}`;

    setTimeout(updateClock, 1000); // Update every second
}

// site.js

let currentSlide = 0;
const images = ['charmander.jpeg', 'squirtle.png', 'bulbassaur.png']; // Add your image URLs

function updateSlider() {
    const sliderImage = document.getElementById('sliderImage');
    sliderImage.src = '/images/' + images[currentSlide];
}

function nextSlide() {
    currentSlide = (currentSlide + 1) % images.length;
    updateSlider();
}

function prevSlide() {
    currentSlide = (currentSlide - 1 + images.length) % images.length;
    updateSlider();
}

updateSlider();


updateClock();


document.addEventListener('mousemove', updateMousePosition);
