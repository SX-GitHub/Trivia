using System.ComponentModel.DataAnnotations;

namespace DropDownMvc.Models
{
    public enum Canine
    {
        [Display(Name = "German sheperd")]
        GermanSheperd,
        [Display(Name = "Gold retriever")]
        GoldRetriever,
        Boxer,
        Poodle,
        Bulldog
    }
}
