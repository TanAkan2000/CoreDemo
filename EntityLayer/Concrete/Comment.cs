using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string CommentUserName{ get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }

        //herkes sisteme yorum yapabilecek isteme authentication olma işlemi yazarlar tarafından yapılabilcek
        public DateTime CommentDate { get; set; }
        public bool CommentStatus { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }

    }
}
