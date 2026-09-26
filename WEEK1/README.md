## Chapter 1 — Introduction to Visual C#

##  Overview

This chapter introduces the basic concepts of **Visual C#**, **Visual Studio**, **Windows Forms**, **GUI applications**, **objects**, **controls**, and basic C# programming concepts.

The chapter also explains how to create a simple Windows Forms application, work with controls, write event-driven code, use labels and PictureBox controls, understand IntelliSense, add comments, and deal with syntax errors.

---

## Topics Covered

* 1.1 Objects
* 1.2 Getting Started with Visual Studio
* 1.3 Getting Started with Visual Studio
* 1.4 Getting Started with Visual Studio
* 2.1 Getting Started with Forms and Controls
* 2.2 Creating the GUI for Your First Visual C# Application
* 2.3 Introduction to C# Code
* 2.4 Writing Code for the Hello World Application
* 2.5 Label Controls
* 2.6 Making Sense of IntelliSense
* 2.7 PictureBox Controls
* 2.8 Comments, Blank Lines, and Indentation
* 2.9 Writing the Code to Close an Application's Form
* 2.10 Dealing with Syntax Errors

---

# 1.1 Objects

An **object** is a program component that contains data and performs operations.

### Properties

Properties are the data or characteristics stored in an object.

Examples:

* Name
* Text
* Size
* Font

### Methods

Methods are operations that an object can perform.

Example:

```csharp
this.Close();
```

---

## Controls

Controls are objects that are visible in a program's GUI.

Common controls include:

* Label
* Button
* TextBox
* CheckBox
* ComboBox
* ListBox

There are also invisible objects such as:

* Timer
* OpenFileDialog

### Class

A **class** is code that describes a particular type of object.

---

# 1.2 Getting Started with Visual Studio

**Visual Studio** is a professional **Integrated Development Environment (IDE)**.

Important parts of Visual Studio include:

* Designer Window
* Solution Explorer
* Properties Window
* Toolbox
* Code Editor

---

## Toolbox

The **Toolbox** is used to select controls that can be added to an application.

Common controls include:

* Button
* CheckBox
* ComboBox
* Label
* ListBox
* ListView
* MaskedTextBox
* DateTimePicker

---

## Tooltip

A **Tooltip** is a small box that appears when the mouse pointer is placed over an item.

---

## Docked and Floating Windows

### Docked Window

A docked window is attached to one of the edges of the Visual Studio environment.

### Floating Window

A floating window can be moved around the screen by clicking and dragging it.

---

# Projects and Solutions

A **Project** is an application created in Visual Studio.

A project can contain several files, such as:

```text
Form1.cs
Program.cs
```

A **Solution** is a container that can hold one or more projects.

### Simple Structure

```text
Solution
   ↓
Project
   ↓
Files
```

---

## Displaying the Designer

If the form does not automatically appear in the Designer:

1. Right-click `Form1.cs`
2. Select **View Designer**

---

# 2.1 Getting Started with Forms and Controls

When a new Windows Forms App is created, an empty form named:

```text
Form1
```

is automatically created.

The form can be resized using its sizing handles.

---

## Properties Window

The **Properties Window** controls how an object looks and behaves.

It contains:

| Column         | Description                    |
| -------------- | ------------------------------ |
| Property Name  | Name of the property           |
| Property Value | Value assigned to the property |

Example:

```text
Text = My First Program
```

The `Text` property determines the text displayed in the form's title bar.

---

## Adding Controls to a Form

Controls can be added from the Toolbox by:

1. Double-clicking the control
2. Dragging and dropping the control onto the form

Controls can also be:

* Resized
* Moved
* Modified through the Properties Window
* Deleted using the Delete key

---

# Rules for Naming Controls

Control names are also called **identifiers**.

### Naming Rules

1. The first character must be a letter or underscore.
2. Other characters can be letters, numbers, or underscores.
3. Spaces are not allowed.

### Valid Examples

```text
showDayButton
DisplayTotal
_ScoreLabel
```

---

## camelCase Naming Convention

C# programmers commonly use **camelCase** for control names.

Example:

```text
showDayButton
```

The first word begins with lowercase letters, while the first letter of the following words is uppercase.

---

# 2.2 Creating the GUI for Your First Visual C# Application

In this section, a simple application is created using:

* A Form
* A Button

When the Button is clicked, the application displays:

```text
Hello World
```

The GUI is created using the Designer.

---

# 2.3 Introduction to C# Code

C# code is primarily organized into:

### Namespace

A namespace is a container that holds classes.

### Class

A class is a container that holds methods.

### Method

A method is a group of one or more programming statements that performs an operation.

### Source Code File

A file that contains program code is called a **source code file**.

---

## Program.cs and Form1.cs

### Program.cs

Contains the application's start-up code.

### Form1.cs

Contains code associated with the `Form1` form.

---

# Event-Driven Applications

GUI applications are **event-driven**.

This means the program waits for the user to perform an action and then responds.

Examples of events:

* Mouse click
* Key press
* Mouse movement

---

## Event Handler

An **Event Handler** is a method that executes when a specific event occurs.

Example:

```csharp
private void myButton_Click(object sender, EventArgs e)
{
    // Code goes here
}
```

