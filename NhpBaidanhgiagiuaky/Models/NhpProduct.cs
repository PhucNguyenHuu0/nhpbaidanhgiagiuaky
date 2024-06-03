using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace NhpBaidanhgiagiuaky.Models
{
    public class NhpProduct
    {
        [Required(ErrorMessage = "Hãy nhập mã số")]
        public int nhpId { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên sản phẩm")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Tên sản phẩm phải dài từ 5 đến 100 ký tự")]
        [RegularExpression("[A-Z ]+", ErrorMessage = "Tên sản phẩm chỉ chứa ký tự viết hoa và khoảng trắng")]
        public string nhpName { get; set; }
        [Required(ErrorMessage = "Hãy nhập ảnh")]
        public string nhpImage { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập số lượng sản phẩm")]
        [Range(1, 100, ErrorMessage = "Số lượng sản phẩm phải nằm trong khoảng từ 1 đến 100")]
        public int nhpQuantity { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập giá sản phẩm")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Giá sản phẩm phải lớn hơn 0")]
        public decimal nhpPrice { get; set; }
        public bool nhpIsActive { get; set; } = true;
    }
}