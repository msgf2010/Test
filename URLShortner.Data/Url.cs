using System;
using System.Collections.Generic;
using System.Text;

namespace URLShortner.Data
{
    public class URL
    {
        public int Id { get; set; }
        public string URLOriginal { get; set; }
        public string URLShortened { get; set; }
        public User User { get; set; }
    }
}