---

# Message Boxes

A **MessageBox** displays a message in a separate window.

Example:

```csharp
MessageBox.Show("Thanks for clicking the button!");
```

---

# 2.4 Writing Code for the Hello World Application

The Hello World application can display a message when the Button is clicked.

Example:

```csharp
MessageBox.Show("Hello World");
```

---

# 2.5 Label Controls

A **Label** control displays text on a form.

It can display:

* Unchanging text
* Program output

## Important Label Properties

| Property      | Description                       |
| ------------- | --------------------------------- |
| `Text`        | Gets or sets the text             |
| `Name`        | Gets or sets the name             |
| `Font`        | Controls font, style, and size    |
| `BorderStyle` | Displays a border around the text |
| `AutoSize`    | Controls resizing                 |
| `TextAlign`   | Controls text alignment           |

---

## TextAlign

The `TextAlign` property supports nine values:

### Top

```text
TopLeft
TopCenter
TopRight
```

### Middle

```text
MiddleLeft
MiddleCenter
MiddleRight
```

### Bottom

```text
BottomLeft
BottomCenter
BottomRight
```

---

## Displaying Output in a Label

The `=` symbol is called the **assignment operator**.

Example:

```csharp
answerLabel.Text = "Hello";
```

The item receiving the value must be on the left side of `=`.

To clear a Label:

```csharp
answerLabel.Text = "";
```

---

# 2.6 Making Sense of IntelliSense

**IntelliSense** is a smart code-completion feature in Visual Studio.

It provides suggestions for:

* Keywords
* Variables
* Methods
* Classes
* Properties

It helps programmers write code more efficiently.

---

# 2.7 PictureBox Controls

A **PictureBox** control displays a graphic image on a form.

## Important Properties

| Property   | Description                               |
| ---------- | ----------------------------------------- |
| `Image`    | Specifies the image                       |
| `SizeMode` | Specifies how the image is displayed      |
| `Visible`  | Determines whether the control is visible |

---

## Creating Clickable Images

A PictureBox can respond to a click event.

You can double-click the PictureBox in the Designer to create a Click Event Handler and then add code to it.

---

# Sequential Execution of Statements

Statements execute in the order in which they appear.

Example:

```csharp
cardBackPictureBox.Visible = true;
cardFacePictureBox.Visible = false;
```

The first statement runs first, followed by the second statement.

The correct sequence is important because an incorrect sequence can cause **logic errors**.

---

# 2.8 Comments, Blank Lines, and Indentation

## Comments

Comments are notes written in source code to explain how parts of a program work.

### Single-Line Comment

```csharp
// Make image of the card back visible.
```

### Block Comment

```csharp
/*
   Line one
   Line two
*/
```

---

## Blank Lines

Blank lines make code easier to read.

## Indentation

Indentation helps make code:

* Organized
* Readable
* Easier to understand

---

# 2.9 Closing an Application's Form

To close the current form:

```csharp
this.Close();
```

To close the entire application:

```csharp
Application.Exit();
```

### Difference

```text
this.Close()
        ↓
Closes the current Form

Application.Exit()
        ↓
Closes the entire application
```

---

# 2.10 Dealing with Syntax Errors

A **syntax error** occurs when C# code does not follow the correct syntax.

Visual Studio examines code while it is being written.

When a syntax error is found, Visual Studio usually shows a **red jagged underline** under the incorrect code.

Syntax errors can prevent the program from compiling and running correctly.

---

# Important Terms

| Term          | Meaning                                          |
| ------------- | ------------------------------------------------ |
| Object        | Program component containing data and operations |
| Property      | Data/characteristic of an object                 |
| Method        | Operation an object can perform                  |
| Control       | Visible GUI object                               |
| Class         | Describes a type of object                       |
| IDE           | Integrated Development Environment               |
| Toolbox       | Contains controls                                |
| Solution      | Container for projects                           |
| Project       | Application                                      |
| Namespace     | Container for classes                            |
| Event         | User action                                      |
| Event Handler | Responds to an event                             |
| Label         | Displays text                                    |
| PictureBox    | Displays an image                                |
| IntelliSense  | Code completion feature                          |
| Comment       | Note explaining code                             |
| Syntax Error  | Incorrect C# syntax                              |

---

#  Important C# Code

```csharp
MessageBox.Show("Hello World");
```

```csharp
answerLabel.Text = "Hello";
```

```csharp
answerLabel.Text = "";
```

```csharp
this.Close();
```

```csharp
Application.Exit();
```

---

# Chapter Summary

This chapter introduces the fundamentals of **Visual C# and Windows Forms development**. It explains objects, properties, methods, controls, Visual Studio, projects and solutions, Forms, the Properties Window, GUI design, C# code organization, event-driven programming, MessageBoxes, Labels, IntelliSense, PictureBox controls, comments, indentation, closing forms, and syntax errors.

## Key Flow

```text
Visual Studio
      ↓
Project / Solution
      ↓
Form
      ↓
Controls
      ↓
Properties
      ↓
C# Code
      ↓
Events
      ↓
Program Output
```

---

##  Source

**Starting Out with Visual C#, Sixth Edition — Chapter 1: Introduction to Visual C#**
