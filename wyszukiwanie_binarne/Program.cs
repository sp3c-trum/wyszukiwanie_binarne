int[] tabela = new int[100];

for (int i = 0; i < tabela.Length; i++)
{
    tabela[i] = i*2;
}

int left = 0;
int right = tabela.Length - 1;
int mid;
int szukana;
int szukajLiczby()
{
    while (left <= right)
    {
        mid = (left + right) / 2;

        if (tabela[mid] == szukana) {
            return mid;
        }
        else if (tabela[mid] > szukana)
        {
            right = mid - 1;
        } else
        {
            left = mid + 1;
        }
    }
    return -1;
};

Console.WriteLine("Wpisz liczbę któej szukasz: ");
szukana = Int32.Parse(Console.ReadLine());
Console.WriteLine("Indeks tej liczby to : " + szukajLiczby());