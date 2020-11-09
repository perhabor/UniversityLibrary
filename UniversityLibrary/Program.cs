using System;

namespace UniversityLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Students studentdetails1 = new Students("Jim Nad", "I4C345", "2020");
                Students studentdetails2 = new Students("Naresh Mash", "I4C343", "2019");
                Students studentdetails3= new Students("Ben Hood", "I4C344", "2018");
                Students studentdetails4 = new Students("Kim Nim", "I4C345", "2017");
                Students studentdetails5 = new Students("Lam Tish", "I4C346", "2016");



            GenericDefaulterList<IDefaulters> library = new GenericDefaulterList<IDefaulters>(6); 


               library.Add(library1);                     
               library.Add(library2);                     
               library.Add(library3);                     
               library.Add(library4);                     
               library.Add(library5);  
             

            library.GetDefaulter();

        }
    }
}
