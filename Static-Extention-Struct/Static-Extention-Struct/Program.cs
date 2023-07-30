using Static_Extention_Struct;
using Static_Extention_Struct.Extentions;

//Person.Name = "Kubra";
//Console.WriteLine(Person.Name);
//Person.Test();


//Person person = new Person();
//Person person1 = new Person();
//Person person2 = new Person();
//Person person3 = new Person();

//Person.Name="Kubra";
//Console.WriteLine(Person.Name);

//Person.Test();
//Person.Test();
//Person.Test();

//Car car = new Car();
//Car car1 = new Car();
//Car car2 = new Car();

//Console.WriteLine(Car.count);


//string name = "";

//name. 

//int num = 5;
//num.Test();
//Console.WriteLine(num.Test());

//int num = 5;

//int result = num.Sum(100);
//Console.WriteLine(result);


//string name = "Fidan";
//Console.WriteLine(name.Contains("d"));


// Ozumuz yaratdigimiz metod HasStr

//Console.WriteLine(name.HasStr("n")); 


//string name = "Fidan";
//Console.WriteLine(name.CheckDigitOfString());

//string name = "Fidan";

//Console.WriteLine(name.CheckDigitOfString(@"\w"));
//Console.WriteLine(name.CheckDigitOfString(@"@"));
//Console.WriteLine(name.CheckDigitOfString(@"[A-Z]"));



Book book = new Book();
book.Name = "Xosrov ve Shirin";

book.Test();


//book.Name = "salam";
//book.Test();


//Animal animal = new Animal();


//string name = null;

//Console.WriteLine(name);


//int? age = null;

//if (age==null)
//{
//    Console.WriteLine("Age not found");
//}

//Animal animal = new Animal();
//animal.GetAge();





//GetRole(1);

//static void GetRole(int roleId)
//{
//    if (roleId == (int)Roles.SuperAdmin)
//    {
//        Console.WriteLine("SuperAdmin");
//     }
//}


//foreach (var item in Enum.GetValues(typeof(Roles))) 
//{
//    Console.WriteLine(item.ToString());
//}

///adina gore yoxlama
///
//GetHasRole("Admin");

//static void GetHasRole(string role)
//{
//    bool hasRole = false;

//    foreach (var item in Enum.GetValues(typeof(Roles)))
//    {
//        if (item.ToString()==role)
//        {
//            //Console.WriteLine("Yes, we have this role");
//            //return;

//            hasRole = true;
//        }

//    }

//    if (hasRole)
//    {
//        Console.WriteLine("Yes, we have this role");
//    }
//    else 
//    {
//        Console.WriteLine("No, we don`t have this role");
//    }
//}



//var result = GetHasRole("Admin");


//if (result)
//{
//    Console.WriteLine("yes");
//}
//else
//{
//    Console.WriteLine("No");
//}



//static bool GetHasRole(string role)
//{


//    foreach (var item in Enum.GetValues(typeof(Roles)))
//    {
//        if (item.ToString() == role)
//        {
//            //Console.WriteLine("Yes, we have this role");
//            //return;

//            return  true;
//        }

//    }

//    return false;
//}










//static string GetHasRole(string role)
//{


//    foreach (var item in Enum.GetValues(typeof(Roles)))
//    {
//        if (item.ToString() == role)
//        {
//            //Console.WriteLine("Yes, we have this role");
//            //return;

//            return "Yes";
//        }

//    }

//    return "No";
//}

//Console.WriteLine(GetHasRole("Admin"));




//Id-ye gore yoxlama


//CheckRole(3);

//static void CheckRole(int roleId)
//{

//	switch (roleId)
//	{
//		case (int)Roles.SuperAdmin:
//            Console.WriteLine("SuperAdmin");
//			break;
//        case (int)Roles.Admin:
//            Console.WriteLine("Admin");
//            break;
//        case (int)Roles.Member:
//            Console.WriteLine("Member");
//            break;
//        default:
//            Console.WriteLine("Role id is wrong");
//            break;
//    }

//}














