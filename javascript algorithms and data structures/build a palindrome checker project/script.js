const inputForm = document.getElementById("input-form");
const inputText = document.getElementById("text-input");
const result = document.getElementById("result");
const positiveTest = " is a palindrome.";
const negativeTest = " is not a palindrome";

function testPalindrome(e) {
  e.preventDefault();
  // const rawInput = escapeHtml(inputText.value);
  const rawInput = inputText.value;
  const input = cleanInput(rawInput);

  if (input) {
    const reverseInput = input.split("").reverse().join("");

    if (input.toLowerCase() === reverseInput.toLowerCase()) {
      // result.innerText = demaskStr(rawInput) + positiveTest;
      result.innerText = rawInput + positiveTest;
    } else {
      // result.innerText = demaskStr(rawInput) + negativeTest;
      result.innerText = rawInput + negativeTest;
    }

    result.classList.remove("hide");
  } else {
    result.classList.add("hide");
    alert("Please input a value");
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
}

function cleanInput(str) {
  const regex = /[\p{P}\p{S}\s]/gu;
  return str.replace(regex, "");
}

inputForm.addEventListener("submit", testPalindrome);