#include <stdio.h>
#include <stdlib.h>

#define MAX_STR_LEN 50
#define STUDENTS_COUNT 2

// typedef int integer;
// typedef struct student Student;

// better way to use typedef for structs:
typedef struct person
{
  char first_name[MAX_STR_LEN];
  char last_name[MAX_STR_LEN];
  int age;
} Person;

struct student
{
  char first_name[MAX_STR_LEN];
  char last_name[MAX_STR_LEN];
  int entrance_year;
  float average;
};

union number
{
  //because the both of data is saved in one slot of memory, you can choose and work with just one of them
  int int_value;
  float floating_value;
};

// typedef union number Number;

enum month
{
  // zero-based
  Jan = 1,
  Feb,
  Mar,
  Apr,
  May,
  Jun,
  Jul,
  Aug,
  Sep,
  Oct,
  Nov,
  Dec
};

// typedef enum month Month;

void reduce_entrance_year(struct student s)
{
  s.entrance_year--;
  // it reduces the value just in this scope.
  // call by value
}

void real_reduce_entrance_year(struct student *s)
{
  s->entrance_year--;
  // it realy reduces the value
  // call by reference
}

int main()
{

  // exmpl 1
  struct student s1;
  printf("please enter first name\n");
  scanf("%s", s1.first_name);
  printf("please enter last name\n");
  scanf("%s", s1.last_name);
  printf("please enter entrance year\n");
  scanf("%d", &s1.entrance_year);
  printf("please enter average\n");
  scanf("%f", &s1.average);
  printf("Hello %s %s. You've entered to this school at %d with average %f",
          s1.first_name, s1.last_name, s1.entrance_year, s1.average);

  // exmpl 2
  struct student students[STUDENTS_COUNT];

  for (int i = 0; i < STUDENTS_COUNT ; i++)
  {
    printf("please enter student #%d's first name\n", i + 1);
    scanf("%s", students[i].first_name);
    printf("please enter student #%d's last name\n", i + 1);
    scanf("%s", students[i].last_name);
    printf("please enter student #%d's entrance year\n", i + 1);
    scanf("%d", &students[i].entrance_year);
    printf("please enter student #%d's average\n", i + 1);
    scanf("%f", &students[i].average);
  }

  printf("Id\tFirstName\tLastName\tEntranceYear\tAverage\n");
  for(int i = 0; i < STUDENTS_COUNT; i++)
  {
    printf("%d\t%s\t%s\t%d\t%f\n",
            i + 1,
            students[i].first_name,
            students[i].last_name,
            students[i].entrance_year,
            students[i].average
          );
  }

  for(int i = 0 ; i < STUDENTS_COUNT; i++)
  {
    printf("Hello %s %s. You've entered to this school at %d with average %f \n",
          students[i].first_name, students[i].last_name, students[i].entrance_year, students[i].average);
  }


  // exmpl 3
  // structs can created in global scope or local scope
  struct car
  {
    char brand_name[MAX_STR_LEN];
    char model_name[MAX_STR_LEN];
    int manufactor_year;
    float price;
  }ford,cars[100]; //create structs right after initial the main one


  // exmpl 4
  struct student s2 = {"Alex", "Jordan", 2002, 12};
  printf("%s %s %d %f \n",
          s2.first_name,
          s2.last_name,
          s2.entrance_year,
          s2.average
        ); //=> Alex Jordan 2002 12.000000
  struct student *ptr_to_student = &s2;
  // printf("%s\n", (*ptr_to_student).first_name); //=> Alex
  // ==
  printf("%s\n", ptr_to_student->first_name); //=> Alex

  printf("Entrance Year: %d\n",s2.entrance_year); //=> 2002
  reduce_entrance_year(s2);
  printf("Entrance Year: %d\n",s2.entrance_year); //=> 2002

  printf("Entrance Year: %d\n",s2.entrance_year); //=> 2002
  real_reduce_entrance_year(&s2);
  printf("Entrance Year: %d\n",s2.entrance_year); //=> 2001

  //exmpl 5
  //// typedef
  integer a = 2; // line 7
  printf("%d", a); //=> 2
  Student s1; // line 8
  s1.entrance_year = 1997;
  printf("%d", s1.entrance_year); //=> 1997
  Person p1 = {"Alireza", "Mahdavi", 23};
  printf("%s %s %d", p1.first_name, p1.last_name, p1.age); //=> Alireza Mahdavi 23


  //exmpl 5
  //// Union
  union number n1;
  n1.int_value = 2;
  printf("%d %f \n", n1.int_value, n1.floating_value); //=> 2 0.000000
  n1.floating_value = 2.5;
  printf("%d %f \n", n1.int_value, n1.floating_value); //=> 1075838976 2.500000

  union number n2 = {2.5}; //initialize


  //exmpl 6
  //// enum
  enum month m;
  m = Jul;
  printf("%d", m); //=> 7

  switch (m)
  {
    case Feb:
      printf("Feb");
      break;
    case Mar:
      printf("Mar");
      break;
  }

  return 0;
}
