using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace SinglePerson
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = new WebClient().DownloadString("https://uinames.com/api/?ext&amount=10");

            List<Person> people = new JavaScriptSerializer().Deserialize<List<Person>>(json);

            foreach (Person person in people)
            {
                Console.WriteLine(
                    $"=============== Person ==============\n\n" +
                    $"Name: {person.title} {person.name} {person.surname}\n" +
                    $"Gender: {person.gender}\n" +
                    $"Age: {person.age}\n" +
                    $"Phone: {person.phone}\n" +
                    $"Birthday: {person.birthday.dmy}\n" +
                    $"Email: {person.email}\n" +
                    $"Password: {person.password}\n" +
                    $"Photo: {person.photo}\n\n" +
                    $"============ Credit Card ============\n\n" +
                    $"Number: {person.credit_card.number}\n" +
                    $"Pin: {person.credit_card.pin}\n" +
                    $"Expiration: {person.credit_card.expiration}\n" +
                    $"Security: {person.credit_card.security}\n\n" +
                    $"=====================================\n\n\n");
                    
            }

            Console.ReadKey();
        }
    }
}
