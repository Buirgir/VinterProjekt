class Inventory
{
    List<Item> items;
    List<Item> equippedItems;

    public void PrintItems()
    {
        Console.WriteLine("Inventory:");
        for (int i = 0; i < items.Count; i++)
        {
            Console.WriteLine($"{i}.{items[i].Name}");
        }
    }
    public void PrintEquippedItems()
    {
        Console.WriteLine("Equipped items:");
        for (int i = 0; i < items.Count; i++)
        {
            Console.WriteLine($"{i}.{equippedItems[i].Name}");
        }
    }
    public void equipItem(int slot)
    {
        Item chosenItem = items[slot];
        if(chosenItem is Weapon)
        {
            for (int i = 0; i < equippedItems.Count; i++)
            {
                if(equippedItems[i] is Weapon)
                {
                    items.Add(equippedItems[i]);
                    equippedItems.RemoveAt(i);
                    equippedItems.Add(chosenItem);
                }
            }
        }
        else if(chosenItem is Armour)
        {
            for (int i = 0; i < equippedItems.Count; i++)
            {
                if(equippedItems[i] is Armour)
                {
                    items.Add(equippedItems[i]);
                    equippedItems.RemoveAt(i);
                    equippedItems.Add(chosenItem);
                }
            }
        }
    }
}