using FactoryMethod.Services.Interfaces;

namespace FactoryMethod.Services
{
    class WinCheckBox : ICheckBox
    {
        public string CreateCheckBox()
        {
            return "{Resultado CreateCheckBox WIN}";
        }
    }
}
