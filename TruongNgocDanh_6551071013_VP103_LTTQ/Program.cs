using Microsoft.EntityFrameworkCore;
using TruongNgocDanh_6551071013_VP103_LTTQ.Models;

namespace TruongNgocDanh_6551071013_VP103_LTTQ
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var options = new DbContextOptionsBuilder<DuLieuContext>()
                .UseSqlServer(
                    "Server=.localhost,1433;Database=DuLieu;Trusted_Connection=True;TrustServerCertificate=True;")
                .Options;

            using (DuLieuContext db = new DuLieuContext(options))
            {
                Application.Run(new Form1());
            }
        }
    }
}