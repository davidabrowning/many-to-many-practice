using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyPractice
{
    class FavoriteSong
    {
        public int FavoriteSongId { get; set; }
        public List<Person> Fans { get; set; }
    }
}
