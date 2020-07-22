using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.appData
{
    public class State
    {

        public string Name { get; set; }
        public string PictureUrl { get; set; }
        public State(string name, string pictureUrl)
        {
            Name = name;
            PictureUrl = pictureUrl;
        }

    }
}
