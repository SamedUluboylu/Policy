using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace policy.Models
{
    public class InstallmentInformationModel
    {
        [System.ComponentModel.DisplayName("Tarih")]
        public string Date { get; set; }

        [System.ComponentModel.DisplayName("Aylık Gün Sayısı")]
        public int Days { get; set; }

        [System.ComponentModel.DisplayName("Taksit Tutarı")]
        public int Amount { get; set; }

    }
}
