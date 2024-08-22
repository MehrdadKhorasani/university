#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define MAX_STUDENTS 300
#define MAX_NAME_LENGTH 80
#define STUDENT_ID_LENGTH 11

typedef struct student_struct{
  char first_name[MAX_NAME_LENGTH];
  char last_name[MAX_NAME_LENGTH];
  char student_id[STUDENT_ID_LENGTH + 1];
  float average;
} Student;

Student students[MAX_STUDENTS];
int student_count = 0;

void add_student() {
  if (student_count >= MAX_STUDENTS) {
    printf("Student list is full! Cannot add more students.\n");
    return;
  }

  Student student;
  printf("Enter first name: ");
  scanf("%s", student.first_name);
  printf("Enter last name: ");
  scanf("%s", student.last_name);

  while (1) {
    printf("Enter student ID: ");
    scanf("%s", student.student_id);
    if (strlen(student.student_id) > STUDENT_ID_LENGTH) {
      printf("Student ID cannot be more than %d digits. Please enter again.\n", STUDENT_ID_LENGTH);
    } else {
      break;
    }
  }

  while (1) {
    printf("Enter average: ");
    if (scanf("%f", &student.average) != 1) {
      printf("Invalid input. Please enter a valid number for the average.\n");
      while (getchar() != '\n');
    } else {
      break;
    }
  }

  students[student_count++] = student;
  printf("Student added successfully!\n");
}

void remove_student() {
  if (student_count == 0) {
    printf("No students to remove!\n");
    return;
  }

  char student_id[STUDENT_ID_LENGTH + 1];
  printf("Enter student ID to remove: ");
  scanf("%s", student_id);

  for (int i = 0; i < student_count; i++) {
    if (strcmp(students[i].student_id, student_id) == 0) {
      for (int j = i; j < student_count - 1; j++) {
        students[j] = students[j + 1];
      }
      student_count--;
      printf("Student removed successfully!\n");
      return;
    }
  }
  printf("Student not found!\n");
}

void search_student() {
  if (student_count == 0) {
    printf("No students to search!\n");
    return;
  }

  char student_id[STUDENT_ID_LENGTH + 1];
  printf("Enter student ID to search: ");
  scanf("%s", student_id);

  for (int i = 0; i < student_count; i++) {
    if (strcmp(students[i].student_id, student_id) == 0) {
      printf("Student found: %s %s - %s - Average: %.2f\n", students[i].first_name, students[i].last_name, students[i].student_id, students[i].average);
      return;
    }
  }
  printf("Student not found.\n");
}

void sort_students_by_average() {
  if (student_count < 2) {
    printf("Not enough students to sort!\n");
    return;
  }

  for (int i = 0; i < student_count - 1; i++) {
    for (int j = 0; j < student_count - i - 1; j++) {
      if (students[j].average < students[j + 1].average) {
        Student temp = students[j];
        students[j] = students[j + 1];
        students[j + 1] = temp;
      }
    }
  }
  printf("Students sorted by average successfully!\n");

  printf("\n--- Sorted Students List ---\n");
  for (int i = 0; i < student_count; i++) {
    printf("%s %s - %s - Average: %.2f\n", students[i].first_name, students[i].last_name, students[i].student_id, students[i].average);
  }
}

void save_to_file(const char *filename) {
  if (student_count == 0) {
    printf("No students to save!\n");
    return;
  }

  FILE *file = fopen(filename, "w");
  if (file == NULL) {
    printf("Failed to open file for writing.\n");
    return;
  }

  for (int i = 0; i < student_count; i++) {
    fprintf(file, "%s %s %s %.2f\n", students[i].first_name, students[i].last_name, students[i].student_id, students[i].average);
  }

  fclose(file);
  printf("Students saved to %s successfully!\n", filename);
}

void load_from_file(const char *filename) {
  FILE *file = fopen(filename, "r");
  if (file == NULL) {
    printf("Failed to open file for reading.\n");
    return;
  }

  student_count = 0;
  while (fscanf(file, "%s %s %s %f", students[student_count].first_name,
                students[student_count].last_name,
                students[student_count].student_id,
                &students[student_count].average) != EOF) {
    if (student_count >= MAX_STUDENTS) {
      printf("File contains more students than the limit (%d). Only the first %d students were loaded.\n", MAX_STUDENTS, MAX_STUDENTS);
      break;
    }
    student_count++;
  }

  fclose(file);
  printf("Students loaded from %s successfully!\n", filename);
}

void display_menu() {
  printf("\n--- Student Management System ---\n");
  printf("1. Add Student\n");
  printf("2. Remove Student\n");
  printf("3. Search Student\n");
  printf("4. Sort Students by Average\n");
  printf("5. Save Students to File\n");
  printf("6. Load Students from File\n");
  printf("7. Exit\n");
  printf("Select an option: ");
}

int main() {
  int option;

  do {
    display_menu();
    scanf("%d", &option);

    switch (option) {
      case 1:
        add_student();
        break;
      case 2:
        remove_student();
        break;
      case 3:
        search_student();
        break;
      case 4:
        sort_students_by_average();
        break;
      case 5:
        save_to_file("students.txt");
        break;
      case 6:
        load_from_file("students.txt");
        break;
      case 7:
        printf("Exiting program.\n");
        break;
      default:
        printf("Invalid option! Please try again.\n");
    }
  } while (option != 7);

  return 0;
}
