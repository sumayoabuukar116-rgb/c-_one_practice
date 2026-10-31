C# File Handling Assignment


It compares the functions explained by the teacher with the functions used in my project.

---

2. READING FUNCTIONS

A. Reading Functions Explained by the Teacher

1. Read()

reader.Read();

Reads one character from a file.

2. ReadLine()

reader.ReadLine();

Reads one line from a file.

3. ReadToEnd()

reader.ReadToEnd();

Reads all remaining text from a file.

4. ReadAllText()

File.ReadAllText("data.txt");

Reads the entire file and returns it as a string.

B. Reading Function Used in My Project

ReadAllLines()

string[] lines = File.ReadAllLines(open.FileName);
listBox1.Items.AddRange(lines);

Reads all lines from a selected file and displays them in the ListBox.

C. Comparison of Reading Functions

Teacher's Functions| My Function
Read()| ReadAllLines()
ReadLine()| ReadAllLines()
ReadToEnd()| ReadAllLines()
ReadAllText()| ReadAllLines()

Differences:

- Read() reads one character, while ReadAllLines() reads all lines.
- ReadLine() reads one line, while ReadAllLines() reads all lines.
- ReadToEnd() returns remaining text as a string, while ReadAllLines() returns an array of strings.
- ReadAllText() returns the entire file as one string, while ReadAllLines() separates the content into lines.

---

3. DELETE FUNCTIONS

A. Delete Functions Explained by the Teacher

No specific delete functions are listed in the teacher's notes provided for this assignment.

B. Delete Functions Used in My Project

1. RemoveAt()

listBox1.Items.RemoveAt(listBox1.SelectedIndex);

Deletes one selected item from the ListBox.

2. Clear()

listBox1.Items.Clear();

Deletes all items from the ListBox.

C. Comparison of Delete Functions


Teacher's Functions| My Functions
Not specified in the notes| RemoveAt()
Not specified in the notes| Clear()

Differences:

- RemoveAt() deletes one selected item.
- Clear() deletes all items at once.
