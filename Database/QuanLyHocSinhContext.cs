using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace QuanLiSinhVien.Database;

public partial class QuanLyHocSinhContext : DbContext
{
    public QuanLyHocSinhContext()
    {
    }

    public QuanLyHocSinhContext(DbContextOptions<QuanLyHocSinhContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DangKyHocPhan> DangKyHocPhans { get; set; }

    public virtual DbSet<Diem> Diems { get; set; }

    public virtual DbSet<GiangVien> GiangViens { get; set; }

    public virtual DbSet<HocKy> HocKies { get; set; }

    public virtual DbSet<HocPhi> HocPhis { get; set; }

    public virtual DbSet<Khoa> Khoas { get; set; }

    public virtual DbSet<LopHocPhan> LopHocPhans { get; set; }

    public virtual DbSet<LopQuanLy> LopQuanLies { get; set; }

    public virtual DbSet<MonHoc> MonHocs { get; set; }

    public virtual DbSet<SinhVien> SinhViens { get; set; }

    public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

    public virtual DbSet<VaiTro> VaiTros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-CKTBGDM\\SQLEXPRESS;Initial Catalog=QuanLyHocSinh;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DangKyHocPhan>(entity =>
        {
            entity.HasKey(e => new { e.MaSv, e.MaLopHp }).HasName("PK__DangKyHo__1E53A4B96E663A9B");

            entity.ToTable("DangKyHocPhan");

            entity.Property(e => e.MaSv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaSV");
            entity.Property(e => e.MaLopHp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaLopHP");
            entity.Property(e => e.NgayDangKy).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.MaLopHpNavigation).WithMany(p => p.DangKyHocPhans)
                .HasForeignKey(d => d.MaLopHp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DangKyHoc__MaLop__5AEE82B9");

            entity.HasOne(d => d.MaSvNavigation).WithMany(p => p.DangKyHocPhans)
                .HasForeignKey(d => d.MaSv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DangKyHocP__MaSV__59FA5E80");
        });

        modelBuilder.Entity<Diem>(entity =>
        {
            entity.HasKey(e => new { e.MaSv, e.MaMh, e.LanThi }).HasName("PK__Diem__9281D00118A04477");

            entity.ToTable("Diem");

            entity.Property(e => e.MaSv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaSV");
            entity.Property(e => e.MaMh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaMH");
            entity.Property(e => e.DiemQt).HasColumnName("DiemQT");
            entity.Property(e => e.MaLopHp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaLopHP");

            entity.HasOne(d => d.MaLopHpNavigation).WithMany(p => p.Diems)
                .HasForeignKey(d => d.MaLopHp)
                .HasConstraintName("FK__Diem__MaLopHP__619B8048");

            entity.HasOne(d => d.MaMhNavigation).WithMany(p => p.Diems)
                .HasForeignKey(d => d.MaMh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Diem__MaMH__628FA481");

            entity.HasOne(d => d.MaSvNavigation).WithMany(p => p.Diems)
                .HasForeignKey(d => d.MaSv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Diem__MaSV__60A75C0F");
        });

        modelBuilder.Entity<GiangVien>(entity =>
        {
            entity.HasKey(e => e.MaGv).HasName("PK__GiangVie__2725AEF32856998D");

            entity.ToTable("GiangVien");

            entity.Property(e => e.MaGv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaGV");
            entity.Property(e => e.DienThoai)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MaK)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MaTk)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaTK");
            entity.Property(e => e.TenGv)
                .HasMaxLength(100)
                .HasColumnName("TenGV");

            entity.HasOne(d => d.MaKNavigation).WithMany(p => p.GiangViens)
                .HasForeignKey(d => d.MaK)
                .HasConstraintName("FK__GiangVien__MaK__3E52440B");

            entity.HasOne(d => d.MaTkNavigation).WithMany(p => p.GiangViens)
                .HasForeignKey(d => d.MaTk)
                .HasConstraintName("FK__GiangVien__MaTK__3F466844");
            entity.ToTable("GiangVien", tb => tb.HasTrigger("trg_xoa_giangvien"));
        });

        modelBuilder.Entity<HocKy>(entity =>
        {
            entity.HasKey(e => e.MaHk).HasName("PK__HocKy__2725A6E7A231244D");

            entity.ToTable("HocKy");

            entity.Property(e => e.MaHk)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaHK");
            entity.Property(e => e.TenHk)
                .HasMaxLength(50)
                .HasColumnName("TenHK");
        });

        modelBuilder.Entity<HocPhi>(entity =>
        {
            entity.HasKey(e => e.MaHp).HasName("PK__HocPhi__2725A6ECD17E01F2");

            entity.ToTable("HocPhi");

            entity.Property(e => e.MaHp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaHP");
            entity.Property(e => e.GiaTien).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MaMh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaMH");

            entity.HasOne(d => d.MaMhNavigation).WithMany(p => p.HocPhis)
                .HasForeignKey(d => d.MaMh)
                .HasConstraintName("FK__HocPhi__MaMH__656C112C");
        });

        modelBuilder.Entity<Khoa>(entity =>
        {
            entity.HasKey(e => e.MaK).HasName("PK__Khoa__C7977BAD4EA0CEFE");

            entity.ToTable("Khoa");

            entity.Property(e => e.MaK)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TenK).HasMaxLength(100);
        });

        modelBuilder.Entity<LopHocPhan>(entity =>
        {
            entity.HasKey(e => e.MaLopHp).HasName("PK__LopHocPh__976ACA320F8DE2D6");

            entity.ToTable("LopHocPhan");

            entity.Property(e => e.MaLopHp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaLopHP");
            entity.Property(e => e.MaGv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaGV");
            entity.Property(e => e.MaHk)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaHK");
            entity.Property(e => e.MaKhoa)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MaLopQl)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaLopQL");
            entity.Property(e => e.MaMh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaMH");
            entity.Property(e => e.TenLop).HasMaxLength(100);

            entity.HasOne(d => d.MaGvNavigation).WithMany(p => p.LopHocPhans)
                .HasForeignKey(d => d.MaGv)
                .HasConstraintName("FK__LopHocPhan__MaGV__5441852A");

            entity.HasOne(d => d.MaHkNavigation).WithMany(p => p.LopHocPhans)
                .HasForeignKey(d => d.MaHk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LopHocPhan__MaHK__5535A963");

            entity.HasOne(d => d.MaKhoaNavigation).WithMany(p => p.LopHocPhans)
                .HasForeignKey(d => d.MaKhoa)
                .HasConstraintName("FK__LopHocPha__MaKho__5629CD9C");

            entity.HasOne(d => d.MaLopQlNavigation).WithMany(p => p.LopHocPhans)
                .HasForeignKey(d => d.MaLopQl)
                .HasConstraintName("FK__LopHocPha__MaLop__52593CB8");

            entity.HasOne(d => d.MaMhNavigation).WithMany(p => p.LopHocPhans)
                .HasForeignKey(d => d.MaMh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LopHocPhan__MaMH__534D60F1");
            entity.ToTable("LopHocPhan", tb => tb.HasTrigger("trg_xoa_diem_lophocphan"));
        });

        modelBuilder.Entity<LopQuanLy>(entity =>
        {
            entity.HasKey(e => e.MaLopQl).HasName("PK__LopQuanL__976A95DD5E2604F6");

            entity.ToTable("LopQuanLy");

            entity.Property(e => e.MaLopQl)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaLopQL");
            entity.Property(e => e.MaGv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaGV");
            entity.Property(e => e.MaKhoa)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TenLop).HasMaxLength(100);

            entity.HasOne(d => d.MaGvNavigation).WithMany(p => p.LopQuanLies)
                .HasForeignKey(d => d.MaGv)
                .HasConstraintName("FK__LopQuanLy__MaGV__4222D4EF");

            entity.HasOne(d => d.MaKhoaNavigation).WithMany(p => p.LopQuanLies)
                .HasForeignKey(d => d.MaKhoa)
                .HasConstraintName("FK__LopQuanLy__MaKho__4316F928");
        });

        modelBuilder.Entity<MonHoc>(entity =>
        {
            entity.HasKey(e => e.MaMh).HasName("PK__MonHoc__2725DFD912702949");

            entity.ToTable("MonHoc");

            entity.Property(e => e.MaMh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaMH");
            entity.Property(e => e.MaK)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TenMh)
                .HasMaxLength(100)
                .HasColumnName("TenMH");

            entity.HasOne(d => d.MaKNavigation).WithMany(p => p.MonHocs)
                .HasForeignKey(d => d.MaK)
                .HasConstraintName("FK__MonHoc__MaK__4CA06362");
            entity.ToTable("MonHoc", tb => tb.HasTrigger("trg_xoa_diem_monhoc"));
        });

        modelBuilder.Entity<SinhVien>(entity =>
        {
            entity.HasKey(e => e.MaSv).HasName("PK__SinhVien__2725081A4323E3CF");

            entity.ToTable("SinhVien");

            entity.Property(e => e.MaSv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaSV");
            entity.Property(e => e.DienThoai)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MaKhoa)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MaLopQl)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaLopQL");
            entity.Property(e => e.MaTk)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaTK");
            entity.Property(e => e.PhuHuynhSdt)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PhuHuynhSDT");
            entity.Property(e => e.TenSv)
                .HasMaxLength(100)
                .HasColumnName("TenSV");

            entity.HasOne(d => d.MaKhoaNavigation).WithMany(p => p.SinhViens)
                .HasForeignKey(d => d.MaKhoa)
                .HasConstraintName("FK__SinhVien__MaKhoa__47DBAE45");

            entity.HasOne(d => d.MaLopQlNavigation).WithMany(p => p.SinhViens)
                .HasForeignKey(d => d.MaLopQl)
                .HasConstraintName("FK__SinhVien__MaLopQ__45F365D3");

            entity.HasOne(d => d.MaTkNavigation).WithMany(p => p.SinhViens)
                .HasForeignKey(d => d.MaTk)
                .HasConstraintName("FK__SinhVien__MaTK__46E78A0C");
            entity.ToTable("SinhVien", tb => tb.HasTrigger("trg_taotaikhoan_sinhvien"));
        });

        modelBuilder.Entity<TaiKhoan>(entity =>
        {
            entity.HasKey(e => e.MaTk).HasName("PK__TaiKhoan__27250070D82531BE");

            entity.ToTable("TaiKhoan");

            entity.HasIndex(e => e.TenDangNhap, "UQ__TaiKhoan__55F68FC08B69A29A").IsUnique();

            entity.Property(e => e.MaTk)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaTK");
            entity.Property(e => e.MaVt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaVT");
            entity.Property(e => e.MatKhau)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TenDangNhap)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.MaVtNavigation).WithMany(p => p.TaiKhoans)
                .HasForeignKey(d => d.MaVt)
                .HasConstraintName("FK__TaiKhoan__MaVT__3B75D760");
        });

        modelBuilder.Entity<VaiTro>(entity =>
        {
            entity.HasKey(e => e.MaVt).HasName("PK__VaiTro__2725103EF3AFFCE6");

            entity.ToTable("VaiTro");

            entity.Property(e => e.MaVt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaVT");
            entity.Property(e => e.TenVt)
                .HasMaxLength(50)
                .HasColumnName("TenVT");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
