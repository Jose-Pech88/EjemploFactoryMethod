using FactoryMethod.Services.Interfaces;

namespace FactoryMethod.Services
{
    class MacCheckBox : ICheckBox
    {
        public string CreateCheckBox()
        {
            return "{Resultado CreateCheckBox WIN}";
        }
    }
}
