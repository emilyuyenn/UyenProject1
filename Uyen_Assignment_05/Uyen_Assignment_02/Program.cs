// See https://aka.ms/new-console-template for more information
using Uyen_Assignment_05;
{
    Console.Write("\nProject 05: Business Transportation Management\n");
    Console.Write("---------------------------------------------------\n");
    Console.Write("Name: Nguyen Thi Thu Uyen\n");
    Console.Write("Class: K21PFP-01\n\n\n");


    string choice;
    int booktimes = 0;
    Company company = new Company();
    Customer customer = new Customer();

    List<Vehicle> vehicles = Company.ReadData("Uyen.txt");
    company.SetVehicle(vehicles);
    company.RandomLocationVehicleList();
    do
    {

        Console.Write("Start new trip \n");
        Console.Write("Answer (YES/EXIT) \n");
        choice = Console.ReadLine();
        
        switch (choice)
        {
            case "YES":
                {
                    

                    
                    
                    company.RandomStatusVehicleList();
                    for (int i = 0; i < vehicles.Count; i++)
                    {
                        Console.WriteLine(vehicles[i]);
                    }
                    

                    customer.BookVehicle(company);
                    

                    //booktimes++;
                    //if (booktimes % 3 == 0)
                    //{
                    //    vehicles[i].UpdateGPS(company.g);
                    //}
                }
                    
                break;
            case "EXIT":
                Environment.Exit(0);
                break;
        } 
    } while (choice == "YES");

}
