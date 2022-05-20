using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.International.Converters.PinYinConverter;

namespace BNR.Core
{
    /// <summary>
    /// {CN:广州}
    /// </summary>
    [ParameterType("CN")]
    public class ChineseSpellCodeParameter : IParameterHandler
    {
        public void Execute(StringBuilder sb, string value)
        {

            foreach (char item in value)
            {
                var sp = FirstPinYin(item.ToString());
             //   sb.Append(PinYin.GetFirst(item.ToString()));
                sb.Append(sp);
            }

        }
        /// <summary>
        /// 汉字转首拼
        /// </summary>
        /// <param name="chinese">汉字</param>
        /// <returns></returns>
        public  string FirstPinYin(string chinese)
        {
            string retValue = string.Empty;

            foreach (char chr in chinese)
            {
                try
                {
                    if (ChineseChar.IsValidChar(chr))
                    {
                        ChineseChar chineseChar = new ChineseChar(chr);
                        string t = chineseChar.Pinyins[0].ToString();
                        retValue += t.Substring(0, 1);
                    }
                    else
                    {
                        retValue += chr.ToString();
                    }
                }
                catch (Exception e)
                {
                    return "Z";
                }
            }

            return retValue;
        }


        public BNRFactory Factory
        {
            get;
            set;
        }
    }
}
