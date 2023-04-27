using Case2Aflevering;
using Microsoft.Extensions.DependencyInjection;


var serviceProvider = new ServiceCollection()
    // Singleton, Transient bestem selv. Singleton er for altid, transient er en ny hver gang.
    .AddSingleton<H1>()
    .AddSingleton<Search>()
    .BuildServiceProvider();


Mark mark = new Mark("Mark", "Hyrsting", "Larsen");
string returnValue = mark.ShowText();
Console.WriteLine(returnValue);


// 2D Liste eksempel
string[,] bilmærker2D = new string[,] 
{
    {"Toyota", "Mazda", "Nissan" },
    {"Audi", "BMV", "Mercedes" }
};


List<string> lst1 = new List<string>() { "Toyota", "Mazda", "Nissan" };
List<string> lst2 = new List<string>() { "Audi", "BMV", "Mercedes" };

List<List<string>> lstBilmærker2D = new List<List<string>>();
lstBilmærker2D.Add(lst1);
lstBilmærker2D.Add(lst2);


Console.WriteLine($"Min liste i Listen bilmærker: {lstBilmærker2D[1][1]}  {lstBilmærker2D[1][2]}");




















// Model klasse

//object[] objSamling = new object[] {
//    "Hello",
//    12,
//    new DateTime(1971, 02, 23)
//};

//Search search = serviceProvider.GetService<Search>()!;
//List<Person> teachers = search.GetTeachers();
//(new Search((new H1), "Hello World!")
//Search s = new();
//builder.Services.AddControllersWithViews();

//string strDato = ((DateTime)objSamling[2]).ToString("MM/dd/yyyy");
//string[] strDatoSplit = strDato.Split();
