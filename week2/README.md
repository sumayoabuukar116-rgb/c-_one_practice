C# Chapter 2 — Processing Data

3.1 Reading Input with TextBox Controls
3.2 A First Look at Variables
3.3 Numeric Data Type and Variables
3.4 Performing Calculations
3.5 Inputting and Outputting Numeric Values
3.6 Formatting Numbers with the ToString Method
3.7 Simple Exception Handling
3.8 Using Named Constants


3.1 Reading Input with TextBox Controls

A TextBox allows the user to enter information using the keyboard. The entered information is stored in the "Text" property.

Clearing a TextBox

textBox1.Clear();
textBox1.Text = "";
textBox1.Text = string.Empty;

---

3.2 A First Look at Variables

A variable is a storage location in memory used to store data.

Variable Declaration

string firstName;

Common Data Types

- "string" — stores text.
- "int" — stores whole numbers.
- "double" — stores decimal/real numbers.
- "decimal" — stores high-precision decimal values.

String Concatenation

Concatenation means joining strings together using the "+" operator.

string fullName = firstName + " " + lastName;

Local Variables and Scope

A local variable belongs to the method where it is declared. Its scope determines where it can be used.

Initializing Variables

A variable should have a value before it is used.

string productDescription = "Computer";

Multiple Variables

Several variables of the same type can be declared in one statement.

string lastName, firstName, middleName;

---

3.3 Numeric Data Types and Variables

Main Numeric Data Types

- "int" — whole numbers.
- "double" — real numbers, including decimal values.
- "decimal" — high-precision decimal values, commonly used for financial calculations.

Numeric Literals

int hoursWorked = 40;
double temperature = 87.6;
decimal payRate = 28.75m;

Type Casting

Casting converts a value from one data type to another.

int wholeNumber;
decimal moneyNumber = 4500m;

wholeNumber = (int)moneyNumber;

"var"

The "var" keyword allows C# to determine the data type automatically.

var interestRate = 12.0;
var stockCode = "D465U";
var accountBalance = 1000.0m;

---

3.4 Performing Calculations

Arithmetic Operators

Operator| Meaning
"+"| Addition
"-"| Subtraction
"*"| Multiplication
"/"| Division
"%"| Modulus

Integer Division

When two integers are divided, the result is an integer and the fractional part may be lost.

---

3.5 Inputting and Outputting Numeric Values

TextBox input is stored as a string, even when the user enters a number.

Parsing

Parsing converts a string into a numeric value.

int.Parse()
double.Parse()
decimal.Parse()

Displaying Numeric Values

Numeric values can be converted to strings using "ToString()".

value.ToString();

---

3.6 Formatting Numbers with the ToString Method

The "ToString()" method can format numeric values.

Format| Purpose
"N"| Number
"F"| Fixed-point
"E"| Exponential
"C"| Currency
"P"| Percentage

---

3.7 Simple Exception Handling

An exception is an unexpected error that occurs while a program is running.

Examples:

- Division by zero
- Invalid input
- Missing files

"try-catch"

The "try" section contains code that may cause an error, while "catch" handles the error.

try
{
    // statements
}
catch
{
    // handle exception
}

Throwing vs. Catching

- Throwing — an exception occurs.
- Catching — the program handles the exception.

Exception Message

An exception has a "Message" property that describes the error.

---

3.8 Using Named Constants

A constant is a value that cannot be changed while the program is running.

Constants are declared using "const".

const double INTEREST_RATE = 0.129;

---

3.9 Declaring Variables as Fields

A field is a variable declared at the class level.

- It is declared inside the class.
- It is outside methods.
- Its scope can cover the entire class.
- It exists while the form/class exists.

---

3.10 Using the Math Class

The Math class provides mathematical methods and constants.

Common Math Methods

- "Math.Sqrt()" — square root.
- "Math.Pow()" — power.
- "Math.Max()" — larger value.
- "Math.Min()" — smaller value.
- "Math.Round()" — rounds a number.

Math Constants

- "Math.PI" — represents pi.
- "Math.E" — represents the mathematical constant e.

---

3.11 More GUI Details

Tab Order

Tab Order determines the order in which controls receive focus when the user presses the Tab key.

- "TabIndex" determines the position.
- The first position is "0".

Focus Method

Focus determines which control currently receives keyboard input.

Keyboard Access Keys

Access keys allow users to access controls using the keyboard, usually together with the Alt key.

Setting Colors

- "BackColor" — controls the background color.
- "ForeColor" — controls the text/foreground color.

Background Images for Forms

Forms can have background images.

Background Image Layouts

- None
- Tile
- Center
- Stretch
- Zoom

GroupBoxes versus Panels

Both are containers used to organize controls.

GroupBox

- Can have a border.
- Can have a title.

Panel

- Does not have a title.
- Can have a border style.

---

3.12 Using the Debugger to Locate Logic Errors

Logic Errors

A logic error occurs when the program runs but produces the wrong result.

Examples:

- Incorrect mathematical calculation.
- Assigning the wrong value.
- Using the wrong variable.

Breakpoints

A breakpoint pauses program execution at a specific line so the programmer can inspect the program.

Break Mode

When execution is paused at a breakpoint, the program is in Break Mode.

Locals Window

The Locals Window displays local variables, their values, and their data types.

Watch Window

The Watch Window allows the programmer to monitor selected variables.

Single-Stepping

Single-stepping executes the program one statement at a time. It helps the programmer find the exact location of a logic error.

---

Key Topics to Remember

- TextBox and user input
- Variables and data types
- String concatenation
- Variable scope
- "int", "double", and "decimal"
- Type casting
- "var"
- Arithmetic operations
- Parsing numeric input
- "ToString()" and number formatting
- Exception handling
- Constants
- Fields
- Math class
- GUI controls
- Tab order and focus
- GroupBox and Panel
- Debugging and logic errors
- Breakpoints
- Locals and Watch windows
- Single-stepping