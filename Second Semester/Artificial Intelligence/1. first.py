def my_final_grade_calculation(txt_list):

  result_dict = {}

  name = txt_list[0].lower()
  quizes = []
  assignments = []
  midterm = int(txt_list[11])
  final = int(txt_list[12])
  
  for i in range(11):
      if 0 < i < 7:
          quizes.append(int(txt_list[i]))
      elif i >= 7:
          assignments.append(int(txt_list[i]))

  quizes.remove(min(quizes))
  quizes.remove(min(quizes))
  quizes_avg = int(sum(quizes) / len(quizes))

  assignments.remove(min(assignments))
  assignments_avg = int(sum(assignments) / len(assignments))

  score = (quizes_avg + assignments_avg + midterm + final) / 4
  pass_or_not = "pass" if score >= 60 else "fail"

  result_dict[name] = pass_or_not

  return result_dict

def main():
  final_results = {}

  with open("data.txt", "r") as text_file:
      for line in text_file:
          txt_list = line.strip().split(',')
          student_result = my_final_grade_calculation(txt_list)
          final_results.update(student_result)

  print(final_results)

if __name__ == "__main__":
  main()
