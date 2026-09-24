# c#_one_practice
c# programming language 
# C# Student Information

## Project Description

This project is a simple **C# Windows Forms application** that collects student information from different TextBoxes and displays the information in a Label.

The project demonstrates how to use:

* Variables
* TextBoxes
* Labels
* Parse method
* String concatenation
* Button click events
* User input

---

## Technologies Used

* **C#**
* **Windows Forms**
* **Visual Studio**

---

## Student Information

The application collects the following student information:

* Student ID
* Student Name
* Department
* Age
* Gender

The user enters the information into the TextBoxes and clicks the button to display the result.

---

## 1. Creating Variables

Variables are created to store the information entered by the user.

```csharp
int studentId;
string studentName;
string department;
int age;
string gender;
```

The variables store different types of information.

![Creating Variables](Screenshots/creatingvariable.png.png)

---

## 2. Assigning Values

The values entered into the TextBoxes are assigned to the variables.

For the **Student ID**, the `Parse` method is used to convert the TextBox value from a string into an integer.

```csharp
studentId = int.Parse(txtStudentID.Text);
studentName = txtStudentName.Text;
department = txtDepartment.Text;
age = int.Parse(txtAge.Text);
gender = txtGender.Text;
```

The `int.Parse()` method is important because TextBox values are stored as strings.

![Assigning Values](Screenshots/Assign_variable.png)

---

## 3. Parse Method

The `Parse` method is used to convert a string value into another data type.

For example:

```csharp
studentId = int.Parse(txtStudentID.Text);
```

Here:

* `txtStudentID.Text` gets the value entered by the user.
* `int.Parse()` converts the value from a string to an integer.
* `studentId` stores the converted integer value.

This allows the program to work with the Student ID as an integer.

---

## 4. Concatenation

The `+` operator is used to combine different pieces of information into one string.

Example:

```csharp
lblResult.Text = "Student ID: " + studentId +
                 "\nName: " + studentName +
                 "\nDepartment: " + department +
                 "\nAge: " + age +
                 "\nGender: " + gender;
```

The `+` operator combines the labels and values into one output.

![Concatenation](Screenshots/Concatenation.png)

---

## 5. Button Click Event

When the user clicks the button, the program reads the information from the TextBoxes, stores the values in variables, and displays the result in the Label.

Example:

```csharp
private void btnDisplay_Click(object sender, EventArgs e)
{
    int studentId;
    string studentName;
    string department;
    int age;
    string gender;

    studentId = int.Parse(txtStudentID.Text);
    studentName = txtStudentName.Text;
    department = txtDepartment.Text;
    age = int.Parse(txtAge.Text);
    gender = txtGender.Text;

    lblResult.Text = "Student ID: " + studentId +
                     "\nName: " + studentName +
                     "\nDepartment: " + department +
                     "\nAge: " + age +
                     "\nGender: " + gender;
}
```

---

## 6. Program Output

After entering the student's information and clicking the button, the information is displayed in the Label.

Example:

```text
Student ID: 12345
Name: Sumayo
Department: Information Technology
Age: 20
Gender: Female
```

![Program Output](Screenshots/output.png)

---

## 7. How the Program Works

The program follows these steps:

1. The user enters the Student ID.
2. The user enters the student's name.
3. The user enters the department.
4. The user enters the student's age.
5. The user enters the gender.
6. The program reads the values from the TextBoxes.
7. `int.Parse()` converts numeric values into integers.
8. The values are stored in variables.
9. The `+` operator combines the information.
10. The final information is displayed in the Label.

---

## 8. What I Learned

Through this assignment, I learned how to:

* Create variables in C#
* Get input from TextBoxes
* Convert strings into integers using `Parse`
* Assign values to variables
* Use string concatenation
* Handle button click events
* Display information using a Label
* Create a simple Windows Forms application


---

## Conclusion

This project demonstrates the basic concepts of C# programming by creating a simple Student Information application. It shows how user input can be collected, converted, stored in variables, combined using concatenation, and displayed as output.
