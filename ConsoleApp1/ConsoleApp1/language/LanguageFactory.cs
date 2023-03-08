using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.language
{
    class LanguageFactory
    {
        public ILanguage getLanguage(int languageId)
        {
            switch (languageId)
            {
                case 1:
                    return new Language1();
                    break;
                case 2:
                    return new Language2();
                    break;
            }
            return null;
        }
    }
}
