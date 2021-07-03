def summa(*arg): # объявление функции с неопределенным количеством аргументов
    summ = 0 
    for i in arg: # цикл для суммирования всех введенных чисел
        summ += i
    return summ

def summa_sp(sp): # объявление функции с аргументом-списком
    summ = 0 
    for i in sp: # цикл для суммирования всех введенных чисел
        summ += i
    return summ

a = (1, 2, 3)
print(summa(0, 5, 9))
print(summa_sp(a))
    