const inputForm = document.getElementById("input-form");
const inputText = document.getElementById("text-input");
const result = document.getElementById("result");
// Deklaration von Konstanten mit "const". "document.getElementById" ruft Elemente im DOM basierend auf ihrer ID ab.

const positiveTest = " is a palindrome.";
const negativeTest = " is not a palindrome";
// "positiveTest" und "negativeTest" sind String-Konstanten, die später für Ausgaben verwendet werden.

function testPalindrome(e) {
  e.preventDefault();
  // const rawInput = escapeHtml(inputText.value);
  // "e.preventDefault()" verhindert das Standardverhalten des Submit-Events, also das Neuladen der Seite.

  const rawInput = inputText.value;
  // Zugriff auf die Eingabe des Nutzers durch die "value"-Eigenschaft eines DOM-Elements.

  const input = cleanInput(rawInput);
  // Aufruf der "cleanInput"-Funktion, um das Eingabeformat zu bereinigen.

  if (input) {
    const reverseInput = input.split("").reverse().join("");
    // "split" teilt den String in ein Array von Zeichen, "reverse" kehrt die Reihenfolge im Array um und "join" konvertiert das Array zurück in einen String.

    if (input.toLowerCase() === reverseInput.toLowerCase()) {
      // result.innerText = demaskStr(rawInput) + positiveTest;
      result.innerText = rawInput + positiveTest;
      // "innerText" setzt den Textinhalt eines DOM-Elements. Der String wird dabei im HTML dargestellt.
    } else {
      // result.innerText = demaskStr(rawInput) + negativeTest;
      result.innerText = rawInput + negativeTest;
    }

    result.classList.remove("hide");
    // "classList.remove" entfernt eine CSS-Klasse, in diesem Fall "hide".
  } else {
    result.classList.add("hide");
    // "classList.add" fügt eine CSS-Klasse hinzu.
    alert("Please input a value");
    // "alert" zeigt ein Popup mit einer Nachricht.
  }
}

function demaskStr(safe) {
  return safe
    .replace(/&amp;/g, "&")
    .replace(/&lt;/g, "<")
    .replace(/&gt;/g, ">")
    .replace(/&quot;/g, "\"")
    .replace(/&#039;/g, "'")
    .replace(/&#96;/g, "`")
    .replace(/&#40;/g, "(")
    .replace(/&#41;/g, ")")
    .replace(/&#123;/g, "{")
    .replace(/&#125;/g, "}")
    .replace(/&#91;/g, "[")
    .replace(/&#93;/g, "]");
  // "replace" ist eine String-Methode, die ein Muster oder einen regulären Ausdruck im Text ersetzt.
  // "/g" ist ein Modifikator für die globale Suche, der alle Übereinstimmungen im String ersetzt.
}

function escapeHtml(unsafe) {
  return unsafe
    .replace(/&/g, "&amp;")
    .replace(/</g, "&lt;")
    .replace(/>/g, "&gt;")
    .replace(/"/g, "&quot;")
    .replace(/'/g, "&#039;")
    .replace(/`/g, "&#96;")
    .replace(/\(/g, "&#40;")
    .replace(/\)/g, "&#41;")
    .replace(/{/g, "&#123;")
    .replace(/}/g, "&#125;")
    .replace(/\[/g, "&#91;")
    .replace(/\]/g, "&#93;");
  // Ähnlich wie in "demaskStr" ersetzt "replace" hier spezielle Zeichen, um sie HTML-sicher zu machen.
}

function cleanInput(str) {
// \p{P}: findet alle Zeichen, die als Satzzeichen (Punctuation) klassifiziert sind.
// \p{S}: findet alle Symbole (Symbols), wie Währungszeichen oder mathematische Operatoren.
// \s: findet alle Leerzeichen (Whitespace), wie Leerzeichen, Tabulatoren und Zeilenumbrüche.
// [...]: definiert eine Zeichenklasse, die eines der darin enthaltenen Zeichen oder Gruppen findet.
// g: der globale Modifikator, der sicherstellt, dass alle Vorkommen im Text gefunden werden, nicht nur das erste.
// u: der Unicode-Modifikator, der den regulären Ausdruck als Unicode-Text behandelt.
  const regex = /[\p{P}\p{S}\s]/gu;
  return str.replace(regex, "");
  // "regex" ist ein regulärer Ausdruck, der Satzzeichen, Symbole und Leerzeichen erkennt und ersetzt.
  // "\p{P}" erkennt Satzzeichen, "\p{S}" Symbole, "\s" Leerzeichen.
  // "[...]" ist eine Zeichenklasse, und "g" (global) und "u" (Unicode) sind Modifikatoren für die Suche.
}

inputForm.addEventListener("submit", testPalindrome);
// "addEventListener" hängt ein Event an ein Element an. Hier: das "submit"-Event des Formulars "inputForm".
