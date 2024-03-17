using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCoreProduct.Models;

namespace WebAppCoreProduct.Pages
{
    public class ProductModel : PageModel
    {
        public bool IsCorrect { get; set; } = true;
        public Product Product { get; set; }
        public string? MessageResult { get; private set; }

        public void OnPost(string name, decimal? price)
        {
            Product = new Product();
            if (price == null || price < 0 || string.IsNullOrEmpty(name))
            {
                MessageResult = "Переданы некорректные данные. Повторите ввод";
                return;
            }
            var result = price * (decimal?)0.18;
            MessageResult = $"Для товара {name} с ценой {price} скидка получится {result}";
            Product.Price = price;
            Product.Name = name;
        }

        public void OnGet()
        {
            MessageResult = "Для товара можно определить скидку";
        }

        public void OnPostDiscount(string name, decimal? price, double discount)
        {
            Product = new Product();
            var result = price * (decimal?)discount / 100;
            MessageResult = $"Для товара {name} с ценой {price} и скидкой {discount} получится { result}";
            Product.Price = price;
            Product.Name = name;
        }

        public void OnPostPromo(string name, decimal? price, string promo)
        {
            Product = new Product();
            if (promo == "BlackFriday")
            { 
            var result = price - (price * (decimal?)0.18) - ((price * (decimal?)0.18) * (decimal?)0.15);
                MessageResult = $"Для товара {name} действует дополнительная скидка 15% по промокоду {promo}. Цена равна {result}";
            }
            else
            {
                var result = price - (price * (decimal?)0.18);
                MessageResult = $"Данного промокода не существует. Цена равна {result}";
            }
            Product.Price = price;
            Product.Name = name;
        }
    }
}
