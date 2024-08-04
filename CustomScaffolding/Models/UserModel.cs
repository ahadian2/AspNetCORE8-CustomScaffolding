using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CustomScaffolding.Models
{
    public class UserModel
    {
        [DisplayName("شماره یکتا")]
        public int Id { get; set; }
        [DisplayName(" نام")]
        public string Name { get; set; }
        [DisplayName(" نام خانوادگی")]
        public string Family { get; set; }
    }
}
