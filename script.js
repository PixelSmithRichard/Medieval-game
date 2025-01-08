// Function to handle the form submission and display the entered info
function submitInfo() {
    const keyInfo = document.getElementById('key-info').value;
    const resultDiv = document.getElementById('result');
    
    if (keyInfo) {
        resultDiv.innerHTML = `<p>You entered: <strong>${keyInfo}</strong></p>`;
    } else {
        resultDiv.innerHTML = `<p>Please enter some key information.</p>`;
    }
}
