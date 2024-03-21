﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules2
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public StatusEnum FavouriteMusicType { get; set; }
        public List<string> FavouriteSongs { get; set; }

        public string GetFavSongs()
        {
            if (FavouriteSongs == null || FavouriteSongs.Count == 0)
            {
             
                return "Damnn, you hate music huh? You're lame!";
            }
            else 
            { 
            
                return string.Join(", ", FavouriteSongs);
            }
        }
    }
}

