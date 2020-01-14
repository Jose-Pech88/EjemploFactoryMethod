using FactoryMethod.Services.Interfaces;

namespace FactoryMethod.Services.Factory
{
    abstract class GUIFactory
    {
        // Note that the Creator may also provide some default implementation of
        // the factory method.
        public abstract IButton FactoryMethodButton();

        public abstract ICheckBox FactoryMethodCheck();

        // Also note that, despite its name, the Creator's primary
        // responsibility is not creating products. Usually, it contains some
        // core business logic that relies on Product objects, returned by the
        // factory method. Subclasses can indirectly change that business logic
        // by overriding the factory method and returning a different type of
        // product from it.
        public string SomeOperationButtom()
        {
            // Call the factory method to create a Product object.
            var button = FactoryMethodButton();
            // Now, use the product.
            var result = "Creator: The same creator's code has just worked with "
                + button.CreateButton();

            return result;
        }

        public string SomeOperationCheck()
        {
            // Call the factory method to create a Product object.
            var button = FactoryMethodCheck();
            // Now, use the product.
            var result = "Creator: The same creator's code has just worked with "
                + button.CreateCheckBox();

            return result;
        }
    }
}
