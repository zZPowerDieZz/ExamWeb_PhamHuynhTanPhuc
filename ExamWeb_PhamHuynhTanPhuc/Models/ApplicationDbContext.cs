﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWeb_PhamHuynhTanPhuc.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> ops) : base(ops)
        {
        }
        public DbSet<DiaNhac> DiaNhacs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DiaNhac>().HasData(
              new DiaNhac { Id = 1, TieuDe = "CD Nỗi buồn gác trọ", NgheSi = "Tuấn Vũ", TrongNuoc = true, GiaBan = 105000, SoLuong = 20 },
              new DiaNhac { Id = 2, TieuDe = "CD Bài tình ca đêm", NgheSi = "Chế Linh", TrongNuoc = true, GiaBan = 250000, SoLuong = 15 },
              new DiaNhac { Id = 3, TieuDe = "CD BABYMONSTER", NgheSi = "BABYMONSTER", TrongNuoc = false, GiaBan = 230000, SoLuong = 10 },
              new DiaNhac { Id = 4, TieuDe = "CD Chuyện chúng mình", NgheSi = "Mạnh Quỳnh", TrongNuoc = true, GiaBan = 150000, SoLuong = 30 },
              new DiaNhac { Id = 5, TieuDe = "CD Today's US-UK Hit ", NgheSi = "Taylor Swift", TrongNuoc = false, GiaBan = 27000, SoLuong = 10 },
              new DiaNhac { Id = 6, TieuDe = "CD Đoá hồng nhạc việt", NgheSi = "Văn Mai Hương", TrongNuoc = true, GiaBan = 220000, SoLuong = 40 }
            );
        }
    }
}
