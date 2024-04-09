using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models.Domain
{
    public class TblAlbum
    {
        [Key]
        public int Album_Id { get; set; }
        public int Album_No { get; set; }
        public string Album_Tur { get; set; }
        public string Sanatci_Bilgi { get; set; }
        public string Album_Ad { get; set; }
        public Decimal Album_Fiyat { get; set; }
        public bool Yerli { get; set; }
        public string Menajer_Bilgi { get; set; }
    }
}
