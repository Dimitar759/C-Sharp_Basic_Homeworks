using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Admin
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public Admin(string username, string password, string role)
        {
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }

        public string AddTeacher()
        {
            while (true) 
            {
                try
                {
                    Console.WriteLine("Enter username:");
                    string username = Console.ReadLine();

                    if (string.IsNullOrEmpty(username))
                    {
                        Console.WriteLine("Username cannot be empty.");
                        Console.WriteLine("Please try again.");
                        continue;
                    }

                    if (trainers.Any(s => s.Username == username))
                    {
                        Console.WriteLine("Username already exists. Please choose a different username.");
                        Console.WriteLine("Please try again.");
                        continue;
                    }

                    Console.WriteLine("Enter password:");
                    string password = Console.ReadLine();

                    if (password.Length < 8)
                    {
                        Console.WriteLine("Password must be at least 8 characters long.");
                        Console.WriteLine("Please try again.");
                        continue;
                    }

                    Trainer newTrainer = new Trainer(username, password, "Trainer");
                    trainers.Add(newTrainer);

                    Console.WriteLine("Trainer added successfully.");
                    return "Trainer added successfully.";
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    Console.WriteLine("Please try again.");
                    continue;
                }
            }
        }


        public string RemoveTeacher()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter username:");
                    string username = Console.ReadLine();

                    if (string.IsNullOrEmpty(username))
                    {
                        Console.WriteLine("Username cannot be empty.");
                        Console.WriteLine("Please try again.");
                        continue;
                    }

                    int removedCount = trainers.RemoveAll(t => t.Username == username);

                    if (removedCount == 0)
                    {
                        Console.WriteLine("Username doesn't exist. Please choose an existing username.");
                        Console.WriteLine("Please try again.");
                        continue;
                    }

                    Console.WriteLine("Teacher removed successfully.");
                    return "Teacher removed successfully.";
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    Console.WriteLine("Please try again.");
                    continue;
                }

            }
        }

        public string AddStudent()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter username:");
                    string username = Console.ReadLine();

                    if (string.IsNullOrEmpty(username))
                    {
                        Console.WriteLine("Username cannot be empty.");
                        Console.WriteLine("Please try again.");
                        continue;
                    }

                    if (students.Any(s => s.Username == username))
                    {
                        Console.WriteLine("Username already exists. Please choose a different username.");
                        Console.WriteLine("Please try again.");
                        continue;
                    }

                    Console.WriteLine("Enter password:");
                    string password = Console.ReadLine();

                    if (password.Length < 8)
                    {
                        Console.WriteLine("Password must be at least 8 characters long.");
                        Console.WriteLine("Please try again.");
                        continue;
                    }

                    Student newStudent = new Student(username, password, "Student");
                    students.Add(newStudent);

                    Console.WriteLine("Student added successfully.");
                    return "Student added successfully.";
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    Console.WriteLine("Please try again.");
                    continue;
                }
            }
        }

        public string RemoveStudent()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter username:");
                    string username = Console.ReadLine();

                    if (string.IsNullOrEmpty(username))
                    {
                        Console.WriteLine("Username cannot be empty.");
                        Console.WriteLine("Please try again.");
                        continue;
                    }

                    int removedCount = students.RemoveAll(t => t.Username == username);

                    if (removedCount == 0)
                    {
                        Console.WriteLine("Username doesn't exist. Please choose an existing username.");
                        Console.WriteLine("Please try again.");
                        continue;
                    }

                    Console.WriteLine("Student removed successfully.");
                    return "Student removed successfully.";
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    Console.WriteLine("Please try again.");
                    continue;
                }

            }
        }

        public string AddAdmin()
        {
            while (true)
            {

                try
                {
                    Console.WriteLine("Enter username:");
                    string username = Console.ReadLine();

                    if (string.IsNullOrEmpty(username))
                    {
                        Console.WriteLine("Username cannot be empty.");
                        Console.WriteLine("Please try again.");
                        continue;
                    }

                    if (admins.Any(s => s.Username == username))
                    {
                        Console.WriteLine("Username already exists. Please choose a different username.");
                        Console.WriteLine("Please try again.");
                        continue;
                    }

                    Console.WriteLine("Enter password:");
                    string password = Console.ReadLine();

                    if (password.Length < 8)
                    {
                        Console.WriteLine("Password must be at least 8 characters long.");
                        Console.WriteLine("Please try again.");
                        continue;
                    }

                    Trainer newAdmin = new Trainer(username, password, "Admin");
                    admins.Add(newAdmin);

                    Console.WriteLine("Admin added successfully.");
                    return "Admin added successfully.";
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    Console.WriteLine("Please try again.");
                    continue;
                }

            }
        }

        public string RemoveAdmin() 
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter username:");
                    string username = Console.ReadLine();

                    if (string.IsNullOrEmpty(username))
                    {
                        Console.WriteLine("Username cannot be empty.");
                        Console.WriteLine("Please try again.");
                        continue;
                    }

                    int removedCount = admins.RemoveAll(t => t.Username == username);

                    if (removedCount == 0)
                    {
                        Console.WriteLine("Username doesn't exist. Please choose an existing username.");
                        Console.WriteLine("Please try again.");
                        continue;
                    }

                    Console.WriteLine("Admin removed successfully.");
                    return "Admin removed successfully.";
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    Console.WriteLine("Please try again.");
                    continue;
                }

            }
        }

    }
}
