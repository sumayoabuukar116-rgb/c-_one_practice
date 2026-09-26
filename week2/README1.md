# C# Chapter 3 – Variables and Input

This chapter introduces **TextBox controls, variables, data types, string concatenation, variable scope, initialization, numeric data types, casting, and the `var` keyword** in C# Windows Forms.

---

## 3.1 Reading Input with TextBox Controls

### TextBox Control

A **TextBox** is a rectangular control that allows the user to enter information using the keyboard.

* It is found in the **Common Controls** section of the Toolbox.
* Its default names are usually `textBox1`, `textBox2`, etc.
* The information entered by the user is stored in the TextBox's **Text** property.

### The Text Property

The `Text` property stores user input as a string.

```csharp
textBox1.Text = "Hello";
```

This means that the TextBox will contain the word **Hello**.

### Clearing a TextBox

There are three ways to clear a TextBox:

```csharp
textBox1.Text = string.Empty;
```

```csharp
textBox1.Clear();
```

```csharp
textBox1.Text = "";
```

All three methods remove the text from the TextBox.

### Screenshot

![TextBox Control](Screenshots/TextBox.png)

---

# 3.2 A First Look at Variables

## What is a Variable?

A **variable** is a storage location in memory. The variable's name represents that storage location.

A variable must be declared before it can be used.

### Variable Declaration

The general form is:

```csharp
DataType VariableName;
```

Example:

```csharp
string firstName;
```

This creates a string variable called `firstName`.

---

## Data Types

A **data type** determines what kind of information a variable can store.

| Data Type | Purpose                        |
| --------- | ------------------------------ |
| `string`  | Text                           |
| `int`     | Whole numbers                  |
| `double`  | Decimal/real numbers           |
| `decimal` | High-precision decimal numbers |

Primitive data types are basic, built-in types provided by C#.

---

## Variable Names

A variable name:

* Must begin with a letter or `_`.
* Cannot contain spaces.
* Cannot use C# keywords or reserved words.
* Should have a meaningful name.

Example:

```csharp
string studentName;
```

`studentName` is meaningful because it tells us what the variable stores.

### Screenshot

![Variable Declaration](Screenshots/variable_declaration.png)

---

# String Variables

A `string` stores text.

Example:

```csharp
string name = "Ahmed";
```

Here, the variable `name` stores the text **Ahmed**.

---

# String Concatenation

**Concatenation** means joining strings together.

The `+` operator can join strings with other strings or numeric values.

Example:

```csharp
string fullName = firstName + " " + lastName;
```

If:

```text
firstName = Ahmed
lastName = Ali
```

The result is:

```text
Ahmed Ali
```

Strings can also be combined with numbers:

```csharp
12 + " apples";
```

```csharp
"Total is " + 25.75;
```

### Screenshot

![String Concatenation](Screenshots/concatenation.png)

---

# Example: String Variable

The following example declares a variable, combines information from TextBoxes, and displays the result in a Label.

```csharp
string fullname;

fullname = firstNameTextBox.Text + " " + lastNameTextBox.Text;

fullNameLabel.Text = fullname;
```

### What happens?

1. `fullname` is created as a string variable.
2. The first and last names are combined.
3. The combined name is stored in `fullname`.
4. The result is displayed in the Label.

### Screenshot

![String Variable Example](Screenshots/string_variable.png)

---

# Local Variables and Scope

A **local variable** belongs to the method where it is declared.

Example:

```csharp
private void firstButton_Click(object sender, EventArgs e)
{
    string myName;
    myName = nameTextBox.Text;
}
```

The variable `myName` can only be used inside `firstButton_Click`.

It cannot automatically be used inside another method:

```csharp
private void secondButton_Click(object sender, EventArgs e)
{
    outputLabel.Text = myName;
}
```

This causes an error because `myName` is outside its scope.

---

## Scope and Lifetime

### Scope

**Scope** means where a variable can be accessed.

### Lifetime

**Lifetime** means how long a variable exists in memory.

