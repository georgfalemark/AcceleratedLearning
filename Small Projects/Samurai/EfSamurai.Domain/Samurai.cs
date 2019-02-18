using System;
using System.Collections.Generic;

namespace EfSamurai.Domain
{
    public class Samurai
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }
        public string Email { get; set; }

        public List<Quote> Quotes { get; set; }

        public HairCut HairCuts { get; set; }
        public SecretIdentity SecretIdentity { get; set; }
    }
}
