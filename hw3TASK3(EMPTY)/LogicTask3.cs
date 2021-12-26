public class LogicTask3
{
    int num1;
    int num2;
    public LogicTask3 Plus(LogicTask3 RACIO)
    {
        LogicTask3 res = new LogicTask3();
        res.num1 = this.num1 * RACIO.num2 + RACIO.num1 * this.num2;
        res.num2 = this.num2 * RACIO.num2;
        return res;
    }
    public LogicTask3 Minus(LogicTask3 RACIO)
    {
        LogicTask3 res = new LogicTask3();
        res.num1 = this.num1 * RACIO.num2 - RACIO.num1 * this.num2;
        res.num2 = this.num2 * RACIO.num2;
        return res;
    }
    public LogicTask3 Multiply(LogicTask3 RACIO)
    {
        LogicTask3 res = new LogicTask3();
        res.num1 = this.num1 * RACIO.num1;
        res.num2 = this.num2 * RACIO.num2;
        return res;
    }
    public LogicTask3 Division(LogicTask3 RACIO)
    {
        LogicTask3 res = new LogicTask3();
        res.num1 = this.num1 * RACIO.num2;
        res.num2 = this.num2 * RACIO.num1;
        return res;
    }

    public int variableA
    {
        get
        {
            return num1;
        }
        set
        {
            num1 = value;
        }
    }

    public int variableB
    {
        get
        {
            return num2;
        }
        set
        {
            if (value != 0)
                num2 = value;
            else throw new ArgumentException("Знаменатель не может быть равен 0!");
        }
    }

    public double Decimal
    {
        get
        {
            return (double)num1 / num2;
        }
    }

    int FindNOD(int x1, int x2)
    {
        int res = 1;
        for (int i = 2; i <= (x1 < x2 ? x1 : x2); i++)
        {
            if (x1 % i == 0 && x2 % i == 0)
                res = i;
        }
        return res;
    }

    public void Simplification()
    {
        int NOD = FindNOD(this.num1, this.num2);
        this.num1 = this.num1 / NOD;
        this.num2 = this.num2 / NOD;
    }
}