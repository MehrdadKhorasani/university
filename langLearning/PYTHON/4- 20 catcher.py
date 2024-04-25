import random
player_score = 0
cpu_score = 0
while (player_score < 20 and cpu_score < 20 ):
  player_dice = random.randint(1,6)
  cpu_dice = random.randint(1,6)
  player_score += player_dice
  cpu_score += cpu_dice
  print("in this round the scores are:")
  print(f"player: {player_score}")
  print(f"cpu: {cpu_score}")


if(player_score >= 20): print(f"game ends. player wins with {player_score} scores")
else: print(f"game ends. cpu wins with {cpu_score} scores")


