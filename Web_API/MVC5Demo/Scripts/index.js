const appKey = "f24f40b1c24505685fce3b8acd0fcffc";
let searchButton = "";
let searchInput = "";
let cityName = "";
let icon = "";
let temperature = "";
let humidity = "";

$(document).ready(function () {
//     searchButton = document.getElementById("search-btn");
//     searchInput = document.getElementById("search-txt");
//     cityName = document.getElementById("city-name");
//     icon = document.getElementById("icon");
     temperature = document.getElementById("temp");
//     humidity = document.getElementById("humidity-div");
//    alert(searchButton.id);
//    searchButton.addEventListener("click", findWeatherDetails);
//    searchInput.addEventListener("keyup", enterPressed);
});
function enterPressed(event) {
    if (event.key === "Enter") {
        alert("enter" + searchInput.value);
        GetLatLong(searchInput.value);
        findWeatherDetails();
    }
}

function findWeatherDetails() {
   
    //if (searchInput.value === "") {

    //} else {

        let searchLink = "http://localhost/WeatherForcast.API/api/Values/";// + searchInput.value + "&appid=" + appKey;
        $.ajax({
            beforeSend: function(){
                $('.ajax-loader').css("visibility", "visible");
            },
            url: searchLink,
            crossDomain: true,
            dataType: 'json',
            success: function (result) {
                $('.ajax-loader').css("visibility", "hidden");
                var _tblDailies = result["tblDailies"];
               
                var owl_html = "";
                var mydate = new Date();
                var weekday = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];
                var day = mydate.getDay()
                list = [
                      //"clear-night", "clear-day", "partly-cloudy-day",
                      //"partly-cloudy-night", "cloudy", "rain", "sleet", "snow", "wind",
                      //"fog"
                ],
           
                    $.each(_tblDailies, function (key, value) {
                       
                        list.push(value.Icon+"_"+day);
                        owl_html = owl_html + "<div class='owl-item' style='width: 91px;'><div class='item agile-item'><canvas id='" + value.Icon +"_"+ day+"' width='40' height='40'></canvas><h6>" +weekday[day] + "</h6></div></div>";
                        if (day < 6)
                            day++;
                        else
                            day = 0;
                    });
                $("#owl-demo").html(owl_html).owlCarousel({
                    autoPlay: 3000, //Set AutoPlay to 3 seconds

                    items: 3,
                    itemsDesktop: [768, 3],
                    itemsDesktopSmall: [414, 4]

                });
                    var icons = new Skycons({ "color": "#fff" }),
                        
                         i;

                    for (i = list.length; i--;)
                        icons.set(list[i], list[i]);

                    icons.play();
                    //$(_tblHourlies).find("tblHourly").each(function () {
                    //    alert("anagha");
                    //    var _name = 'Name: ' + $(this).find('Icon').text();
                    //    alert(_name);
                    //    console.log(_name);
                    //});
                
                cityName.innerHTML = result["TimeZone"];
                temperature.innerHTML = result["Temperature"] + "°";
                Icon.innerHTML = result["Summary"];
                if (result["Summary"] == "partly-cloudy-night" || result["Summary"] == "Partly Cloudy")
                {
                    $('body').css('background-image', 'url("../Images/3.jpg")');
                }
                else if (result["Summary"] == "cloudy" || result["Summary"] == "Mostly Cloudy") {
                    $('body').css('background-image', 'url("../Images/3.jpg")');
                }
                else if (result["Summary"] == "sunny") {
                    $('body').css('background-image', 'url("../Images/2.jpg")');
                }
                else if (result["Summary"] == "Clear") {
                    $('body').css('background-image', 'url("../Images/4.jpg")');
                }
                else if (result["Summary"] == "rain") {
                    $('body').css('background-image', 'url("../Images/1.jpg")');
                }
                else if (result["Summary"] == "Overcast") {
                    alert(result["Summary"]);
                    $('body').css('background-image', 'url("../Images/5.jpg")');
                }
                if (result["Icon"] == "partly-cloudy-night" || result["Icon"] == "Partly Cloudy" || result["Icon"] == "Mostly Cloudy") {
                    $("#weather-icon").removeClass("icon");
                    $("#weather-icon").addClass("partial-cloudy-night");
                }
                else if(result["Icon"]=="cloudy")
                {
                    $("#weather-icon").removeClass("icon");
                    $("#weather-icon").addClass("cloudy-day");
                }
                else if (result["Icon"] == "sunny" || result["Icon"] == "Clear") {
                    
                    $("#weather-icon").removeClass("icon");
                    $("#weather-icon").addClass("cloudy-day");
                }
                else if (result["Icon"] == "rain") {
                   
                    $("#weather-icon").removeClass("icon");
                    $("#weather-icon").addClass("cloudy-day");
                }
                   // icon.src = "../Images/CompleteLastingHapuka-size_restricted.gif";
            },
            error: function (err) {
                alert("error" + err.responseText + err.status);
            }
        });
   // }
}

function theResponse(response) {
    alert(response);
    let jsonObject = JSON.parse(response);
    cityName.innerHTML = jsonObject.name;
    icon.src = "http://openweathermap.org/img/w/" + jsonObject.weather[0].icon + ".png";
    temperature.innerHTML = parseInt(jsonObject.main.temp - 273) + "°";
    humidity.innerHTML = jsonObject.main.humidity + "%";
}

function httpRequestAsync(url, callback) {
    alert("hello");
    $.ajax({
        url: "http://localhost/WeatherForcast.API/api/Values/?lat=19.99&log=73.78",
        "crossDomain": true, success: function (result) {
            alert(result);
        }
    });
   
}

function GetLatLong(city)
{
    alert(city);
    var geocoder = new google.maps.Geocoder();
    geocoder.geocode({ 'address': city }, function (results, status) {
        if (status == google.maps.GeocoderStatus.OK) {
            alert("location : " + results[0].geometry.location.lat() + " " + results[0].geometry.location.lng());
        } else {
            alert("Something got wrong " + status);
        }
    });
}