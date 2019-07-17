namespace TheMall
{
    //using a generic type so it can be whatever I specify. In this case, 
    public interface IStorable<TItem>
    {
        void AddToInventory(string name, TItem item);

        TItem GetFromInventory(string name);
    }
}