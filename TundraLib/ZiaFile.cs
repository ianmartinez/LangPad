using System;
using System.Collections.Generic;
using System.Drawing;

namespace TundraLib
{
    public static class ZiaFile
    {
        public enum LineType
        {
            Comment,
            KeyValue,
            Blank
        }
        public struct ZiaLine
        {
            public LineType LineType;
            public string Key;
            public string Value;
            public ZiaLine(LineType _LineType, string _Key = "", string _Value = "")
            {
                LineType = _LineType;
                Key = _Key;
                Value = _Value;
            }
        }

        public static Dictionary<string, Dictionary<string, string>> ReadSectioned(string Data)
        {
            ;/* Cannot convert OnErrorResumeNextStatementSyntax, CONVERSION ERROR: Conversion for OnErrorResumeNextStatement not implemented, please report this issue in 'On Error Resume Next' at character 620
   at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.MethodBodyVisitor.DefaultVisit(SyntaxNode node)
   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitOnErrorResumeNextStatement(OnErrorResumeNextStatementSyntax node)
   at Microsoft.CodeAnalysis.VisualBasic.Syntax.OnErrorResumeNextStatementSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
   at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.ConvertWithTrivia(SyntaxNode node)
   at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node)

Input: 
        On Error Resume Next

 */
            string[] Sections = Data.Split(new string[] { "[" }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, Dictionary<string, string>> TemporaryDictionary = new Dictionary<string, Dictionary<string, string>>();
            foreach (string Section in Sections)
                TemporaryDictionary.Add(Section.Split('\n')[0].ToString().Remove(Section.Split('\n')[0].ToString().Length - 1, 1), Read(Section));
            return TemporaryDictionary;
        }

        public static Dictionary<string, string> Read(string Data)
        {
            ;/* Cannot convert OnErrorResumeNextStatementSyntax, CONVERSION ERROR: Conversion for OnErrorResumeNextStatement not implemented, please report this issue in 'On Error Resume Next' at character 1195
   at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.MethodBodyVisitor.DefaultVisit(SyntaxNode node)
   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitOnErrorResumeNextStatement(OnErrorResumeNextStatementSyntax node)
   at Microsoft.CodeAnalysis.VisualBasic.Syntax.OnErrorResumeNextStatementSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
   at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.ConvertWithTrivia(SyntaxNode node)
   at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node)

Input: 
        On Error Resume Next

 */
            string[] Lines = Data.Split(new string[] { Environment.NewLine, "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, string> TemporaryDictionary = new Dictionary<string, string>();
            foreach (string Line in Lines)
            {
                if (Line.StartsWith("!"))
                    continue;
                if (Line.StartsWith("#"))
                    continue;
                if (!Line.Contains("="))
                    continue;
                TemporaryDictionary.Add(FromCompatibleString(Line.Split('=')[0]), FromCompatibleString(Line.Split('=')[1]));
            }
            return TemporaryDictionary;
        }

        public static string Write(List<ZiaLine> Source, bool MakeCompatible = false)
        {
            string RString = "";
            foreach (ZiaLine Line in Source)
            {
                if (Line.LineType == LineType.Comment)
                    RString = RString.Insert(RString.Length, string.Format("#{0}", Line.Key));
                else if (Line.LineType == LineType.KeyValue)
                {
                    if (MakeCompatible == true)
                        RString = RString.Insert(RString.Length, string.Format("{0}={1}", Line.Key, ToCompatibleString(Line.Value)));
                    else
                        RString = RString.Insert(RString.Length, string.Format("{0}={1}", Line.Key, Line.Value));
                }
                else
                {
                }
                RString = RString.Insert(RString.Length, Environment.NewLine);
            }
            return RString;
        }

        public static string SearchSectioned(Dictionary<string, Dictionary<string, string>> Data, string LookupSection, string LookupKey)
        {
            foreach (KeyValuePair<string, Dictionary<string, string>> CurrentSection in Data)
            {
                if (!(CurrentSection.Key == LookupSection))
                    continue;
                return Search(CurrentSection.Value, LookupKey);
            }

            return null;
        }

        public static string Search(Dictionary<string, string> Data, string Lookup)
        {
            return Data[Lookup];
        }

        public static string GetValue(string Data, string Lookup)
        {
            return Search(Read(Data), Lookup);
        }

        public static string ToCompatibleString(string Source)
        {
            Source = Source.Replace("=", ":eq:");
            Source = Source.Replace("|", ":pi:");
            Source = Source.Replace(",", ":co:");
            Source = Source.Replace(Environment.NewLine, ":cr:");
            Source = Source.Replace("\r\n", ":cr:");
            Source = Source.Replace("\n", ":cr:");
            Source = Source.Replace("\r", ":cr:");
            return Source;
        }

        public static string ToCompatibleColor(Color Source)
        {
            if (Source == Color.Transparent)
                return "$0";
            else if (Source == Color.White)
                return "$1";
            else if (Source == Color.Black)
                return "$2";
            else
                return string.Format("{0},{1},{2},{3}", Source.A, Source.R, Source.G, Source.B);
        }

        public static string ToCompatibleDoubleList(double[] Source)
        {
            string CompatibleDoubleList = "";
            foreach (double _Double in Source)
                CompatibleDoubleList = CompatibleDoubleList + _Double + '|';
            return CompatibleDoubleList;
        }

        public static string ToCompatibleStringList(List<string> Source)
        {
            string CompatibleDoubleList = "";
            foreach (string _String in Source)
            {
                if (_String == "")
                    continue;
                if (_String == " ")
                    continue;
                CompatibleDoubleList = CompatibleDoubleList + _String + '|';
            }
            return CompatibleDoubleList;
        }

        public static string ToCompatibleColorList(Color[] Source)
        {
            string CompatibleDoubleList = "";
            foreach (Color _Color in Source)
                CompatibleDoubleList = CompatibleDoubleList + ToCompatibleColor(_Color) + '|';
            return CompatibleDoubleList;
        }

        public static string ToCompatibleFont(Font Source)
        {
            return string.Format("{0}|{1}|{2}", Source.Name, Source.Size, Source.Style);
        }

        public static string FromCompatibleString(string Source)
        {
            Source = Source.Replace(":eq:", "=");
            Source = Source.Replace(":pi:", "|");
            Source = Source.Replace(":co:", ",");
            Source = Source.Replace(":cr:", Environment.NewLine);
            return Source;
        }

        public static Color[] FromCompatibleColorList(string Source)
        {
            List<Color> TempararyColors = new List<Color>();
            string[] SplitColors = Source.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string ThisColor in SplitColors)
            {
                if (ThisColor == null)
                    return null;
                if (char.IsWhiteSpace(ThisColor[1]) == true)
                    return null;
                TempararyColors.Add(FromCompatibleColor(ThisColor));
            }
            return TempararyColors.ToArray();
        }

        public static int[] FromCompatibleIntegerList(string Source)
        {
            List<int> TempararyIntegers = new List<int>();
            string[] SplitIntegers = Source.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string ThisInteger in SplitIntegers)
            {
                if (ThisInteger == null)
                    return null;
                if (char.IsWhiteSpace(ThisInteger[1]) == true)
                    return null;
                TempararyIntegers.Add(int.Parse(ThisInteger));
            }
            return TempararyIntegers.ToArray();
        }

        public static double[] FromCompatibleDoubleList(string Source)
        {
            List<double> TempararyDoubles = new List<double>();
            string[] SplitDoubles = Source.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
            if (SplitDoubles.Length == 0)
                return null;
            foreach (string ThisDouble in SplitDoubles)
            {
                if (ThisDouble == null)
                    return null;
                if (ThisDouble == "")
                    return null;
                if (ThisDouble == " ")
                    return null;
                TempararyDoubles.Add(double.Parse(ThisDouble));
            }

            return TempararyDoubles.ToArray();
        }

        public static Color FromCompatibleColor(string Source)
        {
            if (Source.Split(',').Length == 4)
                return Color.FromArgb(int.Parse(Source.Split(',')[0]), int.Parse(Source.Split(',')[1]), int.Parse(Source.Split(',')[2]), int.Parse(Source.Split(',')[3]));
            else if (Source.Split(',').Length == 3)
                return Color.FromArgb(int.Parse(Source.Split(',')[0]), int.Parse(Source.Split(',')[1]), int.Parse(Source.Split(',')[2]));
            else if (Source.StartsWith("#"))
                return ColorTranslator.FromHtml(Source);
            else if (Source.StartsWith("~"))
            {
                int black = int.Parse(Source.Remove(0, 1));
                return Color.FromArgb(black, black, black);
            }
            else if (Source == "$NULL")
                return Color.Transparent;
            else if (Source == "$0")
                return Color.Transparent;
            else if (Source == "$1")
                return Color.White;
            else if (Source == "$2")
                return Color.Black;
            else
                return Color.Transparent;
        }

        public static Font FromCompatibleFont(string Source)
        {
            string _Name = Source.Split('|')[0];
            float _Size = (float.Parse(Source.Split('|')[1]));
            FontStyle _FontStyle = (FontStyle)Enum.Parse(typeof(FontStyle), Source.Split('|')[2]);
            return new Font(_Name, _Size, _FontStyle);
        }
        public static Point FromCompatiblePoint(string Source)
        {
            Source = Source.Remove(0, 1);
            Source = Source.Remove(Source.Length - 1, 1);
            return new Point(int.Parse(Source.Split(',')[0]), int.Parse(Source.Split(',')[1]));
        }
    }
}