document.getElementById('game-form').addEventListener('submit', function (event) {
    event.preventDefault();  // Prevents form submission

    const gameName = document.getElementById('game-name').value;
    const gameDescription = document.getElementById('game-description').value;
    const gameGenre = document.getElementById('game-genre').value;
    const resultDiv = document.getElementById('result');
    
    if (gameName && gameDescription && gameGenre) {
        resultDiv.innerHTML = `
            <h3>Your Game Info</h3>
            <p><strong>Name:</strong> ${gameName}</p>
            <p><strong>Description:</strong> ${gameDescription}</p>
            <p><strong>Genre:</strong> ${gameGenre}</p>
        `;
        resultDiv.style.display = 'block';
    } else {
        resultDiv.innerHTML = `<p>Please fill out all fields.</p>`;
        resultDiv.style.display = 'block';
    }
});
