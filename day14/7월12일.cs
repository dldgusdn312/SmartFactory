```
<Quiz1>
namespace OOPdelegateApp
{
    class Station
    {
        public string Policestation()
        {
            return "경찰서에 신고하다";
        }
        public string Firestaion()
        {
            return "소방서에 신고하다";
        }
        public string Tax()
        {
            return "국세청에 신고하다";
        }
    }

    internal class Program
    {
        delegate string Report();
        static void Main(string[] args)

        {
            Station st = new Station();
            Report report = st.Policestation;
            Console.WriteLine(report());
            report = st.Firestaion;
            Console.WriteLine(report());
            report = st.Tax;
            Console.WriteLine(report());
        }
    }
}
```
```
