﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demo1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QL_TOURDL_N5Entities2 : DbContext
    {
        public QL_TOURDL_N5Entities2()
            : base("name=QL_TOURDL_N5Entities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AnhTin> AnhTins { get; set; }
        public virtual DbSet<AnhTour> AnhTours { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<ChucNang> ChucNangs { get; set; }
        public virtual DbSet<DIADIEM_TOUR> DIADIEM_TOUR { get; set; }
        public virtual DbSet<DiemThamQuan> DiemThamQuans { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<KhachSan> KhachSans { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhanQuyen> PhanQuyens { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<TinTuc> TinTucs { get; set; }
        public virtual DbSet<Tour> Tours { get; set; }
    }
}
