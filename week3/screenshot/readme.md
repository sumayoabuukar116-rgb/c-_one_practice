1. First Image  - Nested If-Else StatementExplanation: 

This image demonstrates a nested if statement (an if statement placed inside another if statement). 

 How it works:First, it checks if the salary is greater than or equal to 40,000.

If that condition is true, it enters the inner block to check if the yearsOnJob is greater than or equal to 2.

If both conditions are met, it displays the message "You qualify for the load" in decisionLabel.Text.  
   
 The else blocks handle the cases where the respective requirements are not met (e.g., salary is too low or years on the job are insufficient). 

 ![Screenshot 1](screenshot/screenshot1.jpeg)


 2. Second Image  - If-Else-If Ladder (Grading System)Explanation:
 
  This shows an if-else-if ladder used to evaluate a student's test score and assign a letter grade (A, B, C, D, or F). 
  
How it works:It parses the score from a text box into an integer. 

  It checks the score sequentially: if it is $\ge 90$, the grade is "A"; if it is $\ge 80$, the grade is "B"; and so on down to the final else block which assigns "F" for scores below 60.

![Screenshot 2](screenshot/screenshot2.jpeg)  

3. Third Image  - Boolean Assignment Using If-ElseExplanation: 

This code checks a user's points to determine whether a boolean flag (isGrandMaster) should be set to true or false.

How it works:It reads the points from txtPoints.Text. 

 If the points are greater than 5000 (points > 5000), isGrandMaster becomes true.
  
 Otherwise, it becomes false. 
   
  Finally, it converts the boolean result to a string and displays it in lblResult.Text.

![Screenshot 3](screenshot/screenshot3.jpeg)


4. Fourth Image  - Working with ListBox (Selected Text & Count)Explanation: 

This image demonstrates two common ListBox operations:

Getting selected text: listBox1.Text retrieves the text of the currently selected item in the list box, which is then shown in a message box. 

 Getting total items: listBox1.Items.Count counts the total number of items present in the ListBox and displays the count. 

 ![Screenshot 4](screenshot/screenshot4.jpeg)

 5. Fifth Image  - Removing an Item from a ListBox (RemoveAt)Explanation: 
 
 This code shows how to safely delete an item from a ListBox based on the user's selection.
 
How it works:It checks if (listBox1.SelectedIndex != -1) to ensure that an actual item is selected (since -1 means no item is selected).

If an item is selected, it calls listBox1.Items.RemoveAt(listBox1.SelectedIndex) to delete it.

 If nothing is selected, it prompts the user with a warning message ("Please select an item to remove.").   

 ![Screenshot 5](screenshot/screenshot5.jpeg)