using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns
{
    public enum BrandType {
        Nokia
    }
    public class AbstractFactory
    {
        public static IBrand Initialize(BrandType brand)
        {
            switch (brand)
            {
                case BrandType.Nokia:
                    return new Nokia();
                default:
                    return null;
            }
        }
    }

    public interface IBrand
    {
        IMobile GetSmartPhone();

        IMobile GetNormalPhone();
    }

    public interface IMobile
    {
        string GetModelSpecification();
    }

    public class Nokia : IBrand
    {
        public IMobile GetNormalPhone()
        {
            return new Nokia1100();
        }

        public IMobile GetSmartPhone()
        {
            return new NokiaLumia();
        }
    }

    public class Nokia1100 : IMobile
    {
        public string GetModelSpecification()
        {
            return "Nokia 1100 specification list";
        }
    }

    public class NokiaLumia : IMobile
    {
       

        public string GetModelSpecification()
        {
            return "Nokia Lumia specification list";
        }
    }
}
