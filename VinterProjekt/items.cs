using System.Linq.Expressions;

class Item
{
    protected string _name = "Null";
    protected string rarity = "Null";
    protected float rarityMulti = 1;

    public string Name
    {
        get
        {
            return _name;
        }
    }
    public void RarityGen()
    {
        int rarityInt = Random.Shared.Next(1, 100);
        if(rarityInt <= 60)
        {
            rarity = "Common";
            rarityMulti = 1;
        }
        else if(rarityInt >60 && rarityInt <= 80)
        {
            rarity = "Rare";
            rarityMulti = 1.2f;
        }
        else if(rarityInt > 80 && rarityInt <= 95)
        {
            rarity = "Epic";
            rarityMulti = 1.5f;
        }
        else if(rarityInt > 95)
        {
            rarity = "Epic";
            rarityMulti = 3;
        }
        else
        {
            rarity = "Common";
            rarityMulti = 1;
        }
    }
}

class Weapon : Item
{
    int _baseDamage;
    string _element;

    public int BaseDamage
    {
        get
        {
            return _baseDamage;
        }
    }
    public string Element
    {
        get
        {
            return _element;
        }
    }

    public void generateWeapon()
    {
        string[] possibleNames = ["Axe", "Sword", "Greatsword", "Greataxe", "Gun", "Rifle"];
        string[] possibleElements = ["Electric", "Flaming", "Frozen", "Normal", "Earth"];
        _element = possibleElements[Random.Shared.Next(possibleElements.Length)];
        RarityGen();
        _name = rarity + _element + possibleNames[Random.Shared.Next(possibleNames.Length)];
        _baseDamage = Convert.ToInt32(Random.Shared.Next(5, 20) * rarityMulti);
    }    
}

class Armour : Item
{
    int _defence;
    int _attackboost;
    int _manaBoost;

    public int Defence
    {
        get
        {
            return _defence;
        }
    }
    public int AttackBoost
    {
        get
        {
            return _attackboost;
        }
    }
    public int ManaBoost
    {
        get
        {
            return _manaBoost;
        }
    }

    public void generateArmour()
    {
        string[] possibleNames = ["Warrior's chestplate", "Iron chestplate", "Mage's robe"];
        string[] possibleElements = ["Electric", "Flaming", "Frozen", "Normal", "Earth"];
        RarityGen();

        _name = rarity + possibleNames[Random.Shared.Next(possibleNames.Length)];
        _defence = Convert.ToInt32(Random.Shared.Next(7) * rarityMulti);
        _attackboost = Convert.ToInt32(Random.Shared.Next(5) * rarityMulti);
        _manaBoost = Convert.ToInt32(Random.Shared.Next(80) * rarityMulti);

    }    
}