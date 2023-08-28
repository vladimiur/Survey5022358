using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey5022358
{
    public class Surveys
    {
        public string Name { get; set; }
        public DateTime Birhdate { get; set; }
        public string FavoriteTeam { get; set; }
        public override string ToString()
        {
            return $"{Name}| {Birhdate}| {FavoriteTeam}";
        }
    }
}
