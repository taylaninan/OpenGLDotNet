using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace Common
{
    ///////////////////////////////////////////////////////////////////////////
    // Conversion functions
    ///////////////////////////////////////////////////////////////////////////
    #region Object: ConvertX...
    public static class ConvertX
    {
        private static string ReplaceSplitters(string prmValue)
        {
            prmValue = prmValue.Replace(';', ',');
            prmValue = prmValue.Replace(':', ',');
            prmValue = prmValue.Replace('.', ',');
            prmValue = prmValue.Replace('-', ',');
            prmValue = prmValue.Replace('_', ',');

            return prmValue;
        }

        private static string PreProcess(string prmValue, string prmPreProcess)
        {
            prmPreProcess = ReplaceSplitters(prmPreProcess);
            string[] strPreProcessValues = prmPreProcess.Split(',');

            for (int Counter = 0; Counter < strPreProcessValues.Length; Counter++)
            {
                string strPreProcessValue = strPreProcessValues[Counter].Trim().ToLower();

                if (!String.IsNullOrEmpty(strPreProcessValue))
                {
                    if (strPreProcessValue == "trim")
                    {
                        prmValue = prmValue.Trim();
                    }

                    if (strPreProcessValue == "lower")
                    {
                        prmValue = prmValue.ToLower();
                    }

                    if (strPreProcessValue == "upper")
                    {
                        prmValue = prmValue.ToUpper();
                    }

                    if (strPreProcessValue == "space")
                    {
                        prmValue = prmValue.Replace(" ", "");
                    }

                    if (strPreProcessValue == "whitespace")
                    {
                        while (prmValue.Contains("  "))
                        {
                            prmValue = prmValue.Replace("  ", " ");
                        }
                    }

                    if (strPreProcessValue == "striptags")
                    {
                        prmValue = HtmlX.StripTags(prmValue);
                    }
                }
            }

            return prmValue;
        }

        public static string ToString(string prmValue, uint prmLength, string prmValidValues, string prmPreProcess, string prmDefault)
        {
            // Pre Process
            prmValue = PreProcess(prmValue, prmPreProcess);

            // Check Length
            if (prmLength != 0)
            {
                if (prmValue.Length != prmLength)
                {
                    prmValue = prmDefault;
                }
            }

            // Check Valid Values
            bool ValidFound = false;
            int CheckCount = 0;

            prmValidValues = ReplaceSplitters(prmValidValues);
            string[] strValidValues = prmValidValues.Split(',');

            foreach (string strValidValue in strValidValues)
            {
                if (!String.IsNullOrEmpty(strValidValue))
                {
                    CheckCount++;

                    if (strValidValue == prmValue)
                    {
                        ValidFound = true;
                    }
                }
            }

            if (CheckCount > 0 && !ValidFound)
            {
                prmValue = prmDefault;
            }

            // Return result;
            return prmValue;
        }

        public static DateX ToDateX(string prmValue, uint prmLength, string prmValidValues, string prmPreProcess, DateX prmDefault)
        {
            DateX Result;

            // Pre Process
            prmValue = PreProcess(prmValue, prmPreProcess);

            // Check Length
            if (prmLength != 0)
            {
                if (prmValue.Length != prmLength)
                {
                    prmValue = prmDefault.ToString();
                }
            }

            // Try to Parse
            bool Converted = DateX.TryParse(prmValue, out Result);
            if (!Converted)
            {
                Result = prmDefault;
            }

            // Check for valid values
            bool ValidFound = false;
            int CheckCount = 0;

            prmValidValues = ReplaceSplitters(prmValidValues);
            string[] strValidValues = prmValidValues.Split(',');

            foreach (string strValidValue in strValidValues)
            {
                if (!String.IsNullOrEmpty(strValidValue))
                {
                    CheckCount++;

                    if (strValidValue == Result.ToString())
                    {
                        ValidFound = true;
                    }
                }
            }

            if (CheckCount > 0 && !ValidFound)
            {
                Result = prmDefault;
            }

            return Result;
        }

        public static byte ToByte(string prmValue, uint prmLength, string prmValidValues, string prmPreProcess, byte prmDefault)
        {
            byte Result;

            // Pre Process
            prmValue = PreProcess(prmValue, prmPreProcess);

            // Check Length
            if (prmLength != 0)
            {
                if (prmValue.Length != prmLength)
                {
                    prmValue = prmDefault.ToString();
                }
            }

            // Try to Parse
            bool Converted = Byte.TryParse(prmValue, out Result);
            if (!Converted)
            {
                Result = prmDefault;
            }

            // Check Valid Values
            byte ValidValue;
            bool ValidFound = false;
            int CheckCount = 0;

            prmValidValues = ReplaceSplitters(prmValidValues);
            string[] strValidValues = prmValidValues.Split(',');

            foreach (string strValidValue in strValidValues)
            {
                if (!String.IsNullOrEmpty(strValidValue))
                {
                    Converted = Byte.TryParse(strValidValue, out ValidValue);
                    if (Converted)
                    {
                        CheckCount++;

                        if (ValidValue == Result)
                        {
                            ValidFound = true;
                        }
                    }
                }
            }

            if (CheckCount > 0 && !ValidFound)
            {
                Result = prmDefault;
            }

            // Return result;
            return Result;
        }

        public static sbyte ToSByte(string prmValue, uint prmLength, string prmValidValues, string prmPreProcess, sbyte prmDefault)
        {
            sbyte Result;

            // Pre Process
            prmValue = PreProcess(prmValue, prmPreProcess);

            // Check Length
            if (prmLength != 0)
            {
                if (prmValue.Length != prmLength)
                {
                    prmValue = prmDefault.ToString();
                }
            }

            // Try to Parse
            bool Converted = SByte.TryParse(prmValue, out Result);
            if (!Converted)
            {
                Result = prmDefault;
            }

            // Check Valid Values
            sbyte ValidValue;
            bool ValidFound = false;
            int CheckCount = 0;

            prmValidValues = ReplaceSplitters(prmValidValues);
            string[] strValidValues = prmValidValues.Split(',');

            foreach (string strValidValue in strValidValues)
            {
                if (!String.IsNullOrEmpty(strValidValue))
                {
                    Converted = SByte.TryParse(strValidValue, out ValidValue);
                    if (Converted)
                    {
                        CheckCount++;

                        if (ValidValue == Result)
                        {
                            ValidFound = true;
                        }
                    }
                }
            }

            if (CheckCount > 0 && !ValidFound)
            {
                Result = prmDefault;
            }

            // Return result;
            return Result;
        }

        public static ushort ToUShort(string prmValue, uint prmLength, string prmValidValues, string prmPreProcess, ushort prmDefault)
        {
            ushort Result;

            // Pre Process
            prmValue = PreProcess(prmValue, prmPreProcess);

            // Check Length
            if (prmLength != 0)
            {
                if (prmValue.Length != prmLength)
                {
                    prmValue = prmDefault.ToString();
                }
            }

            // Try to Parse
            bool Converted = ushort.TryParse(prmValue, out Result);
            if (!Converted)
            {
                Result = prmDefault;
            }

            // Check Valid Values
            ushort ValidValue;
            bool ValidFound = false;
            int CheckCount = 0;

            prmValidValues = ReplaceSplitters(prmValidValues);
            string[] strValidValues = prmValidValues.Split(',');

            foreach (string strValidValue in strValidValues)
            {
                if (!String.IsNullOrEmpty(strValidValue))
                {
                    Converted = ushort.TryParse(strValidValue, out ValidValue);
                    if (Converted)
                    {
                        CheckCount++;

                        if (ValidValue == Result)
                        {
                            ValidFound = true;
                        }
                    }
                }
            }

            if (CheckCount > 0 && !ValidFound)
            {
                Result = prmDefault;
            }

            // Return result;
            return Result;
        }

        public static short ToShort(string prmValue, uint prmLength, string prmValidValues, string prmPreProcess, short prmDefault)
        {
            short Result;

            // Pre Process
            prmValue = PreProcess(prmValue, prmPreProcess);

            // Check Length
            if (prmLength != 0)
            {
                if (prmValue.Length != prmLength)
                {
                    prmValue = prmDefault.ToString();
                }
            }

            // Try to Parse
            bool Converted = short.TryParse(prmValue, out Result);
            if (!Converted)
            {
                Result = prmDefault;
            }

            // Check Valid Values
            short ValidValue;
            bool ValidFound = false;
            int CheckCount = 0;

            prmValidValues = ReplaceSplitters(prmValidValues);
            string[] strValidValues = prmValidValues.Split(',');

            foreach (string strValidValue in strValidValues)
            {
                if (!String.IsNullOrEmpty(strValidValue))
                {
                    Converted = short.TryParse(strValidValue, out ValidValue);
                    if (Converted)
                    {
                        CheckCount++;

                        if (ValidValue == Result)
                        {
                            ValidFound = true;
                        }
                    }
                }
            }

            if (CheckCount > 0 && !ValidFound)
            {
                Result = prmDefault;
            }

            // Return result;
            return Result;
        }

        public static uint ToUInt(string prmValue, uint prmLength, string prmValidValues, string prmPreProcess, uint prmDefault)
        {
            uint Result;

            // Pre Process
            prmValue = PreProcess(prmValue, prmPreProcess);

            // Check Length
            if (prmLength != 0)
            {
                if (prmValue.Length != prmLength)
                {
                    prmValue = prmDefault.ToString();
                }
            }

            // Try to Parse
            bool Converted = uint.TryParse(prmValue, out Result);
            if (!Converted)
            {
                Result = prmDefault;
            }

            // Check Valid Values
            uint ValidValue;
            bool ValidFound = false;
            int CheckCount = 0;

            prmValidValues = ReplaceSplitters(prmValidValues);
            string[] strValidValues = prmValidValues.Split(',');

            foreach (string strValidValue in strValidValues)
            {
                if (!String.IsNullOrEmpty(strValidValue))
                {
                    Converted = uint.TryParse(strValidValue, out ValidValue);
                    if (Converted)
                    {
                        CheckCount++;

                        if (ValidValue == Result)
                        {
                            ValidFound = true;
                        }
                    }
                }
            }

            if (CheckCount > 0 && !ValidFound)
            {
                Result = prmDefault;
            }

            // Return result;
            return Result;
        }

        public static int ToInt(string prmValue, uint prmLength, string prmValidValues, string prmPreProcess, int prmDefault)
        {
            int Result;

            // Pre Process
            prmValue = PreProcess(prmValue, prmPreProcess);

            // Check Length
            if (prmLength != 0)
            {
                if (prmValue.Length != prmLength)
                {
                    prmValue = prmDefault.ToString();
                }
            }

            // Try to Parse
            bool Converted = int.TryParse(prmValue, out Result);
            if (!Converted)
            {
                Result = prmDefault;
            }

            // Check Valid Values
            int ValidValue;
            bool ValidFound = false;
            int CheckCount = 0;

            prmValidValues = ReplaceSplitters(prmValidValues);
            string[] strValidValues = prmValidValues.Split(',');

            foreach (string strValidValue in strValidValues)
            {
                if (!String.IsNullOrEmpty(strValidValue))
                {
                    Converted = int.TryParse(strValidValue, out ValidValue);
                    if (Converted)
                    {
                        CheckCount++;

                        if (ValidValue == Result)
                        {
                            ValidFound = true;
                        }
                    }
                }
            }

            if (CheckCount > 0 && !ValidFound)
            {
                Result = prmDefault;
            }

            // Return result;
            return Result;
        }

        public static ulong ToULong(string prmValue, uint prmLength, string prmValidValues, string prmPreProcess, ulong prmDefault)
        {
            ulong Result;

            // Pre Process
            prmValue = PreProcess(prmValue, prmPreProcess);

            // Check Length
            if (prmLength != 0)
            {
                if (prmValue.Length != prmLength)
                {
                    prmValue = prmDefault.ToString();
                }
            }

            // Try to Parse
            bool Converted = ulong.TryParse(prmValue, out Result);
            if (!Converted)
            {
                Result = prmDefault;
            }

            // Check Valid Values
            ulong ValidValue;
            bool ValidFound = false;
            int CheckCount = 0;

            prmValidValues = ReplaceSplitters(prmValidValues);
            string[] strValidValues = prmValidValues.Split(',');

            foreach (string strValidValue in strValidValues)
            {
                if (!String.IsNullOrEmpty(strValidValue))
                {
                    Converted = ulong.TryParse(strValidValue, out ValidValue);
                    if (Converted)
                    {
                        CheckCount++;

                        if (ValidValue == Result)
                        {
                            ValidFound = true;
                        }
                    }
                }
            }

            if (CheckCount > 0 && !ValidFound)
            {
                Result = prmDefault;
            }

            // Return result;
            return Result;
        }

        public static long ToLong(string prmValue, uint prmLength, string prmValidValues, string prmPreProcess, long prmDefault)
        {
            long Result;

            // Pre Process
            prmValue = PreProcess(prmValue, prmPreProcess);

            // Check Length
            if (prmLength != 0)
            {
                if (prmValue.Length != prmLength)
                {
                    prmValue = prmDefault.ToString();
                }
            }

            // Try to Parse
            bool Converted = long.TryParse(prmValue, out Result);
            if (!Converted)
            {
                Result = prmDefault;
            }

            // Check Valid Values
            long ValidValue;
            bool ValidFound = false;
            int CheckCount = 0;

            prmValidValues = ReplaceSplitters(prmValidValues);
            string[] strValidValues = prmValidValues.Split(',');

            foreach (string strValidValue in strValidValues)
            {
                if (!String.IsNullOrEmpty(strValidValue))
                {
                    Converted = long.TryParse(strValidValue, out ValidValue);
                    if (Converted)
                    {
                        CheckCount++;

                        if (ValidValue == Result)
                        {
                            ValidFound = true;
                        }
                    }
                }
            }

            if (CheckCount > 0 && !ValidFound)
            {
                Result = prmDefault;
            }

            // Return result;
            return Result;
        }

        public static float ToFloat(string prmValue, uint prmLength, string prmValidValues, string prmPreProcess, float prmDefault)
        {
            float Result;

            // Pre Process
            prmValue = PreProcess(prmValue, prmPreProcess);

            // Check Length
            if (prmLength != 0)
            {
                if (prmValue.Length != prmLength)
                {
                    prmValue = prmDefault.ToString();
                }
            }

            // Try to Parse
            bool Converted = float.TryParse(prmValue, out Result);
            if (!Converted)
            {
                Result = prmDefault;
            }

            // Check Valid Values
            float ValidValue;
            bool ValidFound = false;
            int CheckCount = 0;

            prmValidValues = ReplaceSplitters(prmValidValues);
            string[] strValidValues = prmValidValues.Split(',');

            foreach (string strValidValue in strValidValues)
            {
                if (!String.IsNullOrEmpty(strValidValue))
                {
                    Converted = float.TryParse(strValidValue, out ValidValue);
                    if (Converted)
                    {
                        CheckCount++;

                        if (ValidValue == Result)
                        {
                            ValidFound = true;
                        }
                    }
                }
            }

            if (CheckCount > 0 && !ValidFound)
            {
                Result = prmDefault;
            }

            // Return result;
            return Result;
        }

        public static double ToDouble(string prmValue, uint prmLength, string prmValidValues, string prmPreProcess, double prmDefault)
        {
            double Result;

            // Pre Process
            prmValue = PreProcess(prmValue, prmPreProcess);

            // Check Length
            if (prmLength != 0)
            {
                if (prmValue.Length != prmLength)
                {
                    prmValue = prmDefault.ToString();
                }
            }

            // Try to Parse
            bool Converted = double.TryParse(prmValue, out Result);
            if (!Converted)
            {
                Result = prmDefault;
            }

            // Check Valid Values
            double ValidValue;
            bool ValidFound = false;
            int CheckCount = 0;

            prmValidValues = ReplaceSplitters(prmValidValues);
            string[] strValidValues = prmValidValues.Split(',');

            foreach (string strValidValue in strValidValues)
            {
                if (!String.IsNullOrEmpty(strValidValue))
                {
                    Converted = double.TryParse(strValidValue, out ValidValue);
                    if (Converted)
                    {
                        CheckCount++;

                        if (ValidValue == Result)
                        {
                            ValidFound = true;
                        }
                    }
                }
            }

            if (CheckCount > 0 && !ValidFound)
            {
                Result = prmDefault;
            }

            // Return result;
            return Result;
        }

        public static decimal ToDecimal(string prmValue, uint prmLength, string prmValidValues, string prmPreProcess, decimal prmDefault)
        {
            decimal Result;

            // Pre Process
            prmValue = PreProcess(prmValue, prmPreProcess);

            // Check Length
            if (prmLength != 0)
            {
                if (prmValue.Length != prmLength)
                {
                    prmValue = prmDefault.ToString();
                }
            }

            // Try to Parse
            bool converted = decimal.TryParse(prmValue, out Result);
            if (!converted)
            {
                Result = prmDefault;
            }

            // Check Valid Values
            decimal ValidValue;
            bool ValidFound = false;
            int CheckCount = 0;

            prmValidValues = ReplaceSplitters(prmValidValues);
            string[] strValidValues = prmValidValues.Split(',');

            foreach (string strValidValue in strValidValues)
            {
                if (!String.IsNullOrEmpty(strValidValue))
                {
                    converted = decimal.TryParse(strValidValue, out ValidValue);
                    if (converted)
                    {
                        CheckCount++;

                        if (ValidValue == Result)
                        {
                            ValidFound = true;
                        }
                    }
                }
            }

            if (CheckCount > 0 && !ValidFound)
            {
                Result = prmDefault;
            }

            // Return result;
            return Result;
        }
    }
    #endregion

    ///////////////////////////////////////////////////////////////////////////
    // Value functions
    ///////////////////////////////////////////////////////////////////////////
    #region Object: ValueX...
    public static class ValueX
    {
        ///////////////////////////////////////////////////////////////////////////
        // "Bit" constants
        ///////////////////////////////////////////////////////////////////////////
        #region Bit constants...
        public enum Bits : uint
        {
            Bit00 = 0x00000001U,
            Bit01 = 0x00000002U,
            Bit02 = 0x00000004U,
            Bit03 = 0x00000008U,
            Bit04 = 0x00000010U,
            Bit05 = 0x00000020U,
            Bit06 = 0x00000040U,
            Bit07 = 0x00000080U,
            Bit08 = 0x00000100U,
            Bit09 = 0x00000200U,
            Bit10 = 0x00000400U,
            Bit11 = 0x00000800U,
            Bit12 = 0x00001000U,
            Bit13 = 0x00002000U,
            Bit14 = 0x00004000U,
            Bit15 = 0x00008000U,
            Bit16 = 0x00010000U,
            Bit17 = 0x00020000U,
            Bit18 = 0x00040000U,
            Bit19 = 0x00080000U,
            Bit20 = 0x00100000U,
            Bit21 = 0x00200000U,
            Bit22 = 0x00400000U,
            Bit23 = 0x00800000U,
            Bit24 = 0x01000000U,
            Bit25 = 0x02000000U,
            Bit26 = 0x04000000U,
            Bit27 = 0x08000000U,
            Bit28 = 0x10000000U,
            Bit29 = 0x20000000U,
            Bit30 = 0x40000000U,
            Bit31 = 0x80000000U
        }
        #endregion
    }
    #endregion

    ///////////////////////////////////////////////////////////////////////////
    // String functions
    ///////////////////////////////////////////////////////////////////////////
    #region Object: StringX...
    public class StringX
    {
        public string String = null;

        public StringX(string prmString)
        {
            this.String = prmString;
        }

        public override string ToString()
        {
            return this.String;
        }

        public static bool operator ==(StringX lhs, string rhs)
        {
            bool Result = false;

            if (Object.ReferenceEquals(lhs, rhs))
            {
                Result = true;
            }

            if (Object.ReferenceEquals(lhs, null) && Object.ReferenceEquals(rhs, null))
            {
                Result = true;
            }

            if (!Object.ReferenceEquals(lhs, null) && !Object.ReferenceEquals(rhs, null))
            {
                if (lhs.String == rhs || Object.ReferenceEquals(lhs.String, rhs))
                {
                    Result = true;
                }
            }

            return Result;
        }

        public static bool operator !=(StringX lhs, string rhs)
        {
            return !(lhs == rhs);
        }

        public static bool operator ==(string lhs, StringX rhs)
        {
            bool Result = false;

            if (Object.ReferenceEquals(lhs, rhs))
            {
                Result = true;
            }

            if (Object.ReferenceEquals(lhs, null) && Object.ReferenceEquals(rhs, null))
            {
                Result = true;
            }

            if (!Object.ReferenceEquals(lhs, null) && !Object.ReferenceEquals(rhs, null))
            {
                if (lhs == rhs.String || Object.ReferenceEquals(lhs, rhs.String))
                {
                    Result = true;
                }
            }

            return Result;
        }

        public static bool operator !=(string lhs, StringX rhs)
        {
            return !(lhs == rhs);
        }

        public static bool operator ==(StringX lhs, StringX rhs)
        {
            bool Result = false;

            if (Object.ReferenceEquals(lhs, rhs))
            {
                Result = true;
            }

            if (Object.ReferenceEquals(lhs, null) && Object.ReferenceEquals(rhs, null))
            {
                Result = true;
            }

            if (!Object.ReferenceEquals(lhs, null) && !Object.ReferenceEquals(rhs, null))
            {
                if (lhs.String == rhs.String)
                {
                    Result = true;
                }
            }

            return Result;
        }

        public static bool operator !=(StringX lhs, StringX rhs)
        {
            return !(lhs == rhs);
        }

        public static implicit operator string(StringX value)
        {
            if (Object.ReferenceEquals(value, null))
            {
                return null;
            }
            else
            {
                return value.String;
            }
        }

        public static implicit operator StringX(string value)
        {
            return new StringX(value);
        }

        public override bool Equals(object obj)
        {
            bool Result = false;

            // First, compare StringX to StringX
            if (this.GetType() == obj.GetType() && this is StringX && obj is StringX)
            {
                // Check whether we have same instance
                if (Object.ReferenceEquals(this, obj))
                {
                    Result = true;
                }

                // Check whether both objects are null
                if (Object.ReferenceEquals(this, null) && Object.ReferenceEquals(obj, null))
                {
                    Result = true;
                }

                // Check whether the "contents" are the same
                if (!Object.ReferenceEquals(this, null) && !Object.ReferenceEquals(obj, null))
                {
                    if (this.String == ((StringX)obj).String)
                    {
                        Result = true;
                    }
                }
            }

            // After that, compare StringX to String
            if (this.GetType() != obj.GetType() && this is StringX && obj is String)
            {
                // Check whether we have same instance
                if (Object.ReferenceEquals(this, obj))
                {
                    Result = true;
                }

                // Check whether both objects are null
                if (Object.ReferenceEquals(this, null) && Object.ReferenceEquals(obj, null))
                {
                    Result = true;
                }

                // Check whether the "contents" are the same
                if (!Object.ReferenceEquals(this, null) && !Object.ReferenceEquals(obj, null))
                {
                    if (this.String == ((String)obj))
                    {
                        Result = true;
                    }
                }
            }

            return Result;
        }

        public override int GetHashCode()
        {
            return this.String.GetHashCode();
        }

        public StringX ToLower(string CultureName = "tr")
        {
            System.Globalization.CultureInfo _CultureInfo = null;

            CultureName = CultureName.ToLower();

            switch (CultureName)
            {
                case "en":
                case "eng":
                    _CultureInfo = new System.Globalization.CultureInfo("en-US");
                    return new StringX(this.String.ToLower(_CultureInfo));

                case "tr":
                case "tur":
                    _CultureInfo = new System.Globalization.CultureInfo("tr-TR");
                    return new StringX(this.String.ToLower(_CultureInfo));

                default:
                    _CultureInfo = new System.Globalization.CultureInfo("tr-TR");
                    return new StringX(this.String.ToLower(_CultureInfo));
            }
        }

        public StringX ToUpper(string CultureName = "tr")
        {
            System.Globalization.CultureInfo _CultureInfo = null;

            CultureName = CultureName.ToLower();

            switch (CultureName)
            {
                case "en":
                case "eng":
                    _CultureInfo = new System.Globalization.CultureInfo("en-US");
                    return new StringX(this.String.ToUpper(_CultureInfo));

                case "tr":
                case "tur":
                    _CultureInfo = new System.Globalization.CultureInfo("tr-TR");
                    return new StringX(this.String.ToUpper(_CultureInfo));

                default:
                    _CultureInfo = new System.Globalization.CultureInfo("tr-TR");
                    return new StringX(this.String.ToUpper(_CultureInfo));
            }
        }

        public StringX Replace(char find, char replace)
        {
            return new StringX(this.String.Replace(find, replace));
        }

        public StringX Replace(string find, string replace)
        {
            return new StringX(this.String.Replace(find, replace));
        }

        public StringX Trim()
        {
            return new StringX(this.String.Trim());
        }

        public StringX TrimLeft()
        {
            return new StringX(this.String.TrimStart());
        }

        public StringX TrimRight()
        {
            return new StringX(this.String.TrimEnd());
        }

        public bool ToBoolean()
        {
            if (this.String == "1" || this.String == "on" || this.String == "true" || this.String == "yes" || this.String == "ok")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public StringX Quote()
        {
            return new StringX("'" + this.String.Replace("'", "''") + "'");
        }

        public StringX SqlQuote()
        {
            if (String.IsNullOrEmpty(this.String))
            {
                return new StringX("null");
            }
            else
            {
                return this.Quote();
            }
        }

        public int Length()
        {
            return this.String.Length;
        }

        public StringX SubString(int StartIndex, int Length)
        {
            return new StringX(this.String.Substring(StartIndex, Length));
        }

        public StringX SubString(int StartIndex)
        {
            return new StringX(this.String.Substring(StartIndex));
        }

        public StringX[] Split(char[] delimiter)
        {
            string[] splitted = this.String.Split(delimiter, StringSplitOptions.None);

            StringX[] result = new StringX[splitted.Length];

            for (uint counter = 0; counter < result.Length; counter++)
            {
                result[counter] = new StringX(splitted[counter]);
            }

            return result;
        }

        public StringX[] Split(string[] delimiter)
        {
            string[] splitted = this.String.Split(delimiter, StringSplitOptions.None);

            StringX[] result = new StringX[splitted.Length];

            for (uint counter = 0; counter < result.Length; counter++)
            {
                result[counter] = new StringX(splitted[counter]);
            }

            return result;
        }

        public StringX Join(char glue, string[] pieces)
        {
            string result = String.Empty;

            for (uint counter = 0; counter < pieces.Length; counter++)
            {
                if (!String.IsNullOrEmpty(pieces[counter]))
                {
                    if (String.IsNullOrEmpty(result))
                    {
                        result = pieces[counter];
                    }
                    else
                    {
                        result += glue + pieces[counter];
                    }
                }
            }

            return new StringX(result);
        }

        public StringX Join(string glue, string[] pieces)
        {
            string result = String.Empty;

            for (uint counter = 0; counter < pieces.Length; counter++)
            {
                if (!String.IsNullOrEmpty(pieces[counter]))
                {
                    if (String.IsNullOrEmpty(result))
                    {
                        result = pieces[counter];
                    }
                    else
                    {
                        result += glue + pieces[counter];
                    }
                }
            }

            return new StringX(result);
        }

        public StringX Empty()
        {
            return new StringX(String.Empty);
        }

        public bool IsEmpty()
        {
            return (this.String == String.Empty || this.String == "" || this.String == null);
        }

        public bool IsNullOrEmpty()
        {
            return String.IsNullOrEmpty(this.String);
        }

        public bool IsNullOrWhiteSpace()
        {
            string value = this.String.Trim();

            return String.IsNullOrEmpty(value);
        }

        public bool Contains(string SubString)
        {
            return this.String.Contains(SubString);
        }

        public int ScanLeft(char SubChar)
        {
            return this.String.IndexOf(SubChar);
        }

        public int ScanLeft(string SubString)
        {
            return this.String.IndexOf(SubString);
        }

        public int ScanRight(char SubChar)
        {
            return this.String.LastIndexOf(SubChar);
        }

        public int ScanRight(string SubString)
        {
            return this.String.LastIndexOf(SubString);
        }

        public char[] ToCharArray()
        {
            return this.String.ToCharArray();
        }

        public bool IsValidEmail()
        {
            // Shortest possible email address: a@a.co
            if (this.IsNullOrWhiteSpace() || this.Length() < 6)
            {
                return false;
            }
            else
            {
                string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{2,4})(\]?)$";
                Regex re = new Regex(strRegex);
                return re.IsMatch(this.String);
            }
        }

        public bool IsValidUrl()
        {
            string pattern = @"^(http|https|ftp)\://[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,3}(:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&amp;%\$#\=~])*[^\.\,\)\(\s]$";
            Regex reg = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            return reg.IsMatch(this.String);
        }

        protected bool IsValidDecimal(char Decimal)
        {
            return (Decimal == '0' || Decimal == '1' || Decimal == '2' || Decimal == '3' || Decimal == '4' ||
                    Decimal == '5' || Decimal == '6' || Decimal == '7' || Decimal == '8' || Decimal == '9');
        }

        public bool IsValidDecimal()
        {
            bool result = true;

            char[] prmChars = this.String.ToCharArray();

            for (uint counter = 0; counter < prmChars.Length; counter++)
            {
                if (!IsValidDecimal(prmChars[counter]))
                {
                    result = false;
                }
            }

            return result;
        }

        protected bool IsValidHex(char Hex)
        {
            return (Hex == '0' || Hex == '1' || Hex == '2' || Hex == '3' || Hex == '4' || Hex == '5' || Hex == '6' ||
                    Hex == '7' || Hex == '8' || Hex == '9' || Hex == 'A' || Hex == 'B' || Hex == 'C' || Hex == 'D' ||
                    Hex == 'E' || Hex == 'F' || Hex == 'a' || Hex == 'b' || Hex == 'c' || Hex == 'd' || Hex == 'e' ||
                    Hex == 'f');
        }

        public bool IsValidHex()
        {
            bool result = true;

            char[] prmChars = this.String.ToUpper().ToCharArray();

            for (uint counter = 0; counter < prmChars.Length; counter++)
            {
                if (!IsValidHex(prmChars[counter]))
                {
                    result = false;
                }
            }

            return result;
        }

        public bool IsValidGuid()
        {
            bool result = false;

            if (this.Length() == 32)
            {
                result = this.IsValidHex();
            }

            if (this.Length() == 36)
            {
                StringX guidShort = this.Replace("-", "");

                result = (this.Length() == 36 && guidShort.Length() == 32 && guidShort.IsValidHex() &&
                          this.SubString(8, 1) == "-" && this.SubString(13, 1) == "-" &&
                          this.SubString(18, 1) == "-" && this.SubString(23, 1) == "-");
            }

            return result;
        }

        public bool IsValidIPv4()
        {
            bool result = true;
            byte IPv4Byte = 0;

            string[] IPv4Addresses = this.String.Split('.');

            if (IPv4Addresses.Length == 4)
            {
                for (int counter = 0; counter < IPv4Addresses.Length; counter++)
                {
                    IPv4Addresses[counter] = IPv4Addresses[counter].PadLeft(3, '0');

                    if (IPv4Addresses[counter].Length == 3)
                    {
                        if (!Byte.TryParse(IPv4Addresses[counter], out IPv4Byte))
                        {
                            result = false;
                        }
                    }
                    else
                    {
                        result = false;
                    }
                }
            }
            else
            {
                result = false;
            }

            return result;
        }

        public string ToMD5()
        {
            MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider();

            byte[] ByteArray = System.Text.Encoding.Unicode.GetBytes(this.String);
            ByteArray = MD5.ComputeHash(ByteArray);

            StringBuilder sb = new StringBuilder();

            foreach (byte Byte in ByteArray)
            {
                sb.Append(Byte.ToString("x2").ToLower());
            }

            return sb.ToString();
        }
    }
    #endregion

    ///////////////////////////////////////////////////////////////////////////
    // Date & Time functions
    ///////////////////////////////////////////////////////////////////////////
    #region Object: DateX...
    public class DateX
    {
        protected const short SQLYearMin = 1900;

        protected sbyte _day = -1;
        protected sbyte _month = -1;
        protected short _year = -1;
        protected sbyte _hour = -1;
        protected sbyte _minute = -1;
        protected sbyte _second = -1;
        protected short _millisecond = -1;

        protected void CheckDateLimits(string CheckType)
        {
            CheckType = CheckType.ToLower();

            if (CheckType == "short" || CheckType == "long")
            {
                if (CheckType == "short")
                {
                    if (this._day < 1 || this._day > 31)
                    {
                        this._day = -1;
                    }

                    if (this._month < 1 || this._month > 12)
                    {
                        this._month = -1;
                    }

                    if (this._year < SQLYearMin)
                    {
                        this._year = -1;
                    }

                    if (this._day == -1 || this._month == -1 || this._year == -1)
                    {
                        this._day = -1;
                        this._month = -1;
                        this._year = -1;
                    }
                }

                if (CheckType == "long")
                {
                    if (this._day < 1 || this._day > 31)
                    {
                        this._day = -1;
                    }

                    if (this._month < 1 || this._month > 12)
                    {
                        this._month = -1;
                    }

                    if (this._year < SQLYearMin)
                    {
                        this._year = -1;
                    }

                    if (this._hour < 0 || this._hour > 23)
                    {
                        this._hour = -1;
                    }

                    if (this._minute < 0 || this._minute > 59)
                    {
                        this._minute = -1;
                    }

                    if (this._second < 0 || this._second > 59)
                    {
                        this._second = -1;
                    }

                    if (this._millisecond < 0 || this._millisecond > 999)
                    {
                        this._millisecond = -1;
                    }

                    if (this._day == -1 || this._month == -1 || this._year == -1 || this._hour == -1 || this._minute == -1 || this._second == -1 || this._millisecond == -1)
                    {
                        this._day = -1;
                        this._month = -1;
                        this._year = -1;
                        this._hour = -1;
                        this._minute = -1;
                        this._second = -1;
                        this._millisecond = -1;
                    }
                }
            }
            else
            {
                this._day = -1;
                this._month = -1;
                this._year = -1;
                this._hour = -1;
                this._minute = -1;
                this._second = -1;
                this._millisecond = -1;
            }
        }

        public DateX()
        {
            this._day = -1;
            this._month = -1;
            this._year = -1;
            this._hour = -1;
            this._minute = -1;
            this._second = -1;
            this._millisecond = -1;
        }

        public DateX(sbyte Day, sbyte Month, short Year)
        {
            this._day = Day;
            this._month = Month;
            this._year = Year;

            this.CheckDateLimits("short");
        }

        public DateX(sbyte Day, sbyte Month, short Year, sbyte Hour, sbyte Minute, sbyte Second, short MilliSecond)
        {
            this._day = Day;
            this._month = Month;
            this._year = Year;
            this._hour = Hour;
            this._minute = Minute;
            this._second = Second;
            this._millisecond = MilliSecond;

            this.CheckDateLimits("long");
        }

        public DateX(DateTime prmDateTime)
        {
            this._day = (sbyte)prmDateTime.Day;
            this._month = (sbyte)prmDateTime.Month;
            this._year = (short)prmDateTime.Year;
            this._hour = (sbyte)prmDateTime.Hour;
            this._minute = (sbyte)prmDateTime.Minute;
            this._second = (sbyte)prmDateTime.Second;
            this._millisecond = (short)prmDateTime.Millisecond;

            this.CheckDateLimits("long");
        }

        public DateX(string SqlDate)
        {
            bool converted = false;
            DateX result = null;

            converted = DateX.TryParse(SqlDate, out result);

            if (converted)
            {
                this._year = result._year;
                this._month = result._month;
                this._day = result._day;
                this._hour = result._hour;
                this._minute = result._minute;
                this._second = result._second;
                this._millisecond = result._millisecond;
            }
            else
            {
                this._year = -1;
                this._month = -1;
                this._day = -1;
                this._hour = -1;
                this._minute = -1;
                this._second = -1;
                this._millisecond = -1;
            }

            this.CheckDateLimits("long");
        }

        public static bool TryParse(string SqlDate, out DateX result)
        {
            result = new DateX();
            bool SqlDateFormatFound = false;

            if (SqlDate == null)
            {
                result._year = -1;
                result._month = -1;
                result._day = -1;
                result._hour = -1;
                result._minute = -1;
                result._second = -1;
                result._millisecond = -1;

                return true;
            }
            else
            {
                //                  01234567890123456789012
                // SQL Date Format: 20130706                Length: 08 - ok
                if (SqlDate.Length == 8)
                {
                    SqlDateFormatFound = true;

                    result._year = ConvertX.ToShort(SqlDate.Substring(0, 4), 4, "", "trim,striptags", -1);
                    result._month = ConvertX.ToSByte(SqlDate.Substring(4, 2), 2, "", "trim,striptags", -1);
                    result._day = ConvertX.ToSByte(SqlDate.Substring(6, 2), 2, "", "trim,striptags", -1);
                    result._hour = 0;
                    result._minute = 0;
                    result._second = 0;
                    result._millisecond = 0;
                }

                //                  01234567890123456789012
                // SQL Date Format: 2013-07-06              Length: 10 - ok
                if (SqlDate.Length == 10)
                {
                    SqlDateFormatFound = true;

                    result._year = ConvertX.ToShort(SqlDate.Substring(0, 4), 4, "", "trim,striptags", -1);
                    result._month = ConvertX.ToSByte(SqlDate.Substring(5, 2), 2, "", "trim,striptags", -1);
                    result._day = ConvertX.ToSByte(SqlDate.Substring(8, 2), 2, "", "trim,striptags", -1);
                    result._hour = 0;
                    result._minute = 0;
                    result._second = 0;
                    result._millisecond = 0;
                }

                //                  01234567890123456789012
                // SQL Date Format: 201307061324            Length: 12 - ok
                if (SqlDate.Length == 12)
                {
                    SqlDateFormatFound = true;

                    result._year = ConvertX.ToShort(SqlDate.Substring(0, 4), 4, "", "trim,striptags", -1);
                    result._month = ConvertX.ToSByte(SqlDate.Substring(4, 2), 2, "", "trim,striptags", -1);
                    result._day = ConvertX.ToSByte(SqlDate.Substring(6, 2), 2, "", "trim,striptags", -1);
                    result._hour = ConvertX.ToSByte(SqlDate.Substring(8, 2), 2, "", "trim,striptags", -1);
                    result._minute = ConvertX.ToSByte(SqlDate.Substring(10, 2), 2, "", "trim,striptags", -1);
                    result._second = 0;
                    result._millisecond = 0;
                }

                //                  01234567890123456789012
                // SQL Date Format: 20130706132456          Length: 14 - ok
                if (SqlDate.Length == 14)
                {
                    SqlDateFormatFound = true;

                    result._year = ConvertX.ToShort(SqlDate.Substring(0, 4), 4, "", "trim,striptags", -1);
                    result._month = ConvertX.ToSByte(SqlDate.Substring(4, 2), 2, "", "trim,striptags", -1);
                    result._day = ConvertX.ToSByte(SqlDate.Substring(6, 2), 2, "", "trim,striptags", -1);
                    result._hour = ConvertX.ToSByte(SqlDate.Substring(8, 2), 2, "", "trim,striptags", -1);
                    result._minute = ConvertX.ToSByte(SqlDate.Substring(10, 2), 2, "", "trim,striptags", -1);
                    result._second = ConvertX.ToSByte(SqlDate.Substring(12, 2), 2, "", "trim,striptags", -1);
                    result._millisecond = 0;
                }

                //                  01234567890123456789012
                // SQL Date Format: 20130706 132456         Length: 15 - ok
                if (SqlDate.Length == 15)
                {
                    SqlDateFormatFound = true;

                    result._year = ConvertX.ToShort(SqlDate.Substring(0, 4), 4, "", "trim,striptags", -1);
                    result._month = ConvertX.ToSByte(SqlDate.Substring(4, 2), 2, "", "trim,striptags", -1);
                    result._day = ConvertX.ToSByte(SqlDate.Substring(6, 2), 2, "", "trim,striptags", -1);
                    result._hour = ConvertX.ToSByte(SqlDate.Substring(9, 2), 2, "", "trim,striptags", -1);
                    result._minute = ConvertX.ToSByte(SqlDate.Substring(11, 2), 2, "", "trim,striptags", -1);
                    result._second = ConvertX.ToSByte(SqlDate.Substring(13, 2), 2, "", "trim,striptags", -1);
                    result._millisecond = 0;
                }

                //                  01234567890123456789012
                // SQL Date Format: 2013-07-06 13:24        Length: 16 - ok
                if (SqlDate.Length == 16)
                {
                    SqlDateFormatFound = true;

                    result._year = ConvertX.ToShort(SqlDate.Substring(0, 4), 4, "", "trim,striptags", -1);
                    result._month = ConvertX.ToSByte(SqlDate.Substring(5, 2), 2, "", "trim,striptags", -1);
                    result._day = ConvertX.ToSByte(SqlDate.Substring(8, 2), 2, "", "trim,striptags", -1);
                    result._hour = ConvertX.ToSByte(SqlDate.Substring(11, 2), 2, "", "trim,striptags", -1);
                    result._minute = ConvertX.ToSByte(SqlDate.Substring(14, 2), 2, "", "trim,striptags", -1);
                    result._second = 0;
                    result._millisecond = 0;
                }

                //                  01234567890123456789012
                // SQL Date Format: 20130706132456843       Length: 17 - ok
                if (SqlDate.Length == 17)
                {
                    SqlDateFormatFound = true;

                    result._year = ConvertX.ToShort(SqlDate.Substring(0, 4), 4, "", "trim,striptags", -1);
                    result._month = ConvertX.ToSByte(SqlDate.Substring(4, 2), 2, "", "trim,striptags", -1);
                    result._day = ConvertX.ToSByte(SqlDate.Substring(6, 2), 2, "", "trim,striptags", -1);
                    result._hour = ConvertX.ToSByte(SqlDate.Substring(8, 2), 2, "", "trim,striptags", -1);
                    result._minute = ConvertX.ToSByte(SqlDate.Substring(10, 2), 2, "", "trim,striptags", -1);
                    result._second = ConvertX.ToSByte(SqlDate.Substring(12, 2), 2, "", "trim,striptags", -1);
                    result._millisecond = ConvertX.ToShort(SqlDate.Substring(14, 3), 3, "", "trim,striptags", -1);
                }

                //                  01234567890123456789012
                // SQL Date Format: 20130706 132456843      Length: 18 - ok
                if (SqlDate.Length == 18)
                {
                    SqlDateFormatFound = true;

                    result._year = ConvertX.ToShort(SqlDate.Substring(0, 4), 4, "", "trim,striptags", -1);
                    result._month = ConvertX.ToSByte(SqlDate.Substring(4, 2), 2, "", "trim,striptags", -1);
                    result._day = ConvertX.ToSByte(SqlDate.Substring(6, 2), 2, "", "trim,striptags", -1);
                    result._hour = ConvertX.ToSByte(SqlDate.Substring(9, 2), 2, "", "trim,striptags", -1);
                    result._minute = ConvertX.ToSByte(SqlDate.Substring(11, 2), 2, "", "trim,striptags", -1);
                    result._second = ConvertX.ToSByte(SqlDate.Substring(13, 2), 2, "", "trim,striptags", -1);
                    result._millisecond = ConvertX.ToShort(SqlDate.Substring(15, 3), 3, "", "trim,striptags", -1);
                }

                //                  01234567890123456789012
                // SQL Date Format: 2013-07-06 13:24:56     Length: 19 - ok
                if (SqlDate.Length == 19)
                {
                    SqlDateFormatFound = true;

                    result._year = ConvertX.ToShort(SqlDate.Substring(0, 4), 4, "", "trim,striptags", -1);
                    result._month = ConvertX.ToSByte(SqlDate.Substring(5, 2), 2, "", "trim,striptags", -1);
                    result._day = ConvertX.ToSByte(SqlDate.Substring(8, 2), 2, "", "trim,striptags", -1);
                    result._hour = ConvertX.ToSByte(SqlDate.Substring(11, 2), 2, "", "trim,striptags", -1);
                    result._minute = ConvertX.ToSByte(SqlDate.Substring(14, 2), 2, "", "trim,striptags", -1);
                    result._second = ConvertX.ToSByte(SqlDate.Substring(17, 2), 2, "", "trim,striptags", -1);
                    result._millisecond = 0;
                }

                //                  01234567890123456789012
                // SQL Date Format: 2013-07-06 13:24:56.843 Length: 23 - ok
                if (SqlDate.Length == 23)
                {
                    SqlDateFormatFound = true;

                    result._year = ConvertX.ToShort(SqlDate.Substring(0, 4), 4, "", "trim,striptags", -1);
                    result._month = ConvertX.ToSByte(SqlDate.Substring(5, 2), 2, "", "trim,striptags", -1);
                    result._day = ConvertX.ToSByte(SqlDate.Substring(8, 2), 2, "", "trim,striptags", -1);
                    result._hour = ConvertX.ToSByte(SqlDate.Substring(11, 2), 2, "", "trim,striptags", -1);
                    result._minute = ConvertX.ToSByte(SqlDate.Substring(14, 2), 2, "", "trim,striptags", -1);
                    result._second = ConvertX.ToSByte(SqlDate.Substring(17, 2), 2, "", "trim,striptags", -1);
                    result._millisecond = ConvertX.ToShort(SqlDate.Substring(20, 3), 3, "", "trim,striptags", -1);
                }

                if (SqlDateFormatFound)
                {
                    if (result._day < 1 || result._day > 31)
                    {
                        result._day = -1;
                    }

                    if (result._month < 1 || result._month > 12)
                    {
                        result._month = -1;
                    }

                    if (result._year < SQLYearMin)
                    {
                        result._year = -1;
                    }

                    if (result._hour < 0 || result._hour > 23)
                    {
                        result._hour = -1;
                    }

                    if (result._minute < 0 || result._minute > 59)
                    {
                        result._minute = -1;
                    }

                    if (result._second < 0 || result._second > 59)
                    {
                        result._second = -1;
                    }

                    if (result._millisecond < 0 || result._millisecond > 999)
                    {
                        result._millisecond = -1;
                    }

                    if (result._day == -1 || result._month == -1 || result._year == -1 || result._hour == -1 || result._minute == -1 || result._second == -1 || result._millisecond == -1)
                    {
                        result = null;
                        return false;
                    }
                    else
                    {
                        return true;
                    }

                }
                else
                {
                    result = null;
                    return false;
                }
            }
        }

        public DateTime ToShortDateTime()
        {
            if (this._year == -1 || this._month == -1 || this._day == -1)
            {
                return new DateTime(SQLYearMin, 1, 1);
            }
            else
            {
                return new DateTime(this._year, this._month, this._day);
            }
        }

        public DateTime ToLongDateTime()
        {
            if (this._year == -1 || this._month == -1 || this._day == -1 || this._hour == -1 || this._minute == -1 || this._second == -1 || this._millisecond == -1)
            {
                return new DateTime(SQLYearMin, 1, 1, 0, 0, 0, 0);
            }
            else
            {
                return new DateTime(this._year, this._month, this._day, this._hour, this._minute, this._second, this._millisecond);
            }
        }

        public StringX ToSQLShortDate()
        {
            if (this._day == -1 || this._month == -1 || this._year == -1)
            {
                return null;
            }
            else
            {
                string strDay = this._day.ToString().PadLeft(2, '0');
                string strMonth = this._month.ToString().PadLeft(2, '0');
                string strYear = this._year.ToString().PadLeft(4, '0');

                return strYear + "-" + strMonth + "-" + strDay;
            }
        }

        public StringX ToSQLLongDate()
        {
            if (this._day == -1 || this._month == -1 || this._year == -1 || this._hour == -1 || this._minute == -1 || this._second == -1 || this._millisecond == -1)
            {
                return null;
            }
            else
            {
                string strDay = this._day.ToString().PadLeft(2, '0');
                string strMonth = this._month.ToString().PadLeft(2, '0');
                string strYear = this._year.ToString().PadLeft(4, '0');
                string strHour = this._hour.ToString().PadLeft(2, '0');
                string strMinute = this._minute.ToString().PadLeft(2, '0');
                string strSecond = this._second.ToString().PadLeft(2, '0');
                string strMilliSecond = this._millisecond.ToString().PadLeft(3, '0');

                return strYear + "-" + strMonth + "-" + strDay + " " + strHour + ":" + strMinute + ":" + strSecond + "." + strMilliSecond;
            }
        }

        public override string ToString()
        {
            return this.ToSQLLongDate();
        }
    }
    #endregion

    ///////////////////////////////////////////////////////////////////////////
    // HTML functions
    ///////////////////////////////////////////////////////////////////////////
    #region Object: HtmlX...
    public static class HtmlX
    {
        ///////////////////////////////////////////////////////////////////////////
        // HTML Cleaning functions
        ///////////////////////////////////////////////////////////////////////////
        public static string StripTags(string source)
        {
            char[] array = new char[source.Length];
            int arrayIndex = 0;
            bool inside = false;

            for (int i = 0; i < source.Length; i++)
            {
                char let = source[i];

                if (let == '<')
                {
                    inside = true;
                    continue;
                }
                if (let == '>')
                {
                    inside = false;
                    continue;
                }
                if (!inside)
                {
                    array[arrayIndex] = let;
                    arrayIndex++;
                }
            }
            return new string(array, 0, arrayIndex);
        }

        public static string CleanWord(string html)
        {
            html = html.Trim();

            if (String.IsNullOrEmpty(html))
            {
                html = "";
            }

            // start by completely removing all unwanted tags     
            html = Regex.Replace(html, @"<[/]?(img|span|xml|del|ins|[ovwxp]:\w+)[^>]*?>", "", RegexOptions.IgnoreCase);
            // then run another pass over the html (twice), removing unwanted attributes     
            html = Regex.Replace(html, @"<([^>]*)(?:class|lang|style|size|face|[ovwxp]:\w+)=(?:'[^']*'|""[^""]*""|[^\s>]+)([^>]*)>", "<$1$2>", RegexOptions.IgnoreCase);
            html = Regex.Replace(html, @"<([^>]*)(?:class|lang|style|size|face|[ovwxp]:\w+)=(?:'[^']*'|""[^""]*""|[^\s>]+)([^>]*)>", "<$1$2>", RegexOptions.IgnoreCase);

            return html;
        }

        ///////////////////////////////////////////////////////////////////////////
        // HTML IsEmpty functions
        ///////////////////////////////////////////////////////////////////////////
        public static bool IsEmpty(byte value1)
        {
            return (value1 == 0);
        }

        public static bool IsEmpty(sbyte value1)
        {
            return (value1 == 0);
        }

        public static bool IsEmpty(short value1)
        {
            return (value1 == 0);
        }

        public static bool IsEmpty(ushort value1)
        {
            return (value1 == 0);
        }

        public static bool IsEmpty(int value1)
        {
            return (value1 == 0);
        }

        public static bool IsEmpty(uint value1)
        {
            return (value1 == 0);
        }

        public static bool IsEmpty(long value1)
        {
            return (value1 == 0);
        }

        public static bool IsEmpty(ulong value1)
        {
            return (value1 == 0);
        }

        public static bool IsEmpty(decimal value1)
        {
            return (value1 == 0);
        }

        public static bool IsEmpty(float value1)
        {
            return (value1 == 0);
        }

        public static bool IsEmpty(double value1)
        {
            return (value1 == 0);
        }

        public static bool IsEmpty(char value1)
        {
            return (value1 == ' ' || value1 == '\0' || value1 == '0');
        }

        public static bool IsEmpty(string value1)
        {
            value1 = value1.Trim();

            return (String.IsNullOrEmpty(value1) || value1 == "0");
        }

        public static bool IsEmpty(object value1)
        {
            return (value1 == null || value1 is DBNull);
        }
    }
    #endregion

    ///////////////////////////////////////////////////////////////////////////
    // File functions
    ///////////////////////////////////////////////////////////////////////////
    #region Object FileX...
    public static class FileX
    {
        public static string GetGenericFileTypeName(string file_ext)
        {
            string file_type = "";      // Very rare or unknown

            file_ext = file_ext.ToLower();
            file_ext = file_ext.Trim(new char[] { ' ', '.' });

            if (file_ext == "jpg" || file_ext == "jpeg" || file_ext == "png" || file_ext == "gif" ||
                file_ext == "bmp" || file_ext == "tga" || file_ext == "tif" || file_ext == "tiff" ||
                file_ext == "apng" || file_ext == "jpe" || file_ext == "lbm" || file_ext == "odi" ||
                file_ext == "oti" || file_ext == "pcx" || file_ext == "psp" || file_ext == "pspimage" ||
                file_ext == "qti" || file_ext == "qtif" || file_ext == "qif" || file_ext == "ras" ||
                file_ext == "wmp" || file_ext == "wvl" || file_ext == "xbm" || file_ext == "xcf" ||
                file_ext == "xpm")
            {
                file_type = "image_raster";
            }

            if (file_ext == "ai" || file_ext == "cdr" || file_ext == "cdx" || file_ext == "cmx" ||
               file_ext == "design" || file_ext == "emf" || file_ext == "emz" || file_ext == "eps" ||
               file_ext == "epsf" || file_ext == "fh10" || file_ext == "fh11" || file_ext == "fh7" ||
               file_ext == "fh8" || file_ext == "fh9" || file_ext == "fhd" || file_ext == "fif" ||
               file_ext == "ft10" || file_ext == "ft11" || file_ext == "ft7" || file_ext == "ft8" ||
               file_ext == "ft9" || file_ext == "fxg" || file_ext == "odg" || file_ext == "otg" ||
               file_ext == "ps" || file_ext == "psid" || file_ext == "sda" || file_ext == "std" ||
               file_ext == "svg" || file_ext == "svgz" || file_ext == "vbr" || file_ext == "vml" ||
               file_ext == "vsd" || file_ext == "vst" || file_ext == "wmf" || file_ext == "wpg" ||
               file_ext == "ps")
            {
                file_type = "image_vector";
            }

            if (file_ext == "txt" || file_ext == "text" || file_ext == "rtf" || file_ext == "ini" ||
                file_ext == "log")
            {
                file_type = "text";
            }

            if (file_ext == "aac" || file_ext == "ac3" || file_ext == "aif" || file_ext == "aiff" ||
                file_ext == "aifc" || file_ext == "flac" || file_ext == "iff" || file_ext == "m4a" ||
                file_ext == "m4b" || file_ext == "m4p" || file_ext == "mod" || file_ext == "mp1" ||
                file_ext == "mp2" || file_ext == "mp3" || file_ext == "mpa" || file_ext == "mpga" ||
                file_ext == "nsa" || file_ext == "oga" || file_ext == "ogg" || file_ext == "pcm" ||
                file_ext == "sid" || file_ext == "voc" || file_ext == "wav" || file_ext == "wma")
            {
                file_type = "audio";
            }

            if (file_ext == "3g2" || file_ext == "3gp" || file_ext == "asf" || file_ext == "asx" ||
                file_ext == "avi" || file_ext == "bdmv" || file_ext == "bik" || file_ext == "dat" ||
                file_ext == "divx" || file_ext == "dv" || file_ext == "dvx" || file_ext == "f4v" ||
                file_ext == "flv" || file_ext == "ifo" || file_ext == "ivf" || file_ext == "m1v" ||
                file_ext == "m2a" || file_ext == "m2v" || file_ext == "m4v" || file_ext == "mj2" ||
                file_ext == "mjp" || file_ext == "mjpg" || file_ext == "mod" || file_ext == "mov" ||
                file_ext == "movie" || file_ext == "mp2v" || file_ext == "mp4" || file_ext == "mp4v" ||
                file_ext == "mpeg" || file_ext == "mpeg4" || file_ext == "mpg" || file_ext == "mpg2" ||
                file_ext == "mpv" || file_ext == "mpv2" || file_ext == "ogm" || file_ext == "ogv" ||
                file_ext == "ogx" || file_ext == "qt" || file_ext == "qtm" || file_ext == "rm" ||
                file_ext == "smk" || file_ext == "swf" || file_ext == "vob" || file_ext == "wm" ||
                file_ext == "wmv" || file_ext == "yuv")
            {
                file_type = "video";
            }

            if (file_ext == "sbt" || file_ext == "srt" || file_ext == "smi" || file_ext == "sub")
            {
                file_type = "video_subtitle";
            }

            if (file_ext == "doc" || file_ext == "docx" || file_ext == "xls" || file_ext == "xlsx" ||
                file_ext == "vsd" || file_ext == "vss" || file_ext == "vst" || file_ext == "vdx" ||
                file_ext == "vsx" || file_ext == "vtx" || file_ext == "pub" || file_ext == "mpp" ||
                file_ext == "mpt" || file_ext == "ppt" || file_ext == "pptx" || file_ext == "pot" ||
                file_ext == "potx" || file_ext == "pps" || file_ext == "ppsx" || file_ext == "odp" ||
                file_ext == "xsn" || file_ext == "pdf" || file_ext == "xps" || file_ext == "xlsb" ||
                file_ext == "xlt" || file_ext == "xltx" || file_ext == "ods" || file_ext == "123" ||
                file_ext == "numbers" || file_ext == "ots" || file_ext == "wks" || file_ext == "xl" ||
                file_ext == "dot" || file_ext == "ind" || file_ext == "indd" || file_ext == "indl" ||
                file_ext == "indp" || file_ext == "inds" || file_ext == "indt")
            {
                file_type = "office";
            }

            if (file_ext == "csv" || file_ext == "xml" || file_ext == "pst" || file_ext == "accdb" ||
                file_ext == "db" || file_ext == "db2" || file_ext == "db3" || file_ext == "dbf" ||
                file_ext == "fmp" || file_ext == "fm5" || file_ext == "fp3" || file_ext == "fp4" ||
                file_ext == "fp5" || file_ext == "fp7" || file_ext == "frm" || file_ext == "ib" ||
                file_ext == "itdb" || file_ext == "mdb" || file_ext == "mdf" || file_ext == "mdn" ||
                file_ext == "mdt" || file_ext == "mpd" || file_ext == "myd" || file_ext == "ndf" ||
                file_ext == "odb" || file_ext == "sdb" || file_ext == "sdf" || file_ext == "sqlite" ||
                file_ext == "sqlitedb" || file_ext == "nsf")
            {
                file_type = "database";
            }

            if (file_ext == "air" || file_ext == "apk" || file_ext == "app" || file_ext == "applescript" ||
                file_ext == "bat" || file_ext == "cmd" || file_ext == "com" || file_ext == "csh" ||
                file_ext == "elf" || file_ext == "esh" || file_ext == "exe" || file_ext == "ex_" ||
                file_ext == "hta" || file_ext == "ita" || file_ext == "jar" || file_ext == "js" ||
                file_ext == "osx" || file_ext == "pif" || file_ext == "prg" || file_ext == "vb" ||
                file_ext == "vbs" || file_ext == "vbscript" || file_ext == "ws" || file_ext == "wsf" ||
                file_ext == "xap" || file_ext == "scr" || file_ext == "dll")
            {
                file_type = "executable";
            }

            if (file_ext == "cer" || file_ext == "crt" || file_ext == "csr" || file_ext == "pgp")
            {
                file_type = "security";
            }

            if (file_ext == "asa" || file_ext == "asax" || file_ext == "ascx" || file_ext == "ashx" ||
                file_ext == "asmx" || file_ext == "asp" || file_ext == "aspx" || file_ext == "cfm" ||
                file_ext == "cfml" || file_ext == "css" || file_ext == "dhtml" || file_ext == "do" ||
                file_ext == "htm" || file_ext == "html" || file_ext == "htx" || file_ext == "htaccess" ||
                file_ext == "jhtml" || file_ext == "js" || file_ext == "jsp" || file_ext == "jspa" ||
                file_ext == "jspx" || file_ext == "mht" || file_ext == "mhtml" || file_ext == "mspx" ||
                file_ext == "nzb" || file_ext == "oth" || file_ext == "php" || file_ext == "php3" ||
                file_ext == "php4" || file_ext == "php5" || file_ext == "phtm" || file_ext == "phtml" ||
                file_ext == "shtm" || file_ext == "shtml" || file_ext == "url" || file_ext == "vrml" ||
                file_ext == "xht" || file_ext == "xhtml")
            {
                file_type = "web";
            }

            if (file_ext == "chr" || file_ext == "cha" || file_ext == "eot" || file_ext == "fnt" ||
                file_ext == "fon" || file_ext == "otf" || file_ext == "suit" || file_ext == "ttc" ||
                file_ext == "ttf")
            {
                file_type = "font";
            }

            if (file_ext == "cpl" || file_ext == "cur" || file_ext == "dev" || file_ext == "drv" ||
                file_ext == "hlp" || file_ext == "icl" || file_ext == "ico" || file_ext == "idx" ||
                file_ext == "lnk" || file_ext == "mui" || file_ext == "prf" || file_ext == "pwl" ||
                file_ext == "reg" || file_ext == "sys" || file_ext == "vga" || file_ext == "vxd")
            {
                file_type = "system";
            }

            if (file_ext == "7z" || file_ext == "ace" || file_ext == "rar" || file_ext == "zip" ||
                file_ext == "arc" || file_ext == "arj" || file_ext == "bz" || file_ext == "bz2" ||
                file_ext == "bzip" || file_ext == "bzip2" || file_ext == "c00" || file_ext == "c01" ||
                file_ext == "c02" || file_ext == "c03" || file_ext == "c04" || file_ext == "c05" ||
                file_ext == "c06" || file_ext == "c07" || file_ext == "c08" || file_ext == "c09" ||
                file_ext == "cb7" || file_ext == "cbr" || file_ext == "cbt" || file_ext == "cbz" ||
                file_ext == "deb" || file_ext == "gz" || file_ext == "gzip" || file_ext == "lha" ||
                file_ext == "lnx" || file_ext == "lzo" || file_ext == "lzx" || file_ext == "par" ||
                file_ext == "par2" || file_ext == "pkg" || file_ext == "zoo" || file_ext == "rpm" ||
                file_ext == "s7z" || file_ext == "sfx" || file_ext == "sit" || file_ext == "sitx" ||
                file_ext == "uc2" || file_ext == "uha" || file_ext == "wad" || file_ext == "xpi" ||
                file_ext == "r00" || file_ext == "r01" || file_ext == "r02" || file_ext == "r03" ||
                file_ext == "r04" || file_ext == "r05" || file_ext == "r06" || file_ext == "r07" ||
                file_ext == "r08" || file_ext == "r09" || file_ext == "z00" || file_ext == "z01" ||
                file_ext == "z02" || file_ext == "z03" || file_ext == "z04" || file_ext == "z05" ||
                file_ext == "z06" || file_ext == "z07" || file_ext == "z08" || file_ext == "z09" ||
                file_ext == "uzip")
            {
                file_type = "archieve";
            }

            if (file_ext == "adf" || file_ext == "adz" || file_ext == "atr" || file_ext == "bif" ||
                file_ext == "bin" || file_ext == "c2d" || file_ext == "ccd" || file_ext == "cdr" ||
                file_ext == "cif" || file_ext == "cso" || file_ext == "cue" || file_ext == "d64" ||
                file_ext == "daa" || file_ext == "dao" || file_ext == "dax" || file_ext == "dcf" ||
                file_ext == "dmg" || file_ext == "dsk" || file_ext == "fdd" || file_ext == "fdi" ||
                file_ext == "hdd" || file_ext == "ima" || file_ext == "image" || file_ext == "img" ||
                file_ext == "iso" || file_ext == "isz" || file_ext == "nrg" || file_ext == "pqi" ||
                file_ext == "sqfs" || file_ext == "st" || file_ext == "t64" || file_ext == "tao" ||
                file_ext == "tap" || file_ext == "toast" || file_ext == "ufs" || file_ext == "vdi" ||
                file_ext == "vcd" || file_ext == "vhd" || file_ext == "vmdk" || file_ext == "vmwarevm" ||
                file_ext == "x64")
            {
                file_type = "disk_image";
            }

            if (file_ext == "abc" || file_ext == "ada" || file_ext == "addin" || file_ext == "as" ||
                file_ext == "asc" || file_ext == "asm" || file_ext == "b" || file_ext == "bas" ||
                file_ext == "bb" || file_ext == "bcp" || file_ext == "c" || file_ext == "cd" ||
                file_ext == "class" || file_ext == "cpp" || file_ext == "cs" || file_ext == "csproj" ||
                file_ext == "dbproj" || file_ext == "dcp" || file_ext == "dcu" || file_ext == "dfm" ||
                file_ext == "dpk" || file_ext == "dpl" || file_ext == "dpr" || file_ext == "dsk" ||
                file_ext == "dsp" || file_ext == "f" || file_ext == "f90" || file_ext == "fla" ||
                file_ext == "fpp" || file_ext == "framework" || file_ext == "frm" || file_ext == "fs" ||
                file_ext == "fsi" || file_ext == "fsproj" || file_ext == "fsscript" || file_ext == "fsx" ||
                file_ext == "h" || file_ext == "hh" || file_ext == "hpp" || file_ext == "j" ||
                file_ext == "jav" || file_ext == "java" || file_ext == "json" || file_ext == "licx" ||
                file_ext == "ocx" || file_ext == "p" || file_ext == "pas" || file_ext == "ph" ||
                file_ext == "pl" || file_ext == "ppl" || file_ext == "ppu" || file_ext == "res" ||
                file_ext == "resources" || file_ext == "resx" || file_ext == "rsrc" || file_ext == "sln" ||
                file_ext == "tpu" || file_ext == "tpx" || file_ext == "vbg" || file_ext == "vbp" ||
                file_ext == "vbproj" || file_ext == "vbx" || file_ext == "vbz" || file_ext == "vcproj" ||
                file_ext == "vcxproj" || file_ext == "vdp" || file_ext == "vdproj" || file_ext == "vsmacros" ||
                file_ext == "vsmdi" || file_ext == "vsmproj" || file_ext == "vspscc" || file_ext == "vssscc" ||
                file_ext == "wdl" || file_ext == "xaml")
            {
                file_type = "development";
            }

            if (file_ext == "$$$" || file_ext == "bac" || file_ext == "backupdb" || file_ext == "bak" ||
                file_ext == "bk1" || file_ext == "bkf" || file_ext == "bkp" || file_ext == "dbk" ||
                file_ext == "gho" || file_ext == "ghs" || file_ext == "oeb" || file_ext == "qic" ||
                file_ext == "rbk" || file_ext == "tmp" || file_ext == "v2i")
            {
                file_type = "backup";
            }

            return file_type;
        }
    }
    #endregion

    public static class ToolsX
    {
        ///////////////////////////////////////////////////////////////////////////
        // Boolean functions
        ///////////////////////////////////////////////////////////////////////////
        #region Boolean functions...
        public static byte Bool2Byte(bool AnyBool)
        {
            if (AnyBool)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////////
        // Database IsNull functions
        ///////////////////////////////////////////////////////////////////////////
        #region IsNullDB overloads...
        public static byte IsNullDB(object value, byte replacement)
        {
            if (value == null || value is DBNull)
            {
                return replacement;
            }
            else
            {
                return Convert.ToByte(value);
            }
        }

        public static sbyte IsNullDB(object value, sbyte replacement)
        {
            if (value == null || value is DBNull)
            {
                return replacement;
            }
            else
            {
                return Convert.ToSByte(value);
            }
        }

        public static short IsNullDB(object value, short replacement)
        {
            if (value == null || value is DBNull)
            {
                return replacement;
            }
            else
            {
                return Convert.ToInt16(value);
            }
        }

        public static ushort IsNullDB(object value, ushort replacement)
        {
            if (value == null || value is DBNull)
            {
                return replacement;
            }
            else
            {
                return Convert.ToUInt16(value);
            }
        }

        public static int IsNullDB(object value, int replacement)
        {
            if (value == null || value is DBNull)
            {
                return replacement;
            }
            else
            {
                return Convert.ToInt32(value);
            }
        }

        public static uint IsNullDB(object value, uint replacement)
        {
            if (value == null || value is DBNull)
            {
                return replacement;
            }
            else
            {
                return Convert.ToUInt32(value);
            }
        }

        public static long IsNullDB(object value, long replacement)
        {
            if (value == null || value is DBNull)
            {
                return replacement;
            }
            else
            {
                return Convert.ToInt64(value);
            }
        }

        public static ulong IsNullDB(object value, ulong replacement)
        {
            if (value == null || value is DBNull)
            {
                return replacement;
            }
            else
            {
                return Convert.ToUInt64(value);
            }
        }

        public static decimal IsNullDB(object value, decimal replacement)
        {
            if (value == null || value is DBNull)
            {
                return replacement;
            }
            else
            {
                return Convert.ToDecimal(value);
            }
        }

        public static float IsNullDB(object value, float replacement)
        {
            if (value == null || value is DBNull)
            {
                return replacement;
            }
            else
            {
                return Convert.ToSingle(value);
            }
        }

        public static double IsNullDB(object value, double replacement)
        {
            if (value == null || value is DBNull)
            {
                return replacement;
            }
            else
            {
                return Convert.ToDouble(value);
            }
        }

        public static char IsNullDB(object value, char replacement)
        {
            if (value == null || value is DBNull)
            {
                return replacement;
            }
            else
            {
                return Convert.ToChar(value);
            }
        }

        public static string IsNullDB(object value, string replacement)
        {
            if (value == null || value is DBNull)
            {
                return replacement;
            }
            else
            {
                return Convert.ToString(value);
            }
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////////
        // Minimum functions for value types
        ///////////////////////////////////////////////////////////////////////////
        #region Minimum of value types...
        public static byte Min(byte value1, byte value2)
        {
            if (value1 <= value2)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }

        public static sbyte Min(sbyte value1, sbyte value2)
        {
            if (value1 <= value2)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }

        public static short Min(short value1, short value2)
        {
            if (value1 <= value2)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }

        public static ushort Min(ushort value1, ushort value2)
        {
            if (value1 <= value2)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }

        public static int Min(int value1, int value2)
        {
            if (value1 <= value2)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }

        public static uint Min(uint value1, uint value2)
        {
            if (value1 <= value2)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }

        public static long Min(long value1, long value2)
        {
            if (value1 <= value2)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }

        public static ulong Min(ulong value1, ulong value2)
        {
            if (value1 <= value2)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }

        public static decimal Min(decimal value1, decimal value2)
        {
            if (value1 <= value2)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }

        public static float Min(float value1, float value2)
        {
            if (value1 <= value2)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }

        public static double Min(double value1, double value2)
        {
            if (value1 <= value2)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////////
        // Maximum functions for value types
        ///////////////////////////////////////////////////////////////////////////
        #region Maximum of value types...
        public static byte Max(byte value1, byte value2)
        {
            if (value1 >= value2)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }

        public static sbyte Max(sbyte value1, sbyte value2)
        {
            if (value1 >= value2)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }

        public static short Max(short value1, short value2)
        {
            if (value1 >= value2)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }

        public static ushort Max(ushort value1, ushort value2)
        {
            if (value1 >= value2)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }

        public static int Max(int value1, int value2)
        {
            if (value1 >= value2)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }

        public static uint Max(uint value1, uint value2)
        {
            if (value1 >= value2)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }

        public static long Max(long value1, long value2)
        {
            if (value1 >= value2)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }

        public static ulong Max(ulong value1, ulong value2)
        {
            if (value1 >= value2)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }

        public static decimal Max(decimal value1, decimal value2)
        {
            if (value1 >= value2)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }

        public static float Max(float value1, float value2)
        {
            if (value1 >= value2)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }

        public static double Max(double value1, double value2)
        {
            if (value1 >= value2)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////////
        // Minimum functions for arrays[]
        ///////////////////////////////////////////////////////////////////////////
        #region Minimum of an array[] overloads...
        public static byte Min(byte[] array1)
        {
            byte Minimum;

            if (array1.Length == 0)
            {
                throw new Exception("Common.Tools.Min: Empty 'byte[]' array exception");
            }
            else
            {
                Minimum = array1[0];

                for (int counter = 1; counter < array1.Length; counter++)
                {
                    if (array1[counter] < Minimum)
                    {
                        Minimum = array1[counter];
                    }
                }

                return Minimum;
            }
        }

        public static sbyte Min(sbyte[] array1)
        {
            sbyte Minimum;

            if (array1.Length == 0)
            {
                throw new Exception("Common.Tools.Min: Empty 'sbyte[]' array exception");
            }
            else
            {
                Minimum = array1[0];

                for (int counter = 1; counter < array1.Length; counter++)
                {
                    if (array1[counter] < Minimum)
                    {
                        Minimum = array1[counter];
                    }
                }

                return Minimum;
            }
        }

        public static int Min(int[] array1)
        {
            int Minimum;

            if (array1.Length == 0)
            {
                throw new Exception("Common.Tools.Min: Empty 'int[]' array exception");
            }
            else
            {
                Minimum = array1[0];

                for (int counter = 1; counter < array1.Length; counter++)
                {
                    if (array1[counter] < Minimum)
                    {
                        Minimum = array1[counter];
                    }
                }

                return Minimum;
            }
        }

        public static uint Min(uint[] array1)
        {
            uint Minimum;

            if (array1.Length == 0)
            {
                throw new Exception("Common.Tools.Min: Empty 'uint[]' array exception");
            }
            else
            {
                Minimum = array1[0];

                for (int counter = 1; counter < array1.Length; counter++)
                {
                    if (array1[counter] < Minimum)
                    {
                        Minimum = array1[counter];
                    }
                }

                return Minimum;
            }
        }

        public static long Min(long[] array1)
        {
            long Minimum;

            if (array1.Length == 0)
            {
                throw new Exception("Common.Tools.Min: Empty 'long[]' array exception");
            }
            else
            {
                Minimum = array1[0];

                for (int counter = 1; counter < array1.Length; counter++)
                {
                    if (array1[counter] < Minimum)
                    {
                        Minimum = array1[counter];
                    }
                }

                return Minimum;
            }
        }

        public static ulong Min(ulong[] array1)
        {
            ulong Minimum;

            if (array1.Length == 0)
            {
                throw new Exception("Common.Tools.Min: Empty 'ulong[]' array exception");
            }
            else
            {
                Minimum = array1[0];

                for (int counter = 1; counter < array1.Length; counter++)
                {
                    if (array1[counter] < Minimum)
                    {
                        Minimum = array1[counter];
                    }
                }

                return Minimum;
            }
        }

        public static short Min(short[] array1)
        {
            short Minimum;

            if (array1.Length == 0)
            {
                throw new Exception("Common.Tools.Min: Empty 'short[]' array exception");
            }
            else
            {
                Minimum = array1[0];

                for (int counter = 1; counter < array1.Length; counter++)
                {
                    if (array1[counter] < Minimum)
                    {
                        Minimum = array1[counter];
                    }
                }

                return Minimum;
            }
        }

        public static ushort Min(ushort[] array1)
        {
            ushort Minimum;

            if (array1.Length == 0)
            {
                throw new Exception("Common.Tools.Min: Empty 'ushort[]' array exception");
            }
            else
            {
                Minimum = array1[0];

                for (int counter = 1; counter < array1.Length; counter++)
                {
                    if (array1[counter] < Minimum)
                    {
                        Minimum = array1[counter];
                    }
                }

                return Minimum;
            }
        }

        public static decimal Min(decimal[] array1)
        {
            decimal Minimum;

            if (array1.Length == 0)
            {
                throw new Exception("Common.Tools.Min: Empty 'decimal[]' array exception");
            }
            else
            {
                Minimum = array1[0];

                for (int counter = 1; counter < array1.Length; counter++)
                {
                    if (array1[counter] < Minimum)
                    {
                        Minimum = array1[counter];
                    }
                }

                return Minimum;
            }
        }

        public static float Min(float[] array1)
        {
            float Minimum;

            if (array1.Length == 0)
            {
                throw new Exception("Common.Tools.Min: Empty 'float[]' array exception");
            }
            else
            {
                Minimum = array1[0];

                for (int counter = 1; counter < array1.Length; counter++)
                {
                    if (array1[counter] < Minimum)
                    {
                        Minimum = array1[counter];
                    }
                }

                return Minimum;
            }
        }

        public static double Min(double[] array1)
        {
            double Minimum;

            if (array1.Length == 0)
            {
                throw new Exception("Common.Tools.Min: Empty 'double[]' array exception");
            }
            else
            {
                Minimum = array1[0];

                for (int counter = 1; counter < array1.Length; counter++)
                {
                    if (array1[counter] < Minimum)
                    {
                        Minimum = array1[counter];
                    }
                }

                return Minimum;
            }
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////////
        // Maximum functions for arrays[]
        ///////////////////////////////////////////////////////////////////////////
        #region Maximum of an array[] overloads...
        public static byte Max(byte[] array1)
        {
            byte Maximum;

            if (array1.Length == 0)
            {
                throw new Exception("Common.Tools.Max: Empty 'byte[]' array exception");
            }
            else
            {
                Maximum = array1[0];

                for (int counter = 1; counter < array1.Length; counter++)
                {
                    if (array1[counter] > Maximum)
                    {
                        Maximum = array1[counter];
                    }
                }

                return Maximum;
            }
        }

        public static sbyte Max(sbyte[] array1)
        {
            sbyte Maximum;

            if (array1.Length == 0)
            {
                throw new Exception("Common.Tools.Max: Empty 'sbyte[]' array exception");
            }
            else
            {
                Maximum = array1[0];

                for (int counter = 1; counter < array1.Length; counter++)
                {
                    if (array1[counter] > Maximum)
                    {
                        Maximum = array1[counter];
                    }
                }

                return Maximum;
            }
        }

        public static int Max(int[] array1)
        {
            int Maximum;

            if (array1.Length == 0)
            {
                throw new Exception("Common.Tools.Max: Empty 'int[]' array exception");
            }
            else
            {
                Maximum = array1[0];

                for (int counter = 1; counter < array1.Length; counter++)
                {
                    if (array1[counter] > Maximum)
                    {
                        Maximum = array1[counter];
                    }
                }

                return Maximum;
            }
        }

        public static uint Max(uint[] array1)
        {
            uint Maximum;

            if (array1.Length == 0)
            {
                throw new Exception("Common.Tools.Max: Empty 'uint[]' array exception");
            }
            else
            {
                Maximum = array1[0];

                for (int counter = 1; counter < array1.Length; counter++)
                {
                    if (array1[counter] > Maximum)
                    {
                        Maximum = array1[counter];
                    }
                }

                return Maximum;
            }
        }

        public static long Max(long[] array1)
        {
            long Maximum;

            if (array1.Length == 0)
            {
                throw new Exception("Common.Tools.Max: Empty 'long[]' array exception");
            }
            else
            {
                Maximum = array1[0];

                for (int counter = 1; counter < array1.Length; counter++)
                {
                    if (array1[counter] > Maximum)
                    {
                        Maximum = array1[counter];
                    }
                }

                return Maximum;
            }
        }

        public static ulong Max(ulong[] array1)
        {
            ulong Maximum;

            if (array1.Length == 0)
            {
                throw new Exception("Common.Tools.Max: Empty 'ulong[]' array exception");
            }
            else
            {
                Maximum = array1[0];

                for (int counter = 1; counter < array1.Length; counter++)
                {
                    if (array1[counter] > Maximum)
                    {
                        Maximum = array1[counter];
                    }
                }

                return Maximum;
            }
        }

        public static short Max(short[] array1)
        {
            short Maximum;

            if (array1.Length == 0)
            {
                throw new Exception("Common.Tools.Max: Empty 'short[]' array exception");
            }
            else
            {
                Maximum = array1[0];

                for (int counter = 1; counter < array1.Length; counter++)
                {
                    if (array1[counter] > Maximum)
                    {
                        Maximum = array1[counter];
                    }
                }

                return Maximum;
            }
        }

        public static ushort Max(ushort[] array1)
        {
            ushort Maximum;

            if (array1.Length == 0)
            {
                throw new Exception("Common.Tools.Max: Empty 'ushort[]' array exception");
            }
            else
            {
                Maximum = array1[0];

                for (int counter = 1; counter < array1.Length; counter++)
                {
                    if (array1[counter] > Maximum)
                    {
                        Maximum = array1[counter];
                    }
                }

                return Maximum;
            }
        }

        public static float Max(float[] array1)
        {
            float Maximum;

            if (array1.Length == 0)
            {
                throw new Exception("Common.Tools.Max: Empty 'float[]' array exception");
            }
            else
            {
                Maximum = array1[0];

                for (int counter = 1; counter < array1.Length; counter++)
                {
                    if (array1[counter] > Maximum)
                    {
                        Maximum = array1[counter];
                    }
                }

                return Maximum;
            }
        }

        public static double Max(double[] array1)
        {
            double Maximum;

            if (array1.Length == 0)
            {
                throw new Exception("Common.Tools.Max: Empty 'double[]' array exception");
            }
            else
            {
                Maximum = array1[0];

                for (int counter = 1; counter < array1.Length; counter++)
                {
                    if (array1[counter] > Maximum)
                    {
                        Maximum = array1[counter];
                    }
                }

                return Maximum;
            }
        }

        public static decimal Max(decimal[] array1)
        {
            decimal Maximum;

            if (array1.Length == 0)
            {
                throw new Exception("Common.Tools.Max: Empty 'decimal[]' array exception");
            }
            else
            {
                Maximum = array1[0];

                for (int counter = 1; counter < array1.Length; counter++)
                {
                    if (array1[counter] > Maximum)
                    {
                        Maximum = array1[counter];
                    }
                }

                return Maximum;
            }
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////////
        // Swap functions for primitives
        ///////////////////////////////////////////////////////////////////////////
        #region Swap values overloads...
        public static void Swap<T>(ref T val1, ref T val2)
        {
            T dummy;

            dummy = val1;
            val1 = val2;
            val2 = dummy;
        }

        public static void Swap(ref byte val1, ref byte val2)
        {
            byte dummy;

            dummy = val1;
            val1 = val2;
            val2 = dummy;
        }

        public static void Swap(ref sbyte val1, ref sbyte val2)
        {
            sbyte dummy;

            dummy = val1;
            val1 = val2;
            val2 = dummy;
        }

        public static void Swap(ref short val1, ref short val2)
        {
            short dummy;

            dummy = val1;
            val1 = val2;
            val2 = dummy;
        }

        public static void Swap(ref ushort val1, ref ushort val2)
        {
            ushort dummy;

            dummy = val1;
            val1 = val2;
            val2 = dummy;
        }

        public static void Swap(ref int val1, ref int val2)
        {
            int dummy;

            dummy = val1;
            val1 = val2;
            val2 = dummy;
        }

        public static void Swap(ref uint val1, ref uint val2)
        {
            uint dummy;

            dummy = val1;
            val1 = val2;
            val2 = dummy;
        }

        public static void Swap(ref long val1, ref long val2)
        {
            long dummy;

            dummy = val1;
            val1 = val2;
            val2 = dummy;
        }

        public static void Swap(ref ulong val1, ref ulong val2)
        {
            ulong dummy;

            dummy = val1;
            val1 = val2;
            val2 = dummy;
        }

        public static void Swap(ref float val1, ref float val2)
        {
            float dummy;

            dummy = val1;
            val1 = val2;
            val2 = dummy;
        }

        public static void Swap(ref double val1, ref double val2)
        {
            double dummy;

            dummy = val1;
            val1 = val2;
            val2 = dummy;
        }

        public static void Swap(ref decimal val1, ref decimal val2)
        {
            decimal dummy;

            dummy = val1;
            val1 = val2;
            val2 = dummy;
        }

        public static void Swap(ref string val1, ref string val2)
        {
            string dummy;

            dummy = val1;
            val1 = val2;
            val2 = dummy;
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////////
        // IsBetween functions for primitives
        ///////////////////////////////////////////////////////////////////////////
        #region IsBetween value overloads...
        public static bool IsBetween(byte X, byte LowerLimit, byte UpperLimit)
        {
            if (UpperLimit < LowerLimit) { ToolsX.Swap(ref LowerLimit, ref UpperLimit); }
            return (X >= LowerLimit) && (X <= UpperLimit);
        }

        public static bool IsBetween(sbyte X, sbyte LowerLimit, sbyte UpperLimit)
        {
            if (UpperLimit < LowerLimit) { ToolsX.Swap(ref LowerLimit, ref UpperLimit); }
            return (X >= LowerLimit) && (X <= UpperLimit);
        }

        public static bool IsBetween(ushort X, ushort LowerLimit, ushort UpperLimit)
        {
            if (UpperLimit < LowerLimit) { ToolsX.Swap(ref LowerLimit, ref UpperLimit); }
            return (X >= LowerLimit) && (X <= UpperLimit);
        }

        public static bool IsBetween(short X, short LowerLimit, short UpperLimit)
        {
            if (UpperLimit < LowerLimit) { ToolsX.Swap(ref LowerLimit, ref UpperLimit); }
            return (X >= LowerLimit) && (X <= UpperLimit);
        }

        public static bool IsBetween(uint X, uint LowerLimit, uint UpperLimit)
        {
            if (UpperLimit < LowerLimit) { ToolsX.Swap(ref LowerLimit, ref UpperLimit); }
            return (X >= LowerLimit) && (X <= UpperLimit);
        }

        public static bool IsBetween(int X, int LowerLimit, int UpperLimit)
        {
            if (UpperLimit < LowerLimit) { ToolsX.Swap(ref LowerLimit, ref UpperLimit); }
            return (X >= LowerLimit) && (X <= UpperLimit);
        }

        public static bool IsBetween(ulong X, ulong LowerLimit, ulong UpperLimit)
        {
            if (UpperLimit < LowerLimit) { ToolsX.Swap(ref LowerLimit, ref UpperLimit); }
            return (X >= LowerLimit) && (X <= UpperLimit);
        }

        public static bool IsBetween(long X, long LowerLimit, long UpperLimit)
        {
            if (UpperLimit < LowerLimit) { ToolsX.Swap(ref LowerLimit, ref UpperLimit); }
            return (X >= LowerLimit) && (X <= UpperLimit);
        }

        public static bool IsBetween(float X, float LowerLimit, float UpperLimit)
        {
            if (UpperLimit < LowerLimit) { ToolsX.Swap(ref LowerLimit, ref UpperLimit); }
            return (X >= LowerLimit) && (X <= UpperLimit);
        }

        public static bool IsBetween(double X, double LowerLimit, double UpperLimit)
        {
            if (UpperLimit < LowerLimit) { ToolsX.Swap(ref LowerLimit, ref UpperLimit); }
            return (X >= LowerLimit) && (X <= UpperLimit);
        }

        public static bool IsBetween(decimal X, decimal LowerLimit, decimal UpperLimit)
        {
            if (UpperLimit < LowerLimit) { ToolsX.Swap(ref LowerLimit, ref UpperLimit); }
            return (X >= LowerLimit) && (X <= UpperLimit);
        }

        #endregion

        ///////////////////////////////////////////////////////////////////////////
        // High & Low Nibble functions
        ///////////////////////////////////////////////////////////////////////////
        #region HighNibble & LowNibble overloads...
        public static byte HighNibble(byte value)
        {
            return (byte)(value >> 4);
        }

        public static byte LowNibble(byte value)
        {
            return (byte)(value & 0x0F);
        }

        public static byte HighNibble(ushort value)
        {
            return (byte)(value >> 8);
        }

        public static byte LowNibble(ushort value)
        {
            return (byte)(value & 0xFF);
        }

        public static ushort HighNibble(uint value)
        {
            return (ushort)(value >> 16);
        }

        public static ushort LowNibble(uint value)
        {
            return (ushort)(value & 0xFFFF);
        }

        public static uint HighNibble(ulong value)
        {
            return (uint)(value >> 32);
        }

        public static uint LowNibble(ulong value)
        {
            return (uint)(value & 0xFFFFFFFF);
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////////
        // Value2String functions
        ///////////////////////////////////////////////////////////////////////////
        #region Value2String overloads...
        public static string Value2String(byte value)
        {
            return Convert.ToString((char)value);
        }

        public static string Value2String(ushort value, bool LowNibbleFirst = false)
        {
            if (LowNibbleFirst == false)
            {
                return Value2String(HighNibble(value)) + Value2String(LowNibble(value));
            }
            else
            {
                return Value2String(LowNibble(value)) + Value2String(HighNibble(value));
            }
        }

        public static string Value2String(uint value, bool LowNibbleFirst = false)
        {
            if (LowNibbleFirst == false)
            {
                return Value2String(HighNibble(value), LowNibbleFirst) + Value2String(LowNibble(value), LowNibbleFirst);
            }
            else
            {
                return Value2String(LowNibble(value), LowNibbleFirst) + Value2String(HighNibble(value), LowNibbleFirst);
            }
        }

        public static string Value2String(ulong value, bool LowNibbleFirst = false)
        {
            if (LowNibbleFirst == false)
            {
                return Value2String(HighNibble(value), LowNibbleFirst) + Value2String(LowNibble(value), LowNibbleFirst);
            }
            else
            {
                return Value2String(LowNibble(value), LowNibbleFirst) + Value2String(HighNibble(value), LowNibbleFirst);
            }
        }
        #endregion
    }
}