from random import randint # импорт библиотеки

count = [0 for i in range(7)] # создание нулевого массива
for i in range(7):
    count[i] = randint(0, 9) # присвоение рандомного числа элементу списка
for i in range(7):
    print(count[i], end='') # вывод списка в строку

