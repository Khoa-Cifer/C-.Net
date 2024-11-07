using System;
using System.Collections.Generic;

namespace AirConditionerShop.DAL.Entities;

public partial class AirConditioner
{
    public int AirConditionerId { get; set; }

    public string AirConditionerName { get; set; } = null!;

    public string? Warranty { get; set; }

    public string? SoundPressureLevel { get; set; }

    public string? FeatureFunction { get; set; }

    public int? Quantity { get; set; }

    public double? DollarPrice { get; set; }

    public string? SupplierId { get; set; }  //MÃ NCC, FK, KHOÁ NGOẠI TRỎ THẲNG VÀO TABLE
                                             //SUPPLIER-COMPANY  

    //1 MÁY LẠNH THUỘC VỀ 1 NCC CỤ THỂ NÀO ĐÓ TẠM GỌI LÀ Supplier (biến object)
    //                                                           thuộc data-type NCC

    //                              NAVIGATION PATH - CON ĐƯỜNG GIÚP TA MÓC
    //                              SANG OBJECT BÊN KIA, SUPP-COMPANY
    public virtual SupplierCompany? Supplier { get; set; }
    //                         int  Yob { get; set; }  
    //                     Author   X;    

}
