using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooKeeper.Models.DTO;
internal class BookNumberDTO
{
    public BookNumberDTO(string title, string author, string description, DateTime year, string category, int totalNumber, int availableNumber)
    {
        Title = title;
        Author = author;
        Description = description;
        Year = year;
        Category = category;
        TotalNumber = totalNumber;
        AvailableNumber = availableNumber;
    }

    public string Title { get; set; }
    public string Author { get; set; }
    public string Description { get; set; }
    public DateTime Year { get; set; }
    public string Category { get; set; }
    public int TotalNumber { get; set; }
    public int AvailableNumber { get; set; }
}
