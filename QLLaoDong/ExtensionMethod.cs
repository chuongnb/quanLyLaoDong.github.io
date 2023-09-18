using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace QLLaoDong
{
    public static class ExtensionMethod
    {
        public static Boolean NameCheck(this String s)
        {
            return Regex.Match(s, @"^([A-Z][a-zA-Z]+(\s[A-Z][a-zA-Z]+)*)$").Success;
        }
        public static Boolean FulNameCheckCuaTui(this String s)
        {
            return Regex.Match(s, @"^([A-Z][a-zA-Z]+(\s[A-Z][a-zA-Z]+)+)$").Success;
        }
        public static Boolean EmailCheck(this String s)
        {
            return Regex.Match(s, @"^(\w+@\w+([.][a-zA-Z]+){1,4})$").Success;
            
        }

        public static Boolean PhoneCheck(this String s)
        {
            return Regex.Match(s, @"^([0][0-9]{2}-)?([1-9]\d{7})$").Success;
        }

        public static string LTrim(this string s)
        {
           
            int i = 0;
            while (s[i] == ' ')
            {
                i++;
            }
            s = s.Substring(i);
            return s;
        }
        
        public static string LTrim1(this string s)
        {
       
            while (Regex.Match(s, @"^\s+").Success)
                s = s.Substring(1);
            return s;
        }
        public static string RTrim(this string s)
        {
          
            int i = s.Length - 1;
            while (s[i] == ' ')
            {
                i--;
            }
            s = s.Substring(0, i + 1);
            return s;
        }

        public static string MTrim(this string s)
        {
         
            while (s.IndexOf("  ") >= 0)
            {
                s = s.Replace("  ", " ");
            }
            return s;
        }
        public static string MTrim1(this string s)
        {
            
            while (s.Contains("  "))
            {
                s = s.Replace("  ", " ");
            }
            return s;
        }
        public static string MTrim2(this string s)
        {
        
            while (Regex.Match(s, "  ").Success)
            {
                s = s.Replace("  ", " ");
            }
            return s;
        }
        public static String PerfectString(this String s)
        {
            //s = s.LTrim();
            //s = s.MTrim();
            //s = s.RTrim();
            s = s.LTrim().MTrim().RTrim();
            s = " " + s;
            s = s.ToLower();//" le tan dung" 
            foreach (Match item in Regex.Matches(s, @"\s\S"))
            {
                s = s.Replace(item.Value, item.Value.ToUpper());
            }
            // hoa dau moi tu
            //" Le Tan Dung" 
            return s.Substring(1, 4);
        }
        public static int TinhTong(this int a, int b)
        {

            return a + b;
        }
        public static string FirstWord(this string s)
        {
            //s="Le Thi Tu"
            if (s != null && s.Length > 0)
            {
                //tach chuoi theo chuan 
                String[] list = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                return list[0];
            }
            return null;
        }
        public static String LastWordCuaTui(this string s)
        {
            if (s != null && s.Length > 0)
            {
                String[] list = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                return list[list.Length - 1];
            }
            return null;
        }
        public static int WordCount1(this string s)
        {
            if (s != null && s.Length > 0)
            {
                String[] list = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                return list.Length;
            }

            return 0;
        }
        public static int WordCount2(this string s)
        {
            s = s.PerfectString();
            s = s + " ";//Le Tan Dung "
                        //@"\s+\S*"=>nhieu ky tu khoang trang theo sau la 1 hoac nhieu ky tu
                        // MatchCollection temp = Regex.Matches(s, @"\S+\s");
            MatchCollection temp = Regex.Matches(s, @"\s+\S*");
            return temp.Count;

        }
    }
}
