
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace QuanlydienSinhvien
{

using System;
    using System.Collections.Generic;
    
public partial class monhoc
{

    public monhoc()
    {

        this.ketquahoctaps = new HashSet<ketquahoctap>();

    }


    public int monhoc_id { get; set; }

    public string maMH { get; set; }

    public string tenMH { get; set; }

    public Nullable<int> hocki_id { get; set; }



    public virtual hocky hocky { get; set; }

    public virtual ICollection<ketquahoctap> ketquahoctaps { get; set; }

}

}
