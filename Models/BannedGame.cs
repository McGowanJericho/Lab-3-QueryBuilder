using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBuilder.Models
{
    internal class BannedGame : IClassModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Series { get; set; }
        public string Country { get; set; } 
        public string Details { get; set; }

        /*public BannedGame() 
        {
            Id = 137;
            Title = "N/A";
            Series = "N/A";
            Country = "N/A";
            Details = "N/A";
        }
        public BannedGame(int id, string title, string series, string country, string details)
        {
            this.Id = id;
            this.Title = title;
            this.Series = series;
            this.Country = country;
            this.Details = details;
        }*/
        

    }
}
