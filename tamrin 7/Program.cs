//tamrin 7 amir mahdi hosein njad
List<student> students = new List<student>();
StreamReader sr = new StreamReader(@"D:\Workshop\tamrin7name.txt");

while (!sr.EndOfStream)
{ 
    string line = sr.ReadLine();
    student student = new student();

   student.FIRSTname = line.Split(',')[0];
   student.LASTname = line.Split(',')[1];
   student.pishrafte1 = Convert.ToDouble(line.Split(',')[2]);
   student.tafsir = Convert.ToDouble(line.Split(',')[3]);
   student.riazi = Convert.ToDouble(line.Split(',')[4]);
   student.kargah = Convert.ToDouble(line.Split(',')[5]);
   student.zaban = Convert.ToDouble(line.Split(',')[6]);
   student.pishrafte2 = Convert.ToDouble(line.Split(',')[7]);
   student.sheygaraee = Convert.ToDouble(line.Split(',')[8]);
   student.tarbiatBadani = Convert.ToDouble(line.Split(',')[9]);
   student.sistemAmel = Convert.ToDouble(line.Split(',')[10]);
   student.algoritm = Convert.ToDouble(line.Split(',')[11]);

   students.Add(student);
}

Console.WriteLine("adad moored nazar ra jahat anjam amaliat vard konid");
Console.Write("1-namayesh list-->");
 Console.Write("2-namayesh miangin kol-->");
Console.Write("3-namayesh miangin kol ba zarib-->");
Console.Write("4- namayesh miangin doroos **-->");
Console.Write("5-namayesh miangin doroos *--> ");
Console.Write("6-namayehs adad aval nomarat-->");
Console.Write("7-namyesh ba asas sort-->");
Console.WriteLine("8-namaehsh be soorat grad bandi");
Console.WriteLine();
Console.WriteLine("adad mored nazar ra vared konid");


do
{
    double n = Convert.ToInt64(Console.ReadLine());

    if (n == 1)
    {
        Console.WriteLine(sr.ReadLine());
    }
    else if (n == 2)
    {
        foreach (var student in students)
        {
            Console.WriteLine("name:"+ student.LASTname +  "= " + student.totalAverage());

        }

    }
    else if (n == 3)
    {
        foreach (var student in students)
        {
            Console.WriteLine("name:"+ student.LASTname + "= " + student.average());
        }
    }
    else if (n == 4)
    {
        foreach (var student in students)
        {
            Console.WriteLine("name:" + student.LASTname + "= " + student.average1());

        }
    }
    else if (n == 5)
    {
        foreach (var student in students)
        {
            Console.WriteLine("name:" + student.LASTname + "= " + student.average2());

        }

    }
    else if (n == 7)
    {
        //SortedList sortedList = new SortedList();
        //int grades = 
        //Array.Sort(grades);

    }
    else if (n == 8)

    {

 //foreach (student grade in students)
 //   { string grades;
 //       switch (grade)
 //       {
 //           case student n when (n >= 17 && n <= 20):
 //               Console.WriteLine("Grade {0}: A", grade);
 //               break;
 //           case student n when (n >= 15 && n < 17):
 //               Console.WriteLine("Grade {0}: B", grade);
 //               break;
 //           case student n when (n >= 13 && n < 15):
 //               Console.WriteLine("Grade {0}: C", grade);
 //               break;
 //           case student n when (n >= 10 && n < 13):
 //               Console.WriteLine("Grade {0}: D", grade);
 //               break;
 //           case student n when (n >= 7 && n < 10):
 //               Console.WriteLine("Grade {0}: E", grade);
 //               break;
 //           case student n when (n >= 3 && n < 7):
 //               Console.WriteLine("Grade {0}: F", grade);
 //               break;
 //           case int n when (n >= 0 && n < 3):
 //               Console.WriteLine("Grade {0}: G", grade);
 //               break;
        }
   
   
} while (true);




 public class student
{
    public string FIRSTname { get; set; }
    public string LASTname { get; set; }
    public double pishrafte1 { get; set; }
    public double tafsir { get; set; }
    public double riazi { get; set; }
    public double kargah { get; set; }
    public double zaban { get; set; }
    public double pishrafte2 { get; set; }
    public double sheygaraee { get; set; }
    public double tarbiatBadani { get; set; }
    public double sistemAmel { get; set; }
    public double algoritm { get; set; }

public double totalAverage()
    {

        return (( pishrafte1 ) + ( tafsir ) + ( riazi ) + ( kargah ) + ( zaban ) + ( pishrafte2 ) + ( sheygaraee ) + ( tarbiatBadani ) + ( sistemAmel  ) + (algoritm )) / 10;
    }
    public double average()
    {
        return ( (pishrafte1*3) + (tafsir*1) + ( riazi*2) + ( kargah*1) + ( zaban*2) + ( pishrafte2*3) +  ( sheygaraee*3) + ( tarbiatBadani*1) + ( sistemAmel*3) +(algoritm * 3)    )/22;
    }
    
    public double average1()
    {
        return (pishrafte1 * 3 + pishrafte2 * 3 + sheygaraee * 3) / 9;
    }
    public double average2()
    {
        return ( sistemAmel*3 + algoritm * 3 ) / 6;
    }
}

