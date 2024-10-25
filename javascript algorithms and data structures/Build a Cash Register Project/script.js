let cid = [
    ["PENNY", 1.01], ["NICKEL", 2.05], ["DIME", 3.1], ["QUARTER", 4.25], ["ONE", 90], ["FIVE", 55], ["TEN", 20], ["TWENTY", 60], ["ONE HUNDRED", 100]
];
// Deklaration einer Variablen mit "let". "cid" ist ein Array, das Arrays enthält (Nested Array), jeder Unterarray enthält zwei Werte.

let price = 11.95;
// "let" erstellt eine block-skopierte, veränderbare Variable "price".

const priceSpan = document.getElementById("price");
// "const" deklariert eine block-skopierte Konstante. "document.getElementById" ist eine DOM-Methode, die ein Element anhand seiner ID auswählt.

priceSpan.textContent = price;
// "textContent" ist eine Eigenschaft des DOM-Elements, die den Textinhalt festlegt.

const penny = document.getElementById("penny");
const nickel = document.getElementById("nickel");
const dime = document.getElementById("dime");
const quarter = document.getElementById("quarter");
const dollar = document.getElementById("dollar");
const dollar5 = document.getElementById("5-dollar");
const dollar10 = document.getElementById("10-dollar");
const dollar20 = document.getElementById("20-dollar");
const dollar100 = document.getElementById("100-dollar");
// Wiederholung der DOM-Auswahl mit "const". Variablen mit "const" sind konstant und können nicht neu zugewiesen werden, der Inhalt ist jedoch änderbar.

const cashInput = document.getElementById("cash");
const changeDiv = document.getElementById("change-due");
// DOM-Elemente werden hier erneut über ihre IDs abgerufen.

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
// Array-Literale werden durch eckige Klammern "[]" erstellt. "currencyElements" ist ein Array aus Arrays, das DOM-Elemente und Werte aus "cid" paart.

const updateCurrencyElements = () => {
    currencyElements.forEach(element => element[0].textContent = element[1][1]);
}
// "updateCurrencyElements" ist eine Funktion, die durch eine Pfeilfunktion "( ) => { }" deklariert wurde. "forEach" ist eine Array-Methode, die jeden Eintrag in "currencyElements" iteriert.

updateCurrencyElements();
// Funktionsaufruf von "updateCurrencyElements".

document.getElementById("cash-form").addEventListener("submit", function (e) {
    e.preventDefault();
    // "addEventListener" ist eine DOM-Methode, die einen Event-Listener (hier: "submit") an ein Element anhängt.
    // "e.preventDefault()" verhindert das Standardverhalten des Submit-Events, d.h., die Seite wird nicht neu geladen.

    let cash = parseFloat(parseFloat(cashInput.value).toFixed(2));
    // "parseFloat" ist eine Methode, die eine Zeichenkette in eine Gleitkommazahl umwandelt. "toFixed(2)" rundet die Zahl auf zwei Dezimalstellen.

    let changeDue = cash - price;
    // Subtraktionsoperator "-" zur Berechnung des Werts von "changeDue".

    if (cash < price) {
        alert("Customer does not have enough money to purchase the item");
        return;
    } else if (cash === price) {
        changeDiv.textContent = "No change due - customer paid with exact cash";
        return;
    }
    // "if" und "else if" sind Kontrollstrukturen für bedingte Anweisungen. "alert" ist eine Funktion, die ein Popup-Fenster mit einer Nachricht zeigt.
    
    const getChange = (changeDue, cid) => {
        let totalCid = cid.reduce((acc, unit) => acc + unit[1], 0).toFixed(2);
        // "reduce" ist eine Array-Methode, die alle Elemente zu einem einzigen Wert verarbeitet. Hier summiert "reduce" alle Beträge in "cid".

        if (totalCid < changeDue) {
            return { status: "INSUFFICIENT_FUNDS", change: [] };
        }
        // "return" gibt einen Wert aus der Funktion zurück. Hier wird ein Objekt mit den Eigenschaften "status" und "change" zurückgegeben.

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
        // Array-Literal von Arrays mit Währungswerten, verwendet zur Berechnung des Rückgelds.

        let changeArray = [];
        for (let i = currencyUnit.length - 1; i >= 0; i--) {
            let currencyName = currencyUnit[i][0];
            let currencyValue = currencyUnit[i][1];
            let availableAmount = cid[i][1];
            let amountToGive = 0;
            // "for" Schleife zur Rückwärts-Iteration. "let i = currencyUnit.length - 1" startet die Schleife am Ende des Arrays. 
            // Deklaration lokaler Variablen für den aktuellen Schleifendurchlauf.

            while (changeDue >= currencyValue && availableAmount >= currencyValue) {
                changeDue -= currencyValue;
                changeDue = parseFloat(changeDue.toFixed(2));
                availableAmount -= currencyValue;
                availableAmount = parseFloat(availableAmount.toFixed(2));
                amountToGive += currencyValue;
            }
            // "while" Schleife wiederholt den Codeblock, solange die Bedingung erfüllt ist.

            if (amountToGive > 0) {
                changeArray.push([currencyName, amountToGive]);
            }
            // "push" ist eine Array-Methode, die einen neuen Wert am Ende des Arrays hinzufügt.
        }

        if (changeDue > 0) {
            return { status: "INSUFFICIENT_FUNDS", change: [] };
        } else if (totalCid === (cash - price).toFixed(2)) {
            return { status: "CLOSED", change: changeArray };
        } else {
            return { status: "OPEN", change: changeArray };
        }
        // Bedingungen zur Rückgabe verschiedener Status- und Change-Objekte basierend auf dem Wechselgeld.
    }

    const result = getChange(changeDue, cid);
    // Funktionsaufruf von "getChange", speichert das Ergebnis in "result".

    if (result.status === "INSUFFICIENT_FUNDS") {
        changeDiv.innerHTML = `<p>Status: ${result.status}</p>`;
    } else if (result.status === "CLOSED") {
        changeDiv.innerHTML = `<p>Status: ${result.status}</p>` +
            result.change.map(item => `<p>${item[0]}: $${item[1].toFixed(2)}</p>`).join("");
    } else {
        changeDiv.innerHTML = `<p>Status: OPEN</p>` +
            result.change.map(item => `<p>${item[0]}: $${item[1].toFixed(2)}</p>`).join("");
    }
    // "innerHTML" ändert den HTML-Inhalt eines Elements. Hier wird ein dynamischer Inhalt mittels Template-Literalen `` und "map" erstellt.
    // "map" erstellt ein neues Array durch Iteration über "result.change". "join" konvertiert das Array in eine Zeichenkette.
});
