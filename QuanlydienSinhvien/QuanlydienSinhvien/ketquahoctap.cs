
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
    
public partial class ketquahoctap
{

    public int kqht_id { get; set; }

    public string mssv { get; set; }

    public Nullable<int> lophoc_id { get; set; }

    public Nullable<int> monhoc_id { get; set; }

    public Nullable<int> chuyencan { get; set; }

    public Nullable<int> giuaki { get; set; }

    public Nullable<int> cuoiki { get; set; }

    public Nullable<double> DTB { get; set; }

    public Nullable<int> hocki_id { get; set; }



    public virtual hocky hocky { get; set; }

    public virtual lophoc lophoc { get; set; }

    public virtual monhoc monhoc { get; set; }

}

}
