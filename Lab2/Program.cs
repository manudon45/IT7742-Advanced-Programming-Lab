using Lab2;

#region Exercise 1
Employee employee1 = new Employee("Manish Ray", 28, 101, "Software Development");
employee1.DisplayEmployeeDetails();

Console.WriteLine();

Employee employee2 = new Employee(102, "Human Resources");
employee2.DisplayEmployeeDetails();
#endregion

#region Exercise 2
Console.WriteLine("Exercise 2: Overloaded Construsctors\n");

Console.WriteLine("--- Creating Person with Name and Age ---");
Person2 person1 = new Person2("John Doe", 35);
Console.WriteLine($"Person: Name = {person1.Name}, Age = {person1.Age}\n");

Console.WriteLine("--- Creating Person with only Name (default Age) ---");
Person2 person2 = new Person2("Jane Smith");
Console.WriteLine($"Person: Name = {person2.Name}, Age = {person2.Age}\n");

Console.WriteLine("--- Creating Employee with all parameters ---");
Employee2 emp1 = new Employee2("Alice Walice", 30, 201, "IT Department");
emp1.DisplayEmployeeDetails();
Console.WriteLine();

Console.WriteLine("--- Creating Employee with Name, ID, and Department (default Age) ---");
Employee2 emp2 = new Employee2("Bob Willy", 202, "Finance");
emp2.DisplayEmployeeDetails();
Console.WriteLine();

Console.WriteLine("--- Creating Employee with only ID and Department (default Name and Age) ---");
Employee2 emp3 = new Employee2(203, "Marketing");
emp3.DisplayEmployeeDetails();
#endregion

#region Exercise 3
Console.WriteLine("Exercise 3: Access Modifiers and Getter/Setter Methods\n");

Console.WriteLine("--- Creating Employee using Getter/Setter Methods ---");
Employee3 emp = new Employee3("Michael Jordan", 32, 301, "Sales");
emp.DisplayEmployeeDetails();
Console.WriteLine();

Console.WriteLine("--- Modifying properties using Setter Methods ---");
emp.SetName("Michael Anderson");
emp.SetAge(33);
emp.SetEmployeeId(304);
emp.SetDepartment("Business Development");

Console.WriteLine("After modification:");
emp.DisplayEmployeeDetails();
Console.WriteLine();

Console.WriteLine("--- Accessing properties using Getter Methods ---");
Console.WriteLine($"Employee Name: {emp.GetName()}");
Console.WriteLine($"Employee Age: {emp.GetAge()}");
Console.WriteLine($"Employee ID: {emp.GetEmployeeId()}");
Console.WriteLine($"Employee Department: {emp.GetDepartment()}");
Console.WriteLine();

Console.WriteLine("--- Creating Employee with only ID and Department ---");
Employee3 emp4 = new Employee3(305, "Operations");
Console.WriteLine($"Name (before setting): {emp4.GetName()}");
Console.WriteLine($"Age (default): {emp4.GetAge()}");

// Set name and age
emp4.SetName("Sarah Lee");
emp4.SetAge(29);

Console.WriteLine("\nAfter setting Name and Age:");
emp4.DisplayEmployeeDetails();
#endregion

#region Exercise 4
Console.WriteLine("Exercise 4: Method Overriding\n");

Console.WriteLine("--- Creating Person4 instance ---");
Person4 person = new Person4("David Smith", 45);
person.DisplayDetails();
Console.WriteLine();

Console.WriteLine("--- Creating Employee4 instance ---");
Employee4 employee = new Employee4("Emily Johnson", 30, 401, "Engineering");
employee.DisplayDetails();
Console.WriteLine();

Console.WriteLine("--- Demonstrating Polymorphism ---");
Person4 empAsPersonReference = new Employee4("James Wilson", 28, 402, "Product");
Console.WriteLine("Calling DisplayDetails() through Person4 reference:");
empAsPersonReference.DisplayDetails();
Console.WriteLine();

Console.WriteLine("--- Using DisplayDetailsWithBase() method ---");
employee.DisplayDetailsWithBase();
Console.WriteLine();

Console.WriteLine("--- Demonstrating Polymorphic Behavior ---");
Person4 p4_1 = new Person4("Alice Martinez", 50);
Employee4 p4_2 = new Employee4("Bob Taylor", 35, 403, "Sales");
Person4 p4_3 = new Person4("Carol White", 40);
Employee4 p4_4 = new Employee4("Manish Kumar", 32, 404, "Finance");

