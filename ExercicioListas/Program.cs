﻿namespace ListExercise{
  class Program { 
    static void Main(string[] args){
      Console.Write("How many employees will be registered? ");
      int n = int.Parse(Console.ReadLine());

      List<Employee> list = new List<Employee>();

      for(int i = 1; i <= n; i++){
        Console.WriteLine($"Employee #{i}: ");
        Console.Write("Id: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Salary: ");
        double salary = double.Parse(Console.ReadLine());
        list.Add(new Employee(id, name, salary));
      }
      Console.Write("Enter the employee that will have salary increase: ");
      int salaryIncreaseId = int.Parse(Console.ReadLine());

      Employee emp = list.Find(x => x.Id == salaryIncreaseId); {
        if(emp == null) Console.WriteLine("This ID does not exist!");
        else { Console.Write("Enter the percentage: ");
        double percentage = double.Parse(Console.ReadLine());
        emp.IncreaseSalary(percentage); }
      }

      Console.WriteLine("Updated list of employees: ");
      foreach(Employee emps in list){
        Console.WriteLine(emps);
      }
    }
  }
}