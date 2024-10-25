let cid = [
    ["PENNY", 1.01], ["NICKEL", 2.05], ["DIME", 3.1], ["QUARTER", 4.25], ["ONE", 90], ["FIVE", 55], ["TEN", 20], ["TWENTY", 60], ["ONE HUNDRED", 100]
];

let price = 11.95;
const priceSpan = document.getElementById("price");
priceSpan.textContent = price;

const penny = document.getElementById("penny");
const nickel = document.getElementById("nickel");
const dime = document.getElementById("dime");
const quarter = document.getElementById("quarter");
const dollar = document.getElementById("dollar");
const dollar5 = document.getElementById("5-dollar");
const dollar10 = document.getElementById("10-dollar");
const dollar20 = document.getElementById("20-dollar");
const dollar100 = document.getElementById("100-dollar");
const cashInput = document.getElementById("cash");
const changeDiv = document.getElementById("change-due");
const currencyElements = [
    [penny, cid[0]],
    [nickel, cid[1]],
    [dime, cid[2]],
    [quarter, cid[3]],
    [dollar, cid[4]],
    [dollar5, cid[5]],
    [dollar10, cid[6]],
    [dollar20, cid[7]],
    [dollar100, cid[8]],
];
const updateCurrencyElements = () => {
    currencyElements.forEach(element => element[0].textContent = element[1][1]);
}
updateCurrencyElements();

document.getElementById("cash-form").addEventListener("submit", function (e) {
    e.preventDefault();

    let cash = parseFloat(parseFloat(cashInput.value).toFixed(2));
    let changeDue = cash - price;

    if (cash < price) {
        alert("Customer does not have enough money to purchase the item");
        return;
    } else if (cash === price) {
        changeDiv.textContent = "No change due - customer paid with exact cash";
        return;
    }

    const getChange = (changeDue, cid) => {
        let totalCid = cid.reduce((acc, unit) => acc + unit[1], 0).toFixed(2);
        if (totalCid < changeDue) {
            return { status: "INSUFFICIENT_FUNDS", change: [] };
        }

        const currencyUnit = [
            ["PENNY", 0.01],
            ["NICKEL", 0.05],
            ["DIME", 0.10],
            ["QUARTER", 0.25],
            ["ONE", 1.00],
            ["FIVE", 5.00],
            ["TEN", 10.00],
            ["TWENTY", 20.00],
            ["ONE HUNDRED", 100.00],
        ];

        let changeArray = [];
        for (let i = currencyUnit.length - 1; i >= 0; i--) {
            let currencyName = currencyUnit[i][0];
            let currencyValue = currencyUnit[i][1];
            let availableAmount = cid[i][1];
            let amountToGive = 0;

            while (changeDue >= currencyValue && availableAmount >= currencyValue) {
                changeDue -= currencyValue;
                changeDue = parseFloat(changeDue.toFixed(2));
                availableAmount -= currencyValue;
                availableAmount = parseFloat(availableAmount.toFixed(2));
                amountToGive += currencyValue;
            }

            if (amountToGive > 0) {
                changeArray.push([currencyName, amountToGive]);
            }
        }

        if (changeDue > 0) {
            return { status: "INSUFFICIENT_FUNDS", change: [] };
        } else if (totalCid === (cash - price).toFixed(2)) {
            return { status: "CLOSED", change: changeArray };
        } else {
            return { status: "OPEN", change: changeArray };
        }
    }

    const result = getChange(changeDue, cid);

    if (result.status === "INSUFFICIENT_FUNDS") {
        changeDiv.innerHTML = `<p>Status: ${result.status}</p>`;
    } else if (result.status === "CLOSED") {
        changeDiv.innerHTML = `<p>Status: ${result.status}</p>` +
            result.change.map(item => `<p>${item[0]}: $${item[1].toFixed(2)}</p>`).join("");
    } else {
        changeDiv.innerHTML = `<p>Status: OPEN</p>` +
            result.change.map(item => `<p>${item[0]}: $${item[1].toFixed(2)}</p>`).join("");
    }
});
