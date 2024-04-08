import random
player_choose = input('Your choose form r/p/s: \n')
arr = ['r','p','s']
cpu_choose = arr[random.randint(0,2)]
check_game = player_choose + cpu_choose
print(check_game)
match check_game:
    case "rr" | "pp" | "ss":
        print("draw")
    case "rs" | "pr" | "sp":
        print("win")
    case "rp" | "ps" | "sr":
        print("lose")
    case _:
        print("There is a problem")
