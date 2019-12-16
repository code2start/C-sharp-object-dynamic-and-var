using System;

namespace Object_dynamic_var_ar
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Object s2 = new Student();
            var s3 = new Student();
            dynamic s4 = new Student();
            // object
            Object o1 = 10;//boxing
            //o1 = o1 + 2;//error
            o1 = "Mohamed Fathy";
            //var
            var v1 = 10; // v1 is int
            v1 = v1 + 2;//no error
                        // v1 = "Mohamed Fathy"; //error

            //dynamic
            dynamic d1 = 10;
            d1 = d1 + 2;
            d1 = "Mohamed";
            d1 = new Student();
            d1.play();
            var v2 = new Student();
            //v2.play();
        }
    }
}
