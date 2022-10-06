using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Publisher
{
    [Key]
    public int PublisherId { get; set; }
    public string Name { get; set; }
    [InverseProperty("Publisher")]
    public ICollection<Book> Books { get; set; }
}