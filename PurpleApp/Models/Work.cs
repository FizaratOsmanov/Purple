using PurpleApp.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace PurpleApp.Models;

public class Work: BaseAuditableEntity
{
    
    [DisallowNull]
    [MinLength(3)]
    public string Title { get; set; }
    public string Description { get; set; }

    [AllowNull]
    public string MainImageUrl { get; set; }
    
    public int ServiceId { get; set;}

    [AllowNull]
    public Service? Service { get; set;}

}
