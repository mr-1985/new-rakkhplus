using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyShop.DataLayer.Entities
{
    public class setting
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "درصد فروشگاه ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        public string ShopPercent { get; set; }

        [Display(Name = "قیمت فروشگاه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        public string ShopPrice { get; set; }

        [Display(Name = " درصد کارمزد تعداد اقساط ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        public string PaymentPercent { get; set; }

        [Display(Name = "درصد مبلغ تسهیلات ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        public string PricePercent { get; set; }

        [Display(Name = "درصد کارمزد بانک ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        public string BankPercent { get; set; }

        [Display(Name = "درصد کارمزد تعاونی ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        public string OperativePercent { get; set; }

        public DateTime CreateDtae { get; set; }
        public bool IsDelete { get; set; }
    }
}
