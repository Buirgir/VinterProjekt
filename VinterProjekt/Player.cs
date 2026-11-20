class Player
{
    string _userName;
    int _hp = 100;
    int _mp = 100;
    int maxHp = 100;
    int maxMp = 100;
    int defeatedEnemies;

    public int Hp
    {
        get
        {
            return _hp;
        }
        set
        {
            _hp = Math.Clamp(value, 0, maxHp);
        }
    }
    public int Mp
    {
        get
        {
            return _mp;
        }
        set
        {
            _mp = Math.Clamp(value, 0, maxMp);
        }
    }
    public int getDefeatedEnemies()
    {
        return defeatedEnemies;
    }

    public void IncreseDefeatedEnemies()
    {
        defeatedEnemies++;
    }
    public void RoundStart()
    {
        Mp = maxMp;
        Hp = maxHp;
    }
}