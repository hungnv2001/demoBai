using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class Staff
	{
        [Key]
        public int Id { get; set; }
        [MinLength(4,ErrorMessage ="Phải có tên trên 4 ký tự")]
        public string Name { get; set; }

        public string GrId { get; set; }
    }
}
