using System.ComponentModel;

namespace MvcCreditApp.Models
{
    public class Credit
    {
        // ID кредита
        public virtual int CreditId { get; set; }
        // Название
        [DisplayName("Вид кредита")]
        public virtual string Head { get; set; }
        // Период, на который выдается кредит
        [DisplayName("Период")]
        public virtual int Period { get; set; }
        // Максимальная сумма кредита
        [DisplayName("Сумма")]
        public virtual int Sum { get; set; }
        // Процентная ставка
        [DisplayName("Ставка")]
        public virtual int Procent { get; set; }
    }
}
