using System;
using Newtonsoft.Json;

namespace BTB.Importer.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<USCities>(myJsonResponse);
    public class LocationService
    {
        public (string City, string State, string Country) GetRandomLocation()
        {
            var cities = new List<(string city, string state, string country)>();

            #region Cities

            // U.S. Cities
            cities.Add(("New York", "NY", "US"));
            cities.Add(("Los Angeles", "CA", "US"));
            cities.Add(("Chicago", "IL", "US"));
            cities.Add(("Houston", "TX", "US"));
            cities.Add(("Philadelphia", "PA", "US"));
            cities.Add(("Phoenix", "AZ", "US"));
            cities.Add(("San Antonio", "TX", "US"));
            cities.Add(("San Diego", "CA", "US"));
            cities.Add(("Dallas", "TX", "US"));
            cities.Add(("San Jose", "CA", "US"));
            cities.Add(("Austin", "TX", "US"));
            cities.Add(("Jacksonville", "FL", "US"));
            cities.Add(("San Francisco", "CA", "US"));
            cities.Add(("Indianapolis", "IN", "US"));
            cities.Add(("Columbus", "OH", "US"));
            cities.Add(("Fort Worth", "TX", "US"));
            cities.Add(("Charlotte", "NC", "US"));
            cities.Add(("Detroit", "MI", "US"));
            cities.Add(("El Paso", "TX", "US"));
            cities.Add(("Memphis", "TN", "US"));
            cities.Add(("Boston", "MA", "US"));
            cities.Add(("Seattle", "WA", "US"));
            cities.Add(("Denver", "CO", "US"));
            cities.Add(("Washington", "DC", "US"));
            cities.Add(("Nashville", "TN", "US"));
            cities.Add(("Baltimore", "MD", "US"));
            cities.Add(("Oklahoma City", "OK", "US"));
            cities.Add(("Louisville", "KY", "US"));
            cities.Add(("Portland", "OR", "US"));
            cities.Add(("Las Vegas", "NV", "US"));
            cities.Add(("Milwaukee", "WI", "US"));
            cities.Add(("Albuquerque", "NM", "US"));
            cities.Add(("Tucson", "AZ", "US"));
            cities.Add(("Fresno", "CA", "US"));
            cities.Add(("Sacramento", "CA", "US"));
            cities.Add(("Long Beach", "CA", "US"));
            cities.Add(("Kansas City", "MO", "US"));
            cities.Add(("Mesa", "AZ", "US"));
            cities.Add(("Atlanta", "GA", "US"));
            cities.Add(("Virginia Beach", "VA", "US"));
            cities.Add(("Omaha", "NE", "US"));
            cities.Add(("Colorado Springs", "CO", "US"));
            cities.Add(("Raleigh", "NC", "US"));
            cities.Add(("Miami", "FL", "US"));
            cities.Add(("Oakland", "CA", "US"));
            cities.Add(("Minneapolis", "MN", "US"));
            cities.Add(("Tulsa", "OK", "US"));
            cities.Add(("Cleveland", "OH", "US"));
            cities.Add(("Wichita", "KS", "US"));
            cities.Add(("Arlington", "TX", "US"));
            cities.Add(("New Orleans", "LA", "US"));
            cities.Add(("Bakersfield", "CA", "US"));
            cities.Add(("Tampa", "FL", "US"));
            cities.Add(("Honolulu", "HI", "US"));
            cities.Add(("Aurora", "CO", "US"));
            cities.Add(("Anaheim", "CA", "US"));
            cities.Add(("Santa Ana", "CA", "US"));
            cities.Add(("St. Louis", "MO", "US"));
            cities.Add(("Riverside", "CA", "US"));
            cities.Add(("Corpus Christi", "TX", "US"));
            cities.Add(("Lexington-Fayette", "KY", "US"));
            cities.Add(("Pittsburgh", "PA", "US"));
            cities.Add(("Anchorage", "AK", "US"));
            cities.Add(("Stockton", "CA", "US"));
            cities.Add(("Cincinnati", "OH", "US"));
            cities.Add(("St. Paul", "MN", "US"));
            cities.Add(("Toledo", "OH", "US"));
            cities.Add(("Greensboro", "NC", "US"));
            cities.Add(("Newark", "NJ", "US"));
            cities.Add(("Plano", "TX", "US"));
            cities.Add(("Henderson", "NV", "US"));
            cities.Add(("Lincoln", "NE", "US"));
            cities.Add(("Buffalo", "NY", "US"));
            cities.Add(("Jersey City", "NJ", "US"));
            cities.Add(("Chula Vista", "CA", "US"));
            cities.Add(("Fort Wayne", "IN", "US"));
            cities.Add(("Orlando", "FL", "US"));
            cities.Add(("St. Petersburg", "FL", "US"));
            cities.Add(("Chandler", "AZ", "US"));
            cities.Add(("Laredo", "TX", "US"));
            cities.Add(("Norfolk", "VA", "US"));
            cities.Add(("Durham", "NC", "US"));
            cities.Add(("Madison", "WI", "US"));
            cities.Add(("Lubbock", "TX", "US"));
            cities.Add(("Irvine", "CA", "US"));
            cities.Add(("Winston-Salem", "NC", "US"));
            cities.Add(("Glendale", "AZ", "US"));
            cities.Add(("Garland", "TX", "US"));
            cities.Add(("Hialeah", "FL", "US"));
            cities.Add(("Reno", "NV", "US"));
            cities.Add(("Chesapeake", "VA", "US"));
            cities.Add(("Gilbert", "AZ", "US"));
            cities.Add(("Baton Rouge", "LA", "US"));
            cities.Add(("Irving", "TX", "US"));
            cities.Add(("Scottsdale", "AZ", "US"));
            cities.Add(("North Las Vegas", "NV", "US"));
            cities.Add(("Fremont", "CA", "US"));
            cities.Add(("Boise City", "ID", "US"));
            cities.Add(("Richmond", "VA", "US"));
            cities.Add(("San Bernardino", "CA", "US"));
            cities.Add(("Birmingham", "AL", "US"));
            cities.Add(("Spokane", "WA", "US"));
            cities.Add(("Rochester", "NY", "US"));
            cities.Add(("Des Moines", "IA", "US"));
            cities.Add(("Modesto", "CA", "US"));
            cities.Add(("Fayetteville", "NC", "US"));
            cities.Add(("Tacoma", "WA", "US"));
            cities.Add(("Fontana", "CA", "US"));
            cities.Add(("Oxnard", "CA", "US"));
            cities.Add(("Moreno Valley", "CA", "US"));
            cities.Add(("Aurora", "IL", "US"));
            cities.Add(("Yonkers", "NY", "US"));
            cities.Add(("Akron", "OH", "US"));
            cities.Add(("Huntington Beach", "CA", "US"));
            cities.Add(("Little Rock", "AR", "US"));
            cities.Add(("Augusta-Richmond County", "GA", "US"));
            cities.Add(("Amarillo", "TX", "US"));
            cities.Add(("Glendale", "CA", "US"));
            cities.Add(("Mobile", "AL", "US"));
            cities.Add(("Grand Rapids", "MI", "US"));
            cities.Add(("Salt Lake City", "UT", "US"));
            cities.Add(("Tallahassee", "FL", "US"));
            cities.Add(("Huntsville", "AL", "US"));
            cities.Add(("Grand Prairie", "TX", "US"));
            cities.Add(("Knoxville", "TN", "US"));
            cities.Add(("Worcester", "MA", "US"));
            cities.Add(("Newport News", "VA", "US"));
            cities.Add(("Brownsville", "TX", "US"));
            cities.Add(("Overland Park", "KS", "US"));
            cities.Add(("Santa Clarita", "CA", "US"));
            cities.Add(("Providence", "RI", "US"));
            cities.Add(("Garden Grove", "CA", "US"));
            cities.Add(("Chattanooga", "TN", "US"));
            cities.Add(("Oceanside", "CA", "US"));
            cities.Add(("Jackson", "MS", "US"));
            cities.Add(("Fort Lauderdale", "FL", "US"));
            cities.Add(("Santa Rosa", "CA", "US"));
            cities.Add(("Rancho Cucamonga", "CA", "US"));
            cities.Add(("Port St. Lucie", "FL", "US"));
            cities.Add(("Tempe", "AZ", "US"));
            cities.Add(("Ontario", "CA", "US"));
            cities.Add(("Vancouver", "WA", "US"));
            cities.Add(("Sioux Falls", "SD", "US"));
            cities.Add(("Springfield", "MO", "US"));
            cities.Add(("Peoria", "AZ", "US"));
            cities.Add(("Pembroke Pines", "FL", "US"));
            cities.Add(("Elk Grove", "CA", "US"));
            cities.Add(("Salem", "OR", "US"));
            cities.Add(("Lancaster", "CA", "US"));
            cities.Add(("Corona", "CA", "US"));
            cities.Add(("Eugene", "OR", "US"));
            cities.Add(("Palmdale", "CA", "US"));
            cities.Add(("Salinas", "CA", "US"));
            cities.Add(("Springfield", "MA", "US"));
            cities.Add(("Pasadena", "TX", "US"));
            cities.Add(("Fort Collins", "CO", "US"));
            cities.Add(("Hayward", "CA", "US"));
            cities.Add(("Pomona", "CA", "US"));
            cities.Add(("Cary", "NC", "US"));
            cities.Add(("Rockford", "IL", "US"));
            cities.Add(("Alexandria", "VA", "US"));
            cities.Add(("Escondido", "CA", "US"));
            cities.Add(("McKinney", "TX", "US"));
            cities.Add(("Kansas City", "KS", "US"));
            cities.Add(("Joliet", "IL", "US"));
            cities.Add(("Sunnyvale", "CA", "US"));
            cities.Add(("Torrance", "CA", "US"));
            cities.Add(("Bridgeport", "CT", "US"));
            cities.Add(("Lakewood", "CO", "US"));
            cities.Add(("Hollywood", "FL", "US"));
            cities.Add(("Paterson", "NJ", "US"));
            cities.Add(("Naperville", "IL", "US"));
            cities.Add(("Syracuse", "NY", "US"));
            cities.Add(("Mesquite", "TX", "US"));
            cities.Add(("Dayton", "OH", "US"));
            cities.Add(("Savannah", "GA", "US"));
            cities.Add(("Clarksville", "TN", "US"));
            cities.Add(("Orange", "CA", "US"));
            cities.Add(("Pasadena", "CA", "US"));
            cities.Add(("Fullerton", "CA", "US"));
            cities.Add(("Killeen", "TX", "US"));
            cities.Add(("Frisco", "TX", "US"));
            cities.Add(("Hampton", "VA", "US"));
            cities.Add(("McAllen", "TX", "US"));
            cities.Add(("Warren", "MI", "US"));
            cities.Add(("Bellevue", "WA", "US"));
            cities.Add(("West Valley City", "UT", "US"));
            cities.Add(("Columbia", "SC", "US"));
            cities.Add(("Olathe", "KS", "US"));
            cities.Add(("Sterling Heights", "MI", "US"));
            cities.Add(("New Haven", "CT", "US"));
            cities.Add(("Miramar", "FL", "US"));
            cities.Add(("Waco", "TX", "US"));
            cities.Add(("Thousand Oaks", "CA", "US"));
            cities.Add(("Cedar Rapids", "IA", "US"));
            cities.Add(("Charleston", "SC", "US"));
            cities.Add(("Visalia", "CA", "US"));
            cities.Add(("Topeka", "KS", "US"));
            cities.Add(("Elizabeth", "NJ", "US"));
            cities.Add(("Gainesville", "FL", "US"));
            cities.Add(("Thornton", "CO", "US"));
            cities.Add(("Roseville", "CA", "US"));
            cities.Add(("Carrollton", "TX", "US"));
            cities.Add(("Coral Springs", "FL", "US"));
            cities.Add(("Stamford", "CT", "US"));
            cities.Add(("Simi Valley", "CA", "US"));
            cities.Add(("Concord", "CA", "US"));
            cities.Add(("Hartford", "CT", "US"));
            cities.Add(("Kent", "WA", "US"));
            cities.Add(("Lafayette", "LA", "US"));
            cities.Add(("Midland", "TX", "US"));
            cities.Add(("Surprise", "AZ", "US"));
            cities.Add(("Denton", "TX", "US"));
            cities.Add(("Victorville", "CA", "US"));
            cities.Add(("Evansville", "IN", "US"));
            cities.Add(("Santa Clara", "CA", "US"));
            cities.Add(("Abilene", "TX", "US"));
            cities.Add(("Athens-Clarke County", "GA", "US"));
            cities.Add(("Vallejo", "CA", "US"));
            cities.Add(("Allentown", "PA", "US"));
            cities.Add(("Norman", "OK", "US"));
            cities.Add(("Beaumont", "TX", "US"));
            cities.Add(("Independence", "MO", "US"));
            cities.Add(("Murfreesboro", "TN", "US"));
            cities.Add(("Ann Arbor", "MI", "US"));
            cities.Add(("Springfield", "IL", "US"));
            cities.Add(("Berkeley", "CA", "US"));
            cities.Add(("Peoria", "IL", "US"));
            cities.Add(("Provo", "UT", "US"));
            cities.Add(("El Monte", "CA", "US"));
            cities.Add(("Columbia", "MO", "US"));
            cities.Add(("Lansing", "MI", "US"));
            cities.Add(("Fargo", "ND", "US"));
            cities.Add(("Downey", "CA", "US"));

            // Canadian cities
            cities.Add(("Toronto", "ON", "CA"));
            cities.Add(("Montreal", "QC", "CA"));
            cities.Add(("Vancouver", "BC", "CA"));
            cities.Add(("Calgary", "AB", "CA"));
            cities.Add(("Ottawa", "ON", "CA"));
            cities.Add(("Edmonton", "AB", "CA"));
            cities.Add(("Winnipeg", "MB", "CA"));
            cities.Add(("Quebec City", "QC", "CA"));
            cities.Add(("Hamilton", "ON", "CA"));
            cities.Add(("Kitchener", "ON", "CA"));
            cities.Add(("London", "ON", "CA"));
            cities.Add(("Victoria", "BC", "CA"));
            cities.Add(("Windsor", "ON", "CA"));
            cities.Add(("Saskatoon", "SK", "CA"));
            cities.Add(("Regina", "SK", "CA"));
            cities.Add(("Sherbrooke", "QC", "CA"));
            cities.Add(("Surrey", "BC", "CA"));
            cities.Add(("Halifax", "NS", "CA"));
            cities.Add(("St. Catharines", "ON", "CA"));
            cities.Add(("Barrie", "ON", "CA"));
            cities.Add(("Kelowna", "BC", "CA"));
            cities.Add(("Guelph", "ON", "CA"));
            cities.Add(("Kingston", "ON", "CA"));
            cities.Add(("Abbotsford", "BC", "CA"));
            cities.Add(("Saguenay", "QC", "CA"));
            cities.Add(("Thunder Bay", "ON", "CA"));
            cities.Add(("Trois-Rivieres", "QC", "CA"));
            cities.Add(("Nanaimo", "BC", "CA"));
            cities.Add(("Lethbridge", "AB", "CA"));
            cities.Add(("Saint John", "NB", "CA"));
            cities.Add(("New Westminster", "BC", "CA"));
            cities.Add(("Moncton", "NB", "CA"));
            cities.Add(("Red Deer", "AB", "CA"));
            cities.Add(("Chatham-Kent", "ON", "CA"));
            cities.Add(("Cambridge", "ON", "CA"));
            cities.Add(("Brantford", "ON", "CA"));
            cities.Add(("Medicine Hat", "AB", "CA"));
            cities.Add(("Grande Prairie", "AB", "CA"));
            cities.Add(("Saint-Jerome", "QC", "CA"));
            cities.Add(("Brampton", "ON", "CA"));
            cities.Add(("Sarnia", "ON", "CA"));
            cities.Add(("North Bay", "ON", "CA"));
            cities.Add(("Prince George", "BC", "CA"));
            cities.Add(("Saint John", "NB", "CA"));
            cities.Add(("Gatineau", "QC", "CA"));
            cities.Add(("Kamloops", "BC", "CA"));
            cities.Add(("Peterborough", "ON", "CA"));
            cities.Add(("Chilliwack", "BC", "CA"));
            cities.Add(("Belleville", "ON", "CA"));
            cities.Add(("Orillia", "ON", "CA"));
            cities.Add(("Pembroke", "ON", "CA"));
            cities.Add(("Saint-Jean-sur-Richelieu", "QC", "CA"));
            cities.Add(("Leduc", "AB", "CA"));
            cities.Add(("Saint-Hyacinthe", "QC", "CA"));
            cities.Add(("Brandon", "MB", "CA"));
            cities.Add(("Woodstock", "ON", "CA"));
            cities.Add(("Airdrie", "AB", "CA"));
            cities.Add(("Stratford", "ON", "CA"));
            cities.Add(("Saint John", "NB", "CA"));
            cities.Add(("Prince Albert", "SK", "CA"));
            cities.Add(("Spruce Grove", "AB", "CA"));
            cities.Add(("Kawartha Lakes", "ON", "CA"));
            cities.Add(("Drummondville", "QC", "CA"));
            cities.Add(("Brockville", "ON", "CA"));
            cities.Add(("North Vancouver", "BC", "CA"));
            cities.Add(("Timmins", "ON", "CA"));
            cities.Add(("Saint-Hyacinthe", "QC", "CA"));
            cities.Add(("Penticton", "BC", "CA"));
            cities.Add(("Cornwall", "ON", "CA"));
            cities.Add(("White Rock", "BC", "CA"));
            cities.Add(("Moose Jaw", "SK", "CA"));
            cities.Add(("Dartmouth", "NS", "CA"));

            // Mexican cities
            cities.Add(("Mexico City", "DF", "MX"));
            cities.Add(("Guadalajara", "JAL", "MX"));
            cities.Add(("Puebla", "PUE", "MX"));
            cities.Add(("Juárez", "CHI", "MX"));
            cities.Add(("Tijuana", "BCN", "MX"));
            cities.Add(("Monterrey", "NLE", "MX"));
            cities.Add(("Mexicali", "BCN", "MX"));
            cities.Add(("Chihuahua", "CHH", "MX"));

            #endregion

            var rnd = new Random();
            var city = cities[rnd.Next(cities.Count)];
            return city;
        }
    }

}

