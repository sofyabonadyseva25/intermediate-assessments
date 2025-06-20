int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
void F (int m,int n)
{
    if (m !=  n)
    {
        if(m > n)
        {
            F(m - 1, n);
            System.Console.Write(m + " ");
        }
        else
        {
            F(m + 1, n);
            System.Console.Write(m + " ");
        }
    }
    else
    {
        Console.Write(m + " ");

    }
   
}
F(m, n);
