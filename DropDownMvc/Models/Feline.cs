using System.ComponentModel.DataAnnotations;

namespace DropDownMvc.Models
{
    public enum Feline
    {
        Domestic,
        [Display(Name = "Wild cat")]
        WildCat,
        [Display(Name = "Jungle cat")]
        JungleCat,
        [Display(Name = "Black-footed cat")]
        BlackFootedCat
    }
}
