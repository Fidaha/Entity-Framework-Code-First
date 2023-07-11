namespace Savings.Models
{
    public class Person
    {
        public Guid PersonId { get; set; }
        public string Name { get; set; }
        public List<SavingAccount> SavingAccounts { get; set; } 

        public Person() { 
        }

        public Person(string name, List<SavingAccount> savingAccounts) 
        {
            Name = name;
            SavingAccounts = savingAccounts;
        }

    }
}
