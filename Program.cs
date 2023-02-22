Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string array = number.ToString();
char max = array[0];
char min = array[0];
  for (int i = 0; i < array.Length; i++)
  {
    if (max < array[i])
    {
      max = array[i];
    }
    if (min > array[i])
    {
     min = array[i];
    }
  }
int result1 = max - min;
char mediumResult2 = array[array.Length / 2];
int result2 = int.Parse(char.ToString(mediumResult2));
if ( result1 == result2)
{
  Console.WriteLine($"{number} - это интересное число ");
}
else
{
  Console.WriteLine($"{number} - это не интересное число ");
}

