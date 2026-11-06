CHAPTER 4: LOOPS, FILES, AND RANDOM NUMBERS

Book: Starting Out With Visual C# – Sixth Edition
Publisher: Pearson Education (2024)

1. TOPICS – CHAPTER 4

1. The while Loop
2. The ++ and – Operators
3. The for Loop
4. The do-while Loop
5. Using Files for Data Storage
6. The OpenFileDialog and SaveFileDialog Controls
7. Random Numbers
8. The Load Event

⸻

2. THE WHILE LOOP

What is a while loop?

The while loop causes a statement or set of statements to repeat as long as a Boolean expression is true.

A while loop has two parts:

1. Boolean expression: A condition that is tested to determine whether it is true or false.
2. Statement or set of statements: The code that repeats while the condition is true.

Structure of a while Loop

* The first line is called the while clause.
* Statements inside the curly braces are called the body of the loop.
* When a while loop executes, the Boolean expression is tested.
* If the expression is true, the statements are executed.
* Each time the loop executes its statements, we say the loop is iterating or performing an iteration.
* Counter variables are variables used to track how many times a loop runs.

The while Loop is a Pretest Loop

A while loop is a pretest loop, which means it tests its condition before performing an iteration.

This usually means steps must be taken prior to the loop to ensure it executes at least once.

If a while loop’s condition is false to start with, the loop will not iterate.

Infinite Loops

An infinite loop is a loop that repeats until the program is interrupted.

A typical cause of an infinite loop is that the programmer forgets to write code that makes the test condition false.

⸻

3. THE INCREMENT AND DECREMENT OPERATORS

Increment

To increment a variable means to increase its value.

Decrement

To decrement a variable means to decrease its value.

C# provides the ++ and – operators to increment and decrement variables.

* ++ is called the increment operator.
* – is called the decrement operator.

Postfix Mode versus Prefix Mode

There are two modes:

1. Postfix Mode

Postfix mode means placing the operators after their operands.

Postfix uses the old value first, then changes the value.

2. Prefix Mode

Prefix mode means placing the operators before their operands.

Prefix changes the value first, then uses the new value.

Difference Between Postfix and Prefix

* Postfix: Uses the old value first, then changes the value.
* Prefix: Changes the value first, then uses the new value.

⸻

4. THE FOR LOOP

What is a for loop?

The for loop is specially designed for situations requiring a counter variable to control the number of times that a loop iterates.

Three Actions of a for Loop

You must specify three actions:

1. Initialization

A one-time expression that defines the initial value of the counter.

2. Test

A Boolean expression to be tested. If true, the loop iterates.

3. Update

Increase or decrease the value of the counter.

Important

The for loop is a pretest loop.

Other Forms of Update Expression

In the update expression, the counter variable is typically incremented by 1. However, this is not a requirement.

You can decrement the counter variable to make it count backward.

⸻

5. THE DO-WHILE LOOP

What is a do-while loop?

The do-while loop is a posttest loop, which means it performs an iteration before testing its Boolean expression.

In the do-while loop, one or more statements are executed before a Boolean expression is tested.

Important

The do-while loop is a posttest loop.

It executes its statements at least once, even if the condition is false at the beginning.

Difference Between while and do-while

* while loop is a pretest loop.
* do-while loop is a posttest loop.
* while checks the condition before executing statements.
* do-while executes statements before checking the condition.
* while may not execute at all.
* do-while executes at least once.

⸻

6. USING FILES FOR DATA STORAGE

What is File Data Storage?

When a program needs to save data for later use, it writes the data in a file.

Three Steps of Working with Files

There are three steps:

1. Open the file

Create a connection between the file and the program.

2. Process the file

Either write to or read from the file.

3. Close the file

Disconnect the file and the program.

Two Types of Files

In general, there are two types of files:

1. Text File

A text file contains data that has been encoded as text using a scheme such as Unicode.

2. Binary File

A binary file contains data that has not been converted to text. You cannot view the contents of binary files with a text editor.

Important: This chapter only works with text files.

⸻

7. FILE ACCESSING

What is a File Object?

A file object is an object that is associated with a specific file and provides a way for the program to work with that file.

.NET provides two classes to work with file objects:

1. StreamWriter

StreamWriter is used for writing data to a text file.

2. StreamReader

StreamReader is used for reading data from a text file.

⸻

8. WRITING DATA TO A FILE

Theory

Writing data to a file means saving information inside a text file.

The steps are:

1. Start by creating a StreamWriter object.
2. Use one of the File methods to open the file to which you will be writing data.
3. Use the Write or WriteLine method to write items of data to the file.
4. Close the connection.

Sample File Methods

* File.CreateText
* File.AppendText

WriteLine Method

The WriteLine method writes an item of data to a file and then writes a newline character, which specifies the end of a line.

Write Method

The Write method writes an item to a file without a newline character.

⸻

