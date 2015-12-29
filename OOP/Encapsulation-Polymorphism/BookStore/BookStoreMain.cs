namespace BookStore
{
    using BookStore.Interfaces;
    using BookStore.UI;
    using Engine;

    public class BookStoreMain
    {
        public static void Main()
        {
            IRenderer renderer = new ConsoleRenderer();
            IInputHandler inputHandler = new ConsoleInputHandler();

            BookStoreEngine engine = new BookStoreEngine(renderer, inputHandler);

            engine.Run();
        }
    }
}
