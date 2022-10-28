// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите числа: ");
string seriesNumbers = Console.ReadLine();

seriesNumbers = seriesNumbers + ",";    
int[] ArrayNumbers(string seriesNew){ 

  int[] arrayNumbers = new int[1];    // инициализация массива из 1 элемента
  int j =0;

  for (int i = 0; i < seriesNew.Length; i++){
    string seriesNew1 = "";

    while (seriesNew[i] != ',' && i < seriesNew.Length){
      seriesNew1 += seriesNew[i];
      i++;
    }
    arrayNumbers[j] = Convert.ToInt32(seriesNew1);    // заполняет массив значениями из строки
    if (i < seriesNew.Length-1){
      arrayNumbers = arrayNumbers.Concat(new int[] {0}).ToArray();    // добавляет новый нулевой элемент в конец массива
    }
    j++;
  }
  return arrayNumbers;
}

// функция  вывода массива на печать 
void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count){
    Console.Write(coll[index]);
    index++;
    if (index < count){
   Console.Write(", ");
    }
  }
  Console.Write("]");
} 

int[] arrayNumbers =  ArrayNumbers(seriesNumbers);

PrintArry(arrayNumbers);

