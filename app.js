// open website animation
let intro = document.querySelector('.intro');
let logo = document.querySelector('.logo-header');
let logoSpan = document.querySelectorAll('.logo');

window.addEventListener("DOMContentLoaded", () => {
  setTimeout(() => {
    logoSpan.forEach((span, idx) => {
      setTimeout(() => {
        span.classList.add('active');
      }, (idx + 1) * 400)
    });

    setTimeout(() => {
      logoSpan.forEach((span, idx) => {
        setTimeout(() => {
          span.classList.remove('active');
          // span.classList.fade('fade');
        }, (idx + 1) * 50)
      })
    }, 2000);

    setTimeout(() => {
      intro.style.top = '-100vh';
    }, 2300)
  });
})


// dynamic portfolio page
let json = {
  "pokemongocaml": {
    "year": 2023,
    "description": "PokemonGOCaml is a pokemon inspired game, utilizing the functional programming language OCaml and libraries such as Raylib and Raygui. Users are able to explore maps, catch different types of pokemon, and level up!",
    "languages": ["style/media/ocaml-logo.png"],
    "libraries": ["style/media"]
  },
  "bookifly": {
    "year": 2023,
    "description": "Bookifly is a book organization & management web application. Built w/ Django framework, Bookifly utilizes databases and APIs to display and store book information. Users are able to save books into lists (Want To Read, Currently Reading, Read), rate books, explore the NYT bestselling lists, and more! This project is currently still in progress of being completed",
    "languages":[ "style/media/python.png", "style/media/html.jpg"],
    "libraries": ["style/media"]
  },
  "weather": {
    "year": 2023,
    "description": "Web application that implements the Forecast Weather API from WeatherAPI.com. Users are able to input any city of their choosing into the search bar and are given the current temperature, forecast, humidity, and more along with the local time/date of the input.",
    "languages":[ "style/media/python.png", "style/media/html.jpg"],
    "libraries": ["style/media"]
  }
}

const portfolio = document.getElementsByClassName("modal-btn")
for (let i = 0; i < portfolio.length; i ++){
  portfolio[i].addEventListener("click", function(){
    const data = json[portfolio[i]["firstChild"]["id"]];
    console.log(data);
    document.getElementById("exampleModalLabel").innerHTML = portfolio[i]["firstChild"]["id"];
    document.getElementById("year").innerHTML = data["year"]
    document.getElementById("description").innerHTML = data["description"];
    console.log($('#languages'));
    $('#languages').innerHTML = ""
    for (let i = 0; i < data["languages"].length; i ++){
      console.log(data["languages"][i])
      $('#languages').append(
        '<div class="col-sm-3">' + 
        '<img id="l1" class="image-fluid" src= "' + data["languages"][i] + '"/>' + 
        '</div>'
      )
    }
  })
}
