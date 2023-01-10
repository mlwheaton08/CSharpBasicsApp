using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsConsole
{
    public class UserInput
    {

        //after set can put custom code, but most of the time it will simply be get; set;
        public string Name { get; set; }
        public string FavoriteDayOfWeek { get; set; }
        public string LeastFavoriteSubject { get; set; }

        public override string ToString()
        {
            return @$"Name: {Name}
Favorite day of the week: {FavoriteDayOfWeek}
Least favorite school subject: {LeastFavoriteSubject}";
        }
    }
}
