using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class customermanager
    {
        public void add(customer customer)
        {
            Console.WriteLine(customer.id + "müşteri ID eklendi. \n");
            Console.WriteLine(customer.name + "müşteri adı eklendi. \n");
            Console.WriteLine(customer.cell + "müşteri numarası eklendi. \n");
            Console.WriteLine(customer.totalbalance + "müşteri bakiye oluşturuldu. \n");

        }
        public void delete(customer customer)
        {
            Console.WriteLine("Silmek istediğiniz müşteri ismini giriniz: " + customer.name);
            Console.WriteLine("Müşteri silinme işlemi başarılı.");

        }

        public void update(customer customer)
        {
            Console.WriteLine("Bilgilerini güncellemek istediğiniz müşteri ismini giriniz: " + customer.name);
            Console.WriteLine("Müşteri güncelleme işlemi başarılı.");

        }

        public void list(customer customer)
        {
          

        }




    }
}
