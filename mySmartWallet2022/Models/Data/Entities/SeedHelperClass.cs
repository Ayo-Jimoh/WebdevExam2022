namespace mySmartWallet2022.Models.Data.Entities
{
    public class SeedHelperClass
    {
        public static async Task seed(ApplicationDbContext context)
        {
            if (!context.Customers.Any())
            {

                context.Customers.Add(new Customer

                {
                    FirstName = "Jimoh",
                    LastName = "Ayodeji",
                    MiddleName = "Julius",
                    gender = GenderEnum.male,
                    MaritalStatus= MaritalStatusEnum.Single,
                    DateOfBirth = DateTime.Now.AddYears(-20),
                    Country = "Nigeria",
                    State = "Lagos",
                    City ="Magodo",
                    Active = true,

                });
                context.Customers.Add(new Customer

                {
                    FirstName = "Funmi",
                    LastName = "Adeola",
                    MiddleName = "Adejumoke",
                    gender = GenderEnum.Female,
                    MaritalStatus = MaritalStatusEnum.Single,
                    DateOfBirth = DateTime.Now.AddYears(-10),
                    Country = "England",
                    State = "London",
                    City = "Manhattan",
                    Active = true,

                }
                    );
                // context.SaveChangesAsync();
                await context.SaveChangesAsync();
            }
        
        }
    }
}
