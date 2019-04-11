using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateSamples.Commons
{
    public class RegexText
    {
        public const string EMAIL_ADDRESS = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                               @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

        public const string USERNAME = @"^[a-zA-Z][a-zA-Z0-9]{2,19}$";

        //public const string UsernameOrEmailAddressRegex = @"^(([a-zA-Z][a-zA-Z0-9]{2,19})" +
        //                               @"|(([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
        //                               @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
        //                                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)))$";

        //tecnical debt: "I don't know the regex text for vietnamese"
        public const string VIETNAMESE = @"^[a-zA-Záàảãạăắằẳẵặâấầẩẫậéèẻẽẹêếềểễệđíìỉĩị" +
                                              @"óòỏõọôốồổỗộơớờởỡợúùủũụưứừửữự" +
                                              @"ÁÀẢÃẠĂẮẰẲẴẶÂẤẦẨẪẬÉÈẺẼẸÊẾỀỂỄỆĐÍÌỈĨỊ" +
                                              @"ÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢÚÙỦŨỤƯỨỪỬỮỰ \'.-]+$";
    }
}
