using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.appData
{
    public static class StateRepository
    {
        public static State correctAnswer { get; set; }
        public static List<State> pastStates { get; set; } =
            new List<State>();

        public static List<State> States =
            new List<State>
            {
               new State("Alabama","\\appData\\states\\images\\alabama.jpg" ),
               new State("Alaska", "\\appData\\states\\images\\alaska.jpg"),
               new State("Arizona","\\appData\\states\\images\\arizona.jpg" ),
               new State("Arkansas","\\appData\\states\\images\\arkansas.jpg" ),
               new State("California","\\appData\\states\\images\\california.jpg" ),
               new State("Colorado","\\appData\\states\\images\\colorado.jpg" ),
               new State("Connecticut","\\appData\\states\\images\\connecticut.jpg" ),
               new State("Delaware","\\appData\\states\\images\\delaware.jpg" ),
               new State("Florida","\\appData\\states\\images\\florida.jpg" ),
               new State("Georgia","\\appData\\states\\images\\georgia.jpg" ),
               new State("Hawaii","\\appData\\states\\images\\hawaii.jpg" ),
               new State("Idaho","\\appData\\states\\images\\idaho.jpg" ),
               new State("Illinois","\\appData\\states\\images\\illinois.jpg" ),
               new State("Indiana","\\appData\\states\\images\\indiana.jpg" ),
               new State("Iowa","\\appData\\states\\images\\iowa.jpg" ),
               new State("Kansas","\\appData\\states\\images\\kansas.jpg" ),
               new State("Kentucky","\\appData\\states\\images\\kentucky.jpg" ),
               new State("Louisiana","\\appData\\states\\images\\louisiana.jpg" ),
               new State("Maine","\\appData\\states\\images\\maine.jpg" ),
               new State("Maryland","\\appData\\states\\images\\maryland.jpg" ),
               new State("Massachusetts","\\appData\\states\\images\\massachusetts.jpg" ),
               new State("Michigan","\\appData\\states\\images\\michigan.jpg" ),
               new State("Minnesota","\\appData\\states\\images\\minnesota.jpg" ),
               new State("Mississippi","\\appData\\states\\images\\mississippi.jpg" ),
               new State("Missouri","\\appData\\states\\images\\missouri.jpg" ),
               new State("Montana","\\appData\\states\\images\\montana.jpg" ),
               new State("Nebraska", "\\appData\\states\\images\\nebraska.jpg"),
               new State("Nevada","\\appData\\states\\images\\nevada.jpg" ),
               new State("New Hampshire","\\appData\\states\\images\\new_hampshire.jpg" ),
               new State("New Jersey","\\appData\\states\\images\\new_jersey.jpg" ),
               new State("New Mexico", "\\appData\\states\\images\\new_mexico.jpg"),
               new State("New York","\\appData\\states\\images\\new_york.jpg" ),
               new State("North Carolina","\\appData\\states\\images\\north_carolina.jpg" ),
               new State("North Dakota","\\appData\\states\\images\\north_dakota.jpg" ),
               new State("Ohio","\\appData\\states\\images\\ohio.jpg" ),
               new State("Oklahoma", "\\appData\\states\\images\\oklahoma.jpg"),
               new State("Oregon","\\appData\\states\\images\\oregon.jpg" ),
               new State("Pennsylvania","\\appData\\states\\images\\pennsylvania.jpg" ),
               new State("Rhode Island","\\appData\\states\\images\\rhode_island.jpg" ),
               new State("South Carolina","\\appData\\states\\images\\south_carolina.jpg" ),
               new State("South Dakota","\\appData\\states\\images\\south_dakota.jpg" ),
               new State("Tennessee","\\appData\\states\\images\\tennessee.jpg" ),
               new State("Texas","\\appData\\states\\images\\texas.jpg" ),
               new State("Utah","\\appData\\states\\images\\utah.jpg" ),
               new State("Vermont","\\appData\\states\\images\\vermont.jpg" ),
               new State("Virginia","\\appData\\states\\images\\virginia.jpg" ),
               new State("Washington","\\appData\\states\\images\\washington.jpg" ),
               new State("West Virginia","\\appData\\states\\images\\west_virginia.jpg" ),
               new State("Wisconsin","\\appData\\states\\images\\wisconsin.jpg" ),
               new State("Wyoming","\\appData\\states\\images\\wyoming.jpg" ),

            };


    }
}
