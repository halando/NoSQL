//a docker, mint kernel virtualizációs eszköz alkalmas arra, hogy mind a fejlesztés
// mind a futtatás körülményeinek maradéktalan megteremtését bocsássa rendelkezésünkre 


//A Library projekttípus a Windows esetén egy *. dll állományt eredményez, ami
//gépikódú, de önmagában
namespace NoSQL
{
    using System.Net;
    public class Database  //MVC=model(adat)-view(megjelenítés)-controller(előbbi 2 vezérlése)
    {
        private string url { get; set; } //ún. property, ami  a majdani objektum tulajdonsága és ezt lekérdezhetjük: get  és a set
        public Database(string url )
        { 
        this.url = url;
        }
        public Response Get()
        {
            return new Request(HttpMethod.Get,this.url).Execute();
        }
        public Response Post(string json)
        {
            return new Request(HttpMethod.Get, this.url,json).Execute();
        } 
        public Response Put(string json)
        {
            return new Request(HttpMethod.Get, this.url, json).Execute();
        }
        public Response Delete(string json)
        {
            return new Request(HttpMethod.Get, this.url, json).Execute();
        }
    }
}