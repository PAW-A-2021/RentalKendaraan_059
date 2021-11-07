using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RentalKendaraan.Models
{
    public partial class Pengembalian
    {
        public int IdPengembalian { get; set; }
        public DateTime? TglPengembalian { get; set; }
        public int? IdPeminjaman { get; set; }
        public int? IdKondisiq { get; set; }
        public int? Denda { get; set; }

        public virtual KondisiKendaraan IdKondisiqNavigation { get; set; }
        public virtual Peminjaman IdPeminjamanNavigation { get; set; }
    }
}
