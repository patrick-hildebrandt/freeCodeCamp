document.getElementById('check-btn').addEventListener('click', (e) => {
    e.preventDefault();
    const userInput = document.getElementById('user-input').value.trim();
    const resultsDiv = document.getElementById('results-div');
    const validUSPhoneNumber = /^(1\s?)?(\(\d{3}\)|\d{3})([\s-]?)\d{3}([\s-]?)\d{4}$/;

    if (!userInput) {
        alert("Please provide a phone number");
        return;
    }

    if (validUSPhoneNumber.test(userInput)) {
        resultsDiv.textContent = `Valid US number: ${userInput}`;
        resultsDiv.classList.remove("hide");
    } else {
        resultsDiv.textContent = `Invalid US number: ${userInput}`;
        resultsDiv.classList.remove("hide");
    }
});

document.getElementById('clear-btn').addEventListener('click', () => {
    const resultsDiv = document.getElementById('results-div');
    document.getElementById('results-div').textContent = "";
    resultsDiv.classList.add("hide");
});