Console.WriteLine("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
String[] array1 = new String[N];
int M = 0;
int cnt = 0;
for (int i = 0; i < N; i++){
    cnt = i + 1;
    Console.WriteLine("Введите элемент массива " + cnt);
    array1[i] = Console.ReadLine();
    if (array1[i].Length <= 3){
        M += 1;
    }
}
cnt = 0;
String[] array2 = new String[M];
for (int i = 0; i < N ; i++){
    if (array1[i].Length <= 3){
        array2[cnt] = array1[i];
        cnt += 1;
    }
}

Console.WriteLine();
Console.Write("Результирующий массив: [");
for (int i = 0; i<M; i++){
    Console.Write("\"" + array2[i].ToString() + "\"");
    if (i < (M-1)){
        Console.Write(",");
    }
}
Console.Write("]");
