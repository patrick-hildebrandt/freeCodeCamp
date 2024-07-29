const inputForm = document.getElementById("input-form");
const numberInput = document.getElementById("number");
const output = document.getElementById("output");
const numeralEquations = {
    // MMM:	3000,
    // MM:	2000,
    M: 1000,
    CM: 900,
    // DCCC: 800,
    // DCC: 700,
    // DC:	600,
    D: 500,
    CD: 400,
    // CCC: 300,
    // CC:	200,
    C: 100,
    XC: 90,
    // LXXX: 80,
    // LXX: 70,
    // LX:	60,
    L: 50,
    XL: 40,
    // XXX: 30,
    // XX:	20,
    X: 10,
    IX: 9,
    // VIII: 8,
    // VII: 7,
    // VI:	6,
    V: 5,
    IV: 4,
    // III: 3,
    // II:	2,
    I: 1
};

const setOutput = (outputString) => {
    output.textContent = outputString;
    output.classList.remove("hide");
    numberInput.value = "";
}

const convertToRoman = (number) => {
    let result = "";

    Object.entries(numeralEquations).forEach(([key, value]) => {
        while (number >= value) {
            result += key;
            number -= value;
        }
    });

    return result;
};

const convertNumber = () => {
    const inputInt = parseInt(numberInput.value);

    if (isNaN(inputInt)) {
        setOutput("Please enter a valid number");
    } else if (inputInt < 1) {
        setOutput("Please enter a number greater than or equal to 1");
    } else if (inputInt > 3999) {
        setOutput("Please enter a number less than or equal to 3999");
    } else {
        setOutput(convertToRoman(inputInt));
    }
};

inputForm.addEventListener("submit", (e) => {
    e.preventDefault();
    convertNumber();
});