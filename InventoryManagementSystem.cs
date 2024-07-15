using System;
using System.Collections.Generic;
using System.Linq;

namespace InventoryManagementSystem
{
    class Program
    {
        static List<User> users = new List<User>();
        static List<Client> clients = new List<Client>();
        static List<Product> products = new List<Product>();

        static void Main(string[] args)
        {
            SeedData();

            while (true)
            {

                Console.WriteLine("================================================");
                Console.WriteLine("************** INVENTORY STORE ****************");
                Console.WriteLine("================================================");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Manage Users");
                Console.WriteLine("3. Manage Clients");
                Console.WriteLine("4. Manage Products");
                Console.WriteLine("5. View Stock Information");
                Console.WriteLine("6. Generate Bill");
                Console.WriteLine("7. Exit");
                Console.WriteLine("================================================");
                Console.Write("ENTER YOUR CHOICE (1-7) :: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Login();
                        break;
                    case 2:
                        ManageUsers();
                        break;
                    case 3:
                        ManageClients();
                        break;
                    case 4:
                        ManageProducts();
                        break;
                    case 5:
                        DisplayStockInformation();
                        break;
                    case 6:
                        GenerateBill();
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void SeedData()
        {
            users.Add(new User { Username = "admin", Password = "password" });
            // products.Add(new Product { Id = 1, Name = "Product1", Category = "Category1", Quantity = 100, Price = 10, ExpiryDate = DateTime.Now.AddMonths(1) });
        }

        static void Login()
        {
            Console.WriteLine("Enter Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();

            User user = users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                Console.WriteLine("Login successful!");
            }
            else
            {
                Console.WriteLine("Invalid credentials.");
            }
        }

        static void ManageUsers()
        {
            Console.WriteLine("================================================");
            Console.WriteLine("-------------MANAGE USERS OF SYSTEM------------");
            Console.WriteLine("1. Add User");
            Console.WriteLine("2. Delete User");
            Console.WriteLine("3. Update User");
            Console.WriteLine("4. Display Users");
            Console.WriteLine("5. Back");
            Console.WriteLine("================================================");

            Console.WriteLine("Enter your choice to manage users of system (1-5) :: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    AddUser();
                    break;
                case 2:
                    DeleteUser();
                    break;
                case 3:
                    UpdateUser();
                    break;
                case 4:
                    DisplayUsers();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        static void AddUser()
        {
            Console.WriteLine("Enter Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();

            users.Add(new User { Username = username, Password = password });
            Console.WriteLine("User added successfully.");
        }
        static void DeleteUser()
        {
            Console.WriteLine("Enter Username to delete:");
            string username = Console.ReadLine();

            User user = users.FirstOrDefault(u => u.Username == username);
            if (user != null)
            {
                users.Remove(user);
                Console.WriteLine("User deleted successfully.");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }

        static void UpdateUser()
        {
            Console.WriteLine("Enter Username to update:");
            string username = Console.ReadLine();

            User user = users.FirstOrDefault(u => u.Username == username);
            if (user != null)
            {
                Console.WriteLine("Enter new Password:");
                string password = Console.ReadLine();

                user.Password = password;
                Console.WriteLine("User updated successfully.");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }

        static void DisplayUsers()
        {
            Console.WriteLine("Users:");
            foreach (var user in users)
            {
                Console.WriteLine(String.Format("Username: {0}", user.Username));
            }
        }

        static void ManageClients()
        {
            Console.WriteLine("================================================");
            Console.WriteLine("-------------MANAGE CLIENTS OF SYSTEM------------");
            Console.WriteLine("================================================");

            Console.WriteLine("1. Add Client");
            Console.WriteLine("2. Delete Client");
            Console.WriteLine("3. Update Client");
            Console.WriteLine("4. Display Clients");
            Console.WriteLine("5. Back");
            Console.WriteLine("================================================");

            Console.WriteLine("Enter your choice to manage clients of system (1-5) :: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddClient();
                    break;
                case 2:
                    DeleteClient();
                    break;
                case 3:
                    UpdateClient();
                    break;
                case 4:
                    DisplayClients();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        static void AddClient()
        {
            Console.WriteLine("Enter Client Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Client Address:");
            string address = Console.ReadLine();

            clients.Add(new Client { Name = name, Address = address });
            Console.WriteLine("Client added successfully.");
        }

        static void DeleteClient()
        {
            Console.WriteLine("Enter Client Name to delete:");
            string name = Console.ReadLine();
            Client client = clients.FirstOrDefault(c => c.Name == name);
            if (client != null)
            {
                clients.Remove(client);
                Console.WriteLine("Client deleted successfully.");
            }
            else
            {
                Console.WriteLine("Client not found.");
            }
        }

        static void UpdateClient()
        {
            Console.WriteLine("Enter Client Name to update:");
            string name = Console.ReadLine();

            Client client = clients.FirstOrDefault(c => c.Name == name);
            if (client != null)
            {
                Console.WriteLine("Enter new Address:");
                string address = Console.ReadLine();

                client.Address = address;
                Console.WriteLine("Client updated successfully.");
            }
            else
            {
                Console.WriteLine("Client not found.");
            }
        }

        static void DisplayClients()
        {
            Console.WriteLine("Clients:");
            foreach (var client in clients)
            {
                Console.WriteLine(String.Format("Name: {0}, Address: {1}", client.Name, client.Address));

            }
        }

        static void ManageProducts()
        {
            Console.WriteLine("\nManage Products");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Delete Product");
            Console.WriteLine("3. Update Product");
            Console.WriteLine("4. Display Products");
            Console.WriteLine("5. Back");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddProduct();
                    break;
                case 2:
                    DeleteProduct();
                    break;
                case 3:
                    UpdateProduct();
                    break;
                case 4:
                    DisplayProducts();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        static void AddProduct()
        {
            Console.WriteLine("Enter Product Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Product Category:");
            string category = Console.ReadLine();
            Console.WriteLine("Enter Product Quantity:");
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Price:");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Expiry Date (yyyy-mm-dd):");
            DateTime expiryDate = DateTime.Parse(Console.ReadLine());

            products.Add(new Product { Id = products.Count + 1, Name = name, Category = category, Quantity = quantity, Price = price, ExpiryDate = expiryDate });
            Console.WriteLine("Product added successfully.");
        }

        static void DeleteProduct()
        {
            Console.WriteLine("Enter Product Id to delete:");
            int id = int.Parse(Console.ReadLine());

            Product product = products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                products.Remove(product);
                Console.WriteLine("Product deleted successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        static void UpdateProduct()
        {
            Console.WriteLine("Enter Product Id to update:");
            int id = int.Parse(Console.ReadLine());

            Product product = products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                Console.WriteLine("Enter new Product Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter new Product Category:");
                string category = Console.ReadLine();
                Console.WriteLine("Enter new Product Quantity:");
                int quantity = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter new Product Price:");
                decimal price = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter new Product Expiry Date (yyyy-mm-dd):");
                DateTime expiryDate = DateTime.Parse(Console.ReadLine());

                product.Name = name;
                product.Category = category;
                product.Quantity = quantity;
                product.Price = price;
                product.ExpiryDate = expiryDate;

                Console.WriteLine("Product updated successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        static void DisplayProducts()
        {
            Console.WriteLine("Products:");
            foreach (var product in products)
            {
                Console.WriteLine(String.Format(
                    "Id: {0}, Name: {1}, Category: {2}, Quantity: {3}, Price: {4}, Expiry Date: {5}",
                    product.Id,
                    product.Name,
                    product.Category,
                    product.Quantity,
                    product.Price,
                    product.ExpiryDate.ToShortDateString()
                ));
            }
        }

        static void DisplayStockInformation()
        {
            Console.WriteLine("Stock Information:");
            foreach (var product in products)
            {
                Console.WriteLine(String.Format("Id: {0}, Name: {1}, Quantity: {2}", product.Id, product.Name, product.Quantity));
            }
        }

        static void GenerateBill()
        {
            Console.WriteLine("Enter Product Id to purchase:");
            int id = int.Parse(Console.ReadLine());

            Product product = products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                Console.WriteLine("Enter Quantity:");
                int quantity = int.Parse(Console.ReadLine());

                if (quantity <= product.Quantity)
                {
                    product.Quantity -= quantity;
                    decimal total = quantity * product.Price;
                    Console.WriteLine(String.Format("Total Bill Amount: {0}", total));
                }
                else
                {
                    Console.WriteLine("Insufficient stock.");
                }
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }
    }
    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    class Client
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}