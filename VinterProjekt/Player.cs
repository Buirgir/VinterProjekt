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
            _hp = Math.Max(value, 0);
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
            _mp = Math.Max(value, 0);
        }
    }
    public int getDefeatedEnemies()
    {
        return defeatedEnemies;
    }
}