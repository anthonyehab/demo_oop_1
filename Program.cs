using System;

namespace demo_oop_1
{
    // access modifier allowed inside namespace
    //1- internal (default)
    //2- public





    public enum days
    { 
    saturday,
    sunday,
    monday,
    tuesday,
    wendesday,
    thursday,
    friday
    }
    public enum grades
    { 
    A,B,C,D, E, F
    }
    public enum gender
    { 
    male=1,female=2
    }
  public  enum branches:byte
    { 
    dokki,nasrcity,maadi,alex,smartviilage
    }
    public enum permession:byte
    {
        delete=1,execute=2, read=4,write=8

    }
     class employee
    {
        string name;
        int age;
        gender gender;
        decimal salary;
        permession permession;
    }
    internal class program
    {
        #region exception handling
        //   try 
        //{	        
        //	  static void DoSomeCode()
        //       {
        //           int x, y, z;
        //           x = int.Parse(Console.ReadLine());
        //           y = int.Parse(Console.ReadLine());
        //           z = x / y;

        //           int[] numbers = { 1, 2, 3 };
        //           numbers[10] = 100;
        //       }
        //   }
        //catch( Exception ex  )
        //{
        //       Console.WriteLine(ex.message);
        //} 
        #endregion
        type_A obj = new type_A();
        static void main(string[] args)
        {
            #region enum
            #region ex 01
            //grades x = grades.A;
            //Console.WriteLine(x);
            //if (x == grades.A) 
            //{
            //    Console.WriteLine(":)");
            //}
            //else
            //        Console.WriteLine(":(");


            #endregion
            #region ex 02

            //  Console.WriteLine("please enter your grade");

            //  grades x=(grades)  enum.parse(typeof (grades) , Console.ReadLine());

            #endregion
            #region ex 03
            //gender G1 = gender.female;
            //Console.WriteLine(G1);
            //gender G2 =(gender) 2;
            //Console.WriteLine(G2);
            //string Gender = "male";
            //Enum.TryParse(typeof(gender), Gender, out object result);
            //Console.WriteLine(result);
            //gender x = new gender();//take default value of enum =0


            #endregion
            #region ex 04
            //employee employee = new employee();
            //employee .name = "tony";
            //employee.gender = gender.male;
            //employee.permession = (permession)4;
            #endregion

            #endregion
            #region struct
            //point p1;
            //p1.x = 10;
            //p1.y = 20;
            //Console.WriteLine(p1.x);
            //Console.WriteLine(p1.y);

            //p1 = new point();

            //Console.WriteLine(p1.x);
            //Console.WriteLine(p1.y);

            #endregion





        }

    }
}
