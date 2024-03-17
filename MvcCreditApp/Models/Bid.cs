using System.ComponentModel;


namespace MvcCreditApp.Models
{
    public class Bid
    {
        // ID заявки
        public virtual int BidId { get; set; }
        // Имя заявителя
        [DisplayName("Имя заявителя")]
        public virtual string Name { get; set; }
        // Название кредита
        [DisplayName("Вид кредита")]
        public virtual string CreditHead { get; set; }
        [DisplayName("Дата подачи заявки")]
        public virtual DateTime bidDate
        {
            get; set;
        }
    }
}
