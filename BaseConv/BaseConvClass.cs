using System;
using System.Collections.Generic;
using System.Text;

namespace BaseConv
{
    public class BaseConvClass
    {
        //const
        const string INVALID_INPUT_BASE = "Invalid Input Base";
        const string ENTER_VALUES = "Enter Values";
        const string NUMBER_TOO_HIGH = "Number Too High";
        const string INVALID_OUTPUT_BASE = "Invalid Output Base";
        const char A = 'A';
        const char Z = 'Z';
        const char ZERO = '0';
        const char NINE = '9';
        const byte CAP_OFFSET = (int)(A) - 10;  //55;
        const byte NUM_OFFSET = (int)(ZERO);    //48;

        //var
        string inNum;
        uint inBas;              // Largest fully functional base is 36 (10 numbers, 26 letters (uppercase))
        uint outBas;
        //static bool overflow = false;

        // protected
        public bool inHighAlpha(char input)
        {
            return 'A' <= input && input <= 'Z';
        }

        public bool inLowAlpha(char input)
        {
            return 'a' <= input && input <= 'z';
        }

        public bool inNumer(char input)
        {
            return '0' <= input && input <= '9';
        }

        public bool InUpperAlphaOrNumeric(char input)
        {
            return inHighAlpha(input) || inNumer(input);
        }
        
        public char Caps_On(char input)
        { // 'a'..'z' 97..122
            if ( inLowAlpha(input) )   
                return (char)((int)input-32);  // && // $DF(hex) // 223(dec) // 11011111(bin)
            else 
	            return input;
        }

        protected byte Value_Find(char input)
        { // '0'..'9'
            if ( inNumer(input) ) //try return StrToInt(Input); except on EConvertError do return ord(Input)-55; }
                return ((byte)((Int32)(input) - NUM_OFFSET));
            else
                return ((byte)((Int32)(input) - CAP_OFFSET));
        }

        protected char Value_Give(byte input)
        {
            if ( input < 10 )    //try return IntToStr(Input); except on EConvertError do return chr(Input+55); }
                return (char)(input + NUM_OFFSET);//IntToStr(Input)
            else
                return (char)(input + CAP_OFFSET); //StrToInt(Input)
        }

        protected UInt64 Work_Into_Dec(string num, uint from_Bas)
        {
            // if bas == 1)  return length(num) else    // not necessary and debatable as to whether it speeds it up enough in enough of the cases to warant having it
            // if bas == 10)  return StrToInt(num) else // same considerations

            UInt64 Value = 0;

            for (int i = 0 ; i < num.Length ; i++)   //for i = 1 to length(num) do
            {
                Value = Value + Value_Find(num[num.Length - i - 1]) * (UInt64)Math.Pow(from_Bas, i);
            }

            return Value;
        }

        public string Work_From_Dec(UInt64 num, uint to_bas)
        {
            UInt64 temp_num = num;

            string Value = "";

            if (to_bas == 1)  
                for (UInt64 i = 0 ; (i < num) ; ++i)
                {
                    Value += '1'; // if this doesn't work do Value = Value + '1';  // Base 1 (Tally)
                }
            else
                do
                {
                    Value = Value_Give((byte)(temp_num % to_bas)) + Value;
                    temp_num = temp_num / to_bas;
                }
                while (0 < temp_num);

            return Value;
        }

        public string Valid(string input, bool inAlpha) // overload;
        {           
            string working = "";

            if ( (input != "") && (input != "0") )
            {
                bool startingZero = true;

                foreach (char i in input)
                {
                    if ( (i != '0') || ( (! startingZero) && (i == '0') ) )
                    {
                        if (i != '0')
                            startingZero = false;

                        if (inAlpha)
                        {
                            if (InUpperAlphaOrNumeric(Caps_On(i)))
                                working = working + Caps_On(i);
                        }
                        else
                            if (inNumer(i))
                                working = working + i;
                    }
                    
                }
            }
            else
                working = "0";

            return working;
        }

        public bool Valid(string num, uint Bas) // overload;
        {
            byte highest = 0;
            bool working = true;

            if ( Bas <= 0 )
                working = false;
            else
            {
                if ( Bas == 1 )
                {
                    foreach(char i in num)
                      if (!(i == '1'))
                          working = false;
                }
                else
                {
                    if ( working )
                    {
                        foreach (char i in num)
                            if (!InUpperAlphaOrNumeric(Caps_On(i)))
                                working = false;

                        if ( working )
                        {
                            foreach (char i in num)
                                if ( highest < Value_Find(i) )
                                    highest = Value_Find(i);

                            if ( Bas <= highest )
                                working = false;
                        }
                    }
                }
            }
            return working;
        }

        // public
        public string BasCalc(string given_inNum, uint given_inBas, uint given_outBas) // overload;
        {
            string working;

            if ( (given_inNum != "") && (Valid(given_inNum,true) != "") ) 
            {
                inNum = Valid(given_inNum,true);
                inBas = given_inBas;
                outBas = given_outBas;
                
                try
                {
                    if (inNum != "0")
                        if (Valid(inNum, inBas))     // assumed to mean " == true"
                            if (0 < inBas)
                                if (0 < outBas)
                                    if (inBas != outBas)  // do when input and output bases are the same must have validation above in case inputs are inpossible
                                    {
                                        working = Work_From_Dec(Work_Into_Dec(inNum, inBas), outBas);  //if ( overflow )//working = NUMBER_TOO_HIGH; // handled with try catch
                                    }
                                    else working = inNum;
                                else working = INVALID_OUTPUT_BASE;
                            else working = INVALID_INPUT_BASE;
                        else working = INVALID_INPUT_BASE;
                    else working = "0";

                    if ( working == "" )
                        working = NUMBER_TOO_HIGH; // if the input num too high to store (simpler than: valid) , however may be unused
                }
                catch ( System.ArgumentOutOfRangeException ) //eInvalidOP
                { working = NUMBER_TOO_HIGH; }
                catch (System.OverflowException) //eInvalidOP
                { working = NUMBER_TOO_HIGH; }
                catch ( System.FormatException ) // EConvertError
                { working = INVALID_INPUT_BASE; }
                
                  //on eDivByZERO do working = INVALID_OUTPUT_BASE;  // checked in tally (base 1) section of Work_From_Dec
            }
            else 
                working = ENTER_VALUES;

            return working;
        }

        public string BasCalc(string given_inNum, string given_inBas, string given_outBas) // overload;
        {                       //don't bother checking inNum as that will be done by the other BasCalc
            if ( /*(given_inBas != "") && (given_outBas != "") &&*/ (Valid(given_inBas, false) != "") && (Valid(given_outBas, false) != ""))
                return BasCalc(given_inNum, Convert.ToUInt32(Valid(given_inBas, false)), Convert.ToUInt32(Valid(given_outBas, false)));
            else
                return ENTER_VALUES;        // if given_inBas or given_outBas were empty or filled with junk data (empty when validated)
        }

        public string GetInNum()
        {
          return inNum;
        }

        public string GetInBasAsStr()
        {
          return Convert.ToString(inBas);
        }

        public uint GetInBasAsUnt()
        {
          return inBas;
        }

        public string GetOutBasAsStr()
        {
          return Convert.ToString(outBas);
        }

        public uint GetOutBasAsUInt()
        {
          return outBas;
        }
    }
}
