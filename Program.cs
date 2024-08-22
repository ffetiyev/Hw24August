



using System.Globalization;

//Person p = new Person()
//{
//    Name = "dfwef",
//    Surname = "efw",
//};

//p.Age = 918;

//Console.WriteLine(p.Age);

//Student stu1 = new Student()
//{
//    fullName = "Farid Fatiyev",
//    //no = 1,
//    groupNo = "p402",
//};
//Console.WriteLine(stu1.groupNo);

//Person p = new Person();

//Person.SayHi();

//Console.WriteLine("efnwnfWEFKKF".ToCapitalize());

using Models;
Person p1 = new Person()
{
    Name="John",
    Surname="Doe",
};
Person p2 = new Person()
{
    Name="Jake",
    Surname="Doe",
};

Console.WriteLine(Person._instanceCount);
Console.WriteLine(p1.PrintInfo());

