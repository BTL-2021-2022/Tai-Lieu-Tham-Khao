using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace StoreApp.Models
{
    public partial class QuanLyBanGiayContext : DbContext
    {
        public QuanLyBanGiayContext()
        {
        }

        public QuanLyBanGiayContext(DbContextOptions<QuanLyBanGiayContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chitietdathang> Chitietdathangs { get; set; }
        public virtual DbSet<ChitietdathangNhap> ChitietdathangNhaps { get; set; }
        public virtual DbSet<Chitiethoadon> Chitiethoadons { get; set; }
        public virtual DbSet<Chitiethoadonnhap> Chitiethoadonnhaps { get; set; }
        public virtual DbSet<Chitietkhdat> Chitietkhdats { get; set; }
        public virtual DbSet<Dathangncc> Dathangnccs { get; set; }
        public virtual DbSet<DonhangmuaNhap> DonhangmuaNhaps { get; set; }
        public virtual DbSet<Donkhdat> Donkhdats { get; set; }
        public virtual DbSet<Hoadonban> Hoadonbans { get; set; }
        public virtual DbSet<Hoadonnhap> Hoadonnhaps { get; set; }
        public virtual DbSet<Khachhang> Khachhangs { get; set; }
        public virtual DbSet<Nguoiquanly> Nguoiquanlies { get; set; }
        public virtual DbSet<Nhacungcap> Nhacungcaps { get; set; }
        public virtual DbSet<Phieudoitra> Phieudoitras { get; set; }
        public virtual DbSet<Sanpham> Sanphams { get; set; }
        public virtual DbSet<SoLuongCon> SoLuongCons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-9PD6VKP\\SQLEXPRESS;Initial Catalog=QuanLyBanGiay;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Vietnamese_CI_AS");

            modelBuilder.Entity<Chitietdathang>(entity =>
            {
                entity.HasKey(e => new { e.MaHddatHang, e.MaSp, e.Size, e.Mau })
                    .HasName("PK__CHITIETD__82BDE1970DDB735A");

                entity.ToTable("CHITIETDATHANG");

                entity.Property(e => e.MaHddatHang).HasColumnName("MaHDDatHang");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MaSP");

                entity.Property(e => e.Mau).HasMaxLength(20);

                entity.Property(e => e.DonGiaDat).HasColumnType("money");

                entity.Property(e => e.TenSp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TenSP");

                entity.Property(e => e.ThanhTien).HasColumnType("money");

                entity.Property(e => e.TienCoc).HasColumnType("money");

                entity.HasOne(d => d.MaHddatHangNavigation)
                    .WithMany(p => p.Chitietdathangs)
                    .HasForeignKey(d => d.MaHddatHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CHITIETDA__MaHDD__4D94879B");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.Chitietdathangs)
                    .HasForeignKey(d => d.MaSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CHITIETDAT__MaSP__4BAC3F29");
            });

            modelBuilder.Entity<ChitietdathangNhap>(entity =>
            {
                entity.HasKey(e => new { e.MaSp, e.Size, e.Mau })
                    .HasName("PK__CHITIETD__8FD0CFB7EF84F3CC");

                entity.ToTable("CHITIETDATHANG_NHAP");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MaSP");

                entity.Property(e => e.Mau).HasMaxLength(20);

                entity.Property(e => e.DonGiaDat).HasColumnType("money");

                entity.Property(e => e.TenSp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TenSP");

                entity.Property(e => e.ThanhTien).HasColumnType("money");

                entity.Property(e => e.TienCoc).HasColumnType("money");
            });

            modelBuilder.Entity<Chitiethoadon>(entity =>
            {
                entity.HasKey(e => new { e.MaSp, e.SoHd, e.Size, e.Mau })
                    .HasName("PK__CHITIETH__F6699ED3809170CD");

                entity.ToTable("CHITIETHOADON");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MaSP");

                entity.Property(e => e.SoHd).HasColumnName("SoHD");

                entity.Property(e => e.Mau).HasMaxLength(20);

                entity.Property(e => e.GiaBan).HasColumnType("money");

                entity.Property(e => e.ThanhTien).HasColumnType("money");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.Chitiethoadons)
                    .HasForeignKey(d => d.MaSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CHITIETHOA__MaSP__49C3F6B7");

                entity.HasOne(d => d.SoHdNavigation)
                    .WithMany(p => p.Chitiethoadons)
                    .HasForeignKey(d => d.SoHd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CHITIETHOA__SoHD__440B1D61");
            });

            modelBuilder.Entity<Chitiethoadonnhap>(entity =>
            {
                entity.HasKey(e => new { e.SoHdn, e.MaSp, e.Size, e.Mau })
                    .HasName("PK__CHITIETH__4F3EE24FCC64B428");

                entity.ToTable("CHITIETHOADONNHAP");

                entity.Property(e => e.SoHdn).HasColumnName("SoHDN");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MaSP");

                entity.Property(e => e.Mau).HasMaxLength(20);

                entity.Property(e => e.DonGiaNhap).HasColumnType("money");

                entity.Property(e => e.TenSp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TenSP");

                entity.Property(e => e.ThanhTien).HasColumnType("money");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.Chitiethoadonnhaps)
                    .HasForeignKey(d => d.MaSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CHITIETHOA__MaSP__4AB81AF0");

                entity.HasOne(d => d.SoHdnNavigation)
                    .WithMany(p => p.Chitiethoadonnhaps)
                    .HasForeignKey(d => d.SoHdn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CHITIETHO__SoHDN__46E78A0C");
            });

            modelBuilder.Entity<Chitietkhdat>(entity =>
            {
                entity.HasKey(e => new { e.MaSp, e.SoHd, e.Size, e.Mau })
                    .HasName("PK__CHITIETK__F6699ED312421751");

                entity.ToTable("CHITIETKHDAT");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MaSP");

                entity.Property(e => e.SoHd).HasColumnName("SoHD");

                entity.Property(e => e.Mau).HasMaxLength(20);

                entity.Property(e => e.DonGiaNhap).HasColumnType("money");

                entity.Property(e => e.TenSp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TenSP");

                entity.Property(e => e.ThanhTien).HasColumnType("money");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.Chitietkhdats)
                    .HasForeignKey(d => d.MaSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CHITIETKHD__MaSP__47DBAE45");

                entity.HasOne(d => d.SoHdNavigation)
                    .WithMany(p => p.Chitietkhdats)
                    .HasForeignKey(d => d.SoHd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CHITIETKHD__SoHD__4CA06362");
            });

            modelBuilder.Entity<Dathangncc>(entity =>
            {
                entity.HasKey(e => e.MaHddatHang)
                    .HasName("PK__DATHANGN__EA40ED6C8EF13C31");

                entity.ToTable("DATHANGNCC");

                entity.Property(e => e.MaHddatHang).HasColumnName("MaHDDatHang");

                entity.Property(e => e.MaNcc)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MaNCC");

                entity.Property(e => e.NgayThang).HasColumnType("datetime");

                entity.Property(e => e.NguoiLap)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.MaNccNavigation)
                    .WithMany(p => p.Dathangnccs)
                    .HasForeignKey(d => d.MaNcc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DATHANGNC__MaNCC__45F365D3");
            });

            modelBuilder.Entity<DonhangmuaNhap>(entity =>
            {
                entity.HasKey(e => new { e.MaSp, e.Size, e.Mau })
                    .HasName("PK__DONHANGM__8FD0CFB711CBE0BC");

                entity.ToTable("DONHANGMUA_NHAP");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MaSP");

                entity.Property(e => e.Mau).HasMaxLength(20);

                entity.Property(e => e.DonGiaMua).HasColumnType("money");

                entity.Property(e => e.TenSp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TenSP");
            });

            modelBuilder.Entity<Donkhdat>(entity =>
            {
                entity.HasKey(e => e.SoHd)
                    .HasName("PK__DONKHDAT__BC3CAB5713CFCC04");

                entity.ToTable("DONKHDAT");

                entity.Property(e => e.SoHd).HasColumnName("SoHD");

                entity.Property(e => e.DiaChiKh)
                    .HasMaxLength(50)
                    .HasColumnName("DiaChiKH");

                entity.Property(e => e.NgayDat).HasColumnType("datetime");

                entity.Property(e => e.Sdt)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SDT");

                entity.Property(e => e.TenKh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TenKH");

                entity.Property(e => e.TienCoc).HasColumnType("money");

                entity.Property(e => e.TinhTrang)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Hoadonban>(entity =>
            {
                entity.HasKey(e => e.SoHd)
                    .HasName("PK__HOADONBA__BC3CAB57698F7DB5");

                entity.ToTable("HOADONBAN");

                entity.Property(e => e.SoHd).HasColumnName("SoHD");

                entity.Property(e => e.MaNql)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MaNQL");

                entity.Property(e => e.NgayBan).HasColumnType("datetime");

                entity.Property(e => e.Sdt)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SDT");

                entity.Property(e => e.TinhTrangDoiTra).HasMaxLength(20);

                entity.HasOne(d => d.MaNqlNavigation)
                    .WithMany(p => p.Hoadonbans)
                    .HasForeignKey(d => d.MaNql)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HOADONBAN__MaNQL__4222D4EF");

                entity.HasOne(d => d.SdtNavigation)
                    .WithMany(p => p.Hoadonbans)
                    .HasForeignKey(d => d.Sdt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HOADONBAN__SDT__4316F928");
            });

            modelBuilder.Entity<Hoadonnhap>(entity =>
            {
                entity.HasKey(e => e.SoHdn)
                    .HasName("PK__HOADONNH__27C3EEB4051A6C7A");

                entity.ToTable("HOADONNHAP");

                entity.Property(e => e.SoHdn).HasColumnName("SoHDN");

                entity.Property(e => e.MaNcc)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MaNCC");

                entity.Property(e => e.MaNql)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MaNQL");

                entity.Property(e => e.NgayNhap).HasColumnType("datetime");

                entity.HasOne(d => d.MaNccNavigation)
                    .WithMany(p => p.Hoadonnhaps)
                    .HasForeignKey(d => d.MaNcc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HOADONNHA__MaNCC__44FF419A");

                entity.HasOne(d => d.MaNqlNavigation)
                    .WithMany(p => p.Hoadonnhaps)
                    .HasForeignKey(d => d.MaNql)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HOADONNHA__MaNQL__412EB0B6");
            });

            modelBuilder.Entity<Khachhang>(entity =>
            {
                entity.HasKey(e => e.Sdt)
                    .HasName("PK__KHACHHAN__CA1930A4CB53F3F7");

                entity.ToTable("KHACHHANG");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SDT");

                entity.Property(e => e.DiaChiKh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("DiaChiKH");

                entity.Property(e => e.TenKh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TenKH");

                entity.Property(e => e.TongTien).HasColumnType("money");
            });

            modelBuilder.Entity<Nguoiquanly>(entity =>
            {
                entity.HasKey(e => e.MaNql)
                    .HasName("PK__NGUOIQUA__3A180B294C0B7A0A");

                entity.ToTable("NGUOIQUANLY");

                entity.Property(e => e.MaNql)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MaNQL");

                entity.Property(e => e.DiaChiNql)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("DiaChiNQL");

                entity.Property(e => e.MatKhau)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Sdtnql)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SDTNQL");

                entity.Property(e => e.TenNql)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TenNQL");

                entity.Property(e => e.TinhTrang)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Nhacungcap>(entity =>
            {
                entity.HasKey(e => e.MaNcc)
                    .HasName("PK__NHACUNGC__3A185DEB78CF10F4");

                entity.ToTable("NHACUNGCAP");

                entity.Property(e => e.MaNcc)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MaNCC");

                entity.Property(e => e.DiaChiNcc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("DiaChiNCC");

                entity.Property(e => e.Sdtncc)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SDTNCC");

                entity.Property(e => e.TenNcc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TenNCC");

                entity.Property(e => e.TinhTrang)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Phieudoitra>(entity =>
            {
                entity.HasKey(e => e.SoPhieu)
                    .HasName("PK__PHIEUDOI__960AAEE2BEE4C549");

                entity.ToTable("PHIEUDOITRA");

                entity.Property(e => e.DonGia).HasColumnType("money");

                entity.Property(e => e.MaSpmoi)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MaSPMoi");

                entity.Property(e => e.Mau).HasMaxLength(20);

                entity.Property(e => e.SoHd).HasColumnName("SoHD");

                entity.Property(e => e.TenSpmoi)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TenSPMoi");

                entity.Property(e => e.ThanhTien).HasColumnType("money");

                entity.HasOne(d => d.SoHdNavigation)
                    .WithMany(p => p.Phieudoitras)
                    .HasForeignKey(d => d.SoHd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PHIEUDOITR__SoHD__4E88ABD4");
            });

            modelBuilder.Entity<Sanpham>(entity =>
            {
                entity.HasKey(e => e.MaSp)
                    .HasName("PK__SANPHAM__2725081C191030A4");

                entity.ToTable("SANPHAM");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MaSP");

                entity.Property(e => e.GiaBan).HasColumnType("money");

                entity.Property(e => e.TenSp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TenSP");

                entity.Property(e => e.ThongTin)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TinhTrang)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<SoLuongCon>(entity =>
            {
                entity.HasKey(e => new { e.Size, e.MaSp, e.Mau })
                    .HasName("PK__SoLuongC__B390CAFDE5A41BB4");

                entity.ToTable("SoLuongCon");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MaSP");

                entity.Property(e => e.Mau).HasMaxLength(20);

                entity.Property(e => e.Slcon).HasColumnName("SLCon");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.SoLuongCons)
                    .HasForeignKey(d => d.MaSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SoLuongCon__MaSP__48CFD27E");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
