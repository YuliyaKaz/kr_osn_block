# Итоговая контрольная работа по основному блоку
## Задача:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
## Алгоритм решения:
1. Ввод количества элементов исходного массива N
2. Создание массива размером N - массив array1
3. Последовательный ввод элементов массива array1
4. При каждом вводе элемента массива проверяем его длину. Подсчитываем количество элементов, длина которых меньше, либо равна трем символам
5. Создаем новый массив array2
5. В цикле заполняем массив array2 элементами исходного массива, длина символов которых меньше, либо равна 3 символам.
6. Вывод элементов нового массива