// See https://aka.ms/new-console-template for more information


using HelloWorld;

class Baseclass
{
    public  virtual void mahindraCar()
    {
        Console.WriteLine("XUV");
    }
    static void Main(string[] args)
    {
        Basic_datatype test = new Basic_datatype();
        //test.method1();
        Loops test2 = new Loops();
        //test2.loop();
        Car mahindraCar = new Car();  // Create an object of the Car Class (this will call the constructor)
                                      //Console.WriteLine(mahindraCar.Model);

        Baseclass Mcar1 = new Baseclass();
        Baseclass Mcar2 = new PolyCar();
        Baseclass Mcar3 = new Polytruck();

        Mcar1.mahindraCar();
        Mcar2.mahindraCar();
        Mcar3.mahindraCar();

        PracticeExamples ex = new PracticeExamples();
        //ex.swapNumber();
        //ex.primeNum();

    }


}


