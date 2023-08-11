using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD.StepDefinitions
{
    [Binding]
    internal class hooks
    {
        [BeforeScenario]
        public static void BeforeScenario()
        {
            Console.WriteLine("Hooks:before every scenario**************");
        }
        [AfterScenario]
        public static void AfterScenario()
        {
            Console.WriteLine("Hooks:After every scenario***************");
        }
        [BeforeFeature]
        public static void BFeature()
        {
            Console.WriteLine("Hooks:Before feature==========");
        }
        [AfterFeature]
        public static void AFeature()
        {
            Console.WriteLine("Hooks:After feature==========");
        }

    }
}
