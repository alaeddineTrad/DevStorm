using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domain.Entities
{
    public class Review
    {

        public virtual Showroomer Showroomer { get; set; }
        public virtual Buyer Buyer { get; set; }

        public Review()
        {

        }
    }
}