using ConsoleAppOrderBy;

IList<Student> studentList = new List<Student>() 
{
                new Student() { StudentID = 1, StudentNaam = "Jan", Leeftijd = 18 } ,
                new Student() { StudentID = 6, StudentNaam = "Piet", Leeftijd = 18 } ,
                new Student() { StudentID = 2, StudentNaam = "Joris",  Leeftijd = 15 } ,
                new Student() { StudentID = 3, StudentNaam = "Dimitri",  Leeftijd = 25 } ,
                new Student() { StudentID = 4, StudentNaam = "Carmen" , Leeftijd = 20 } ,
                new Student() { StudentID = 5, StudentNaam = "Pol" , Leeftijd = 19 }
};


//var studentenAflopend = studentList.OrderByDescending(s => s.Leeftijd);
var studentenOuderDan = studentList.Where(s => s.Leeftijd > 20);


foreach (var std in studentenOuderDan)
    Console.WriteLine(std.StudentNaam + ' ' + std.Leeftijd);