using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CraigslistClone.Models
{
    public class ImageUploadViewModel
    {
        [Required]
        public string Caption { get; set; }

        [Required]
        public HttpPostedFile File { get; set; }
    }

    public class Upload
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public string File { get; set; }
        public string EntityType { get; set; }

        public int? EntityId { get; set; }

        public string OwnerId { get; set; }

        [ForeignKey("OwnerId")]
        public virtual ApplicationUser Owner { get; set; }

        public virtual string FilePath
        {
            get
            {
                return $"/Uploads/{File}";
            }
        }
    }
}