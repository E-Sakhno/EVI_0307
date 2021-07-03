def more_n(sp, n):
    for i in sp:
        if i>n:
            print(i, end=' ')

more_n((5, 4, 4, 9), 4)