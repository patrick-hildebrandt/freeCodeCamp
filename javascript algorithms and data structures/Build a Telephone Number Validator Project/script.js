document.getElementById('check-btn').addEventListener('click', (e) => {
    e.preventDefault();
    const userInput = document.getElementById('user-input').value.trim();
    const resultsDiv = document.getElementById('results-div');
    // ^                 = Anfang des Strings
    // (1\s?)?           = Optionale Länderkennzahl "1" mit optionalem Leerzeichen
    // (\(\d{3}\)|\d{3}) = Drei Ziffern, entweder in Klammern oder ohne Klammern
    // ([\s-]?)          = Optionales Leerzeichen oder Bindestrich
    // \d{3}             = Drei Ziffern (erste Teil der Nummer)
    // ([\s-]?)          = Optionales Leerzeichen oder Bindestrich
    // \d{4}             = Vier Ziffern (zweiter Teil der Nummer)
    // $                 = Ende des Strings
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
    resultsDiv.textContent = "";
    resultsDiv.classList.add("hide");
});