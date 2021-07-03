from random import randint

count = [0 for i in range(7)]
for i in range(7):
    count[i] = randint(0, 9)
for i in range(7):
    print(count[i], end='')

