using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyPractice
{
    class Person
    {
        public int PersonId { get; set; }
        public List<FavoriteSong> FavoriteSongs { get; set; }
    }
}
