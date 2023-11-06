using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCApplication_1.Models
{
    public enum Status
    {
        [Display(Name = "In Progress")]
        InProgress,
        Done,
        Paused
    }
}
