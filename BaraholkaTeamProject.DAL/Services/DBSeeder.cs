using BaraholkaTeamProject.DAL.ContextData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BaraholkaTeamProject.DAL.Services
{
    public class DBSeeder
    {
        public static void SeedAll(MyContext context) 
        {
            if (context.users.Count() == 0 && context.products.Count() == 0)
            {
                User user = new User();
                byte []buffer;
                using (FileStream fs = new FileStream(@"Images\seederImage2.jpg", FileMode.Open, FileAccess.Read))
                {
                    buffer = new byte[fs.Length + 1];
                    fs.Read(buffer);
                }
                user.Image = buffer;
                user.Name = "Ivan";
                user.Surname = "Ivanov";
                user.Login = "12345678";
                user.Password = "12345678";

                context.users.Add(user);
                context.SaveChanges();


                byte[] bufferProduct;
                using (FileStream fs = new FileStream(@"Images\seederImage1.jpg", FileMode.Open, FileAccess.Read))
                {
                    bufferProduct = new byte[fs.Length + 1];
                    fs.Read(bufferProduct);
                }
                Product product = new Product();
                product.image = bufferProduct.ToArray();
                product.Name = "Iphone X";
                product.Description = "Запись видео 4K UHD 60 fps, " +
                    "Запись видео Slow Motion FullHD 240, Zoom 10x, " +
                    "Шестилинзовый объектив, Вспышка True Tone Quad-LED, " +
                    "Защита объектива сапфировым стеклом, Сенсор BSI, Гибридный ИК-фильтр";
                product.user = user;
                context.products.Add(product);

                context.SaveChanges();
            }
        }
    }
}
