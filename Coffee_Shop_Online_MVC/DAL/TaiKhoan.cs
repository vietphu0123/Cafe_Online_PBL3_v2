using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2.DAL
{
    [Table("TaiKhoan")]
    public class TaiKhoan
    {
        
        public TaiKhoan()
        {
            this.User = new HashSet<Users>();
            this.Manager = new HashSet<Managers>();
        }


        [Key]
        public int idTaiKhoan { get; set; }
        public string TenTaiKhoan { get; set; }
        public string pass { get; set; }
        public string LoaiTK { get; set; }
        public virtual ICollection<Managers> Manager { get; set; }
        public virtual ICollection<Users> User { get; set; }
    }
}