9. CREATETEXT VERSUS APPENDTEXT

File.CreateText

The File.CreateText method creates a text file with the name specified by the argument.

* If the file already exists, its contents are erased.
* It creates a StreamWriter object in memory, associated with the file.
* It returns a reference to the StreamWriter object.

File.AppendText

When there is a need not to erase the contents of an existing file, use the AppendText method.

Difference Between CreateText and AppendText

* CreateText erases the old contents if the file already exists.
* AppendText keeps the old contents.
* CreateText writes new contents.
* AppendText adds new contents to the existing file.

⸻

10. SPECIFYING THE LOCATION OF AN OUTPUT FILE

If you want to open a file in a different location, you can specify a path as well as the filename in the argument.

Be sure to prefix the string with the @ character.

Important Terms

* Path: The location where the file is stored.
* Filename: The name of the file.
* @ character: Used when specifying a file path in a string.

⸻

11. READING DATA FROM A FILE

Theory

Reading data from a file means getting information from a saved text file.

The steps are:

1. Start by creating a StreamReader object.
2. Use the File.OpenText method to open the file.
3. Use the Read or ReadLine method to read data from the file.
4. Close the connection.

StreamReader Methods

1. StreamReader.ReadLine

Reads a line of characters from the current stream and returns the data as a string.

2. StreamReader.Read

Reads the next character or next set of characters from the input stream.

3. StreamReader.ReadToEnd

Used to read data until the end of the stream.

4. File.ReadAllText

Used to read all the text contained in a file.

⸻

12. READING A FILE WITH A LOOP

Theory

StreamReader objects have a Boolean property named EndOfStream that signals whether or not the end of the file has been reached.

You can write a loop to detect the end of the file.

Important

* EndOfStream = True: The end of the file has been reached.
* EndOfStream = False: The end of the file has not yet been reached.

A loop can be used to read the data in a file until its end.

⸻

13. THE OPENFILEDIALOG AND SAVEFILEDIALOG CONTROLS

Theory

The OpenFileDialog and SaveFileDialog controls allow your application to display standard Windows dialog boxes for opening and saving files.

Unlike Label, Button, and TextBox, they are invisible controls.

1. OpenFileDialog

The OpenFileDialog control displays a standard Windows Open dialog box.

2. SaveFileDialog

The SaveFileDialog control displays a standard Windows Save As dialog box.

Important

OpenFileDialog and SaveFileDialog are invisible controls. They do not appear directly on the Form like Label, Button, and TextBox.

⸻

14. DISPLAYING AN OPEN DIALOG BOX

When adding an OpenFileDialog control to the form, it does not appear on the form but in an area at the bottom of the Designer called the Component Tray.

In code, you can display an Open dialog box by calling the ShowDialog method.

⸻

15. DETECTING THE USER’S SELECTION

The ShowDialog method returns a DialogResult value that indicates which button the user clicks to dismiss the dialog box.

There are two important results:

1. DialogResult.OK

If the user clicked the Open button, the value DialogResult.OK is returned.

2. DialogResult.Cancel

If the user clicked the Cancel button, the value DialogResult.Cancel is returned.

⸻

16. THE FILENAME AND INITIALDIRECTORY PROPERTIES

When the user selects a file with the Open dialog box, the file’s path and filename are stored in the control’s Filename property.

Filename Property

It stores the file’s path and filename selected by the user.

InitialDirectory Property

You can specify a directory to be initially displayed with the InitialDirectory property.

⸻

17. DISPLAYING A SAVE AS DIALOG BOX

The SaveFileDialog control is used to display a standard Windows Save As dialog box.

There are three important steps:

1. Use the ShowDialog method to display the Save As dialog box.
2. Detect the user’s choice.
3. Open the selected file.

⸻

18. RANDOM NUMBERS

Theory

.NET provides the Random class to generate random numbers.

Two Commonly Used Methods

1. Next

Next randomly creates an integer.

2. NextDouble

NextDouble randomly creates a floating-point number from 0.0 to 1.0.

⸻

19. THE RANDOM.NEXT METHOD

Random.Next generates a random number whose value ranges from 0 to 2,147,483,647.

It also allows you to generate a random number whose value ranges from zero to some other positive number.

For example, it can generate a random number from 0 to 99.

Important Terms

* Random: Used to generate random numbers.
* Integer: A whole number.
* Floating-point number: A number that can contain a decimal part.
* Next: Generates a random integer.
* NextDouble: Generates a random floating-point number between 0.0 and 1.0.

⸻

20. THE LOAD EVENT

Theory

When running an application, the application’s form is loaded into memory and an event known as Load takes place.

How to Create a Load Event Handler

To create a Load event handler, simply double-click the form in the Designer.

⸻

21. THE LOAD EVENT – CONTINUED

Any code you write inside the Load event will execute when the form is launched.

Important

The Load Event takes place when the Form is launched.


