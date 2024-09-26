# def my_final_grade_calculation(file_name):
#   return {"tom": "pass", "mary":"pass", "joan": "fail"}

# def main():
#   pass

# if __name__ == "__main__":
#   main()

text_file = open("data.txt", "r")

txt_list = []

for line in text_file:
  txt_list.append(line.split(','))

print(txt_list)