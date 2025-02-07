using Demo4.Fifa;
using Demo4.Youtupe;
using System.Collections;

namespace Demo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Non-Generic HashTable
            //Hashtable hashtable = new Hashtable();

            //hashtable.Add("Ahmed", "112233");
            //hashtable.Add("Mohamed", "445566");
            //hashtable.Add("Ali", "778899");
            //hashtable.Add("Sayed", "123456");
            //hashtable.Add("Khaled", "987654");
            //hashtable.Add("Mahmoud", "654321");

            //Console.WriteLine(hashtable.IsFixedSize);

            //Console.WriteLine();
            //Console.WriteLine("============================");

            //foreach (DictionaryEntry item in hashtable)
            //{
            //    System.Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            //}

            //foreach(var key in hashtable.Keys)
            //{
            //    System.Console.WriteLine($"Key: {key}");
            //}

            //Console.WriteLine();
            //Console.WriteLine("====================");
            //Console.WriteLine();

            //foreach (var Value in hashtable.Values)
            //{
            //    System.Console.WriteLine($"Value: {Value}");
            //}

            //Console.WriteLine(hashtable["Ahmed"]);

            //Console.WriteLine(hashtable["Ahmeeeed"]);

            //hashtable["Ahmed"] = 147852;

            //Console.WriteLine(hashtable["Ahmed"]);

            //Console.WriteLine(hashtable.Contains("Ahmed"));

            //    hashtable.Remove("Sayed");

            //    foreach (DictionaryEntry item in hashtable)
            //    {
            //        System.Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            //    } 
            #endregion

            #region Generic-Collection Dictionary
            //Dictionary<string, long> PhoneBook = new Dictionary<string, long>();

            //PhoneBook.Add("Ahmed", 112233);
            //PhoneBook.Add("Mohamed", 445566);
            //PhoneBook.Add("Ali", 778899);
            //PhoneBook.Add("Sayed", 123456);
            //PhoneBook.Add("Khaled", 987654);
            //PhoneBook.Add("Mahmoud", 654321);

            //bool flag=PhoneBook.Remove("Sayed",out long Res);
            //System.Console.WriteLine(flag);
            //System.Console.WriteLine(Res);

            //bool flag = PhoneBook.TryGetValue("Sayed", out long Res);
            //System.Console.WriteLine(flag);
            //System.Console.WriteLine(Res);

            //foreach (KeyValuePair<string, long> pair in PhoneBook)
            //{
            //    Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
            //} 
            #endregion

            #region Generic-Collection HashSet
            //HashSet<string> Names= new HashSet<string>();
            //Names.Add("Ahmed");
            //Names.Add("Mohamed");
            //Names.Add("Ali");
            //Names.Add("Sayed");
            //Names.Add("Khaled");
            //Names.Add("Mahmoud");

            //foreach (var item in Names)
            //{
            //    System.Console.WriteLine(item);
            //} 
            #endregion

            #region Generic-Collection Sorted Dictionary
            //SortedDictionary<int,string> Names = new SortedDictionary<int, string>();

            //Names.Add(5, "Ahmed");
            //Names.Add(3, "Mohamed");
            //Names.Add(1, "Ali");
            //Names.Add(4, "Sayed");
            //Names.Add(2, "Khaled");
            //Names.Add(6, "Mahmoud");

            //foreach (var item in Names)
            //{
            //    System.Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            //} 
            #endregion

            #region Generic-Collection SortedList & SortedSet
            //SortedList<int, string> pairs = new SortedList<int, string>();

            ////pairs.Add(5, "Ahmed");
            //pairs.SetValueAtIndex(5, "Ahmed");

            //SortedSet<int> numbers = new SortedSet<int>();

            //numbers.Add(5);
            //numbers.Add(3);
            //numbers.Add(1); 
            #endregion

            #region Event EX01
            //Ball ball = new Ball() { Id = 1 };

            //ball.Location = new Location() { X = 10, Y = 20, Z = 30 };

            //Console.WriteLine(ball);

            //Player P01 =new Player() { Name = "Cristiano", TeamName = "Madrid" };
            //Player P02=new Player() { Name = "Messi", TeamName = "Barcelona" };

            //Player P03=new Player() { Name = "Benzema", TeamName = "Madrid" };
            //Player P04=new Player() { Name = "Neymar", TeamName = "Barcelona" };

            //Referee R01 = new Referee() { Name = "John" };

            //Coach C01 = new Coach() { Name = "Zidane", TeamName = "Madrid" };

            //ball.BallLocationChange= P01.Run;
            //ball.BallLocationChange += P02.Run;
            //ball.BallLocationChange += P03.Run;
            //ball.BallLocationChange += P04.Run;
            //ball.BallLocationChange += R01.Look;
            //ball.BallLocationChange += R01.Look;
            //ball.BallLocationChange += C01.Order;


            //ball.Location = new Location() { X = 10, Y = 20, Z = 30 };
            //Console.WriteLine(ball); 
            #endregion

            #region Event EX02

            //Channel channel = new Channel() { Title = "National Geographic" };

            //channel.AddVideo(new Videos() { Title = "The Secret Of The Pyramids" });

            //Subscriper S01 = new Subscriper() { Name = "Ahmed" };
            //Subscriper S02 = new Subscriper() { Name = "Mohamed" };
            //Subscriper S03 = new Subscriper() { Name = "Ali" };
            //Subscriper S04 = new Subscriper() { Name = "Omar" };


            //channel.UploadVideo += S01.Notify;
            //channel.UploadVideo += S02.Notify;
            //channel.UploadVideo += S03.Notify;

            //channel.AddVideo(new Videos() { Title = "The Secret Of Nature" });

            //Console.WriteLine();
            //Console.WriteLine("After Mohamed UnSubscripe");
            //Console.WriteLine();

            //channel.UploadVideo -= S02.Notify;
            //channel.UploadVideo += S04.Notify;

            //channel.AddVideo(new Videos() { Title = "The Secret Of Water In Forests" }); 
            #endregion


        }
    }
}
