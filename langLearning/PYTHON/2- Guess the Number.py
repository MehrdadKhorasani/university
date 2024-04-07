import random


level = input("Insert your Level:\n")
if(level == 'easy'):
    random_number = random.randint(1,5)
elif(level == 'medium'):
    random_number = random.randint(1,10)
elif(level == 'hard'):
    random_number = random.randint(1,20)
else:
    random_number = 0
for i in range(3):
    userNum = int(input("what is your guess: "))
    if(userNum == random_number):
        print("you win")
        break
    if(i == 2):
        print("you lost")
