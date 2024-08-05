const messageInput = document.getElementById("message-input");
const result = document.getElementById("result");
const checkMessageButton = document.getElementById("check-message-btn");

// please help: findet die exakte Zeichenfolge "please help".
// |: der logische ODER-Operator, der eine der beiden angegebenen Zeichenfolgen findet.
// assist me: findet die exakte Zeichenfolge "assist me".
// i: der Modifikator, der die Groß- und Kleinschreibung ignoriert (case-insensitive).
const helpRegex = /please help|assist me/i;

// [0-9]+: findet eine oder mehrere Ziffern (0-9).
// : ein Leerzeichen.
// (?:...): eine nicht-erfassende Gruppe, die zum Gruppieren verwendet wird, aber keine Rückverweise erlaubt.
// hundred|thousand|million|billion: findet eine der exakten Zeichenfolgen "hundred", "thousand", "million" oder "billion".
// ?: das vorangehende Element (die nicht-erfassende Gruppe) ist optional und kann null- oder einmal vorkommen.
// dollars: findet die exakte Zeichenfolge " dollars".
// i: der Modifikator, der die Groß- und Kleinschreibung ignoriert (case-insensitive).
const dollarRegex = /[0-9]+ (?:hundred|thousand|million|billion)? dollars/i;

// (?:^|\s): eine nicht-erfassende Gruppe, die entweder den Anfang des Strings (^) oder ein Leerzeichen (\s) findet.
// fr[e3][e3]: findet "fr" gefolgt von zwei Zeichen, die entweder "e" oder "3" sind (z.B., "free" oder "fr33").
// m[o0]n[e3]y: findet "m" gefolgt von "o" oder "0", dann "n", "e" oder "3" und endet mit "y" (z.B., "money" oder "m0n3y").
// (?:$|\s): eine nicht-erfassende Gruppe, die entweder das Ende des Strings ($) oder ein Leerzeichen (\s) findet.
// i: der Modifikator, der die Groß- und Kleinschreibung ignoriert (case-insensitive).
const freeRegex = /(?:^|\s)fr[e3][e3] m[o0]n[e3]y(?:$|\s)/i;

// (?:^|\s): eine nicht-erfassende Gruppe, die entweder den Anfang des Strings (^) oder ein Leerzeichen (\s) findet.
// [s5]: findet entweder das Zeichen "s" oder die Ziffer "5".
// [t7]: findet entweder das Zeichen "t" oder die Ziffer "7".
// [o0]: findet entweder das Zeichen "o" oder die Ziffer "0".
// [c{[(]: findet eines der Zeichen "c", "{", "[", oder "(".
// k: findet das Zeichen "k".
// : ein Leerzeichen.
// [a@4]: findet entweder das Zeichen "a", "@" oder die Ziffer "4".
// l: findet das Zeichen "l".
// [e3]: findet entweder das Zeichen "e" oder die Ziffer "3".
// r: findet das Zeichen "r".
// [t7]: findet entweder das Zeichen "t" oder die Ziffer "7".
// (?:$|\s): eine nicht-erfassende Gruppe, die entweder das Ende des Strings ($) oder ein Leerzeichen (\s) findet.
// i: der Modifikator, der die Groß- und Kleinschreibung ignoriert (case-insensitive).
const stockRegex = /(?:^|\s)[s5][t7][o0][c{[(]k [a@4]l[e3]r[t7](?:$|\s)/i;

// (?:^|\s): eine nicht-erfassende Gruppe, die entweder den Anfang des Strings (^) oder ein Leerzeichen (\s) findet.
// d[e3]: findet "d" gefolgt von entweder "e" oder "3".
// [a@4]: findet entweder das Zeichen "a", "@" oder die Ziffer "4".
// r: findet das Zeichen "r".
// fr: findet ein Leerzeichen gefolgt von "fr".
// [i1|]: findet entweder "i", "1" oder den senkrechten Strich "|".
// [e3]: findet entweder "e" oder "3".
// nd: findet die Zeichen "n" und "d".
// (?:$|\s): eine nicht-erfassende Gruppe, die entweder das Ende des Strings ($) oder ein Leerzeichen (\s) findet.
// i: der Modifikator, der die Groß- und Kleinschreibung ignoriert (case-insensitive).
const dearRegex = /(?:^|\s)d[e3][a@4]r fr[i1|][e3]nd(?:$|\s)/i;

const denyList = [helpRegex, dollarRegex, freeRegex, stockRegex, dearRegex];

const isSpam = (msg) => denyList.some((regex) => regex.test(msg));

checkMessageButton.addEventListener("click", () => {
    if (messageInput.value === "") {
        alert("Please enter a message.");
        return;
    }

    result.textContent = isSpam(messageInput.value)
        ? "Oh no! This looks like a spam message."
        : "This message does not seem to contain any spam.";
    messageInput.value = "";
});