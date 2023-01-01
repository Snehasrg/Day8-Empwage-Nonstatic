using Nonstatic_Line_Comparison;

namespace NonstaticLinecomparison
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problem by Non Static Method");
         
           // Length obj= new Length();
            //obj.calculatelength();

           // CheckEquality obj= new CheckEquality();
            //obj.checkequallines();

            LineComparison obj=new LineComparison();
            obj.checkcomparison();
        }

    }
}
