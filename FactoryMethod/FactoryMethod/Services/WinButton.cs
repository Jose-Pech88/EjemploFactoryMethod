using FactoryMethod.Services.Interfaces;

namespace FactoryMethod.Services
{
    // Concrete Products provide various implementations of the Product
    // interface.
    public class WinButton : IButton
    {
        public string CreateButton()
        {
            return "{Resultado CreateButton WIN}";
        }
    }
}
