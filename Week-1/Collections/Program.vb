Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        'Arrays, List, Dictionaries
        'Arrays in vb are zero based
        dim fruits() as string = {"banna", "apple", "mango"}
        dim fruits2(3) as String
        fruits2(0) = "kiwi"
        fruits2(1) = "strawberry"
        fruits(2) = "pineapple"

        'enhanced for look aka for each that is utilized to iterate over collections
        'Arrays are a homogenous collection of tems stored in a contiguous memory space
        'declare arrays by including () after the variable
        for Each fruit As String in fruits2 
            Console.WriteLine(fruit)
        Next 
        ' while arrays are cool adn they are staticly sized
        'Elements take o(1), its statically sized
        
        '============== List ============
        'have to declare the data type of lists
        'Lists are ordered collections of homogenous items
        'index based like arrays but they can change size
        dim students as New List(of String)
        students.add("Irving")
        students.add("Chase")
        students.add("Gavin")
        students.add("Amol")

        for each student as String in students
            Console.WriteLine(student)
        Next

        students(3) = "Amol Apte"
        Console.WriteLine(students(3))

        '=============Dictionary============
        'Hashtable
        'A collection of key value pairs 
        'access these values based on their keys
        'its quick 
        'index base and the index is defined 
        dim gradeBook as new Dictionary(of string, Integer)
        gradeBook.add("Justin", 95)
        gradeBook.add("Marielle", 100)

        Console.WriteLine("marielle got a grade of {0}", gradeBook("Marielle"))
        for Each grade As KeyValuePair(of String, Integer) In gradeBook
            Console.WriteLine("{0} got a grade of {1}", grade.Key, grade.Value)
        Next
    End Sub
End Module
