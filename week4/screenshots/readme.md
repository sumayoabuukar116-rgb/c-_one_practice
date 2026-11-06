1. While Loop Iteration Check :

 Shows a while loop where int count = 5; and the condition is while (count < 5). 
 
A red arrow points to the condition, noting that the loop's body will not iterate because 5 < 5 evaluates to false right away.  
![Screenshot 1](screenshots/screenshot1.jpeg)

2. Initializing Loop Variables: 

Demonstrates fixing the loop by initializing int count = 0; so that the condition count < 5 evaluates to true, allowing the loop to run.

   Shows the same structure with int count = 0; running a while loop that displays "Hello" in a message box. 
   ![Screenshot 2](screenshots/screenshot2.jpeg)

   3. Postfix vs. Prefix Increment Operators

 Compares two code blocks demonstrating how increment placement changes variable assignment:

Top block (Postfix x = count++;): Assigns the current value of count to x first, then increments count.

Bottom block (Prefix x = ++count;): Increments count first, then assigns the new updated value to x.
![Screenshot 3](screenshots/screenshot3.jpeg)

4. For Loop Declarations 

 Shows two ways to declare a for loop:

Declaring the counter variable beforehand (int count; followed by for (count = 0; ...)).

Declaring the counter variable directly inside the loop's initialization expression (for (int count = 0; ...)).

![Screenshot 4](screenshots/screenshot4.jpeg)

5. Advanced For Loops:

 Stepping and Counting Backward 
 
  Demonstrates incrementing by a custom step using count += 10 in a loop that runs up to 100.   

 Demonstrates counting backward by decrementing (count--) starting from 10 down to 0

 ![Screenshot 5](screenshots/screenshot5.jpeg)

 6. Do-While vs. While Loops 
  Asks "Will you see the message box?" comparing a do-while loop versus a regular while loop when number = 1 and the condition is number < 0:In the do-while loop, the code runs at least once before checking the condition at the bottom, so the message box will appear. 
  
 In the while loop, the condition is checked at the top before execution, so the message box will not appear

 ![Screenshot 6](screenshots/screenshot6.jpeg)


 Image 7    Counting backward in a for loop  
 
  This image demonstrates a countdown loop starting at 10 (int count = 10), running while count >= 0, and decrementing using count--
   ![Screenshot 7](screenshots/screenshot7.jpeg)

   Image 8  do-while vs. while loop behavior
   
       This image asks whether you will see a message box for two different loops where number = 1 and the condition is number < 0: 

      In the do-while loop, the code runs at least once before checking the condition at the bottom, so the message box will appear.  
      
       In the while loop, the condition is checked at the top first, so the message box will not appear

       Image 9    Creating and writing to a file   
       
        This image demonstrates file handling using StreamWriter and File.CreateText("courses.txt") to create a new text file, write three lines of course titles, and safely close the stream with outputFile.Close(). 

![Screenshot 9](screenshots/screenshot9.jpeg)


Image 10 

 Appending text to an existing file

 This image shows how to use File.AppendText("Names.txt") with a StreamWriter to add new text entries ("Lynn", "Jamal", "Alex") to the end of a file without overwriting its existing data.

 ![Screenshot 10](screenshots/screenshot10.jpeg)

Image 11: Different ways to read text files using StreamReader and File methods.   

Demonstrates that a StreamReader provides different methods such as ReadLine() (reads a single line), Read() (reads a single character as an integer), and ReadToEnd() (reads the entire text of the file at once).  

 Also shows that File.ReadAllText("lstcourse.doc") is a shortcut method to read all text from a file into a string variable or add it directly to a ListBox.

![Screenshot 11](screenshots/screenshot11.jpeg)

Image12  Reading a file until the end using a while loop and try-catch error handling.

   Uses a try-catch block to handle exceptions safely if the file cannot be found.  
   
    Uses a while (reader.EndOfStream == false) loop to continually read each line of the file and add it to listBox1 until it reaches the very end of the stream. 

![Screenshot 12](screenshots/screenshot12.jpeg)

    Image 13 : Checking the result of an OpenFileDialog.  
    
     Shows how to invoke openFileDialog.ShowDialog() and store the user's choice in a DialogResult variable. 

     Uses if (result == DialogResult.OK) to check if the user selected a file and clicked OK, and an else if statement to handle if they clicked Cancel.  

![Screenshot 13](screenshots/screenshot13.jpeg)

 Image 14 : Combining OpenFileDialog with file reading.  
 
After the user selects a file through the dialog, the program opens the file path using a StreamReader, reads the first line (ReadLine()), adds it to a ListBox, and closes the reader.

If the user clicks Cancel, it displays a message box saying "Wala Cancalay". 

![Screenshot 14](screenshots/screenshot14.jpeg)

Image 15: Retrieving the filename from an open file dialog. 

 Briefly demonstrates checking if openFileDialog.ShowDialog() == DialogResult.OK and then accessing the selected file path dynamically using openFileDialog.Filename inside File.OpenText(...).   

 ![Screenshot 15](screenshots/screenshot15.jpeg)

  Image 16: Reading all lines from a selected file using a while loop.  
  
   Opens the file path obtained from openFileDialog1.Filename and loops through the stream using reader.EndOfStream == false, reading and adding every line to listBox1 before closing the reader.  

  ![Screenshot 16](screenshots/screenshot16.jpeg) 

  Image 17 : Working with the SaveFileDialog control. 
  
   Explains how to call saveFileDialog.ShowDialog(), detect the user's choice using DialogResult.
   
   OK, and create a new file at the user-specified destination using File.CreateText(saveFileDialog.Filename).  

 ![Screenshot 17](screenshots/screenshot17.jpeg) 

 Image 18 : Writing data to a file chosen via SaveFileDialog. 
 
   If the user clicks OK on the save dialog, it creates a text file at the selected path, writes the text "Mohamed" into it using write.WriteLine(), and closes the file stream. 
   
     If the user cancels, it shows a message box saying "Wala Cancalay". 

![Screenshot 18](screenshots/screenshot18.jpeg) 

