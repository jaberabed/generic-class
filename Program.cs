namespace FinalTest2
{
   internal class Program
   {
      private static void Main(string[] args)
      {
         Console.WriteLine("Hello, World!");
         ValueContainer<int> intContainer = new ValueContainer<int>();
         intContainer.AddItem(10);
         intContainer.AddItem(30);
         intContainer.AddItem(80);
         intContainer.AddItem(20);

         Console.WriteLine("Descending Collection");
         intContainer.DescendingCollection();
      }

      public class ValueContainer<T> where T : struct
      {
         public List<T> newList;

         public ValueContainer()
         {
            newList = new List<T>();
         }

         public void AddItem(T item)
         {
            newList.Add(item);
         }

         public List<T> DescendingCollection()
         {
            List<T> sortedList = newList.OrderByDescending(x => x).ToList();
            return sortedList;
         }
      }
   }
}