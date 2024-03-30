using OneFit.Domain.Commons;
using OneFit.Domain.Enums;

namespace OneFit.Domain.Entities;

public class Studio : Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Address { get; set; }
    public StudioType Type { get; set; }
    public long CategoryId { get; set; }
}