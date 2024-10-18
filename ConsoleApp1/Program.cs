namespace ConsoleApp1
{
    class CurrentTime {
        public int Number = 0;
        public DateTime NowTime;
        public void GetNumber()
        {
            Number++;
        }

        public void OutNumber()
        {
            Console.WriteLine("현재 순서는 " + Number);
        }

        public void GetTime()
        {
            NowTime = DateTime.Now; 
        }

        public void OutTime()
        {
            Console.WriteLine("현재 시각은 " + NowTime);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CurrentTime currentTime = new CurrentTime();
            for (int i = 0; i < 100; i++)
            {
                currentTime.GetNumber();
                currentTime.OutNumber();

                currentTime.GetTime();
                currentTime.OutTime();
                System.Threading.Thread.Sleep(1000);
            }
        }
    }

}