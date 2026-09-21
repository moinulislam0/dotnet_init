using System;

class Test {

    public static void Main(){
    // string name = " Md Moinul Islam";
    // int age = 25;
    // double number = 12.3;
    // bool isTrue = false;
    // char bloodgroup = 'A';
    // Console.WriteLine($"Name : {name}");
    // Console.WriteLine(age);
    // Console.WriteLine(number);
    // Console.WriteLine(isTrue);
    // Console.WriteLine(bloodgroup);
    // double salary = 2458.2;
    // Console.WriteLine(salary);

    // int salary2 = (int)salary;
    // Console.WriteLine(salary2);

    // Console.WriteLine(Convert.ToString(salary2));
    // Console.WriteLine(Convert.ToDouble(salary2));
    // Console.WriteLine(Convert.ToInt32(salary));
    String input = "15";
    int age ;
    int result;
    bool isSuccess = int.TryParse(input ,out result);
    Console.WriteLine(result);
    Console.WriteLine(isSuccess);
    Console.WriteLine("Enter your name : ");
   String? name = Console.ReadLine();
    Console.WriteLine("Enter your age :");
     age =Convert.ToInt32( Console.ReadLine());
    Console.WriteLine("Name "+name);
    Console.WriteLine("Age "+age);
    }
}