using System;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace OrcaMDF.Framework
{
	public static class TestHelper
	{
		public static void GetAllPublicProperties(object obj)
		{
			var props = obj.GetType().GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);

			foreach(var prop in props)
				prop.GetValue(obj, null);
		}

		public static byte[] GetBytesFromByteString(string input)
		{
			// Remove anything but valid hex characters
			input = Regex.Replace(input, "[^0-9A-F]", "", RegexOptions.IgnoreCase);

			if(input.Length % 2 != 0)
				throw new FormatException("input");

			return SoapHexBinary.Parse(input).Value;
		}
	}

    public class SoapHexBinary
    {
        public byte[] Value { get; set; }

        public SoapHexBinary(byte[] value)
        {
            Value = value;
        }

        public static SoapHexBinary Parse(string value)
		{
			return new SoapHexBinary(SoapHexBinary.ToByteArray(SoapHexBinary.FilterBin64(value)));
		}

        private static byte[] ToByteArray(string value)
        {
            char[] charArray = value.ToCharArray();
            if (charArray.Length % 2 != 0)
                throw new Exception("Nope");

            byte[] numArray = new byte[charArray.Length / 2];
            for (int index = 0; index < charArray.Length / 2; ++index)
                numArray[index] = (byte)((uint)SoapHexBinary.ToByte(charArray[index * 2], value) * 16U + (uint)SoapHexBinary.ToByte(charArray[index * 2 + 1], value));
            return numArray;
        }

        internal static string FilterBin64(string value)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int index = 0; index < value.Length; ++index)
            {
                if (value[index] != ' ' && value[index] != '\n' && value[index] != '\r')
                    stringBuilder.Append(value[index]);
            }
            return stringBuilder.ToString();
        }

        private static byte ToByte(char c, string value)
        {
            c.ToString();
            try
            {
                return byte.Parse(c.ToString(), NumberStyles.HexNumber, (IFormatProvider)CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                throw new Exception("Nope", ex);
            }
        }

    }
}