Console.WriteLine("Displaying details for all people:\n");
p4_1.DisplayDetails();
Console.WriteLine();

p4_2.DisplayDetails();
Console.WriteLine();

p4_3.DisplayDetails();
Console.WriteLine();

p4_4.DisplayDetails();

#endregion

#region Exercise 5
Console.WriteLine("Exercise 5: Inheritance Hierarchy\n");

Console.WriteLine("--- Creating Person5 instance ---");
Person5 person5 = new Person5("Gregory White", 50);
person5.DisplayDetails();
Console.WriteLine();

Console.WriteLine("--- Creating Employee5 instance ---");
Employee5 employee5 = new Employee5("Olivia Harris", 29, 501, "Research & Development");
employee5.DisplayDetails();
Console.WriteLine();

Console.WriteLine("--- Creating Manager5 instance (wIth all parameters) ---");
Manager5 manager1 = new Manager5("Richard Chen", 45, 502, "Engineering", 8);
manager1.DisplayDetails();
Console.WriteLine();

Console.WriteLine("--- Creating Manager5 instance (with Name, ID, Department, TeamSize) ---");
Manager5 manager2 = new Manager5("Patricia Davis", 502, "Quality Assurance", 6);
manager2.DisplayDetails();
Console.WriteLine();

Console.WriteLine("--- Creating Manager5 instance (with minimal parameters) ---");
Manager5 manager3 = new Manager5(503, "Operations", 5);
Console.WriteLine($"Name (default): {manager3.Name}");
Console.WriteLine($"Age (default): {manager3.Age}");
manager3.DisplayDetails();
Console.WriteLine();

Console.WriteLine("--- Demonstrating Polymorphism with Inheritance Hierarchy ---");
Person5 p1 = new Person5("Rachel Green", 40);
Employee5 e1 = new Employee5("Monica Geller", 32, 504, "Finance");
Manager5 mgr1 = new Manager5("Ross Geller", 48, 505, "IT Management", 10);
Employee5 e2 = new Employee5("Chandler Bing", 35, 506, "Human Resources");
Manager5 mgr2 = new Manager5("Phoebe Buffay", 38, 507, "Marketing", 7);

Console.WriteLine("Displaying details for all people in the hierarchy:\n");
p1.DisplayDetails();
Console.WriteLine();

e1.DisplayDetails();
Console.WriteLine();

mgr1.DisplayDetails();
Console.WriteLine();

e2.DisplayDetails();
Console.WriteLine();

mgr2.DisplayDetails();
#endregion

#region Exercise 6
Console.WriteLine("Exercise 6: Practical Application - Library System\n");

Console.WriteLine("--- Creating LibraryItem instance (base class) ---");
LibraryItem item = new LibraryItem("Item1", "Author0", 2020);
item.DisplayDetails();
Console.WriteLine();

Console.WriteLine("--- Creating Book instances ---");
Book book1 = new Book("Book1", "Author1", 2022, "ISBN001", "Genre1");
book1.DisplayDetails();
Console.WriteLine();

Book book2 = new Book("Book2", "Author2", 2008, "ISBN002", "Genre2");
book2.DisplayDetails();
Console.WriteLine();

Console.WriteLine("--- Creating Magazine instances ---");
Magazine magazine1 = new Magazine("Magazine1", "Author3", 2024, 3, "Frequency1");
magazine1.DisplayDetails();
Console.WriteLine();

Magazine magazine2 = new Magazine("Magazine2", "Author4", 2024, 15, "Frequency2");
magazine2.DisplayDetails();
Console.WriteLine();

Console.WriteLine("--- Demonstrating Polymorphism with Library Items ---");
LibraryItem lib1 = new Book("Book3", "Author5", 1994, "ISBN003", "Genre3");
LibraryItem lib2 = new Magazine("Magazine3", "Author6", 2024, 5, "Frequency3");
LibraryItem lib3 = new Book("Book4", "Author7", 2009, "ISBN004", "Genre4");

Console.WriteLine("Library Collection:\n");
lib1.DisplayDetails();
Console.WriteLine();

lib2.DisplayDetails();
Console.WriteLine();

lib3.DisplayDetails();
#endregion

