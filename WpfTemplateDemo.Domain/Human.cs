namespace WpfTemplateDemo.Domain
{
    public class Human
    {
        private int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 0 && value < 100)
                {
                    age = value;
                }
            }
        }
    }
}