A local variable is created when its method starts and is destroyed when the method ends.

---

# Duplicate Variable Names

You cannot declare two variables with the same name in the same scope.

Incorrect:

```csharp
string name;
string name;
```

However, different methods can have variables with the same name because each method has its own scope.

Example:

```csharp
private void firstButton_Click(object sender, EventArgs e)
{
    string name;
}

private void secondButton_Click(object sender, EventArgs e)
{
    string name;
}
```

---

# Assignment Compatibility

A value assigned to a variable must be compatible with its data type.

Example:

```csharp
string name = "Ahmed";
```

This works because `"Ahmed"` is a string.

---

# Initializing Variables

A variable must have a value before you use it.

### Incorrect

```csharp
string productDescription;

MessageBox.Show(productDescription);
```

The variable was declared but not assigned a value. C# gives an **unassigned local variable** error.

### Correct

```csharp
string productDescription = "Computer";

MessageBox.Show(productDescription);
```

Now the variable has a value and can be used.

### Screenshot

![Initializing Variables](Screenshots/initializing_variables.png)

---

# Declaring Multiple Variables

Several variables of the same type can be declared in one statement.

```csharp
string lastName, firstName, middleName;
```

They can also be initialized:

```csharp
string lastName = "Khalaf",
       firstName = "Mohamed",
       middleName = "Abdullahi";
```

---

# 3.3 Numeric Data Types and Variables

When a variable must store a number and participate in calculations, a **numeric data type** is used.

## Main Numeric Types

| Type      | Purpose                                                                 |
| --------- | ----------------------------------------------------------------------- |
| `int`     | Whole numbers                                                           |
| `double`  | Real numbers, including fractional values                               |
| `decimal` | High-precision decimal values, commonly used for financial calculations |

---

# Numeric Literals

A **numeric literal** is a number written directly in the program.

Example:

```csharp
int hoursWorked = 40;

double temperature = 87.6;

decimal payRate = 28.75m;
```

### Important

```text
40      → int
87.6    → double
28.75m  → decimal
```

The `m` suffix tells C# that the value is a `decimal`.

---

# Assignment Compatibility for int

An `int` can receive an integer, but not a `double` or `decimal`.

### Works

```csharp
int hoursWorked = 40;
```

### Error

```csharp
int unitsSold = 650m;
```

### Error

```csharp
int score = -25.5;
```

---

# Assignment Compatibility for double

A `double` can receive a `double` or an `int`, but not a `decimal`.

### Works

```csharp
double distance = 28.75;

double speed = 75;
```

### Error

```csharp
double sales = 6500.0m;
```

---

# Assignment Compatibility for decimal

A `decimal` can receive a `decimal` or an `int`, but not a `double`.

### Works

```csharp
decimal balance = 9280.73m;

decimal price = 50;
```

### Error

```csharp
decimal sales = 6500.0;
```

---

# Explicit Conversion with Cast Operators

**Casting** means explicitly converting one data type into another.

Example:

```csharp
int wholeNumber;

decimal moneyNumber = 4500m;

wholeNumber = (int)moneyNumber;
```

Another example:

```csharp
double realNumber;

decimal moneyNumber = 625.70m;

realNumber = (double)moneyNumber;
```

The cast operator tells C# which data type the value should be converted to.

### Screenshot

![Casting](Screenshots/casting.png)

---

# Declaring Local Variables with the var Keyword

The `var` keyword allows C# to determine the data type automatically from the value assigned to the variable.

Examples:

```csharp
var interestRate = 12.0;

var stockCode = "D465U";

var accountBalance = 1000.0m;
```

C# determines the types as follows:

| Variable         | Data Type |
| ---------------- | --------- |
| `interestRate`   | `double`  |
| `stockCode`      | `string`  |
| `accountBalance` | `decimal` |

A `var` variable must be initialized when it is declared.

`var` is used for local variables.

### Screenshot

![var Keyword](Screenshots/var_keyword.png)

---



