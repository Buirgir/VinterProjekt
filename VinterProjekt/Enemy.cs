class Enemy
{
    string enemyName;
    int _hp;
    int maxHp = 100;
    string[] possibleNames = ["Gorlock, Orclord, Zombie, Dwarf, BabyDragon, SnowGiant"];
    public void generateEnemy(Player Player)
    {
        int nameInt = Random.Shared.Next(possibleNames.Length);
        enemyName = possibleNames[nameInt];
        maxHp = maxHp * Math.Max(Player.getDefeatedEnemies(), 1);
    }

    public int Hp
    {
        get
        {
            return _hp;
        }
        set
        {
            _hp = Math.Max(value, 0);
        }
    }
    public string Name
    {
        get
        {
            return enemyName;
        }
    }
}