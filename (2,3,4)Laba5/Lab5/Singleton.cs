using System.Drawing;

namespace Lab5
{
    public class Singleton
    {
        private static Singleton instance;

        public Color BackColor { get; private set; }

        protected Singleton(Color color)
        {
            this.BackColor = color;
        }

        public static Singleton getInstance(Color color)
        {
            if (instance == null)
                instance = new Singleton(color);
            return instance;
        }
    }
}
