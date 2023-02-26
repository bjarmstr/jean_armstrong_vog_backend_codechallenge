using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VogCodeChallenge.ConsoleApp
{
    public static class SWITCHModules
    {

        public static dynamic SWITCHModule(dynamic value)
        {
            switch (value)
            {
                case int oneToFour when oneToFour > 0 && oneToFour <= 4:
                    return oneToFour * 2;

                case int greaterThanFour when greaterThanFour > 4:
                    return greaterThanFour *3;

                case int below1 when below1 < 1 :
                    throw new Exception("Exception: value below 1");

                case float oneOrTwoFloat when oneOrTwoFloat == 1.0f || oneOrTwoFloat == 2.0f:
                    return 3.0f;

                case string stringValue:
                    return stringValue.ToUpper();

                default:
                    return value;
            }

        }

    }
}

