a = [[0 for i in range(3)] for j in range(5)]

print(a)

for i in range(5):
    for j in range(3):
        inp = ''
        while True:
            try:
                inp = int(input((f'Введите число {j+1}-е число в {i+1}-й строке ')))
                a[i][j] = inp
                break
            except:
                print('Повторите ввод. Необходимо целое число')
           
        

print(a)