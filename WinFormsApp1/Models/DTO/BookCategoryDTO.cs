using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooKeeper.Models.DTO;
public class BookCategoryDTO
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
    public DateTime Year { get; set; }
    public string Category { get; set; }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("Title : " + this.Title);
        stringBuilder.AppendLine("Author : " + this.Author);
        stringBuilder.AppendLine("Category : " + this.Category);
        stringBuilder.AppendLine("Year of release : " + this.Year);
        stringBuilder.AppendLine("Description : " + this.Description);

        return stringBuilder.ToString();
    }
}
