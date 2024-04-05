def calc(num1,operator,num2):
    match operator:
        case '+':
            print(num1 + num2)
        case '-':
            print(num1 - num2)
        case '*':
            print(num1 * num2)
        case '/':
            print(num1 / num2)
        case _:
            print("use a valid operator")

first_number = int(input("What is your first Number"))
operator = input("What is your operator (+ - * /)")
second_number = int(input("What is your second Number"))
calc(first_number,operator,second_number)
