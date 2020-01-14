using FactoryMethod.Services.Interfaces;

namespace FactoryMethod.Services.Factory
{
    class MacFactory : GUIFactory
    {
        public override IButton FactoryMethodButton()
        {
            return new MacButton();
        }
        public override ICheckBox FactoryMethodCheck()
        {
            return new MacCheckBox();
        }
    }
}
