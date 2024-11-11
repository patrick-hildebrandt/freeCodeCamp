const searchForm = document.getElementById("search-form");
const searchInput = document.getElementById("search-input");

const pokemonContainer = document.getElementById("pokemon-container");
const pokemonName = document.getElementById("pokemon-name");
const pokemonId = document.getElementById("pokemon-id");
const height = document.getElementById("height");
const weight = document.getElementById("weight");
const image = document.getElementById("image");
const types = document.getElementById("types");

const hp = document.getElementById("hp");
const attack = document.getElementById("attack");
const defense = document.getElementById("defense");
const specialAttack = document.getElementById("special-attack");
const specialDefense = document.getElementById("special-defense");
const speed = document.getElementById("speed");

const endpointAll = "https://pokeapi-proxy.freecodecamp.rocks/api/pokemon";
const endpointPokemon = "https://pokeapi-proxy.freecodecamp.rocks/api/pokemon/{name-or-id}";
const regexStr = /[a-zA-z]+/i;
const regexNr = /\d+/;
const regexMale = /♂/;
const regexFemale = /♀/;
const regexSpChars = /[^a-zA-Z0-9\-\s]/g;
const regexSpace = /\s+/gi;

const mock = {
    height: "",
    id: "",
    name: "",
    sprites: {
        front_default: "",
    },
    stats: [
        {
            base_stat: "",
            stat: {
                name: "hp",
            },
        },
        {
            base_stat: "",
            stat: {
                name: "attack",
            },
        },
        {
            base_stat: "",
            stat: {
                name: "defense",
            },
        },
        {
            base_stat: "",
            stat: {
                name: "special-attack",
            },
        },
        {
            base_stat: "",
            stat: {
                name: "special-defense",
            },
        },
        {
            base_stat: "",
            stat: {
                name: "speed",
            },
        },
    ],
    types: [],
    weight: "",
};

const statsEl = [
    ["hp", hp],
    ["attack", attack],
    ["defense", defense],
    ["special-attack", specialAttack],
    ["special-defense", specialDefense],
    ["speed", speed],
];

const fetchData = async endpoint => {
    try {
        const res = await fetch(endpoint);
        const data = await res.json();
        return data;
    } catch (err) {
        console.error(err);
    }
};

const harmonizeName = name => {
    name = name.replace(regexMale, "m");
    name = name.replace(regexFemale, "f");
    name = name.replace(regexSpChars, "");
    name = name.replace(regexSpace, "-");
    return name.toLowerCase();
};

v

const findId = (nameOrId, allPokemon) => {
    if (regexStr.test(nameOrId)) {
        const name = harmonizeName(nameOrId);
        const foundPokemon = allPokemon.results.find(pokemon => pokemon.name === name);
        return foundPokemon ? foundPokemon.id : null;
    } else if (regexNr.test(nameOrId)) {
        const foundPokemon = allPokemon.results.find(pokemon => pokemon.id.toString() === nameOrId);
        return foundPokemon ? foundPokemon.id : null;
    }
    return null;
};

const updateUi = (pokemon) => {
    pokemonName.textContent = `${capitalizeFirstChar(pokemon.name)}`;
    pokemonId.textContent = pokemon.id ? `#${pokemon.id}` : "";
    height.textContent = pokemon.height;
    weight.textContent = pokemon.weight;
    image.innerHTML = pokemon.sprites.front_default ?
        `<img id="sprite" src="${pokemon.sprites.front_default}"></img>` : "";
    types.innerHTML = "";
    pokemon.types.forEach(({ type }) => {
        types.innerHTML += `<span class="inline-block">${capitalizeFirstChar(type.name)}</span>`;
    });
    pokemon.stats.forEach(({ base_stat, stat }) => {
        const statName = stat.name;
        statsEl.forEach(stat => {
            if (stat[0] === statName) {
                stat[1].textContent = base_stat;
                return;
            }
        });
    });
};

const resetUi = () => {
    updateUi(mock);
    searchInput.value = "";
};

searchForm.addEventListener("submit", async (e) => {
    e.preventDefault();

    let search = "";
    const allPokemon = await fetchData(endpointAll);
    const searchTerm = searchInput.value;
    search = findId(searchTerm, allPokemon);
    if (search) {
        const pokemon = await fetchData(endpointPokemon.replace(/{name-or-id}/, search));
        updateUi(pokemon);
    } else {
        resetUi();
        alert("Pokémon not found");
    }
});