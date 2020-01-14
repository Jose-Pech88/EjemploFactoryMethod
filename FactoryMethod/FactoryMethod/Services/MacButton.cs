using FactoryMethod.Services.Interfaces;

namespace FactoryMethod.Services
{
    public class MacButton : IButton
    {
        public string CreateButton()
        {
            return "{Resultado CreateButton MAC}";
        }
    }
}
