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
    public void PrintItemStats(int slot)
    {
        if(items[slot] is Weapon w)
        {
            Console.WriteLine($"Inspected weapon name is {w.Name}");
            Console.WriteLine($"Inspected weapon damage is {w.BaseDamage}");
            Console.WriteLine($"Inspected weapon element is {w.Element}");
            Console.WriteLine("--------------------------------------");
            for (int i = 0; i < equippedItems.Count; i++)
            {
                if(equippedItems[i] is Weapon ww)
                {
                    Console.WriteLine($"Equipped weapon name is {ww.Name}");
                    Console.WriteLine($"Equipped weapon damage is {ww.BaseDamage}");
                    Console.WriteLine($"Equipped weapon element is {ww.Element}");
                }
            }
        }
        if(items[slot] is Armour a)
        {
            Console.WriteLine($"Inspected Armour name is {a.Name}");
            Console.WriteLine($"Inspected Armour defence is {a.Defence}");
            Console.WriteLine($"Inspected Armour attack boost is {a.AttackBoost}");
            Console.WriteLine($"Inspected Armour mana boost is {a.ManaBoost}");
            Console.WriteLine("--------------------------------------");
            for (int i = 0; i < equippedItems.Count; i++)
            {
                if(equippedItems[i] is Armour aa)
                {
                    Console.WriteLine($"Equipped Armour name is {aa.Name}");
                    Console.WriteLine($"Equipped Armour Defence is {aa.Defence}");
                    Console.WriteLine($"Equipped Armour attack boost is {aa.AttackBoost}");
                    Console.WriteLine($"Equipped Armour mana boost is {aa.ManaBoost}");
                }
            }
        }
    }
}