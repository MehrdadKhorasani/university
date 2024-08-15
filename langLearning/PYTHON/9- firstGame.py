import pygame
pygame.init()

win = pygame.display.set_mode((300,300))

pygame.display.set_caption("First Game")

x = 30
y = 30
width = 16
height = 16
velacity = 5

run = True

while(run):
  pygame.time.delay(100)

  for event in pygame.event.get():
    if event.type == pygame.QUIT:
      run = False

  keys = pygame.key.get_pressed()

  if keys[pygame.K_LEFT]:
    x -= velacity
  if keys[pygame.K_RIGHT]:
    x += velacity
  if keys[pygame.K_UP]:
    y-= velacity
  if keys[pygame.K_DOWN]:
    y+= velacity

  win.fill((0,0,0))
  pygame.draw.rect(win, (255,0,0), (x , y , width, height))
  pygame.display.update()

pygame.quit()