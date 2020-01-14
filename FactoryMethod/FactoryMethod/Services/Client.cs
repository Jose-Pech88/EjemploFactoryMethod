using FactoryMethod.Services.Factory;
using System;

namespace FactoryMethod.Services
{
    class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Cargando WinFactory.");
            ClientCodeButton(new WinFactory());

            Console.WriteLine("");

            Console.WriteLine("App: Cargando MacFactory.");
            ClientCodeButton(new MacFactory());

            Console.WriteLine("__________________________________________________________");

            Console.WriteLine("App: Cargando WinFactory.");
            ClientCodeCheck(new WinFactory());

            Console.WriteLine("");

            Console.WriteLine("App: Cargando MacFactory.");
            ClientCodeCheck(new MacFactory());

            Console.ReadKey();
        }

        // The client code works with an instance of a concrete creator, albeit
        // through its base interface. As long as the client keeps working with
        // the creator via the base interface, you can pass it any creator's
        // subclass.
        public void ClientCodeButton(GUIFactory creator)
        {
            // ...
            Console.WriteLine("Client: I'm not aware of the creator's class," +
                "but it still works.\n" + creator.FactoryMethodButton());
            // ...
        }

        public void ClientCodeCheck(GUIFactory creator)
        {
            // ...
            Console.WriteLine("Client: I'm not aware of the creator's class," +
                "but it still works.\n" + creator.FactoryMethodCheck());
            // ...
        }
    }
}
