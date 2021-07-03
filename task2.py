a = [[0 for i in range(3)] for j in range(5)] # создание нулевого двумерного массива 5х3


for i in range(5):
    for j in range(3):
        inp = ''
        while True:
            try: # проверка типа данных, введенных пользователем
                inp = int(input((f'Введите число {j+1}-е число в {i+1}-й строке ')))
                a[i][j] = inp
                break
            except:
                print('Повторите ввод. Необходимо целое число')
           
        
for i in range(5):# вывод массива
    print(a[i])
