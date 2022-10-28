//Kent Tupas
//10/27/2022
//Resurant Picker API
//Peer Review: Jessie Lamzon
//code works very well and ran with no problems.  I like the use of array too. nice clean code.  good job!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TupasKResturantPicker9.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResturantPickerController : ControllerBase
    {
    [HttpGet]
    [Route("Resturant/{category}")]

    public string Resturant(string category)
    {
    Random random = new Random();
    string[] pizza = {"Pizza Hut", "Dominos", "Costco", "Papa Johns","Papa Murphys","Vip Pizza", "Leonardi's Pizza", "Eddie pizza", "Chuckie Chesse Pizza","Pizza Guys"};
    string[] burger = {"Mc Donalds", "Red Robin", "Carls Jr","Wendys","Burger King", "Five guys","In n Out","Flip's Burger", "Habit Burger", "Moo moo's Burger Barn"};
    string[] mexican = {"Taqueria La Mexicana","El Comal Taco truck", "La Casita","Tacos Chapala","La Korita","Nena's on B St","Acapulco Gardens mexican Food","El Poblana taco Truck","Birriera Jalisco","Taco Bell"};
    
    int pizzaIndex = random.Next(pizza.Length);
    int burgerIndex = random.Next(burger.Length);
    int mexicanIndex = random.Next(mexican.Length);
    
    if(category == "pizza") 
    return $"{pizza[pizzaIndex]}";
    if(category == "burger")
    return $"{burger[burgerIndex]}";
    if(category == "mexican") 
    return $"{mexican[mexicanIndex]}";
    else{
        return "Error Reload";
    }
   } 
 }    
}
