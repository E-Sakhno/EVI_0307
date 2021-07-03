def lo_shu(a): # объявление функции
    a_sort = sorted([a[i][j] for i in range(3) for j in range(3)]) # создание одномерного упорядоченного массива из введенного
    if a_sort == [i for i in range(1, 10)]: # если введенный массив исключительно из чисел от 1 до 9
        # суммы элементов в строках
        summ_str_1 = sum(a[0])
        summ_str_2 = sum(a[1])
        summ_str_3 = sum(a[2])
        # суммы элементов в столбах
        summ_st_1 = sum([a[i][0] for i in range(3)])
        summ_st_2 = sum([a[i][1] for i in range(3)])
        summ_st_3 = sum([a[i][2] for i in range(3)])
        # суммы элементов в диагоналях
        summ_diag_1 = sum([a[i][i] for i in range(3)])
        summ_diag_2 = sum([a[i][3-i-1] for i in range(3)])
        # массив из всех сумм
        summs = [summ_str_1, summ_str_2, summ_str_3, summ_st_1, summ_st_2, summ_st_3, summ_diag_1, summ_diag_2]
        if len(set(summs)) == 1: # если все значения одинаковые
            print("Список является магическим квадратом Ло Шу")
        else:
            print("Список не является магическим квадратом Ло Шу")
    else:
        print("Список не является магическим квадратом Ло Шу!")

a = [[4,9,2],[3,5,7],[8,1,6]]
lo_shu(a)