using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaseConv
{
    class TestClass
    {
        const string TL_FILENAME = "Base Conv Test Result";  // TO stands for Test Output
        const string TL_EXTENSION = "txt";

        private static TextWriter tw;

        static string InNum;
        static string InBas;
        static string OutBas;
        //static string OutNum;

        public static void RunTests(string filePath, BaseConvClass bc)
        {
            try
            {
                tw = new StreamWriter(filePath + TL_FILENAME + '.' + TL_EXTENSION);  // create and open the text file for writing to (deletes any previous contents)

                try
                {
                    // Header
                    tw.WriteLine("Testing BaseConv Class at " + Convert.ToString(DateTime.Now) + "\r\nValues InNum, InBas, OutNum");

                    TestMet("BaseConv", "String Inputs");

                    Set("42","10","2");
                    TestDes("Decimal-Binary Conversion");
                    TestRes(bc.BasCalc(InNum, InBas, OutBas), "101010");

                    Set("101010","2","10");
                    TestDes("Decimal-Binary Conversion");
                    TestRes(bc.BasCalc(InNum, InBas, OutBas), "42");

                    Set("FF","16","10");
                    TestDes("Decimal-Hex Conversion");
                    TestRes(bc.BasCalc(InNum, InBas, OutBas), "255");

                    Set("255","10","16");
                    TestDes("Hex-Decimal Conversion");
                    TestRes(bc.BasCalc(InNum, InBas, OutBas), "FF");
                }
                finally  // in case of IO error
                {
                    tw.Close();
                }
            }
            catch (UnauthorizedAccessException)
            {
                // do something very intelligent or instead do the wise thing (i.e. nothing)
            }
        }

        static void Set(string In_Num, string In_Bas, string Out_Bas)
        {
            InNum = In_Num;
            InBas = In_Bas;
            OutBas = Out_Bas;
        }



        static void TestMet(string name)
        {
            tw.WriteLine("\r\nCurrently Testing: {0}", name);  // \r\n as notepad incorrectly displays a simple \n as jibberish rectangular placeholder characters
        }

        static void TestMet(string name, string des)
        {
            tw.WriteLine("\r\nCurrently Testing: {0}\r\n{1}", name, des);
        }

        static void TestDes(string des)
        {
            tw.WriteLine("\t{0} with {1}: ", des, NumForm());
        }

        static void TestRes(string testRes, string expected)  // should refers to the expected TestRes of the method call check
        {
            if (testRes == expected)
                tw.WriteLine("\t\tPass: was {0}", testRes);
            else
                tw.WriteLine("\t\tFail: was {0} should have been {1}", testRes, expected);
        }

        static string NumForm()
        {
            return String.Format("String with {0}, {1}, {2}", InNum, InBas, OutBas);
        }
    }
}
