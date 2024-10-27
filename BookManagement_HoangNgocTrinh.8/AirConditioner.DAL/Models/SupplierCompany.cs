using System;
using System.Collections.Generic;

namespace AirConditioner.DAL.Models;

public partial class SupplierCompany
{
    public string SupplierId { get; set; } = null!;

    public string SupplierName { get; set; } = null!;

    public string? SupplierDescription { get; set; }

    public string? PlaceOfOrigin { get; set; }

    public virtual ICollection<AirConditionerShop> AirConditioners { get; set; } = new List<AirConditionerShop>();
}
