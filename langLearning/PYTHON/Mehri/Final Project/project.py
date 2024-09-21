import tkinter as tk
from tkinter import ttk, messagebox
import sqlite3

class StudentApp:
    def __init__(self, root):
        self.root = root
        self.root.title("Student Information System")
        self.root.geometry("420x500")
        self.root.configure(bg="#f3f3f3")

        self.create_widgets()
        self.create_database()

    def create_database(self):
        conn = sqlite3.connect('students.db')
        c = conn.cursor()
        c.execute('''CREATE TABLE IF NOT EXISTS students
                     (id INTEGER PRIMARY KEY AUTOINCREMENT,
                     first_name TEXT,
                     last_name TEXT,
                     phone TEXT,
                     gender TEXT)''')
        conn.commit()
        conn.close()

    def create_widgets(self):
        style = ttk.Style()
        style.configure("TLabel", font=("Helvetica", 12), background="#f2f2f2")
        style.configure("TButton", font=("Helvetica", 10), padding=5)

        ttk.Label(self.root, text="First Name").grid(row=0, column=0, padx=10, pady=10, sticky="W")
        ttk.Label(self.root, text="Last Name").grid(row=1, column=0, padx=10, pady=10, sticky="W")
        ttk.Label(self.root, text="Phone").grid(row=2, column=0, padx=10, pady=10, sticky="W")
        ttk.Label(self.root, text="Gender").grid(row=3, column=0, padx=10, pady=10, sticky="W")

        self.entry_first_name = ttk.Entry(self.root)
        self.entry_last_name = ttk.Entry(self.root)
        self.entry_phone = ttk.Entry(self.root)

        self.entry_first_name.grid(row=0, column=1, padx=10, pady=10)
        self.entry_last_name.grid(row=1, column=1, padx=10, pady=10)
        self.entry_phone.grid(row=2, column=1, padx=10, pady=10)

        self.gender_var = tk.StringVar(value="")  
        ttk.Radiobutton(self.root, text="Male", variable=self.gender_var, value="Male").grid(row=3, column=1, padx=10, pady=10, sticky="W")
        ttk.Radiobutton(self.root, text="Female", variable=self.gender_var, value="Female").grid(row=3, column=2, padx=10, pady=10, sticky="W")

        ttk.Button(self.root, text="Add Student", command=self.add_student).grid(row=4, column=0, columnspan=3, padx=10, pady=10)
        ttk.Button(self.root, text="Show Students", command=self.show_students).grid(row=5, column=0, columnspan=3, padx=10, pady=10)

        self.student_list = tk.Listbox(self.root, height=10, width=50, font=("Helvetica", 10))
        self.student_list.grid(row=6, column=0, columnspan=3, padx=10, pady=10)

    def add_student(self):
        first_name = self.entry_first_name.get().strip()
        last_name = self.entry_last_name.get().strip()
        phone = self.entry_phone.get().strip()
        gender = self.gender_var.get()

        if not first_name.isalpha():
            messagebox.showwarning("Input Error", "First name must contain only letters.")
            return

        if not last_name.isalpha():
            messagebox.showwarning("Input Error", "Last name must contain only letters.")
            return

        if not phone.isdigit():
            messagebox.showwarning("Input Error", "Phone number must contain only digits.")
            return

        if not gender:
            messagebox.showwarning("Input Error", "Please select a gender.")
            return

        conn = sqlite3.connect('students.db')
        c = conn.cursor()
        c.execute("INSERT INTO students (first_name, last_name, phone, gender) VALUES (?, ?, ?, ?)",
                  (first_name, last_name, phone, gender))
        conn.commit()
        conn.close()
        messagebox.showinfo("Success", "Student added successfully!")
        self.clear_entries()

    def clear_entries(self):
        self.entry_first_name.delete(0, tk.END)
        self.entry_last_name.delete(0, tk.END)
        self.entry_phone.delete(0, tk.END)
        self.gender_var.set("")

    def show_students(self):
        conn = sqlite3.connect('students.db')
        c = conn.cursor()
        c.execute("SELECT * FROM students")
        records = c.fetchall()
        conn.close()

        self.student_list.delete(0, tk.END)
        for record in records:
            self.student_list.insert(tk.END, f"{record[1]} {record[2]}, Phone: {record[3]}, Gender: {record[4]}")

if __name__ == "__main__":
    root = tk.Tk()
    app = StudentApp(root)
    root.mainloop()
