using System.Linq.Expressions;

class Item
{
    string _name;
    int rarity;

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if(value != null)
            {
                _name = value;
            }
            else
            {
                _name = "NoName";
            }
        }
    }
}

class Weapon : Item
{
    int baseDamage;
    string element;

    public void generateWeapon()
    {
        string[] possibleNames = ["Axe", "Sword", "Greatsword", "Greataxe", "Gun", "Rifle"];
        string[] possibleElements = ["Electric", "Flaming", "Frozen", "Normal", "Earth"];
        element = possibleElements[Random.Shared.Next(possibleElements.Length)];
        Name = possibleNames[Random.Shared.Next(possibleNames.Length)] + element;
        int baseDamage = Random.Shared.Next(5, 20);
    }    
}

class Armour : Item
{
    int baseDamage;
    string element;

    public void generateWeapon()
    {
        string[] possibleNames = ["Warrior's chestplate", "", "Mage's robe", "", "Gun", "Rifle"];
        string[] possibleElements = ["Electric", "Flaming", "Frozen", "Normal", "Earth"];
        Name = possibleNames[Random.Shared.Next(possibleNames.Length)];
        element = possibleElements[Random.Shared.Next(possibleElements.Length)];
        int baseDamage = Random.Shared.Next(5, 20);
    }    
}